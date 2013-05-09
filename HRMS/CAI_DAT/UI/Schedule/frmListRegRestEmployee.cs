using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Events;
using XPTable.Models;
using System.Data.SqlClient;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// form danh sach nhan vien dang ky nghi
    /// </summary>
    public class frmListRegRestEmployee : Form
    {
        #region Windows Form generated code

        private Label label1;
        private DateTimePicker dtpStartRest;
        private DateTimePicker dtpEndRest;
        private Label label2;
        private Label label3;
        private ComboBox cboDepartment;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnClose;
        private Button btnModify;
        private Button btnDelete;
        private DataGridTextBoxColumn dgsEmployeeName;
        private DataGridTextBoxColumn dgsCardID;
        private DataGridTextBoxColumn dgsDepartment;
        private DataGridTextBoxColumn dtgDayName;
        private DataGridTextBoxColumn dgsRestReason;
        private DataGridTextBoxColumn dtgStartRest;
        private DataGridTextBoxColumn dgsEndRest;
        private Table lvwRestEmployee;
        private ColumnModel columnModel1;
        private TableModel tableModel1;
        private TextColumn cCardID;
        private TextColumn cEmployeeName;
        private TextColumn cDepartmentName;
        private TextColumn cDayName;
        private TextColumn cStartDate;
        private TextColumn cEndDate;
        private TextColumn cRestReason;
        private GroupBox groupBox2;
        private Button btnExcel;
        private NumberColumn cSTT;
        private TextColumn txtThoiGianNghi;
        private Container components = null;

        public frmListRegRestEmployee()
        {
            InitializeComponent();
        }

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListRegRestEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartRest = new System.Windows.Forms.DateTimePicker();
            this.dtpEndRest = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwRestEmployee = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cDepartmentName = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.cDayName = new XPTable.Models.TextColumn();
            this.cStartDate = new XPTable.Models.TextColumn();
            this.cEndDate = new XPTable.Models.TextColumn();
            this.txtThoiGianNghi = new XPTable.Models.TextColumn();
            this.cRestReason = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgsEmployeeName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgsCardID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgsDepartment = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtgDayName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgsRestReason = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtgStartRest = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgsEndRest = new System.Windows.Forms.DataGridTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwRestEmployee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartRest
            // 
            this.dtpStartRest.CustomFormat = "dd/MM/yyyy    ";
            this.dtpStartRest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartRest.Location = new System.Drawing.Point(56, 16);
            this.dtpStartRest.Name = "dtpStartRest";
            this.dtpStartRest.Size = new System.Drawing.Size(112, 20);
            this.dtpStartRest.TabIndex = 1;
            this.dtpStartRest.CloseUp += new System.EventHandler(this.dtpStartRest_CloseUp);
            // 
            // dtpEndRest
            // 
            this.dtpEndRest.CustomFormat = "dd/MM/yyyy   ";
            this.dtpEndRest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndRest.Location = new System.Drawing.Point(240, 16);
            this.dtpEndRest.Name = "dtpEndRest";
            this.dtpEndRest.Size = new System.Drawing.Size(112, 20);
            this.dtpEndRest.TabIndex = 3;
            this.dtpEndRest.CloseUp += new System.EventHandler(this.dtpEndRest_CloseUp);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(184, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(492, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên bộ phận";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Location = new System.Drawing.Point(572, 16);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(208, 21);
            this.cboDepartment.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvwRestEmployee);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 492);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên nghỉ";
            // 
            // lvwRestEmployee
            // 
            this.lvwRestEmployee.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwRestEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRestEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwRestEmployee.ColumnModel = this.columnModel1;
            this.lvwRestEmployee.EnableToolTips = true;
            this.lvwRestEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestEmployee.FullRowSelect = true;
            this.lvwRestEmployee.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwRestEmployee.GridLines = XPTable.Models.GridLines.Both;
            this.lvwRestEmployee.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwRestEmployee.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwRestEmployee.Location = new System.Drawing.Point(8, 16);
            this.lvwRestEmployee.Name = "lvwRestEmployee";
            this.lvwRestEmployee.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwRestEmployee.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestEmployee.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwRestEmployee.Size = new System.Drawing.Size(772, 460);
            this.lvwRestEmployee.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwRestEmployee.TabIndex = 11;
            this.lvwRestEmployee.TableModel = this.tableModel1;
            this.lvwRestEmployee.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwRestEmployee.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwRestEmployee_MouseDown);
            this.lvwRestEmployee.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwRestEmployee_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartmentName,
            this.cCardID,
            this.cEmployeeName,
            this.cDayName,
            this.cStartDate,
            this.cEndDate,
            this.txtThoiGianNghi,
            this.cRestReason});
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
            // cDepartmentName
            // 
            this.cDepartmentName.Editable = false;
            this.cDepartmentName.Text = "Tên bộ phận";
            this.cDepartmentName.Width = 100;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 60;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Editable = false;
            this.cEmployeeName.Text = "Tên nhân viên";
            this.cEmployeeName.Width = 130;
            // 
            // cDayName
            // 
            this.cDayName.Editable = false;
            this.cDayName.Text = "Kiểu ngày nghỉ";
            this.cDayName.Width = 110;
            // 
            // cStartDate
            // 
            this.cStartDate.Editable = false;
            this.cStartDate.Text = "Ngày bắt đầu";
            this.cStartDate.Width = 90;
            // 
            // cEndDate
            // 
            this.cEndDate.Editable = false;
            this.cEndDate.Text = "Ngày kết thúc";
            this.cEndDate.Width = 90;
            // 
            // txtThoiGianNghi
            // 
            this.txtThoiGianNghi.Editable = false;
            this.txtThoiGianNghi.Text = "Thời gian nghỉ";
            this.txtThoiGianNghi.Width = 100;
            // 
            // cRestReason
            // 
            this.cRestReason.Editable = false;
            this.cRestReason.Text = "Lý do nghỉ";
            this.cRestReason.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(636, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModify.Location = new System.Drawing.Point(556, 548);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Sửa";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(716, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(476, 548);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgsEmployeeName
            // 
            //this.dgsEmployeeName.Format = global::EVSoft.HRMS.Common.Lang.LangResource_vi_VN.string1;
            this.dgsEmployeeName.FormatInfo = null;
            this.dgsEmployeeName.HeaderText = "Tên nhân viên";
            this.dgsEmployeeName.MappingName = "EmployeeName";
            this.dgsEmployeeName.Width = 120;
            // 
            // dgsCardID
            // 
            //this.dgsCardID.Format = global::EVSoft.HRMS.Common.Lang.LangResource_vi_VN.string1;
            this.dgsCardID.FormatInfo = null;
            this.dgsCardID.HeaderText = "Mã nhân viên";
            this.dgsCardID.MappingName = "CardID";
            this.dgsCardID.Width = 75;
            // 
            // dgsDepartment
            // 
            //this.dgsDepartment.Format = global::EVSoft.HRMS.Common.Lang.LangResource_vi_VN.string1;
            this.dgsDepartment.FormatInfo = null;
            this.dgsDepartment.HeaderText = "Phòng";
            this.dgsDepartment.MappingName = "DepartmentName";
            this.dgsDepartment.Width = 80;
            // 
            // dtgDayName
            // 
            //this.dtgDayName.Format = global::EVSoft.HRMS.Common.Lang.LangResource_vi_VN.string1;
            this.dtgDayName.FormatInfo = null;
            this.dtgDayName.HeaderText = "Kiểu ngày";
            this.dtgDayName.MappingName = "DayName";
            this.dtgDayName.Width = 90;
            // 
            // dgsRestReason
            // 
            //this.dgsRestReason.Format = global::EVSoft.HRMS.Common.Lang.LangResource_vi_VN.string1;
            this.dgsRestReason.FormatInfo = null;
            this.dgsRestReason.HeaderText = "Lý do nghỉ";
            this.dgsRestReason.MappingName = "RestReason";
            this.dgsRestReason.Width = 120;
            // 
            // dtgStartRest
            // 
            this.dtgStartRest.Format = "dd/MM/yyyy    ";
            this.dtgStartRest.FormatInfo = null;
            this.dtgStartRest.HeaderText = "Bắt đầu";
            this.dtgStartRest.MappingName = "StartRest";
            this.dtgStartRest.Width = 75;
            // 
            // dgsEndRest
            // 
            this.dgsEndRest.Format = "dd/MM/yyyy    ";
            this.dgsEndRest.FormatInfo = null;
            this.dgsEndRest.HeaderText = "Kết thúc";
            this.dgsEndRest.MappingName = "EndRest";
            this.dgsEndRest.Width = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpStartRest);
            this.groupBox2.Controls.Add(this.dtpEndRest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 48);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(352, 548);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(112, 23);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmListRegRestEmployee
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(804, 578);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListRegRestEmployee";
            this.Text = "Danh sách nhân viên nghỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListRegRestEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwRestEmployee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Danh sách các biến
        /// <summary>
        /// 
        /// </summary>
        private DataSet dsRegRestEmployee = null;
        /// <summary>
        /// 
        /// </summary>
        private RegRestEmployeeDO regRestEmployee = null;
        /// <summary>
        /// 
        /// </summary>
        private int selectedRowIndex = -1;

        #endregion

        #region Các hàm khai báo
        public override void Refresh()
        {
            ChangeToCurrentLang();

            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();
        }

        /// <summary>
        /// Thiết lập ngôn ngữ
        /// </summary>
        private void ChangeToCurrentLang()
        {
            this.Text = WorkingContext.LangManager.GetString("frmListRegRest_Text");
            this.label1.Text = WorkingContext.LangManager.GetString("frmListRegRest_lable1");
            this.label2.Text = WorkingContext.LangManager.GetString("frmListRegRest_lable2");
            this.label3.Text = WorkingContext.LangManager.GetString("frmListRegRest_lable3");
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListRegRest_groupbox1");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwSTT");
            this.cDepartmentName.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwBoPhan");
            this.cCardID.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwMeTHe");
            this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwTenNV");
            this.cStartDate.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwNgayBD");
            this.cDayName.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwKieuNN");
            this.cEndDate.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwNgayKT");
            this.cRestReason.Text = WorkingContext.LangManager.GetString("frmListRegRest_lvwLD");
            this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListRegRest_btnAdd");
            this.btnExcel.Text = WorkingContext.LangManager.GetString("frmListRegRest_btnExcel");
            this.btnModify.Text = WorkingContext.LangManager.GetString("frmListRegRest_btnEdit");
            this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListRegRest_btnDelete");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmListRegRest_btnClose");
            this.lvwRestEmployee.NoItemsText = WorkingContext.LangManager.GetString("XPtable");

        }

        /// <summary>
        /// Lấy Danh sách các phòng ban
        /// </summary>
        private void PopulateDepartmentCombo()
        {
            DepartmentDO departmentDO = new DepartmentDO();
            DataSet dsDepartment = departmentDO.GetAllDepartments();

            cboDepartment.DataSource = dsDepartment.Tables[0];
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.DisplayMember = "DepartmentName";
        }

        /// <summary>
        /// Hiển thị danh sách nhân viên đã nghỉ trong khoảng thời gian và bộ phận làm việc
        /// </summary>
        private void PopulateRestEmployee()
        {
            if (dtpStartRest.Value.Date <= dtpEndRest.Value.Date)
            {
                dsRegRestEmployee = regRestEmployee.GetRegRestEmployee(dtpStartRest.Value.Date, dtpEndRest.Value.Date, (int)cboDepartment.SelectedValue);

                lvwRestEmployee.BeginUpdate();
                lvwRestEmployee.TableModel.Rows.Clear();

                DataTable dtRegRestEmployee = dsRegRestEmployee.Tables[0];

                int STT = 0;
                foreach (DataRow dr in dtRegRestEmployee.Rows)
                {
                    string CardID = dr["CardID"].ToString();
                    string EmployeeName = dr["EmployeeName"].ToString();
                    string DepartmentName = dr["DepartmentName"].ToString();
                    string DayName = dr["DayName"].ToString();
                    string StartRest = DateTime.Parse(dr["StartRest"].ToString()).ToString("dd/MM/yyyy");
                    string EndRest = DateTime.Parse(dr["EndRest"].ToString()).ToString("dd/MM/yyyy");
                    string RestReason = dr["RestReason"].ToString();
                    string strTypeRest = "Cả ngày";
                    if (dr["TypeRest"] != DBNull.Value)
                    {
                        bool bTypeRest = Convert.ToBoolean(dr["TypeRest"]);
                        if (bTypeRest)
                            strTypeRest = "Sáng";
                        else
                            strTypeRest = "Chiều";
                    }
                    Cell[] ListRestEmployee = new Cell[9];
                    ListRestEmployee[0] = new Cell(STT + 1);
                    ListRestEmployee[1] = new Cell(DepartmentName);
                    ListRestEmployee[2] = new Cell(CardID);
                    ListRestEmployee[3] = new Cell(EmployeeName);
                    ListRestEmployee[4] = new Cell(DayName);
                    ListRestEmployee[5] = new Cell(StartRest);
                    ListRestEmployee[6] = new Cell(EndRest);
                    ListRestEmployee[7] = new Cell(strTypeRest);
                    ListRestEmployee[8] = new Cell(RestReason);
                    Row row = new Row(ListRestEmployee);
                    row.Tag = STT;
                    lvwRestEmployee.TableModel.Rows.Add(row);
                    STT++;
                }
                lvwRestEmployee.EndUpdate();
            }
            else
            {
                MessageBox.Show("Không hợp lệ! Ngày bắt đầu phải trước ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        #endregion

        #region Các hàm sự kiện
        private void frmListRegRestEmployee_Load(object sender, EventArgs e)
        {
            Refresh();
            regRestEmployee = new RegRestEmployeeDO();

            PopulateDepartmentCombo();

            cboDepartment.SelectedIndex = 0;

            DateTime now = DateTime.Now;
            dtpStartRest.Value = new DateTime(now.Year, now.Month, 1);
            dtpEndRest.Value = DateTime.Today;

            PopulateRestEmployee();

            this.cboDepartment.SelectedIndexChanged += new EventHandler(this.cboDepartment_SelectedIndexChanged);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegRestEmployee restEmployee = new frmRegRestEmployee();
            restEmployee.RestEmployeeDataSet = dsRegRestEmployee;
            restEmployee.ShowDialog();
            PopulateRestEmployee();
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime_Edit_messa");
                string str1 = WorkingContext.LangManager.GetString("frmListRegRest_Delete_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Xóa đăng ký nghỉ của nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa? ", "Xóa đăng ký nghỉ của nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = WorkingContext.GetConnection();
                SqlTransaction trans = null;
                int ret = 0;
                bool bUpdate = false;
                bool bUpdate1 = false;
                int iDayId = -1;

                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    iDayId = Convert.ToInt32(dsRegRestEmployee.Tables[0].Rows[selectedRowIndex]["DayID"]);
                    int iEmployeeID = Convert.ToInt32(dsRegRestEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeID"]);
                    DateTime dtStartRest = Convert.ToDateTime(dsRegRestEmployee.Tables[0].Rows[selectedRowIndex]["StartRest"]);
                    DateTime dtEndRest = Convert.ToDateTime(dsRegRestEmployee.Tables[0].Rows[selectedRowIndex]["EndRest"]);
                    dsRegRestEmployee.Tables[0].Rows[selectedRowIndex].Delete();
                    //Xóa thông tin đăng ký nghỉ của nhân viên
                    ret = regRestEmployee.DeleteRegRestEmployee(dsRegRestEmployee, trans);
                    //Cập nhật lại số ngày nghỉ phép của nhân viên nếu là xóa đăng ký nghỉ phép
                    if (ret == 1 && (iDayId == 200 || iDayId == 219))
                    {
                        if (dtStartRest.Month == dtEndRest.Month)
                            bUpdate = regRestEmployee.UpdateRestSheetEmployee(iEmployeeID, dtStartRest, dtEndRest, dtStartRest, iDayId, trans);
                        else
                        {
                            bUpdate = regRestEmployee.UpdateRestSheetEmployee(iEmployeeID, dtStartRest, dtEndRest, dtStartRest, iDayId, trans);
                            bUpdate = regRestEmployee.UpdateRestSheetEmployee(iEmployeeID, dtStartRest, dtEndRest, dtEndRest, iDayId, trans);
                        }
                    }
                    dsRegRestEmployee.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (trans != null)
                        trans.Rollback();
                    trans.Dispose();
                    return;
                }

                bool bResultPri = false;
                if (iDayId != 200 && iDayId != 219)
                {
                    if (ret == 1)
                    {
                        bResultPri = true;
                    }
                }
                else
                {
                    if (ret == 1 && bUpdate)
                    {
                        bResultPri = true;
                    }
                }
                if (bResultPri)
                {
                    trans.Commit();
                    trans.Dispose();
                }
                else
                {
                    trans.Rollback();
                    trans.Dispose();
                }

                PopulateRestEmployee();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime_Edit_messa");
                string str1 = WorkingContext.LangManager.GetString("frmListRegRest_Edit_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Sửa đăng ký nghỉ của nhân viên", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                frmRegRestEmployee regRestEmployee = new frmRegRestEmployee();
                regRestEmployee.UPDATE = true;
                regRestEmployee.RestEmployeeDataSet = dsRegRestEmployee;
                regRestEmployee.CurrentRestEmployee = selectedRowIndex;
                regRestEmployee.ShowDialog();
                PopulateRestEmployee();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void lvwRestEmployee_SelectionChanged(object sender, SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                selectedRowIndex = (int)lvwRestEmployee.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void lvwRestEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (lvwRestEmployee.SelectedItems.Length > 0)
                {
                    frmRegRestEmployee frm = new frmRegRestEmployee();
                    frm.RestEmployeeDataSet = dsRegRestEmployee;
                    frm.CurrentRestEmployee = selectedRowIndex;
                    frm.ShowDialog(this);
                    PopulateRestEmployee();
                }
                selectedRowIndex = -1;
                tableModel1.Selections.Clear();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            frmStatusMessage message = new frmStatusMessage();
            string str = WorkingContext.LangManager.GetString("frmListRegRest_Messa2");
            //message.Show("Đang xuất dữ liệu bảng đăng ký nghỉ ra file Excel...");
            message.Show(str);
            this.Cursor = Cursors.WaitCursor;
            if (!Utils.ExportExcel(lvwRestEmployee, this.Text.ToUpper()))
            {
                string str1 = WorkingContext.LangManager.GetString("frmRegOverTime_Excell_Messa2");
                string str2 = WorkingContext.LangManager.GetString("frmListRegRest_btnExcel");
                //MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            message.Close();
            this.Cursor = Cursors.Default;
        }

        private void dtpEndRest_ValueChanged(object sender, EventArgs e)
        {
            PopulateRestEmployee();
        }

        private void dtpStartRest_ValueChanged(object sender, EventArgs e)
        {
            PopulateRestEmployee();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRestEmployee();
        }

        private void dtpStartRest_CloseUp(object sender, System.EventArgs e)
        {
            PopulateRestEmployee();
        }

        private void dtpEndRest_CloseUp(object sender, System.EventArgs e)
        {
            PopulateRestEmployee();
        }
        #endregion
    }
}
