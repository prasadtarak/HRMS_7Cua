//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: quandh 25/11/2006
//Note		: Thêm cột phụ cấp ăn trưa, PC trách nhiệm,PC độc hại
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
//using GlacialComponents.Controls;
using EVSoft.HRMS.UI.Employee;
using XPTable.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace EVSoft.HRMS.UI.Employee
{
    public class frmListEmployees : System.Windows.Forms.Form
    {
        private Label lblDepartment;
        private Panel pnDepartment;
        private Panel pnEmployee;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClose;
        private Panel pnButtons;
        private Splitter splitter1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblEmployee;
        private XPTable.Models.Table lvwEmployee;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn cCardID;
        private XPTable.Models.TextColumn cEmployeeName;
        private XPTable.Models.TextColumn cDepartmentName;
        private XPTable.Models.TextColumn cGender;
        private XPTable.Models.TextColumn cDateOfBirth;
        private XPTable.Models.TextColumn cIdentityCard;
        private XPTable.Models.TextColumn cPhone;
        private XPTable.Models.TextColumn cAddress;
        private System.Windows.Forms.Button btnExcel;
        private XPTable.Models.TextColumn cInsurance;
        private XPTable.Models.NumberColumn cSTT;
        private XPTable.Models.TextColumn cCommune;
        private XPTable.Models.TextColumn cDistrict;
        private XPTable.Models.TextColumn cProvince;
        private System.Windows.Forms.Button btnDeletedEmployee;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnPermanentDelete;
        private EVSoft.HRMS.Controls.DepartmentTreeView departmentTreeView;
        private XPTable.Models.TextColumn cStopDate;
        private XPTable.Models.TextColumn cPosition;
        private XPTable.Models.TextColumn cStartTrial;
        private XPTable.Models.TextColumn cStartDate;
        private XPTable.Models.TextColumn cTrinhdo;
        private XPTable.Models.NumberColumn cBasicSalary;
        //Thêm cột phụ cấp ăn trưa, PC trách nhiệm,PC độc hại
        private XPTable.Models.NumberColumn LunchAllowance;
        private XPTable.Models.NumberColumn ResponsibleAllowance;
        private XPTable.Models.NumberColumn HarmfulAllowance;
        private System.ComponentModel.IContainer components;
        //		private bool check = true;
        private int t;
        // bien nay dung de kiem tra xem dang tim kiem theo danh sach nhan vien nghi hay danh sach nhan vien van dang lam viec
        private int delete = 0;
        private XPTable.Models.TextColumn cTotalYear;
        private XPTable.Models.TextColumn cTotalMonth;
        private XPTable.Models.TextColumn txtKinhNghiem;
        private NumberColumn IntimateAllowance;
        private TextColumn cBarCode;
        private Button btnUpdateBarCode;
        private Button btnExcelBarCode;
        private TableModel tableModel2;
        private ColumnModel columnModel2;
        private TextColumn clBarcode;
        private TextColumn clEmployeeID;
        private TextColumn clEmployeeName;
        private TextColumn clDepartment;
        private TextColumn clStartDate;
        private TextColumn clImagePath;
        private Table lvwEmployeeBarcode;
        private NumberColumn clSTT;
        private CheckBoxColumn bIntimateAllowanceFixed;
        private NumberColumn DangerousAllowance;
        private TextColumn cTemporaryAddress;
        private TextColumn cIssue;
        private TextColumn cAllocationPlace;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListEmployees));
            this.pnDepartment = new System.Windows.Forms.Panel();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.btnDeletedEmployee = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.pnEmployee = new System.Windows.Forms.Panel();
            this.lvwEmployeeBarcode = new XPTable.Models.Table();
            this.columnModel2 = new XPTable.Models.ColumnModel();
            this.clSTT = new XPTable.Models.NumberColumn();
            this.clBarcode = new XPTable.Models.TextColumn();
            this.clEmployeeID = new XPTable.Models.TextColumn();
            this.clEmployeeName = new XPTable.Models.TextColumn();
            this.clDepartment = new XPTable.Models.TextColumn();
            this.clStartDate = new XPTable.Models.TextColumn();
            this.clImagePath = new XPTable.Models.TextColumn();
            this.tableModel2 = new XPTable.Models.TableModel();
            this.lvwEmployee = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cDepartmentName = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cBarCode = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.cGender = new XPTable.Models.TextColumn();
            this.cDateOfBirth = new XPTable.Models.TextColumn();
            this.cIdentityCard = new XPTable.Models.TextColumn();
            this.cIssue = new XPTable.Models.TextColumn();
            this.cAllocationPlace = new XPTable.Models.TextColumn();
            this.cInsurance = new XPTable.Models.TextColumn();
            this.cPhone = new XPTable.Models.TextColumn();
            this.cTrinhdo = new XPTable.Models.TextColumn();
            this.cAddress = new XPTable.Models.TextColumn();
            this.cTemporaryAddress = new XPTable.Models.TextColumn();
            this.cCommune = new XPTable.Models.TextColumn();
            this.cDistrict = new XPTable.Models.TextColumn();
            this.cProvince = new XPTable.Models.TextColumn();
            this.cPosition = new XPTable.Models.TextColumn();
            this.cStartTrial = new XPTable.Models.TextColumn();
            this.cStartDate = new XPTable.Models.TextColumn();
            this.cStopDate = new XPTable.Models.TextColumn();
            this.cBasicSalary = new XPTable.Models.NumberColumn();
            this.LunchAllowance = new XPTable.Models.NumberColumn();
            this.DangerousAllowance = new XPTable.Models.NumberColumn();
            this.ResponsibleAllowance = new XPTable.Models.NumberColumn();
            this.HarmfulAllowance = new XPTable.Models.NumberColumn();
            this.IntimateAllowance = new XPTable.Models.NumberColumn();
            this.bIntimateAllowanceFixed = new XPTable.Models.CheckBoxColumn();
            this.cTotalYear = new XPTable.Models.TextColumn();
            this.cTotalMonth = new XPTable.Models.TextColumn();
            this.txtKinhNghiem = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdateBarCode = new System.Windows.Forms.Button();
            this.btnExcelBarCode = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPermanentDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnDepartment.SuspendLayout();
            this.pnEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployeeBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).BeginInit();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDepartment
            // 
            this.pnDepartment.Controls.Add(this.departmentTreeView);
            this.pnDepartment.Controls.Add(this.btnDeletedEmployee);
            this.pnDepartment.Controls.Add(this.lblDepartment);
            this.pnDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDepartment.Location = new System.Drawing.Point(0, 0);
            this.pnDepartment.Name = "pnDepartment";
            this.pnDepartment.Size = new System.Drawing.Size(200, 550);
            this.pnDepartment.TabIndex = 0;
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeView.BackColor = System.Drawing.Color.GhostWhite;
            this.departmentTreeView.DepartmentDataSet = null;
            this.departmentTreeView.ImageIndex = 0;
            this.departmentTreeView.Location = new System.Drawing.Point(0, 24);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.SelectedImageIndex = 0;
            this.departmentTreeView.Size = new System.Drawing.Size(200, 504);
            this.departmentTreeView.TabIndex = 5;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // btnDeletedEmployee
            // 
            this.btnDeletedEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeletedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletedEmployee.Location = new System.Drawing.Point(0, 527);
            this.btnDeletedEmployee.Name = "btnDeletedEmployee";
            this.btnDeletedEmployee.Size = new System.Drawing.Size(200, 23);
            this.btnDeletedEmployee.TabIndex = 7;
            this.btnDeletedEmployee.Text = "Danh sách nhân viên đã nghỉ việc";
            this.btnDeletedEmployee.Click += new System.EventHandler(this.btnDeletedEmployee_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartment.Location = new System.Drawing.Point(0, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(200, 24);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Danh sách các đơn vị";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnEmployee
            // 
            this.pnEmployee.Controls.Add(this.lvwEmployeeBarcode);
            this.pnEmployee.Controls.Add(this.lvwEmployee);
            this.pnEmployee.Controls.Add(this.lblEmployee);
            this.pnEmployee.Controls.Add(this.pnButtons);
            this.pnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmployee.Location = new System.Drawing.Point(200, 0);
            this.pnEmployee.Name = "pnEmployee";
            this.pnEmployee.Size = new System.Drawing.Size(820, 550);
            this.pnEmployee.TabIndex = 4;
            // 
            // lvwEmployeeBarcode
            // 
            this.lvwEmployeeBarcode.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwEmployeeBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwEmployeeBarcode.ColumnModel = this.columnModel2;
            this.lvwEmployeeBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployeeBarcode.Location = new System.Drawing.Point(990, 261);
            this.lvwEmployeeBarcode.Name = "lvwEmployeeBarcode";
            this.lvwEmployeeBarcode.Size = new System.Drawing.Size(150, 150);
            this.lvwEmployeeBarcode.TabIndex = 0;
            this.lvwEmployeeBarcode.TableModel = this.tableModel2;
            this.lvwEmployeeBarcode.Text = "table1";
            this.lvwEmployeeBarcode.Visible = false;
            // 
            // columnModel2
            // 
            this.columnModel2.Columns.AddRange(new XPTable.Models.Column[] {
            this.clSTT,
            this.clBarcode,
            this.clEmployeeID,
            this.clEmployeeName,
            this.clDepartment,
            this.clStartDate,
            this.clImagePath});
            // 
            // clSTT
            // 
            this.clSTT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clSTT.Text = "STT";
            this.clSTT.Width = 40;
            // 
            // clBarcode
            // 
            this.clBarcode.Text = "Mã vạch";
            this.clBarcode.Width = 100;
            // 
            // clEmployeeID
            // 
            this.clEmployeeID.Text = "Mã nhân viên";
            // 
            // clEmployeeName
            // 
            this.clEmployeeName.Text = "Họ tên";
            this.clEmployeeName.Width = 150;
            // 
            // clDepartment
            // 
            this.clDepartment.Text = "Bộ phận";
            // 
            // clStartDate
            // 
            this.clStartDate.Text = "Ngày vào công ty";
            // 
            // clImagePath
            // 
            this.clImagePath.Text = "Hình ảnh";
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwEmployee.ColumnModel = this.columnModel1;
            this.lvwEmployee.EnableHeaderContextMenu = false;
            this.lvwEmployee.EnableToolTips = true;
            this.lvwEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.FullRowSelect = true;
            this.lvwEmployee.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.lvwEmployee.GridLines = XPTable.Models.GridLines.Both;
            this.lvwEmployee.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwEmployee.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwEmployee.Location = new System.Drawing.Point(3, 22);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwEmployee.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwEmployee.Size = new System.Drawing.Size(812, 488);
            this.lvwEmployee.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwEmployee.TabIndex = 10;
            this.lvwEmployee.TableModel = this.tableModel1;
            this.lvwEmployee.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwEmployee.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwEmployee_KeyPress);
            this.lvwEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwEmployee_MouseDown);
            this.lvwEmployee.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwEmployee_SelectionChanged);
            this.lvwEmployee.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartmentName,
            this.cCardID,
            this.cBarCode,
            this.cEmployeeName,
            this.cGender,
            this.cDateOfBirth,
            this.cIdentityCard,
            this.cIssue,
            this.cAllocationPlace,
            this.cInsurance,
            this.cPhone,
            this.cTrinhdo,
            this.cAddress,
            this.cTemporaryAddress,
            this.cCommune,
            this.cDistrict,
            this.cProvince,
            this.cPosition,
            this.cStartTrial,
            this.cStartDate,
            this.cStopDate,
            this.cBasicSalary,
            this.LunchAllowance,
            this.DangerousAllowance,
            this.ResponsibleAllowance,
            this.HarmfulAllowance,
            this.IntimateAllowance,
            this.bIntimateAllowanceFixed,
            this.cTotalYear,
            this.cTotalMonth,
            this.txtKinhNghiem});
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
            this.cSTT.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.cSTT.Width = 40;
            // 
            // cDepartmentName
            // 
            this.cDepartmentName.Editable = false;
            this.cDepartmentName.Text = "Bộ phận";
            this.cDepartmentName.Width = 90;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 50;
            // 
            // cBarCode
            // 
            this.cBarCode.Text = "Mã vạch";
            this.cBarCode.Width = 100;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Editable = false;
            this.cEmployeeName.Text = "Tên nhân viên";
            this.cEmployeeName.Width = 130;
            // 
            // cGender
            // 
            this.cGender.Editable = false;
            this.cGender.Text = "Giới tính";
            this.cGender.Width = 60;
            // 
            // cDateOfBirth
            // 
            this.cDateOfBirth.Editable = false;
            this.cDateOfBirth.Text = "Ngày sinh";
            // 
            // cIdentityCard
            // 
            this.cIdentityCard.Editable = false;
            this.cIdentityCard.Text = "Số CMND";
            // 
            // cIssue
            // 
            this.cIssue.Editable = false;
            this.cIssue.Text = "Ngày cấp";
            // 
            // cAllocationPlace
            // 
            this.cAllocationPlace.Editable = false;
            this.cAllocationPlace.Text = "Nơi cấp";
            // 
            // cInsurance
            // 
            this.cInsurance.Text = "Số sổ BHXH";
            // 
            // cPhone
            // 
            this.cPhone.Editable = false;
            this.cPhone.Text = "Điện thoại";
            // 
            // cTrinhdo
            // 
            this.cTrinhdo.Editable = false;
            this.cTrinhdo.Text = "Trình độ";
            this.cTrinhdo.Width = 58;
            // 
            // cAddress
            // 
            this.cAddress.Editable = false;
            this.cAddress.Text = "Địa chỉ thường trú";
            this.cAddress.Width = 120;
            // 
            // cTemporaryAddress
            // 
            this.cTemporaryAddress.Editable = false;
            this.cTemporaryAddress.Text = "Địa chỉ tạm trú";
            this.cTemporaryAddress.Width = 120;
            // 
            // cCommune
            // 
            this.cCommune.Editable = false;
            this.cCommune.Text = "Phường/xã";
            this.cCommune.Width = 80;
            // 
            // cDistrict
            // 
            this.cDistrict.Editable = false;
            this.cDistrict.Text = "Quận/huyện";
            this.cDistrict.Width = 80;
            // 
            // cProvince
            // 
            this.cProvince.Text = "Tỉnh/T.phố";
            this.cProvince.Width = 80;
            // 
            // cPosition
            // 
            this.cPosition.Editable = false;
            this.cPosition.Text = "Chức vụ";
            this.cPosition.Width = 62;
            // 
            // cStartTrial
            // 
            this.cStartTrial.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cStartTrial.Editable = false;
            this.cStartTrial.Text = "Ngày thử việc";
            this.cStartTrial.Width = 91;
            // 
            // cStartDate
            // 
            this.cStartDate.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cStartDate.Text = "Ngày chính thức";
            this.cStartDate.Width = 98;
            // 
            // cStopDate
            // 
            this.cStopDate.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cStopDate.Editable = false;
            this.cStopDate.Text = "Thôi việc";
            this.cStopDate.Visible = false;
            this.cStopDate.Width = 98;
            // 
            // cBasicSalary
            // 
            this.cBasicSalary.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cBasicSalary.Editable = false;
            this.cBasicSalary.Format = "#,##0;(#,##0);-";
            this.cBasicSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cBasicSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cBasicSalary.Text = "Lương cơ bản";
            this.cBasicSalary.Width = 84;
            // 
            // LunchAllowance
            // 
            this.LunchAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.LunchAllowance.Editable = false;
            this.LunchAllowance.Format = "#,##0;(#,##0);-";
            this.LunchAllowance.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LunchAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LunchAllowance.Text = "PC ăn trưa";
            this.LunchAllowance.Width = 84;
            // 
            // DangerousAllowance
            // 
            this.DangerousAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.DangerousAllowance.Editable = false;
            this.DangerousAllowance.Format = "#,##0;(#,##0);-";
            this.DangerousAllowance.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DangerousAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.DangerousAllowance.Text = "PC công việc";
            this.DangerousAllowance.Width = 84;
            // 
            // ResponsibleAllowance
            // 
            this.ResponsibleAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.ResponsibleAllowance.Editable = false;
            this.ResponsibleAllowance.Format = "#,##0;(#,##0);-";
            this.ResponsibleAllowance.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ResponsibleAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ResponsibleAllowance.Text = "PC trách nhiệm";
            this.ResponsibleAllowance.Width = 84;
            // 
            // HarmfulAllowance
            // 
            this.HarmfulAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.HarmfulAllowance.Editable = false;
            this.HarmfulAllowance.Format = "#,##0;(#,##0);-";
            this.HarmfulAllowance.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HarmfulAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.HarmfulAllowance.Text = "PC Độc hại";
            this.HarmfulAllowance.Width = 84;
            // 
            // IntimateAllowance
            // 
            this.IntimateAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.IntimateAllowance.Editable = false;
            this.IntimateAllowance.Format = "#,##0;(#,##0);-";
            this.IntimateAllowance.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IntimateAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.IntimateAllowance.Text = "PC đi lại";
            this.IntimateAllowance.Width = 84;
            // 
            // bIntimateAllowanceFixed
            // 
            this.bIntimateAllowanceFixed.Editable = false;
            this.bIntimateAllowanceFixed.Text = "PC ĐL cố định";
            // 
            // cTotalYear
            // 
            this.cTotalYear.Text = "Số năm";
            // 
            // cTotalMonth
            // 
            this.cTotalMonth.Text = "Số tháng";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployee.Location = new System.Drawing.Point(8, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(812, 24);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Tổng số nhân viên trong danh sách: 999";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnEdit);
            this.pnButtons.Controls.Add(this.btnClose);
            this.pnButtons.Controls.Add(this.btnSearch);
            this.pnButtons.Controls.Add(this.txtSearch);
            this.pnButtons.Controls.Add(this.btnUpdateBarCode);
            this.pnButtons.Controls.Add(this.btnExcelBarCode);
            this.pnButtons.Controls.Add(this.btnExcel);
            this.pnButtons.Controls.Add(this.btnPermanentDelete);
            this.pnButtons.Controls.Add(this.btnAdd);
            this.pnButtons.Controls.Add(this.btnRestore);
            this.pnButtons.Controls.Add(this.btnDelete);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 510);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(820, 40);
            this.pnButtons.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Location = new System.Drawing.Point(580, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(740, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(128, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(16, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnUpdateBarCode
            // 
            this.btnUpdateBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBarCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateBarCode.Location = new System.Drawing.Point(131, 8);
            this.btnUpdateBarCode.Name = "btnUpdateBarCode";
            this.btnUpdateBarCode.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateBarCode.TabIndex = 2;
            this.btnUpdateBarCode.Text = "Cập nhật mã vạch";
            this.btnUpdateBarCode.Visible = false;
            this.btnUpdateBarCode.Click += new System.EventHandler(this.btnUpdateBarCode_Click);
            // 
            // btnExcelBarCode
            // 
            this.btnExcelBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelBarCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcelBarCode.Location = new System.Drawing.Point(244, 8);
            this.btnExcelBarCode.Name = "btnExcelBarCode";
            this.btnExcelBarCode.Size = new System.Drawing.Size(136, 23);
            this.btnExcelBarCode.TabIndex = 3;
            this.btnExcelBarCode.Text = "Xuất Excel hỗ trợ mã vạch";
            this.btnExcelBarCode.Click += new System.EventHandler(this.btnExcelBarCode_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(388, 8);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Xuất &Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPermanentDelete
            // 
            this.btnPermanentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermanentDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPermanentDelete.Location = new System.Drawing.Point(660, 8);
            this.btnPermanentDelete.Name = "btnPermanentDelete";
            this.btnPermanentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPermanentDelete.TabIndex = 6;
            this.btnPermanentDelete.Text = "&Xóa";
            this.btnPermanentDelete.Click += new System.EventHandler(this.btnPermanentDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(500, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm &mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Location = new System.Drawing.Point(500, 9);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "&Khôi phục";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(660, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Thôi việc";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 550);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // frmListEmployees
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1020, 550);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnEmployee);
            this.Controls.Add(this.pnDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListEmployees";
            this.Text = "Danh sách nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListEmployees_Load);
            this.pnDepartment.ResumeLayout(false);
            this.pnEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployeeBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).EndInit();
            this.pnButtons.ResumeLayout(false);
            this.pnButtons.PerformLayout();
            this.ResumeLayout(false);

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

        public frmListEmployees()
        {
            InitializeComponent();
        }

        #region Variables
        /// <summary>
        /// 
        /// </summary>
        private DepartmentDO departmentDO = null;
        /// <summary>
        /// 
        /// </summary>
        private EmployeeDO employeeDO = null;
        /// <summary>
        /// DataSet Employee
        /// </summary>
        private DataSet dsEmployee = null;
        /// <summary>
        /// Hàng hiện tại được chọn trong DataSet
        /// </summary>
        private int selectedRowIndex = -1;
        /// <summary>
        /// Tên file xuất danh sách nhân viên đang làm việc ra excel
        /// </summary>
        private string DANH_SACH_NHAN_VIEN = "Temp_DanhSachNhanVien.xls";
        /// <summary>
        /// Tên file xuất danh sách nhân viên nghỉ việc ra excel
        /// </summary>
        private string DANH_SACH_NHAN_VIEN_THOI_VIEC = "Temp_DanhSachNhanVienThoiViec.xls";
        /// <summary>
        ///Bien kiem tra dang list ds nhan vien thoi viec hay van dang lam viec 
        /// </summary>
        private bool checkEmployeeDeleted = false;
        #endregion

        #region Methods user defined
        /// <summary>
        /// Chuyển chức vụ sang dạng xâu
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        private String ConvertProfessionalLevel2String(int pro)
        {
            string temp = "";
            switch (pro)
            {
                case 0:
                    temp = "Phổ thông";
                    break;
                case 1:
                    temp = "Trung cấp";
                    break;
                case 2:
                    temp = "Cao đẳng";
                    break;
                case 3:
                    temp = "Đại học";
                    break;
                case 4:
                    temp = "Sau đại học";
                    break;
            }
            return temp;
        }

        /// <summary>
        /// Hiển thị danh sách nhân viên trong công ty/phòng ban
        /// </summary>
        private void PopulateEmployeeListView()
        {
            lvwEmployee.BeginUpdate();
            lvwEmployee.TableModel.Rows.Clear();

            lvwEmployeeBarcode.BeginUpdate();
            lvwEmployeeBarcode.TableModel.Rows.Clear();

            int STT = 0;
            string strBarCode;
            foreach (DataRow dr in dsEmployee.Tables[0].Rows)
            {

                Cell DepartmentName = new Cell();
                DepartmentName = new Cell(dr["DepartmentName"].ToString());
                Cell DepartmentNameBC = new Cell(Utils.RemoveSign4VietnameseString(dr["DepartmentName"].ToString()));
                Cell CardID = new Cell(dr["CardID"].ToString());
                Cell BarCode = new Cell("");
                Cell BarCodeNew = new Cell("");
                if (dr["BarCode"] != DBNull.Value)
                {
                    BarCode = new Cell(dr["BarCode"].ToString());
                    //Ma BarCode bo so check code
                    strBarCode = dr["BarCode"].ToString();
                    if (strBarCode.Length > 0)
                        BarCodeNew = new Cell(strBarCode.Substring(0, strBarCode.Length - 1));
                }
                Cell EmployeeID = new Cell(dr["EmployeeID"].ToString());
                Cell EmployeeName = new Cell(dr["EmployeeName"].ToString());
                Cell EmployeeNameBC = new Cell(Utils.RemoveSign4VietnameseString(dr["EmployeeName"].ToString()));

                Cell Gender = new Cell(Int32.Parse(dr["Gender"].ToString()) == 0 ? "Nam" : "Nữ");
                Cell DateOfBirth = new Cell(DateTime.Parse(dr["DateOfBirth"].ToString()).ToString("dd/MM/yyyy"));
                Cell IdentityCard = new Cell(dr["IdentityCard"].ToString());
                Cell Issue = new Cell(DateTime.Parse(dr["Issue"].ToString()).ToString("dd/MM/yyyy"));//Ngày cấp CMND
                Cell AllocationPlace = new Cell(dr["AllocationPlace"].ToString());//Nơi cấp CMND
                Cell InsuranceID = new Cell(dr["InsuranceID"].ToString());
                Cell Address = new Cell(dr["Address"].ToString());//Địa chỉ thường trú
                Cell TemporaryAddress = new Cell(dr["TemporaryAddress"].ToString());//Địa chỉ tạm trú
                Cell Phone = new Cell(dr["Phone"].ToString());
                string professionalLevel = ConvertProfessionalLevel2String(int.Parse(dr["ProfessionalLevel"].ToString()));
                Cell ProfessionalLevel = new Cell(professionalLevel);
                Cell Commune = new Cell(dr["Commune"].ToString());
                Cell District = new Cell(dr["District"].ToString());
                Cell Province = new Cell(dr["Province"].ToString());
                Cell Position = new Cell(dr["PositionName"].ToString());
                Cell TaxID = new Cell(dr["TaxID"].ToString());
                Cell FamilyConditionNumber = new Cell("");
                if (dr["FamilyConditionNumber"] != DBNull.Value)
                {
                    FamilyConditionNumber = new Cell(Int32.Parse(dr["FamilyConditionNumber"].ToString()));
                }

                Cell StartTrial = new Cell("");
                if (dr["StartTrial"] != DBNull.Value)
                {
                    StartTrial = new Cell(DateTime.Parse(dr["StartTrial"].ToString()).ToString("dd/MM/yyyy"));
                }
                int Start_month = 0;
                int Stop_month = 0;
                int Start_year = 0;
                int Stop_year = 0;
                int totalMonth = 0;
                int totalYear = 0;
                Cell StartDate = new Cell("");

                if (dr["StartDate"] != DBNull.Value)
                {
                    StartDate = new Cell(DateTime.Parse(dr["StartDate"].ToString()).ToString("dd/MM/yyyy"));
                    Start_month = DateTime.Parse(dr["StartDate"].ToString()).Month;
                    Start_year = DateTime.Parse(dr["StartDate"].ToString()).Year;
                }
                Cell BasicSalary = new Cell("");
                if (dr["BasicSalary"] != DBNull.Value)
                {
                    BasicSalary = new Cell(double.Parse(dr["BasicSalary"].ToString()));
                }

                Cell LunchAllowance = new Cell("");
                if (dr["LunchAllowance"] != DBNull.Value)
                {
                    LunchAllowance = new Cell(double.Parse(dr["LunchAllowance"].ToString()));
                }

                Cell DangerousAllowance = new Cell("");
                if (dr["DangerousAllowance"] != DBNull.Value)
                {
                    DangerousAllowance = new Cell(double.Parse(dr["DangerousAllowance"].ToString()));
                }

                Cell ResponsibleAllowance = new Cell("");
                if (dr["ResponsibleAllowance"] != DBNull.Value)
                {
                    ResponsibleAllowance = new Cell(double.Parse(dr["ResponsibleAllowance"].ToString()));
                }

                Cell HarmfulAllowance = new Cell("");
                if (dr["HarmfulAllowance"] != DBNull.Value)
                {
                    HarmfulAllowance = new Cell(double.Parse(dr["HarmfulAllowance"].ToString()));
                }

                Cell IntimateAllowance = new Cell("");
                if (dr["IntimateAllowance"] != DBNull.Value)
                {
                    IntimateAllowance = new Cell(double.Parse(dr["IntimateAllowance"].ToString()));
                }

                Cell IntimateAllowanceFixed = new Cell("");
                if (dr["IntimateAllowanceFixed"] != DBNull.Value)
                {
                    IntimateAllowanceFixed = new Cell("", Convert.ToBoolean(dr["IntimateAllowanceFixed"]));
                }

                Cell StopDate = new Cell("");

                if (dr["StopDate"] != DBNull.Value)
                {
                    StopDate = new Cell(DateTime.Parse(dr["StopDate"].ToString()).ToString("dd/MM/yyyy"));
                    Stop_month = DateTime.Parse(dr["StopDate"].ToString()).Month;
                    Stop_year = DateTime.Parse(dr["StopDate"].ToString()).Year;
                }
                if ((Start_year != 0) && (Start_month != 0))
                {
                    if (delete == 1)
                    {
                        totalMonth = Stop_month - Start_month;
                        totalYear = Stop_year - Start_year;
                        if (totalMonth < 0)
                        {
                            totalMonth = totalMonth + 12;
                            totalYear = totalYear - 1;
                        }
                    }
                    else
                    {
                        totalMonth = DateTime.Now.Month - Start_month;
                        totalYear = DateTime.Now.Year - Start_year;
                        if (totalMonth < 0)
                        {
                            if (totalYear == 0)//Nhân viên thử việc
                            {
                                totalMonth = 0;
                                totalYear = 0;
                            }
                            else if (totalYear >= 1)
                            {
                                totalMonth = totalMonth + 12;
                                totalYear = totalYear - 1;
                            }

                        }
                    }
                }
                else
                {
                    totalMonth = 0;
                    totalYear = 0;
                }
                Cell Total_Month = new Cell(totalMonth.ToString());
                Cell Total_Year = new Cell(totalYear.ToString());

                string kinhnghiem = "";
                if ((totalYear == 0) && (totalMonth == 0)) ;
                else if ((totalYear == 0) && (totalMonth < 6))
                    kinhnghiem = "I";
                else if (((totalYear == 0) && (totalMonth >= 6)) || ((totalYear == 1) && (totalMonth == 0)))
                    kinhnghiem = "II";
                else kinhnghiem = "III";
                Cell Kinhnghiem = new Cell(kinhnghiem.ToString());

                Cell ImageFilePath = new Cell("");
                if (dr["Picture"] != DBNull.Value)
                {
                    string PictureFileName = dr["Picture"].ToString();
                    if (PictureFileName.Equals(""))
                    {
                        ImageFilePath = new Cell(Application.StartupPath + @"\IMAGES\noimage3.jpg");
                    }
                    else
                    {
                        string PictureFilePath = WorkingContext.Setting.PicturePath + '\\' + dr["Picture"].ToString();
                        try
                        {
                            ImageFilePath = new Cell(PictureFilePath);
                        }
                        catch
                        {
                            ImageFilePath = new Cell(Application.StartupPath + @"\IMAGES\noimage3.jpg");
                        }
                    }
                }
                else
                {
                    ImageFilePath = new Cell(Application.StartupPath + "/IMAGES/noimage3.jpg");
                }

                Row row = new Row(new Cell[] { new Cell(STT + 1), DepartmentName, CardID, BarCode, EmployeeName, Gender, DateOfBirth, IdentityCard, Issue, AllocationPlace, InsuranceID, Phone, ProfessionalLevel, Address, TemporaryAddress, Commune, District, Province, Position, StartTrial, StartDate, StopDate, BasicSalary, LunchAllowance, DangerousAllowance, ResponsibleAllowance, HarmfulAllowance, IntimateAllowance, IntimateAllowanceFixed, Total_Year, Total_Month, Kinhnghiem });
                row.Tag = STT;
                lvwEmployee.TableModel.Rows.Add(row);

                STT++;
            }
            lvwEmployee.EndUpdate();
            lvwEmployeeBarcode.EndUpdate();

            string str = WorkingContext.LangManager.GetString("frmliste_text1");
            lblEmployee.Text = "Tổng số nhân viên trong danh sách: " + dsEmployee.Tables[0].Rows.Count;
            lblEmployee.Text = str + dsEmployee.Tables[0].Rows.Count;
            t = dsEmployee.Tables[0].Rows.Count;
            if (checkEmployeeDeleted == false)
            {
                btnRestore.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnPermanentDelete.Visible = false;
            }
            else
            {
                btnRestore.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnPermanentDelete.Visible = true;
            }
        }

        /// <summary>
        /// Tạo bảng lưu dữ liệu xuất ra excel
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable CreatTableEmployeeForExcel(bool bThoiViec)
        {
            System.Data.DataTable tblEmployee = new System.Data.DataTable();

            tblEmployee.Columns.Add("STT", typeof(int));
            tblEmployee.Columns.Add("BoPhan", typeof(string));
            tblEmployee.Columns.Add("MaThe", typeof(string));
            tblEmployee.Columns.Add("MaVach", typeof(string));
            tblEmployee.Columns.Add("TenNhanVien", typeof(string));
            tblEmployee.Columns.Add("GioiTinh", typeof(string));
            tblEmployee.Columns.Add("NgaySinh", typeof(string));
            tblEmployee.Columns.Add("SoCMND", typeof(string));
            tblEmployee.Columns.Add("NgayCap", typeof(string));
            tblEmployee.Columns.Add("NoiCap", typeof(string));
            tblEmployee.Columns.Add("SoBHXH", typeof(string));
            tblEmployee.Columns.Add("DienThoai", typeof(string));
            tblEmployee.Columns.Add("TrinhDo", typeof(string));
            tblEmployee.Columns.Add("DcThuongTru", typeof(string));
            tblEmployee.Columns.Add("DcTamTru", typeof(string));
            tblEmployee.Columns.Add("PhuongXa", typeof(string));
            tblEmployee.Columns.Add("Huyen", typeof(string));
            tblEmployee.Columns.Add("Tinh", typeof(string));
            tblEmployee.Columns.Add("ChuVu", typeof(string));
            tblEmployee.Columns.Add("NgayThuViec", typeof(string));
            tblEmployee.Columns.Add("NgayChinhThuc", typeof(string));
            if (bThoiViec)
                tblEmployee.Columns.Add("ThoiViec", typeof(string));
            tblEmployee.Columns.Add("LuongCoBan", typeof(decimal));
            tblEmployee.Columns.Add("PcAnTrua", typeof(decimal));
            tblEmployee.Columns.Add("PcCongViec", typeof(decimal));
            tblEmployee.Columns.Add("PcNgheNghiep", typeof(decimal));
            tblEmployee.Columns.Add("PcChucVu", typeof(decimal));
            tblEmployee.Columns.Add("PcDiLai", typeof(decimal));
            tblEmployee.Columns.Add("PcCoDinh", typeof(string));
            tblEmployee.Columns.Add("SoNam", typeof(int));
            tblEmployee.Columns.Add("SoThang", typeof(int));
            tblEmployee.Columns.Add("KinhNghiem", typeof(string));

            return tblEmployee;

        }

        /// <summary>
        /// Đổ dữ liệu vào bảng để xuất ra excel
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable KhoiTaoDuLieuBangLuuThongTinXuatExcel(bool bThoiViec)
        {
            System.Data.DataTable tblDuLieuXuatExcelPri = null;
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                tblDuLieuXuatExcelPri = CreatTableEmployeeForExcel(bThoiViec);
                DataRow dtRowPri;
                int index = 1;
                foreach (DataRow dr in dsEmployee.Tables[0].Rows)
                {
                    dtRowPri = tblDuLieuXuatExcelPri.NewRow();
                    dtRowPri["STT"] = index++;
                    dtRowPri["BoPhan"] = dr["DepartmentName"].ToString();
                    dtRowPri["MaThe"] = dr["CardID"].ToString();
                    dtRowPri["MaVach"] = dr["BarCode"].ToString();
                    dtRowPri["TenNhanVien"] = dr["EmployeeName"].ToString();
                    if (dr["Gender"] != DBNull.Value)
                        dtRowPri["GioiTinh"] = Int32.Parse(dr["Gender"].ToString()) == 0 ? "Nam" : "Nữ";
                    if (dr["DateOfBirth"] != DBNull.Value)
                        dtRowPri["NgaySinh"] = DateTime.Parse(dr["DateOfBirth"].ToString()).ToString("dd/MM/yyyy");
                    dtRowPri["SoCMND"] = dr["IdentityCard"].ToString();
                    if (dr["Issue"] != DBNull.Value)
                        dtRowPri["NgayCap"] = DateTime.Parse(dr["Issue"].ToString()).ToString("dd/MM/yyyy");
                    dtRowPri["NoiCap"] = dr["AllocationPlace"].ToString();
                    dtRowPri["SoBHXH"] = dr["InsuranceID"].ToString();
                    dtRowPri["DienThoai"] = dr["Phone"].ToString();
                    if (dr["ProfessionalLevel"] != DBNull.Value)
                        dtRowPri["TrinhDo"] = ConvertProfessionalLevel2String(int.Parse(dr["ProfessionalLevel"].ToString()));
                    dtRowPri["DcThuongTru"] = dr["Address"].ToString();
                    dtRowPri["DcTamTru"] = dr["TemporaryAddress"].ToString();
                    dtRowPri["PhuongXa"] = dr["Commune"].ToString();
                    dtRowPri["Huyen"] = dr["District"].ToString();
                    dtRowPri["Tinh"] = dr["Province"].ToString();
                    dtRowPri["ChuVu"] = dr["PositionName"].ToString();

                    if (dr["StartTrial"] != DBNull.Value)
                        dtRowPri["NgayThuViec"] = DateTime.Parse(dr["StartTrial"].ToString()).ToString("dd/MM/yyyy");

                    int Start_month = 0;
                    int Stop_month = 0;
                    int Start_year = 0;
                    int Stop_year = 0;
                    int totalMonth = 0;
                    int totalYear = 0;

                    if (dr["StartDate"] != DBNull.Value)
                    {
                        dtRowPri["NgayChinhThuc"] = DateTime.Parse(dr["StartDate"].ToString()).ToString("dd/MM/yyyy");
                        Start_month = DateTime.Parse(dr["StartDate"].ToString()).Month;
                        Start_year = DateTime.Parse(dr["StartDate"].ToString()).Year;
                    }
                    if (dr["StopDate"] != DBNull.Value)
                    {
                        Stop_month = DateTime.Parse(dr["StopDate"].ToString()).Month;
                        Stop_year = DateTime.Parse(dr["StopDate"].ToString()).Year;
                        if (bThoiViec)
                            dtRowPri["ThoiViec"] = DateTime.Parse(dr["StopDate"].ToString()).ToString("dd/MM/yyyy");
                    }

                    if (dr["BasicSalary"] != DBNull.Value)
                        dtRowPri["LuongCoBan"] = double.Parse(dr["BasicSalary"].ToString());

                    if (dr["LunchAllowance"] != DBNull.Value)
                        dtRowPri["PcAnTrua"] = double.Parse(dr["LunchAllowance"].ToString());
                    if (dr["DangerousAllowance"] != DBNull.Value)
                        dtRowPri["PcCongViec"] = double.Parse(dr["DangerousAllowance"].ToString());
                    if (dr["ResponsibleAllowance"] != DBNull.Value)
                        dtRowPri["PcNgheNghiep"] = double.Parse(dr["ResponsibleAllowance"].ToString());
                    if (dr["HarmfulAllowance"] != DBNull.Value)
                        dtRowPri["PcChucVu"] = double.Parse(dr["HarmfulAllowance"].ToString());
                    if (dr["IntimateAllowance"] != DBNull.Value)
                        dtRowPri["PcDiLai"] = double.Parse(dr["IntimateAllowance"].ToString());
                    if (dr["IntimateAllowanceFixed"] != DBNull.Value)
                        dtRowPri["PcCoDinh"] = Convert.ToBoolean(dr["IntimateAllowanceFixed"]) == true ? "Có" : "";

                    if ((Start_year != 0) && (Start_month != 0))
                    {
                        if (delete == 1)
                        {
                            totalMonth = Stop_month - Start_month;
                            totalYear = Stop_year - Start_year;
                            if (totalMonth < 0)
                            {
                                totalMonth = totalMonth + 12;
                                totalYear = totalYear - 1;
                            }
                        }
                        else
                        {
                            totalMonth = DateTime.Now.Month - Start_month;
                            totalYear = DateTime.Now.Year - Start_year;
                            if (totalMonth < 0)
                            {
                                if (totalYear == 0)//Nhân viên thử việc
                                {
                                    totalMonth = 0;
                                    totalYear = 0;
                                }
                                else if (totalYear >= 1)
                                {
                                    totalMonth = totalMonth + 12;
                                    totalYear = totalYear - 1;
                                }

                            }
                        }
                    }

                    dtRowPri["SoThang"] = totalMonth.ToString();
                    dtRowPri["SoNam"] = totalYear.ToString();

                    string kinhnghiem = string.Empty;
                    if ((totalYear == 0) && (totalMonth == 0)) ;
                    else if ((totalYear == 0) && (totalMonth < 6))
                        kinhnghiem = "I";
                    else if (((totalYear == 0) && (totalMonth >= 6)) || ((totalYear == 1) && (totalMonth == 0)))
                        kinhnghiem = "II";
                    else kinhnghiem = "III";
                    dtRowPri["KinhNghiem"] = kinhnghiem;

                    tblDuLieuXuatExcelPri.Rows.Add(dtRowPri);
                }
            }
            return tblDuLieuXuatExcelPri;
        }

        public override void Refresh()
        {
            ChangeToCurrentLang();
            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();

        }

        private void ChangeToCurrentLang()
        {
            this.Text = WorkingContext.LangManager.GetString("frmliste_text");
            this.lblDepartment.Text = WorkingContext.LangManager.GetString("frmListEmployee_lblDepartment");
            this.lblEmployee.Text = WorkingContext.LangManager.GetString("frmListEmployee_lblEmployee");
            this.btnDeletedEmployee.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntDeletedEmployee");
            this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntAdd");
            this.btnSearch.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntSearch");
            this.txtSearch.Text = WorkingContext.LangManager.GetString("frmListEmployee_txtSearch");
            this.btnExcel.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnXuatExcel");
            this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntDelete");
            this.btnEdit.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntEdit");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntClose");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_STT");
            this.cDepartmentName.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_Department");
            this.cCardID.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_MaThe");
            this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_TenNhanVien");
            this.cGender.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_GioiTinh");
            this.cDateOfBirth.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_DateOfBirth");
            this.cIdentityCard.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_SCMND");
            this.cInsurance.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_BHXH");
            this.cPhone.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_Phone");
            this.cTrinhdo.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_TrinhDo");
            this.cAddress.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_Addr");
            this.cCommune.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_PhuongXa");
            this.cDistrict.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_QuanHuyen");
            this.cProvince.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_City");
            this.cPosition.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_Position");
            this.cStartDate.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_NgayChinhThuc");
            this.cStartTrial.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_StartDate");
            this.cBasicSalary.Text = WorkingContext.LangManager.GetString("frmListEmployee_lvwEmployee_BasicSalary");

            this.LunchAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance_lblPCAnTrua");
            this.ResponsibleAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance_lblPCTrachNhiem");
            this.HarmfulAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance_lblPCDocHai");
            this.btnRestore.Text = WorkingContext.LangManager.GetString("frmE_btnKP");
            this.btnPermanentDelete.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnDelete");
            this.lvwEmployee.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            this.lblEmployee.Text = WorkingContext.LangManager.GetString("frmliste_text1") + dsEmployee.Tables[0].Rows.Count;
            this.cStopDate.Text = WorkingContext.LangManager.GetString("frmListEmployee_bntDelete");
            this.cTotalMonth.Text = WorkingContext.LangManager.GetString("Bosung_tool11");
            this.cTotalYear.Text = WorkingContext.LangManager.GetString("Bosung_tool10");
            this.txtKinhNghiem.Text = WorkingContext.LangManager.GetString("frmListEmployee_kinhnghiem");
        }
        #endregion

        #region Events Windows Form
        private void frmListEmployees_Load(object sender, EventArgs e)
        {
            EVsoft.HRMS.Common.GeneralProcess.StandardFormControl(this);
            departmentDO = new DepartmentDO();
            employeeDO = new EmployeeDO();

            departmentTreeView.DepartmentDataSet = departmentDO.GetAllDepartments();
            departmentTreeView.BuildTree();
            departmentTreeView.SelectedNode = departmentTreeView.TopNode;

            Refresh();
        }
        
        private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            departmentTreeView.ExpandNodes(true);
            dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);

            PopulateEmployeeListView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (lvwEmployee.SelectedItems.Length > 0)
                {
                    frmEmployee frm = new frmEmployee();
                    frm.EmployeeDataSet = dsEmployee;
                    frm.SelectedEmployee = selectedRowIndex;
                    frm.ShowDialog(this);

                    PopulateEmployeeListView();
                }
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.EmployeeDataSet = dsEmployee;
            frm.ShowDialog(this);

            if (!checkEmployeeDeleted)
                dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
            else
                dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);
            PopulateEmployeeListView();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (lvwEmployee.SelectedItems.Length == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListEm_UpdateE_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListEm_UpdateE_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Sửa nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmEmployee frm = new frmEmployee();
                frm.EmployeeDataSet = dsEmployee;
                frm.SelectedEmployee = selectedRowIndex;

                try
                {
                    frm.ShowDialog();
                }
                catch
                {
                    frm.ShowDialog();
                }

                if (!checkEmployeeDeleted)
                    dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
                else
                    dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);
                PopulateEmployeeListView();
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (lvwEmployee.SelectedItems.Length == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListEm_UpdateE_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListEm_ThoiViecE_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Thôi việc nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int EmployeeID = (int)dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeID"];
            string EmployeeName = dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeName"].ToString();
            string str2 = WorkingContext.LangManager.GetString("frmListEm_ThoiViecE_Messa");
            string str3 = WorkingContext.LangManager.GetString("frmListEm_ThoiViecE_Title1");
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn cho thôi việc nhân viên '" + EmployeeName + "'?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            DialogResult dr = MessageBox.Show(str2 + EmployeeName + "'?", str3, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                int ret = 0;
                try
                {
                    ret = employeeDO.DeleteEmployee(EmployeeID);
                }
                catch
                {
                    dsEmployee.Tables[0].RejectChanges();
                }
                if (ret == 1)
                {
                    string str4 = WorkingContext.LangManager.GetString("frmListEm_ThoiViecE_Messa1");
                    //MessageBox.Show("Nhân viên này đã được cho thôi việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str4, str3, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsEmployee.Tables[0].AcceptChanges();
                    dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
                    PopulateEmployeeListView();
                }
                else if (ret == -1)
                {
                    MessageBox.Show(
                        "Nhân viên này là người quản trị hệ thống! Hãy chọn người quản lý hệ thống khác trước khi cho nhân viên này thôi việc!",
                        "Cho thôi việc nhân viên");
                    dsEmployee.Tables[0].RejectChanges();

                }
                else
                {
                    string str4 = WorkingContext.LangManager.GetString("frmListEm_ThoiViecE_Messa2");
                    //MessageBox.Show("Không thể cho thôi việc nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(str4, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsEmployee.Tables[0].RejectChanges();
                }
            }
        }

        private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dsEmployee = employeeDO.GetSearchEmployee((int)departmentTreeView.SelectedNode.Tag, txtSearch.Text, delete);
                PopulateEmployeeListView();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dsEmployee = employeeDO.GetSearchEmployee((int)departmentTreeView.SelectedNode.Tag, txtSearch.Text, delete);
            PopulateEmployeeListView();
        }

        private void lvwEmployee_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (lvwEmployee.SelectedItems.Length > 0)
                {
                    frmEmployee frm = new frmEmployee();
                    frm.EmployeeDataSet = dsEmployee;
                    frm.SelectedEmployee = selectedRowIndex;
                    frm.ShowDialog(this);

                    PopulateEmployeeListView();
                }
            }
        }

        private void lvwEmployee_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                selectedRowIndex = (int)lvwEmployee.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void btnExcel_Click(object sender, System.EventArgs e)
        {
            //frmStatusMessage message = new frmStatusMessage();
            ////message.Show("Xuất danh sách ra file excel...");
            //string str_xuat = WorkingContext.LangManager.GetString("frmListEmployee_Excel_frmMessa");
            //message.Show(str_xuat);
            //this.Cursor = Cursors.WaitCursor;

            //bool bThoiViec = false;
            //if (checkEmployeeDeleted)
            //    bThoiViec = true;

            //bool bExport = Utils.ExportExcelForEmployee(lvwEmployee, this.Text.ToUpper(), bThoiViec);
            ////if (!Utils.ExportExcel(lvwEmployee, this.Text.ToUpper()))
            //if (!bExport)
            //{
            //    string str = WorkingContext.LangManager.GetString("frmListEm_XuatExcel_Error");
            //    string str1 = WorkingContext.LangManager.GetString("frmListEm_XuatExcel_Error_Title");
            //    //MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //message.Close();
            //this.Cursor = Cursors.Default;

            frmStatusMessage message = new frmStatusMessage();
            //message.Show("Xuất danh sách ra file excel...");
            string str_xuat = WorkingContext.LangManager.GetString("frmListEmployee_Excel_frmMessa");
            message.Show(str_xuat);
            this.Cursor = Cursors.WaitCursor;

            bool bThoiViec = false;
            if (checkEmployeeDeleted)
                bThoiViec = true;

            System.Data.DataTable tblExcelPri = KhoiTaoDuLieuBangLuuThongTinXuatExcel(bThoiViec);
            if (tblExcelPri != null && tblExcelPri.Rows.Count > 0)
            {               
                // Xuất excel
                if(bThoiViec)
                    ExportToExcel.XuatDuLieuRaExcel(4, 0, string.Empty, tblExcelPri, DANH_SACH_NHAN_VIEN_THOI_VIEC);
                else
                    ExportToExcel.XuatDuLieuRaExcel(4, 0, string.Empty, tblExcelPri, DANH_SACH_NHAN_VIEN);                               
            }

            message.Close();
            this.Cursor = Cursors.Default;
        }        

        private void btnDeletedEmployee_Click(object sender, System.EventArgs e)
        {
            if (!checkEmployeeDeleted)
            {
                btnDeletedEmployee.Text = "Danh sách nhân viên";
                checkEmployeeDeleted = true;
                delete = 1;// chon tim kiem theo danh sach nhan vien nghi
                cStopDate.Visible = true;

                dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);
                PopulateEmployeeListView();
            }
            else
            {
                cStopDate.Visible = false;
                btnDeletedEmployee.Text = "Danh sách nhân viên nghỉ";
                checkEmployeeDeleted = false;
                delete = 0;
                dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
                PopulateEmployeeListView();
            }
        }

        private void btnPermanentDelete_Click(object sender, System.EventArgs e)
        {
            string str1 = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Title");
            if (lvwEmployee.SelectedItems.Length == 0)
            {
                string str2 = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Messa3");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Xóa nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string EmployeeName = dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeName"].ToString();
            string str = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Messa");
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa nhân viên '" + EmployeeName + "'?\nTất cả các dữ liệu liên quan đến nhân viên này sẽ bị xóa khỏi hệ thống", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            DialogResult dr = MessageBox.Show(str + "'" + EmployeeName + "' ?", str1, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                int ret = 0;
                try
                {
                    dsEmployee.Tables[0].Rows[selectedRowIndex].Delete();
                    ret = employeeDO.DeleteEmployeePermanent(dsEmployee);
                }
                catch
                {
                    dsEmployee.Tables[0].RejectChanges();
                }
                if (ret != 0)
                {
                    string str2 = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Messa1");
                    //MessageBox.Show("Nhân viên đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsEmployee.Tables[0].AcceptChanges();
                    dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);
                    PopulateEmployeeListView();
                }
                else
                {
                    string str2 = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Messa2");
                    //MessageBox.Show("Không thể xóa nhân viên khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsEmployee.Tables[0].RejectChanges();
                }
            }
        }

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            string str = WorkingContext.LangManager.GetString("frmListEm_KhoiPhucE_Title");
            if (lvwEmployee.SelectedItems.Length == 0)
            {
                string str1 = WorkingContext.LangManager.GetString("frmListEm_DeleteE_Messa3");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Khôi phục nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str1, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int EmployeeID = (int)dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeID"];
            string EmployeeName = dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeName"].ToString();
            string str2 = WorkingContext.LangManager.GetString("frmListEm_KhoiPhucE_Messa");
            //DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn khôi phục nhân viên '" + EmployeeName + "'?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            DialogResult dr = MessageBox.Show(str2 + " '" + EmployeeName + "'?", str, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                int ret = 0;
                try
                {
                    ret = employeeDO.RestoreEmployee(EmployeeID);
                }
                catch
                {
                    dsEmployee.Tables[0].RejectChanges();
                }
                if (ret != 0)
                {
                    string str3 = WorkingContext.LangManager.GetString("frmListEm_KhoiPhucE_Messa1");
                    //MessageBox.Show("Nhân viên đã được khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str3, str, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsEmployee.Tables[0].AcceptChanges();
                    dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);
                    PopulateEmployeeListView();
                }
                else
                {
                    string str3 = WorkingContext.LangManager.GetString("frmListEm_KhoiPhucE_Messa2");
                    //MessageBox.Show("Không thể khôi phục nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(str3, str, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsEmployee.Tables[0].RejectChanges();
                }
            }
        }

        private void btnUpdateBarCode_Click(object sender, EventArgs e)
        {
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                string employeeID;
                foreach (DataRow row in dsEmployee.Tables[0].Rows)
                {
                    employeeID = row["EmployeeID"].ToString();
                    string employeeIDLen12 = employeeID.ToString();
                    if (employeeID.ToString().Length < 12)
                        for (int i = 0; i < (12 - employeeID.ToString().Length); i++)
                            employeeIDLen12 = "0" + employeeIDLen12;

                    if (employeeIDLen12.Length == 12)
                    {
                        row["BarCode"] = employeeIDLen12 + BarCodeHelper.CreateCheckCode(employeeIDLen12);
                        employeeDO.UpdateBarCode(dsEmployee);
                    }
                }

                MessageBox.Show("Cập nhật mã vạch thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsEmployee.Tables[0].AcceptChanges();

                if (!checkEmployeeDeleted)
                    dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
                else
                    dsEmployee = employeeDO.GetDeletedEmployee((int)departmentTreeView.SelectedNode.Tag);

                PopulateEmployeeListView();
            }
        }

        private void btnExcelBarCode_Click(object sender, EventArgs e)
        {
            frmExportExcelBC frm = new frmExportExcelBC();
            frm.dsEmployee = dsEmployee;
            frm.ShowDialog();
        }
        #endregion
    }
}