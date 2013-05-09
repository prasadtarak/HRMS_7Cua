using System;
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
    /// Summary description for frmListSalary.
    /// </summary>
    public class frmListSalary : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.GroupBox grbDepartment;
        private MTGCComboBox cboDepartment;
        private System.Windows.Forms.GroupBox grbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LookupComboBox cboYear;
        private System.Windows.Forms.LookupComboBox cboMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGenerate;
        private XPTable.Models.Table lvwSalary;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn cCardID;
        private XPTable.Models.TextColumn cEmployeeName;
        private XPTable.Models.TextColumn cDepartment;
        private XPTable.Models.TextColumn cOverTime2;
        private XPTable.Models.NumberColumn cRealSalary;
        private XPTable.Models.NumberColumn cSTT;
        private XPTable.Models.NumberColumn cBasicSalary;
        private XPTable.Models.NumberColumn cLunchAllowance;
        private XPTable.Models.NumberColumn cResponsibleAllowance;
        private XPTable.Models.NumberColumn cInsurance;
        private XPTable.Models.NumberColumn cPersonalIncomeTax;
        private XPTable.Models.NumberColumn cOtherDeduction;
        private XPTable.Models.NumberColumn cOverTimeMoney;
        private XPTable.Models.NumberColumn cTotalPaidLunch;
        private XPTable.Models.NumberColumn cHarmfulAllowance;
        private XPTable.Models.NumberColumn cOtherAddition;
        private System.Windows.Forms.Button btnUpdate;
        private XPTable.Models.TextColumn cOverTime3;
        private XPTable.Models.TextColumn cOverTime4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private XPTable.Models.TextColumn cOverTime1;
        private XPTable.Models.NumberColumn cSumMoney;
        private XPTable.Models.NumberColumn cSalaryBLD;
        private System.Windows.Forms.Label lbSumLCB;
        private System.Windows.Forms.Label lbSumLT;
        private System.Windows.Forms.Label lbSumBH;
        private System.Windows.Forms.Label lbSumTL;
        private System.Windows.Forms.Label lbSumKTK;
        private System.Windows.Forms.Label lbSumBHXH;
        private System.Windows.Forms.Label lbSumLCBBH;
        private NumberColumn cIntimateAllowance;
        private NumberColumn clGTGC;
        private NumberColumn cDangerousAllowance;
        private NumberColumn cJapaneseAllowance;
        private NumberColumn cTotalTimeSheet;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmListSalary()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListSalary));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new MTGCComboBox();
            this.grbMonth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.LookupComboBox();
            this.cboMonth = new System.Windows.Forms.LookupComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSumTL = new System.Windows.Forms.Label();
            this.lbSumBH = new System.Windows.Forms.Label();
            this.lbSumLT = new System.Windows.Forms.Label();
            this.lbSumKTK = new System.Windows.Forms.Label();
            this.lbSumBHXH = new System.Windows.Forms.Label();
            this.lbSumLCBBH = new System.Windows.Forms.Label();
            this.lbSumLCB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwSalary = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cDepartment = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.cBasicSalary = new XPTable.Models.NumberColumn();
            this.cHarmfulAllowance = new XPTable.Models.NumberColumn();
            this.cResponsibleAllowance = new XPTable.Models.NumberColumn();
            this.cDangerousAllowance = new XPTable.Models.NumberColumn();
            this.cLunchAllowance = new XPTable.Models.NumberColumn();
            this.cIntimateAllowance = new XPTable.Models.NumberColumn();
            this.cJapaneseAllowance = new XPTable.Models.NumberColumn();
            this.clGTGC = new XPTable.Models.NumberColumn();
            this.cTotalTimeSheet = new XPTable.Models.NumberColumn();
            this.cSumMoney = new XPTable.Models.NumberColumn();
            this.cOverTime1 = new XPTable.Models.TextColumn();
            this.cOverTime2 = new XPTable.Models.TextColumn();
            this.cOverTime3 = new XPTable.Models.TextColumn();
            this.cOverTime4 = new XPTable.Models.TextColumn();
            this.cOverTimeMoney = new XPTable.Models.NumberColumn();
            this.cOtherAddition = new XPTable.Models.NumberColumn();
            this.cInsurance = new XPTable.Models.NumberColumn();
            this.cPersonalIncomeTax = new XPTable.Models.NumberColumn();
            this.cTotalPaidLunch = new XPTable.Models.NumberColumn();
            this.cOtherDeduction = new XPTable.Models.NumberColumn();
            this.cSalaryBLD = new XPTable.Models.NumberColumn();
            this.cRealSalary = new XPTable.Models.NumberColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbDepartment.SuspendLayout();
            this.grbMonth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Location = new System.Drawing.Point(604, 484);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "&Nạp lại";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportExcel.Location = new System.Drawing.Point(300, 484);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 23);
            this.btnExportExcel.TabIndex = 34;
            this.btnExportExcel.Text = "&Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // grbDepartment
            // 
            this.grbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDepartment.Controls.Add(this.cboDepartment);
            this.grbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDepartment.Location = new System.Drawing.Point(548, 8);
            this.grbDepartment.Name = "grbDepartment";
            this.grbDepartment.Size = new System.Drawing.Size(216, 48);
            this.grbDepartment.TabIndex = 36;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbSumTL);
            this.groupBox1.Controls.Add(this.lbSumBH);
            this.groupBox1.Controls.Add(this.lbSumLT);
            this.groupBox1.Controls.Add(this.lbSumKTK);
            this.groupBox1.Controls.Add(this.lbSumBHXH);
            this.groupBox1.Controls.Add(this.lbSumLCBBH);
            this.groupBox1.Controls.Add(this.lbSumLCB);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblTotalEmployee);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 412);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng lương chi tiết tháng";
            // 
            // lbSumTL
            // 
            this.lbSumTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumTL.Location = new System.Drawing.Point(532, 388);
            this.lbSumTL.Name = "lbSumTL";
            this.lbSumTL.Size = new System.Drawing.Size(144, 16);
            this.lbSumTL.TabIndex = 22;
            this.lbSumTL.Text = "Tổng TL:";
            this.lbSumTL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumBH
            // 
            this.lbSumBH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumBH.Location = new System.Drawing.Point(532, 388);
            this.lbSumBH.Name = "lbSumBH";
            this.lbSumBH.Size = new System.Drawing.Size(104, 16);
            this.lbSumBH.TabIndex = 19;
            this.lbSumBH.Text = "Tổng BH:";
            this.lbSumBH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumLT
            // 
            this.lbSumLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumLT.Location = new System.Drawing.Point(420, 388);
            this.lbSumLT.Name = "lbSumLT";
            this.lbSumLT.Size = new System.Drawing.Size(112, 16);
            this.lbSumLT.TabIndex = 18;
            this.lbSumLT.Text = "Tổng LT:";
            this.lbSumLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumKTK
            // 
            this.lbSumKTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumKTK.Location = new System.Drawing.Point(292, 388);
            this.lbSumKTK.Name = "lbSumKTK";
            this.lbSumKTK.Size = new System.Drawing.Size(128, 16);
            this.lbSumKTK.TabIndex = 17;
            this.lbSumKTK.Text = "Tổng KTK:";
            this.lbSumKTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumBHXH
            // 
            this.lbSumBHXH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumBHXH.Location = new System.Drawing.Point(180, 388);
            this.lbSumBHXH.Name = "lbSumBHXH";
            this.lbSumBHXH.Size = new System.Drawing.Size(112, 16);
            this.lbSumBHXH.TabIndex = 16;
            this.lbSumBHXH.Text = "Tổng BH:";
            this.lbSumBHXH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumLCBBH
            // 
            this.lbSumLCBBH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumLCBBH.Location = new System.Drawing.Point(85, 380);
            this.lbSumLCBBH.Name = "lbSumLCBBH";
            this.lbSumLCBBH.Size = new System.Drawing.Size(95, 27);
            this.lbSumLCBBH.TabIndex = 15;
            this.lbSumLCBBH.Text = "Tổng LCB(BH):";
            this.lbSumLCBBH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumLCB
            // 
            this.lbSumLCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumLCB.Location = new System.Drawing.Point(-31, 386);
            this.lbSumLCB.Name = "lbSumLCB";
            this.lbSumLCB.Size = new System.Drawing.Size(79, 21);
            this.lbSumLCB.TabIndex = 14;
            this.lbSumLCB.Text = "Tổng LCB:";
            this.lbSumLCB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lvwSalary);
            this.panel1.Location = new System.Drawing.Point(8, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 356);
            this.panel1.TabIndex = 13;
            // 
            // lvwSalary
            // 
            this.lvwSalary.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwSalary.ColumnModel = this.columnModel1;
            this.lvwSalary.EditStartAction = XPTable.Editors.EditStartAction.SingleClick;
            this.lvwSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwSalary.FullRowSelect = true;
            this.lvwSalary.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwSalary.GridLines = XPTable.Models.GridLines.Both;
            this.lvwSalary.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwSalary.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvwSalary.Location = new System.Drawing.Point(0, 0);
            this.lvwSalary.Name = "lvwSalary";
            this.lvwSalary.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwSalary.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwSalary.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwSalary.Size = new System.Drawing.Size(752, 356);
            this.lvwSalary.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwSalary.TabIndex = 10;
            this.lvwSalary.TableModel = this.tableModel1;
            this.lvwSalary.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwSalary.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwSalary.EditingStopped += new XPTable.Events.CellEditEventHandler(this.lvwSalary_EditingStopped);
            this.lvwSalary.Click += new System.EventHandler(this.lvwSalary_Click);
            this.lvwSalary.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwSalary_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartment,
            this.cCardID,
            this.cEmployeeName,
            this.cBasicSalary,
            this.cHarmfulAllowance,
            this.cResponsibleAllowance,
            this.cDangerousAllowance,
            this.cLunchAllowance,
            this.cIntimateAllowance,
            this.cJapaneseAllowance,
            this.clGTGC,
            this.cTotalTimeSheet,
            this.cSumMoney,
            this.cOverTime1,
            this.cOverTime2,
            this.cOverTime3,
            this.cOverTime4,
            this.cOverTimeMoney,
            this.cOtherAddition,
            this.cInsurance,
            this.cPersonalIncomeTax,
            this.cTotalPaidLunch,
            this.cOtherDeduction,
            this.cSalaryBLD,
            this.cRealSalary});
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
            this.cBasicSalary.Text = "Lương CB";
            this.cBasicSalary.Width = 70;
            // 
            // cHarmfulAllowance
            // 
            this.cHarmfulAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cHarmfulAllowance.Editable = false;
            this.cHarmfulAllowance.Format = "#,##0;(#,##0);0";
            this.cHarmfulAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cHarmfulAllowance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cHarmfulAllowance.Text = "Chức vụ";
            // 
            // cResponsibleAllowance
            // 
            this.cResponsibleAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cResponsibleAllowance.Editable = false;
            this.cResponsibleAllowance.Format = "#,##0;(#,##0);0";
            this.cResponsibleAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cResponsibleAllowance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cResponsibleAllowance.Text = "Nghề nghiệp";
            // 
            // cDangerousAllowance
            // 
            this.cDangerousAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cDangerousAllowance.Editable = false;
            this.cDangerousAllowance.Format = "#,##0;(#,##0);0";
            this.cDangerousAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cDangerousAllowance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cDangerousAllowance.Text = "Công việc";
            // 
            // cLunchAllowance
            // 
            this.cLunchAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cLunchAllowance.Editable = false;
            this.cLunchAllowance.Format = "#,##0;(#,##0);-";
            this.cLunchAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cLunchAllowance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cLunchAllowance.Text = "Ăn trưa";
            // 
            // cIntimateAllowance
            // 
            this.cIntimateAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cIntimateAllowance.Format = "#,##0;(#,##0);0";
            this.cIntimateAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cIntimateAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cIntimateAllowance.Text = "Đi lại";
            // 
            // cJapaneseAllowance
            // 
            this.cJapaneseAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cJapaneseAllowance.Editable = false;
            this.cJapaneseAllowance.Format = "#,##0;(#,##0);0";
            this.cJapaneseAllowance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cJapaneseAllowance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cJapaneseAllowance.Text = "PC Tiếng nhật";
            this.cJapaneseAllowance.Width = 90;
            // 
            // clGTGC
            // 
            this.clGTGC.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.clGTGC.Editable = false;
            this.clGTGC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clGTGC.Text = "GTGC";
            this.clGTGC.Width = 50;
            // 
            // cTotalTimeSheet
            // 
            this.cTotalTimeSheet.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cTotalTimeSheet.Text = "Số công";
            // 
            // cSumMoney
            // 
            this.cSumMoney.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cSumMoney.Format = "#,##0;(#,##0);0";
            this.cSumMoney.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cSumMoney.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cSumMoney.Text = "Số tiền đồng";
            // 
            // cOverTime1
            // 
            this.cOverTime1.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOverTime1.Editable = false;
            this.cOverTime1.Text = "LTHS1";
            this.cOverTime1.Width = 45;
            // 
            // cOverTime2
            // 
            this.cOverTime2.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOverTime2.Editable = false;
            this.cOverTime2.Text = "HS1.5";
            this.cOverTime2.Width = 45;
            // 
            // cOverTime3
            // 
            this.cOverTime3.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOverTime3.Editable = false;
            this.cOverTime3.Text = "HS2";
            this.cOverTime3.Width = 45;
            // 
            // cOverTime4
            // 
            this.cOverTime4.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOverTime4.Editable = false;
            this.cOverTime4.Text = "HS3";
            this.cOverTime4.Width = 45;
            // 
            // cOverTimeMoney
            // 
            this.cOverTimeMoney.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOverTimeMoney.Format = "#,##0;(#,##0);0";
            this.cOverTimeMoney.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cOverTimeMoney.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cOverTimeMoney.Text = "Cộng LT";
            this.cOverTimeMoney.Width = 60;
            // 
            // cOtherAddition
            // 
            this.cOtherAddition.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOtherAddition.Format = "#,##0;(#,##0);-";
            this.cOtherAddition.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cOtherAddition.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cOtherAddition.Text = "Cộng khác";
            this.cOtherAddition.Width = 65;
            // 
            // cInsurance
            // 
            this.cInsurance.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cInsurance.Format = "#,##0;(#,##0);-";
            this.cInsurance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cInsurance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cInsurance.Text = "Bảo hiểm";
            this.cInsurance.Width = 60;
            // 
            // cPersonalIncomeTax
            // 
            this.cPersonalIncomeTax.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cPersonalIncomeTax.Format = "#,##0;(#,##0);-";
            this.cPersonalIncomeTax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cPersonalIncomeTax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cPersonalIncomeTax.Text = "Thuế TN";
            this.cPersonalIncomeTax.Width = 60;
            // 
            // cTotalPaidLunch
            // 
            this.cTotalPaidLunch.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cTotalPaidLunch.Format = "#,##0;(#,##0);-";
            this.cTotalPaidLunch.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cTotalPaidLunch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cTotalPaidLunch.Text = "K.trừ AT";
            this.cTotalPaidLunch.Width = 60;
            // 
            // cOtherDeduction
            // 
            this.cOtherDeduction.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cOtherDeduction.Format = "#,##0;(#,##0);-";
            this.cOtherDeduction.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cOtherDeduction.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cOtherDeduction.Text = "K.trừ khác";
            this.cOtherDeduction.Width = 62;
            // 
            // cSalaryBLD
            // 
            this.cSalaryBLD.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cSalaryBLD.Format = "#,##0;(#,##0);0";
            this.cSalaryBLD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cSalaryBLD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cSalaryBLD.Text = "Chưa KTrừ";
            this.cSalaryBLD.Width = 70;
            // 
            // cRealSalary
            // 
            this.cRealSalary.Alignment = XPTable.Models.ColumnAlignment.Right;
            this.cRealSalary.Format = "#,##0;(#,##0);0";
            this.cRealSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cRealSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cRealSalary.Text = "Thực lĩnh";
            this.cRealSalary.Width = 70;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmployee.Location = new System.Drawing.Point(676, 388);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(80, 16);
            this.lblTotalEmployee.TabIndex = 12;
            this.lblTotalEmployee.Text = "Tổng NV: 335";
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(128, 380);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(8, 380);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(692, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerate.Location = new System.Drawing.Point(8, 484);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 23);
            this.btnGenerate.TabIndex = 39;
            this.btnGenerate.Text = "&Sinh bảng lương";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(436, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(516, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmListSalary
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(772, 514);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.grbMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListSalary";
            this.Text = "Thống kê lương nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListSalary_Load);
            this.grbDepartment.ResumeLayout(false);
            this.grbMonth.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwSalary)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        /// <summary>
        /// 
        /// </summary>
        private SalaryDO salaryDO = null;
        /// <summary>
        /// 
        /// </summary>
        private DataSet dsSalary = null;
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
        TimeSheetDO TsDo = new TimeSheetDO();
        private int t;
        /// <summary>
        /// 
        /// </summary>
        private int selectedRowIndex = -1;

        private const float WORKING_DAY_IN_MONTH = 24;
        #endregion

        /// <summary>
        /// 
        /// </summary>
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
            this.Text = WorkingContext.LangManager.GetString("frmListSalary_Text");
            this.cRealSalary.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_ThucLinh");
            this.grbMonth.Text = WorkingContext.LangManager.GetString("frmListSalary_grpMonth");
            this.label1.Text = WorkingContext.LangManager.GetString("frmListSalary_grpMonth_lable1");
            this.label2.Text = WorkingContext.LangManager.GetString("frmListSalary_grpMonth_lable2");
            this.grbDepartment.Text = WorkingContext.LangManager.GetString("frmListSalary_grpDepartment");
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListSalary_groupbox1");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_STT");
            this.cDepartment.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_BoPhan");
            this.cCardID.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_MaThe");
            this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_HoTen");
            this.cBasicSalary.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_LCB");
            this.cLunchAllowance.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_PCAT");
            this.cResponsibleAllowance.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_PCTN");
            this.cHarmfulAllowance.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_PCDH");
            this.cTotalTimeSheet.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_SoCong");
            this.cTotalPaidLunch.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_KTAT");
            this.txtSearch.Text = WorkingContext.LangManager.GetString("frmListSalary_txtSearch");
            this.btnSearch.Text = WorkingContext.LangManager.GetString("frmListSalary_btnSearch");
            this.btnExportExcel.Text = WorkingContext.LangManager.GetString("frmListSalary_btnXuatExcel");
            this.btnGenerate.Text = WorkingContext.LangManager.GetString("frmListSalary_btnSinhbangLuong");
            this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmListSalary_btnCapNhat");
            this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListSalary_btnXoa");
            this.btnRefresh.Text = WorkingContext.LangManager.GetString("frmListSalary_btnNapLai");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmListSalary_btnDong");
            this.cSumMoney.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_STD");
            this.cOverTime1.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_LTHS1");
            this.cOverTime2.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_HS1.5");
            this.cOverTime3.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_HS2");
            this.cOverTime4.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_HS3");
            this.cOverTimeMoney.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_ConglamThem");
            this.cOtherAddition.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_CongKhac");
            this.cInsurance.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_BH");
            this.cPersonalIncomeTax.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_Thue");
            this.cOtherDeduction.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_KhauTruKhac");
            this.cSalaryBLD.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_CKT");
            this.cRealSalary.Text = WorkingContext.LangManager.GetString("frmListSalary_lvwSalary_ThucLinh");
            this.lblTotalEmployee.Text = WorkingContext.LangManager.GetString("frmListSalary_lblTongSoNV") + " " + t;
            this.lvwSalary.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
        }

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
        /// Hiển thị dữ liệu bảng lương tháng
        /// </summary>
        private void LoadSalaryData()
        {
            // Get DataSet
            try
            {
                dsSalary = salaryDO.GetDepartmentSalary(CurrentMonth, CurrentYear, DepartmentID);
            }
            catch { }
            if (dsSalary != null)
                dataRows = dsSalary.Tables[0].Select(dataFilter, dataSort);
            // Load Salary data to table
            lvwSalary.BeginUpdate();
            lvwSalary.TableModel.Rows.Clear();

            int STT = 0;
            double sumBasicSalary = 0;
            //			double sumPCAT = 0;
            //			double sumPCTN = 0;
            //			double sumPCDH = 0;
            double sumLT = 0;
            double sumBH = 0;
            double sumKTK = 0;
            double sumLCBBH = 0;
            double sumTL = 0;

            foreach (DataRow dr in dataRows)
            {
                bool checkTimeSheet = false;
                bool checkOverTime = false;
                string CardID = dr["CardID"].ToString();
                string EmployeeName = dr["EmployeeName"].ToString();
                string DepartmentName = dr["DepartmentName"].ToString();
                int EmployeeID = Convert.ToInt16(dr["EmployeeID"]);
                DataSet dsTimeSheet = TsDo.GetTimeSetChange(CurrentYear, CurrentMonth, EmployeeID, 0);
                DataSet dsOverTimeSheet = TsDo.GetTimeSetChange(CurrentYear, CurrentMonth, EmployeeID, 1);
                if (dsTimeSheet != null)
                {
                    if (dsTimeSheet.Tables.Count > 0)
                    {
                        if (dsTimeSheet.Tables[0].Rows.Count > 0)
                            checkTimeSheet = true;

                    }
                }
                if (dsOverTimeSheet != null)
                {
                    if (dsOverTimeSheet.Tables.Count > 0)
                    {
                        if (dsOverTimeSheet.Tables[0].Rows.Count > 0)
                            checkOverTime = true;

                    }
                }
                double BasicSalary = double.Parse(dr["BasicSalary"].ToString());
                sumBasicSalary = sumBasicSalary + BasicSalary;
                double LunchAllowance = 0;
                if (dr["LunchAllowance"] != DBNull.Value)
                {
                    LunchAllowance = double.Parse(dr["LunchAllowance"].ToString());
                    //sumPCAT = sumPCAT + LunchAllowance;
                }
                double DangerousAllowance = 0;
                if (dr["DangerousAllowance"] != DBNull.Value)
                {
                    DangerousAllowance = double.Parse(dr["DangerousAllowance"].ToString());
                    //sumPCCV = sumPCCV + DangerousAllowance;
                }
                double ResponsibleAllowance = 0;
                if (dr["ResponsibleAllowance"] != DBNull.Value)
                {
                    ResponsibleAllowance = double.Parse(dr["ResponsibleAllowance"].ToString());
                    //sumPCTN = sumPCTN + ResponsibleAllowance;
                }
                double HarmfulAllowance = 0;
                if (dr["HarmfulAllowance"] != DBNull.Value)
                {
                    HarmfulAllowance = double.Parse(dr["HarmfulAllowance"].ToString());
                    //sumPCDH = sumPCDH + HarmfulAllowance;
                }
                double IntimateAllowance = 0;
                if (dr["IntimateAllowance"] != DBNull.Value)
                {
                    IntimateAllowance = double.Parse(dr["IntimateAllowance"].ToString());
                    //sumPCDH = sumPCDH + HarmfulAllowance;
                }
                double JapaneseAllowance = 0;
                if (dr["JapaneseAllowance"] != DBNull.Value)
                {
                    JapaneseAllowance = double.Parse(dr["JapaneseAllowance"].ToString());
                    //sumPCDH = sumPCDH + HarmfulAllowance;
                }
                int GTGC = 0;
                if (dr["FamilyConditionNumber"] != DBNull.Value)
                {
                    GTGC = int.Parse(dr["FamilyConditionNumber"].ToString());
                    //sumPCDH = sumPCDH + HarmfulAllowance;
                }
                float TotalTimeSheet = 0;
                if (dr["TotalTimeSheet"] != DBNull.Value)
                {
                    TotalTimeSheet = float.Parse(dr["TotalTimeSheet"].ToString());
                }
                double SumMoney = 0;
                if (dr["SumMoney"] != DBNull.Value)
                {
                    SumMoney = double.Parse(dr["SumMoney"].ToString());
                }
                string OverTime1 = dr["OverTime1"].ToString();
                string OverTime2 = dr["OverTime2"].ToString();
                string OverTime3 = dr["OverTime3"].ToString();
                string OverTime4 = dr["OverTime4"].ToString();
                double OverTimeMoney = 0;
                if (dr["OverTimeMoney"] != DBNull.Value)
                {
                    OverTimeMoney = double.Parse(dr["OverTimeMoney"].ToString());
                    sumLT = sumLT + OverTimeMoney;
                }
                double OtherAddition = 0;
                if (dr["OtherAddition"] != DBNull.Value)
                {
                    OtherAddition = double.Parse(dr["OtherAddition"].ToString());
                }
                double Insurance = 0;
                if (dr["Insurance"] != DBNull.Value)
                {
                    Insurance = double.Parse(dr["Insurance"].ToString());
                    sumBH = sumBH + Insurance;
                    if (double.Parse(dr["Insurance"].ToString()) != 0)
                        sumLCBBH = sumLCBBH + BasicSalary;
                }

                double PersonalIncomeTax = 0;
                if (dr["PersonalIncomeTax"] != DBNull.Value)
                {
                    PersonalIncomeTax = double.Parse(dr["PersonalIncomeTax"].ToString());
                }
                double TotalPaidLunch = 0;
                if (dr["TotalPaidLunch"] != DBNull.Value)
                {
                    TotalPaidLunch = double.Parse(dr["TotalPaidLunch"].ToString());
                    //sumKTAT = sumKTAT + TotalPaidLunch;
                }
                double OtherDeduction = 0;
                if (dr["OtherDeduction"] != DBNull.Value)
                {
                    OtherDeduction = double.Parse(dr["OtherDeduction"].ToString());
                    sumKTK = sumKTK + OtherDeduction;
                }
                double SalaryBLD = 0;
                if (dr["SalaryBLD"] != DBNull.Value)
                {
                    SalaryBLD = double.Parse(dr["SalaryBLD"].ToString());
                    //sumCKT = sumCKT + SalaryBLD;
                }
                double RealSalary = 0;
                if (dr["RealSalary"] != DBNull.Value)
                {
                    RealSalary = double.Parse(dr["RealSalary"].ToString());
                    sumTL = sumTL + RealSalary;
                }

                Row row = new Row(new Cell[] { new Cell(STT + 1), new Cell(DepartmentName), new Cell(CardID), new Cell(EmployeeName), new Cell(BasicSalary), new Cell(HarmfulAllowance), new Cell(ResponsibleAllowance), new Cell(DangerousAllowance), new Cell(LunchAllowance) , new Cell(IntimateAllowance), new Cell(JapaneseAllowance), new Cell(GTGC), new Cell(TotalTimeSheet), new Cell(SumMoney), new Cell(OverTime1), new Cell(OverTime2), new Cell(OverTime3), new Cell(OverTime4), new Cell(OverTimeMoney), new Cell(OtherAddition), new Cell(Insurance), new Cell(PersonalIncomeTax), new Cell(TotalPaidLunch), new Cell(OtherDeduction), new Cell(SalaryBLD), new Cell(RealSalary) });
                if (checkTimeSheet)
                    row.Cells[8].BackColor = System.Drawing.Color.Aqua;
                if (checkOverTime)
                    row.Cells[14].BackColor = System.Drawing.Color.Aqua;
                row.Tag = STT;
                lvwSalary.TableModel.Rows.Add(row);
                STT++;
            }
            lvwSalary.EndUpdate();
            string str = WorkingContext.LangManager.GetString("frmListSalary_lblTongSoNV");
            lblTotalEmployee.Text = str + "  " + dataRows.Length;
            t = dataRows.Length;
            lbSumLCB.Text = "TLCB: " + (int)(sumBasicSalary / 1000) * 1000;
            lbSumLCBBH.Text = "TLCB(BH): " + (int)(sumLCBBH / 1000) * 1000;
            lbSumBHXH.Text = "TBH: " + (int)(sumBH / 1000) * 1000;
            lbSumKTK.Text = "TKTK: " + (int)(sumKTK / 1000) * 1000;
            lbSumLT.Text = "TLT:" + (int)(sumLT / 1000) * 1000;
            lbSumBH.Text = "TBH:" + (int)(sumBH / 1000) * 1000;
            //lbSumCKT.Text = "TCKT:" + sumCKT;
            //lbSumKTAT.Text = "TKTAT:" + sumKTAT;
            lbSumTL.Text = "TTL:" + (int)(sumTL / 1000) * 1000;

        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmListSalary_Load(object sender, System.EventArgs e)
        {
            Refresh();
            salaryDO = new SalaryDO();
            CurrentMonth = DateTime.Now.Month;
            CurrentYear = DateTime.Now.Year;
            cboMonth.SelectedText = CurrentMonth.ToString();
            cboYear.SelectedText = CurrentYear.ToString();
            PopulateDepartmentCombo();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DepartmentID = int.Parse(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1);
            LoadSalaryData();
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            // Bộ phận đã có bảng chấm công hay chưa
            TimeSheetDO timeSheetDO = new TimeSheetDO();
            DataSet dsTimeSheet = timeSheetDO.GetDepartmentTimeSheet(CurrentMonth, CurrentYear, DepartmentID);
            if (dsTimeSheet.Tables[0].Rows.Count == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao");
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao_title");
                //MessageBox.Show("Bộ phận này chưa có dữ liệu chấm công tháng. Bạn phải sinh bảng chấm công tháng trước khi sinh bảng lương.", "Sinh bảng lương tháng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Bộ phận đã có dữ liệu lương hay chưa
            if (dsSalary.Tables[0].Rows.Count > 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao1");
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao_title");
                //Xác nhận muốn sinh lại bảng lương tháng
                if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            GenerateSalary();
            LoadSalaryData();
        }
        private void GenerateSalary()
        {
            frmStatusMessage message = new frmStatusMessage();
            string str = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao3");
            //message.Show("Đang sinh dữ liệu bảng lương...");
            message.Show(str);
            this.Cursor = Cursors.WaitCursor;
            employeeDO = new EmployeeDO();
            DataSet dsEmployee = employeeDO.GetEmployeeByDepartment(DepartmentID);
            int totalEmployees = dsEmployee.Tables[0].Rows.Count;
            float percentToComplete = 0;
            int percentProcessing = 0;
            message.ProgressBar.Value = 0;

            DataSet dsGetAutoGenerateLunchSheet = salaryDO.GetAutoGenerateLunchSheet();
            string checkStatus = dsGetAutoGenerateLunchSheet.Tables[0].Rows[0][0].ToString();
            string ProcedureName = null;
            bool bSalaryHP = true;
            if (dsGetAutoGenerateLunchSheet != null)
                if (string.Compare(checkStatus, "true") == 0 || string.Compare(checkStatus, "True") == 0 || string.Compare(checkStatus, "TRUE") == 0)
                {
                    bSalaryHP = false;
                    ProcedureName = "GenerateSalary_New";
                }
                //else ProcedureName = "GenerateSalary_HP_New";

            if (dsEmployee.Tables[0].Rows.Count > 0)
            {                              
                int ret = 0;
                if (bSalaryHP)
                {
                    //Lấy về số ngày làm việc trong tháng  
                    float fWorkingDayInMonth = 0;
                    fWorkingDayInMonth = salaryDO.GetWorkingDayInMonth(CurrentMonth, CurrentYear);
                    if (fWorkingDayInMonth == 0)
                        fWorkingDayInMonth = WORKING_DAY_IN_MONTH;

                    foreach (DataRow dr in dsEmployee.Tables[0].Rows)
                    {
                        int EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                        percentProcessing = ++percentProcessing;
                        try
                        {
                            ret = ret + salaryDO.GenerateSalary_HP(CurrentMonth, CurrentYear, EmployeeID, fWorkingDayInMonth);
                            percentToComplete = ((float)(percentProcessing) / (float)(totalEmployees)) * 100;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        message.ProgressBar.Value = (int)percentToComplete;
                    }
                }
                else
                {
                    foreach (DataRow dr in dsEmployee.Tables[0].Rows)
                    {
                        int EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                        percentProcessing = ++percentProcessing;
                        try
                        {
                            ret = ret + salaryDO.GenerateSalary(CurrentMonth, CurrentYear, EmployeeID, ProcedureName);
                            percentToComplete = ((float)(percentProcessing) / (float)(totalEmployees)) * 100;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        message.ProgressBar.Value = (int)percentToComplete;
                    }
                }

                message.Close();
                this.Cursor = Cursors.Default;
                if (ret > 0)
                {
                    string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao4");
                    string str2 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao_title");
                    //MessageBox.Show("Sinh bảng lương thành công", "Sinh bảng lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao5");
                    string str2 = WorkingContext.LangManager.GetString("frmListSalary_btnSinh_THongBao_title");
                    //MessageBox.Show("Sinh bảng lương thất bại", "Sinh bảng lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                message.Close();
                this.Cursor = Cursors.Default;
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentMonth = int.Parse(cboMonth.Text);
            LoadSalaryData();
        }

        private void cboYear_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentYear = int.Parse(cboYear.Text);
            LoadSalaryData();
        }

        private void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            frmStatusMessage message = new frmStatusMessage();
            string str = WorkingContext.LangManager.GetString("frmListSalary_btnXuatE_ThongBao");
            //message.Show("Xuất dữ liệu bảng lương ra file excel...");
            message.Show(str);
            this.Cursor = Cursors.WaitCursor;
            if (!Utils.ExportExcel(lvwSalary, this.Text.ToUpper()))
            {
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnXuatE_ThongBao1");
                string str2 = WorkingContext.LangManager.GetString("frmListSalary_btnXuatExcel");
                //MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            message.Close();
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// Cập nhật bảng lương
        /// </summary>
        private void UpdateSalary()
        {
            int ret = 0;
            try
            {
                // Điền dữ liệu từ listview vào DataSet
                for (int rowIndex = 0; rowIndex < lvwSalary.RowCount; rowIndex++)
                {
                    int STT = (int)lvwSalary.TableModel.Rows[rowIndex].Tag;
                    DataRow dr = dataRows[STT];
                    dr.BeginEdit();
                    dr["IntimateAllowance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cIntimateAllowance)].Data;
                    dr["DangerousAllowance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cDangerousAllowance)].Data;
                    dr["ResponsibleAllowance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cResponsibleAllowance)].Data;
                    dr["HarmfulAllowance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cHarmfulAllowance)].Data;
                    dr["SumMoney"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cSumMoney)].Data;
                    dr["OverTimeMoney"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cOverTimeMoney)].Data;
                    dr["OtherAddition"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cOtherAddition)].Data;
                    dr["Insurance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cInsurance)].Data;
                    dr["PersonalIncomeTax"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cPersonalIncomeTax)].Data;
                    dr["TotalPaidLunch"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cTotalPaidLunch)].Data;
                    dr["OtherDeduction"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cOtherDeduction)].Data;
                    dr["SalaryBLD"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cSalaryBLD)].Data;
                    dr["RealSalary"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cRealSalary)].Data;
                    dr["LunchAllowance"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cLunchAllowance)].Data;
                    dr["TotalTimeSheet"] = lvwSalary.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cTotalTimeSheet)].Data;
                    dr.EndEdit();

                }
                // Cập nhật
                ret = salaryDO.UpdateSalary(dsSalary);
            }
            catch
            {

            }
            if (ret != 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListSalary_btnCapNhat_ThongBao");
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnCapNhat_ThongBao_Title");
                //MessageBox.Show("Cập nhật bảng lương nhân viên thành công!", "Cập nhật bảng lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsSalary.AcceptChanges();
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmListSalary_btnCapNhat_ThongBao1");
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnCapNhat_ThongBao_Title");
                //MessageBox.Show("Cập nhật bảng lương nhân viên thất bại!", "Cập nhật bảng lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsSalary.RejectChanges();
            }
        }
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (dsSalary.Tables[0].Rows.Count > 0)
            {
                UpdateSalary();
                LoadSalaryData();
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
            dataSort = "DepartmentName, CardID ASC";
            LoadSalaryData();
        }

        private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
                dataSort = "DepartmentName, CardID ASC";
                LoadSalaryData();
            }
        }

        private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtSearch.SelectAll();
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
            else
            {
                return 0;
            }
        }
        private void lvwSalary_EditingStopped(object sender, XPTable.Events.CellEditEventArgs e)
        {
            e.Handled = true;
             
            double oldValue = GetCellValue(e.Cell.Data.ToString());
            double newValue = GetCellValue(((NumberCellEditor)e.Editor).TextBox.Text);
            /* Nếu thay đổi cột số công thì chỉ cập nhật chính cột đó*/
            if (e.Column == columnModel1.Columns.IndexOf(cTotalTimeSheet))
            {                
                lvwSalary.TableModel.Rows[e.Row].Cells[e.Column].Data = newValue;
            }
            else
            {
                double SalaryBLD = (double)lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cSalaryBLD)].Data;
                double RealSalary = (double)lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRealSalary)].Data;
                double SumMoney = (double)lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cSumMoney)].Data;
                
                /* Nếu thay đổi các cột phụ cấp thì cập nhật số tiền SumMoney, SalaryBLD, RealSalary */
                if (e.Column <= columnModel1.Columns.IndexOf(cJapaneseAllowance))
                {
                    SumMoney = SumMoney - oldValue + newValue;
                    SalaryBLD = SalaryBLD - oldValue + newValue;
                    RealSalary = RealSalary - oldValue + newValue;
                }
                /* Nếu thay đổi ở các cột từ SumMoney đến cột cOtherAddition thì cập nhật số tiền SalaryBLD và RealSalary */
                else if (e.Column >= columnModel1.Columns.IndexOf(cSumMoney) &&
                    e.Column <= columnModel1.Columns.IndexOf(cOtherAddition))
                {
                    SalaryBLD = SalaryBLD - oldValue + newValue;
                    RealSalary = RealSalary - oldValue + newValue;
                }
                /* Nếu thay đổi cột khấu trừ ăn trưa TotalPaidLunch thì cập nhật số tiền thực lĩnh RealSalary*/
                else if (e.Column == columnModel1.Columns.IndexOf(cTotalPaidLunch))
                {
                    RealSalary = RealSalary + oldValue - newValue;
                }
                /* Nếu thay đổi 1 trong các cột OtherDeduction, Insurance, PersonalIncomeTax thì cập nhật số tiền SalaryBLD và RealSalary */
                else if (e.Column == columnModel1.Columns.IndexOf(cOtherDeduction) ||
                         e.Column == columnModel1.Columns.IndexOf(cInsurance) ||
                         e.Column == columnModel1.Columns.IndexOf(cPersonalIncomeTax))
                {
                    SalaryBLD = SalaryBLD + oldValue - newValue;
                    RealSalary = RealSalary + oldValue - newValue;
                }
                /* Nếu thay đổi cột Lương chưa khấu trừ SalaryBLD thì cập nhật số tiền SalaryBLD và RealSalary*/
                else if (e.Column == columnModel1.Columns.IndexOf(cSalaryBLD))
                {
                    SalaryBLD = newValue;
                    RealSalary = RealSalary - oldValue + newValue;
                }
                /* Nếu thay đổi cột lương thực lĩnh RealSalary thì cập nhật chính nó*/
                else
                {
                    RealSalary = newValue;
                }
                /* Nếu cột thay đổi không phải là SumMoney thì cập nhật cho cột này với giá trị được tính toán*/
                if (e.Column != columnModel1.Columns.IndexOf(cSumMoney))
                {
                    lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cSumMoney)].Data = SumMoney;
                }
                lvwSalary.TableModel.Rows[e.Row].Cells[e.Column].Data = newValue;
                lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cSalaryBLD)].Data = SalaryBLD;
                lvwSalary.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRealSalary)].Data = RealSalary;
            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            LoadSalaryData();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListSalary_btnXoa_ThongBao");
                string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnXoa_ThongBao_Title");
                //MessageBox.Show("Bạn chưa chọn nhân viên nào trong danh sách?", "Xóa nhân viên khỏi bảng lương", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string str2 = WorkingContext.LangManager.GetString("frmListSalary_btnXoa_ThongBao1");
            string str3 = WorkingContext.LangManager.GetString("frmListSalary_btnXoa_ThongBao_Title");
            // bạn có thật sự muốn xóa nhân viên khỏi bảng lương?
            if (MessageBox.Show(str2, str3, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                //				dsSalary.Tables[0].Rows[selectedRowIndex].Delete();
                dsSalary.Tables[0].Select(dataFilter, dataSort)[selectedRowIndex].Delete();
                salaryDO.DeleteEmployeeSalary(dsSalary);
                dsSalary.AcceptChanges();
                LoadSalaryData();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }

        private void lvwSalary_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                selectedRowIndex = (int)lvwSalary.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void lvwSalary_Click(object sender, System.EventArgs e)
        {

        }

    }
}
