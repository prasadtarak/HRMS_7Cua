using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EVsoft.HRMS.Common;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for Configuration.
	/// </summary>
	public class frmSettings : Form
	{
		private ModuleSettings settings;
		private TabControl tabSettings;
		private TabPage tpWorkingContext;
		private TabPage tpPicturePath;
		private GroupBox groupBox2;
		private Button btnClose;
		private TextBox txtPassWord;
		private Label lblPassword;
		private TextBox txtUserName;
        private Label lblUserID;
        private Label lblDatabase;
		private Label lblServer;
		private Button btnBrowse;
		private TextBox txtPicturePath;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.TabPage tbLanguage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoEnglish;
		private System.Windows.Forms.RadioButton rdoJapanese;
		private System.Windows.Forms.RadioButton rdoVietnamese;
        private ComboBox txtDatabase;
        private ComboBox txtServer;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
        private GroupBox groupBox3;
        private TextBox txtReportPath;
        private Button btnBrowseReport;

        private SystemProcess sysprocess = new SystemProcess();

		public frmSettings()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpWorkingContext = new System.Windows.Forms.TabPage();
            this.txtDatabase = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.ComboBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.tpPicturePath = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbLanguage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVietnamese = new System.Windows.Forms.RadioButton();
            this.rdoJapanese = new System.Windows.Forms.RadioButton();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReportPath = new System.Windows.Forms.TextBox();
            this.btnBrowseReport = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tpWorkingContext.SuspendLayout();
            this.tpPicturePath.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbLanguage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpWorkingContext);
            this.tabSettings.Controls.Add(this.tpPicturePath);
            this.tabSettings.Controls.Add(this.tbLanguage);
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(296, 138);
            this.tabSettings.TabIndex = 0;
            // 
            // tpWorkingContext
            // 
            this.tpWorkingContext.Controls.Add(this.txtDatabase);
            this.tpWorkingContext.Controls.Add(this.txtServer);
            this.tpWorkingContext.Controls.Add(this.txtPassWord);
            this.tpWorkingContext.Controls.Add(this.lblPassword);
            this.tpWorkingContext.Controls.Add(this.lblDatabase);
            this.tpWorkingContext.Controls.Add(this.txtUserName);
            this.tpWorkingContext.Controls.Add(this.lblUserID);
            this.tpWorkingContext.Controls.Add(this.lblServer);
            this.tpWorkingContext.Location = new System.Drawing.Point(4, 22);
            this.tpWorkingContext.Name = "tpWorkingContext";
            this.tpWorkingContext.Size = new System.Drawing.Size(288, 112);
            this.tpWorkingContext.TabIndex = 0;
            this.tpWorkingContext.Text = "Kết nối dữ liệu";
            this.tpWorkingContext.UseVisualStyleBackColor = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.FormattingEnabled = true;
            this.txtDatabase.Location = new System.Drawing.Point(112, 84);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(168, 21);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.DropDown += new System.EventHandler(this.Onchange);
            // 
            // txtServer
            // 
            this.txtServer.FormattingEnabled = true;
            this.txtServer.Location = new System.Drawing.Point(112, 8);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(168, 21);
            this.txtServer.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.Location = new System.Drawing.Point(112, 59);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(168, 20);
            this.txtPassWord.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(8, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(8, 84);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(100, 23);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Tên cơ sơ dữ liệu";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(112, 34);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(8, 34);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(100, 23);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "Tên đăng nhập";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(8, 8);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(100, 23);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "Máy chủ";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpPicturePath
            // 
            this.tpPicturePath.Controls.Add(this.groupBox3);
            this.tpPicturePath.Controls.Add(this.groupBox2);
            this.tpPicturePath.Location = new System.Drawing.Point(4, 22);
            this.tpPicturePath.Name = "tpPicturePath";
            this.tpPicturePath.Size = new System.Drawing.Size(288, 112);
            this.tpPicturePath.TabIndex = 1;
            this.tpPicturePath.Text = "Thiết lập Đường Dẫn";
            this.tpPicturePath.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPicturePath);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đường dẫn ảnh";
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Location = new System.Drawing.Point(8, 18);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(200, 20);
            this.txtPicturePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Location = new System.Drawing.Point(208, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Chọn...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbLanguage
            // 
            this.tbLanguage.Controls.Add(this.groupBox1);
            this.tbLanguage.Location = new System.Drawing.Point(4, 22);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(288, 112);
            this.tbLanguage.TabIndex = 2;
            this.tbLanguage.Text = "Ngôn ngữ";
            this.tbLanguage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVietnamese);
            this.groupBox1.Controls.Add(this.rdoJapanese);
            this.groupBox1.Controls.Add(this.rdoEnglish);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdoVietnamese
            // 
            this.rdoVietnamese.Location = new System.Drawing.Point(16, 64);
            this.rdoVietnamese.Name = "rdoVietnamese";
            this.rdoVietnamese.Size = new System.Drawing.Size(104, 24);
            this.rdoVietnamese.TabIndex = 2;
            this.rdoVietnamese.Text = "Tiếng Việt";
            // 
            // rdoJapanese
            // 
            this.rdoJapanese.Location = new System.Drawing.Point(16, 40);
            this.rdoJapanese.Name = "rdoJapanese";
            this.rdoJapanese.Size = new System.Drawing.Size(104, 24);
            this.rdoJapanese.TabIndex = 1;
            this.rdoJapanese.Text = "Japanese";
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.Location = new System.Drawing.Point(16, 16);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(104, 24);
            this.rdoEnglish.TabIndex = 0;
            this.rdoEnglish.Text = "English";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(218, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Location = new System.Drawing.Point(138, 144);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Đồng ý";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReportPath);
            this.groupBox3.Controls.Add(this.btnBrowseReport);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(8, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đường dẫn báo cáo";
            // 
            // txtReportPath
            // 
            this.txtReportPath.Location = new System.Drawing.Point(8, 18);
            this.txtReportPath.Name = "txtReportPath";
            this.txtReportPath.Size = new System.Drawing.Size(200, 20);
            this.txtReportPath.TabIndex = 1;
            // 
            // btnBrowseReport
            // 
            this.btnBrowseReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseReport.Location = new System.Drawing.Point(208, 18);
            this.btnBrowseReport.Name = "btnBrowseReport";
            this.btnBrowseReport.Size = new System.Drawing.Size(56, 23);
            this.btnBrowseReport.TabIndex = 0;
            this.btnBrowseReport.Text = "Chọn...";
            this.btnBrowseReport.Click += new System.EventHandler(this.btnBrowseReport_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSaveSettings;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(298, 174);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tpWorkingContext.ResumeLayout(false);
            this.tpWorkingContext.PerformLayout();
            this.tpPicturePath.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbLanguage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion


		private void frmSettings_Load(object sender, EventArgs e)
		{
//			RestoreSettings();
			getSettings();
			Refresh();

		}
		
		public override void Refresh()
		{
			ChangeToCurrentLang();

			foreach (Form form in this.MdiChildren)
			{
				form.Refresh();
			}

			base.Refresh ();
		}

		private void ChangeToCurrentLang()
		{
			this.Text = WorkingContext.LangManager.GetString("frmSetting_Text");
			this.tpWorkingContext.Text = WorkingContext.LangManager.GetString("frmSetting_tabSetting_tbWorkingContext");
			this.tpPicturePath.Text = WorkingContext.LangManager.GetString("frmSetting_TabSetting_tbPicturePath");
			this.lblServer.Text = WorkingContext.LangManager.GetString("frmSetting_tblServer");
			this.lblDatabase.Text = WorkingContext.LangManager.GetString("frmSetting_tblDataBase");
			this.lblUserID.Text = WorkingContext.LangManager.GetString("frmSetting_tblUserID");
			this.lblPassword.Text = WorkingContext.LangManager.GetString("frmSetting_tblPassword");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmSetting_GroupBox2");
			this.btnBrowse.Text = WorkingContext.LangManager.GetString("frmSetting_bntBrown");
			this.btnSaveSettings.Text = WorkingContext.LangManager.GetString("frmSetting_bntOK");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmSetting_bntClose");



		}
	
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			if(WorkingContext.CheckConnection(txtServer.Text,txtDatabase.Text,txtUserName.Text,txtPassWord.Text))
			{
				ModuleSettings newSettings = new ModuleSettings();
				newSettings.Database=txtDatabase.Text.Trim();
				newSettings.Password = txtPassWord.Text.Trim();
				newSettings.UserName = txtUserName.Text.Trim();
				newSettings.Server = txtServer.Text.Trim();
				newSettings.PicturePath = txtPicturePath.Text.Trim();
                newSettings.ReportPath = txtReportPath.Text.Trim();
				if(rdoEnglish.Checked)
				{
					newSettings.Language = "en-US";
				}
				else if(rdoVietnamese.Checked)
				{
					newSettings.Language = "vi-VN";
				}
				else if(rdoJapanese.Checked)
				{
					newSettings.Language = "ja-JP";
				}
				

//				WorkingContext.Setting.Server = txtServer.Text;
//				WorkingContext.Setting.Database = txtDatabase.Text;
//				WorkingContext.Setting.UserID = txtUserID.Text;
//				WorkingContext.Setting.Password = txtPassword.Text;
//
//				WorkingContext.Setting.PicturePath = txtPicturePath.Text;
				try 
				{
//					WorkingContext.Setting.Save();
					ModuleConfig.SaveSettings(newSettings);
					
				}

				catch
				{	
					string str1 = WorkingContext.LangManager.GetString("frmSetting_Error1");
					string str3 = WorkingContext.LangManager.GetString("frmSetting_Error1_Title");
					//MessageBox.Show("Không thể tạo file cấu hình hệ thống", "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
					MessageBox.Show(str1, str3, MessageBoxButtons.OK,  MessageBoxIcon.Error);
					return;
				}
				string str = WorkingContext.LangManager.GetString("frmSetting_ThongBao_Messa");
				string str2 = WorkingContext.LangManager.GetString("frmSetting_ThongBao_Title");
				MessageBox.Show(str, str2, MessageBoxButtons.OK,  MessageBoxIcon.Information);
				WorkingContext.InitWorkingContext();
				this.Close();
			}
			else
			{	
				string str4 = WorkingContext.LangManager.GetString("frmSetting_Error1_Title");
				string str5 = WorkingContext.LangManager.GetString("frmSetting_Error2");
				//MessageBox.Show("Không thể kết nối được cơ sở dữ liệu. Hãy nhập lại thông số cấu hình hệ thống", "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
				MessageBox.Show(str5, str4, MessageBoxButtons.OK,  MessageBoxIcon.Error);
			}

			
			
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = WorkingContext.Setting.PicturePath;

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtPicturePath.Text = fbd.SelectedPath;
			}
		}

//		private void RestoreSettings()
//		{
//			Setting newSetting;
//
//			try
//			{
//				newSetting = ((Setting) WorkingContext.Setting.Restore());
//
//			}
//			catch (UserSettingsException ex)
//			{
//				// in case of failure, keep current WorkingContext.Settings
//				MessageBox.Show(ex.ToString());
//				newSetting = WorkingContext.Setting;
//
//			}
//
//			WorkingContext.Setting = newSetting;
//
//			UpdateDisplay();
//
//		}

		/// <summary>
		/// Hiển thị thông tin cấu hình
		/// </summary>
//		private void UpdateDisplay()
//		{
//			txtServer.Text = WorkingContext.Setting.Server;
//			txtDatabase.Text = WorkingContext.Setting.Database;
//			txtUserName.Text = WorkingContext.Setting.UserID;
//			txtPassWord.Text = WorkingContext.Setting.Password;
//
//			txtPicturePath.Text = WorkingContext.Setting.PicturePath;
//		}
		/// <summary>
		/// 
		/// </summary>
		private void getSettings()
		{
            LoadServerCbo();
			settings = ModuleConfig.GetSettings();
			txtDatabase.Text = settings.Database;
			txtUserName.Text = settings.UserName;
			txtPassWord.Text = settings.Password;
			txtServer.Text = settings.Server;
			txtPicturePath.Text = settings.PicturePath;
            txtReportPath.Text = settings.ReportPath;
			switch(settings.Language)
			{
				case "en-US" :
					rdoEnglish.Checked = true;
					break;
				case "vi-VN" :
					rdoVietnamese.Checked = true;
					break;
				case "ja-JP":
					rdoJapanese.Checked = true; 
					break;

			}

		}

        private void LoadServerCbo()
        {
            string[] server = sysprocess.GetServers();
            txtServer.DataSource = server;
            txtServer.SelectedIndex = -1;
        }

        private void Onchange(object sender, EventArgs e)
        {
            txtDatabase.Items.Clear();
            string servername = txtServer.Text;
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if ((servername == "") || (username == "")) return;
            string[] database = sysprocess.Listdb(servername, username, password);
            if (database == null) return;
            txtDatabase.Items.Clear();
            foreach (string str in database)
                txtDatabase.Items.Add(str);
        }

        private void btnBrowseReport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = WorkingContext.Setting.ReportPath;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtReportPath.Text = fbd.SelectedPath;
            }
        }

	}
}