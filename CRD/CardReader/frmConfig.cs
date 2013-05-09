using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using myCompany.MyApp.Config;

namespace CardReader
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmConfig : System.Windows.Forms.Form
	{
//		[STAThread]
//		private static void Main()
//		{
//			Application.EnableVisualStyles();
//			Application.DoEvents();
//			Application.Run(new frmConfig());
//			
//		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.RadioButton rdo3750;
		private System.Windows.Forms.RadioButton rdo6750;
		private System.Windows.Forms.TabControl tbConfig;
		private System.Windows.Forms.TabPage tbCardType;
		private System.Windows.Forms.TabPage tbDatabase;
		private System.Windows.Forms.TextBox txtPassWord;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Label lblDatabase;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TabPage tbPicture;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPicturePath;
		private System.Windows.Forms.Button btnBrowse;
        private RadioButton rdoBarCode;
        private ComboBox cboBarCodeType;
        private RadioButton rdoX628C;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
//		private Form cardForm;

		public frmConfig()
		{
//			this.cardForm = frm;
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBarCodeType = new System.Windows.Forms.ComboBox();
            this.rdo6750 = new System.Windows.Forms.RadioButton();
            this.rdo3750 = new System.Windows.Forms.RadioButton();
            this.rdoBarCode = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbConfig = new System.Windows.Forms.TabControl();
            this.tbCardType = new System.Windows.Forms.TabPage();
            this.tbDatabase = new System.Windows.Forms.TabPage();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbPicture = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.rdoX628C = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.tbCardType.SuspendLayout();
            this.tbDatabase.SuspendLayout();
            this.tbPicture.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoX628C);
            this.groupBox1.Controls.Add(this.cboBarCodeType);
            this.groupBox1.Controls.Add(this.rdo6750);
            this.groupBox1.Controls.Add(this.rdo3750);
            this.groupBox1.Controls.Add(this.rdoBarCode);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboBarCodeType
            // 
            this.cboBarCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarCodeType.FormattingEnabled = true;
            this.cboBarCodeType.Items.AddRange(new object[] {
            "JAN-8",
            "JAN-13"});
            this.cboBarCodeType.Location = new System.Drawing.Point(161, 16);
            this.cboBarCodeType.Name = "cboBarCodeType";
            this.cboBarCodeType.Size = new System.Drawing.Size(113, 21);
            this.cboBarCodeType.TabIndex = 4;
            // 
            // rdo6750
            // 
            this.rdo6750.Location = new System.Drawing.Point(16, 100);
            this.rdo6750.Name = "rdo6750";
            this.rdo6750.Size = new System.Drawing.Size(152, 24);
            this.rdo6750.TabIndex = 2;
            this.rdo6750.Text = "Máy quẹt thẻ PP 6750";
            // 
            // rdo3750
            // 
            this.rdo3750.Location = new System.Drawing.Point(16, 71);
            this.rdo3750.Name = "rdo3750";
            this.rdo3750.Size = new System.Drawing.Size(152, 24);
            this.rdo3750.TabIndex = 1;
            this.rdo3750.Text = "Máy quẹt thẻ PP 3750";
            // 
            // rdoBarCode
            // 
            this.rdoBarCode.Checked = true;
            this.rdoBarCode.Location = new System.Drawing.Point(16, 16);
            this.rdoBarCode.Name = "rdoBarCode";
            this.rdoBarCode.Size = new System.Drawing.Size(120, 24);
            this.rdoBarCode.TabIndex = 0;
            this.rdoBarCode.TabStop = true;
            this.rdoBarCode.Text = "Máy đọc Mã Vạch";
            this.rdoBarCode.CheckedChanged += new System.EventHandler(this.rdoBarCode_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(232, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(152, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Location = new System.Drawing.Point(8, 237);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Trợ giúp";
            // 
            // tbConfig
            // 
            this.tbConfig.Controls.Add(this.tbCardType);
            this.tbConfig.Controls.Add(this.tbDatabase);
            this.tbConfig.Controls.Add(this.tbPicture);
            this.tbConfig.Location = new System.Drawing.Point(8, 8);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.SelectedIndex = 0;
            this.tbConfig.Size = new System.Drawing.Size(304, 223);
            this.tbConfig.TabIndex = 4;
            // 
            // tbCardType
            // 
            this.tbCardType.Controls.Add(this.groupBox1);
            this.tbCardType.Location = new System.Drawing.Point(4, 22);
            this.tbCardType.Name = "tbCardType";
            this.tbCardType.Size = new System.Drawing.Size(296, 197);
            this.tbCardType.TabIndex = 0;
            this.tbCardType.Text = "Máy đọc thẻ";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Controls.Add(this.txtPassWord);
            this.tbDatabase.Controls.Add(this.lblPassword);
            this.tbDatabase.Controls.Add(this.txtUserName);
            this.tbDatabase.Controls.Add(this.lblUserID);
            this.tbDatabase.Controls.Add(this.txtDatabase);
            this.tbDatabase.Controls.Add(this.lblDatabase);
            this.tbDatabase.Controls.Add(this.txtServer);
            this.tbDatabase.Controls.Add(this.lblServer);
            this.tbDatabase.Location = new System.Drawing.Point(4, 22);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(296, 142);
            this.tbDatabase.TabIndex = 1;
            this.tbDatabase.Text = "Cơ sở dữ liệu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.Location = new System.Drawing.Point(112, 88);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(168, 20);
            this.txtPassWord.TabIndex = 23;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(8, 88);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(112, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 20);
            this.txtUserName.TabIndex = 21;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(8, 64);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(100, 23);
            this.lblUserID.TabIndex = 20;
            this.lblUserID.Text = "Tên đăng nhập";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabase.Location = new System.Drawing.Point(112, 40);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(168, 20);
            this.txtDatabase.TabIndex = 19;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(8, 40);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(100, 23);
            this.lblDatabase.TabIndex = 18;
            this.lblDatabase.Text = "Tên cơ sơ dữ liệu";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(112, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(168, 20);
            this.txtServer.TabIndex = 17;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(8, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(100, 23);
            this.lblServer.TabIndex = 16;
            this.lblServer.Text = "Máy chủ";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPicture
            // 
            this.tbPicture.Controls.Add(this.groupBox2);
            this.tbPicture.Location = new System.Drawing.Point(4, 22);
            this.tbPicture.Name = "tbPicture";
            this.tbPicture.Size = new System.Drawing.Size(296, 142);
            this.tbPicture.TabIndex = 2;
            this.tbPicture.Text = "Đường dẫn ảnh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtPicturePath);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn đường dẫn";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Location = new System.Drawing.Point(224, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Chọn ...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Location = new System.Drawing.Point(8, 24);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(208, 20);
            this.txtPicturePath.TabIndex = 0;
            // 
            // rdoX628C
            // 
            this.rdoX628C.Location = new System.Drawing.Point(16, 41);
            this.rdoX628C.Name = "rdoX628C";
            this.rdoX628C.Size = new System.Drawing.Size(152, 24);
            this.rdoX628C.TabIndex = 5;
            this.rdoX628C.Text = "Máy vân tay X628C";
            // 
            // frmConfig
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(320, 267);
            this.Controls.Add(this.tbConfig);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn máy đọc thẻ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.tbCardType.ResumeLayout(false);
            this.tbDatabase.ResumeLayout(false);
            this.tbDatabase.PerformLayout();
            this.tbPicture.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(myCompany.MyApp.Config.ModuleConfig.CheckConnection(txtServer.Text,txtDatabase.Text,txtUserName.Text,txtPassWord.Text))
			{
			    string barCodeType = string.Empty;
                if(cboBarCodeType.Text !=string.Empty)
                    barCodeType = cboBarCodeType.Text;

                if (rdoBarCode.Checked)
                {
                    Utils.SaveSettings("BarCode", txtDatabase.Text.Trim(), txtPassWord.Text.Trim(), txtUserName.Text.Trim(), txtServer.Text.Trim(), txtPicturePath.Text.Trim(), barCodeType);
                }
				if(rdo3750.Checked)
				{
                    Utils.SaveSettings("PP3750", txtDatabase.Text.Trim(), txtPassWord.Text.Trim(), txtUserName.Text.Trim(), txtServer.Text.Trim(), txtPicturePath.Text.Trim(), barCodeType);
				}
				if(rdo6750.Checked)
				{
                    Utils.SaveSettings("PP6750", txtDatabase.Text.Trim(), txtPassWord.Text.Trim(), txtUserName.Text.Trim(), txtServer.Text.Trim(), txtPicturePath.Text.Trim(), barCodeType);
				}
				
                if (rdoX628C.Checked)
                {
                    Utils.SaveSettings("X628C", txtDatabase.Text.Trim(), txtPassWord.Text.Trim(), txtUserName.Text.Trim(), txtServer.Text.Trim(), txtPicturePath.Text.Trim(), barCodeType);
                }
				MessageBox.Show("Lưu cấu hình thành công. Hãy khởi động lại chương trình đọc thẻ để có hiệu lực !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("Không kết nối được cơ sở dữ liệu, hãy xem lại cấu hình hệ thống ?","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
			this.Close();

		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{	
			LoadSettingData();

		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnBrowse_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = Utils.settings.PicturePath;

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtPicturePath.Text = fbd.SelectedPath;
			}
		}
		/// <summary>
		/// Lấy cấu hình hệ thống từ file cấu hình
		/// </summary>
		private void LoadSettingData()
		{
			txtServer.Text = Utils.settings.Server;
			txtDatabase.Text = Utils.settings.Database;
			txtPassWord.Text = Utils.settings.Password;
			txtUserName.Text = Utils.settings.UserName;
			txtPicturePath.Text = Utils.settings.PicturePath;
		    cboBarCodeType.Text = Utils.settings.BarCodeType;
			switch (Utils.settings.CardType)
			{
                case "BarCode":
                    rdoBarCode.Checked = true;
                    break;
                case "X628C":
					rdoX628C.Checked = true;
						break;
				case "PP3750":
					rdo3750.Checked = true;
						break;
				case "PP6750":
					rdo6750.Checked = true;
						break;
				default:
					rdo3750.Checked = true;
					break;
			}
		}

        private void rdoBarCode_CheckedChanged(object sender, EventArgs e)
        {
            cboBarCodeType.Visible = rdoBarCode.Checked;
        }
	}
}
