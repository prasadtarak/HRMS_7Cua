using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmLunch.
	/// </summary>
	public class frmLunch : Form
	{
		#region Window Form generated code
		private Button btnClose;
		private DepartmentTreeView departmentTreeView;
		private ColumnModel columnModel1;
		private TableModel tableModel1;
		private TextColumn chEmployeeName;
		private TextColumn chCardID;
		private Button btnSet;
		private LookupComboBox cboLunchMoney;
		private GroupBox groupBox1;
		private Button btnSlectAll;
		private Button btnClearAll;
		private DateTimePicker dtpWorkingDay;
		private TextColumn chLunchMoney;
		private Table lvwLunch;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private ContextMenu contextMenu1;
		private MenuItem mnuSet;
		private Button btn_LoadPrevious;
		private XPTable.Models.TextColumn chDepartmentName;
		private XPTable.Models.NumberColumn chSTT;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblTotalEmployee;
		private System.Windows.Forms.Label lblHaveLunch;
		private System.Windows.Forms.Label lblLunchMoney;
        private System.Windows.Forms.Button btImportEmployeeToLunch;
        private Button button1;
        private Button bntXoa;
        private MenuItem menuXoa;
        private IContainer components;

		public frmLunch()
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunch));
            this.btnClose = new System.Windows.Forms.Button();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.chSTT = new XPTable.Models.NumberColumn();
            this.chDepartmentName = new XPTable.Models.TextColumn();
            this.chCardID = new XPTable.Models.TextColumn();
            this.chEmployeeName = new XPTable.Models.TextColumn();
            this.chLunchMoney = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnSet = new System.Windows.Forms.Button();
            this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
            this.cboLunchMoney = new System.Windows.Forms.LookupComboBox();
            this.btnSlectAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLunchMoney = new System.Windows.Forms.Label();
            this.lblHaveLunch = new System.Windows.Forms.Label();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.lvwLunch = new XPTable.Models.Table();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuSet = new System.Windows.Forms.MenuItem();
            this.menuXoa = new System.Windows.Forms.MenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_LoadPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btImportEmployeeToLunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwLunch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(716, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeView.BackColor = System.Drawing.Color.GhostWhite;
            this.departmentTreeView.DepartmentDataSet = null;
            this.departmentTreeView.ImageIndex = 0;
            this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.SelectedImageIndex = 0;
            this.departmentTreeView.Size = new System.Drawing.Size(200, 384);
            this.departmentTreeView.TabIndex = 3;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.chSTT,
            this.chDepartmentName,
            this.chCardID,
            this.chEmployeeName,
            this.chLunchMoney});
            // 
            // chSTT
            // 
            this.chSTT.Editable = false;
            this.chSTT.Text = "STT";
            this.chSTT.Width = 40;
            // 
            // chDepartmentName
            // 
            this.chDepartmentName.Editable = false;
            this.chDepartmentName.Text = "Bộ phận";
            this.chDepartmentName.Width = 100;
            // 
            // chCardID
            // 
            this.chCardID.Editable = false;
            this.chCardID.Text = "Mã thẻ";
            this.chCardID.Width = 60;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.Editable = false;
            this.chEmployeeName.Text = "Tên nhân viên";
            this.chEmployeeName.Width = 130;
            // 
            // chLunchMoney
            // 
            this.chLunchMoney.Editable = false;
            this.chLunchMoney.Text = "Mức ăn trưa";
            this.chLunchMoney.Width = 110;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSet.Location = new System.Drawing.Point(473, 480);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "&Thiết lập";
            this.btnSet.Click += new System.EventHandler(this.btnSetLunch_Click);
            // 
            // dtpWorkingDay
            // 
            this.dtpWorkingDay.CustomFormat = "dd/MM/yyyy    ";
            this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkingDay.Location = new System.Drawing.Point(8, 16);
            this.dtpWorkingDay.Name = "dtpWorkingDay";
            this.dtpWorkingDay.Size = new System.Drawing.Size(200, 20);
            this.dtpWorkingDay.TabIndex = 74;
            this.dtpWorkingDay.ValueChanged += new System.EventHandler(this.dtpWorkingDay_ValueChanged);
            // 
            // cboLunchMoney
            // 
            this.cboLunchMoney.AllowTypeAllSymbols = true;
            this.cboLunchMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLunchMoney.Items.AddRange(new object[] {
            "Chưa thiết lập",
            "15000",
            "16000",
            "25000"});
            this.cboLunchMoney.Location = new System.Drawing.Point(8, 16);
            this.cboLunchMoney.Name = "cboLunchMoney";
            this.cboLunchMoney.Size = new System.Drawing.Size(548, 21);
            this.cboLunchMoney.TabIndex = 76;
            // 
            // btnSlectAll
            // 
            this.btnSlectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSlectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSlectAll.Location = new System.Drawing.Point(8, 376);
            this.btnSlectAll.Name = "btnSlectAll";
            this.btnSlectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSlectAll.TabIndex = 5;
            this.btnSlectAll.Text = "Chọn tất";
            this.btnSlectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearAll.Location = new System.Drawing.Point(88, 377);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Bỏ chọn";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblLunchMoney);
            this.groupBox1.Controls.Add(this.lblHaveLunch);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.Controls.Add(this.btnSlectAll);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.lvwLunch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(232, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 408);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đăng ký ăn trưa";
            // 
            // lblLunchMoney
            // 
            this.lblLunchMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLunchMoney.Location = new System.Drawing.Point(448, 376);
            this.lblLunchMoney.Name = "lblLunchMoney";
            this.lblLunchMoney.Size = new System.Drawing.Size(104, 23);
            this.lblLunchMoney.TabIndex = 81;
            this.lblLunchMoney.Text = "Số tiền: 0";
            this.lblLunchMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHaveLunch
            // 
            this.lblHaveLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHaveLunch.Location = new System.Drawing.Point(344, 376);
            this.lblHaveLunch.Name = "lblHaveLunch";
            this.lblHaveLunch.Size = new System.Drawing.Size(104, 23);
            this.lblHaveLunch.TabIndex = 80;
            this.lblHaveLunch.Text = "Số ăn trưa: 0";
            this.lblHaveLunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmployee.Location = new System.Drawing.Point(208, 376);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(128, 23);
            this.lblTotalEmployee.TabIndex = 79;
            this.lblTotalEmployee.Text = "Số nhân viên: 0";
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwLunch
            // 
            this.lvwLunch.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwLunch.ColumnModel = this.columnModel1;
            this.lvwLunch.ContextMenu = this.contextMenu1;
            this.lvwLunch.EnableToolTips = true;
            this.lvwLunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwLunch.FullRowSelect = true;
            this.lvwLunch.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwLunch.GridLines = XPTable.Models.GridLines.Both;
            this.lvwLunch.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwLunch.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwLunch.Location = new System.Drawing.Point(8, 16);
            this.lvwLunch.MultiSelect = true;
            this.lvwLunch.Name = "lvwLunch";
            this.lvwLunch.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwLunch.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwLunch.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwLunch.Size = new System.Drawing.Size(544, 352);
            this.lvwLunch.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwLunch.TabIndex = 11;
            this.lvwLunch.TableModel = this.tableModel1;
            this.lvwLunch.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwLunch.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSet,
            this.menuXoa});
            // 
            // mnuSet
            // 
            this.mnuSet.Index = 0;
            this.mnuSet.Text = "&Thiết lập...";
            this.mnuSet.Click += new System.EventHandler(this.btnSetLunch_Click);
            // 
            // menuXoa
            // 
            this.menuXoa.Index = 1;
            this.menuXoa.Text = "&Xóa thiết lập";
            this.menuXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.departmentTreeView);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 408);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng ban";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cboLunchMoney);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(232, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 48);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mức ăn trưa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpWorkingDay);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 48);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ngày";
            // 
            // btn_LoadPrevious
            // 
            this.btn_LoadPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadPrevious.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_LoadPrevious.Location = new System.Drawing.Point(635, 480);
            this.btn_LoadPrevious.Name = "btn_LoadPrevious";
            this.btn_LoadPrevious.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadPrevious.TabIndex = 4;
            this.btn_LoadPrevious.Text = "&Sao chép ...";
            this.btn_LoadPrevious.Click += new System.EventHandler(this.CopyFromPreviousLunch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(142, 481);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(8, 481);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btImportEmployeeToLunch
            // 
            this.btImportEmployeeToLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImportEmployeeToLunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btImportEmployeeToLunch.Location = new System.Drawing.Point(554, 480);
            this.btImportEmployeeToLunch.Name = "btImportEmployeeToLunch";
            this.btImportEmployeeToLunch.Size = new System.Drawing.Size(75, 23);
            this.btImportEmployeeToLunch.TabIndex = 3;
            this.btImportEmployeeToLunch.Text = "&Import...";
            this.btImportEmployeeToLunch.Click += new System.EventHandler(this.btImportEmployeeToLunch_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(280, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Tự Động Thiết Lập...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntXoa.Enabled = false;
            this.bntXoa.Location = new System.Drawing.Point(392, 480);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 1;
            this.bntXoa.Text = "Xóa thiết lập";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // frmLunch
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(804, 510);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_LoadPrevious);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btImportEmployeeToLunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập ăn trưa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLunch_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwLunch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Các biến tự định nghĩa
		/// <summary>
		/// 
		/// </summary>
		private DepartmentDO departmentDO = null;
		/// <summary>
		/// 
		/// </summary>
		private EmployeeDO employeeDO = null;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsEmployee = null;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsLunch = null;
		/// <summary>
		/// 
		/// </summary>
		private LunchDO lunchDO = null;
		/// <summary>
		/// 
		/// </summary>
		private DataRow[] LunchDataRows = null;
		/// <summary>
		/// 
		/// </summary>
		private DataRow[] EmployeeDataRows = null;
		/// <summary>
		/// 
		/// </summary>
		private string dataFilter = "";
		/// <summary>
		/// 
		/// </summary>
		private string dataSort = "";
		/// <summary>
		/// 
		/// </summary>
		public DateTime previousWorkingDay;
		/// <summary>
		/// thiết lập trạng thái copy dữ liệu ăn trưa từ một ngày đã đăng ký ăn trưa, 0: không đồng ý copy, 1: đồng ý copy
		/// </summary>
		public int CopyFromPreviousLunchStatus = 0;
		
		#endregion 

		#region Các hàm khai báo
		/// <summary>
		/// Hiển thị danh sách đăng ký ăn trưa lên listview
		/// </summary>
		private void PopulateLunchList()
		{
			dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);

			//dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
            dsEmployee = employeeDO.GetEmployeeForSettingLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
			LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);
			EmployeeDataRows = dsEmployee.Tables[0].Select(dataFilter, dataSort);
            if (dsLunch.Tables[0].Rows.Count > 0)
            {
                bntXoa.Enabled = true;
            }
            else
                bntXoa.Enabled = false;
            
			lvwLunch.BeginUpdate();
			lvwLunch.TableModel.Rows.Clear();

			// Hiển thị những người trong danh sách đã đăng ký ăn trưa ra màn hình
			if(dsLunch.Tables[0].Rows.Count >0)
			{
				int STT = 0;
				int HaveLunch = 0;
				double TotalLunchMoney = 0;
				foreach (DataRow dr in LunchDataRows)
				{
					string CardID = dr["CardID"].ToString();
					string EmployeeName = dr["EmployeeName"].ToString();
					string DepartmentName = dr["DepartmentName"].ToString();
					string LunchMoney;
					if (dr["LunchMoney"] != DBNull.Value) 
					{
						LunchMoney = Double.Parse(dr["LunchMoney"].ToString()).ToString();
						TotalLunchMoney += Double.Parse(dr["LunchMoney"].ToString());
						HaveLunch++;
					}
					else
					{
						LunchMoney = "Chưa thiết lập";
					}
					Cell[] Lunch = new Cell[5];
					Lunch[0] = new Cell(STT+1);
					Lunch[1] = new Cell(DepartmentName);
					Lunch[2] = new Cell(CardID);
					Lunch[3] = new Cell(EmployeeName);
					Lunch[4] = new Cell(LunchMoney);
					Row row = new Row(Lunch);
					row.Tag = STT;
					lvwLunch.TableModel.Rows.Add(row);
					STT++;
				}
				string str = WorkingContext.LangManager.GetString("frmLunch_lblTotalEm1");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_lblTotalLunch1");
				string str2 = WorkingContext.LangManager.GetString("frmLunch_lblTotalLunchMoney");

				lblTotalEmployee.Text = str + LunchDataRows.Length;
				lblHaveLunch.Text = str1 + HaveLunch;
				lblLunchMoney.Text = str2 + TotalLunchMoney;
			}
				//Hiển thị danh sách những người chưa đăng ký ăn trưa
			else
			{
				int STT = 0;
				foreach (DataRow dr in EmployeeDataRows)
				{
					string CardID = dr["CardID"].ToString();
					string EmployeeName = dr["EmployeeName"].ToString();
					string DepartmentName = dr["DepartmentName"].ToString();
					string LunchMoney = "Chưa thiết lập";
					Cell[] Lunch = new Cell[5];
					Lunch[0] = new Cell(STT+1);
					Lunch[1] = new Cell(DepartmentName);
					Lunch[2] = new Cell(CardID);
					Lunch[3] = new Cell(EmployeeName);
					Lunch[4] = new Cell(LunchMoney);
					Row row = new Row(Lunch);
					row.Tag = STT;
					lvwLunch.TableModel.Rows.Add(row);
					STT++;
				}
				string str = WorkingContext.LangManager.GetString("frmLunch_lblTotalEm1");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_lblTotalLunch1");
				lblTotalEmployee.Text = str + " : " + EmployeeDataRows.Length;
				lblHaveLunch.Text = str1 + " : 0";
			}
			lvwLunch.EndUpdate();
        }

        #region Các hàm thực hiện thiết lập mới và cập nhật ăn trưa
        /// <summary>
		/// Điền mức ăn trưa bằng Null cho tất cả các nhân viên trong công ty trong ngày được chọn
		/// </summary>
		private void AddLunch()
		{
			//dsEmployee = employeeDO.GetEmployeeByDepartment(1);
            dsEmployee = employeeDO.GetEmployeeForSettingLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
			int ret = 0;
			try
			{
				foreach(DataRow row in dsEmployee.Tables[0].Rows)
				{
					DataRow dr = dsLunch.Tables[0].NewRow();
					dr.BeginEdit();
					dr["EmployeeID"] = row["EmployeeID"];
					dr["WorkingDay"] = dtpWorkingDay.Value.Date;
					dr.EndEdit();
					dsLunch.Tables[0].Rows.Add(dr);
				}	
				ret = lunchDO.AddLunch(dsLunch);
			}
			catch
			{
				
			}
			if (ret != 0)
			{
				dsLunch.AcceptChanges();
				UpdateLunch();	
			}
			else
			{
				dsLunch.RejectChanges();
				string str = WorkingContext.LangManager.GetString("frmLunch_AddLunch_ThongBao");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_AddLunch_Title");
				//MessageBox.Show("Không thể thêm đăng ký ăn trưa", "Đăng ký ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// Thiết lập tiền ăn trưa cho các nhân viên của toàn công ty theo từng ngày
        /// </summary>
        /// <param name="DayNow"></param>
        private void AddLunchOneDay(DateTime DayNow)
        {
            //dsEmployee = employeeDO.GetEmployeeByDepartment(1);
            dsEmployee = employeeDO.GetEmployeeForSettingLunch(1, dtpWorkingDay.Value.Date);
            foreach (DataRow row in dsEmployee.Tables[0].Rows)
            {
                int EmployeeID = (int)row["EmployeeID"];
                decimal MoneyLuch = Convert.ToDecimal(cboLunchMoney.Text);
                lunchDO.AddLunchAuto(EmployeeID, DayNow, MoneyLuch);
            } 
        }

		/// <summary>
		/// Cập nhật đăng ký ăn trưa
		/// </summary>
		private void UpdateLunch()
		{
			frmMessage frmMessage = new frmMessage();
			string LunchMessage = "";
			int STT = 0;

			int ret = 0;
			try 
			{
				dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
				LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);
				for (int i=0;i<lvwLunch.SelectedIndicies.Length;i++)
				{
					// chỉ số hàng được chọn
					int rowIndex = (int)lvwLunch.SelectedItems[i].Tag;
					DataRow dr = LunchDataRows[rowIndex];
					dr.BeginEdit();
					if(cboLunchMoney.SelectedIndex == 0)//nếu chọn chưa thiết lập thì ghi giá trị Null vào Database
					{
						dr["LunchMoney"] = DBNull.Value;
					}
					else
					{
						dr["LunchMoney"] = cboLunchMoney.Text;	
					}
					dr.EndEdit();
					ret = lunchDO.UpdateLunch(dsLunch);

					// Thông báo và không cập nhật nếu nhân viên đăng ký ăn trưa trùng với đăng ký nghỉ hoặc đi công tác
					if(ret == EmployeeStatus.EMPLOYEE_LEAVE)
					{
						LunchMessage = dr["CardID"]+" - "+dr["EmployeeName"]+" đã đi công tác";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}

					if(ret == EmployeeStatus.EMPLOYEE_REST)
					{
						LunchMessage = dr["CardID"]+" - "+dr["EmployeeName"]+" đã đăng ký nghỉ";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}
					else if(ret == EmployeeStatus.EMPLOYEE_ABSENT)
					{
						LunchMessage = dr["CardID"]+" - "+dr["EmployeeName"]+" vắng mặt";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}				
				}
			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}
			if (STT != 0)
			{
				frmMessage.Show();
			}
			else //Thông báo thiết lập ăn trưa thành công
			{
				frmMessage.Close();
				string str = WorkingContext.LangManager.GetString("frmLunch_SetLunch_ThongBao1");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_SetLunch_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void UpdateLunchOneDay(DateTime DayNow)
        {
            frmMessage frmMessage = new frmMessage();
            //string LunchMessage = "";
            int STT = 0;

            int ret = 0;
            try
            {
                dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, DayNow);
                LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);
                for (int i = 0; i < lvwLunch.SelectedIndicies.Length; i++)
                {
                    // chỉ số hàng được chọn
                    int rowIndex = (int)lvwLunch.SelectedItems[i].Tag;
                    DataRow dr = LunchDataRows[rowIndex];
                    dr.BeginEdit();
                    if (cboLunchMoney.SelectedIndex == 0)//nếu chọn chưa thiết lập thì ghi giá trị Null vào Database
                    {
                        dr["LunchMoney"] = DBNull.Value;
                    }
                    else
                    {
                        dr["LunchMoney"] = cboLunchMoney.Text;
                    }
                    dr.EndEdit();
                    ret = lunchDO.UpdateLunch(dsLunch);
                }
            }
            catch
            {
                string str = WorkingContext.LangManager.GetString("frmLunch_SetLunch_ThongBao");
                string str1 = WorkingContext.LangManager.GetString("frmLunch_SetLunch_Title");
                //MessageBox.Show("Có lỗi xảy ra khi cập nhật dữ liệu ăn trưa", "Thiết lập ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (STT != 0)
            {
                frmMessage.Show();
            }
           
        }

        /// <summary>
        /// cập nhật dữ liệu đăng ký ăn trưa từ một ngày trước
        /// </summary>
        private void UpdateFromPreviousLunch()
        {
            frmMessage frmMessage = new frmMessage();
            string LunchMessage = "";
            int STT = 0;

            dsLunch = lunchDO.GetLunch(1, dtpWorkingDay.Value.Date);
            int ret = 0;
            try
            {
                foreach (DataRow row in dsLunch.Tables[0].Rows)
                {
                    DataRow dr = row;
                    dr.BeginEdit();
                    dr["EmployeeID"] = row["EmployeeID"];
                    dr["WorkingDay"] = dtpWorkingDay.Value.Date;
                    //					dr["LunchMoney"] = 0;
                    dr.EndEdit();
                    ret = lunchDO.UpdateFromPreviousLunch(dsLunch, DateTime.Parse(previousWorkingDay.ToShortDateString()));
                    // Thông báo và không cập nhật nếu nhân viên đăng ký ăn trưa trùng với đăng ký nghỉ hoặc đi công tác
                    if (ret == EmployeeStatus.EMPLOYEE_LEAVE)
                    {
                        LunchMessage = dr["CardID"] + " - " + dr["EmployeeName"] + " đã đi công tác";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
                    }

                    if (ret == EmployeeStatus.EMPLOYEE_REST)
                    {
                        LunchMessage = dr["CardID"] + " - " + dr["EmployeeName"] + " đã đăng ký nghỉ";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
                    }
                    else if (ret == EmployeeStatus.EMPLOYEE_ABSENT)
                    {
                        LunchMessage = dr["CardID"] + " - " + dr["EmployeeName"] + " vắng mặt";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
                    }
                }
            }
            catch
            {

            }
            if (STT != 0)
            {
                frmMessage.Show();
            }
            else
            {
                frmMessage.Close();
                string str = WorkingContext.LangManager.GetString("frmLunch_SetLunch_ThongBao1");
                string str1 = WorkingContext.LangManager.GetString("frmLunch_SetLunch_Title");
                //MessageBox.Show("Thiết lập ăn trưa thành công!", "Thiết lập ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Tự động cập nhật tiền ăn trưa cho nhân viên cho toàn công ty theo từng ngày
        /// </summary>
        /// <param name="DayNow">Ngày thiết lập</param>
        private void UpdateLunchByDay(DateTime DayNow)
        {
            //nếu số tiền được chọn không phải là "chưa thiết lập"
            if (cboLunchMoney.SelectedIndex != 0)
            {
                string errStr = CheckInputData();
                if (errStr != "") //Lỗi nhập dữ liệu và thao tác của người dùng
                {
                    string str = WorkingContext.LangManager.GetString("frmLunch_Messa5");
                    MessageBox.Show(errStr, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AddLunchOneDay(DayNow);
                }
            }
        }
        #endregion

        #region Các hàm kiểm tra dữ liệu
        /// <summary>
        /// Kiểm tra  số tiền nhập vào qua combobox
        /// </summary>
        /// <returns></returns>
        private String CheckInputData()
        {
            if (lvwLunch.SelectedIndicies.Length <= 0) //Lỗi chưa chọn nhân viên để thiết lập
            {
                string str = WorkingContext.LangManager.GetString("frmLunch_Messa1");
                return str;
            }

            if (cboLunchMoney.Text == "") //Lỗi chưa nhập số tiền cần thiết lập
            {
                string str = WorkingContext.LangManager.GetString("frmLunch_Messa2");
                return str;
            }
            else
            {
                try
                {
                    if (int.Parse(cboLunchMoney.Text) <= 0) //Lỗi số tiền <= 0
                    {
                        string str = WorkingContext.LangManager.GetString("frmLunch_Messa3");
                        return str;
                    }
                }
                catch
                {
                    string str = WorkingContext.LangManager.GetString("frmLunch_Messa4");
                    return str;
                }
            }
            return "";
        }

		/// <summary>
		/// Kiểm tra điều kiện để sao chép dữ liệu ăn trưa 
		/// </summary>
		/// <returns></returns>
		private String CheckCopyLunch()
		{
			DataSet dsPreviousLunch = lunchDO.GetLunch(1,previousWorkingDay);
			if(dsPreviousLunch.Tables[0].Rows.Count <= 0)//nếu ngày sao chép chưa có dữ liệu
			{
				string str = WorkingContext.LangManager.GetString("frmLunch_groupbox4");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_Messa7");
				//return "Ngày " + previousWorkingDay.ToString("dd/MM/yyyy") + " chưa thiết lập ăn trưa";
				return str + previousWorkingDay.ToString("dd/MM/yyyy") + str1;
			}
			return "";
		}

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
                CheckNodesRec(n, check);
            }
        }
        #endregion

        /// <summary>
		/// 
		/// </summary>
		private void CopyFromPreviousLunch()
		{
			frmMessage frmMessage = new frmMessage();
            
			string LunchMessage = "";
			int STT = 0;

			dsEmployee = employeeDO.GetEmployeeByDepartment(1);
			int ret = 0;
			try
			{
				foreach(DataRow row in dsEmployee.Tables[0].Rows)
				{
					DataRow dr = dsLunch.Tables[0].NewRow();
					dr.BeginEdit();
					dr["EmployeeID"] = row["EmployeeID"];
					dr["WorkingDay"] = dtpWorkingDay.Value.Date;
					//					dr["LunchMoney"] = 0;
					dr.EndEdit();
					dsLunch.Tables[0].Rows.Add(dr);
					ret = lunchDO.CopyFromPreviousLunch(dsLunch,DateTime.Parse(previousWorkingDay.ToShortDateString()));
					
					if(ret == EmployeeStatus.EMPLOYEE_LEAVE)
					{
						LunchMessage = row["CardID"]+" - "+row["EmployeeName"]+" đã đi công tác";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}

					if(ret == EmployeeStatus.EMPLOYEE_REST)
					{
						LunchMessage = row["CardID"]+" - "+row["EmployeeName"]+" đã đăng ký nghỉ";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}
					else if(ret == EmployeeStatus.EMPLOYEE_ABSENT)
					{
						LunchMessage = row["CardID"]+" - "+row["EmployeeName"]+" vắng mặt";
						STT++;
						frmMessage.AddMessage(STT.ToString() + ". " + LunchMessage);
					}
				}	
			}
			catch
			{
				
			}
			if (STT != 0)
			{
				frmMessage.Show();
			}
			else
			{
				frmMessage.Close();
				string str = WorkingContext.LangManager.GetString("frmLunch_SetLunch_Title");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_SetLunch_ThongBao1");
				//MessageBox.Show("Thiết lập ăn trưa thành công!", "Thiết lập ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
			this.Text = WorkingContext.LangManager.GetString("frmLunch_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmLunch_groupbox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmLunch_groupbox2");
			this.groupBox3.Text = WorkingContext.LangManager.GetString("frmLunch_groupbox3");
			this.groupBox4.Text = WorkingContext.LangManager.GetString("frmLunch_groupbox4");
			this.chSTT.Text = WorkingContext.LangManager.GetString("frmLunch_lvwLunchSTT");
			this.chDepartmentName.Text = WorkingContext.LangManager.GetString("frmLunch_lvwLunchBoPhan");
			this.chCardID.Text = WorkingContext.LangManager.GetString("frmLunch_lvwLunchMaThe");
			this.chEmployeeName.Text = WorkingContext.LangManager.GetString("frmLunch_lvwLunchTenNV");
			this.chLunchMoney.Text = WorkingContext.LangManager.GetString("frmLunch_lvwLunchMAT");
			this.btnClearAll.Text = WorkingContext.LangManager.GetString("frmLunch_btnClearAll");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmLunch_btnClose");
			this.btnSearch.Text = WorkingContext.LangManager.GetString("frmLunch_btnSearch");
			this.btnSet.Text = WorkingContext.LangManager.GetString("frmLunch_btnSet");
			this.btnSlectAll.Text = WorkingContext.LangManager.GetString("frmLunch_btnSelectAll");
			this.btn_LoadPrevious.Text = WorkingContext.LangManager.GetString("frmLunch_btnSaoChep");
			this.txtSearch.Text = WorkingContext.LangManager.GetString("frmLunch_txtSearch");
			this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmLunch_lblTotalEm1");
			this.lblHaveLunch.Text = WorkingContext.LangManager.GetString("frmLunch_lblTotalLunch1");
			this.lblLunchMoney.Text = WorkingContext.LangManager.GetString("frmLunch_lblTotalLunchMoney");
			this.lvwLunch.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
		}

		#endregion

		#region Các hàm xử lý sự kiện
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmLunch_Load(object sender, EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			employeeDO = new EmployeeDO();
			lunchDO = new LunchDO();
			cboLunchMoney.Text = "16000";
				
			departmentTreeView.DepartmentDataSet = departmentDO.GetAllDepartments();
			departmentTreeView.BuildTree();
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;
		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);
			dataFilter = "";
			PopulateLunchList();
		}

		private void btnSetLunch_Click(object sender, EventArgs e)
		{
			//nếu số tiền được chọn không phải là "chưa thiết lập"
			if(cboLunchMoney.SelectedIndex != 0)
			{
				string errStr = CheckInputData();
				if(errStr != "")
				{
					string str = WorkingContext.LangManager.GetString("frmLunch_Messa5");
					//string str1 = WorkingContext.LangManager.GetString("");
					MessageBox.Show(errStr,str,MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					if(dsLunch.Tables[0].Rows.Count > 0)
					{
						UpdateLunch();
					}
					else
					{
						AddLunch();
					}
					PopulateLunchList();
				}
			}
			else //chọn "Chưa thiết lập"
			{
				if(lvwLunch.SelectedIndicies.Length > 0)
				{
					if(dsLunch.Tables[0].Rows.Count > 0)
					{
						UpdateLunch();
					}
					else
					{
						AddLunch();
					}
					PopulateLunchList();
				}
				else
				{
					string str = WorkingContext.LangManager.GetString("frmLunch_Messa1");
					string str1 = WorkingContext.LangManager.GetString("frmLunch_Messa5");
					//MessageBox.Show("Không có nhân viên nào được chọn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			
			// sau khi thiết lập thì clear tất cả các đối tượng được chọn
			tableModel1.Selections.Clear();
		}

		private void btnSelectAll_Click(object sender, EventArgs e)
		{
			tableModel1.Selections.SelectCells(0, 0, lvwLunch.RowCount - 1,0);
		}

		private void btnClearAll_Click(object sender, EventArgs e)
		{
			tableModel1.Selections.Clear();
		}

		private void dtpWorkingDay_ValueChanged(object sender, EventArgs e)
		{
			PopulateLunchList();
		}

		private void CopyFromPreviousLunch_Click(object sender, EventArgs e)
		{
			frmCopyLunch frm = new frmCopyLunch(this);
			frm.CurrentDay = dtpWorkingDay.Value;
			frm.ShowDialog(this);
			DataSet dsCurrentLunch = lunchDO.GetLunch(1,dtpWorkingDay.Value.Date);
			if(CopyFromPreviousLunchStatus > 0)//nếu đồng ý copy dữ liệu
			{
				string errStr = CheckCopyLunch();
				if(errStr != "")
				{
					string str = WorkingContext.LangManager.GetString("frmLunch_Messa5");
					//string str1 = WorkingContext.LangManager.GetString("");
					MessageBox.Show(errStr, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if(dsCurrentLunch.Tables[0].Rows.Count <= 0)//nếu dữ liệu đăng ký ăn trưa của ngày cần thiết lập chưa có thì dùng chế độ thêm mới
					{
						CopyFromPreviousLunch();
					}
					else
					{
						UpdateFromPreviousLunch();// chế độ cập nhật
					}
					PopulateLunchList();
				}
				
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmLunch_Messa8");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_Messa5");
				//MessageBox.Show("Sao chép dữ liệu đăng ký ăn trưa bị hủy bỏ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
			dataSort = "DepartmentName, CardID ASC";
			PopulateLunchList();
		}

		private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
				dataSort = "DepartmentName, CardID ASC";
				PopulateLunchList();
			}
		}

		private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtSearch.SelectAll();
		}

		private void btImportEmployeeToLunch_Click(object sender, System.EventArgs e)
		{
			DateTime workingDay=dtpWorkingDay.Value.Date;
			int ret = 0;
			try
			{
				ret = lunchDO.ImportEmployeeToLunch(workingDay);
			}
			catch
			{
				
			}
			if (ret != -1)
			{
				PopulateLunchList();
//				MessageBox .Show("Import thành công: "+ret+" bản ghi !");
				MessageBox .Show("Import lại danh sách nhân viên thành công !");

			}
//			else
//			{
//				dsLunch.RejectChanges();
//				string str = WorkingContext.LangManager.GetString("frmLunch_AddLunch_ThongBao");
//				string str1 = WorkingContext.LangManager.GetString("frmLunch_AddLunch_Title");
//				//MessageBox.Show("Không thể thêm đăng ký ăn trưa", "Đăng ký ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Error);
//				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}

		}

        private void button1_Click(object sender, EventArgs e)
        {
            WaitingForm.PleaseWait.ShowProcess();
            //WaitingForm.PleaseWait.ProcessStart();

            tableModel1.Selections.SelectCells(0, 0, lvwLunch.RowCount - 1, 0);
            DateTime TimeNow = Convert.ToDateTime(dtpWorkingDay.Value);
            int MaxDay = System.DateTime.DaysInMonth(TimeNow.Year,TimeNow.Month);
            DateTime BegDay = System.DateTime.Parse(TimeNow.Month.ToString() + "/" + "01" + "/" + TimeNow.Year.ToString());
            try
            {
                for (int i = 0; i < MaxDay; i++)
                {
                    UpdateLunchByDay(BegDay.Date);
                    BegDay.AddDays(1);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật cơ sở dữ liệu..", "Thông báo");
            }
            WaitingForm.PleaseWait.CloseProcess();
            tableModel1.Selections.Clear();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (lvwLunch.SelectedIndicies.Length <= 0)//Lỗi chưa có nhân viên nào được chọn để xóa
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmLunch_Error_Messa"),
                    WorkingContext.LangManager.GetString("frmLunch_Messa5"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show(this, WorkingContext.LangManager.GetString("frmLunch_Confirm_Delete"),
                    WorkingContext.LangManager.GetString("Confirm"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        int ret = 0;
                        dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
                        LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);
                        int count = lvwLunch.SelectedIndicies.Length;
                        for (int i = count - 1; i >= 0; i--)
                        {
                            // chỉ số hàng được chọn
                            int rowIndex = (int)lvwLunch.SelectedItems[i].Tag;
                            if (rowIndex >= 0)
                            {
                                dsLunch.Tables[0].Rows[rowIndex].Delete();
                                ret = lunchDO.DeleteLunch(dsLunch);
                                count--;
                            }
                        }
                        if (ret > 0)
                        {
                            MessageBox.Show(this, WorkingContext.LangManager.GetString("frmLunch_OK_Delete"),
                                WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title"),
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateLunchList();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }            
            }
        }
        #endregion
    }
}