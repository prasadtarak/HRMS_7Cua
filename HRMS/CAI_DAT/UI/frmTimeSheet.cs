//using Application = Microsoft.Office.Interop.Excel.Application;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using Microsoft.Office.Interop.Excel;
using XPTable.Editors;
using XPTable.Events;
using XPTable.Models;
using Button = System.Windows.Forms.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;
using Excel = Microsoft.Office.Interop.Excel;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Summary description for frmTimeSheet.
    /// </summary>
    public class frmTimeSheet : Form
    {
        private GroupBox groupBox1;
        private Button btnClose;
        private TableModel tableModel1;
        private ColumnModel columnModel1;
        private TextColumn cCardID;
        private TextColumn cEmployeeName;
        private TextColumn cDepartment;
        private TextColumn c7;
        private TextColumn c8;
        private TextColumn c9;
        private TextColumn c10;
        private TextColumn c11;
        private TextColumn c6;
        private TextColumn c1;
        private TextColumn c2;
        private TextColumn c3;
        private TextColumn c4;
        private TextColumn c5;
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
        private GroupBox grbMonth;
        private Label label1;
        private Label label2;
        private LookupComboBox cboMonth;
        private LookupComboBox cboYear;
        private GroupBox grbDepartment;
        private Table lvwTimeSheet;
        private TextColumn cTotal;
        private Button btnUpdate;
        private Button btnExportExcel;
        private Button btnRefresh;
        private MTGCComboBox cboDepartment;
        private Label lblTotalEmployee;
        private NumberColumn cSTT;
        private Button btnSearch;
        private TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGenerateTimeSheet;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public frmTimeSheet()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.lvwTimeSheet = new XPTable.Models.Table();
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
            this.cTotal = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnGenerateTimeSheet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbMonth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.LookupComboBox();
            this.cboMonth = new System.Windows.Forms.LookupComboBox();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new MTGCComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwTimeSheet)).BeginInit();
            this.grbMonth.SuspendLayout();
            this.grbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.Controls.Add(this.lvwTimeSheet);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng chấm công chi tiết tháng";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(136, 376);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(8, 376);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmployee.Location = new System.Drawing.Point(636, 382);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(144, 23);
            this.lblTotalEmployee.TabIndex = 12;
            this.lblTotalEmployee.Text = "Tổng số nhân viên: 343";
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwTimeSheet
            // 
            this.lvwTimeSheet.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwTimeSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTimeSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.lvwTimeSheet.ColumnModel = this.columnModel1;
            this.lvwTimeSheet.EditStartAction = XPTable.Editors.EditStartAction.SingleClick;
            this.lvwTimeSheet.EnableToolTips = true;
            this.lvwTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwTimeSheet.FullRowSelect = true;
            this.lvwTimeSheet.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwTimeSheet.GridLines = XPTable.Models.GridLines.Both;
            this.lvwTimeSheet.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwTimeSheet.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvwTimeSheet.Location = new System.Drawing.Point(0, 19);
            this.lvwTimeSheet.Name = "lvwTimeSheet";
            this.lvwTimeSheet.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwTimeSheet.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwTimeSheet.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwTimeSheet.Size = new System.Drawing.Size(772, 360);
            this.lvwTimeSheet.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwTimeSheet.TabIndex = 11;
            this.lvwTimeSheet.TableModel = this.tableModel1;
            this.lvwTimeSheet.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwTimeSheet.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwTimeSheet.EditingStopped += new XPTable.Events.CellEditEventHandler(this.lvwTimeSheet_EditingStopped);
            this.lvwTimeSheet.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwTimeSheet_SelectionChanged);
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
            this.cTotal});
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
            this.cDepartment.Text = "Bộ phận";
            this.cDepartment.Width = 90;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 50;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Editable = false;
            this.cEmployeeName.Text = "Họ và tên";
            this.cEmployeeName.Width = 140;
            // 
            // c1
            // 
            this.c1.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c1.Sortable = false;
            this.c1.Text = "1";
            this.c1.Width = 28;
            // 
            // c2
            // 
            this.c2.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c2.Sortable = false;
            this.c2.Text = "2";
            this.c2.Width = 28;
            // 
            // c3
            // 
            this.c3.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c3.Sortable = false;
            this.c3.Text = "3";
            this.c3.Width = 28;
            // 
            // c4
            // 
            this.c4.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c4.Sortable = false;
            this.c4.Text = "4";
            this.c4.Width = 28;
            // 
            // c5
            // 
            this.c5.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c5.Sortable = false;
            this.c5.Text = "5";
            this.c5.Width = 28;
            // 
            // c6
            // 
            this.c6.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c6.Sortable = false;
            this.c6.Text = "6";
            this.c6.Width = 28;
            // 
            // c7
            // 
            this.c7.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c7.Sortable = false;
            this.c7.Text = "7";
            this.c7.Width = 28;
            // 
            // c8
            // 
            this.c8.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c8.Sortable = false;
            this.c8.Text = "8";
            this.c8.Width = 28;
            // 
            // c9
            // 
            this.c9.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c9.Sortable = false;
            this.c9.Text = "9";
            this.c9.Width = 28;
            // 
            // c10
            // 
            this.c10.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c10.Sortable = false;
            this.c10.Text = "10";
            this.c10.Width = 28;
            // 
            // c11
            // 
            this.c11.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c11.Sortable = false;
            this.c11.Text = "11";
            this.c11.Width = 28;
            // 
            // c12
            // 
            this.c12.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c12.Sortable = false;
            this.c12.Text = "12";
            this.c12.Width = 28;
            // 
            // c13
            // 
            this.c13.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c13.Sortable = false;
            this.c13.Text = "13";
            this.c13.Width = 28;
            // 
            // c14
            // 
            this.c14.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c14.Sortable = false;
            this.c14.Text = "14";
            this.c14.Width = 28;
            // 
            // c15
            // 
            this.c15.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c15.Sortable = false;
            this.c15.Text = "15";
            this.c15.Width = 28;
            // 
            // c16
            // 
            this.c16.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c16.Sortable = false;
            this.c16.Text = "16";
            this.c16.Width = 28;
            // 
            // c17
            // 
            this.c17.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c17.Sortable = false;
            this.c17.Text = "17";
            this.c17.Width = 28;
            // 
            // c18
            // 
            this.c18.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c18.Sortable = false;
            this.c18.Text = "18";
            this.c18.Width = 28;
            // 
            // c19
            // 
            this.c19.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c19.Sortable = false;
            this.c19.Text = "19";
            this.c19.Width = 28;
            // 
            // c20
            // 
            this.c20.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c20.Sortable = false;
            this.c20.Text = "20";
            this.c20.Width = 28;
            // 
            // c21
            // 
            this.c21.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c21.Sortable = false;
            this.c21.Text = "21";
            this.c21.Width = 28;
            // 
            // c22
            // 
            this.c22.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c22.Sortable = false;
            this.c22.Text = "22";
            this.c22.Width = 28;
            // 
            // c23
            // 
            this.c23.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c23.Sortable = false;
            this.c23.Text = "23";
            this.c23.Width = 28;
            // 
            // c24
            // 
            this.c24.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c24.Sortable = false;
            this.c24.Text = "24";
            this.c24.Width = 28;
            // 
            // c25
            // 
            this.c25.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c25.Sortable = false;
            this.c25.Text = "25";
            this.c25.Width = 28;
            // 
            // c26
            // 
            this.c26.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c26.Sortable = false;
            this.c26.Text = "26";
            this.c26.Width = 28;
            // 
            // c27
            // 
            this.c27.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c27.Sortable = false;
            this.c27.Text = "27";
            this.c27.Width = 28;
            // 
            // c28
            // 
            this.c28.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c28.Sortable = false;
            this.c28.Text = "28";
            this.c28.Width = 28;
            // 
            // c29
            // 
            this.c29.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c29.Sortable = false;
            this.c29.Text = "29";
            this.c29.Width = 28;
            // 
            // c30
            // 
            this.c30.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c30.Sortable = false;
            this.c30.Text = "30";
            this.c30.Width = 28;
            // 
            // c31
            // 
            this.c31.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.c31.Sortable = false;
            this.c31.Text = "31";
            this.c31.Width = 28;
            // 
            // cTotal
            // 
            this.cTotal.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.cTotal.Editable = false;
            this.cTotal.Sortable = false;
            this.cTotal.Text = "Tổng";
            this.cTotal.Width = 45;
            // 
            // btnGenerateTimeSheet
            // 
            this.btnGenerateTimeSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateTimeSheet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateTimeSheet.Location = new System.Drawing.Point(8, 480);
            this.btnGenerateTimeSheet.Name = "btnGenerateTimeSheet";
            this.btnGenerateTimeSheet.Size = new System.Drawing.Size(160, 23);
            this.btnGenerateTimeSheet.TabIndex = 9;
            this.btnGenerateTimeSheet.Text = "&Sinh bảng chấm công";
            this.btnGenerateTimeSheet.Click += new System.EventHandler(this.btnGenerateTimeSheet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(724, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbMonth
            // 
            this.grbMonth.Controls.Add(this.label2);
            this.grbMonth.Controls.Add(this.label1);
            this.grbMonth.Controls.Add(this.cboYear);
            this.grbMonth.Controls.Add(this.cboMonth);
            this.grbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbMonth.Location = new System.Drawing.Point(8, 8);
            this.grbMonth.Name = "grbMonth";
            this.grbMonth.Size = new System.Drawing.Size(200, 48);
            this.grbMonth.TabIndex = 26;
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
            "2012",
            "2013",
            "2014",
            "2015"});
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
            // grbDepartment
            // 
            this.grbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDepartment.Controls.Add(this.cboDepartment);
            this.grbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDepartment.Location = new System.Drawing.Point(576, 0);
            this.grbDepartment.Name = "grbDepartment";
            this.grbDepartment.Size = new System.Drawing.Size(216, 48);
            this.grbDepartment.TabIndex = 27;
            this.grbDepartment.TabStop = false;
            this.grbDepartment.Text = "Bộ phận";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartment.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboDepartment.ColumnNum = 2;
            this.cboDepartment.ColumnWidth = "0;200";
            this.cboDepartment.DisplayMember = "Text";
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDepartment.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboDepartment.DropDownForeColor = System.Drawing.Color.Black;
            this.cboDepartment.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboDepartment.DropDownWidth = 200;
            this.cboDepartment.GridLineColor = System.Drawing.Color.LightGray;
            this.cboDepartment.GridLineHorizontal = true;
            this.cboDepartment.GridLineVertical = true;
            this.cboDepartment.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboDepartment.Location = new System.Drawing.Point(8, 16);
            this.cboDepartment.ManagingFastMouseMoving = true;
            this.cboDepartment.ManagingFastMouseMovingInterval = 30;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(200, 21);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(344, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportExcel.Location = new System.Drawing.Point(512, 480);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(112, 23);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "&Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Location = new System.Drawing.Point(636, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Nạp lại";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(432, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 24);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTimeSheet
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(804, 510);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.grbMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateTimeSheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimeSheet";
            this.Text = "Bảng chấm công chi tiết tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimeSheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwTimeSheet)).EndInit();
            this.grbMonth.ResumeLayout(false);
            this.grbDepartment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Variables

        /// <summary>
        /// 
        /// </summary>
        private TimeSheetDO timesheetDO = null;

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
        private DataSet dsTimeSheet = null;

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
        private int SelectedItem = -1;
        private int t;

        #endregion

        #region Các hàm xử lý dữ liệu chính

        /// <summary>
        /// 
        /// </summary>
        private void PopulateDepartmentCombo()
        {
            departmentDO = new DepartmentDO();
            DataSet dsDepartment = new DataSet();
            dsDepartment = departmentDO.GetAllDepartments();
            cboDepartment.SourceDataString = new string[] { "DepartmentID", "DepartmentName" };
            cboDepartment.SourceDataTable = dsDepartment.Tables[0];
            if (dsDepartment.Tables[0].Rows.Count > 0)
            {
                cboDepartment.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Hiển thị dữ liệu bảng chấm công lên form
        /// </summary>
        private void PopulateTimeSheetData()
        {

            dsTimeSheet = timesheetDO.GetDepartmentTimeSheet(CurrentMonth, CurrentYear, DepartmentID);

            dataRows = dsTimeSheet.Tables[0].Select(dataFilter, dataSort);
            // Load TimeSheet data to table
            lvwTimeSheet.BeginUpdate();
            lvwTimeSheet.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dataRows)
            {
                string CardID = dr["CardID"].ToString();
                string EmployeeName = dr["EmployeeName"].ToString();
                string DepartmentName = dr["DepartmentName"].ToString();
                int OverTime = Int32.Parse(dr["OverTime"].ToString());
                int EmployeeID = Int32.Parse(dr["EmployeeID"].ToString());
                ArrayList arrList = new ArrayList();
                DataSet DsTimeSheetChange = timesheetDO.GetTimeSetChange(CurrentYear, CurrentMonth, EmployeeID, OverTime);
                if (DsTimeSheetChange != null)
                {
                    if (DsTimeSheetChange.Tables.Count > 0)
                    {
                        int Count = DsTimeSheetChange.Tables[0].Rows.Count;
                        foreach (DataRow r in DsTimeSheetChange.Tables[0].Rows)
                        {
                            arrList.Add(r["DayName"].ToString());
                        }
                    }
                }
                Cell[] TimeSheet = new Cell[40];
                TimeSheet[0] = new Cell(STT / 2 + 1);
                TimeSheet[1] = new Cell(DepartmentName);
                TimeSheet[2] = new Cell(CardID);
                TimeSheet[3] = new Cell(EmployeeName);
                if (OverTime == 0)
                {
                    TimeSheet[35] = new Cell(dr["Total"].ToString());
                    TimeSheet[36] = new Cell("");
                    TimeSheet[37] = new Cell("");
                    TimeSheet[38] = new Cell("");
                    TimeSheet[39] = new Cell("");
                }
                else
                {
                    TimeSheet[0].ForeColor = lvwTimeSheet.AlternatingRowColor;
                    TimeSheet[1].ForeColor = lvwTimeSheet.AlternatingRowColor;
                    TimeSheet[2].ForeColor = lvwTimeSheet.AlternatingRowColor;
                    TimeSheet[3].ForeColor = lvwTimeSheet.AlternatingRowColor;

                    TimeSheet[35] = new Cell(dr["Total"].ToString());
                    TimeSheet[36] = new Cell(dr["OverTime1"].ToString());
                    TimeSheet[37] = new Cell(dr["OverTime2"].ToString());
                    TimeSheet[38] = new Cell(dr["OverTime3"].ToString());
                    TimeSheet[39] = new Cell(dr["OverTime4"].ToString());
                }
                double total = 0.0f;
                for (int i = 1; i <= 31; i++)
                {
                    string dayname = "Day" + i;
                    TimeSheet[i + 3] = new Cell(dr[dayname].ToString());
                    if (arrList.Contains(dayname))
                    {
                        TimeSheet[i + 3].BackColor = System.Drawing.Color.Aqua;
                        //TimeSheet[i + 3].CellStyle.Font = System.Drawing.Font.FromHdc(new IntPtr(1));

                    }
                    total += GetCellValue(dr[dayname].ToString());
                }

                Row row = new Row(TimeSheet);
                row.Tag = STT;
                lvwTimeSheet.TableModel.Rows.Add(row);

                STT++;
            }
            lvwTimeSheet.EndUpdate();
            string str = WorkingContext.LangManager.GetString("frmListSalary_lblTongSoNV");
            lblTotalEmployee.Text = str + " " + dataRows.Length / 2;
            t = dataRows.Length / 2;

        }
        private void GetChange()
        {

        }
        /// <summary>
        /// Tự động sinh bảng chấm công dựa trên dữ liệu sẵn có
        /// </summary>
        private void GenerateTimeSheet()
        {
            frmStatusMessage message = new frmStatusMessage();
            string str = WorkingContext.LangManager.GetString("frmTimeSheet_frmmessa");
            //message.Show("Đang sinh dữ liệu bảng chấm công, xin chờ trong giây lát...");
            message.Show(str);

            this.Cursor = Cursors.WaitCursor;
            employeeDO = new EmployeeDO();
            DataSet dsEmployee = employeeDO.GetEmployeeByDepartment(DepartmentID);
            int totalEmployees = dsEmployee.Tables[0].Rows.Count;
            float percentToComplete = 0;
            int percentProcessing = 0;
            //DateTime firstMonth = new DateTime(CurrentYear,CurrentMonth+1,1);

            message.ProgressBar.Value = 0;
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                int ret = 0, ret1 = 1;
                foreach (DataRow dr in dsEmployee.Tables[0].Rows)
                {
                    percentProcessing = ++percentProcessing;
                    int EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                    //chi tinh cong cho nhung nhan vien chua thoi viec
                    // if (!bool.Parse(dr["Deleted"].ToString()) )
                    //{
                    //if (dr["StartTrial"]!=DBNull.Value)
                    // if (DateTime.Parse(dr["StartTrial"].ToString()) < firstMonth)
                    // {
                    try
                    {
                        ret = timesheetDO.GenerateTimeSheet(CurrentMonth, CurrentYear, EmployeeID);
                        percentToComplete = (percentProcessing * 100) / totalEmployees;
                        //ret1: sinh bảng tổng hợp dữ liệu nhân viên trong tháng để hiển thị trên báo cáo tháng, năm của từng nhân viên
                        //						ret1 = timesheetDO.GenerateEmployeeSummaryInMonth(CurrentMonth, CurrentYear, EmployeeID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    // }
                    // }
                    message.ProgressBar.Value = (int)percentToComplete;
                    //						(int)(percentToComplete/totalEmployees);
                }
                message.Close();
                this.Cursor = Cursors.Default;
                if (ret >= 0 && ret1 > 0)
                {
                    string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Messa");
                    string str2 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Title");
                    //MessageBox.Show("Sinh bảng chấm công thành công", "Sinh bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Messa1");
                    string str2 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Title");
                    //MessageBox.Show("Sinh bảng chấm công thất bại", "Sinh bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                message.Close();
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Cập nhật bảng chấm công
        /// </summary>
        private void UpdateTimeSheet()
        {
            int ret = 0;
            try
            {
                // Điền dữ liệu từ listview vào DataSet

                for (int rowIndex = 0; rowIndex < lvwTimeSheet.RowCount; rowIndex++)
                {
                    int STT = (int)lvwTimeSheet.TableModel.Rows[rowIndex].Tag;
                    DataRow dr = dataRows[STT];

                    for (int colIndex = 1; colIndex <= 31; colIndex++)
                    {

                        string dayname = "Day" + colIndex;
                        string OldValue = dr[dayname].ToString();
                        if (lvwTimeSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text != OldValue)
                        {
                            int Year = Convert.ToInt16(dr["Year"]);
                            int Month = Convert.ToInt16(dr["Month"]);
                            int EmployeeID = Convert.ToInt16(dr["EmployeeID"]);
                            int type = Convert.ToInt16(dr["OverTime"]);


                            timesheetDO.UpdateTimeSheetChange(Year, Month, type, EmployeeID, dayname, OldValue, lvwTimeSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text, "");
                            dr[dayname] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text;
                        }
                    }
                    dr["Total"] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[35].Text;
                    if (lvwTimeSheet.TableModel.Rows[rowIndex].Cells[36].Text == "")
                    {
                        dr["OverTime1"] = 0;
                    }
                    else
                    {
                        dr["OverTime1"] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[36].Text;
                    }
                    if (lvwTimeSheet.TableModel.Rows[rowIndex].Cells[37].Text == "")
                    {
                        dr["OverTime2"] = 0;
                    }
                    else
                    {
                        dr["OverTime2"] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[37].Text;
                    }
                    if (lvwTimeSheet.TableModel.Rows[rowIndex].Cells[38].Text == "")
                    {
                        dr["OverTime3"] = 0;
                    }
                    else
                    {
                        dr["OverTime3"] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[38].Text;
                    }
                    if (lvwTimeSheet.TableModel.Rows[rowIndex].Cells[39].Text == "")
                    {
                        dr["OverTime4"] = 0;
                    }
                    else
                    {
                        dr["OverTime4"] = lvwTimeSheet.TableModel.Rows[rowIndex].Cells[39].Text;
                    }
                }
                // Cập nhật
                ret = timesheetDO.UpdateTimeSheet(dsTimeSheet);
            }
            catch
            {
            }
            if (ret != 0)
            {
                string str = WorkingContext.LangManager.GetString("frmTimeSheet_UpDate_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_UpDate_Title");
                //MessageBox.Show("Cập nhật bảng chấm công thành công!", "Cập nhật bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmTimeSheet_UpDate_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_UpDate_Title");
                //MessageBox.Show("Cập nhật bảng chấm công thất bại!", "Cập nhật bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Trả về giá trị số công của một ngày
        /// </summary>
        /// <param name="CellText"></param>
        /// <returns></returns>
        private double GetCellValue(string CellText)
        {
            double mOut = 0;
            if (IsNumeric(CellText))
            {
                if (CellText.Contains("."))
                    double.TryParse(CellText, NumberStyles.Any, new CultureInfo("en-US"), out mOut);
                else
                    double.TryParse(CellText, out mOut);
                return mOut;
            }
            else if (CellText == "NP" || CellText == "CT")
            {
                return 1.0f;

            }
            else
            {
                return 0.0f;
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
                return Double.TryParse(val, NumberStyles.Any, null, out result);
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Windows Form Events Handler

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentID = int.Parse(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1);
            // Get DataSet
            dataFilter = "";
            PopulateTimeSheetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimeSheet_Load(object sender, EventArgs e)
        {
            Refresh();
            timesheetDO = new TimeSheetDO();
            CurrentMonth = DateTime.Now.Month;
            CurrentYear = DateTime.Now.Year;
            cboMonth.SelectedText = CurrentMonth.ToString();
            cboYear.SelectedText = CurrentYear.ToString();
            PopulateDepartmentCombo();
        }

        private void btnGenerateTimeSheet_Click(object sender, EventArgs e)
        {
            // Phòng ban đã được đăng ký thời gian làm việc chưa
            RegWorkingTimeDO regWorkingTimeDO = new RegWorkingTimeDO();
            DataSet dsWorkingTime = regWorkingTimeDO.GetDepartmentWorkingTimeByMonth(DepartmentID, CurrentMonth, CurrentYear);
            if (dsWorkingTime.Tables[0].Rows.Count == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Messa2");
                string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Title");
                //MessageBox.Show("Bộ phận này chưa được đăng ký thời gian làm việc. Không thể sinh bảng chấm công cho bộ phận này", "Sinh bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Bộ phận đã có dữ liệu chấm công hay chưa
            if (dataRows.Length > 0)
            {
                string str = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Messa3");
                string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_SinhBang_Title");
                //				if (MessageBox.Show("Dữ liệu bảng chấm công trong tháng đã tồn tại, bạn có thực sự muốn sinh lại bảng chấm công?", "Sinh bảng chấm công", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                //				{
                //					return;
                //				}
                if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            GenerateTimeSheet();
            // Get DataSet
            PopulateTimeSheetData();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMonth = int.Parse(cboMonth.Text);
            // Get DataSet
            dataFilter = "";
            PopulateTimeSheetData();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentYear = int.Parse(cboYear.Text);
            // Get DataSet
            dataFilter = "";
            PopulateTimeSheetData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Get DataSet
            PopulateTimeSheetData();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            frmStatusMessage message = new frmStatusMessage();
            string str = WorkingContext.LangManager.GetString("frmTimeSheet_XuatExcel_ThongBao");
            //message.Show("Xuất dữ liệu bảng chấm công ra file excel...");
            message.Show(str);
            this.Cursor = Cursors.WaitCursor;
            // Xuất excel
            if (!ExportExcel(lvwTimeSheet, this.Text.ToUpper()))
            {
                string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_XuatExcel_Erroe_Messa");
                string str2 = WorkingContext.LangManager.GetString("frmTimeSheet_XuatExcel_Erroe_Title");
                //MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            message.Close();
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// Xuất dữ liệu ra file excel
        /// </summary>
        /// <param name="table"></param>
        /// <param name="Title"></param>
        /// <returns></returns>
        public bool ExportExcel(XPTable.Models.Table table, String Title)
        {
            System.Threading.Thread thisThread = System.Threading.Thread.CurrentThread;
            CultureInfo originalCulture = thisThread.CurrentCulture;

            thisThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            try
            {
                // Launch Excel and make sure there is an open workbook.
                Excel.Application excel = new Excel.Application();

                ColumnModel columnModel = table.ColumnModel;
                Workbook book = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet sheet = (Worksheet)book.ActiveSheet;

                Range rCompanyName = (Range)sheet.Cells[1, "A"]; // di chuyển con trỏ đến hàng 1 cột A
                rCompanyName.Value2 = "CÔNG TY TNHH ESTELLE VIỆT NAM";// điền dữ liệu vào cell
                rCompanyName.Font.Bold = true;
                Range rTitle = (Range)sheet.Cells[2, "N"]; // di chuyển con trỏ đến hàng 2 cột N
                rTitle.Value2 = Title;// điền dữ liệu vào cell
                rTitle.Font.Bold = true;

                int rowIndex = 4; // Bắt đầu điền dữ liệu từ XPTable vào bảng Excel từ hàng thứ 4
                int colIndex = 0;

                // Fill the worksheet column headings from the dataset.
                foreach (Column col in columnModel.Columns)
                {
                    colIndex++;
                    Excel.Range cell = (Excel.Range)excel.Cells[4, colIndex];
                    cell.Value2 = col.Text;
                    cell.ColumnWidth = col.Width / 6;
                    cell.Font.Bold = true;
                }

                // Điền dữ liệu từ listview vào file excel
                for (rowIndex = 0; rowIndex < table.RowCount; rowIndex++)
                {
                    for (colIndex = 0; colIndex < columnModel.Columns.Count; colIndex++)
                    {
                        if (table.TableModel.Rows[rowIndex].Cells[colIndex].ForeColor == table.AlternatingRowColor)
                        {
                            excel.Cells[rowIndex + 5, colIndex + 1] = "";
                        }
                        else
                        {
                            if (columnModel.Columns[colIndex] is TextColumn)
                            {
                                excel.Cells[rowIndex + 5, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Text;
                            }
                            else
                            {
                                excel.Cells[rowIndex + 5, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Data;
                            }
                        }
                    }
                }
                excel.Visible = true;
                return true; // Xuất excel thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false; // Xuất excel thất bại
            }
            finally
            {
                thisThread.CurrentCulture = originalCulture;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsTimeSheet.Tables[0].Rows.Count > 0)
            {
                UpdateTimeSheet();
                // Get DataSet
                PopulateTimeSheetData();
            }
        }

        private void lvwTimeSheet_EditingStopped(object sender, CellEditEventArgs e)
        {
            int row = e.Row;
            double oldValue = GetCellValue(e.Cell.Text);
            double newValue = GetCellValue(((TextCellEditor)e.Editor).TextBox.Text);
            double total = GetCellValue(lvwTimeSheet.TableModel.Rows[row].Cells[35].Text);
            total = total + newValue - oldValue;
            lvwTimeSheet.TableModel.Rows[row].Cells[35].Text = total.ToString();
        }

        //		private void btnDelete_Click(object sender, EventArgs e)
        //		{
        //			if (dsTimeSheet.Tables[0].Rows.Count > 0)
        //			{
        //				if (MessageBox.Show("Bạn có chắc chắn xóa dữ liệu chấm công tháng không?", "Xóa bảng chấm công", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
        //				{
        ////					DeleteTimeSheet();
        //					// Get DataSet
        //					PopulateTimeSheetData();
        //				}
        //			}
        //		}

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
            dataSort = "DepartmentName, CardID ASC";
            PopulateTimeSheetData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
                dataSort = "DepartmentName, CardID ASC";
                PopulateTimeSheetData();
            }
        }

        #endregion

        private void lvwTimeSheet_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                SelectedItem = (int)lvwTimeSheet.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string str1 = WorkingContext.LangManager.GetString("frmTimeSheet_DeleteE_Title");
            if (SelectedItem < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmTimeSheet_DeleteE_Messa");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào trong danh sách","Xóa nhân viên khỏi bảng chấm công",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string str2 = WorkingContext.LangManager.GetString("frmTimeSheet_DeleteE_Messa1");
            //bạn có thật sự muốn xóa nhân viên khỏi bảng chấm công?
            if (MessageBox.Show(str2, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                //				dsTimeSheet.Tables[0].Rows[SelectedItem].Delete();
                dsTimeSheet.Tables[0].Select(dataFilter, dataSort)[SelectedItem].Delete();
                timesheetDO.DeleteTimeSheet(dsTimeSheet);
                dsTimeSheet.AcceptChanges();
                PopulateTimeSheetData();
            }
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
            this.Text = WorkingContext.LangManager.GetString("frmTimeSheet_Text");
            this.grbMonth.Text = WorkingContext.LangManager.GetString("frmTimeSheet_grbMonth");
            this.label1.Text = WorkingContext.LangManager.GetString("frmTimeSheet_grbMonth_lable1");
            this.label2.Text = WorkingContext.LangManager.GetString("frmTimeSheet_grbMonth_lable2");
            this.grbDepartment.Text = WorkingContext.LangManager.GetString("frmTimeSheet_grbDepartment");
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmTimeSheet_groupbox1");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmTimeSheet_lvwTimeSheet_STT");
            this.cDepartment.Text = WorkingContext.LangManager.GetString("frmTimeSheet_lvwTimeSheet_BoPhan");
            this.cCardID.Text = WorkingContext.LangManager.GetString("frmTimeSheet_lvwTimeSheet_MaTHe");
            this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmTimeSheet_lvwTimeSheet_HoTen");
            this.cTotal.Text = WorkingContext.LangManager.GetString("frmTimeSheet_lvwTimeSheet_Tong");
            this.txtSearch.Text = WorkingContext.LangManager.GetString("frmTimeSheet_txtSearch");
            this.btnSearch.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnSearch");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnClose");
            this.btnDelete.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnDelete");
            this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnUpdate");
            this.btnGenerateTimeSheet.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnSinhBangChamCong");
            this.btnExportExcel.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnXuatExcel");
            this.btnRefresh.Text = WorkingContext.LangManager.GetString("frmTimeSheet_btnRefesh");
            this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmListSalary_lblTongSoNV") + "  " + t;
            this.lvwTimeSheet.NoItemsText = WorkingContext.LangManager.GetString("XPtable");


        }

    }
}