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
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.groupBoxJobID = new System.Windows.Forms.GroupBox();
            this.btnSetJobID = new System.Windows.Forms.Button();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTighteningData = new System.Windows.Forms.GroupBox();
            this.btnGetTighteningData = new System.Windows.Forms.Button();
            this.txtTighteningLog = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTighteningStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTorqueValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentJobID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxJobID.SuspendLayout();
            this.groupBoxTighteningData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.btnDisconnect);
            this.groupBoxConnection.Controls.Add(this.btnConnect);
            this.groupBoxConnection.Controls.Add(this.txtPort);
            this.groupBoxConnection.Controls.Add(this.txtIPAddress);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.lblConnectionStatus);
            this.groupBoxConnection.Location = new System.Drawing.Point(14, 15);
            this.groupBoxConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConnection.Size = new System.Drawing.Size(887, 100);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "연결 설정";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(651, 56);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(86, 29);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "연결 해제";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(559, 56);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 29);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(246, 59);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(114, 25);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "4545";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(89, 59);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(114, 25);
            this.txtIPAddress.TabIndex = 3;
            this.txtIPAddress.Text = "192.168.1.100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "포트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP 주소";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(7, 25);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(121, 15);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "연결 상태: 끊김";
            // 
            // groupBoxJobID
            // 
            this.groupBoxJobID.Controls.Add(this.btnSetJobID);
            this.groupBoxJobID.Controls.Add(this.txtJobID);
            this.groupBoxJobID.Controls.Add(this.label3);
            this.groupBoxJobID.Enabled = false;
            this.groupBoxJobID.Location = new System.Drawing.Point(14, 122);
            this.groupBoxJobID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxJobID.Name = "groupBoxJobID";
            this.groupBoxJobID.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxJobID.Size = new System.Drawing.Size(887, 75);
            this.groupBoxJobID.TabIndex = 1;
            this.groupBoxJobID.TabStop = false;
            this.groupBoxJobID.Text = "Job ID 설정";
            // 
            // btnSetJobID
            // 
            this.btnSetJobID.Location = new System.Drawing.Point(246, 31);
            this.btnSetJobID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetJobID.Name = "btnSetJobID";
            this.btnSetJobID.Size = new System.Drawing.Size(86, 29);
            this.btnSetJobID.TabIndex = 2;
            this.btnSetJobID.Text = "설정";
            this.btnSetJobID.UseVisualStyleBackColor = true;
            this.btnSetJobID.Click += new System.EventHandler(this.btnSetJobID_Click);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(89, 34);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(114, 25);
            this.txtJobID.TabIndex = 1;
            this.txtJobID.Text = "1001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job ID";
            // 
            // groupBoxTighteningData
            // 
            this.groupBoxTighteningData.Controls.Add(this.btnGetTighteningData);
            this.groupBoxTighteningData.Controls.Add(this.txtTighteningLog);
            this.groupBoxTighteningData.Controls.Add(this.label8);
            this.groupBoxTighteningData.Controls.Add(this.lblTighteningStatus);
            this.groupBoxTighteningData.Controls.Add(this.label7);
            this.groupBoxTighteningData.Controls.Add(this.lblTorqueValue);
            this.groupBoxTighteningData.Controls.Add(this.label5);
            this.groupBoxTighteningData.Controls.Add(this.lblCurrentJobID);
            this.groupBoxTighteningData.Controls.Add(this.label4);
            this.groupBoxTighteningData.Enabled = false;
            this.groupBoxTighteningData.Location = new System.Drawing.Point(14, 205);
            this.groupBoxTighteningData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTighteningData.Name = "groupBoxTighteningData";
            this.groupBoxTighteningData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTighteningData.Size = new System.Drawing.Size(887, 342);
            this.groupBoxTighteningData.TabIndex = 2;
            this.groupBoxTighteningData.TabStop = false;
            this.groupBoxTighteningData.Text = "조임 데이터";
            // 
            // btnGetTighteningData
            // 
            this.btnGetTighteningData.Location = new System.Drawing.Point(10, 178);
            this.btnGetTighteningData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetTighteningData.Name = "btnGetTighteningData";
            this.btnGetTighteningData.Size = new System.Drawing.Size(137, 29);
            this.btnGetTighteningData.TabIndex = 10;
            this.btnGetTighteningData.Text = "조임 데이터 요청";
            this.btnGetTighteningData.UseVisualStyleBackColor = true;
            this.btnGetTighteningData.Click += new System.EventHandler(this.btnGetTighteningData_Click);
            // 
            // txtTighteningLog
            // 
            this.txtTighteningLog.Location = new System.Drawing.Point(10, 232);
            this.txtTighteningLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTighteningLog.Name = "txtTighteningLog";
            this.txtTighteningLog.ReadOnly = true;
            this.txtTighteningLog.Size = new System.Drawing.Size(869, 102);
            this.txtTighteningLog.TabIndex = 9;
            this.txtTighteningLog.Text = "";
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
            // lblTighteningStatus
            // 
            this.lblTighteningStatus.AutoSize = true;
            this.lblTighteningStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTighteningStatus.Location = new System.Drawing.Point(88, 101);
            this.lblTighteningStatus.Name = "lblTighteningStatus";
            this.lblTighteningStatus.Size = new System.Drawing.Size(16, 15);
            this.lblTighteningStatus.TabIndex = 7;
            this.lblTighteningStatus.Text = "-";
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
            // lblTorqueValue
            // 
            this.lblTorqueValue.AutoSize = true;
            this.lblTorqueValue.Location = new System.Drawing.Point(89, 66);
            this.lblTorqueValue.Name = "lblTorqueValue";
            this.lblTorqueValue.Size = new System.Drawing.Size(15, 15);
            this.lblTorqueValue.TabIndex = 3;
            this.lblTorqueValue.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "토크 값";
            // 
            // lblCurrentJobID
            // 
            this.lblCurrentJobID.AutoSize = true;
            this.lblCurrentJobID.Location = new System.Drawing.Point(89, 29);
            this.lblCurrentJobID.Name = "lblCurrentJobID";
            this.lblCurrentJobID.Size = new System.Drawing.Size(15, 15);
            this.lblCurrentJobID.TabIndex = 1;
            this.lblCurrentJobID.Text = "-";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBoxTighteningData);
            this.Controls.Add(this.groupBoxJobID);
            this.Controls.Add(this.groupBoxConnection);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Power Focus 8 Open Protocol Client";
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxJobID.ResumeLayout(false);
            this.groupBoxJobID.PerformLayout();
            this.groupBoxTighteningData.ResumeLayout(false);
            this.groupBoxTighteningData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox groupBoxJobID;
        private System.Windows.Forms.Button btnSetJobID;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTighteningData;
        private System.Windows.Forms.Button btnGetTighteningData;
        private System.Windows.Forms.RichTextBox txtTighteningLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTighteningStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTorqueValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentJobID;
        private System.Windows.Forms.Label label4;
    }
}