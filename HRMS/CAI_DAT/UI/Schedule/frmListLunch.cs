using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Editors;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmListLunch.
	/// </summary>
	public class frmListLunch : Form
	{
		#region Các biến tự định nghĩa
	
		private DepartmentDO departmentDO = null;
		/// <summary>
		/// 
		/// </summary>
		private EmployeeDO employeeDO = null;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsLunchSheet = null;
		/// <summary>
		/// 
		/// </summary>
		private DataRow[] dataRows = null;
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
		private int DepartmentID;
		/// <summary>
		/// 
		/// </summary>
		private int CurrentMonth;
		/// <summary>
		/// 
		/// </summary>
		private int CurrentYear;
		private int selectedRowIndex = -1;

		private LunchDO lunchDO = null;
		private int t;

		#endregion
		#region Khai báo các control
		private Button btnExportExcel;
		private GroupBox grbDepartment;
		private MTGCComboBox cboDepartment;
		private GroupBox grbMonth;
		private Label label2;
		private Label label1;
		private LookupComboBox cboYear;
		private LookupComboBox cboMonth;
		private GroupBox groupBox1;
		private Button btnClose;
		private Table lvwLunchList;
		private TableModel tableModel1;
		private ColumnModel columnModel1;
		private TextColumn c3;
		private TextColumn c4;
		private TextColumn c5;
		private TextColumn c6;
		private TextColumn c7;
		private TextColumn cCardID;
		private TextColumn cEmployeeName;
		private TextColumn cDepartment;
		private TextColumn c1;
		private TextColumn c2;
		private TextColumn c8;
		private TextColumn c9;
		private TextColumn c10;
		private TextColumn c11;
		private TextColumn c12;
		private TextColumn c13;
		private TextColumn c14;
		private TextColumn c15;
		private TextColumn c16;
		private TextColumn c17;
		private TextColumn c18;
		private TextColumn c19;
		private TextColumn c20;
		private TextColumn c21;
		private TextColumn c22;
		private TextColumn c23;
		private TextColumn c24;
		private TextColumn c25;
		private TextColumn c26;
		private TextColumn c27;
		private TextColumn c28;
		private TextColumn c29;
		private TextColumn c30;
		private TextColumn c31;
		private Button btnSetLunch;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		private Button btnGenerateLunchList;
		private NumberColumn cSTT;
		private TextColumn cNVPT;
		private TextColumn cTCNT;
		private TextColumn cTCNN;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblTotalEmployee;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
		private TextColumn cTTC;
		#endregion
		#region Xử lý các sự kiện
		public frmListLunch()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLunch));
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnSetLunch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new MTGCComboBox();
            this.grbMonth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.LookupComboBox();
            this.cboMonth = new System.Windows.Forms.LookupComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.lvwLunchList = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cDepartment = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.c1 = new XPTable.Models.TextColumn();
            this.c2 = new XPTable.Models.TextColumn();
            this.c3 = new XPTable.Models.TextColumn();
            this.c4 = new XPTable.Models.TextColumn();
            this.c5 = new XPTable.Models.TextColumn();
            this.c6 = new XPTable.Models.TextColumn();
            this.c7 = new XPTable.Models.TextColumn();
            this.c8 = new XPTable.Models.TextColumn();
            this.c9 = new XPTable.Models.TextColumn();
            this.c10 = new XPTable.Models.TextColumn();
            this.c11 = new XPTable.Models.TextColumn();
            this.c12 = new XPTable.Models.TextColumn();
            this.c13 = new XPTable.Models.TextColumn();
            this.c14 = new XPTable.Models.TextColumn();
            this.c15 = new XPTable.Models.TextColumn();
            this.c16 = new XPTable.Models.TextColumn();
            this.c17 = new XPTable.Models.TextColumn();
            this.c18 = new XPTable.Models.TextColumn();
            this.c19 = new XPTable.Models.TextColumn();
            this.c20 = new XPTable.Models.TextColumn();
            this.c21 = new XPTable.Models.TextColumn();
            this.c22 = new XPTable.Models.TextColumn();
            this.c23 = new XPTable.Models.TextColumn();
            this.c24 = new XPTable.Models.TextColumn();
            this.c25 = new XPTable.Models.TextColumn();
            this.c26 = new XPTable.Models.TextColumn();
            this.c27 = new XPTable.Models.TextColumn();
            this.c28 = new XPTable.Models.TextColumn();
            this.c29 = new XPTable.Models.TextColumn();
            this.c30 = new XPTable.Models.TextColumn();
            this.c31 = new XPTable.Models.TextColumn();
            this.cNVPT = new XPTable.Models.TextColumn();
            this.cTCNT = new XPTable.Models.TextColumn();
            this.cTCNN = new XPTable.Models.TextColumn();
            this.cTTC = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGenerateLunchList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbDepartment.SuspendLayout();
            this.grbMonth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwLunchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportExcel.Location = new System.Drawing.Point(536, 548);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(104, 23);
            this.btnExportExcel.TabIndex = 39;
            this.btnExportExcel.Text = "&Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnSetLunch
            // 
            this.btnSetLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetLunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetLunch.Location = new System.Drawing.Point(272, 548);
            this.btnSetLunch.Name = "btnSetLunch";
            this.btnSetLunch.Size = new System.Drawing.Size(96, 23);
            this.btnSetLunch.TabIndex = 38;
            this.btnSetLunch.Text = "Thiết lập ăn trưa";
            this.btnSetLunch.Click += new System.EventHandler(this.btnSetLunch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Location = new System.Drawing.Point(644, 548);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "&Nạp lại";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grbDepartment
            // 
            this.grbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDepartment.Controls.Add(this.cboDepartment);
            this.grbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDepartment.Location = new System.Drawing.Point(532, 0);
            this.grbDepartment.Name = "grbDepartment";
            this.grbDepartment.Size = new System.Drawing.Size(264, 48);
            this.grbDepartment.TabIndex = 36;
            this.grbDepartment.TabStop = false;
            this.grbDepartment.Text = "Bộ phận";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboDepartment.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboDepartment.ColumnNum = 2;
            this.cboDepartment.ColumnWidth = "50;200";
            this.cboDepartment.DisplayMember = "Text";
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDepartment.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboDepartment.DropDownForeColor = System.Drawing.Color.Black;
            this.cboDepartment.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboDepartment.DropDownWidth = 270;
            this.cboDepartment.GridLineColor = System.Drawing.Color.LightGray;
            this.cboDepartment.GridLineHorizontal = true;
            this.cboDepartment.GridLineVertical = true;
            this.cboDepartment.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboDepartment.Location = new System.Drawing.Point(8, 16);
            this.cboDepartment.ManagingFastMouseMoving = true;
            this.cboDepartment.ManagingFastMouseMovingInterval = 30;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(248, 21);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // grbMonth
            // 
            this.grbMonth.Controls.Add(this.label2);
            this.grbMonth.Controls.Add(this.label1);
            this.grbMonth.Controls.Add(this.cboYear);
            this.grbMonth.Controls.Add(this.cboMonth);
            this.grbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbMonth.Location = new System.Drawing.Point(8, 0);
            this.grbMonth.Name = "grbMonth";
            this.grbMonth.Size = new System.Drawing.Size(200, 48);
            this.grbMonth.TabIndex = 35;
            this.grbMonth.TabStop = false;
            this.grbMonth.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(104, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboYear
            // 
            this.cboYear.AllowTypeAllSymbols = false;
            this.cboYear.Items.AddRange(new object[] {
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
            this.cboYear.Location = new System.Drawing.Point(136, 16);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(56, 21);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.AllowTypeAllSymbols = false;
            this.cboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(48, 16);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(48, 21);
            this.cboMonth.TabIndex = 0;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.Controls.Add(this.lvwLunchList);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 492);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ăn trưa tháng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(208, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "TổngAT: Tổng ăn trưa - Trợ cấpAT: Trợ cấp ăn trưa  - Trợ cấpLT: Trợ cấp làm thêm " +
                "- TổngTC:  Tổng trợ cấp  ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(136, 456);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(8, 456);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployee.Location = new System.Drawing.Point(636, 456);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(144, 23);
            this.lblTotalEmployee.TabIndex = 15;
            this.lblTotalEmployee.Text = "Tổng số nhân viên: 999";
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwLunchList
            // 
            this.lvwLunchList.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwLunchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLunchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwLunchList.ColumnModel = this.columnModel1;
            this.lvwLunchList.EditStartAction = XPTable.Editors.EditStartAction.SingleClick;
            this.lvwLunchList.EnableToolTips = true;
            this.lvwLunchList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwLunchList.FullRowSelect = true;
            this.lvwLunchList.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwLunchList.GridLines = XPTable.Models.GridLines.Both;
            this.lvwLunchList.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwLunchList.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvwLunchList.Location = new System.Drawing.Point(8, 16);
            this.lvwLunchList.Name = "lvwLunchList";
            this.lvwLunchList.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwLunchList.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwLunchList.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwLunchList.Size = new System.Drawing.Size(772, 432);
            this.lvwLunchList.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwLunchList.TabIndex = 11;
            this.lvwLunchList.TableModel = this.tableModel1;
            this.lvwLunchList.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwLunchList.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwLunchList.EditingStopped += new XPTable.Events.CellEditEventHandler(this.lvwLunchList_EditingStopped);
            this.lvwLunchList.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwLunchList_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartment,
            this.cCardID,
            this.cEmployeeName,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9,
            this.c10,
            this.c11,
            this.c12,
            this.c13,
            this.c14,
            this.c15,
            this.c16,
            this.c17,
            this.c18,
            this.c19,
            this.c20,
            this.c21,
            this.c22,
            this.c23,
            this.c24,
            this.c25,
            this.c26,
            this.c27,
            this.c28,
            this.c29,
            this.c30,
            this.c31,
            this.cNVPT,
            this.cTCNT,
            this.cTCNN,
            this.cTTC});
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cSTT.Text = "STT";
            this.cSTT.Width = 40;
            // 
            // cDepartment
            // 
            this.cDepartment.Editable = false;
            this.cDepartment.Text = "Phòng";
            this.cDepartment.Width = 100;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 55;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Editable = false;
            this.cEmployeeName.Text = "Tên nhân viên";
            this.cEmployeeName.Width = 120;
            // 
            // c1
            // 
            this.c1.Text = "1";
            this.c1.Width = 24;
            // 
            // c2
            // 
            this.c2.Text = "2";
            this.c2.Width = 24;
            // 
            // c3
            // 
            this.c3.Text = "3";
            this.c3.Width = 24;
            // 
            // c4
            // 
            this.c4.Text = "4";
            this.c4.Width = 24;
            // 
            // c5
            // 
            this.c5.Text = "5";
            this.c5.Width = 24;
            // 
            // c6
            // 
            this.c6.Text = "6";
            this.c6.Width = 24;
            // 
            // c7
            // 
            this.c7.Text = "7";
            this.c7.Width = 24;
            // 
            // c8
            // 
            this.c8.Text = "8";
            this.c8.Width = 24;
            // 
            // c9
            // 
            this.c9.Text = "9";
            this.c9.Width = 24;
            // 
            // c10
            // 
            this.c10.Text = "10";
            this.c10.Width = 24;
            // 
            // c11
            // 
            this.c11.Text = "11";
            this.c11.Width = 24;
            // 
            // c12
            // 
            this.c12.Text = "12";
            this.c12.Width = 24;
            // 
            // c13
            // 
            this.c13.Text = "13";
            this.c13.Width = 24;
            // 
            // c14
            // 
            this.c14.Text = "14";
            this.c14.Width = 24;
            // 
            // c15
            // 
            this.c15.Text = "15";
            this.c15.Width = 24;
            // 
            // c16
            // 
            this.c16.Text = "16";
            this.c16.Width = 24;
            // 
            // c17
            // 
            this.c17.Text = "17";
            this.c17.Width = 24;
            // 
            // c18
            // 
            this.c18.Text = "18";
            this.c18.Width = 24;
            // 
            // c19
            // 
            this.c19.Text = "19";
            this.c19.Width = 24;
            // 
            // c20
            // 
            this.c20.Text = "20";
            this.c20.Width = 24;
            // 
            // c21
            // 
            this.c21.Text = "21";
            this.c21.Width = 24;
            // 
            // c22
            // 
            this.c22.Text = "22";
            this.c22.Width = 24;
            // 
            // c23
            // 
            this.c23.Text = "23";
            this.c23.Width = 24;
            // 
            // c24
            // 
            this.c24.Text = "24";
            this.c24.Width = 24;
            // 
            // c25
            // 
            this.c25.Text = "25";
            this.c25.Width = 24;
            // 
            // c26
            // 
            this.c26.Text = "26";
            this.c26.Width = 24;
            // 
            // c27
            // 
            this.c27.Text = "27";
            this.c27.Width = 24;
            // 
            // c28
            // 
            this.c28.Text = "28";
            this.c28.Width = 24;
            // 
            // c29
            // 
            this.c29.Text = "29";
            this.c29.Width = 24;
            // 
            // c30
            // 
            this.c30.Text = "30";
            this.c30.Width = 24;
            // 
            // c31
            // 
            this.c31.Text = "31";
            this.c31.Width = 24;
            // 
            // cNVPT
            // 
            this.cNVPT.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cNVPT.Editable = false;
            this.cNVPT.Text = "TổngAT";
            this.cNVPT.Width = 70;
            // 
            // cTCNT
            // 
            this.cTCNT.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cTCNT.Editable = false;
            this.cTCNT.Text = "Trợ cấpAT";
            this.cTCNT.Width = 70;
            // 
            // cTCNN
            // 
            this.cTCNN.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cTCNN.Editable = false;
            this.cTCNN.Text = "Trợ cấpLT";
            this.cTCNN.Width = 70;
            // 
            // cTTC
            // 
            this.cTTC.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cTTC.Editable = false;
            this.cTTC.Text = "TổngTC";
            this.cTTC.Width = 70;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(724, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerateLunchList
            // 
            this.btnGenerateLunchList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateLunchList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateLunchList.Location = new System.Drawing.Point(8, 548);
            this.btnGenerateLunchList.Name = "btnGenerateLunchList";
            this.btnGenerateLunchList.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateLunchList.TabIndex = 34;
            this.btnGenerateLunchList.Text = "&Sinh bảng ăn trưa";
            this.btnGenerateLunchList.Click += new System.EventHandler(this.btnGenerateLunchList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(376, 548);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(456, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmListLunch
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(804, 574);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnSetLunch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.grbMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateLunchList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListLunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng kết ăn trưa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListLunch_Load);
            this.grbDepartment.ResumeLayout(false);
            this.grbMonth.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwLunchList)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnSetLunch_Click(object sender, EventArgs e)
		{
			frmLunch frm = new frmLunch();
			frm.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmListLunch_Load(object sender, EventArgs e)
		{
			Refresh();
			lunchDO = new LunchDO();
			CurrentMonth = DateTime.Now.Month;
			CurrentYear = DateTime.Now.Year;
			cboMonth.SelectedText = CurrentMonth.ToString();
			cboYear.SelectedText = CurrentYear.ToString();
			PopulateDepartmentCombo();
			this.label3.Visible = false;
			//this.label3.Text = "";
			if (this.Text == "Tổng kết ăn trưa")
			{
				//this.label1.Visible = false;
				//this.label2.Visible = false;
				this.label3.Visible = true;
			}
		}
		private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			DepartmentID = int.Parse(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1);
			dataFilter = "";
			PopulateLunchSheetData();
		}

		private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentMonth = int.Parse(cboMonth.Text);
			dataFilter = "";
			PopulateLunchSheetData();
		}

		private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentYear = int.Parse(cboYear.Text);
			dataFilter = "";
			PopulateLunchSheetData();
		}
		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmListLunch_Messa1");
			//message.Show("Đang xuất dữ liệu bảng ăn trưa ra file Excel...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			if (!Utils.ExportExcel(lvwLunchList,this.Text.ToUpper()))
			{
				string str1 = WorkingContext.LangManager.GetString("frmListLunch_Messa2");
				string str2 = WorkingContext.LangManager.GetString("frmListLunch_Messa3");
				//MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			message.Close();
			this.Cursor = Cursors.Default;
		}

		private void btnGenerateLunchList_Click(object sender, EventArgs e)
		{
			string str = WorkingContext.LangManager.GetString("frmListLunch_Messa4");
			string str1 = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Title");
			//DialogResult dr=MessageBox.Show("Quá trình sinh bảng ăn trưa sẽ mất một khoảng thời gian. Bạn có thực sự muốn thực hiện ? ", "Chú ý !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			DialogResult dr=MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{	
				GenerateLunchSheet();
				PopulateLunchSheetData();
			}
		}
		#endregion
		#region các hàm xử lý chính
		/// <summary>
		/// 
		/// </summary>
		private void PopulateDepartmentCombo()
		{
			departmentDO = new DepartmentDO();

			DataSet dsDepartment = new DataSet();
			dsDepartment = departmentDO.GetAllDepartments();

			cboDepartment.SourceDataString = new string[] {"DepartmentID", "DepartmentName"};
			cboDepartment.SourceDataTable = dsDepartment.Tables[0];
			if (dsDepartment.Tables[0].Rows.Count > 0)
			{
				cboDepartment.SelectedIndex = 0;
			}
		}
	
		/// <summary>
		/// Hiển thị dữ liệu ăn trưa lên form
		/// </summary>
		private void PopulateLunchSheetData()
		{
			// Get DataSet
			dsLunchSheet = lunchDO.GetDepartmentLunchSheet(CurrentMonth, CurrentYear,DepartmentID);
			dataRows = dsLunchSheet.Tables[0].Select(dataFilter, dataSort);
			// Load TimeSheet data to table
			lvwLunchList.BeginUpdate();
			lvwLunchList.TableModel.Rows.Clear();

			int STT = 0;
			foreach (DataRow dr in dataRows)
			{
				string CardID = dr["CardID"].ToString();
				string EmployeeName = dr["EmployeeName"].ToString();
				string DepartmentName = dr["DepartmentName"].ToString();
				string TotalPaidLunch = dr["TotalPaidLunch"].ToString();
				string TotalNormalLunch = dr["TotalNormalLunch"].ToString();
				string TotalOverTimeLunch = dr["TotalOverTimeLunch"].ToString();
				string TotalAllowance = dr["TotalAllowance"].ToString();
				
				Cell[] LunchSheet = new Cell[39];
				LunchSheet[0] = new Cell(STT+1);
				LunchSheet[1] = new Cell(DepartmentName);
				LunchSheet[2] = new Cell(CardID);
				LunchSheet[3] = new Cell(EmployeeName);
				for (int i=1;i<=31;i++)
				{
					string dayname = "Day" + i;
					LunchSheet[i + 3] = new Cell(dr[dayname].ToString());
				}
				LunchSheet[35] = new Cell(TotalPaidLunch);
				LunchSheet[36] = new Cell(TotalNormalLunch);
				LunchSheet[37] = new Cell(TotalOverTimeLunch);
				LunchSheet[38] = new Cell(TotalAllowance);
				Row row = new Row(LunchSheet);
				row.Tag = STT;
				lvwLunchList.TableModel.Rows.Add(row);
				STT++;
			}
			lvwLunchList.EndUpdate();
			string str = WorkingContext.LangManager.GetString("frmListLunch_TextTitle");
			//lblTotalEmployee.Text = "Tổng số nhân viên: " + dataRows.Length;
			lblTotalEmployee.Text = str + dataRows.Length;
			t = dataRows.Length;
		}
		/// <summary>
		/// Tự động sinh bảng ăn trưa dựa trên dữ liệu sẵn có
		/// </summary>
		private void GenerateLunchSheet()
		{
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Messa1");
			//message.Show("Đang sinh dữ liệu ăn trưa...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			employeeDO = new EmployeeDO();
			DataSet dsEmployee = employeeDO.GetEmployeeByDepartment(DepartmentID);
			int totalEmployees = dsEmployee.Tables[0].Rows.Count;
			float percentToComplete = 0;
			int percentProcessing = 0;

			if (dsEmployee.Tables[0].Rows.Count > 0)
			{
				int ret = 0;
				foreach (DataRow dr in dsEmployee.Tables[0].Rows)
				{
					int EmployeeID = int.Parse(dr["EmployeeID"].ToString());
					percentProcessing= ++percentProcessing;
					try 
					{
						ret = lunchDO.GenerateLunchSheet(CurrentMonth, CurrentYear,EmployeeID);
						percentToComplete = (percentProcessing*100) / totalEmployees;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
					message.ProgressBar.Value = (int)percentToComplete;
				}
				message.Close();
				this.Cursor = Cursors.Default;
				if (ret > 0)
				{
					string str2 = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Messa2");
					string str3 = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Title");
					//MessageBox.Show("Sinh bảng ăn trưa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					string str2 = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Messa3");
					string str3 = WorkingContext.LangManager.GetString("frmListLunch_Sinh_Title");
					//MessageBox.Show("Sinh bảng ăn trưa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				message.Close();
				this.Cursor = Cursors.Default;
			}
		}
		#endregion

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
			dataSort = "DepartmentName, CardID ASC";
			PopulateLunchSheetData();
		}

		private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
				dataSort = "DepartmentName, CardID ASC";
				PopulateLunchSheetData();
			}
		}

		private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtSearch.SelectAll();
		}

		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			PopulateLunchSheetData();
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			if (dsLunchSheet.Tables[0].Rows.Count > 0)
			{
				UpdateLunchSheet();
				// Get DataSet
				PopulateLunchSheetData();
			}
		}

		/// <summary>
		/// Cập nhật bảng chấm công
		/// </summary>
		private void UpdateLunchSheet()
		{
			int ret = 0;
			try
			{
				// Điền dữ liệu từ listview vào DataSet
				for (int rowIndex = 0; rowIndex < lvwLunchList.RowCount; rowIndex ++)
				{
					int STT = (int) lvwLunchList.TableModel.Rows[rowIndex].Tag;
					DataRow dr = dataRows[STT];

					for (int colIndex = 1; colIndex <= 31; colIndex++)
					{
						string dayname = "Day" + colIndex;
						if (lvwLunchList.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text=="")
						{
							dr[dayname] ="0";
						}
						else if (!IsNumeric(lvwLunchList.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text))
						{
							dr[dayname] ="5";
						}
						else
						{
							dr[dayname] = lvwLunchList.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text;
						}
					}
					dr["TotalPaidLunch"] = lvwLunchList.TableModel.Rows[rowIndex].Cells[35].Text;
				}
				// Cập nhật
				ret = lunchDO.UpdateLunchSheet(dsLunchSheet);
			}
			catch
			{
			}
			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListLunch_Update_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListLunch_Update_Title");
				//MessageBox.Show("Cập nhật bảng ăn trưa thành công!", "Cập nhật bảng ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListLunch_Update_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListLunch_Update_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lvwLunchList_EditingStopped(object sender, XPTable.Events.CellEditEventArgs e)
		{
			int row = e.Row;
			double oldValue = GetCellValue(e.Cell.Text);
			double newValue = GetCellValue(((TextCellEditor) e.Editor).TextBox.Text);
			double total = GetCellValue(lvwLunchList.TableModel.Rows[row].Cells[35].Text);
			total = total + 1000 *(newValue - oldValue);
			lvwLunchList.TableModel.Rows[row].Cells[35].Text = total.ToString();
		}
		/// <summary>
		/// Trả về giá trị số công của một ngày
		/// </summary>
		/// <param name="CellText"></param>
		/// <returns></returns>
		private double GetCellValue(string CellText)
		{
			if (IsNumeric(CellText))
			{
				return Double.Parse(CellText);
			}
			else if (CellText == "")
			{
				return 0.0f;
			}
			else
			{
				return 5.0f;
			}
		}
		/// <summary>
		/// Kiểm tra dữ liệu có phải dạng số hay ko
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		private bool IsNumeric(string val)
		{
			try
			{
				double result = 0;
				return Double.TryParse(val, NumberStyles.Any, NumberFormatInfo.CurrentInfo, out result);
			}
			catch
			{
				return false;
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListLunch_Delete_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListLunch_Delete_Title");
				//MessageBox.Show("Bạn chưa chọn nhân viên nào trong danh sách?", "Xóa nhân viên khỏi bảng đăng ký ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string str2 = WorkingContext.LangManager.GetString("frmListLunch_Delete_Messa2");
			string str3 = WorkingContext.LangManager.GetString("frmListLunch_Delete_Title");
			// confirm lại xem có chắc chắn muốn xóa nhân viên khỏi bảng đăng ký ăn trưa
			if (MessageBox.Show(str2, str3, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
//				dsLunchSheet.Tables[0].Rows[selectedRowIndex].Delete();
				dsLunchSheet.Tables[0].Select(dataFilter, dataSort)[selectedRowIndex].Delete();
				lunchDO.DeleteEmployeeLunch(dsLunchSheet);
				dsLunchSheet.AcceptChanges();
				//LoadSalaryData();
				PopulateLunchSheetData();
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void lvwLunchList_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwLunchList.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
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
			
			this.Text = WorkingContext.LangManager.GetString("frmListLunch_Text");
			this.grbMonth.Text = WorkingContext.LangManager.GetString("frmListLunch_grpMonth");
			this.label1.Text = WorkingContext.LangManager.GetString("frmListLunch_label1");
			this.label2.Text = WorkingContext.LangManager.GetString("frmListLunch_label2");
			this.grbDepartment.Text = WorkingContext.LangManager.GetString("frmListLunch_grpDepartment");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListLunch_groupbox1");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_STT");
			this.cDepartment.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_Phong");
			this.cCardID.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_MaThe");
			this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_TenNV");
			this.cTCNN.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_PCLT");
			this.cTCNT.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_PCAT");
			this.cTTC.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_TongTC");
			this.cNVPT.Text = WorkingContext.LangManager.GetString("frmListLunch_lvwListLunch_TongAT");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListLunch_btnClose");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListLunch_btnDelete");
			this.btnExportExcel.Text = WorkingContext.LangManager.GetString("frmListLunch_btnExportExcel");
			this.btnGenerateLunchList.Text = WorkingContext.LangManager.GetString("frmListLunch_btnGenarate");
			this.btnRefresh.Text = WorkingContext.LangManager.GetString("frmListLunch_btnRefesh");
			this.btnSearch.Text = WorkingContext.LangManager.GetString("frmListLunch_btnSearch");
			this.btnSetLunch.Text = WorkingContext.LangManager.GetString("frmListLunch_btnSetLunch");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmListLunch_btnUpdate");
			this.txtSearch.Text = WorkingContext.LangManager.GetString("frmListLunch_txtSearch");
			this.lvwLunchList.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			if (this.Text == "Tổng kết ăn trưa")
			{
				//this.label1.Visible = false;
				//this.label2.Visible = false;
				this.label3.Visible = true;
			}
			else
			{
				this.label3.Visible = false;
			}
			this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmListLunch_TextTitle") +" : " + t;
			
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }
	}
}
