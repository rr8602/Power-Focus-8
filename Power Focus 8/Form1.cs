using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Focus_8
{
    public partial class Form1 : Form
    {
        private OpenProtocolClient client;
        private TighteningResult result = new TighteningResult();

        public Form1()
        {
            InitializeComponent();
            InitializeClient();
        }

        private void InitializeClient()
        {
            client = new OpenProtocolClient();
            client.ConnectionChanged += Client_ConnectionChanged;
            client.MessageReceived += Client_MessageReceived;
        }

        // Job Info 구독 설정
        private async void JobInfoSubscribe()
        {
            string message = OpenProtocolMessage.CreateMessage(34);
            await client.SendMessageAsync(message);
        }

        private void Client_ConnectionChanged(object sender, bool isConnected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, bool>(Client_ConnectionChanged), sender, isConnected);
                return;
            }

            lblConnectionStatus.Text = $"연결 상태: {(isConnected ? "연결됨" : "끊김")}";
            lblConnectionStatus.ForeColor = isConnected ? Color.Green : Color.Red;

            btnConnect.Enabled = !isConnected;
            btnDisconnect.Enabled = isConnected;
            groupBoxJobID.Enabled = isConnected;
            groupBoxTighteningData.Enabled = isConnected;
        }

        private void Client_MessageReceived(object sender, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, string>(Client_MessageReceived), sender, message);
                return;
            }

            txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 수신: {message}\n");
            txtTighteningLog.ScrollToCaret();

            ProcessReceivedMessage(message);
        }

        private void ProcessReceivedMessage(string message)
        {
            var protocolMessage = OpenProtocolMessage.Parse(message);
            if (protocolMessage == null) return;

            switch (protocolMessage.MID)
            {
                case 35: // job id 설정 응답 - MID 0035
                    ProcessJobIDAck(protocolMessage.Data);
                    break;
                case 61: // 조임 결과 데이터 - MID 0061
                    ProcessTighteningResult(protocolMessage.Data);
                    break;
                case 4: // 에러 메시지 - MID 0004
                    MessageBox.Show($"명령 오류가 발생했습니다: {protocolMessage.Data}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ProcessTighteningResult(string data)
        {
            try
            {
                // 필드 파싱
                result.TorqueValue = 0.0;
                result.SecondTorqueValue = 0.0;

                if (data.Substring(162, 2) == "24")
                {
                    if (double.TryParse(data.Substring(164, 6), out double firstTorque))
                    {
                        result.TorqueValue = firstTorque / 100;
                    }

                    if (double.TryParse(data.Substring(170, 10).Trim(), out double secondTorque))
                    {
                        result.SecondTorqueValue = secondTorque / 100;
                    }
                }

                result.TighteningStatus = data.Substring(86, 2) == "09" ? int.Parse(data.Substring(88, 1)) : 0; // OK / NG

                // UI 업데이트
                double totalTorque = result.TorqueValue + result.SecondTorqueValue;
                lblTorqueValue.Text = $"{totalTorque:F2} Nm";

                bool isOK = result.TighteningStatus == 1;
                lblTighteningStatus.Text = isOK ? "OK" : "NOK";
                lblTighteningStatus.ForeColor = isOK ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - MID 61 데이터 파싱 오류: {ex.Message} - 데이터: {data}\n");
            }
        }

        private void ProcessJobIDAck(string data)
        {
            result.JobID = data.Substring(85, 2) == "05" ? int.Parse(data.Substring(87, 2)) : 0; // Job ID
            lblCurrentJobID.Text = result.JobID.ToString(); // Job ID 설정
            txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - Job ID 설정 완료\n");
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text.Trim();

            if (!int.TryParse(txtPort.Text.Trim(), out int port))
            {
                MessageBox.Show("유효한 포트 번호를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConnect.Enabled = false;
            txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 시도: {ipAddress}:{port}\n");

            bool connected = await client.ConnectAsync(ipAddress, port);

            if (!connected)
            {
                MessageBox.Show("연결에 실패했습니다.", "연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConnect.Enabled = true;
            }
            else
            {
                txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 성공\n");

                // 연결 후 통신 시작 메시지 전송 (MID 1)
                string startMessage = OpenProtocolMessage.CreateMessage(1);
                await client.SendMessageAsync(startMessage);
                txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: {startMessage}\n");
            }

            JobInfoSubscribe();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 해제\n");
        }

        private async void btnSetJobID_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                MessageBox.Show("먼저 연결하세요.", "연결 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtJobID.Text = lblCurrentJobID.Text;
            string jobID = txtJobID.Text.Trim();

            if (string.IsNullOrEmpty(jobID))
            {
                MessageBox.Show("Job ID를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // MID 38: Job ID 설정
            string message = OpenProtocolMessage.CreateMessage(38, 1, jobID);
            bool sent = await client.SendMessageAsync(message);

            if (sent)
            {
                txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: Job ID 설정 - {jobID}\n");
            }
            else
            {
                MessageBox.Show("메시지 전송에 실패했습니다.", "전송 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetTighteningData_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected)
            {
                MessageBox.Show("먼저 연결하세요.", "연결 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // MID 60: 조임 결과 구독
            string message = OpenProtocolMessage.CreateMessage(60);
            bool sent = await client.SendMessageAsync(message);

            if (sent)
            {
                txtTighteningLog.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: 조임 데이터 구독 요청\n");
            }
            else
            {
                MessageBox.Show("메시지 전송에 실패했습니다.", "전송 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client?.Disconnect();
            base.OnFormClosing(e);
        }
    }
}