using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using System.Security.Cryptography;
using System.Text;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for FrmUser.
	/// </summary>
	public class FrmUser : Form
	{
		private Label lblUsername;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Label lblPassword;
		private GroupBox grbAccountInfo;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private MTGCComboBox cbo;
		private System.Windows.Forms.Label lblUserGroupName;
		private MTGCComboBox cboEmployeeName;
        private MTGCComboBox cboUserGroupName;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FrmUser()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.cboUserGroupName = new MTGCComboBox();
            this.cboEmployeeName = new MTGCComboBox();
            this.lblUserGroupName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbo = new MTGCComboBox();
            this.grbAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblEmployeeName
            // 
            resources.ApplyResources(this.lblEmployeeName, "lblEmployeeName");
            this.lblEmployeeName.Name = "lblEmployeeName";
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Controls.Add(this.cboUserGroupName);
            this.grbAccountInfo.Controls.Add(this.cboEmployeeName);
            this.grbAccountInfo.Controls.Add(this.lblUserGroupName);
            this.grbAccountInfo.Controls.Add(this.txtUsername);
            this.grbAccountInfo.Controls.Add(this.lblUsername);
            this.grbAccountInfo.Controls.Add(this.lblEmployeeName);
            this.grbAccountInfo.Controls.Add(this.txtPassword);
            this.grbAccountInfo.Controls.Add(this.lblPassword);
            this.grbAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.grbAccountInfo, "grbAccountInfo");
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.TabStop = false;
            // 
            // cboUserGroupName
            // 
            this.cboUserGroupName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboUserGroupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboUserGroupName.ColumnNum = 2;
            this.cboUserGroupName.ColumnWidth = "60;120";
            this.cboUserGroupName.DisplayMember = "Text";
            this.cboUserGroupName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUserGroupName.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboUserGroupName.DropDownForeColor = System.Drawing.Color.Black;
            this.cboUserGroupName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboUserGroupName.DropDownWidth = 220;
            this.cboUserGroupName.GridLineColor = System.Drawing.Color.LightGray;
            this.cboUserGroupName.GridLineHorizontal = true;
            this.cboUserGroupName.GridLineVertical = true;
            resources.ApplyResources(this.cboUserGroupName, "cboUserGroupName");
            this.cboUserGroupName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboUserGroupName.ManagingFastMouseMoving = true;
            this.cboUserGroupName.ManagingFastMouseMovingInterval = 30;
            this.cboUserGroupName.Name = "cboUserGroupName";
            // 
            // cboEmployeeName
            // 
            this.cboEmployeeName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboEmployeeName.ColumnNum = 3;
            this.cboEmployeeName.ColumnWidth = "60;120;60";
            this.cboEmployeeName.DisplayMember = "Text";
            this.cboEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmployeeName.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboEmployeeName.DropDownForeColor = System.Drawing.Color.Black;
            this.cboEmployeeName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboEmployeeName.DropDownWidth = 230;
            this.cboEmployeeName.GridLineColor = System.Drawing.Color.LightGray;
            this.cboEmployeeName.GridLineHorizontal = true;
            this.cboEmployeeName.GridLineVertical = true;
            resources.ApplyResources(this.cboEmployeeName, "cboEmployeeName");
            this.cboEmployeeName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboEmployeeName.ManagingFastMouseMoving = true;
            this.cboEmployeeName.ManagingFastMouseMovingInterval = 30;
            this.cboEmployeeName.Name = "cboEmployeeName";
            // 
            // lblUserGroupName
            // 
            resources.ApplyResources(this.lblUserGroupName, "lblUserGroupName");
            this.lblUserGroupName.Name = "lblUserGroupName";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbo
            // 
            this.cbo.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbo.ColumnNum = 1;
            this.cbo.ColumnWidth = "121";
            this.cbo.DisplayMember = "Text";
            this.cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbo.DropDownForeColor = System.Drawing.Color.Black;
            this.cbo.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cbo.DropDownWidth = 141;
            this.cbo.GridLineColor = System.Drawing.Color.LightGray;
            this.cbo.GridLineHorizontal = false;
            this.cbo.GridLineVertical = false;
            resources.ApplyResources(this.cbo, "cbo");
            this.cbo.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbo.ManagingFastMouseMoving = true;
            this.cbo.ManagingFastMouseMovingInterval = 30;
            this.cbo.Name = "cbo";
            // 
            // FrmUser
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		#region Các hàm xử lý dữ liệu chính
		
		private AdminDO adminDO = null;
		private EmployeeDO employeeDO = null;
		
		private DataSet dsUser = null;
		private DataSet dsEmployee = null;
		
		private int selectedUser = -1;

		public DataSet UserDataSet
		{
			get { return dsUser; }
			set { dsUser = value; }
		}

		public int SelectedUser
		{
			get { return selectedUser; }
			set { selectedUser = value; }
		}


		/// <summary>
		/// Cập nhật thông tin người dùng vào cơ sở dữ liệu
		/// </summary>
		private void UpdateUser()
		{
			DataRow dr = dsUser.Tables[0].Rows[selectedUser];
			
			SetUserData(ref dr);
			string str = WorkingContext.LangManager.GetString("frmUser_Update_ThongBao_Title");
			int ret = 0;
			try
			{
				ret = adminDO.UpdateUser(dsUser);
			}
			catch
			{
				
			}
			if (ret != 0)
			{
				string str1 = WorkingContext.LangManager.GetString("frmUser_Update_ThongBao_Messa");
				//MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsUser.AcceptChanges();
			}
			else
			{
				string str1 = WorkingContext.LangManager.GetString("frmUser_Update_ThongBao_Messa1");
				//MessageBox.Show("Cập nhật người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Error);	
				dsUser.RejectChanges();
			}
		}

		/// <summary>
		/// Thêm người dùng vào cơ sở dữ liệu
		/// </summary>
		private void AddNewUser()
		{
			DataRow dr = dsUser.Tables[0].NewRow();
			SetUserData(ref dr);
			dsUser.Tables[0].Rows.Add(dr);
			string str = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Title");
			int ret = 0;
			try
			{
				ret = adminDO.AddUser(dsUser);
			}
			catch
			{
				
			}

			if (ret == 1)
			{
				string str1 = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Messa");
				//MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsUser.AcceptChanges();
				this.Close();
			}
			else if( ret == -1)
			{
				string str1 = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Messa1");
				//MessageBox.Show("Tên đăng nhập này đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);				
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);				
				dsUser.RejectChanges();
			}
			else
			{
				string str1 = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Messa2");
				//MessageBox.Show("Không thể thêm người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Error);				
				dsUser.RejectChanges();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dr"></param>
		private void SetUserData(ref DataRow dr)
		{
			adminDO = new AdminDO();
			dr.BeginEdit();
			dr["UserName"] = txtUsername.Text.Trim();
			dr["Password"] = adminDO.SetMD5hash(txtPassword.Text);
			dr["CardID"] = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col1;
			dr["EmployeeID"] = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3;
			if (cboUserGroupName.Items.Count > 0) 
			{
				dr["UserGroupID"] = ((MTGCComboBoxItem)cboUserGroupName.SelectedItem).Col1;
			}
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

		/// <summary>
		/// 
		/// </summary>
		private void PopulateUserAndGroupCombos()
		{
			// ComboBox Họ tên nhân viên
			try
			{
//				dsEmployee = employeeDO.GetAllEmployees();
				dsEmployee = employeeDO.GetEmployeeByDepartment(1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
			cboEmployeeName.SourceDataString = new string[3] {"CardID", "EmployeeName","EmployeeID"};
			cboEmployeeName.SourceDataTable = dsEmployee.Tables[0];

			// ComboBox Tên nhóm
			DataSet dsGroup = new DataSet();

			try
			{
				dsGroup = adminDO.GetAllGroups();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			cboUserGroupName.SourceDataString = new string[2] {"UserGroupID", "UserGroupName"};
			cboUserGroupName.SourceDataTable = dsGroup.Tables[0];

		}

		/// <summary>
		/// Hiển thị dữ liệu người dùng
		/// </summary>
		private void LoadCurrentUser()
		{
			DataRow dr = dsUser.Tables[0].Rows[selectedUser];
			txtUsername.Text = dr["UserName"].ToString();
			txtUsername.ReadOnly = true;
//			txtPassword.Text = dr["Password"].ToString();
			txtPassword.Text = "";
			cboEmployeeName.Text = dr["EmployeeName"].ToString();
			cboUserGroupName.Text = dr["UserGroupName"].ToString();
			if (txtUsername.Text=="admin")
			{
				cboUserGroupName.Enabled = false;
			}
		}

		/// <summary>
		/// Xóa tất cả các trường trên form
		/// </summary>
		private void ClearFields()
		{
			txtUsername.Text = String.Empty;
			txtPassword.Text = String.Empty;
			cboEmployeeName.SelectedIndex = 0;
			cboUserGroupName.SelectedIndex = 0;
		}

		#endregion

		#region Windows Form Event Handlers

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private bool IsValidated()
		{
			string str1 = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Title");
			if (txtUsername.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmUser_CapNhat_Loi_Messa");
				//string str1 = WorkingContext.LangManager.GetString("frmUser_CapNhat_Loi_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (cboEmployeeName.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Messa3");
				//MessageBox.Show("Bạn chưa chọn tên nhân viên!", "Cập nhật người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (cboUserGroupName.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmUser_Add_ThongBao_Messa4");
				//MessageBox.Show("Bạn chưa chọn nhóm người dùng!", "Cập nhật người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsValidated()) 
			{
				if (selectedUser >= 0) //Cập nhật thông tin người dùng
				{
					UpdateUser();
					this.Close();
				}
				else //Thêm người dùng mới
				{
					AddNewUser();
					ClearFields();
				}
			}
		}

		private void FrmUser_Load(object sender, EventArgs e)
		{
			employeeDO = new EmployeeDO();
			adminDO = new AdminDO();

			PopulateUserAndGroupCombos();

			if (selectedUser >= 0)
			{
				string str = WorkingContext.LangManager.GetString("frmUser_Text1");
				this.Text = str;
				// Hien thi thong tin nguoi dung
				LoadCurrentUser();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmUser_Text2");
				this.Text = str;
				this.txtUsername.TabIndex = 0;
			}
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
			//this.Text = WorkingContext.LangManager.GetString("ユーザー情報修正");
			this.grbAccountInfo.Text = WorkingContext.LangManager.GetString("frmUser_GroupBox1");
			this.lblUsername.Text = WorkingContext.LangManager.GetString("frmUser_lblTenDangNhap");
			this.lblPassword.Text = WorkingContext.LangManager.GetString("frmUser_lblMatKhau");
			this.lblEmployeeName.Text = WorkingContext.LangManager.GetString("frmUser_lblTenNhanVien");
			this.lblUserGroupName.Text = WorkingContext.LangManager.GetString("frmUser_lblTenNhom");
			this.btnOK.Text = WorkingContext.LangManager.GetString("frmUser_cmdOK");
			this.btnCancel.Text = WorkingContext.LangManager.GetString("frmUser_cmdCancel");
		}

		#endregion
	}
}