//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: Form định nghĩa kiểu ngày: ngày nghỉ, ngày  làm việc ..	
//Note	    :		  
//Author	: chinhnd 17-8-2005
//Modify	: 28-9 chỉnh sửa sang update dùng data Adaptor
//Tồn tại: khi thêm mới kiểu ngày hiển thị trên data grid bị lỗi, không được sửa, xóa kiểu ngày vừa thêm
//----------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
//using GlacialComponents.Controls;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// chức năng này cho phép định nghĩa các kiểu ngày nghỉ và ngày làm việc trong công ty. Các thông tin cần thiết lập là: kiểu ngày, ký hiệu ngày, số lượng ngày nghỉ cho phép( bằng 0  nếu là ngày làm việc ), hệ số lương của ngày.
	/// </summary>
	public class frmListDayType : Form
	{
		//		private DayTypeDO daytype = null;
		private DayTypeDO daytypeDO = new DayTypeDO();
		public CurrencyManager currManager;
		private DataSet dsDayType = new DataSet();
		private DataTable dtDayType = null;
		/// <summary>
		/// Biến xác định hàng được chọn hiện tại trên DataSet (Cột STT trên ListView)
		/// ban đầu chưa chọn hàng nào
		/// </summary>
		private int selectedRow = -1;
		private Button btnHelp;
		private DataGridTextBoxColumn chSTT;
		private DataGridTextBoxColumn chName;
		private System.Windows.Forms.GroupBox groupBox1;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn clSTT;
		private XPTable.Models.TextColumn clDayName;
		private XPTable.Models.TextColumn clDayShortName;
		private XPTable.Models.TextColumn clDayFactor;
		private XPTable.Models.TextColumn clQuantity;
		private XPTable.Models.Table lvwDayType;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public frmListDayType()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmListDayType));
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.chSTT = new System.Windows.Forms.DataGridTextBoxColumn();
			this.chName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwDayType = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.clSTT = new XPTable.Models.TextColumn();
			this.clDayName = new XPTable.Models.TextColumn();
			this.clDayShortName = new XPTable.Models.TextColumn();
			this.clDayFactor = new XPTable.Models.TextColumn();
			this.clQuantity = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwDayType)).BeginInit();
			this.SuspendLayout();
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
			// btnEdit
			// 
			this.btnEdit.AccessibleDescription = resources.GetString("btnEdit.AccessibleDescription");
			this.btnEdit.AccessibleName = resources.GetString("btnEdit.AccessibleName");
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnEdit.Anchor")));
			this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
			this.btnEdit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnEdit.Dock")));
			this.btnEdit.Enabled = ((bool)(resources.GetObject("btnEdit.Enabled")));
			this.btnEdit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnEdit.FlatStyle")));
			this.btnEdit.Font = ((System.Drawing.Font)(resources.GetObject("btnEdit.Font")));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEdit.ImageAlign")));
			this.btnEdit.ImageIndex = ((int)(resources.GetObject("btnEdit.ImageIndex")));
			this.btnEdit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnEdit.ImeMode")));
			this.btnEdit.Location = ((System.Drawing.Point)(resources.GetObject("btnEdit.Location")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnEdit.RightToLeft")));
			this.btnEdit.Size = ((System.Drawing.Size)(resources.GetObject("btnEdit.Size")));
			this.btnEdit.TabIndex = ((int)(resources.GetObject("btnEdit.TabIndex")));
			this.btnEdit.Text = resources.GetString("btnEdit.Text");
			this.btnEdit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnEdit.TextAlign")));
			this.btnEdit.Visible = ((bool)(resources.GetObject("btnEdit.Visible")));
			this.btnEdit.Click += new System.EventHandler(this.btnSuaNgay_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.AccessibleDescription = resources.GetString("btnAdd.AccessibleDescription");
			this.btnAdd.AccessibleName = resources.GetString("btnAdd.AccessibleName");
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnAdd.Anchor")));
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnAdd.Dock")));
			this.btnAdd.Enabled = ((bool)(resources.GetObject("btnAdd.Enabled")));
			this.btnAdd.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnAdd.FlatStyle")));
			this.btnAdd.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Font")));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAdd.ImageAlign")));
			this.btnAdd.ImageIndex = ((int)(resources.GetObject("btnAdd.ImageIndex")));
			this.btnAdd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnAdd.ImeMode")));
			this.btnAdd.Location = ((System.Drawing.Point)(resources.GetObject("btnAdd.Location")));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnAdd.RightToLeft")));
			this.btnAdd.Size = ((System.Drawing.Size)(resources.GetObject("btnAdd.Size")));
			this.btnAdd.TabIndex = ((int)(resources.GetObject("btnAdd.TabIndex")));
			this.btnAdd.Text = resources.GetString("btnAdd.Text");
			this.btnAdd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAdd.TextAlign")));
			this.btnAdd.Visible = ((bool)(resources.GetObject("btnAdd.Visible")));
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AccessibleDescription = resources.GetString("btnDelete.AccessibleDescription");
			this.btnDelete.AccessibleName = resources.GetString("btnDelete.AccessibleName");
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDelete.Anchor")));
			this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
			this.btnDelete.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDelete.Dock")));
			this.btnDelete.Enabled = ((bool)(resources.GetObject("btnDelete.Enabled")));
			this.btnDelete.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDelete.FlatStyle")));
			this.btnDelete.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Font")));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDelete.ImageAlign")));
			this.btnDelete.ImageIndex = ((int)(resources.GetObject("btnDelete.ImageIndex")));
			this.btnDelete.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDelete.ImeMode")));
			this.btnDelete.Location = ((System.Drawing.Point)(resources.GetObject("btnDelete.Location")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDelete.RightToLeft")));
			this.btnDelete.Size = ((System.Drawing.Size)(resources.GetObject("btnDelete.Size")));
			this.btnDelete.TabIndex = ((int)(resources.GetObject("btnDelete.TabIndex")));
			this.btnDelete.Text = resources.GetString("btnDelete.Text");
			this.btnDelete.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDelete.TextAlign")));
			this.btnDelete.Visible = ((bool)(resources.GetObject("btnDelete.Visible")));
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.AccessibleDescription = resources.GetString("btnHelp.AccessibleDescription");
			this.btnHelp.AccessibleName = resources.GetString("btnHelp.AccessibleName");
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnHelp.Anchor")));
			this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
			this.btnHelp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnHelp.Dock")));
			this.btnHelp.Enabled = ((bool)(resources.GetObject("btnHelp.Enabled")));
			this.btnHelp.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnHelp.FlatStyle")));
			this.btnHelp.Font = ((System.Drawing.Font)(resources.GetObject("btnHelp.Font")));
			this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
			this.btnHelp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnHelp.ImageAlign")));
			this.btnHelp.ImageIndex = ((int)(resources.GetObject("btnHelp.ImageIndex")));
			this.btnHelp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnHelp.ImeMode")));
			this.btnHelp.Location = ((System.Drawing.Point)(resources.GetObject("btnHelp.Location")));
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnHelp.RightToLeft")));
			this.btnHelp.Size = ((System.Drawing.Size)(resources.GetObject("btnHelp.Size")));
			this.btnHelp.TabIndex = ((int)(resources.GetObject("btnHelp.TabIndex")));
			this.btnHelp.Text = resources.GetString("btnHelp.Text");
			this.btnHelp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnHelp.TextAlign")));
			this.btnHelp.Visible = ((bool)(resources.GetObject("btnHelp.Visible")));
			// 
			// chSTT
			// 
			this.chSTT.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chSTT.Alignment")));
			this.chSTT.Format = "";
			this.chSTT.FormatInfo = null;
			this.chSTT.HeaderText = resources.GetString("chSTT.HeaderText");
			this.chSTT.MappingName = resources.GetString("chSTT.MappingName");
			this.chSTT.NullText = resources.GetString("chSTT.NullText");
			this.chSTT.Width = ((int)(resources.GetObject("chSTT.Width")));
			// 
			// chName
			// 
			this.chName.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chName.Alignment")));
			this.chName.Format = "";
			this.chName.FormatInfo = null;
			this.chName.HeaderText = resources.GetString("chName.HeaderText");
			this.chName.MappingName = resources.GetString("chName.MappingName");
			this.chName.NullText = resources.GetString("chName.NullText");
			this.chName.Width = ((int)(resources.GetObject("chName.Width")));
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.lvwDayType);
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
			// lvwDayType
			// 
			this.lvwDayType.AccessibleDescription = resources.GetString("lvwDayType.AccessibleDescription");
			this.lvwDayType.AccessibleName = resources.GetString("lvwDayType.AccessibleName");
			this.lvwDayType.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwDayType.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lvwDayType.Anchor")));
			this.lvwDayType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwDayType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvwDayType.BackgroundImage")));
			this.lvwDayType.ColumnModel = this.columnModel1;
			this.lvwDayType.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lvwDayType.Dock")));
			this.lvwDayType.Enabled = ((bool)(resources.GetObject("lvwDayType.Enabled")));
			this.lvwDayType.EnableToolTips = true;
			this.lvwDayType.Font = ((System.Drawing.Font)(resources.GetObject("lvwDayType.Font")));
			this.lvwDayType.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwDayType.FullRowSelect = true;
			this.lvwDayType.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwDayType.GridLines = XPTable.Models.GridLines.Both;
			this.lvwDayType.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwDayType.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwDayType.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lvwDayType.ImeMode")));
			this.lvwDayType.Location = ((System.Drawing.Point)(resources.GetObject("lvwDayType.Location")));
			this.lvwDayType.Name = "lvwDayType";
			this.lvwDayType.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lvwDayType.RightToLeft")));
			this.lvwDayType.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwDayType.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwDayType.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwDayType.Size = ((System.Drawing.Size)(resources.GetObject("lvwDayType.Size")));
			this.lvwDayType.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwDayType.TabIndex = ((int)(resources.GetObject("lvwDayType.TabIndex")));
			this.lvwDayType.TableModel = this.tableModel1;
			this.lvwDayType.Text = resources.GetString("lvwDayType.Text");
			this.lvwDayType.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwDayType.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwDayType.Visible = ((bool)(resources.GetObject("lvwDayType.Visible")));
			this.lvwDayType.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwDayType_SelectionChanged);
			this.lvwDayType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwDayType_MouseDown);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.clSTT,
																			   this.clDayName,
																			   this.clDayShortName,
																			   this.clDayFactor,
																			   this.clQuantity});
			// 
			// clSTT
			// 
			this.clSTT.Editable = false;
			this.clSTT.Text = "STT";
			this.clSTT.Width = 50;
			// 
			// clDayName
			// 
			this.clDayName.Editable = false;
			this.clDayName.Text = "Tên kiểu ngày";
			this.clDayName.Width = 140;
			// 
			// clDayShortName
			// 
			this.clDayShortName.Editable = false;
			this.clDayShortName.Text = "Ký hiệu ngày";
			this.clDayShortName.Width = 90;
			// 
			// clDayFactor
			// 
			this.clDayFactor.Editable = false;
			this.clDayFactor.Text = "Hệ số ngày";
			this.clDayFactor.Width = 90;
			// 
			// clQuantity
			// 
			this.clQuantity.Editable = false;
			this.clQuantity.Text = "Số ngày nghỉ";
			this.clQuantity.Width = 90;
			// 
			// frmListDayType
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
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "frmListDayType";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.frmListDayType_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwDayType)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmDayType frm = new frmDayType();
			frm.DsDayType = dsDayType;
			frm.ShowDialog();
			PopulateDayType();
			selectedRow = -1;// sau khi xóa xong thì đưa vị trí con trỏ về -1
			tableModel1.Selections.Clear();

		}

		private void frmListDayType_Load(object sender, EventArgs e)
		{
			Refresh();
			PopulateDayType();
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
			this.Text = WorkingContext.LangManager.GetString("frmListDayType_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListDayType_GroupBox1");
			this.clSTT.Text = WorkingContext.LangManager.GetString("frmListDayType_lvwDayType_STT");
			this.clDayName.Text = WorkingContext.LangManager.GetString("frmListDayType_lvwDayType_TenKieuNgay");
			this.clDayShortName.Text = WorkingContext.LangManager.GetString("frmListDayType_lvwDayType_KyHieuNgay");
			this.clDayFactor.Text = WorkingContext.LangManager.GetString("frmListDayType_lvwDayType_HeSoNgay");
			this.clQuantity.Text = WorkingContext.LangManager.GetString("frmListDayType_lvwDayType_SoNgayNghi");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmListDayType_bntHelp");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListDayType_bntAdd");
			this.btnEdit.Text = WorkingContext.LangManager.GetString("frmListDayType_bntUpDate");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListDayType_bntDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListDayType_bntClose");
			this.lvwDayType.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			
		}
		/// <summary>
		/// Hiển thị các kiểu ngày đã định nghĩa
		/// </summary>
		private void PopulateDayType()
		{
			dsDayType = daytypeDO.GetDayType();
			dtDayType = dsDayType.Tables[0];
			lvwDayType.BeginUpdate();
			lvwDayType.TableModel.Rows.Clear();
			int STT = 0;
			foreach(DataRow dr in dtDayType.Rows)
			{
				STT++;
				string DayName = dr["DayName"].ToString();
				string DayShortName = dr["DayShortName"].ToString();
				string DayFactor = dr["DayFactor"].ToString();
//				string Quantity = dr["Quantity"].ToString();
				Row row = new Row(new string[]{STT.ToString(),DayName,DayShortName,DayFactor});
				row.Tag = STT-1;
				lvwDayType.TableModel.Rows.Add(row);
			}
			lvwDayType.EndUpdate();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(selectedRow < 0 )
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Delete_Error_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Delete_Error_Title");
				//MessageBox.Show("Bạn chưa kiểu ngày nào!", "Xóa kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Delete_ThongBao_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Delete_Error_Title");
				//confirm lại có chắc chắn muốn xóa kiểu ngày này ko?
				DialogResult dr = MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					DeleteDayType();
					PopulateDayType();
				}
				else
				{
					dsDayType.RejectChanges();
				}
			}
			selectedRow = -1;// sau khi xóa xong thì đưa vị trí con trỏ về -1
			tableModel1.Selections.Clear();
			
		}
		/// <summary>
		/// Xóa kiểu ngày
		/// </summary>
		private void DeleteDayType()
		{
			int ret = 0;
			try
			{
				dtDayType.Rows[selectedRow].Delete();
				ret = daytypeDO.DeleteDayTypeDB(dsDayType);
			}
			catch
			{
				dtDayType.RejectChanges();
			}
			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Delete_ThongBao_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Delete_Error_Title");
				//MessageBox.Show("Kiểu ngày đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dtDayType.AcceptChanges();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Delete_ThongBao_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Delete_Error_Title");
				//MessageBox.Show("Không thể xóa kiểu ngày khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtDayType.RejectChanges();
			}
		}
		private void btnSuaNgay_Click(object sender, System.EventArgs e)
		{
			if(selectedRow >= 0)
			{
				frmDayType frm = new frmDayType();
				frm.DsDayType = dsDayType;
				frm.SelectedRowIndex = selectedRow;
				frm.ShowDialog();
				PopulateDayType();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_UpDate_Error_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_UpDate_Error_Title");
				//MessageBox.Show("Bạn chưa chọn kiểu ngày cần sửa", "Sửa kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			selectedRow = -1;// sau khi sửa xong thì đưa vị trí con trỏ về -1
			tableModel1.Selections.Clear();
		}

		private void lvwDayType_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if(e.NewSelectedIndicies.Length > 0)
			{
				selectedRow = (int)lvwDayType.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}

		private void lvwDayType_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if(lvwDayType.SelectedItems.Length > 0)
				{
					frmDayType frm = new frmDayType();
					frm.DsDayType = dsDayType;
					frm.SelectedRowIndex = selectedRow;
					frm.ShowDialog();
					PopulateDayType();
				}
				selectedRow = -1;
				tableModel1.Selections.Clear();
			}
		}
	}
}