//------------------------------------------------------------------------------------
//Class	    : Class thanh toan tien phep
//Purpose	: 
//Author	: chinhnd 9-2005
//Modify	: chinhnd 28_11_2006 by quandh - Cap nhat them truong thanh tien 
//------------------------------------------------------------------------------------

//using Application = Microsoft.Office.Interop.Excel.Application;
using System;
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
using System.Data.SqlClient;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Summary description for frmTimeSheet.
    /// </summary>
    public class frmRestSheet : Form
    {
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestSheet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwRestSheet = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.clSTT = new XPTable.Models.TextColumn();
            this.clDeparmaent = new XPTable.Models.TextColumn();
            this.clCardID = new XPTable.Models.TextColumn();
            this.clEmployeeName = new XPTable.Models.TextColumn();
            this.clMonth1 = new XPTable.Models.TextColumn();
            this.clMonth2 = new XPTable.Models.TextColumn();
            this.clMonth3 = new XPTable.Models.TextColumn();
            this.clMonth4 = new XPTable.Models.TextColumn();
            this.clMonth5 = new XPTable.Models.TextColumn();
            this.clMonth6 = new XPTable.Models.TextColumn();
            this.clMonth7 = new XPTable.Models.TextColumn();
            this.clMonth8 = new XPTable.Models.TextColumn();
            this.clMonth9 = new XPTable.Models.TextColumn();
            this.clMonth10 = new XPTable.Models.TextColumn();
            this.clMonth11 = new XPTable.Models.TextColumn();
            this.clMonth12 = new XPTable.Models.TextColumn();
            this.clTotalRest = new XPTable.Models.TextColumn();
            this.clStartDate = new XPTable.Models.TextColumn();
            this.clTotalRestAllow = new XPTable.Models.TextColumn();
            this.clTotalRestRemain = new XPTable.Models.TextColumn();
            this.cBasicSalary = new XPTable.Models.NumberColumn();
            this.cPhucap = new XPTable.Models.NumberColumn();
            this.toMoney = new XPTable.Models.NumberColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbMonth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.LookupComboBox();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new MTGCComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwRestSheet)).BeginInit();
            this.grbMonth.SuspendLayout();
            this.grbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvwRestSheet);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thanh toán tiền phép chi tiết";
            // 
            // lvwRestSheet
            // 
            this.lvwRestSheet.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwRestSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRestSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwRestSheet.ColumnModel = this.columnModel1;
            this.lvwRestSheet.EditStartAction = XPTable.Editors.EditStartAction.SingleClick;
            this.lvwRestSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestSheet.FullRowSelect = true;
            this.lvwRestSheet.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwRestSheet.GridLines = XPTable.Models.GridLines.Both;
            this.lvwRestSheet.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwRestSheet.Location = new System.Drawing.Point(8, 16);
            this.lvwRestSheet.Name = "lvwRestSheet";
            this.lvwRestSheet.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwRestSheet.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestSheet.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwRestSheet.Size = new System.Drawing.Size(760, 344);
            this.lvwRestSheet.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwRestSheet.TabIndex = 11;
            this.lvwRestSheet.TableModel = this.tableModel1;
            this.lvwRestSheet.Text = "table1";
            this.lvwRestSheet.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwRestSheet.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwRestSheet.EditingStopped += new XPTable.Events.CellEditEventHandler(this.lvwRestSheet_EditingStopped_1);
            this.lvwRestSheet.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwRestSheet_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.clSTT,
            this.clDeparmaent,
            this.clCardID,
            this.clEmployeeName,
            this.clMonth1,
            this.clMonth2,
            this.clMonth3,
            this.clMonth4,
            this.clMonth5,
            this.clMonth6,
            this.clMonth7,
            this.clMonth8,
            this.clMonth9,
            this.clMonth10,
            this.clMonth11,
            this.clMonth12,
            this.clTotalRest,
            this.clStartDate,
            this.clTotalRestAllow,
            this.clTotalRestRemain,
            this.cBasicSalary,
            this.cPhucap,
            this.toMoney});
            // 
            // clSTT
            // 
            this.clSTT.Editable = false;
            this.clSTT.Text = "STT";
            this.clSTT.Width = 40;
            // 
            // clDeparmaent
            // 
            this.clDeparmaent.Editable = false;
            this.clDeparmaent.Text = "Phòng";
            this.clDeparmaent.Width = 120;
            // 
            // clCardID
            // 
            this.clCardID.Editable = false;
            this.clCardID.Text = "Mã thẻ";
            this.clCardID.Width = 60;
            // 
            // clEmployeeName
            // 
            this.clEmployeeName.Editable = false;
            this.clEmployeeName.Text = "Họ tên";
            this.clEmployeeName.Width = 160;
            // 
            // clMonth1
            // 
            this.clMonth1.Text = "1";
            this.clMonth1.Width = 28;
            // 
            // clMonth2
            // 
            this.clMonth2.Text = "2";
            this.clMonth2.Width = 28;
            // 
            // clMonth3
            // 
            this.clMonth3.Text = "3";
            this.clMonth3.Width = 28;
            // 
            // clMonth4
            // 
            this.clMonth4.Text = "4";
            this.clMonth4.Width = 28;
            // 
            // clMonth5
            // 
            this.clMonth5.Text = "5";
            this.clMonth5.Width = 28;
            // 
            // clMonth6
            // 
            this.clMonth6.Text = "6";
            this.clMonth6.Width = 28;
            // 
            // clMonth7
            // 
            this.clMonth7.Text = "7";
            this.clMonth7.Width = 28;
            // 
            // clMonth8
            // 
            this.clMonth8.Text = "8";
            this.clMonth8.Width = 28;
            // 
            // clMonth9
            // 
            this.clMonth9.Text = "9";
            this.clMonth9.Width = 28;
            // 
            // clMonth10
            // 
            this.clMonth10.Text = "10";
            this.clMonth10.Width = 28;
            // 
            // clMonth11
            // 
            this.clMonth11.Text = "11";
            this.clMonth11.Width = 28;
            // 
            // clMonth12
            // 
            this.clMonth12.Text = "12";
            this.clMonth12.Width = 28;
            // 
            // clTotalRest
            // 
            this.clTotalRest.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.clTotalRest.Editable = false;
            this.clTotalRest.Text = "Tổng";
            this.clTotalRest.Width = 40;
            // 
            // clStartDate
            // 
            this.clStartDate.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.clStartDate.Editable = false;
            this.clStartDate.Text = "NKHĐ";
            this.clStartDate.Width = 86;
            // 
            // clTotalRestAllow
            // 
            this.clTotalRestAllow.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.clTotalRestAllow.Editable = false;
            this.clTotalRestAllow.Text = "NPĐH";
            this.clTotalRestAllow.Width = 40;
            // 
            // clTotalRestRemain
            // 
            this.clTotalRestRemain.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.clTotalRestRemain.Editable = false;
            this.clTotalRestRemain.Text = "SNCL";
            this.clTotalRestRemain.Width = 40;
            // 
            // cBasicSalary
            // 
            this.cBasicSalary.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cBasicSalary.Editable = false;
            this.cBasicSalary.Format = "#,##0;(#,##0);0";
            this.cBasicSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cBasicSalary.Text = "Lương cơ bản";
            this.cBasicSalary.Width = 111;
            // 
            // cPhucap
            // 
            this.cPhucap.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cPhucap.Editable = false;
            this.cPhucap.Format = "#,##0;(#,##0);0";
            this.cPhucap.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cPhucap.Text = "Phụ cấp";
            this.cPhucap.Width = 85;
            // 
            // toMoney
            // 
            this.toMoney.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.toMoney.Editable = false;
            this.toMoney.Format = "#,##0;(#,##0);0";
            this.toMoney.Text = "Thành tiền";
            this.toMoney.Width = 90;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(136, 368);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(8, 368);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmployee.Location = new System.Drawing.Point(624, 374);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(144, 23);
            this.lblTotalEmployee.TabIndex = 12;
            this.lblTotalEmployee.Text = "Tổng số nhân viên: 343";
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cSTT.Width = 28;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerate.Location = new System.Drawing.Point(8, 464);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(184, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "&Sinh bảng thanh toán";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(704, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbMonth
            // 
            this.grbMonth.Controls.Add(this.label2);
            this.grbMonth.Controls.Add(this.cboYear);
            this.grbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbMonth.Location = new System.Drawing.Point(8, 8);
            this.grbMonth.Name = "grbMonth";
            this.grbMonth.Size = new System.Drawing.Size(136, 48);
            this.grbMonth.TabIndex = 26;
            this.grbMonth.TabStop = false;
            this.grbMonth.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cboYear.Location = new System.Drawing.Point(56, 16);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(72, 21);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // grbDepartment
            // 
            this.grbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDepartment.Controls.Add(this.cboDepartment);
            this.grbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDepartment.Location = new System.Drawing.Point(568, 8);
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
            this.btnUpdate.Location = new System.Drawing.Point(328, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Câp nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportExcel.Location = new System.Drawing.Point(496, 464);
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
            this.btnRefresh.Location = new System.Drawing.Point(616, 464);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Nạp lại";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(416, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmRestSheet
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.grbMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRestSheet";
            this.Text = "Bảng thanh toán tiền phép chi tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRestSheet_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwRestSheet)).EndInit();
            this.grbMonth.ResumeLayout(false);
            this.grbDepartment.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private GroupBox groupBox1;
        private Button btnClose;

        private GroupBox grbMonth;
        private Label label2;
        private LookupComboBox cboYear;
        private GroupBox grbDepartment;
        private Button btnGenerate;
        private Button btnUpdate;
        private Button btnExportExcel;
        private Button btnRefresh;
        private MTGCComboBox cboDepartment;
        private Label lblTotalEmployee;
        private NumberColumn cSTT;
        private Button btnSearch;
        private TextBox txtSearch;
        private XPTable.Models.Table lvwRestSheet;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn clSTT;
        private XPTable.Models.TextColumn clCardID;
        private XPTable.Models.TextColumn clDeparmaent;
        private XPTable.Models.TextColumn clEmployeeName;
        private XPTable.Models.TextColumn clMonth1;
        private XPTable.Models.TextColumn clMonth2;
        private XPTable.Models.TextColumn clMonth3;
        private XPTable.Models.TextColumn clMonth4;
        private XPTable.Models.TextColumn clMonth5;
        private XPTable.Models.TextColumn clMonth6;
        private XPTable.Models.TextColumn clMonth7;
        private XPTable.Models.TextColumn clMonth8;
        private XPTable.Models.TextColumn clMonth9;
        private XPTable.Models.TextColumn clMonth10;
        private XPTable.Models.TextColumn clMonth11;
        private XPTable.Models.TextColumn clMonth12;
        private XPTable.Models.TextColumn clTotalRest;
        private XPTable.Models.TextColumn clStartDate;
        private XPTable.Models.TextColumn clTotalRestAllow;
        private XPTable.Models.TextColumn clTotalRestRemain;
        private XPTable.Models.NumberColumn toMoney;
        private XPTable.Models.NumberColumn cBasicSalary;
        private XPTable.Models.NumberColumn cPhucap;
        private System.Windows.Forms.Button btnDelete;
        private Container components = null;
        #endregion

        #region Danh sách các biến
        private RestSheetDO restsheetDO = null;
        private DepartmentDO departmentDO = null;
        private EmployeeDO employeeDO = null;
        private DataSet dsRestSheet = null;
        private System.Data.DataTable tblRestSheet;
        private DataRow[] dataRows = null;

        private string dataFilter = "";
        private string dataSort = "";
        private int DepartmentID;
        private int SoNV;
        private int CurrentYear;
        private int CurrentMonth;
        private int SelectedItem = -1;

        private string strTempBangThanhToanTienPhep = "Temp_BangThanhToanTienPhep.xls";
        #endregion

        #region Hàm khởi tạo
        public frmRestSheet()
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
        #endregion

        #region Các hàm khai báo
        /// <summary>
        /// Lấy danh sách phòng ban,bộ phận
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
        private void PopulateRestSheetData()
        {
            restsheetDO = new RestSheetDO();

            dsRestSheet = restsheetDO.GetDepartmentRestSheet(CurrentYear, DepartmentID);
            dataRows = dsRestSheet.Tables[0].Select(dataFilter, dataSort);

            // Load TimeSheet data to table
            lvwRestSheet.BeginUpdate();
            lvwRestSheet.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dataRows)
            {
                string CardID = dr["CardID"].ToString();
                string EmployeeName = dr["EmployeeName"].ToString();
                string DepartmentName = dr["DepartmentName"].ToString();

                Cell[] RestSheet = new Cell[24];
                RestSheet[0] = new Cell((STT + 1).ToString());
                RestSheet[1] = new Cell(DepartmentName);
                RestSheet[2] = new Cell(CardID);
                RestSheet[3] = new Cell(EmployeeName);

                for (int i = 1; i <= 12; i++)
                {
                    string monthname = "month" + i;
                    RestSheet[i + 3] = new Cell(dr[monthname].ToString());
                }
                string tong = dr["TotalRest"].ToString();
                RestSheet[16] = new Cell(tong);
                RestSheet[17] = new Cell();
                if (dr["StartDate"] != DBNull.Value)
                {
                    RestSheet[17] = new Cell(DateTime.Parse(dr["StartDate"].ToString()).ToString("dd/MM/yyyy"));
                }
                string RestAllow = dr["TotalRestAllow"].ToString();
                RestSheet[18] = new Cell(RestAllow);

                string RestRemain = dr["TotalRestRemain"].ToString();
                RestSheet[19] = new Cell(RestRemain);

                double BasicSalary = 0;
                if (dr["BasicSalary"] != DBNull.Value)
                {
                    BasicSalary = double.Parse(dr["BasicSalary"].ToString());
                }
                RestSheet[20] = new Cell(BasicSalary);

                double HarmfulAllowance = 0;
                double ResponsibleAllowance = 0;
                double DangerousAllowance = 0;

                if (dr["HarmfulAllowance"] != DBNull.Value)
                {
                    HarmfulAllowance = double.Parse(dr["HarmfulAllowance"].ToString());
                }
                if (dr["ResponsibleAllowance"] != DBNull.Value)
                {
                    ResponsibleAllowance = double.Parse(dr["ResponsibleAllowance"].ToString());
                }
                if (dr["DangerousAllowance"] != DBNull.Value)
                {
                    DangerousAllowance = double.Parse(dr["DangerousAllowance"].ToString());
                }

                RestSheet[21] = new Cell((HarmfulAllowance + ResponsibleAllowance + DangerousAllowance));

                double toMoney = 0;
                if (dr["toMoney"] != DBNull.Value)
                {
                    toMoney = double.Parse(dr["toMoney"].ToString());
                }
                RestSheet[22] = new Cell(toMoney);
                RestSheet[23] = new Cell();


                Row row = new Row(RestSheet);
                row.Tag = STT;
                lvwRestSheet.TableModel.Rows.Add(row);
                STT++;
            }
            lvwRestSheet.EndUpdate();
            string str1 = WorkingContext.LangManager.GetString("frmRestSheet_lblTotalE");
            //lblTotalEmployee.Text = "Tổng số nhân viên: " + dataRows.Length  ;
            SoNV = dataRows.Length;
            lblTotalEmployee.Text = str1 + dataRows.Length;
        }

        /// <summary>
        /// Tự động sinh bảng thanh toán tiền phép dựa trên dữ liệu sẵn có
        /// </summary>
        private void GenerateRestSheet()
        {
            frmStatusMessage message = new frmStatusMessage();
            message.Show("Đang sinh dữ liệu bảng thanh toán tiền phép, xin chờ trong giây lát...");
            this.Cursor = Cursors.WaitCursor;
            employeeDO = new EmployeeDO();
            DataSet dsEmployee = employeeDO.GetEmployeeByDepartment(DepartmentID);
            int totalEmployees = dsEmployee.Tables[0].Rows.Count;
            float percentToComplete = 0;
            int percentProcessing = 0;

            restsheetDO.DeleteRegRestInYear(CurrentYear);

            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                int ret = 0;
                foreach (DataRow dr in dsEmployee.Tables[0].Rows)
                {
                    int EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                    percentProcessing = ++percentProcessing;
                    try
                    {
                        ret = restsheetDO.GenerateRestSheet(CurrentYear, EmployeeID);
                        percentToComplete = (percentProcessing * 100) / totalEmployees;
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
                    string str = WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Messa");
                    string str1 = WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Title");
                    //MessageBox.Show("Sinh bảng thanh toán tiền phép thành công", "Sinh bảng thanh toán tiền phép", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str = WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Messa1");
                    string str1 = WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Title");
                    //MessageBox.Show("Sinh bảng thanh toán tiền phép thất bại", "Sinh bảng thanh toán tiền phép", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                message.Close();
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Tạo bảng tạm lưu thông tin nghỉ phép của nhân viên
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable TaoBangLuuThongTinNghiPhep()
        {
            System.Data.DataTable tblRestSheetPri = new System.Data.DataTable();

            tblRestSheetPri.Columns.Add("EmployeeID", typeof(int));
            tblRestSheetPri.Columns.Add("RestMonth1", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth2", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth3", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth4", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth5", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth6", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth7", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth8", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth9", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth10", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth11", typeof(string));
            tblRestSheetPri.Columns.Add("RestMonth12", typeof(string));
            tblRestSheetPri.Columns.Add("TotalRestAllow", typeof(float));
            tblRestSheetPri.Columns.Add("TotalRest", typeof(float));

            return tblRestSheetPri;
        }

        /// <summary>
        /// Tổng hợp thông tin nghỉ phép của nhân viên
        /// </summary>
        private void TongHopThongTinNghiPhep(frmStatusMessage frmMessagePara)
        {
            float fPercentToCompletePri = 0;
            int iPercentProcessingPri = 0;
            int iTotalEmployeesPri = 0;

            //Lấy về danh sách nhân viên của phòng ban cần sinh bảng thanh toán phép
            DataSet dtsEmployeePri = employeeDO.GetEmployeeByDepartment(DepartmentID);

            if (dtsEmployeePri != null)
            {
                tblRestSheet = TaoBangLuuThongTinNghiPhep(); //Bảng tạm lưu thông tin nghỉ phép của nhân viên
                iTotalEmployeesPri = dtsEmployeePri.Tables[0].Rows.Count; //Số lượng nhân viên cần tính phép

                foreach (DataRow drEmployee in dtsEmployeePri.Tables[0].Rows)
                {
                    int iEmployeeIDPri = Convert.ToInt32(drEmployee["EmployeeID"]);
                    iPercentProcessingPri = ++iPercentProcessingPri;

                    float fRestAllowPri = 0; // Tổng số phép được hưởng
                    float fTotalRestPri = 0; // Tổng số phép đá nghỉ
                    string[] strRestMonthPri = new string[12]; //Số phép từng tháng trong 1 năm
                    for (int i = 0; i < strRestMonthPri.Length; i++)
                    {
                        strRestMonthPri[i] = "0";
                    }

                    //Lấy thông tin nghỉ phép của nhân viên
                    DataSet dtsRestAllowPri = restsheetDO.GetRestAllowByEmployee(iEmployeeIDPri, CurrentYear, CurrentMonth);
                    if (dtsRestAllowPri != null)
                    {
                        DataRow drRestAllowPri = dtsRestAllowPri.Tables[0].Rows[0];
                        if (drRestAllowPri["StartDate"] != DBNull.Value)
                        {
                            if (drRestAllowPri["TotalRestAllow"] != DBNull.Value)
                            {
                                fRestAllowPri = Convert.ToSingle(drRestAllowPri["TotalRestAllow"]);

                                //Lấy thông tin nghỉ phép của từng tháng trong năm
                                for (int iMonth = 0; iMonth < 12; iMonth++)
                                {
                                    float fRestInMonthPri = restsheetDO.GetRestInMonth(iEmployeeIDPri, CurrentYear, iMonth + 1);
                                    if (fRestInMonthPri > 0)
                                    {
                                        strRestMonthPri[iMonth] = fRestInMonthPri.ToString();

                                        fTotalRestPri += fRestInMonthPri;
                                    }
                                }
                            }
                        }
                    }

                    //Lưu thông tin RestSheet vào bảng tạm để lưu vào database
                    DataRow drRestSheetPri = tblRestSheet.NewRow();

                    drRestSheetPri["EmployeeID"] = iEmployeeIDPri;
                    drRestSheetPri["RestMonth1"] = strRestMonthPri[0];
                    drRestSheetPri["RestMonth2"] = strRestMonthPri[1];
                    drRestSheetPri["RestMonth3"] = strRestMonthPri[2];
                    drRestSheetPri["RestMonth4"] = strRestMonthPri[3];
                    drRestSheetPri["RestMonth5"] = strRestMonthPri[4];
                    drRestSheetPri["RestMonth6"] = strRestMonthPri[5];
                    drRestSheetPri["RestMonth7"] = strRestMonthPri[6];
                    drRestSheetPri["RestMonth8"] = strRestMonthPri[7];
                    drRestSheetPri["RestMonth9"] = strRestMonthPri[8];
                    drRestSheetPri["RestMonth10"] = strRestMonthPri[9];
                    drRestSheetPri["RestMonth11"] = strRestMonthPri[10];
                    drRestSheetPri["RestMonth12"] = strRestMonthPri[11];
                    drRestSheetPri["TotalRestAllow"] = fRestAllowPri;
                    drRestSheetPri["TotalRest"] = fTotalRestPri;

                    tblRestSheet.Rows.Add(drRestSheetPri);

                    fPercentToCompletePri = (iPercentProcessingPri * 100) / iTotalEmployeesPri;
                    frmMessagePara.ProgressBar.Value = (int)fPercentToCompletePri;
                }                
            }
        }

        /// <summary>
        /// Lưu thông tin thanh toán tiền phép
        /// </summary>
        /// <param name="trans"></param>
        private void LuuThongTinTienPhep(SqlTransaction trans)
        {
            SqlCommand com = new SqlCommand("SaveRestSheet");
            com.CommandType = CommandType.StoredProcedure;
            com.Transaction = trans;
            com.Connection = trans.Connection;

            com.Parameters.Clear();
            com.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = CurrentYear;
            SqlParameter prmEmployeeIDPri = com.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int));
            SqlParameter prmRestMonth1Pri = com.Parameters.Add(new SqlParameter("@RestMonth1", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth2Pri = com.Parameters.Add(new SqlParameter("@RestMonth2", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth3Pri = com.Parameters.Add(new SqlParameter("@RestMonth3", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth4Pri = com.Parameters.Add(new SqlParameter("@RestMonth4", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth5Pri = com.Parameters.Add(new SqlParameter("@RestMonth5", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth6Pri = com.Parameters.Add(new SqlParameter("@RestMonth6", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth7Pri = com.Parameters.Add(new SqlParameter("@RestMonth7", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth8Pri = com.Parameters.Add(new SqlParameter("@RestMonth8", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth9Pri = com.Parameters.Add(new SqlParameter("@RestMonth9", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth10Pri = com.Parameters.Add(new SqlParameter("@RestMonth10", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth11Pri = com.Parameters.Add(new SqlParameter("@RestMonth11", SqlDbType.VarChar, 10));
            SqlParameter prmRestMonth12Pri = com.Parameters.Add(new SqlParameter("@RestMonth12", SqlDbType.VarChar, 10));
            SqlParameter prmTotalRestAllowPri = com.Parameters.Add(new SqlParameter("@TotalRestAllow", SqlDbType.Float));
            SqlParameter prmTotalRestPri = com.Parameters.Add(new SqlParameter("@TotalRest", SqlDbType.Float));

            foreach (DataRow drRestSheet in tblRestSheet.Rows)
            {                
                prmEmployeeIDPri.Value = Convert.ToInt32(drRestSheet["EmployeeID"]);
                prmRestMonth1Pri.Value = drRestSheet["RestMonth1"].ToString();
                prmRestMonth2Pri.Value = drRestSheet["RestMonth2"].ToString();
                prmRestMonth3Pri.Value = drRestSheet["RestMonth3"].ToString();
                prmRestMonth4Pri.Value = drRestSheet["RestMonth4"].ToString();
                prmRestMonth5Pri.Value = drRestSheet["RestMonth5"].ToString();
                prmRestMonth6Pri.Value = drRestSheet["RestMonth6"].ToString();
                prmRestMonth7Pri.Value = drRestSheet["RestMonth7"].ToString();
                prmRestMonth8Pri.Value = drRestSheet["RestMonth8"].ToString();
                prmRestMonth9Pri.Value = drRestSheet["RestMonth9"].ToString();
                prmRestMonth10Pri.Value = drRestSheet["RestMonth10"].ToString();
                prmRestMonth11Pri.Value = drRestSheet["RestMonth11"].ToString();
                prmRestMonth12Pri.Value = drRestSheet["RestMonth12"].ToString();
                prmTotalRestAllowPri.Value = Convert.ToSingle(drRestSheet["TotalRestAllow"]);
                prmTotalRestPri.Value = Convert.ToSingle(drRestSheet["TotalRest"]);

                com.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Sinh dữ liệu thanh toán tiền phép
        /// </summary>
        private void SinhBangThanhToanTienPhep()
        {
            frmStatusMessage frmMessagePri = new frmStatusMessage();
            frmMessagePri.Show("Đang sinh dữ liệu bảng thanh toán tiền phép, xin chờ trong giây lát...");
            this.Cursor = Cursors.WaitCursor;

            employeeDO = new EmployeeDO();
            restsheetDO = new RestSheetDO();

            //Tổng hợp thông tin nghỉ phép của nhân viên
            TongHopThongTinNghiPhep(frmMessagePri);

            if (tblRestSheet.Rows.Count > 0)
            {
                SqlConnection con = WorkingContext.GetConnection();
                SqlTransaction trans = null;

                try
                {
                    con.Open();
                    trans = con.BeginTransaction();

                    LuuThongTinTienPhep(trans);

                    frmMessagePri.Close();
                    this.Cursor = Cursors.Default;

                    trans.Commit();
                    trans.Dispose();

                    MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Messa"),
                            WorkingContext.LangManager.GetString("frmRestSheet_Sinh_Title"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    trans.Dispose();

                    frmMessagePri.Close();
                    this.Cursor = Cursors.Default;

                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            else
            {
                frmMessagePri.Close();
                this.Cursor = Cursors.Default;
            }
        }        

        /// <summary>
        /// Cập nhật bảng thanh toán tiền phép
        /// </summary>
        private void UpdateRestSheet()
        {
            int ret = 0;
            try
            {
                // Điền dữ liệu từ listview vào DataSet
                int rowIndex = 0;
                foreach (DataRow dr in dataRows)
                {
                    for (int colIndex = 1; colIndex <= 12; colIndex++)
                    {
                        string monthname = "Month" + colIndex;
                        if (lvwRestSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text == "")
                        {
                            dr[monthname] = "0";
                        }
                        else if (!IsNumeric(lvwRestSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text))
                        {
                            dr[monthname] = "1";
                        }
                        else
                        {
                            dr[monthname] = lvwRestSheet.TableModel.Rows[rowIndex].Cells[colIndex + 3].Text;
                        }
                    }
                    dr["TotalRest"] = lvwRestSheet.TableModel.Rows[rowIndex].Cells[16].Text;
                    dr["TotalRestAllow"] = lvwRestSheet.TableModel.Rows[rowIndex].Cells[18].Text;
                    dr["TotalRestRemain"] = lvwRestSheet.TableModel.Rows[rowIndex].Cells[19].Text;
                    dr["ToMoney"] = lvwRestSheet.TableModel.Rows[rowIndex].Cells[22].Data;
                    rowIndex++;                    
                }

                // Cập nhật
                ret = restsheetDO.UpdateRestSheet(dsRestSheet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (ret != 0)
            {                
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Up_Messa"),
                    WorkingContext.LangManager.GetString("frmRestSheet_Up_Title"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Up_Messa1"),
                    WorkingContext.LangManager.GetString("frmRestSheet_Up_Title"), 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                return 1.0f;
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
                            //else
                            //{
                            //    excel.Cells[rowIndex + 5, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Data;
                            //}
                            //if (colIndex + 1 == 18)
                            //{
                            //    excel.Cells[rowIndex + 5, 18] = Convert.ToDateTime(table.TableModel.Rows[rowIndex].Cells[colIndex].Text).ToString("dd/MM/yyyy");
                            //}

                        }
                    }
                }

                //for (int i = 5; i < table.RowCount; i++)
                //{
                //excel.Cells[i, 18] = Convert.ToDateTime(table.TableModel.Rows[i].Cells[18].Text).ToString("dd/MM/yyyy");

                //    excel.Cells[i, 20] = string.Format(
                //}

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
            this.Text = WorkingContext.LangManager.GetString("frmRestSheet_Text");
            this.grbMonth.Text = WorkingContext.LangManager.GetString("frmRestSheet_grpMonth");
            this.label2.Text = WorkingContext.LangManager.GetString("frmRestSheet_lable2");
            this.grbDepartment.Text = WorkingContext.LangManager.GetString("frmRestSheet_grpDep");
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmRestSheet_groupbox1");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwSTT");
            this.clDeparmaent.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwBoPhan");
            this.clCardID.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwMaTHe");
            this.clEmployeeName.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwTenNV");
            this.clTotalRest.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwTong");
            this.clStartDate.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwNKHD");
            this.clTotalRestAllow.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwNPDH");
            this.clTotalRestRemain.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwSNCL");
            this.cBasicSalary.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwLuong");
            this.cPhucap.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwPhuCap");
            //this.toMoney.Text = WorkingContext.LangManager.GetString("frmRestSheet_lvwThanhTien");
            this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmRestSheet_lblTotalE");
            this.txtSearch.Text = WorkingContext.LangManager.GetString("frmRestSheet_txtSearch");
            this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnUp");
            this.btnSearch.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnSearch");
            this.btnGenerate.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnGenerate");
            this.btnExportExcel.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnExcel");
            this.btnDelete.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnDel");
            this.btnRefresh.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnRefresh");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmRestSheet_btnClose");
            this.lvwRestSheet.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            //this.lvwRestSheet.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmRestSheet_lblTotalE") + ": " + SoNV;


        }

        /// <summary>
        /// Tạo bảng lưu dữ liệu xuất ra excel
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable CreatTableRestSheet()
        {
            System.Data.DataTable tblRestSheet = new System.Data.DataTable();

            tblRestSheet.Columns.Add("STT", typeof(int));
            tblRestSheet.Columns.Add("BoPhan", typeof(string));
            tblRestSheet.Columns.Add("MaThe", typeof(string));
            tblRestSheet.Columns.Add("TenNhanVien", typeof(string));
            tblRestSheet.Columns.Add("Thang1", typeof(decimal));
            tblRestSheet.Columns.Add("Thang2", typeof(decimal));
            tblRestSheet.Columns.Add("Thang3", typeof(decimal));
            tblRestSheet.Columns.Add("Thang4", typeof(decimal));
            tblRestSheet.Columns.Add("Thang5", typeof(decimal));
            tblRestSheet.Columns.Add("Thang6", typeof(decimal));
            tblRestSheet.Columns.Add("Thang7", typeof(decimal));
            tblRestSheet.Columns.Add("Thang8", typeof(decimal));
            tblRestSheet.Columns.Add("Thang9", typeof(decimal));
            tblRestSheet.Columns.Add("Thang10", typeof(decimal));
            tblRestSheet.Columns.Add("Thang11", typeof(decimal));
            tblRestSheet.Columns.Add("Thang12", typeof(decimal));
            tblRestSheet.Columns.Add("TongSoNgayNghi", typeof(decimal));
            tblRestSheet.Columns.Add("NgayKHD", typeof(string));
            tblRestSheet.Columns.Add("TongSoNgayPhep", typeof(decimal));
            tblRestSheet.Columns.Add("SoNgayConLai", typeof(decimal));
            tblRestSheet.Columns.Add("LuongCoBan", typeof(decimal));
            tblRestSheet.Columns.Add("PhuCap", typeof(decimal));
            tblRestSheet.Columns.Add("ThanhTien", typeof(decimal));

            return tblRestSheet;

        }

        /// <summary>
        /// Đổ dữ liệu vào bảng để xuất ra excel
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable KhoiTaoDuLieuBangLuuThongTinXuatExcel()
        {
            System.Data.DataTable tblDuLieuXuatExcelPri = null;
            if (dsRestSheet.Tables[0].Rows.Count > 0)
            {
                tblDuLieuXuatExcelPri = CreatTableRestSheet();
                DataRow dtRowPri;

                for (int i = 0; i < dsRestSheet.Tables[0].Rows.Count; i++)
                {
                    dtRowPri = tblDuLieuXuatExcelPri.NewRow();
                    dtRowPri["STT"] = i + 1;
                    dtRowPri["BoPhan"] = dsRestSheet.Tables[0].Rows[i]["DepartmentName"].ToString();
                    dtRowPri["MaThe"] = dsRestSheet.Tables[0].Rows[i]["CardID"].ToString();
                    dtRowPri["TenNhanVien"] = dsRestSheet.Tables[0].Rows[i]["EmployeeName"].ToString();
                    if (dsRestSheet.Tables[0].Rows[i]["Month1"] != DBNull.Value)
                        dtRowPri["Thang1"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month1"]);
                    else
                        dtRowPri["Thang1"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month2"] != DBNull.Value)
                        dtRowPri["Thang2"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month2"]);
                    else
                        dtRowPri["Thang2"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month3"] != DBNull.Value)
                        dtRowPri["Thang3"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month3"]);
                    else
                        dtRowPri["Thang3"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month4"] != DBNull.Value)
                        dtRowPri["Thang4"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month4"]);
                    else
                        dtRowPri["Thang4"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month5"] != DBNull.Value)
                        dtRowPri["Thang5"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month5"]);
                    else
                        dtRowPri["Thang5"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month6"] != DBNull.Value)
                        dtRowPri["Thang6"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month6"]);
                    else
                        dtRowPri["Thang6"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month7"] != DBNull.Value)
                        dtRowPri["Thang7"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month7"]);
                    else
                        dtRowPri["Thang7"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month8"] != DBNull.Value)
                        dtRowPri["Thang8"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month8"]);
                    else
                        dtRowPri["Thang8"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month9"] != DBNull.Value)
                        dtRowPri["Thang9"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month9"]);
                    else
                        dtRowPri["Thang9"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month10"] != DBNull.Value)
                        dtRowPri["Thang10"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month10"]);
                    else
                        dtRowPri["Thang10"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month11"] != DBNull.Value)
                        dtRowPri["Thang11"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month11"]);
                    else
                        dtRowPri["Thang11"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["Month12"] != DBNull.Value)
                        dtRowPri["Thang12"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["Month12"]);
                    else
                        dtRowPri["Thang12"] = 0;

                    if (dsRestSheet.Tables[0].Rows[i]["TotalRest"] != DBNull.Value)
                        dtRowPri["TongSoNgayNghi"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["TotalRest"]);

                    if (dsRestSheet.Tables[0].Rows[i]["StartDate"] != DBNull.Value)
                    {
                        dtRowPri["NgayKHD"] = Convert.ToDateTime(dsRestSheet.Tables[0].Rows[i]["StartDate"]).ToString("dd/MM/yyyy");
                    }
                    dtRowPri["TongSoNgayPhep"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["TotalRestAllow"]);
                    dtRowPri["SoNgayConLai"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["TotalRestRemain"]);
                    dtRowPri["LuongCoBan"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["BasicSalary"]);

                    //Tính phụ cấp
                    decimal dcHarmfulAllowacePri = 0;
                    decimal dcResponsibleAllowancePri = 0;
                    decimal dcDangerousAllowacePri = 0;
                    if (dsRestSheet.Tables[0].Rows[i]["HarmfulAllowance"] != DBNull.Value)
                        dcHarmfulAllowacePri = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["HarmfulAllowance"]);
                    if (dsRestSheet.Tables[0].Rows[i]["ResponsibleAllowance"] != DBNull.Value)
                        dcResponsibleAllowancePri = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["ResponsibleAllowance"]);
                    if (dsRestSheet.Tables[0].Rows[i]["DangerousAllowance"] != DBNull.Value)
                        dcDangerousAllowacePri = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["DangerousAllowance"]);

                    dtRowPri["PhuCap"] = dcDangerousAllowacePri + dcHarmfulAllowacePri + dcResponsibleAllowancePri;

                    dtRowPri["ThanhTien"] = Convert.ToDecimal(dsRestSheet.Tables[0].Rows[i]["ToMoney"]);

                    tblDuLieuXuatExcelPri.Rows.Add(dtRowPri);
                }
            }
            return tblDuLieuXuatExcelPri;
        }
        #endregion

        #region Các hàm sự kiện
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentID = int.Parse(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1);
            dataFilter = "";
            PopulateRestSheetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Kiểm tra năm tổng hợp phép có hợp lệ không (phải <= năm hiện tại)
            if (CurrentYear > DateTime.Now.Year)
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Messa5"),
                    WorkingContext.LangManager.GetString("Warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.ActiveControl = cboYear;
                return;
            }
            if (dataRows.Length > 0)
            {
                // confirm lại xem có chắc chắn muốn sinh lại bảng thanh toán tiền phép khi dữ liệu này đã có rồi ko?
                if (MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Messa2"),
                    WorkingContext.LangManager.GetString("Confirm"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            SinhBangThanhToanTienPhep();
            PopulateRestSheetData();

            //--------------------------------
            //GenerateRestSheet_New();
            //PopulateRestSheetData();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentYear = int.Parse(cboYear.Text);
            if (CurrentYear != DateTime.Now.Year)
                CurrentMonth = 12;

            PopulateRestSheetData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateRestSheetData();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable tblExcelPri = KhoiTaoDuLieuBangLuuThongTinXuatExcel();
            if (tblExcelPri != null && tblExcelPri.Rows.Count > 0)
            {
                frmStatusMessage message = new frmStatusMessage();
                string str = WorkingContext.LangManager.GetString("frmRestSheet_Messa3");
                message.Show(str);
                this.Cursor = Cursors.WaitCursor;

                // Xuất excel
                string strSubHeaderPri = "Năm " + cboYear.Text;
                ExportToExcel.XuatDuLieuRaExcel(6, 0, strSubHeaderPri, tblExcelPri, strTempBangThanhToanTienPhep);
                message.Close();
                this.Cursor = Cursors.Default;

                #region Bỏ lại
                //if (!ExportExcel(lvwRestSheet, this.Text.ToUpper()))
                //{
                //    string str1 = WorkingContext.LangManager.GetString("frmRestSheet_Messa4");
                //    string str2 = WorkingContext.LangManager.GetString("frmRestSheet_btnExcel");
                //    //MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                #endregion                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsRestSheet.Tables[0].Rows.Count > 0)
            {
                UpdateRestSheet();
                PopulateRestSheetData();
            }
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
            dataSort = "DepartmentName, CardID ASC";
            PopulateRestSheetData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
                dataSort = "DepartmentName, CardID ASC";
                PopulateRestSheetData();
            }
        }

        private void lvwRestSheet_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                SelectedItem = (int)lvwRestSheet.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void frmRestSheet_Load_1(object sender, System.EventArgs e)
        {
            Refresh();
            restsheetDO = new RestSheetDO();
            CurrentYear = DateTime.Now.Year;
            CurrentMonth = DateTime.Now.Month;

            cboYear.SelectedText = CurrentYear.ToString();
            PopulateDepartmentCombo();
            PopulateRestSheetData();
        }

        private void lvwRestSheet_EditingStopped_1(object sender, XPTable.Events.CellEditEventArgs e)
        {
            int row = e.Row;
            double dOldValuePri = GetCellValue(e.Cell.Text);
            double dNewValuePri = GetCellValue(((TextCellEditor)e.Editor).TextBox.Text);
            if (dNewValuePri < 0) //Lỗi nhập giá trị < 0
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Messa1"),
                    WorkingContext.LangManager.GetString("Message"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int iMonthPri = e.Column - 3;
                int iEmployeeIDPri = Convert.ToInt32(dsRestSheet.Tables[0].Rows[row]["EmployeeID"]);
                
                float fRestInMonthPri = restsheetDO.GetRestInMonth(iEmployeeIDPri, CurrentYear, iMonthPri);
                if (Convert.ToDouble(fRestInMonthPri) != dNewValuePri) //Lỗi khi số ngày nghỉ > tổng số ngày đã đăng ký nghỉ trong tháng
                {
                    MessageBox.Show(this, string.Format(WorkingContext.LangManager.GetString("frmRestSheet_Error1_Messa"), iMonthPri, fRestInMonthPri),
                        WorkingContext.LangManager.GetString("Message"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    double dTotalRestPri = 0;
                    for (int i = 4; i < 16; i++)
                    {
                        if (i != e.Column)
                            dTotalRestPri += GetCellValue(lvwRestSheet.TableModel.Rows[row].Cells[i].Text);

                    }
                    dTotalRestPri += dNewValuePri;

                    if (dTotalRestPri > GetCellValue(lvwRestSheet.TableModel.Rows[row].Cells[18].Text)) //Lỗi tổng số ngày nghỉ > số ngày được phép nghỉ
                    {
                        MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRestSheet_Error2_Messa"),
                            WorkingContext.LangManager.GetString("Message"),
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double dTotalremainPri = GetCellValue(lvwRestSheet.TableModel.Rows[row].Cells[19].Text);
                    dTotalremainPri = dTotalremainPri + dOldValuePri - dNewValuePri;

                    if (dTotalremainPri < 0)
                    {
                        dTotalremainPri = 0;
                    }

                    double dBasicSalaryPri = double.Parse((lvwRestSheet.TableModel.Rows[row].Cells[20].Data).ToString());
                    double dAllowancePri = double.Parse((lvwRestSheet.TableModel.Rows[row].Cells[21].Data).ToString());
                    double dAllowMoneyPri = dBasicSalaryPri + dAllowancePri;
                    dAllowMoneyPri = (dTotalremainPri * dAllowMoneyPri) / 24;
                    int iTempPri = Convert.ToInt32(dAllowMoneyPri / 100);
                    iTempPri = iTempPri * 100;
                    dAllowMoneyPri = (double)iTempPri;

                    lvwRestSheet.TableModel.Rows[row].Cells[16].Text = dTotalRestPri.ToString();
                    lvwRestSheet.TableModel.Rows[row].Cells[19].Text = dTotalremainPri.ToString();
                    lvwRestSheet.TableModel.Rows[row].Cells[22].Data = dAllowMoneyPri;
                }
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (SelectedItem < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmRestSheet_Del_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmRestSheet_Del_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào để xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmRestSheet_Del_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmRestSheet_Del_Title");
                // confirm lại xem có chắc chắn muốn xóa nhân viên này khỏi bảng thanh toán tiền phép hay ko?
                if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    dsRestSheet.Tables[0].Select(dataFilter, dataSort)[SelectedItem].Delete();
                    //dsRestSheet.Tables[0].Rows[SelectedItem].Delete();
                    restsheetDO.DeleteRestSheet(dsRestSheet);
                    dsRestSheet.AcceptChanges();
                    PopulateRestSheetData();
                }
            }

        }
        #endregion
    }
}