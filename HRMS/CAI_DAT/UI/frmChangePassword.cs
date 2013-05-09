using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.UI;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmChangePassword.
	/// </summary>
	public class frmChangePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnClose;

		private AdminDO adminDO = null;
		private DataSet dsUser = null;
		private System.Windows.Forms.Label lblNewPass;
		private System.Windows.Forms.Label lblConfirmPass;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.TextBox txtConfirmPass;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.GroupBox groupBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChangePassword()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			txtUserName.Text = WorkingContext.Username;
			adminDO = new AdminDO();
			string str = WorkingContext.Username;


			txtEmployeeName.Text = adminDO.GetEmployeeNameByUser(str);

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
			this.lblNewPass = new System.Windows.Forms.Label();
			this.lblConfirmPass = new System.Windows.Forms.Label();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.txtConfirmPass = new System.Windows.Forms.TextBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNewPass
			// 
			this.lblNewPass.Location = new System.Drawing.Point(8, 64);
			this.lblNewPass.Name = "lblNewPass";
			this.lblNewPass.Size = new System.Drawing.Size(100, 16);
			this.lblNewPass.TabIndex = 5;
			this.lblNewPass.Text = "Mật khẩu mới";
			// 
			// lblConfirmPass
			// 
			this.lblConfirmPass.Location = new System.Drawing.Point(8, 88);
			this.lblConfirmPass.Name = "lblConfirmPass";
			this.lblConfirmPass.Size = new System.Drawing.Size(120, 16);
			this.lblConfirmPass.TabIndex = 4;
			this.lblConfirmPass.Text = "Xác nhận lại mật khẩu";
			// 
			// txtNewPass
			// 
			this.txtNewPass.Location = new System.Drawing.Point(128, 64);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.PasswordChar = '*';
			this.txtNewPass.Size = new System.Drawing.Size(176, 20);
			this.txtNewPass.TabIndex = 0;
			this.txtNewPass.Text = "";
			// 
			// txtConfirmPass
			// 
			this.txtConfirmPass.Location = new System.Drawing.Point(128, 88);
			this.txtConfirmPass.Name = "txtConfirmPass";
			this.txtConfirmPass.PasswordChar = '*';
			this.txtConfirmPass.Size = new System.Drawing.Size(176, 20);
			this.txtConfirmPass.TabIndex = 1;
			this.txtConfirmPass.Text = "";
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEdit.Location = new System.Drawing.Point(160, 136);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Đồng ý";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(240, 136);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.Location = new System.Drawing.Point(8, 16);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(112, 24);
			this.lblUserName.TabIndex = 7;
			this.lblUserName.Text = "Tên đăng nhập";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.Location = new System.Drawing.Point(8, 40);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.TabIndex = 6;
			this.lblEmployeeName.Text = "Tên Nhân viên";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(128, 16);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(176, 20);
			this.txtUserName.TabIndex = 3;
			this.txtUserName.Text = "";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(128, 40);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.ReadOnly = true;
			this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
			this.txtEmployeeName.TabIndex = 2;
			this.txtEmployeeName.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblEmployeeName);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.txtEmployeeName);
			this.groupBox1.Controls.Add(this.lblNewPass);
			this.groupBox1.Controls.Add(this.lblConfirmPass);
			this.groupBox1.Controls.Add(this.txtNewPass);
			this.groupBox1.Controls.Add(this.txtConfirmPass);
			this.groupBox1.Controls.Add(this.lblUserName);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// frmChangePassword
			// 
			this.AcceptButton = this.btnEdit;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(328, 166);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnEdit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thay đổi mật khẩu";
			this.Load += new System.EventHandler(this.frmChangePassword_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			if (txtNewPass.Text != txtConfirmPass.Text)
			{
				string str = WorkingContext.LangManager.GetString("frmChangePass_Error1_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmChangePass_Error1_Title");
				//MessageBox.Show("Mật khẩu xác nhận không đúng mật khẩu mới!","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtNewPass.Text="";
				txtConfirmPass.Text="";
				txtNewPass.Focus();
			}
			else
			{
				ChangePass(txtUserName.Text,txtNewPass.Text);
			}

		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public void ChangePass(string UserName, string Pass)
		{
			adminDO = new AdminDO();
			dsUser = adminDO.GetUser(UserName);
			DataRow dr = dsUser.Tables[0].Rows[0];
			
			SetUserData(ref dr);
			string str = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
			int ret = 0;
			try
			{
				ret = adminDO.ChangePass(dsUser);
			}
			catch
			{
				
			}
			if (ret != 0)
			{
				string str1 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1_Title");
				//MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsUser.AcceptChanges();
				this.Close();
			}
			else
			{
				string str2 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao2_Title");
				//MessageBox.Show("Cập nhật mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				MessageBox.Show(str2, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsUser.RejectChanges();
				this.Close();
			}
		}

		private void SetUserData(ref DataRow dr)
		{
			adminDO = new AdminDO();
			dr.BeginEdit();
			dr["UserName"] = txtUserName.Text.Trim();
			dr["Password"] = adminDO.SetMD5hash(txtNewPass.Text);
			
			dr.EndEdit();
		}
//		private String SetMD5hash (String str)
//		{
//			byte[] data = new byte [1000] ;
//			data = Encoding.UTF8.GetBytes(str);
//			HashAlgorithm hash;
//			hash = new MD5CryptoServiceProvider();
//			byte[] hashbyte = hash.ComputeHash(data);
//			return Convert.ToBase64String(hashbyte);
//		}

		private void frmChangePassword_Load(object sender, System.EventArgs e)
		{
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
			this.Text = WorkingContext.LangManager.GetString("frmChangePass_Text");
			this.lblUserName.Text = WorkingContext.LangManager.GetString("frmChangePass_lblTen");
			this.lblEmployeeName.Text = WorkingContext.LangManager.GetString("frmChangePass_lblTen1");
			this.lblNewPass.Text = WorkingContext.LangManager.GetString("frmChangePass_lblMatKhau");
			this.lblConfirmPass.Text = WorkingContext.LangManager.GetString("frmChangePass_lblMatKhau1");
			this.btnEdit.Text = WorkingContext.LangManager.GetString("frmChangePass_btnOK");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmChangePass_btnClose");
		}

//		
	}
}
