using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for AccountInfo.
	/// </summary>
	public class FrmUserAdmin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnEditUser;
		private System.Windows.Forms.Button btnDeleteUser;
		private System.Windows.Forms.Button btnDeleteGroup;
		private System.Windows.Forms.Button btnEditGroup;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.MenuItem mnuAddUser;
		private System.Windows.Forms.MenuItem mnuEditUser;
		private System.Windows.Forms.MenuItem mnuDeleteUser;
		private System.Windows.Forms.MenuItem mnuAddGroup;
		private System.Windows.Forms.MenuItem mnuEditGroup;
		private System.Windows.Forms.MenuItem mnuDeleteGroup;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvwUsers;
		private System.Windows.Forms.ColumnHeader chUserNo;
		private System.Windows.Forms.ColumnHeader chLogin;
		private System.Windows.Forms.ColumnHeader chCardID;
		private System.Windows.Forms.ColumnHeader chFullName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvwGroups;
		private System.Windows.Forms.ColumnHeader chGroupNo;
		private System.Windows.Forms.ColumnHeader chGroupID;
		private System.Windows.Forms.ColumnHeader chGroupName;
		private System.Windows.Forms.ColumnHeader chGroupDescription;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private bool check = true;
		public bool lang
		{
			get {return check ;}
			set {check = value;}
		}
		

		public FrmUserAdmin()
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
			this.Text = WorkingContext.LangManager.GetString("frmUserAdmin_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmAdminUser_GroupBox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmAdminUser_GroupBox2");
			this.chUserNo.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwUser_STT");
			this.chCardID.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwUser_MaThe");
			this.chLogin.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwUser_TenDangNhap");
			this.chFullName.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwUser_TenDayDu");
			this.chGroupNo.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwGroup_STT");
			this.chGroupID.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwGroup_MaNhom");
			this.chGroupName.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwGroup_TenNhom");
			this.chGroupDescription.Text = WorkingContext.LangManager.GetString("frmAdminUser_lvwGroup_MoTa");
			this.btnAddUser.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdAddUser");
			this.btnEditUser.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdEditUser");
			this.btnDeleteUser.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdDeleteUser");
			this.btnAddGroup.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdAddGroup");
			this.btnEditGroup.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdEditGroup");
			this.btnDeleteGroup.Text = WorkingContext.LangManager.GetString("frmAdminUser_cmdDeleteGroup");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmAdminUser_btnClose");
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmUserAdmin));
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnuAddUser = new System.Windows.Forms.MenuItem();
			this.mnuEditUser = new System.Windows.Forms.MenuItem();
			this.mnuDeleteUser = new System.Windows.Forms.MenuItem();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnEditUser = new System.Windows.Forms.Button();
			this.btnDeleteUser = new System.Windows.Forms.Button();
			this.contextMenu2 = new System.Windows.Forms.ContextMenu();
			this.mnuAddGroup = new System.Windows.Forms.MenuItem();
			this.mnuEditGroup = new System.Windows.Forms.MenuItem();
			this.mnuDeleteGroup = new System.Windows.Forms.MenuItem();
			this.btnDeleteGroup = new System.Windows.Forms.Button();
			this.btnEditGroup = new System.Windows.Forms.Button();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwUsers = new System.Windows.Forms.ListView();
			this.chUserNo = new System.Windows.Forms.ColumnHeader();
			this.chLogin = new System.Windows.Forms.ColumnHeader();
			this.chCardID = new System.Windows.Forms.ColumnHeader();
			this.chFullName = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lvwGroups = new System.Windows.Forms.ListView();
			this.chGroupNo = new System.Windows.Forms.ColumnHeader();
			this.chGroupID = new System.Windows.Forms.ColumnHeader();
			this.chGroupName = new System.Windows.Forms.ColumnHeader();
			this.chGroupDescription = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuAddUser,
																						 this.mnuEditUser,
																						 this.mnuDeleteUser});
			this.contextMenu1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenu1.RightToLeft")));
			// 
			// mnuAddUser
			// 
			this.mnuAddUser.Enabled = ((bool)(resources.GetObject("mnuAddUser.Enabled")));
			this.mnuAddUser.Index = 0;
			this.mnuAddUser.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuAddUser.Shortcut")));
			this.mnuAddUser.ShowShortcut = ((bool)(resources.GetObject("mnuAddUser.ShowShortcut")));
			this.mnuAddUser.Text = resources.GetString("mnuAddUser.Text");
			this.mnuAddUser.Visible = ((bool)(resources.GetObject("mnuAddUser.Visible")));
			this.mnuAddUser.Click += new System.EventHandler(this.mnuAddUser_Click);
			// 
			// mnuEditUser
			// 
			this.mnuEditUser.Enabled = ((bool)(resources.GetObject("mnuEditUser.Enabled")));
			this.mnuEditUser.Index = 1;
			this.mnuEditUser.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuEditUser.Shortcut")));
			this.mnuEditUser.ShowShortcut = ((bool)(resources.GetObject("mnuEditUser.ShowShortcut")));
			this.mnuEditUser.Text = resources.GetString("mnuEditUser.Text");
			this.mnuEditUser.Visible = ((bool)(resources.GetObject("mnuEditUser.Visible")));
			this.mnuEditUser.Click += new System.EventHandler(this.mnuEditUser_Click);
			// 
			// mnuDeleteUser
			// 
			this.mnuDeleteUser.Enabled = ((bool)(resources.GetObject("mnuDeleteUser.Enabled")));
			this.mnuDeleteUser.Index = 2;
			this.mnuDeleteUser.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuDeleteUser.Shortcut")));
			this.mnuDeleteUser.ShowShortcut = ((bool)(resources.GetObject("mnuDeleteUser.ShowShortcut")));
			this.mnuDeleteUser.Text = resources.GetString("mnuDeleteUser.Text");
			this.mnuDeleteUser.Visible = ((bool)(resources.GetObject("mnuDeleteUser.Visible")));
			this.mnuDeleteUser.Click += new System.EventHandler(this.mnuDeleteUser_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.AccessibleDescription = resources.GetString("btnAddUser.AccessibleDescription");
			this.btnAddUser.AccessibleName = resources.GetString("btnAddUser.AccessibleName");
			this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnAddUser.Anchor")));
			this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
			this.btnAddUser.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnAddUser.Dock")));
			this.btnAddUser.Enabled = ((bool)(resources.GetObject("btnAddUser.Enabled")));
			this.btnAddUser.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnAddUser.FlatStyle")));
			this.btnAddUser.Font = ((System.Drawing.Font)(resources.GetObject("btnAddUser.Font")));
			this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
			this.btnAddUser.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAddUser.ImageAlign")));
			this.btnAddUser.ImageIndex = ((int)(resources.GetObject("btnAddUser.ImageIndex")));
			this.btnAddUser.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnAddUser.ImeMode")));
			this.btnAddUser.Location = ((System.Drawing.Point)(resources.GetObject("btnAddUser.Location")));
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnAddUser.RightToLeft")));
			this.btnAddUser.Size = ((System.Drawing.Size)(resources.GetObject("btnAddUser.Size")));
			this.btnAddUser.TabIndex = ((int)(resources.GetObject("btnAddUser.TabIndex")));
			this.btnAddUser.Text = resources.GetString("btnAddUser.Text");
			this.btnAddUser.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAddUser.TextAlign")));
			this.btnAddUser.Visible = ((bool)(resources.GetObject("btnAddUser.Visible")));
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnEditUser
			// 
			this.btnEditUser.AccessibleDescription = resources.GetString("btnEditUser.AccessibleDescription");
			this.btnEditUser.AccessibleName = resources.GetString("btnEditUser.AccessibleName");
			this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnEditUser.Anchor")));
			this.btnEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditUser.BackgroundImage")));
			this.btnEditUser.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnEditUser.Dock")));
			this.btnEditUser.Enabled = ((bool)(resources.GetObject("btnEditUser.Enabled")));
			this.btnEditUser.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnEditUser.FlatStyle")));
			this.btnEditUser.Font = ((System.Drawing.Font)(resources.GetObject("btnEditUser.Font")));
			this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
			this.btnEditUser.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEditUser.ImageAlign")));
			this.btnEditUser.ImageIndex = ((int)(resources.GetObject("btnEditUser.ImageIndex")));
			this.btnEditUser.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnEditUser.ImeMode")));
			this.btnEditUser.Location = ((System.Drawing.Point)(resources.GetObject("btnEditUser.Location")));
			this.btnEditUser.Name = "btnEditUser";
			this.btnEditUser.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnEditUser.RightToLeft")));
			this.btnEditUser.Size = ((System.Drawing.Size)(resources.GetObject("btnEditUser.Size")));
			this.btnEditUser.TabIndex = ((int)(resources.GetObject("btnEditUser.TabIndex")));
			this.btnEditUser.Text = resources.GetString("btnEditUser.Text");
			this.btnEditUser.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEditUser.TextAlign")));
			this.btnEditUser.Visible = ((bool)(resources.GetObject("btnEditUser.Visible")));
			this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.AccessibleDescription = resources.GetString("btnDeleteUser.AccessibleDescription");
			this.btnDeleteUser.AccessibleName = resources.GetString("btnDeleteUser.AccessibleName");
			this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDeleteUser.Anchor")));
			this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
			this.btnDeleteUser.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDeleteUser.Dock")));
			this.btnDeleteUser.Enabled = ((bool)(resources.GetObject("btnDeleteUser.Enabled")));
			this.btnDeleteUser.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDeleteUser.FlatStyle")));
			this.btnDeleteUser.Font = ((System.Drawing.Font)(resources.GetObject("btnDeleteUser.Font")));
			this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
			this.btnDeleteUser.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDeleteUser.ImageAlign")));
			this.btnDeleteUser.ImageIndex = ((int)(resources.GetObject("btnDeleteUser.ImageIndex")));
			this.btnDeleteUser.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDeleteUser.ImeMode")));
			this.btnDeleteUser.Location = ((System.Drawing.Point)(resources.GetObject("btnDeleteUser.Location")));
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDeleteUser.RightToLeft")));
			this.btnDeleteUser.Size = ((System.Drawing.Size)(resources.GetObject("btnDeleteUser.Size")));
			this.btnDeleteUser.TabIndex = ((int)(resources.GetObject("btnDeleteUser.TabIndex")));
			this.btnDeleteUser.Text = resources.GetString("btnDeleteUser.Text");
			this.btnDeleteUser.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDeleteUser.TextAlign")));
			this.btnDeleteUser.Visible = ((bool)(resources.GetObject("btnDeleteUser.Visible")));
			this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
			// 
			// contextMenu2
			// 
			this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuAddGroup,
																						 this.mnuEditGroup,
																						 this.mnuDeleteGroup});
			this.contextMenu2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenu2.RightToLeft")));
			// 
			// mnuAddGroup
			// 
			this.mnuAddGroup.Enabled = ((bool)(resources.GetObject("mnuAddGroup.Enabled")));
			this.mnuAddGroup.Index = 0;
			this.mnuAddGroup.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuAddGroup.Shortcut")));
			this.mnuAddGroup.ShowShortcut = ((bool)(resources.GetObject("mnuAddGroup.ShowShortcut")));
			this.mnuAddGroup.Text = resources.GetString("mnuAddGroup.Text");
			this.mnuAddGroup.Visible = ((bool)(resources.GetObject("mnuAddGroup.Visible")));
			this.mnuAddGroup.Click += new System.EventHandler(this.mnuAddGroup_Click);
			// 
			// mnuEditGroup
			// 
			this.mnuEditGroup.Enabled = ((bool)(resources.GetObject("mnuEditGroup.Enabled")));
			this.mnuEditGroup.Index = 1;
			this.mnuEditGroup.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuEditGroup.Shortcut")));
			this.mnuEditGroup.ShowShortcut = ((bool)(resources.GetObject("mnuEditGroup.ShowShortcut")));
			this.mnuEditGroup.Text = resources.GetString("mnuEditGroup.Text");
			this.mnuEditGroup.Visible = ((bool)(resources.GetObject("mnuEditGroup.Visible")));
			this.mnuEditGroup.Click += new System.EventHandler(this.mnuEditGroup_Click);
			// 
			// mnuDeleteGroup
			// 
			this.mnuDeleteGroup.Enabled = ((bool)(resources.GetObject("mnuDeleteGroup.Enabled")));
			this.mnuDeleteGroup.Index = 2;
			this.mnuDeleteGroup.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuDeleteGroup.Shortcut")));
			this.mnuDeleteGroup.ShowShortcut = ((bool)(resources.GetObject("mnuDeleteGroup.ShowShortcut")));
			this.mnuDeleteGroup.Text = resources.GetString("mnuDeleteGroup.Text");
			this.mnuDeleteGroup.Visible = ((bool)(resources.GetObject("mnuDeleteGroup.Visible")));
			this.mnuDeleteGroup.Click += new System.EventHandler(this.mnuDeleteGroup_Click);
			// 
			// btnDeleteGroup
			// 
			this.btnDeleteGroup.AccessibleDescription = resources.GetString("btnDeleteGroup.AccessibleDescription");
			this.btnDeleteGroup.AccessibleName = resources.GetString("btnDeleteGroup.AccessibleName");
			this.btnDeleteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDeleteGroup.Anchor")));
			this.btnDeleteGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGroup.BackgroundImage")));
			this.btnDeleteGroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDeleteGroup.Dock")));
			this.btnDeleteGroup.Enabled = ((bool)(resources.GetObject("btnDeleteGroup.Enabled")));
			this.btnDeleteGroup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDeleteGroup.FlatStyle")));
			this.btnDeleteGroup.Font = ((System.Drawing.Font)(resources.GetObject("btnDeleteGroup.Font")));
			this.btnDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGroup.Image")));
			this.btnDeleteGroup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDeleteGroup.ImageAlign")));
			this.btnDeleteGroup.ImageIndex = ((int)(resources.GetObject("btnDeleteGroup.ImageIndex")));
			this.btnDeleteGroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDeleteGroup.ImeMode")));
			this.btnDeleteGroup.Location = ((System.Drawing.Point)(resources.GetObject("btnDeleteGroup.Location")));
			this.btnDeleteGroup.Name = "btnDeleteGroup";
			this.btnDeleteGroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDeleteGroup.RightToLeft")));
			this.btnDeleteGroup.Size = ((System.Drawing.Size)(resources.GetObject("btnDeleteGroup.Size")));
			this.btnDeleteGroup.TabIndex = ((int)(resources.GetObject("btnDeleteGroup.TabIndex")));
			this.btnDeleteGroup.Text = resources.GetString("btnDeleteGroup.Text");
			this.btnDeleteGroup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDeleteGroup.TextAlign")));
			this.btnDeleteGroup.Visible = ((bool)(resources.GetObject("btnDeleteGroup.Visible")));
			this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
			// 
			// btnEditGroup
			// 
			this.btnEditGroup.AccessibleDescription = resources.GetString("btnEditGroup.AccessibleDescription");
			this.btnEditGroup.AccessibleName = resources.GetString("btnEditGroup.AccessibleName");
			this.btnEditGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnEditGroup.Anchor")));
			this.btnEditGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditGroup.BackgroundImage")));
			this.btnEditGroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnEditGroup.Dock")));
			this.btnEditGroup.Enabled = ((bool)(resources.GetObject("btnEditGroup.Enabled")));
			this.btnEditGroup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnEditGroup.FlatStyle")));
			this.btnEditGroup.Font = ((System.Drawing.Font)(resources.GetObject("btnEditGroup.Font")));
			this.btnEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnEditGroup.Image")));
			this.btnEditGroup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEditGroup.ImageAlign")));
			this.btnEditGroup.ImageIndex = ((int)(resources.GetObject("btnEditGroup.ImageIndex")));
			this.btnEditGroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnEditGroup.ImeMode")));
			this.btnEditGroup.Location = ((System.Drawing.Point)(resources.GetObject("btnEditGroup.Location")));
			this.btnEditGroup.Name = "btnEditGroup";
			this.btnEditGroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnEditGroup.RightToLeft")));
			this.btnEditGroup.Size = ((System.Drawing.Size)(resources.GetObject("btnEditGroup.Size")));
			this.btnEditGroup.TabIndex = ((int)(resources.GetObject("btnEditGroup.TabIndex")));
			this.btnEditGroup.Text = resources.GetString("btnEditGroup.Text");
			this.btnEditGroup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEditGroup.TextAlign")));
			this.btnEditGroup.Visible = ((bool)(resources.GetObject("btnEditGroup.Visible")));
			this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.AccessibleDescription = resources.GetString("btnAddGroup.AccessibleDescription");
			this.btnAddGroup.AccessibleName = resources.GetString("btnAddGroup.AccessibleName");
			this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnAddGroup.Anchor")));
			this.btnAddGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.BackgroundImage")));
			this.btnAddGroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnAddGroup.Dock")));
			this.btnAddGroup.Enabled = ((bool)(resources.GetObject("btnAddGroup.Enabled")));
			this.btnAddGroup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnAddGroup.FlatStyle")));
			this.btnAddGroup.Font = ((System.Drawing.Font)(resources.GetObject("btnAddGroup.Font")));
			this.btnAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.Image")));
			this.btnAddGroup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAddGroup.ImageAlign")));
			this.btnAddGroup.ImageIndex = ((int)(resources.GetObject("btnAddGroup.ImageIndex")));
			this.btnAddGroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnAddGroup.ImeMode")));
			this.btnAddGroup.Location = ((System.Drawing.Point)(resources.GetObject("btnAddGroup.Location")));
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnAddGroup.RightToLeft")));
			this.btnAddGroup.Size = ((System.Drawing.Size)(resources.GetObject("btnAddGroup.Size")));
			this.btnAddGroup.TabIndex = ((int)(resources.GetObject("btnAddGroup.TabIndex")));
			this.btnAddGroup.Text = resources.GetString("btnAddGroup.Text");
			this.btnAddGroup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAddGroup.TextAlign")));
			this.btnAddGroup.Visible = ((bool)(resources.GetObject("btnAddGroup.Visible")));
			this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
			// 
			// btnClose
			// 
			this.btnClose.AccessibleDescription = resources.GetString("btnClose.AccessibleDescription");
			this.btnClose.AccessibleName = resources.GetString("btnClose.AccessibleName");
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnClose.Anchor")));
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnClose.Dock")));
			this.btnClose.Enabled = ((bool)(resources.GetObject("btnClose.Enabled")));
			this.btnClose.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnClose.FlatStyle")));
			this.btnClose.Font = ((System.Drawing.Font)(resources.GetObject("btnClose.Font")));
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClose.ImageAlign")));
			this.btnClose.ImageIndex = ((int)(resources.GetObject("btnClose.ImageIndex")));
			this.btnClose.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnClose.ImeMode")));
			this.btnClose.Location = ((System.Drawing.Point)(resources.GetObject("btnClose.Location")));
			this.btnClose.Name = "btnClose";
			this.btnClose.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnClose.RightToLeft")));
			this.btnClose.Size = ((System.Drawing.Size)(resources.GetObject("btnClose.Size")));
			this.btnClose.TabIndex = ((int)(resources.GetObject("btnClose.TabIndex")));
			this.btnClose.Text = resources.GetString("btnClose.Text");
			this.btnClose.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClose.TextAlign")));
			this.btnClose.Visible = ((bool)(resources.GetObject("btnClose.Visible")));
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.lvwUsers);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// lvwUsers
			// 
			this.lvwUsers.AccessibleDescription = resources.GetString("lvwUsers.AccessibleDescription");
			this.lvwUsers.AccessibleName = resources.GetString("lvwUsers.AccessibleName");
			this.lvwUsers.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lvwUsers.Alignment")));
			this.lvwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lvwUsers.Anchor")));
			this.lvwUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvwUsers.BackgroundImage")));
			this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.chUserNo,
																					   this.chLogin,
																					   this.chCardID,
																					   this.chFullName});
			this.lvwUsers.ContextMenu = this.contextMenu1;
			this.lvwUsers.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lvwUsers.Dock")));
			this.lvwUsers.Enabled = ((bool)(resources.GetObject("lvwUsers.Enabled")));
			this.lvwUsers.Font = ((System.Drawing.Font)(resources.GetObject("lvwUsers.Font")));
			this.lvwUsers.FullRowSelect = true;
			this.lvwUsers.GridLines = true;
			this.lvwUsers.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lvwUsers.ImeMode")));
			this.lvwUsers.LabelWrap = ((bool)(resources.GetObject("lvwUsers.LabelWrap")));
			this.lvwUsers.Location = ((System.Drawing.Point)(resources.GetObject("lvwUsers.Location")));
			this.lvwUsers.MultiSelect = false;
			this.lvwUsers.Name = "lvwUsers";
			this.lvwUsers.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lvwUsers.RightToLeft")));
			this.lvwUsers.Size = ((System.Drawing.Size)(resources.GetObject("lvwUsers.Size")));
			this.lvwUsers.TabIndex = ((int)(resources.GetObject("lvwUsers.TabIndex")));
			this.lvwUsers.Text = resources.GetString("lvwUsers.Text");
			this.lvwUsers.View = System.Windows.Forms.View.Details;
			this.lvwUsers.Visible = ((bool)(resources.GetObject("lvwUsers.Visible")));
			this.lvwUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwUsers_MouseDown);
			// 
			// chUserNo
			// 
			this.chUserNo.Text = resources.GetString("chUserNo.Text");
			this.chUserNo.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chUserNo.TextAlign")));
			this.chUserNo.Width = ((int)(resources.GetObject("chUserNo.Width")));
			// 
			// chLogin
			// 
			this.chLogin.Text = resources.GetString("chLogin.Text");
			this.chLogin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chLogin.TextAlign")));
			this.chLogin.Width = ((int)(resources.GetObject("chLogin.Width")));
			// 
			// chCardID
			// 
			this.chCardID.Text = resources.GetString("chCardID.Text");
			this.chCardID.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chCardID.TextAlign")));
			this.chCardID.Width = ((int)(resources.GetObject("chCardID.Width")));
			// 
			// chFullName
			// 
			this.chFullName.Text = resources.GetString("chFullName.Text");
			this.chFullName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chFullName.TextAlign")));
			this.chFullName.Width = ((int)(resources.GetObject("chFullName.Width")));
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.lvwGroups);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Enabled = ((bool)(resources.GetObject("groupBox2.Enabled")));
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = ((System.Drawing.Font)(resources.GetObject("groupBox2.Font")));
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			// 
			// lvwGroups
			// 
			this.lvwGroups.AccessibleDescription = resources.GetString("lvwGroups.AccessibleDescription");
			this.lvwGroups.AccessibleName = resources.GetString("lvwGroups.AccessibleName");
			this.lvwGroups.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lvwGroups.Alignment")));
			this.lvwGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lvwGroups.Anchor")));
			this.lvwGroups.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvwGroups.BackgroundImage")));
			this.lvwGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chGroupNo,
																						this.chGroupID,
																						this.chGroupName,
																						this.chGroupDescription});
			this.lvwGroups.ContextMenu = this.contextMenu2;
			this.lvwGroups.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lvwGroups.Dock")));
			this.lvwGroups.Enabled = ((bool)(resources.GetObject("lvwGroups.Enabled")));
			this.lvwGroups.Font = ((System.Drawing.Font)(resources.GetObject("lvwGroups.Font")));
			this.lvwGroups.FullRowSelect = true;
			this.lvwGroups.GridLines = true;
			this.lvwGroups.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lvwGroups.ImeMode")));
			this.lvwGroups.LabelWrap = ((bool)(resources.GetObject("lvwGroups.LabelWrap")));
			this.lvwGroups.Location = ((System.Drawing.Point)(resources.GetObject("lvwGroups.Location")));
			this.lvwGroups.MultiSelect = false;
			this.lvwGroups.Name = "lvwGroups";
			this.lvwGroups.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lvwGroups.RightToLeft")));
			this.lvwGroups.Size = ((System.Drawing.Size)(resources.GetObject("lvwGroups.Size")));
			this.lvwGroups.TabIndex = ((int)(resources.GetObject("lvwGroups.TabIndex")));
			this.lvwGroups.Text = resources.GetString("lvwGroups.Text");
			this.lvwGroups.View = System.Windows.Forms.View.Details;
			this.lvwGroups.Visible = ((bool)(resources.GetObject("lvwGroups.Visible")));
			this.lvwGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwGroups_MouseDown);
			// 
			// chGroupNo
			// 
			this.chGroupNo.Text = resources.GetString("chGroupNo.Text");
			this.chGroupNo.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chGroupNo.TextAlign")));
			this.chGroupNo.Width = ((int)(resources.GetObject("chGroupNo.Width")));
			// 
			// chGroupID
			// 
			this.chGroupID.Text = resources.GetString("chGroupID.Text");
			this.chGroupID.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chGroupID.TextAlign")));
			this.chGroupID.Width = ((int)(resources.GetObject("chGroupID.Width")));
			// 
			// chGroupName
			// 
			this.chGroupName.Text = resources.GetString("chGroupName.Text");
			this.chGroupName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chGroupName.TextAlign")));
			this.chGroupName.Width = ((int)(resources.GetObject("chGroupName.Width")));
			// 
			// chGroupDescription
			// 
			this.chGroupDescription.Text = resources.GetString("chGroupDescription.Text");
			this.chGroupDescription.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chGroupDescription.TextAlign")));
			this.chGroupDescription.Width = ((int)(resources.GetObject("chGroupDescription.Width")));
			// 
			// FrmUserAdmin
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.btnClose;
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDeleteGroup);
			this.Controls.Add(this.btnEditGroup);
			this.Controls.Add(this.btnAddGroup);
			this.Controls.Add(this.btnDeleteUser);
			this.Controls.Add(this.btnEditUser);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.groupBox1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "FrmUserAdmin";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.frmAccountInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Các hàm xử lý chính

		private AdminDO adminDO = null;

		DataSet dsUser = null;
		DataSet dsGroup = null;
		
		/// <summary>
		/// Hiển thị danh sách nhóm trong CSDL lên ListView
		/// </summary>
		public void PopulateGroupListView()
		{
			dsGroup = adminDO.GetAllGroups();
			lvwGroups.Items.Clear();
			int STT = 0;
			foreach (DataRow dr in dsGroup.Tables[0].Rows)
			{
				STT++;
				string GroupID = dr["UserGroupID"].ToString();
				string GroupName = dr["UserGroupName"].ToString();
				string Description = dr["Description"].ToString();
				
				ListViewItem tmpLVItem = new ListViewItem(STT.ToString());
				tmpLVItem.SubItems.Add(GroupID);
				tmpLVItem.SubItems.Add(GroupName);
				tmpLVItem.SubItems.Add(Description);

				lvwGroups.Items.Add(tmpLVItem);
			}
		}

		/// <summary>
		/// Hiển thị danh sách người dùng trong CSDL lên ListView
		/// </summary>
		public void PopulateUserListView()
		{
			dsUser = adminDO.GetAllUsers();
			lvwUsers.Items.Clear();
			int STT = 0;
			foreach (DataRow dr in dsUser.Tables[0].Rows)
			{
				STT++;
				string UserName = dr["UserName"].ToString();
				string CardID = dr["CardID"].ToString();
				string EmployeeName = dr["EmployeeName"].ToString();
				string Description = dr["Description"].ToString();
				
				ListViewItem tmpLVItem = new ListViewItem(STT.ToString());
				tmpLVItem.SubItems.Add(UserName);
				tmpLVItem.SubItems.Add(CardID);
				tmpLVItem.SubItems.Add(EmployeeName);
				tmpLVItem.SubItems.Add(Description);

				lvwUsers.Items.Add(tmpLVItem);
			}
		}

		/// <summary>
		/// Xóa tất cả những người dùng được chọn trên ListView
		/// </summary>
		private void DeleteUsers()
		{
			
			string str1 = WorkingContext.LangManager.GetString("frmUser_DeLUser_Loi_Title");
			if (lvwUsers.SelectedItems.Count == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmUser_DelUser_Loi_Messa");
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Error);
				return;
			}
			string str2 = WorkingContext.LangManager.GetString("frmUser_DelUser_ThongBao1_Messa");

			if (MessageBox.Show(str2, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				
				if (lvwUsers.Items.Count == 1)
				{
					string str = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteU_Error1_Messa");
					//string str1 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteU_Error1_Title");
					//MessageBox.Show("Bạn không thể xóa hết người dùng trong hệ thống! Bạn sẽ không thể đăng nhập vào hệ thống", "Xóa người dùng", MessageBoxButtons.OK,  MessageBoxIcon.Error);
					MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Error);
					return;
				}
				int ret = 0;
				try 
				{
					DataRow data = dsUser.Tables[0].Rows[lvwUsers.SelectedIndices[0]];
					string str = data["UserName"].ToString();
					if(str=="admin")
					{
						string str3 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteU_Error2_Messa");
						string str4 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
						//MessageBox.Show("Không thể xóa admin","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
						MessageBox.Show(str3,str4,MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					else
					{
						dsUser.Tables[0].Rows[lvwUsers.SelectedIndices[0]].Delete();
						ret = adminDO.DeleteUser(dsUser);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				if (ret != 0 )
				{
					string str3 = WorkingContext.LangManager.GetString("frmUser_DelUser_ThongBao2_Messa");
					MessageBox.Show(str3, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
					PopulateUserListView();
					dsUser.AcceptChanges();
				}
				else
				{
					string str3 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteU_Error3_Messa");
					//MessageBox.Show("Xóa người dùng thất bại!", str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(str3, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
					dsUser.RejectChanges();

				}
				PopulateUserListView();
			}
		}

		/// <summary>
		/// Xóa tất cả những nhóm được chọn trên ListView
		/// </summary>
		private void DeleteGroups()
		{
			string str1 = WorkingContext.LangManager.GetString("frmGroup_XoaNhom_Loi_Title");
			if (lvwGroups.SelectedItems.Count == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_XoaNhom_Loi_Messa");
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Error);
				return;
			}
			string str2 = WorkingContext.LangManager.GetString("frmGroup_XoaNhom_ThongBao1_Messa");
			if (MessageBox.Show(str2, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				int ret = 2;
				try 
				{
					DataRow data = dsGroup.Tables[0].Rows[lvwGroups.SelectedIndices[0]];
					string str = data["UserGroupID"].ToString();
					if(str=="admin" || str=="Admin")
					{
						string str3 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteG_Error1_Title");
						string str4 = WorkingContext.LangManager.GetString("frmChangePass_Thongbao1");
						//MessageBox.Show("Không thể xóa nhóm admin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
						MessageBox.Show(str3,str4,MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					else
					{
						dsGroup.Tables[0].Rows[lvwGroups.SelectedIndices[0]].Delete();
						ret = adminDO.DeleteGroup(dsGroup);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				if (ret == 1)
				{
					string str3 = WorkingContext.LangManager.GetString("frmGroup_XoaNhom_ThongBao2_Messa");
					MessageBox.Show(str3, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsGroup.AcceptChanges();
					PopulateGroupListView();
				}
				else if(ret == -1)
				{
					string str4 = WorkingContext.LangManager.GetString("frmGroup_XoaNhom_CanhBao_Messa");
					MessageBox.Show(str4, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					dsGroup.RejectChanges();
					PopulateGroupListView();
				}
				if(ret == 0)
				{
					string str3 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteG_Error2_Title");
					string str4 = WorkingContext.LangManager.GetString("frmUserAdmin_DeleteG_Error1");
					MessageBox.Show("Có lỗi xảy ra trong khi xóa nhóm !", "Xóa nhóm", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(str3, str4, MessageBoxButtons.OK, MessageBoxIcon.Error);
					dsGroup.RejectChanges();
					PopulateGroupListView();
				}
			}
		}

		/// <summary>
		/// Thêm một người dùng mới
		/// </summary>
		private void AddNewUser()
		{
			FrmUser frmUser = new FrmUser();
			frmUser.UserDataSet = dsUser;
			frmUser.ShowDialog(this);
			PopulateUserListView();
		}

		/// <summary>
		/// Sửa thông tin người dùng
		/// </summary>
		private void EditUser()
		{
			if (lvwUsers.SelectedItems.Count == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmUser_SuaNguoiDung_Loi_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmUser_SuaNguoiDung_Loi_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Error);
			}
			else 
			{
				FrmUser frmUser = new FrmUser();
				frmUser.UserDataSet = dsUser;
				frmUser.SelectedUser = lvwUsers.SelectedIndices[0];
				frmUser.ShowDialog(this);
				PopulateUserListView();
			}
		}

		/// <summary>
		/// Thêm một nhóm mới
		/// </summary>
		private void AddNewGroup()
		{
			FrmGroup frmGroup = new FrmGroup();
			frmGroup.GroupDataSet = dsGroup;
			frmGroup.lang = check;
			frmGroup.ShowDialog(this);
			PopulateUserListView();
			PopulateGroupListView();
		}

		/// <summary>
		/// Sửa thông tin nhóm
		/// </summary>
		private void EditGroup()
		{
			if (lvwGroups.SelectedItems.Count == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmGroup_SuaNhom_Loi_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmGroup_SuaNhom_Loi_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Error);
			}
			else 
			{
				FrmGroup frmGroup = new FrmGroup();
				frmGroup.GroupDataSet = dsGroup;
				frmGroup.lang = check;
				frmGroup.SelectedGroup = lvwGroups.SelectedIndices[0];
				frmGroup.ShowDialog(this);
				PopulateUserListView();
				PopulateGroupListView();
			}
		}

		#endregion

		#region Windows Forms Event Handlers

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmAccountInfo_Load(object sender, System.EventArgs e)
		{
			adminDO = new AdminDO();
			
			PopulateUserListView();
			PopulateGroupListView();
			this.Refresh();

		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			AddNewUser();
		}

		private void btnEditUser_Click(object sender, EventArgs e)
		{
			EditUser();
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			DeleteUsers();
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			AddNewGroup();
		}

		private void btnEditGroup_Click(object sender, EventArgs e)
		{
			EditGroup();	
		}

		private void btnDeleteGroup_Click(object sender, EventArgs e)
		{
			DeleteGroups();
		}

		private void mnuDeleteUser_Click(object sender, System.EventArgs e)
		{
			DeleteUsers();
		}

		private void mnuAddUser_Click(object sender, System.EventArgs e)
		{
			AddNewUser();
		}

		private void mnuEditUser_Click(object sender, System.EventArgs e)
		{
			EditUser();
		}

		private void mnuAddGroup_Click(object sender, System.EventArgs e)
		{
			AddNewGroup();
		}

		private void mnuEditGroup_Click(object sender, System.EventArgs e)
		{
			EditGroup();
		}

		private void mnuDeleteGroup_Click(object sender, System.EventArgs e)
		{
			DeleteGroups();
		}
		private void lvwUsers_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				EditUser();
			}
		}

		private void lvwGroups_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				EditGroup();
			}
		}
		#endregion
	}
}
