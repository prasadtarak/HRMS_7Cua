namespace CardReader
{
    partial class frmX628C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmX628C));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.txtMachineSN2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetGeneralLogData = new System.Windows.Forms.Button();
            this.btnClearGLog = new System.Windows.Forms.Button();
            this.btnGetDeviceStatus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuShow = new System.Windows.Forms.MenuItem();
            this.mnuHide = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuStart = new System.Windows.Forms.MenuItem();
            this.mnuStop = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 146);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 102);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblState);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(126, 41);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(138, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(224, 7);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(42, 7);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.201";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(42, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnRsConnect);
            this.tabPage2.Controls.Add(this.txtMachineSN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbBaudRate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbPort);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232/485";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(157, 36);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(75, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(320, 6);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(38, 20);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "MachineSN";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(180, 7);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "BaudRate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPort.Location = new System.Drawing.Point(45, 7);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.txtMachineSN2);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnUSBConnect);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(364, 76);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USBClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(126, 14);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "MachineSN";
            // 
            // txtMachineSN2
            // 
            this.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineSN2.Location = new System.Drawing.Point(195, 11);
            this.txtMachineSN2.Name = "txtMachineSN2";
            this.txtMachineSN2.Size = new System.Drawing.Size(27, 20);
            this.txtMachineSN2.TabIndex = 9;
            this.txtMachineSN2.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(13, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Virtual USBClient";
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(76, 36);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(75, 23);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvLogs);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 297);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download or Clear Attendance Records";
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLogs.GridLines = true;
            this.lvLogs.Location = new System.Drawing.Point(12, 19);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(632, 272);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Count";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EnrollNumber";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VerifyMode";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "InOutMode";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "WorkCode";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Reserved";
            this.columnHeader7.Width = 81;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 60000;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(6, 100);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 23);
            this.btnSettings.TabIndex = 76;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(127, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Clear all attendance logs.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(127, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Get the total of logs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(128, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Get attendance logs.";
            // 
            // btnGetGeneralLogData
            // 
            this.btnGetGeneralLogData.Location = new System.Drawing.Point(6, 18);
            this.btnGetGeneralLogData.Name = "btnGetGeneralLogData";
            this.btnGetGeneralLogData.Size = new System.Drawing.Size(111, 23);
            this.btnGetGeneralLogData.TabIndex = 70;
            this.btnGetGeneralLogData.Text = "DownloadAttLogs";
            this.btnGetGeneralLogData.UseVisualStyleBackColor = true;
            this.btnGetGeneralLogData.Click += new System.EventHandler(this.btnGetGeneralLogData_Click);
            // 
            // btnClearGLog
            // 
            this.btnClearGLog.Location = new System.Drawing.Point(6, 71);
            this.btnClearGLog.Name = "btnClearGLog";
            this.btnClearGLog.Size = new System.Drawing.Size(111, 23);
            this.btnClearGLog.TabIndex = 72;
            this.btnClearGLog.Text = "ClearGLog";
            this.btnClearGLog.UseVisualStyleBackColor = true;
            this.btnClearGLog.Click += new System.EventHandler(this.btnClearGLog_Click);
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(6, 45);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(111, 23);
            this.btnGetDeviceStatus.TabIndex = 71;
            this.btnGetDeviceStatus.Text = "GetRecordCount";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnGetGeneralLogData);
            this.groupBox3.Controls.Add(this.btnSettings);
            this.groupBox3.Controls.Add(this.btnGetDeviceStatus);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnClearGLog);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(402, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 144);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(127, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Chaneg the settings";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuShow,
            this.mnuHide,
            this.menuItem3,
            this.mnuStart,
            this.mnuStop,
            this.menuItem6,
            this.mnuExit});
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // mnuShow
            // 
            this.mnuShow.Index = 0;
            this.mnuShow.Text = "Show";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuHide
            // 
            this.mnuHide.Index = 1;
            this.mnuHide.Text = "Hide";
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // mnuStart
            // 
            this.mnuStart.Index = 3;
            this.mnuStart.Text = "Start Service";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Index = 4;
            this.mnuStop.Text = "Stop Service";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Chương trình đọc thẻ PP3750";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // frmX628C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmX628C";
            this.Text = "X628C";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmX628C_Closing);
            this.Load += new System.EventHandler(this.frmX628C_Load);
            this.Resize += new System.EventHandler(this.frmX628C_Resize);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtMachineSN2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetGeneralLogData;
        private System.Windows.Forms.Button btnClearGLog;
        private System.Windows.Forms.Button btnGetDeviceStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mnuShow;
        private System.Windows.Forms.MenuItem mnuHide;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuStart;
        private System.Windows.Forms.MenuItem mnuStop;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ToolTip ToolTip1;
    }
}