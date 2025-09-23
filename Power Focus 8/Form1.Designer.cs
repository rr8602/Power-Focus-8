namespace Power_Focus_8
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConnection1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect1 = new System.Windows.Forms.Button();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.txtPort1 = new System.Windows.Forms.TextBox();
            this.txtIPAddress1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectionStatus1 = new System.Windows.Forms.Label();
            this.groupBoxJobID1 = new System.Windows.Forms.GroupBox();
            this.btnSetJobID1 = new System.Windows.Forms.Button();
            this.txtJobID1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTighteningData1 = new System.Windows.Forms.GroupBox();
            this.lblTorqueValue1_2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGetTighteningData1 = new System.Windows.Forms.Button();
            this.txtTighteningLog1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTighteningStatus1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTorqueValue1_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentJobID1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxConnection2 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.txtIPAddress2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblConnectionStatus2 = new System.Windows.Forms.Label();
            this.groupBoxJobID2 = new System.Windows.Forms.GroupBox();
            this.btnSetJobID2 = new System.Windows.Forms.Button();
            this.txtJobID2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxTighteningData2 = new System.Windows.Forms.GroupBox();
            this.lblTorqueValue2_2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGetTighteningData2 = new System.Windows.Forms.Button();
            this.txtTighteningLog2 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTighteningStatus2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTorqueValue2_1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCurrentJobID2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxConnection1.SuspendLayout();
            this.groupBoxJobID1.SuspendLayout();
            this.groupBoxTighteningData1.SuspendLayout();
            this.groupBoxConnection2.SuspendLayout();
            this.groupBoxJobID2.SuspendLayout();
            this.groupBoxTighteningData2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnection1
            // 
            this.groupBoxConnection1.Controls.Add(this.btnDisconnect1);
            this.groupBoxConnection1.Controls.Add(this.btnConnect1);
            this.groupBoxConnection1.Controls.Add(this.txtPort1);
            this.groupBoxConnection1.Controls.Add(this.txtIPAddress1);
            this.groupBoxConnection1.Controls.Add(this.label2);
            this.groupBoxConnection1.Controls.Add(this.label1);
            this.groupBoxConnection1.Controls.Add(this.lblConnectionStatus1);
            this.groupBoxConnection1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection1.Name = "groupBoxConnection1";
            this.groupBoxConnection1.Size = new System.Drawing.Size(440, 100);
            this.groupBoxConnection1.TabIndex = 0;
            this.groupBoxConnection1.TabStop = false;
            this.groupBoxConnection1.Text = "연결 설정 1";
            // 
            // btnDisconnect1
            // 
            this.btnDisconnect1.Enabled = false;
            this.btnDisconnect1.Location = new System.Drawing.Point(348, 56);
            this.btnDisconnect1.Name = "btnDisconnect1";
            this.btnDisconnect1.Size = new System.Drawing.Size(86, 29);
            this.btnDisconnect1.TabIndex = 6;
            this.btnDisconnect1.Text = "연결 해제";
            this.btnDisconnect1.UseVisualStyleBackColor = true;
            this.btnDisconnect1.Click += new System.EventHandler(this.btnDisconnect1_Click);
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(256, 56);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(86, 29);
            this.btnConnect1.TabIndex = 5;
            this.btnConnect1.Text = "연결";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // txtPort1
            // 
            this.txtPort1.Location = new System.Drawing.Point(136, 59);
            this.txtPort1.Name = "txtPort1";
            this.txtPort1.Size = new System.Drawing.Size(114, 25);
            this.txtPort1.TabIndex = 4;
            this.txtPort1.Text = "4545";
            // 
            // txtIPAddress1
            // 
            this.txtIPAddress1.Location = new System.Drawing.Point(6, 59);
            this.txtIPAddress1.Name = "txtIPAddress1";
            this.txtIPAddress1.Size = new System.Drawing.Size(114, 25);
            this.txtIPAddress1.TabIndex = 3;
            this.txtIPAddress1.Text = "192.168.1.100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "포트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP 주소";
            // 
            // lblConnectionStatus1
            // 
            this.lblConnectionStatus1.AutoSize = true;
            this.lblConnectionStatus1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConnectionStatus1.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus1.Location = new System.Drawing.Point(6, 22);
            this.lblConnectionStatus1.Name = "lblConnectionStatus1";
            this.lblConnectionStatus1.Size = new System.Drawing.Size(121, 15);
            this.lblConnectionStatus1.TabIndex = 0;
            this.lblConnectionStatus1.Text = "연결 상태: 끊김";
            // 
            // groupBoxJobID1
            // 
            this.groupBoxJobID1.Controls.Add(this.btnSetJobID1);
            this.groupBoxJobID1.Controls.Add(this.txtJobID1);
            this.groupBoxJobID1.Controls.Add(this.label3);
            this.groupBoxJobID1.Enabled = false;
            this.groupBoxJobID1.Location = new System.Drawing.Point(12, 118);
            this.groupBoxJobID1.Name = "groupBoxJobID1";
            this.groupBoxJobID1.Size = new System.Drawing.Size(440, 75);
            this.groupBoxJobID1.TabIndex = 1;
            this.groupBoxJobID1.TabStop = false;
            this.groupBoxJobID1.Text = "Job ID 설정 1";
            // 
            // btnSetJobID1
            // 
            this.btnSetJobID1.Location = new System.Drawing.Point(136, 31);
            this.btnSetJobID1.Name = "btnSetJobID1";
            this.btnSetJobID1.Size = new System.Drawing.Size(86, 29);
            this.btnSetJobID1.TabIndex = 2;
            this.btnSetJobID1.Text = "설정";
            this.btnSetJobID1.UseVisualStyleBackColor = true;
            this.btnSetJobID1.Click += new System.EventHandler(this.btnSetJobID1_Click);
            // 
            // txtJobID1
            // 
            this.txtJobID1.Location = new System.Drawing.Point(6, 34);
            this.txtJobID1.Name = "txtJobID1";
            this.txtJobID1.Size = new System.Drawing.Size(114, 25);
            this.txtJobID1.TabIndex = 1;
            this.txtJobID1.Text = "1001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job ID";
            // 
            // groupBoxTighteningData1
            // 
            this.groupBoxTighteningData1.Controls.Add(this.lblTorqueValue1_2);
            this.groupBoxTighteningData1.Controls.Add(this.label9);
            this.groupBoxTighteningData1.Controls.Add(this.btnGetTighteningData1);
            this.groupBoxTighteningData1.Controls.Add(this.txtTighteningLog1);
            this.groupBoxTighteningData1.Controls.Add(this.label8);
            this.groupBoxTighteningData1.Controls.Add(this.lblTighteningStatus1);
            this.groupBoxTighteningData1.Controls.Add(this.label7);
            this.groupBoxTighteningData1.Controls.Add(this.lblTorqueValue1_1);
            this.groupBoxTighteningData1.Controls.Add(this.label5);
            this.groupBoxTighteningData1.Controls.Add(this.lblCurrentJobID1);
            this.groupBoxTighteningData1.Controls.Add(this.label4);
            this.groupBoxTighteningData1.Enabled = false;
            this.groupBoxTighteningData1.Location = new System.Drawing.Point(12, 199);
            this.groupBoxTighteningData1.Name = "groupBoxTighteningData1";
            this.groupBoxTighteningData1.Size = new System.Drawing.Size(440, 351);
            this.groupBoxTighteningData1.TabIndex = 2;
            this.groupBoxTighteningData1.TabStop = false;
            this.groupBoxTighteningData1.Text = "조임 데이터 1";
            // 
            // lblTorqueValue1_2
            // 
            this.lblTorqueValue1_2.AutoSize = true;
            this.lblTorqueValue1_2.Location = new System.Drawing.Point(237, 66);
            this.lblTorqueValue1_2.Name = "lblTorqueValue1_2";
            this.lblTorqueValue1_2.Size = new System.Drawing.Size(15, 15);
            this.lblTorqueValue1_2.TabIndex = 12;
            this.lblTorqueValue1_2.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "토크 값2";
            // 
            // btnGetTighteningData1
            // 
            this.btnGetTighteningData1.Location = new System.Drawing.Point(10, 178);
            this.btnGetTighteningData1.Name = "btnGetTighteningData1";
            this.btnGetTighteningData1.Size = new System.Drawing.Size(137, 29);
            this.btnGetTighteningData1.TabIndex = 10;
            this.btnGetTighteningData1.Text = "조임 데이터 요청";
            this.btnGetTighteningData1.UseVisualStyleBackColor = true;
            this.btnGetTighteningData1.Click += new System.EventHandler(this.btnGetTighteningData1_Click);
            // 
            // txtTighteningLog1
            // 
            this.txtTighteningLog1.Location = new System.Drawing.Point(10, 232);
            this.txtTighteningLog1.Name = "txtTighteningLog1";
            this.txtTighteningLog1.ReadOnly = true;
            this.txtTighteningLog1.Size = new System.Drawing.Size(424, 113);
            this.txtTighteningLog1.TabIndex = 9;
            this.txtTighteningLog1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "수신 로그";
            // 
            // lblTighteningStatus1
            // 
            this.lblTighteningStatus1.AutoSize = true;
            this.lblTighteningStatus1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTighteningStatus1.Location = new System.Drawing.Point(88, 101);
            this.lblTighteningStatus1.Name = "lblTighteningStatus1";
            this.lblTighteningStatus1.Size = new System.Drawing.Size(16, 15);
            this.lblTighteningStatus1.TabIndex = 7;
            this.lblTighteningStatus1.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "조임 상태";
            // 
            // lblTorqueValue1_1
            // 
            this.lblTorqueValue1_1.AutoSize = true;
            this.lblTorqueValue1_1.Location = new System.Drawing.Point(89, 66);
            this.lblTorqueValue1_1.Name = "lblTorqueValue1_1";
            this.lblTorqueValue1_1.Size = new System.Drawing.Size(15, 15);
            this.lblTorqueValue1_1.TabIndex = 3;
            this.lblTorqueValue1_1.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "토크 값1";
            // 
            // lblCurrentJobID1
            // 
            this.lblCurrentJobID1.AutoSize = true;
            this.lblCurrentJobID1.Location = new System.Drawing.Point(89, 29);
            this.lblCurrentJobID1.Name = "lblCurrentJobID1";
            this.lblCurrentJobID1.Size = new System.Drawing.Size(15, 15);
            this.lblCurrentJobID1.TabIndex = 1;
            this.lblCurrentJobID1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job ID";
            // 
            // groupBoxConnection2
            // 
            this.groupBoxConnection2.Controls.Add(this.btnDisconnect2);
            this.groupBoxConnection2.Controls.Add(this.btnConnect2);
            this.groupBoxConnection2.Controls.Add(this.txtPort2);
            this.groupBoxConnection2.Controls.Add(this.txtIPAddress2);
            this.groupBoxConnection2.Controls.Add(this.label10);
            this.groupBoxConnection2.Controls.Add(this.label11);
            this.groupBoxConnection2.Controls.Add(this.lblConnectionStatus2);
            this.groupBoxConnection2.Location = new System.Drawing.Point(458, 12);
            this.groupBoxConnection2.Name = "groupBoxConnection2";
            this.groupBoxConnection2.Size = new System.Drawing.Size(440, 100);
            this.groupBoxConnection2.TabIndex = 7;
            this.groupBoxConnection2.TabStop = false;
            this.groupBoxConnection2.Text = "연결 설정 2";
            // 
            // btnDisconnect2
            // 
            this.btnDisconnect2.Enabled = false;
            this.btnDisconnect2.Location = new System.Drawing.Point(348, 56);
            this.btnDisconnect2.Name = "btnDisconnect2";
            this.btnDisconnect2.Size = new System.Drawing.Size(86, 29);
            this.btnDisconnect2.TabIndex = 6;
            this.btnDisconnect2.Text = "연결 해제";
            this.btnDisconnect2.UseVisualStyleBackColor = true;
            this.btnDisconnect2.Click += new System.EventHandler(this.btnDisconnect2_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(256, 56);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(86, 29);
            this.btnConnect2.TabIndex = 5;
            this.btnConnect2.Text = "연결";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(136, 59);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(114, 25);
            this.txtPort2.TabIndex = 4;
            this.txtPort2.Text = "4545";
            // 
            // txtIPAddress2
            // 
            this.txtIPAddress2.Location = new System.Drawing.Point(6, 59);
            this.txtIPAddress2.Name = "txtIPAddress2";
            this.txtIPAddress2.Size = new System.Drawing.Size(114, 25);
            this.txtIPAddress2.TabIndex = 3;
            this.txtIPAddress2.Text = "192.168.1.101";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "포트";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "IP 주소";
            // 
            // lblConnectionStatus2
            // 
            this.lblConnectionStatus2.AutoSize = true;
            this.lblConnectionStatus2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConnectionStatus2.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus2.Location = new System.Drawing.Point(6, 22);
            this.lblConnectionStatus2.Name = "lblConnectionStatus2";
            this.lblConnectionStatus2.Size = new System.Drawing.Size(121, 15);
            this.lblConnectionStatus2.TabIndex = 0;
            this.lblConnectionStatus2.Text = "연결 상태: 끊김";
            // 
            // groupBoxJobID2
            // 
            this.groupBoxJobID2.Controls.Add(this.btnSetJobID2);
            this.groupBoxJobID2.Controls.Add(this.txtJobID2);
            this.groupBoxJobID2.Controls.Add(this.label12);
            this.groupBoxJobID2.Enabled = false;
            this.groupBoxJobID2.Location = new System.Drawing.Point(458, 118);
            this.groupBoxJobID2.Name = "groupBoxJobID2";
            this.groupBoxJobID2.Size = new System.Drawing.Size(440, 75);
            this.groupBoxJobID2.TabIndex = 8;
            this.groupBoxJobID2.TabStop = false;
            this.groupBoxJobID2.Text = "Job ID 설정 2";
            // 
            // btnSetJobID2
            // 
            this.btnSetJobID2.Location = new System.Drawing.Point(136, 31);
            this.btnSetJobID2.Name = "btnSetJobID2";
            this.btnSetJobID2.Size = new System.Drawing.Size(86, 29);
            this.btnSetJobID2.TabIndex = 2;
            this.btnSetJobID2.Text = "설정";
            this.btnSetJobID2.UseVisualStyleBackColor = true;
            this.btnSetJobID2.Click += new System.EventHandler(this.btnSetJobID2_Click);
            // 
            // txtJobID2
            // 
            this.txtJobID2.Location = new System.Drawing.Point(6, 34);
            this.txtJobID2.Name = "txtJobID2";
            this.txtJobID2.Size = new System.Drawing.Size(114, 25);
            this.txtJobID2.TabIndex = 1;
            this.txtJobID2.Text = "1001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Job ID";
            // 
            // groupBoxTighteningData2
            // 
            this.groupBoxTighteningData2.Controls.Add(this.lblTorqueValue2_2);
            this.groupBoxTighteningData2.Controls.Add(this.label13);
            this.groupBoxTighteningData2.Controls.Add(this.btnGetTighteningData2);
            this.groupBoxTighteningData2.Controls.Add(this.txtTighteningLog2);
            this.groupBoxTighteningData2.Controls.Add(this.label14);
            this.groupBoxTighteningData2.Controls.Add(this.lblTighteningStatus2);
            this.groupBoxTighteningData2.Controls.Add(this.label15);
            this.groupBoxTighteningData2.Controls.Add(this.lblTorqueValue2_1);
            this.groupBoxTighteningData2.Controls.Add(this.label16);
            this.groupBoxTighteningData2.Controls.Add(this.lblCurrentJobID2);
            this.groupBoxTighteningData2.Controls.Add(this.label17);
            this.groupBoxTighteningData2.Enabled = false;
            this.groupBoxTighteningData2.Location = new System.Drawing.Point(458, 199);
            this.groupBoxTighteningData2.Name = "groupBoxTighteningData2";
            this.groupBoxTighteningData2.Size = new System.Drawing.Size(440, 351);
            this.groupBoxTighteningData2.TabIndex = 9;
            this.groupBoxTighteningData2.TabStop = false;
            this.groupBoxTighteningData2.Text = "조임 데이터 2";
            // 
            // lblTorqueValue2_2
            // 
            this.lblTorqueValue2_2.AutoSize = true;
            this.lblTorqueValue2_2.Location = new System.Drawing.Point(237, 66);
            this.lblTorqueValue2_2.Name = "lblTorqueValue2_2";
            this.lblTorqueValue2_2.Size = new System.Drawing.Size(15, 15);
            this.lblTorqueValue2_2.TabIndex = 12;
            this.lblTorqueValue2_2.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "토크 값2";
            // 
            // btnGetTighteningData2
            // 
            this.btnGetTighteningData2.Location = new System.Drawing.Point(10, 178);
            this.btnGetTighteningData2.Name = "btnGetTighteningData2";
            this.btnGetTighteningData2.Size = new System.Drawing.Size(137, 29);
            this.btnGetTighteningData2.TabIndex = 10;
            this.btnGetTighteningData2.Text = "조임 데이터 요청";
            this.btnGetTighteningData2.UseVisualStyleBackColor = true;
            this.btnGetTighteningData2.Click += new System.EventHandler(this.btnGetTighteningData2_Click);
            // 
            // txtTighteningLog2
            // 
            this.txtTighteningLog2.Location = new System.Drawing.Point(10, 232);
            this.txtTighteningLog2.Name = "txtTighteningLog2";
            this.txtTighteningLog2.ReadOnly = true;
            this.txtTighteningLog2.Size = new System.Drawing.Size(424, 113);
            this.txtTighteningLog2.TabIndex = 9;
            this.txtTighteningLog2.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "수신 로그";
            // 
            // lblTighteningStatus2
            // 
            this.lblTighteningStatus2.AutoSize = true;
            this.lblTighteningStatus2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTighteningStatus2.Location = new System.Drawing.Point(88, 101);
            this.lblTighteningStatus2.Name = "lblTighteningStatus2";
            this.lblTighteningStatus2.Size = new System.Drawing.Size(16, 15);
            this.lblTighteningStatus2.TabIndex = 7;
            this.lblTighteningStatus2.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "조임 상태";
            // 
            // lblTorqueValue2_1
            // 
            this.lblTorqueValue2_1.AutoSize = true;
            this.lblTorqueValue2_1.Location = new System.Drawing.Point(89, 66);
            this.lblTorqueValue2_1.Name = "lblTorqueValue2_1";
            this.lblTorqueValue2_1.Size = new System.Drawing.Size(15, 15);
            this.lblTorqueValue2_1.TabIndex = 3;
            this.lblTorqueValue2_1.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "토크 값1";
            // 
            // lblCurrentJobID2
            // 
            this.lblCurrentJobID2.AutoSize = true;
            this.lblCurrentJobID2.Location = new System.Drawing.Point(89, 29);
            this.lblCurrentJobID2.Name = "lblCurrentJobID2";
            this.lblCurrentJobID2.Size = new System.Drawing.Size(15, 15);
            this.lblCurrentJobID2.TabIndex = 1;
            this.lblCurrentJobID2.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Job ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBoxTighteningData2);
            this.Controls.Add(this.groupBoxJobID2);
            this.Controls.Add(this.groupBoxConnection2);
            this.Controls.Add(this.groupBoxTighteningData1);
            this.Controls.Add(this.groupBoxJobID1);
            this.Controls.Add(this.groupBoxConnection1);
            this.Name = "Form1";
            this.Text = "Power Focus 8 Open Protocol Client";
            this.groupBoxConnection1.ResumeLayout(false);
            this.groupBoxConnection1.PerformLayout();
            this.groupBoxJobID1.ResumeLayout(false);
            this.groupBoxJobID1.PerformLayout();
            this.groupBoxTighteningData1.ResumeLayout(false);
            this.groupBoxTighteningData1.PerformLayout();
            this.groupBoxConnection2.ResumeLayout(false);
            this.groupBoxConnection2.PerformLayout();
            this.groupBoxJobID2.ResumeLayout(false);
            this.groupBoxJobID2.PerformLayout();
            this.groupBoxTighteningData2.ResumeLayout(false);
            this.groupBoxTighteningData2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnection1;
        private System.Windows.Forms.Button btnDisconnect1;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.TextBox txtPort1;
        private System.Windows.Forms.TextBox txtIPAddress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionStatus1;
        private System.Windows.Forms.GroupBox groupBoxJobID1;
        private System.Windows.Forms.Button btnSetJobID1;
        private System.Windows.Forms.TextBox txtJobID1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTighteningData1;
        private System.Windows.Forms.Button btnGetTighteningData1;
        private System.Windows.Forms.RichTextBox txtTighteningLog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTighteningStatus1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTorqueValue1_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentJobID1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTorqueValue1_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxConnection2;
        private System.Windows.Forms.Button btnDisconnect2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.TextBox txtIPAddress2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblConnectionStatus2;
        private System.Windows.Forms.GroupBox groupBoxJobID2;
        private System.Windows.Forms.Button btnSetJobID2;
        private System.Windows.Forms.TextBox txtJobID2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxTighteningData2;
        private System.Windows.Forms.Label lblTorqueValue2_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGetTighteningData2;
        private System.Windows.Forms.RichTextBox txtTighteningLog2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTighteningStatus2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTorqueValue2_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCurrentJobID2;
        private System.Windows.Forms.Label label17;
    }
}