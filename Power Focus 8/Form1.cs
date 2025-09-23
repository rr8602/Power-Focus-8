using System;
using System.Drawing;
using System.Windows.Forms;

namespace Power_Focus_8
{
    public partial class Form1 : Form
    {
        private OpenProtocolClient client1;
        private OpenProtocolClient client2;
        private TighteningResult result1 = new TighteningResult();
        private TighteningResult result2 = new TighteningResult();

        public Form1()
        {
            InitializeComponent();
            InitializeClients();
        }

        private void InitializeClients()
        {
            client1 = new OpenProtocolClient();
            client1.ConnectionChanged += Client1_ConnectionChanged;
            client1.MessageReceived += Client1_MessageReceived;

            client2 = new OpenProtocolClient();
            client2.ConnectionChanged += Client2_ConnectionChanged;
            client2.MessageReceived += Client2_MessageReceived;
        }

        // Client 1 Event Handlers
        private void Client1_ConnectionChanged(object sender, bool isConnected)
        {
            UpdateConnectionStatus(1, isConnected);
        }

        private void Client1_MessageReceived(object sender, string message)
        {
            ProcessReceivedMessage(1, message);
        }

        // Client 2 Event Handlers
        private void Client2_ConnectionChanged(object sender, bool isConnected)
        {
            UpdateConnectionStatus(2, isConnected);
        }

        private void Client2_MessageReceived(object sender, string message)
        {
            ProcessReceivedMessage(2, message);
        }

        private void UpdateConnectionStatus(int clientNumber, bool isConnected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int, bool>(UpdateConnectionStatus), clientNumber, isConnected);
                return;
            }

            if (clientNumber == 1)
            {
                lblConnectionStatus1.Text = $"연결 상태: {(isConnected ? "연결됨" : "끊김")}";
                lblConnectionStatus1.ForeColor = isConnected ? Color.Green : Color.Red;
                btnConnect1.Enabled = !isConnected;
                btnDisconnect1.Enabled = isConnected;
                groupBoxJobID1.Enabled = isConnected;
                groupBoxTighteningData1.Enabled = isConnected;
            }
            else if (clientNumber == 2)
            {
                lblConnectionStatus2.Text = $"연결 상태: {(isConnected ? "연결됨" : "끊김")}";
                lblConnectionStatus2.ForeColor = isConnected ? Color.Green : Color.Red;
                btnConnect2.Enabled = !isConnected;
                btnDisconnect2.Enabled = isConnected;
                groupBoxJobID2.Enabled = isConnected;
                groupBoxTighteningData2.Enabled = isConnected;
            }
        }

        private void ProcessReceivedMessage(int clientNumber, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int, string>(ProcessReceivedMessage), clientNumber, message);
                return;
            }

            RichTextBox log = (clientNumber == 1) ? txtTighteningLog1 : txtTighteningLog2;
            log.AppendText($"{DateTime.Now:HH:mm:ss} - 수신: {message}\n");
            log.ScrollToCaret();

            var protocolMessage = OpenProtocolMessage.Parse(message);
            if (protocolMessage == null) return;

            switch (protocolMessage.MID)
            {
                case 35: // job id 설정 응답 - MID 0035
                    ProcessJobIDAck(clientNumber, protocolMessage.Data);
                    break;
                case 61: // 조임 결과 데이터 - MID 0061
                    ProcessTighteningResult(clientNumber, protocolMessage.Data);
                    break;
                case 4: // 에러 메시지 - MID 0004
                    MessageBox.Show($"명령 오류가 발생했습니다: {protocolMessage.Data}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ProcessTighteningResult(int clientNumber, string data)
        {
            try
            {
                TighteningResult result = (clientNumber == 1) ? result1 : result2;
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

                result.TighteningStatus = (data.Substring(86, 2) == "09") ? int.Parse(data.Substring(88, 1)) : 0;

                // Update UI
                if (clientNumber == 1)
                {
                    lblTorqueValue1_1.Text = $"{result.TorqueValue:F2} Nm";
                    lblTorqueValue1_2.Text = $"{result.SecondTorqueValue:F2} Nm";
                    bool isOK = result.TighteningStatus == 1;
                    lblTighteningStatus1.Text = isOK ? "OK" : "NOK";
                    lblTighteningStatus1.ForeColor = isOK ? Color.Green : Color.Red;
                }
                else if (clientNumber == 2)
                {
                    lblTorqueValue2_1.Text = $"{result.TorqueValue:F2} Nm";
                    lblTorqueValue2_2.Text = $"{result.SecondTorqueValue:F2} Nm";
                    bool isOK = result.TighteningStatus == 1;
                    lblTighteningStatus2.Text = isOK ? "OK" : "NOK";
                    lblTighteningStatus2.ForeColor = isOK ? Color.Green : Color.Red;
                }
            }
            catch (Exception ex)
            {
                RichTextBox log = (clientNumber == 1) ? txtTighteningLog1 : txtTighteningLog2;
                log.AppendText($"{DateTime.Now:HH:mm:ss} - MID 61 데이터 파싱 오류: {ex.Message} - 데이터: {data}\n");
            }
        }

        private void ProcessJobIDAck(int clientNumber, string data)
        {
            TighteningResult result = (clientNumber == 1) ? result1 : result2;
            result.JobID = data.Substring(85, 2) == "05" ? int.Parse(data.Substring(87, 2)) : 0; // Job ID

            if (clientNumber == 1)
            {
                lblCurrentJobID1.Text = result.JobID.ToString(); // Job ID 설정
                txtTighteningLog1.AppendText($"{DateTime.Now:HH:mm:ss} - Job ID 설정 완료\n");
            }
            else if (clientNumber == 2)
            {
                lblCurrentJobID2.Text = result.JobID.ToString(); // Job ID 설정
                txtTighteningLog2.AppendText($"{DateTime.Now:HH:mm:ss} - Job ID 설정 완료\n");
            }
        }

        private async void btnConnect1_Click(object sender, EventArgs e)
        {
            await ConnectClient(1, txtIPAddress1.Text, txtPort1.Text, btnConnect1, txtTighteningLog1);
        }

        private async void btnConnect2_Click(object sender, EventArgs e)
        {
            await ConnectClient(2, txtIPAddress2.Text, txtPort2.Text, btnConnect2, txtTighteningLog2);
        }

        private async System.Threading.Tasks.Task ConnectClient(int clientNumber, string ipAddress, string portText, Button connectButton, RichTextBox log)
        {
            if (!int.TryParse(portText.Trim(), out int port))
            {
                MessageBox.Show("유효한 포트 번호를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connectButton.Enabled = false;
            log.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 시도: {ipAddress}:{port}\n");

            OpenProtocolClient client = (clientNumber == 1) ? client1 : client2;
            bool connected = await client.ConnectAsync(ipAddress.Trim(), port);

            if (!connected)
            {
                MessageBox.Show("연결에 실패했습니다.", "연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectButton.Enabled = true;
            }
            else
            {
                log.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 성공\n");

                // 연결 후 통신 시작 메시지 전송 (MID 1)
                string startMessage = OpenProtocolMessage.CreateMessage(1);
                await client.SendMessageAsync(startMessage);
                log.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: {startMessage}\n");

                // Job Info 구독 설정
                string jobInfoMessage = OpenProtocolMessage.CreateMessage(34);
                await client.SendMessageAsync(jobInfoMessage);
            }
        }

        private void btnDisconnect1_Click(object sender, EventArgs e)
        {
            client1.Disconnect();
            txtTighteningLog1.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 해제\n");
        }

        private void btnDisconnect2_Click(object sender, EventArgs e)
        {
            client2.Disconnect();
            txtTighteningLog2.AppendText($"{DateTime.Now:HH:mm:ss} - 연결 해제\n");
        }

        private async void btnSetJobID1_Click(object sender, EventArgs e)
        {
            await SetJobId(1, client1, txtJobID1, lblCurrentJobID1, txtTighteningLog1);
        }

        private async void btnSetJobID2_Click(object sender, EventArgs e)
        {
            await SetJobId(2, client2, txtJobID2, lblCurrentJobID2, txtTighteningLog2);
        }

        private async System.Threading.Tasks.Task SetJobId(int clientNumber, OpenProtocolClient client, TextBox txtJob, Label lblJob, RichTextBox log)
        {
            if (!client.IsConnected)
            {
                MessageBox.Show("먼저 연결하세요.", "연결 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtJob.Text = lblJob.Text;
            string jobID = txtJob.Text.Trim();

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
                log.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: Job ID 설정 - {jobID}\n");
            }
            else
            {
                MessageBox.Show("메시지 전송에 실패했습니다.", "전송 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetTighteningData1_Click(object sender, EventArgs e)
        {
            await GetTighteningData(client1, txtTighteningLog1);
        }

        private async void btnGetTighteningData2_Click(object sender, EventArgs e)
        {
            await GetTighteningData(client2, txtTighteningLog2);
        }

        private async System.Threading.Tasks.Task GetTighteningData(OpenProtocolClient client, RichTextBox log)
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
                log.AppendText($"{DateTime.Now:HH:mm:ss} - 송신: 조임 데이터 구독 요청\n");
            }
            else
            {
                MessageBox.Show("메시지 전송에 실패했습니다.", "전송 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client1?.Disconnect();
            client2?.Disconnect();
            base.OnFormClosing(e);
        }
    }
}