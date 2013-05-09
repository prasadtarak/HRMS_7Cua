using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for FrmGroup.
	/// </summary>
	public class FrmGroup : Form
	{
		private GroupBox grbAccountInfo;
		private Button btnCancel;
		private Button btnClose;
		private ListBox lstUsers;
		private ListBox lstMembers;
		private Button btnRemoveMember;
		private Button btnClearAll;
		private Button btnSelectAll;
		private GroupBox grbMembership;
		private Label lblUsers;
		private Label lblMemberUsers;
		private Button btnUpdate;
		private TextBox txtUserGroupName;
		private Label lblGroupName;
		private TextBox txtDescription;
		private Label lblDescription;
		private TextBox txtUserGroupID;
		private Label lblGroupID;
		private Button btnAddMember;
		private GroupBox grbPermissions;
		private TreeView trvPermissions;
		private int checkkq = 0;
		private bool check = true;
		public bool lang
		{
			get {return check ;}
			set {check = value;}
		}
		private int checkkq1 = 0;




		//private DataSet dsPermission = null;
		public DataSet PermissionDataSet
		{
			get { return dsPermission; }
			set { dsPermission = value; }
		}

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FrmGroup()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmGroup));
			this.grbAccountInfo = new System.Windows.Forms.GroupBox();
			this.txtUserGroupID = new System.Windows.Forms.TextBox();
			this.lblGroupID = new System.Windows.Forms.Label();
			this.txtUserGroupName = new System.Windows.Forms.TextBox();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.grbPermissions = new System.Windows.Forms.GroupBox();
			this.trvPermissions = new System.Windows.Forms.TreeView();
			this.btnClearAll = new System.Windows.Forms.Button();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.grbMembership = new System.Windows.Forms.GroupBox();
			this.lblMemberUsers = new System.Windows.Forms.Label();
			this.lblUsers = new System.Windows.Forms.Label();
			this.btnRemoveMember = new System.Windows.Forms.Button();
			this.btnAddMember = new System.Windows.Forms.Button();
			this.lstMembers = new System.Windows.Forms.ListBox();
			this.lstUsers = new System.Windows.Forms.ListBox();
			this.grbAccountInfo.SuspendLayout();
			this.grbPermissions.SuspendLayout();
			this.grbMembership.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbAccountInfo
			// 
			this.grbAccountInfo.Controls.Add(this.txtUserGroupID);
			this.grbAccountInfo.Controls.Add(this.lblGroupID);
			this.grbAccountInfo.Controls.Add(this.txtUserGroupName);
			this.grbAccountInfo.Controls.Add(this.lblGroupName);
			this.grbAccountInfo.Controls.Add(this.txtDescription);
			this.grbAccountInfo.Controls.Add(this.lblDescription);
			this.grbAccountInfo.Location = new System.Drawing.Point(8, 8);
			this.grbAccountInfo.Name = "grbAccountInfo";
			this.grbAccountInfo.Size = new System.Drawing.Size(336, 152);
			this.grbAccountInfo.TabIndex = 12;
			this.grbAccountInfo.TabStop = false;
			this.grbAccountInfo.Text = "Thông tin tài khoản";
			// 
			// txtUserGroupID
			// 
			this.txtUserGroupID.Location = new System.Drawing.Point(88, 16);
			this.txtUserGroupID.Name = "txtUserGroupID";
			this.txtUserGroupID.Size = new System.Drawing.Size(136, 20);
			this.txtUserGroupID.TabIndex = 1;
			this.txtUserGroupID.Text = "";
			// 
			// lblGroupID
			// 
			this.lblGroupID.Location = new System.Drawing.Point(8, 16);
			this.lblGroupID.Name = "lblGroupID";
			this.lblGroupID.Size = new System.Drawing.Size(80, 23);
			this.lblGroupID.TabIndex = 4;
			this.lblGroupID.Text = "Mã nhóm";
			this.lblGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUserGroupName
			// 
			this.txtUserGroupName.Location = new System.Drawing.Point(88, 40);
			this.txtUserGroupName.Name = "txtUserGroupName";
			this.txtUserGroupName.Size = new System.Drawing.Size(240, 20);
			this.txtUserGroupName.TabIndex = 2;
			this.txtUserGroupName.Text = "";
			// 
			// lblGroupName
			// 
			this.lblGroupName.Location = new System.Drawing.Point(8, 40);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(80, 23);
			this.lblGroupName.TabIndex = 0;
			this.lblGroupName.Text = "Tên nhóm";
			this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(88, 64);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(240, 80);
			this.txtDescription.TabIndex = 3;
			this.txtDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(8, 64);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(80, 23);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Mô tả";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grbPermissions
			// 
			this.grbPermissions.Controls.Add(this.trvPermissions);
			this.grbPermissions.Controls.Add(this.btnClearAll);
			this.grbPermissions.Controls.Add(this.btnSelectAll);
			this.grbPermissions.Location = new System.Drawing.Point(352, 8);
			this.grbPermissions.Name = "grbPermissions";
			this.grbPermissions.Size = new System.Drawing.Size(224, 360);
			this.grbPermissions.TabIndex = 13;
			this.grbPermissions.TabStop = false;
			this.grbPermissions.Text = "Các quyền";
			// 
			// trvPermissions
			// 
			this.trvPermissions.CheckBoxes = true;
			this.trvPermissions.ImageIndex = -1;
			this.trvPermissions.Location = new System.Drawing.Point(8, 16);
			this.trvPermissions.Name = "trvPermissions";
			this.trvPermissions.SelectedImageIndex = -1;
			this.trvPermissions.Size = new System.Drawing.Size(208, 304);
			this.trvPermissions.TabIndex = 3;
			this.trvPermissions.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvPermissions_BeforeCheck);
			// 
			// btnClearAll
			// 
			this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClearAll.Location = new System.Drawing.Point(120, 328);
			this.btnClearAll.Name = "btnClearAll";
			this.btnClearAll.Size = new System.Drawing.Size(80, 23);
			this.btnClearAll.TabIndex = 2;
			this.btnClearAll.Text = "&Bỏ chọn";
			this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSelectAll.Location = new System.Drawing.Point(40, 328);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(80, 23);
			this.btnSelectAll.TabIndex = 1;
			this.btnSelectAll.Text = "&Chọn tất";
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnUpdate.Location = new System.Drawing.Point(168, 376);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(248, 376);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "&Bỏ qua";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(328, 376);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 16;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// grbMembership
			// 
			this.grbMembership.Controls.Add(this.lblMemberUsers);
			this.grbMembership.Controls.Add(this.lblUsers);
			this.grbMembership.Controls.Add(this.btnRemoveMember);
			this.grbMembership.Controls.Add(this.btnAddMember);
			this.grbMembership.Controls.Add(this.lstMembers);
			this.grbMembership.Controls.Add(this.lstUsers);
			this.grbMembership.Location = new System.Drawing.Point(8, 168);
			this.grbMembership.Name = "grbMembership";
			this.grbMembership.Size = new System.Drawing.Size(336, 200);
			this.grbMembership.TabIndex = 17;
			this.grbMembership.TabStop = false;
			this.grbMembership.Text = "Thành viên nhóm";
			// 
			// lblMemberUsers
			// 
			this.lblMemberUsers.Location = new System.Drawing.Point(208, 16);
			this.lblMemberUsers.Name = "lblMemberUsers";
			this.lblMemberUsers.TabIndex = 5;
			this.lblMemberUsers.Text = "Thành viên";
			this.lblMemberUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUsers
			// 
			this.lblUsers.Location = new System.Drawing.Point(8, 16);
			this.lblUsers.Name = "lblUsers";
			this.lblUsers.TabIndex = 4;
			this.lblUsers.Text = "Người dùng";
			this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRemoveMember
			// 
			this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRemoveMember.Location = new System.Drawing.Point(136, 120);
			this.btnRemoveMember.Name = "btnRemoveMember";
			this.btnRemoveMember.Size = new System.Drawing.Size(64, 23);
			this.btnRemoveMember.TabIndex = 3;
			this.btnRemoveMember.Text = "<<Bớt";
			this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
			// 
			// btnAddMember
			// 
			this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAddMember.Location = new System.Drawing.Point(136, 88);
			this.btnAddMember.Name = "btnAddMember";
			this.btnAddMember.Size = new System.Drawing.Size(64, 23);
			this.btnAddMember.TabIndex = 2;
			this.btnAddMember.Text = "Thêm>>";
			this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
			// 
			// lstMembers
			// 
			this.lstMembers.Location = new System.Drawing.Point(208, 40);
			this.lstMembers.Name = "lstMembers";
			this.lstMembers.Size = new System.Drawing.Size(120, 147);
			this.lstMembers.TabIndex = 1;
			// 
			// lstUsers
			// 
			this.lstUsers.Location = new System.Drawing.Point(8, 40);
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.Size = new System.Drawing.Size(120, 147);
			this.lstUsers.TabIndex = 0;
			// 
			// FrmGroup
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(584, 406);
			this.Controls.Add(this.grbMembership);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.grbPermissions);
			this.Controls.Add(this.grbAccountInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FrmGroup_Load);
			this.grbAccountInfo.ResumeLayout(false);
			this.grbPermissions.ResumeLayout(false);
			this.grbMembership.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region Các hàm xử lý chính

		/// <summary>
		/// Các biến và các hàm truy nhập thuộc tính
		/// </summary>

		private AdminDO adminDO = null;
		private DataSet dsUser = null;
		private DataSet dsMember = null;
		private DataSet dsPermission = null;
		private DataSet dsGroup = null;
		private int selectedGroup = -1;
		private DataRow[] dataRows;

		public DataSet GroupDataSet
		{
			get { return dsGroup; }
			set { dsGroup = value; }
		}

		public int SelectedGroup
		{
			get { return selectedGroup; }
			set { selectedGroup = value; }
		}

		/// <summary>
		/// Thêm một nhóm mới vào CSDL
		/// </summary>
		private void AddNewGroup()
		{
			DataRow dr = dsGroup.Tables[0].NewRow();
			SetGroupData(ref dr);
			dsGroup.Tables[0].Rows.Add(dr);
			int ret = 0;
			string str1 = WorkingContext.LangManager.GetString("frmGroup_Them_Thongbao_Title");
			try
			{
				ret = adminDO.AddGroup(dsGroup);
			}
			catch
			{
			}
			if (ret == 1)
			{
				UpdateUser();
				UpdatePermission();
				string str = WorkingContext.LangManager.GetString("frmGroup_Them_Thongbao_Messa");
				//MessageBox.Show("Thêm nhóm mới thành công !", "Thêm nhóm mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			
			}
			if (ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Them_Error1_Title");
				//MessageBox.Show("Mã nhóm đã tồn tại trong hệ thống !", "Thêm nhóm mới", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (ret == -1)
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Them_Error2_Title");
				//MessageBox.Show("Tên nhóm đã tồn tại trong hệ thống !", "Thêm nhóm mới", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// 
		/// edit by tuyetna 
		/// </summary>
		private void UpdateGroup()
		{
			DataRow dr = dsGroup.Tables[0].Rows[selectedGroup];
			SetGroupData(ref dr);

			int ret = 0;
			try
			{
				ret = adminDO.UpdateGroup(dsGroup);
			}
			catch
			{
			}
			if (ret == 1)
			{
				UpdateUser();
				UpdatePermission();
				string str = WorkingContext.LangManager.GetString("frmGroup_SuaNhom_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmGroup_SuaNhom_Loi_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Them_Error2_Title");
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1");
				//MessageBox.Show("Tên nhóm đã tồn tại trong hệ thống !", "Thêm nhóm mới", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dr"></param>
		private void SetGroupData(ref DataRow dr)
		{
			dr.BeginEdit();
			dr["UserGroupID"] = txtUserGroupID.Text.Trim();
			dr["UserGroupName"] = txtUserGroupName.Text.Trim();
			dr["Description"] = txtDescription.Text.Trim();
			dr.EndEdit();
		}

		/// <summary>
		/// Cập nhật danh sách nhân viên trong nhóm
		/// </summary>
		private void UpdateUser()
		{
			int ret = 2;
			foreach (DataRow dr in dsMember.Tables[0].Rows)
			{
				dr.BeginEdit();
				dr["UserGroupID"] = txtUserGroupID.Text.Trim();
				dr.EndEdit();
			}
//			foreach (DataRow dr in dsUser.Tables[0].Rows)
//			{
//				dr.BeginEdit();
//				dr["UserGroupID"] = DBNull.Value;
//				dr.EndEdit();
//			}
			try
			{
				if (dsMember.Tables[0].Rows.Count > 0)
				{
					ret = adminDO.UpdateUser(dsMember);
				}
//				if (dsUser.Tables[0].Rows.Count > 0)
//				{
//					ret = adminDO.UpdateUser(dsUser);					
//				}
			}
			catch
			{
			}
			if (ret == 0)
			{
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1");
				string str = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa");
				//MessageBox.Show("Không thể cập nhật người dùng cho nhóm này", "Cập nhật nhóm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Cập nhật thông tin nhân viên vào cơ sở dữ liệu
		/// </summary>
		private void UpdatePermission()
		{
			int ret = 0;
			// Delete old permissions
			adminDO.DeleteGroupPermission(txtUserGroupID.Text);
			bool HasCheckedNode = false;
			// Duyệt cây Permissions -- Mặc định cây chỉ có hai cấp
			foreach (TreeNode L1_Node in trvPermissions.Nodes)
			{
				if (L1_Node.Checked)
				{
					int PermissionID = (int) L1_Node.Tag;
					try
					{
						ret = adminDO.AddGroupPermission(txtUserGroupID.Text, PermissionID);
					}
					catch
					{
					}
				}
				foreach (TreeNode L2_Node in L1_Node.Nodes)
				{
					
					if (L2_Node.Checked)
					{
						
						HasCheckedNode = true;
						int PermissionID = (int) L2_Node.Tag;
						try
						{
							ret = adminDO.AddGroupPermission(txtUserGroupID.Text, PermissionID);
						}
						catch
						{
						}

					}
					
					
					foreach (TreeNode L3_Node in L2_Node.Nodes)
					{
						if (!L3_Node.Checked)
						{
							int PermissionID = (int) L3_Node.Tag;
							if ((PermissionID == 30) && (txtUserGroupID.Text =="admin"))
							{
								string str = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa1");
								string str1 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
								//MessageBox.Show("Không thể bỏ quyền quản trị hệ thống của nhóm admin. Quyền này vẫn sẽ tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
								MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
								HasCheckedNode = true;
								//Insert new permissions
								try
								{
									ret = adminDO.AddGroupPermission(txtUserGroupID.Text, PermissionID);
								}
								catch
								{
								}
							}
						}
						if (L3_Node.Checked)
						{
							HasCheckedNode = true;
							//Insert new permissions
							int PermissionID = (int) L3_Node.Tag;
							try
							{
								ret = adminDO.AddGroupPermission(txtUserGroupID.Text, PermissionID);
							}
							catch
							{
							}
						}
					}
					
				}
				
				
				
			}
			if (HasCheckedNode && ret == 0) 
			{
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1");
				string str = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa2");
				//MessageBox.Show("Không thể cập nhật quyền cho nhóm này", "Cập nhật nhóm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str,str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Hiển thị dữ liệu nhóm
		/// </summary>
		private void LoadCurrentGroup()
		{
			DataRow dr = dsGroup.Tables[0].Rows[selectedGroup];
			txtUserGroupID.Text = dr["UserGroupID"].ToString();
			txtUserGroupID.ReadOnly = true;
			txtUserGroupName.Text = dr["UserGroupName"].ToString();
			txtDescription.Text = dr["Description"].ToString();
		}

		/// <summary>
		/// Hiển thị danh sách các quyền 
		/// </summary>
		private void PopulatePermissionTreeView()
		{
			dsPermission = adminDO.GetAllPermissions();

			// Thêm các quyền vào TreeView
			trvPermissions.Nodes.Clear();
			TreeNode RootNode = new TreeNode("Tất cả các quyền");
			foreach (DataRow dr in dsPermission.Tables[0].Rows)
			{
				int PermissionID = Int32.Parse(dr["PermissionID"].ToString());
				string PermissionName = dr["PermissionName"].ToString();
				string ItemName = dr["ItemName"].ToString();

				TreeNode PermissionNode = new TreeNode(PermissionName);
				PermissionNode.Tag = PermissionID;
				RootNode.Nodes.Add(PermissionNode);
			}
			trvPermissions.Nodes.Add(RootNode);

			// Expand TreeNodes
			trvPermissions.SuspendLayout();
			trvPermissions.ExpandAll();
			trvPermissions.ResumeLayout();

			// Lấy danh sách sách các quyền của nhóm từ CSDL
			DataSet dsGroupPermission = null;
			
			try
			{
				dsGroupPermission = adminDO.GetPermissionByGroup(txtUserGroupID.Text);
			}
			catch
			{
			}

			if (dsGroupPermission.Tables[0].Rows.Count > 0)
			{
				// Thiết lập trạng thái check của các nút tương ứng với quyền của người dùng
				foreach (TreeNode L1_Node in trvPermissions.Nodes)
				{
					foreach (TreeNode L2_Node in L1_Node.Nodes)
					{
						DataRow[] dataRows = dsGroupPermission.Tables[0].Select("PermissionID = " + (int) L2_Node.Tag);
						if (dataRows.Length > 0)
						{
							L2_Node.Checked = true;
						}
					}
				}
			}
		}
		/// <summary>
		/// Hiển thị danh sách các nhóm
		/// author: tuyetna
		/// date:17/02/06
		/// </summary>
		private void PopulatePermissionTreeView1(bool kq)
		{
			checkkq = 1;
			dsPermission = adminDO.GetAllPermissions();
			PermissionDataSet = dsPermission;
			BuildTree(kq);
			trvPermissions.SuspendLayout();
			trvPermissions.ExpandAll();
			trvPermissions.ResumeLayout();

			// Lấy danh sách sách các quyền của nhóm từ CSDL
			DataSet dsGroupPermission = null;
			
			try
			{
				dsGroupPermission = adminDO.GetPermissionByGroup(txtUserGroupID.Text);
			}
			catch
			{
			}

			if (dsGroupPermission.Tables[0].Rows.Count > 0)
			{
				// Thiết lập trạng thái check của các nút tương ứng với quyền của người dùng
				foreach (TreeNode L1_Node in trvPermissions.Nodes)
				{
					DataRow[] dataRow1 = dsGroupPermission.Tables[0].Select("PermissionID = " + (int) L1_Node.Tag);
					if (dataRow1.Length > 0)
					{
						L1_Node.Checked = true;
					}
					foreach (TreeNode L2_Node in L1_Node.Nodes)
					{
						foreach (TreeNode L3_Node in L2_Node.Nodes)
						{
							DataRow[] dataRows = dsGroupPermission.Tables[0].Select("PermissionID = " + (int) L3_Node.Tag);
							if (dataRows.Length > 0)
							{
								L3_Node.Checked = true;
							}
							else L3_Node.Checked = false;
						}
						DataRow[] dataRow = dsGroupPermission.Tables[0].Select("PermissionID = " + (int) L2_Node.Tag);
						if (dataRow.Length > 0)
						{
							L2_Node.Checked = true;
						}
					}
					
					
				}
			
			}
			checkkq = 0;
			
			//departmentTreeView.SelectedNode = departmentTreeView.TopNode;
		}
		/// <summary>
		/// Dựng cây phân quyền đọc từ CSDL
		/// author: tuyetna
		/// date:17/02/06
		/// </summary>
		private void BuildTree(bool t)
		{
			//this.Nodes.Clear();

			DataRow[] drData = dsPermission.Tables[0].Select("ParentNode=0");

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int PermissionID = Convert.ToInt32(dataRow["PermissionID"]);

					string PermissionName = null;
					if (t==true)
					{
						PermissionName = Convert.ToString(dataRow["PermissionName"]);
					}
					else
					{
						PermissionName = Convert.ToString(dataRow["PermissionNameTN"]);
					}
					TreeNode mynode = new TreeNode();

					mynode.Text = PermissionName;

					mynode.Tag = PermissionID;

					//mynode.ImageIndex = 0;

					//mynode.SelectedImageIndex = 1;

					trvPermissions.Nodes.Add(mynode);

					if (IsParentNote(PermissionID))
					{
						AddSubNote(ref mynode, PermissionID,t);

					}
				}
			}
			drData = null;

			
		}
		/// <summary>
		/// Kiểm tra một quyền có phải là cha của quyền khác không?
		/// author: tuyetna
		/// date: 17/02/06
		/// </summary>
		/// <param name="PermissionID"></param>
		/// <returns></returns>
		private bool IsParentNote(int PermissionID)
		{
			DataRow[] data = dsPermission.Tables[0].Select("ParentNode=" +PermissionID);
			if (data.Length > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
//		private bool IsChildNode(int ChildID,int ParentID)
//		{
//			DataRow[] data = dsPermission.Tables[0].Select("PermissionID =" +ChildID+" And ParentNode = "+ParentID);
//			if (data.Length >0)
//			{
//				return true;
//			}
//			else 
//			{
//				return false;
//			}
//
//		}
		/// <summary>
		/// Thêm một nút con vào cây phân quyền
		/// author: tuyetna
		/// date: 17/02/06
		/// </summary>
		/// <param name="ParentNote"></param>
		/// <param name="ParentID"></param>
		private void AddSubNote(ref TreeNode ParentNote,int ParentID,bool t)
		{
			DataRow[] drData = dsPermission.Tables[0].Select("ParentNode=" + ParentID);

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int PermissionID = Convert.ToInt32(dataRow["PermissionID"]);

					string PermissionName = null;
					if (t ==true)
					{
						PermissionName= Convert.ToString(dataRow["PermissionName"]);
					}
					else
					{
						PermissionName= Convert.ToString(dataRow["PermissionNameTN"]);
					}

					TreeNode mynode = new TreeNode();

					mynode.Text = PermissionName;

					mynode.Tag = PermissionID;

					//mynode.ImageIndex = 0;

					//mynode.SelectedImageIndex = 1;

					ParentNote.Nodes.Add(mynode);

					if (IsParentNote(PermissionID))
					{
						AddSubNote(ref mynode, PermissionID,t);
					}
				}
			}

			drData = null;
		}
		/// <summary>
		/// Hiển thị danh sách người dùng và các thành viên nhóm
		/// </summary>
		private void PopulateUserAndMemberListBox()
		{
			// Danh sách người dùng
			try
			{
				dsUser = adminDO.GetUsersNotInGroup(txtUserGroupID.Text);
			}
			catch
			{
			}
			lstUsers.Items.Clear();
			lstUsers.DataSource = dsUser.Tables[0];
			lstUsers.DisplayMember = "UserName";
			lstUsers.ValueMember = "UserID";

			// Danh sách thành viên nhóm
			try
			{
				dsMember = adminDO.GetUsersInGroup(txtUserGroupID.Text);
			}
			catch
			{
			}

			lstMembers.Items.Clear();
			lstMembers.DataSource = dsMember.Tables[0];
			lstMembers.DisplayMember = "UserName";
			lstMembers.ValueMember = "UserID";
		}


		#endregion

		#region Utility methods

		/// <summary>
		/// Toggle the check flag for tree nodes, works recursive
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="check"></param>
		private void CheckNodesRec(TreeNode parent, bool check)
		{
			foreach (TreeNode n in parent.Nodes)
			{
				n.Checked = check;
				//
				CheckNodesRec(n, check);
			}
		}

		//private void CheckNodeChild(TreeNode child,bool check)
		//{
			
			//foreach (TreeNode L1_Node in trvPermissions.Nodes)
			//{
				//if (!IsChildNode((int)child.Tag,(int)L1_Node.Tag))
				//{
					
				//	foreach(TreeNode L2_Node in L1_Node.Nodes)
				//	{
				//		if (IsChildNode((int)child.Tag,(int)L2_Node.Tag))
				//		{
				//			
				//			L2_Node.Checked = check;
				//			CheckNodeChild(L2_Node,check);
				//			
				//		}
				//	}	
				//}
				//else 
				//{
				//	L1_Node.Checked = check;
				//}
			//}
		//}

		//private void CheckNodeChild1(TreeNode parent)
		//{
			
		//	bool check = true;
		//	foreach (TreeNode n in parent.Nodes)
		//	{
		//		if (n.Checked == false)
		//		{
		//			check = false;
		//			break;
		//		}
		//	}
		//	if (check == true)
		//	{
		//		parent.Checked = true;
		//	}
		//	else
		//	{
		//		parent.Checked = false;
		//	}
		//}



		/// <summary>
		/// Xóa tất cả các trường trên form
		/// </summary>
		private void ClearFields()
		{
			txtUserGroupName.Text = String.Empty;
			txtUserGroupID.Text = String.Empty;
			txtDescription.Text = String.Empty;
		}

		#endregion

		#region Windows Form Event Handlers

		private void FrmGroup_Load(object sender, EventArgs e)
		{
			adminDO = new AdminDO();
			if (selectedGroup >= 0) // Sửa thông tin nhóm
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Text2");
				this.Text = str;
				LoadCurrentGroup();
				
			}
			else
			{
				
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Text1");
				this.Text = str1;
			}

			// Hiển thị danh sách các quyền
			if ((this.Text != "Thêm một nhóm mới") && (this.Text != "Sửa thông tin nhóm"))
			{
				check = false;
			}
			else 
			{
				check = true;
			}
			
			PopulatePermissionTreeView1(check);
			if (WorkingContext.Username !="admin")
			{
				if (txtUserGroupID.Text=="admin")
				{
					trvPermissions.Enabled = false;
				}
			}
			

			
			checkkq1 = 1;

			// Hiển thị danh sách người dùng và các thành viên
			PopulateUserAndMemberListBox();
			Refresh();
            trvPermissions.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtUserGroupID.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Them_Loi_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Them_Loi_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtUserGroupName.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1");
				//MessageBox.Show("Bạn chưa nhập tên nhóm","Cập nhật",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				if (selectedGroup >= 0) //Cập nhật thông tin người dùng
				{
					UpdateGroup();
				}
				else //Thêm người dùng mới
				{
					AddNewGroup();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (selectedGroup >= 0)
			{
				LoadCurrentGroup();
			}
			else
			{
				ClearFields();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddMember_Click(object sender, EventArgs e)
		{
	
			if (dsUser.Tables[0].Rows.Count > 0)
			{
				DataRow selectedRow = dsUser.Tables[0].Rows[lstUsers.SelectedIndex];
				string str = selectedRow["UserName"].ToString();
				if (str =="admin" && txtUserGroupID.Text != "admin")
				{
					string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa4");
					string str2 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
					//MessageBox.Show("Không thể chuyển nhóm cho user là admin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
					MessageBox.Show(str1,str2,MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					DataRow dr = dsMember.Tables[0].NewRow();
					dr.BeginEdit();
					dr.ItemArray = selectedRow.ItemArray;
				
					dr.EndEdit();

					dsMember.Tables[0].Rows.Add(dr);
					dsMember.AcceptChanges();

					dsUser.Tables[0].Rows.Remove(selectedRow);
					dsUser.AcceptChanges();
				}
			}
		}

		private void btnRemoveMember_Click(object sender, EventArgs e)
		{
			if (dsMember.Tables[0].Rows.Count > 0)
			{
				DataRow selectedRow = dsMember.Tables[0].Rows[lstMembers.SelectedIndex];
				
				string str = selectedRow["UserName"].ToString();
				if (str =="admin" )
				{
					string str1 = WorkingContext.LangManager.GetString("frmGroup_Update_Error1_Messa5");
					string str2 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
					//MessageBox.Show("Không thể chuyển admin ra khỏi nhóm admin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
					MessageBox.Show(str1,str2,MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					DataRow dr = dsUser.Tables[0].NewRow();
					dr.BeginEdit();
					dr.ItemArray = selectedRow.ItemArray;
					dr.EndEdit();

					dsUser.Tables[0].Rows.Add(dr);
					dsUser.AcceptChanges();

					dsMember.Tables[0].Rows.Remove(selectedRow);
					dsMember.AcceptChanges();
				}
			}
		}


		private void btnClearAll_Click(object sender, EventArgs e)
		{
			foreach (TreeNode L1_Node in trvPermissions.Nodes)
			{
				L1_Node.Checked = false;
				foreach (TreeNode L2_Node in L1_Node.Nodes)
				{
					L2_Node.Checked = false;
					foreach (TreeNode L3_Node in L2_Node.Nodes)
					{
						L3_Node.Checked = false;
					}
				}
			}
		}

		private void trvPermissions_BeforeCheck(object sender, TreeViewCancelEventArgs e)
		{
			// get current action		
			if(checkkq1 == 1)
			{
				bool check = !e.Node.Checked;
				//bool check1 = !e.Node.Checked;

				Cursor.Current = Cursors.WaitCursor;
			
				try
				{
					// check child nodes to reflect parent check state
					
					
					
					CheckNodesRec(e.Node, check);
					
					
	
					//CheckNodeChild(e.Node,check);

				}
				catch (Exception ex)
				{
					// ups, exception ?
					Console.WriteLine(ex.Message);
				}
				finally
				{
					// reset the cursor
					Cursor.Current = Cursors.Default;
				}
			}
			
			
		}

		

		private void btnSelectAll_Click(object sender, System.EventArgs e)
		{
			foreach (TreeNode L1_Node in trvPermissions.Nodes)
			{
				L1_Node.Checked = true;
				foreach (TreeNode L2_Node in L1_Node.Nodes)
				{
					L2_Node.Checked = true;
					foreach (TreeNode L3_Node in L2_Node.Nodes)
					{
						L3_Node.Checked = true;
					}
				}
			}
		}
		#endregion


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
			this.grbAccountInfo.Text = WorkingContext.LangManager.GetString("frmGroup_grbAccountInfo")	;
			this.lblGroupID.Text = WorkingContext.LangManager.GetString("frmGroup_lblMaNhom");
			this.lblGroupName.Text = WorkingContext.LangManager.GetString("frmGroup_lblTenNhom");
			this.lblDescription.Text = WorkingContext.LangManager.GetString("frmGroup_lblMoTa");
			this.grbMembership.Text = WorkingContext.LangManager.GetString("frmGroup_grbMemberShip");
			this.grbPermissions.Text = WorkingContext.LangManager.GetString("frmGroup_grbPermission");
			this.lblUsers.Text = WorkingContext.LangManager.GetString("frmGroup_lblUser");
			this.lblMemberUsers.Text = WorkingContext.LangManager.GetString("frmGroup_lblMember");
			this.btnAddMember.Text = WorkingContext.LangManager.GetString("frmGroup_cmdAdd");
			this.btnRemoveMember.Text = WorkingContext.LangManager.GetString("frmGroup_cmdDel");
			this.btnSelectAll.Text = WorkingContext.LangManager.GetString("frmGroup_cmdSelectAll");
			this.btnClearAll.Text = WorkingContext.LangManager.GetString("frmGroup_cmdClearAll");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmGroup_cmdDong");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmGroup_cmdCapNhat");
			this.btnCancel.Text = WorkingContext.LangManager.GetString("frmGroup_cmdBoQua");

		}

		

		
	}
}