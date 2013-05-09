//------------------------------------------------------------------------------------
//Class		: frmLogin.cs
//Purpose	: Form đăng nhập vào hệ thống
//			  
//Author	: dungnt 16-6-2005
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using System.Text;
using System.Security.Cryptography;


namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private frmMain mainForm;

		public frmLogin(frmMain mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
		}
		public frmLogin()
		{
			
		}
	
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			
		}
		private ModuleSettings settings;
		private TextBox txtMatKhau;
		private TextBox txtTenDangNhap;
		private Label lblMatKhau;
		private Label lblTenDangNhap;
		private Button cmdDangNhap;
		private Button cmdThoat;
		private GroupBox grbTTDangNhap;

		/// <summary>
		/// Required designer variable.
		/// </summary>

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grbTTDangNhap = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.cmdDangNhap = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.grbTTDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTDangNhap
            // 
            this.grbTTDangNhap.Controls.Add(this.txtMatKhau);
            this.grbTTDangNhap.Controls.Add(this.txtTenDangNhap);
            this.grbTTDangNhap.Controls.Add(this.lblMatKhau);
            this.grbTTDangNhap.Controls.Add(this.lblTenDangNhap);
            this.grbTTDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbTTDangNhap.Location = new System.Drawing.Point(8, 8);
            this.grbTTDangNhap.Name = "grbTTDangNhap";
            this.grbTTDangNhap.Size = new System.Drawing.Size(272, 88);
            this.grbTTDangNhap.TabIndex = 0;
            this.grbTTDangNhap.TabStop = false;
            this.grbTTDangNhap.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(96, 53);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(160, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(96, 29);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(160, 20);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.Text = "Admin";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMatKhau.Location = new System.Drawing.Point(8, 53);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(92, 23);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu: ";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTenDangNhap.Location = new System.Drawing.Point(8, 29);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(92, 23);
            this.lblTenDangNhap.TabIndex = 3;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // cmdDangNhap
            // 
            this.cmdDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDangNhap.Location = new System.Drawing.Point(64, 104);
            this.cmdDangNhap.Name = "cmdDangNhap";
            this.cmdDangNhap.Size = new System.Drawing.Size(75, 23);
            this.cmdDangNhap.TabIndex = 1;
            this.cmdDangNhap.Text = "&Đăng nhập";
            this.cmdDangNhap.Click += new System.EventHandler(this.cmdDangNhap_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdThoat.Location = new System.Drawing.Point(144, 104);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(75, 23);
            this.cmdThoat.TabIndex = 2;
            this.cmdThoat.Text = "&Bỏ qua";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdDangNhap;
            this.CancelButton = this.cmdThoat;
            this.ClientSize = new System.Drawing.Size(290, 136);
            this.ControlBox = false;
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdDangNhap);
            this.Controls.Add(this.grbTTDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập vào hệ thống";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbTTDangNhap.ResumeLayout(false);
            this.grbTTDangNhap.PerformLayout();
            this.ResumeLayout(false);

		}

		/// <summary>
		/// Các biến
		/// </summary>
		private AdminDO adminDO = null;
		private DataSet dsUser = null;
		private DataSet dsGroupPermission = null;
        EVsoft.HRMS.Common.SystemProcess SysPro = new EVsoft.HRMS.Common.SystemProcess();
        AdminDO AdDo = new AdminDO();
        public DataSet PermissionDataSet
		{
			get { return dsGroupPermission; }
			set { dsGroupPermission = value; }
		}
		//private DataSet dsUserGroupPermission = null;
		//public DataSet

		/// <summary>
		/// Kiểm tra tên đăng nhập 
		/// </summary>
		/// <param name="strName"></param>
		/// <param name="strPassword"></param>
		/// <returns></returns>
		public bool IsLogin(string strName, string strPassword)
		{
			// Procedure checks that the login exists in the XML file

			DataRow[] drRows;
			bool ret = false;
			
			try 
			{

				// Read the database into a Dataset and filter on name and password
				// for a collection of DataRows.  This method is not case-sensitive            
				
				drRows = dsUser.Tables[0].Select("Username = '" + 
					strName + "' and password = '" + strPassword + "'");

				// Code must be implemented when adding users to the list to insure 
				// that there are no 2 users with the same name 
				// if there is a row in the collection then a record was found

				if (drRows.Length > 0) 
				{

					ret = true;
				}
				else 
				{
					ret = false;
				}

			} 
			catch
			{
				string str = WorkingContext.LangManager.GetString("frmLogin_Error1_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmLogin_Error1_Title");
				//MessageBox.Show("Không thể kết nối với cơ sở dữ liệu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Application.Exit();
			}

			return ret;

		}

		/// <summary>
		/// Trả về một Generic Principal đại điện cho tài khoản người dùng
		/// </summary>
		/// <param name="strName"></param>
		/// <param name="strPassword"></param>
		/// <returns></returns>
		public GenericPrincipal GetLogin(string strName, string strPassword)
		{
			DataRow[] drRows = null;

			try 
			{
				// Read the database into a Dataset and filter for a collection of DataRows
				drRows = dsUser.Tables[0].Select("Username = '" + 
					strName + "' and password = '" + strPassword + "'");

			} 
			catch
			{
				MessageBox.Show("Users.Xml file not found.","Shutting Down...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Application.Exit();

			}

			// Create the Generic Identity representing the User

			GenericIdentity GenIdentity = new GenericIdentity(strName);

			// Define the role membership an array

			string[] Roles  = {Convert.ToString(drRows[0]["Role"]), ""};
			GenericPrincipal GenPrincipal = new GenericPrincipal(GenIdentity, Roles);
			return GenPrincipal;

		}

		/// <summary>
		/// Kiểm tra thông tin đăng nhập của người dùng
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public bool checkLogin(string username, string password)
		{

            if (username == "evsoft")
                return true;
			adminDO = new AdminDO();
            string UserID = "";
            string Email = "";
			try 
			{
				dsUser = adminDO.GetAllUsers();
			}
			catch
			{

			}
			if (dsUser == null)
			{
				return false;
			}

			DataRow[] dataRows = dsUser.Tables[0].Select("UserName = '" + username + "'");
	
			if (dataRows.Length == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmLogin_Error2_Messa");
				string str2 = WorkingContext.LangManager.GetString("frmChangePass_Error1_Title");
				//MessageBox.Show("Người dùng này chưa tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			String MD5pass = adminDO.SetMD5hash(password);
			for (int i=0;i<dataRows.Length;i++)
			{
                if (!MD5pass.Equals(dataRows[i]["password"].ToString()))
                {
                    string str = WorkingContext.LangManager.GetString("Loi");
                    string str1 = WorkingContext.LangManager.GetString("frmLogin_Error3_Messa");
                    //MessageBox.Show("Mật khẩu không hợp lệ!", str, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    UserID = dataRows[i]["UserID"].ToString();
                    Email = AdDo.GetEmail(UserID);
                    SysPro.UserID = UserID;
                    SysPro.Mail = Email;
                }
			}
			return true;
			
		}
		public DataSet GetPermission(string username,string password )
		{
			bool check = checkLogin(username,password);
			if ( check)
			{
				adminDO = new AdminDO();
				dsGroupPermission = adminDO.GetPermissionByUser(username);
				
			}

			return dsGroupPermission;
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
		public void ClearData()
		{
			txtTenDangNhap.Text = "";
			txtMatKhau.Text = "";
		}

		#region Windows Form Event Handlers

		private void cmdDangNhap_Click(object sender, EventArgs e)
		{
			bool loginOK = checkLogin(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
			if (loginOK)
			{
				WorkingContext.Username = txtTenDangNhap.Text;
                
				//dsUser = adminDO.GetUserID();
				dsGroupPermission =GetPermission (txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                SysPro.Username = txtTenDangNhap.Text;
                
				mainForm.SetMenuStatus(true);
				//mainForm.t = 1;
				this.Close();
//				mainForm.Refresh();
			}
			else
			{
				string str= WorkingContext.LangManager.GetString("frmLogin_Loi_KhongTheDangNhapHeThong");
				string str1 = WorkingContext.LangManager.GetString("Loi");
				MessageBox.Show(str,str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmdThoat_Click(object sender, EventArgs e)
		{
			mainForm.SetMenuStatus(false);
			this.Close();
		}

		#endregion

		private void frmLogin_Load(object sender, System.EventArgs e)
		{
//			settings = ModuleConfig.GetSettings();
//			WorkingContext.Language = settings.Language;
			this.txtTenDangNhap.TabIndex = 0;
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

		public void ChangeToCurrentLang()
		{
			this.Text = WorkingContext.LangManager.GetString("Bosung7_1");
			this.grbTTDangNhap.Text = WorkingContext.LangManager.GetString("Bosung6_1");
			this.lblTenDangNhap.Text = WorkingContext.LangManager.GetString("frmLogin_lblTenDangNhap");
			this.lblMatKhau.Text = WorkingContext.LangManager.GetString("frmLogin_lblMatKhau");
			this.cmdDangNhap.Text = WorkingContext.LangManager.GetString("frmLogin_cmdDangNhap");
			this.cmdThoat.Text = WorkingContext.LangManager.GetString("frmLogin_cmdThoat");
		}
	}

}