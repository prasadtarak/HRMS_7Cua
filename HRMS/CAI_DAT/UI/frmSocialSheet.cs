using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.UI.Report;
using XPTable.Editors;
using XPTable.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmSocialSheet.
	/// </summary>
	public class frmSocialSheet : System.Windows.Forms.Form
	{
		Database crDatabase;
		Tables crTables;
		TableLogOnInfo crTableLogOnInfo;
		ConnectionInfo crConnectioninfo;
		/// <summary>
		/// 
		/// </summary>
//		private DepartmentDO departmentDO = null;
		DataSet dsSocialInsurance = null;
		SocialInsuranceDO socialInsuranceD0 = null;
		private int selectedRowIndex = -1;
		private int periodID = 0;

		private string dataFilter = "";
		private string dataSort = "";
		private DataRow[] dataRows = null;
		public DateTimePicker DtpFromDate
		{
			get { return dtpFromDate; }
			set { dtpFromDate = value; }
		}

		public DateTimePicker DtpToDate
		{
			get { return dtpToDate; }
			set { dtpToDate = value; }
		}

		public int SelectedRowIndex
		{
			get { return selectedRowIndex; }
			set { selectedRowIndex = value; }
		}

		public DataSet DsSocialInsurance
		{
			get { return dsSocialInsurance; }
			set { dsSocialInsurance = value; }
		}

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnGennerateSocial;
		private System.Windows.Forms.GroupBox groupBox1;
		private XPTable.Models.Table lvwSocialInsuranceSheet;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn cSTT;
		private XPTable.Models.TextColumn cDepartment;
		private XPTable.Models.TextColumn cCardID;
		private XPTable.Models.TextColumn cEmployeeName;
		private XPTable.Models.TextColumn cSocialNumber;
		private XPTable.Models.NumberColumn cBasicSalary;
		private System.Windows.Forms.Button btnDelete;
		private XPTable.Models.NumberColumn cRestDayInTerm;
		private XPTable.Models.NumberColumn cRestDayInYear;
		private XPTable.Models.NumberColumn cMoneyAllowance;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Button btnExportExcel;
		private XPTable.Models.NumberColumn cMoneyAllowanceApproved;
		private XPTable.Models.NumberColumn cRestDayApproved;
		private XPTable.Models.NumberColumn cSocialPeriod;
		private System.Windows.Forms.Button btnToReport;
		private XPTable.Models.TextColumn cNote;
		/// <summary>a
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSocialSheet()
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnGennerateSocial = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lvwSocialInsuranceSheet = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cSTT = new XPTable.Models.TextColumn();
			this.cDepartment = new XPTable.Models.TextColumn();
			this.cCardID = new XPTable.Models.TextColumn();
			this.cEmployeeName = new XPTable.Models.TextColumn();
			this.cSocialNumber = new XPTable.Models.TextColumn();
			this.cBasicSalary = new XPTable.Models.NumberColumn();
			this.cSocialPeriod = new XPTable.Models.NumberColumn();
			this.cRestDayInTerm = new XPTable.Models.NumberColumn();
			this.cRestDayInYear = new XPTable.Models.NumberColumn();
			this.cMoneyAllowance = new XPTable.Models.NumberColumn();
			this.cRestDayApproved = new XPTable.Models.NumberColumn();
			this.cMoneyAllowanceApproved = new XPTable.Models.NumberColumn();
			this.cNote = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnToReport = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwSocialInsuranceSheet)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(724, 536);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEdit.Location = new System.Drawing.Point(344, 536);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Cập nhật";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnGennerateSocial
			// 
			this.btnGennerateSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGennerateSocial.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnGennerateSocial.Location = new System.Drawing.Point(8, 536);
			this.btnGennerateSocial.Name = "btnGennerateSocial";
			this.btnGennerateSocial.Size = new System.Drawing.Size(208, 23);
			this.btnGennerateSocial.TabIndex = 2;
			this.btnGennerateSocial.Text = "Sinh bảng BHYT- BHXH";
			this.btnGennerateSocial.Click += new System.EventHandler(this.btnGennerateSocial_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Controls.Add(this.lvwSocialInsuranceSheet);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(788, 472);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách lao động";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSearch.Location = new System.Drawing.Point(136, 440);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(72, 24);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "&Tìm kiếm";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSearch.Location = new System.Drawing.Point(8, 440);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(128, 20);
			this.txtSearch.TabIndex = 13;
			this.txtSearch.Text = "Nhập chuỗi tìm kiếm";
			this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// lvwSocialInsuranceSheet
			// 
			this.lvwSocialInsuranceSheet.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwSocialInsuranceSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwSocialInsuranceSheet.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwSocialInsuranceSheet.ColumnModel = this.columnModel1;
			this.lvwSocialInsuranceSheet.EditStartAction = XPTable.Editors.EditStartAction.SingleClick;
			this.lvwSocialInsuranceSheet.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwSocialInsuranceSheet.FullRowSelect = true;
			this.lvwSocialInsuranceSheet.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwSocialInsuranceSheet.GridLines = XPTable.Models.GridLines.Both;
			this.lvwSocialInsuranceSheet.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwSocialInsuranceSheet.Location = new System.Drawing.Point(8, 16);
			this.lvwSocialInsuranceSheet.Name = "lvwSocialInsuranceSheet";
			this.lvwSocialInsuranceSheet.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwSocialInsuranceSheet.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwSocialInsuranceSheet.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwSocialInsuranceSheet.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwSocialInsuranceSheet.Size = new System.Drawing.Size(772, 416);
			this.lvwSocialInsuranceSheet.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwSocialInsuranceSheet.TabIndex = 12;
			this.lvwSocialInsuranceSheet.TableModel = this.tableModel1;
			this.lvwSocialInsuranceSheet.Text = "table1";
			this.lvwSocialInsuranceSheet.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwSocialInsuranceSheet.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwSocialInsuranceSheet.EditingStopped += new XPTable.Events.CellEditEventHandler(this.lvwSocialInsuranceSheet_EditingStopped);
			this.lvwSocialInsuranceSheet.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwSocialInsuranceSheet_SelectionChanged);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cSTT,
																			   this.cDepartment,
																			   this.cCardID,
																			   this.cEmployeeName,
																			   this.cSocialNumber,
																			   this.cBasicSalary,
																			   this.cSocialPeriod,
																			   this.cRestDayInTerm,
																			   this.cRestDayInYear,
																			   this.cMoneyAllowance,
																			   this.cRestDayApproved,
																			   this.cMoneyAllowanceApproved,
																			   this.cNote});
			// 
			// cSTT
			// 
			this.cSTT.Alignment = XPTable.Models.ColumnAlignment.Center;
			this.cSTT.Editable = false;
			this.cSTT.Text = "STT";
			this.cSTT.Width = 43;
			// 
			// cDepartment
			// 
			this.cDepartment.Editable = false;
			this.cDepartment.Text = "Bộ phận";
			this.cDepartment.Width = 114;
			// 
			// cCardID
			// 
			this.cCardID.Editable = false;
			this.cCardID.Text = "Mã thẻ";
			this.cCardID.Width = 63;
			// 
			// cEmployeeName
			// 
			this.cEmployeeName.Editable = false;
			this.cEmployeeName.Text = "Tên nhân viên";
			this.cEmployeeName.Width = 126;
			// 
			// cSocialNumber
			// 
			this.cSocialNumber.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cSocialNumber.Editable = false;
			this.cSocialNumber.Text = "Số sổ BHXH";
			// 
			// cBasicSalary
			// 
			this.cBasicSalary.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cBasicSalary.Editable = false;
			this.cBasicSalary.Format = "#,##0;(#,##0);0";
			this.cBasicSalary.Maximum = new System.Decimal(new int[] {
																		 99999999,
																		 0,
																		 0,
																		 0});
			this.cBasicSalary.Text = "Lương cơ bản";
			this.cBasicSalary.Width = 99;
			// 
			// cSocialPeriod
			// 
			this.cSocialPeriod.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cSocialPeriod.Maximum = new System.Decimal(new int[] {
																		  1000,
																		  0,
																		  0,
																		  0});
			this.cSocialPeriod.Text = "Thời gian đóng BHXH";
			// 
			// cRestDayInTerm
			// 
			this.cRestDayInTerm.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cRestDayInTerm.Maximum = new System.Decimal(new int[] {
																		   365,
																		   0,
																		   0,
																		   0});
			this.cRestDayInTerm.Text = "Số ngày nghỉ trong kỳ";
			this.cRestDayInTerm.Width = 115;
			// 
			// cRestDayInYear
			// 
			this.cRestDayInYear.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cRestDayInYear.Maximum = new System.Decimal(new int[] {
																		   365,
																		   0,
																		   0,
																		   0});
			this.cRestDayInYear.Text = "Lũy kế từ đầu năm";
			this.cRestDayInYear.Width = 105;
			// 
			// cMoneyAllowance
			// 
			this.cMoneyAllowance.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cMoneyAllowance.Editable = false;
			this.cMoneyAllowance.Format = "#,##0;(#,##0);0";
			this.cMoneyAllowance.Increment = new System.Decimal(new int[] {
																			  100,
																			  0,
																			  0,
																			  0});
			this.cMoneyAllowance.Maximum = new System.Decimal(new int[] {
																			99999999,
																			0,
																			0,
																			0});
			this.cMoneyAllowance.Text = "Tiền trợ cấp";
			// 
			// cRestDayApproved
			// 
			this.cRestDayApproved.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cRestDayApproved.Maximum = new System.Decimal(new int[] {
																			 1000,
																			 0,
																			 0,
																			 0});
			this.cRestDayApproved.Text = "Số ngày được xét";
			// 
			// cMoneyAllowanceApproved
			// 
			this.cMoneyAllowanceApproved.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cMoneyAllowanceApproved.Editable = false;
			this.cMoneyAllowanceApproved.Format = "#,##0;(#,##0);0";
			this.cMoneyAllowanceApproved.Increment = new System.Decimal(new int[] {
																					  100,
																					  0,
																					  0,
																					  0});
			this.cMoneyAllowanceApproved.Maximum = new System.Decimal(new int[] {
																					100000000,
																					0,
																					0,
																					0});
			this.cMoneyAllowanceApproved.Text = "Số tiền được xét";
			this.cMoneyAllowanceApproved.Width = 94;
			// 
			// cNote
			// 
			this.cNote.Editable = false;
			this.cNote.Text = "Ghi chú";
			this.cNote.Width = 115;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Location = new System.Drawing.Point(432, 536);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExportExcel.Location = new System.Drawing.Point(520, 536);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(112, 23);
			this.btnExportExcel.TabIndex = 5;
			this.btnExportExcel.Text = "Xuất Excel";
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// btnToReport
			// 
			this.btnToReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnToReport.Location = new System.Drawing.Point(644, 536);
			this.btnToReport.Name = "btnToReport";
			this.btnToReport.TabIndex = 6;
			this.btnToReport.Text = "Xuất báo cáo";
			this.btnToReport.Click += new System.EventHandler(this.btnToReport_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtpToDate);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.dtpFromDate);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 48);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thời gian";
			// 
			// dtpToDate
			// 
			this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dtpToDate.CustomFormat = "dd/MM/yyyy";
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDate.Location = new System.Drawing.Point(216, 16);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(88, 20);
			this.dtpToDate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.Location = new System.Drawing.Point(160, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đến ngày";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDate.Location = new System.Drawing.Point(64, 16);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(88, 20);
			this.dtpFromDate.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày";
			// 
			// frmSocialSheet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(804, 566);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnToReport);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGennerateSocial);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnClose);
			this.Name = "frmSocialSheet";
			this.Text = "Quản lý bảo hiểm xã hội";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSocialSheet_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwSocialInsuranceSheet)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void PopulateDepartmentCombo()
		{
//			departmentDO = new DepartmentDO();
//
//			DataSet dsDepartment = new DataSet();
//			dsDepartment = departmentDO.GetAllDepartments();

//			cboDepartment.SourceDataString = new string[] {"DepartmentID", "DepartmentName"};
//			cboDepartment.SourceDataTable = dsDepartment.Tables[0];
//			if (dsDepartment.Tables[0].Rows.Count > 0)
//			{
//				cboDepartment.SelectedIndex = 0;
//			}
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
			this.Text = WorkingContext.LangManager.GetString("frmSocialSheet_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmSocialSheet_groupbox1");
			this.label1.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
			this.label2.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lable2");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmSocialSheet_groupbox2");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_STT");
			this.cDepartment.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_BoPhan");
			this.cCardID.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_MaThe");
			this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_TenNV");
			this.cSocialNumber.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_SoBHXH");
			this.cBasicSalary.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_Luong");
			this.cSocialPeriod.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_TGDBHXH");
			this.cRestDayInTerm.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_SoNN");
			this.cRestDayInYear.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_LuyKe");
			this.cMoneyAllowance.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_TroCap");
			this.cMoneyAllowanceApproved.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_STDX");
			this.cRestDayApproved.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_SNDX");
			this.cNote.Text = WorkingContext.LangManager.GetString("frmSocialSheet_lvw_Note");
			this.btnSearch.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnSearch");
			this.btnGennerateSocial.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnSinh");
			this.btnEdit.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnUp");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnDel");
			this.btnExportExcel.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnExel");
			this.btnToReport.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnReport");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmSocialSheet_btnClose");
			this.txtSearch.Text = WorkingContext.LangManager.GetString("frmRestSheet_txtSearch");
			this.lvwSocialInsuranceSheet.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			
		}
		private void frmSocialSheet_Load(object sender, System.EventArgs e)
		{
			Refresh();
			if(selectedRowIndex >= 0)//Sửa dữ liệu
			{
				DataRow dr = dsSocialInsurance.Tables[0].Rows[selectedRowIndex];
				dtpFromDate.Text = dr["StartPointDate"].ToString();
				DtpToDate.Text = dr["EndPointDate"].ToString();
				periodID = int.Parse(dr["PeriodID"].ToString());
				dtpFromDate.Enabled = false;
				DtpToDate.Enabled = false;
//				btnGennerateSocial.Enabled = false;
			}
			else
			{
				dtpFromDate.Enabled = false;
				
			}

			PopulateDepartmentCombo();
			socialInsuranceD0 = new SocialInsuranceDO();
			PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);
//			this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);

		}

		private void btnGennerateSocial_Click(object sender, System.EventArgs e)
		{
			if(CheckDay(dtpFromDate.Value,DtpToDate.Value))
			{
				string str = WorkingContext.LangManager.GetString("frmSocialSheet_Messa");
				//MessageBox.Show("Ngày chọn không hợp lệ");
				MessageBox.Show(str);
			}
			else
			{
				if (dataRows.Length > 0)
					{
						string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Messa");
						string str2 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
						//if (MessageBox.Show("Dữ liệu bảng Thanh toán BHXH đã tồn tại, bạn có thực sự muốn sinh lại không?", "Sinh bảng thanh toán BHXH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						if (MessageBox.Show(str1, str2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							return;
						}
					}
				GenerateSocialSheet();
				// Get DataSet
				PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);
			}

			//			if (dataRows.Length > 0)
//			{
//				if (MessageBox.Show("Dữ liệu bảng Thanh toán tiền phép của năm này đã tồn tại, bạn có thực sự muốn sinh lại bảng thanh toán tiền phép không?", "Sinh bảng thanh toán tiền phép", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
//				{
//					return;
//				}
//			}
//			GenerateSocialSheet();
//			// Get DataSet
//			PopulateSocialSheet(5);
		}
		/// <summary>
		/// Sinh bảng thanh toán BHXH
		/// </summary>
		private void GenerateSocialSheet()
		{
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Messa1");
			//message.Show("Đang sinh dữ liệu bảng thanh toán BHXH, xin chờ trong giây lát...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			int ret = 0;
			try
			{
				ret = socialInsuranceD0.GenerateSocialInsurance(dtpFromDate.Value,DtpToDate.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			if (ret > 0)
			{
				message.Close();
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Messa2");
				string str2 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				//MessageBox.Show("Sinh bảng thanh toán BHXH thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				message.Close();
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Messa3");
				string str2 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				//MessageBox.Show("Sinh bảng thanh toán BHXH thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			this.Cursor = Cursors.Default;
		}

		/// <summary>
		/// 
		/// </summary>
		private void PopulateSocialSheet(DateTime fromDate,DateTime toDate)
		{
			dsSocialInsurance = socialInsuranceD0.GetSocialInsurance(fromDate,toDate);
			lvwSocialInsuranceSheet.BeginUpdate();
			lvwSocialInsuranceSheet.TableModel.Rows.Clear();
			dataRows = dsSocialInsurance.Tables[0].Select(dataFilter, dataSort);
			int STT = 0;
			foreach (DataRow dr in dataRows)
			{
				string DepartmentName = dr["DepartmentName"].ToString();
				string CardID = dr["CardID"].ToString();
				string EmployeeName = dr["EmployeeName"].ToString();
				//int OverTime = Int32.Parse(dr["OverTime"].ToString());

				string InsuranceID = dr["InsuranceID"].ToString();
				Cell[] SocialSheet = new Cell[13];
				SocialSheet[0] = new Cell((STT+1).ToString());
				SocialSheet[1] = new Cell(DepartmentName);
				SocialSheet[2] = new Cell(CardID);
				SocialSheet[3] = new Cell(EmployeeName);
				SocialSheet[4] = new Cell(InsuranceID);

                double BasicSalary = 0;
				if (dr["BasicSalary"] != DBNull.Value)
				{
					BasicSalary = double.Parse(dr["BasicSalary"].ToString());	
				}
				SocialSheet[5] = new Cell(BasicSalary);
				
				double InsurancePeriod = 0;
				if (dr["InsurancePeriod"] != DBNull.Value)
				{
					InsurancePeriod = double.Parse(dr["InsurancePeriod"].ToString());	
				}
				SocialSheet[6] = new Cell(InsurancePeriod);
				
				double RestDay = 0;
				if (dr["RestDays"] != DBNull.Value)
				{
					RestDay = double.Parse(dr["RestDays"].ToString());	
				}
				SocialSheet[7] = new Cell(RestDay);
				
				double TotalRestInYear = 0;
				if (dr["TotalRestInYear"] != DBNull.Value)
				{
					TotalRestInYear = double.Parse(dr["TotalRestInYear"].ToString());	
				}
				SocialSheet[8] = new Cell(TotalRestInYear);
				
				double MoneyAllowance = 0;
				if (dr["MoneyAllowance"] != DBNull.Value)
				{
					MoneyAllowance = double.Parse(dr["MoneyAllowance"].ToString());	
				}

				SocialSheet[9] = new Cell(MoneyAllowance);


				double RestDaysApproved = 0;
				if (dr["RestDaysApproved"] != DBNull.Value)
				{
					RestDaysApproved = double.Parse(dr["RestDaysApproved"].ToString());	
				}
				SocialSheet[10] = new Cell(RestDaysApproved);
				
				double MoneyAllowanceApproved = 0;
				if (dr["MoneyAllowanceApproved"] != DBNull.Value)
				{
					MoneyAllowanceApproved = double.Parse(dr["MoneyAllowanceApproved"].ToString());	
				}

				SocialSheet[11] = new Cell(MoneyAllowanceApproved);

				 string note = dr["Note"].ToString();
				SocialSheet[12] = new Cell(note);
			
				Row row = new Row(SocialSheet);
				row.Tag = STT;
                lvwSocialInsuranceSheet.TableModel.Rows.Add(row);
				STT++;
	
			}

			lvwSocialInsuranceSheet.EndUpdate();
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmSocialSheet_Excel_Messa");
			//message.Show("Xuất dữ liệu bảng lương ra file excel...");
			message.Show(str);
			//string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Text");
			this.Cursor = Cursors.WaitCursor;
			string stitle = WorkingContext.LangManager.GetString("Bosung_tool9");
			if (!Utils.ExportExcel(lvwSocialInsuranceSheet,stitle.ToUpper()))
			{
				string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnXuatE_ThongBao1");
				string str2 = WorkingContext.LangManager.GetString("frmListSalary_btnXuatExcel");
				//MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			message.Close();
			this.Cursor = Cursors.Default;
		}

		private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtSearch.SelectAll();
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
			dataSort = "DepartmentName, CardID ASC";
			PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);
		}

		private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			if (e.KeyChar == (char) 13)
			{
				dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
				dataSort = "DepartmentName, CardID ASC";
				PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);
			}
		}
		/// <summary>
		/// Kiểm tra điều kiện thời gian có hợp lệ
		/// </summary>
		/// <param name="fromDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		private bool CheckDay(DateTime fromDate, DateTime endDate)
		{
			if(fromDate.CompareTo(endDate) > 0)
			{
				return true;
			}
			else
				return false;
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			if (dsSocialInsurance.Tables[0].Rows.Count > 0)
			{
				UpdateSocialInsurance();
				PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);
			}
		}
		/// <summary>
		/// Cập nhật bảng thanh toán BHXH
		/// </summary>
		private void UpdateSocialInsurance()
		{	
			int ret = 0;
			try
			{
				// Điền dữ liệu từ listview vào DataSet
				for( int rowIndex = 0;rowIndex < lvwSocialInsuranceSheet.RowCount;rowIndex ++)
				{
					int STT = (int)lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Tag;
					DataRow dr = dataRows[STT];
					dr.BeginEdit();
					dr["InsurancePeriod"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cSocialPeriod)].Data;
					dr["RestDays"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cRestDayInTerm)].Data;
					dr["TotalRestInYear"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cRestDayInYear)].Data;
					dr["MoneyAllowance"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cMoneyAllowance)].Data;
					dr["RestDaysApproved"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cRestDayApproved)].Data;
					dr["MoneyAllowanceApproved"] = lvwSocialInsuranceSheet.TableModel.Rows[rowIndex].Cells[columnModel1.Columns.IndexOf(cMoneyAllowanceApproved)].Data;
					dr["PeriodID"] = periodID;
					dr.EndEdit();

				}
				// Cập nhật
				ret = socialInsuranceD0.UpdateSocialInsuranceDO(dsSocialInsurance);
			}
			catch
			{
				
			}
			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmSocialSheet_CapNhat_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				//MessageBox.Show("Cập nhật bảng thanh toán BHXH thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsSocialInsurance.AcceptChanges();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmSocialSheet_CapNhat_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				//MessageBox.Show("Cập nhật bảng thanh toán BHXH thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsSocialInsurance.RejectChanges();
			}
			
		}

		private void lvwSocialInsuranceSheet_EditingStopped(object sender, XPTable.Events.CellEditEventArgs e)
		{
			e.Handled = true;
//			int row = e.Row;
//			double RestDays = GetCellValue(lvwSocialInsuranceSheet.TableModel.Rows[row].Cells[8].Text);

			double BasicSalary = (double)lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cBasicSalary)].Data;
			double RestDays = (double)lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayInTerm)].Data;
//			double RestDayInYear = (double)lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayInYear)].Data;
			double RestDaysApproved = (double)lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayApproved)].Data;

			double oldValue = GetCellValue(e.Cell.Data.ToString());
			double newValue =  GetCellValue(((NumberCellEditor)e.Editor).TextBox.Text);
			if (e.Column == columnModel1.Columns.IndexOf(cRestDayInTerm)) //Khấu trừ ăn trưa
			{
				RestDays = newValue;;
			}
			else if(e.Column == columnModel1.Columns.IndexOf(cRestDayApproved))
			{
				RestDaysApproved = newValue;
			}
//			BasicSalary = BasicSalary - oldValue + newValue;
//			RestDays = RestDays - oldValue+ newValue;
//			RestDayInYear = RestDayInYear - oldValue+ newValue;
//			RestDaysApproved  = RestDaysApproved - oldValue + newValue;
//			double MoneyAllowance = Math.Floor(RestDays*(BasicSalary/25)*0.75);
			double MoneyAllowance = RestDays*(BasicSalary*0.75)/25;
			double MoneyAllowanceApproved =  RestDaysApproved*(BasicSalary*0.75)/25;
			
//			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[e.Column].Data = newValue;
			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayInTerm)].Data = RestDays;
			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayApproved)].Data = RestDaysApproved;
			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cMoneyAllowance)].Data = MoneyAllowance;
			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cMoneyAllowanceApproved)].Data = MoneyAllowanceApproved;


//			lvwSocialInsuranceSheet.TableModel.Rows[e.Row].Cells[columnModel1.Columns.IndexOf(cRestDayApproved)].Data = RestDays;


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

		private void btnToReport_Click(object sender, System.EventArgs e)
		{
//			frmReportPreview frm = new frmReportPreview();
//			frm.crvDetail = 
			ReportDocument rptDocument = new ReportDocument();
			if (this.Text== "Quản lý bảo hiểm xã hội")
			{
				rptDocument = SetReport();
			}
			else 
			{
				rptDocument = SetReport_JP();
			}
			frmReportPreview frm = new frmReportPreview();
			frm.SetReportDocument = rptDocument;
			frm.Show();
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private ReportDocument SetReport()
		{
			ReportDocument rptDoc = new ReportDocument();

			ParameterValues pvFromDate = new ParameterValues();
			ParameterValues pvToDate = new ParameterValues();
			ParameterValues pvUserName = new ParameterValues();
			ParameterDiscreteValue pdvFromDate = new ParameterDiscreteValue();
			ParameterDiscreteValue pdvToDate = new ParameterDiscreteValue();
			ParameterDiscreteValue pdvUserName = new ParameterDiscreteValue();
			pdvUserName.Value = WorkingContext.Username;
			pvUserName.Add(pdvUserName);
			try
			{
				// Load the report
				rptDoc.Load(@"Reports\SocialInsuranceAllowance.rpt");
				// Set the connection information for all the tables used in the report
				// Set the discreet value to the customers name.
				pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
				pdvToDate.Value = dtpToDate.Value.ToShortDateString();
				//								pdvDepartmentID.Value = cboDepartment.SelectedValue;
				// Add it to the parameter collection.
				pvFromDate.Add(pdvFromDate);
				pvToDate.Add(pdvToDate);
//				pvDepartmentID.Add(pdvDepartmentID);
				// Apply the current parameter values.
				rptDoc.DataDefinition.ParameterFields["@FromDate"].ApplyCurrentValues(pvFromDate);
				rptDoc.DataDefinition.ParameterFields["@ToDate"].ApplyCurrentValues(pvToDate);
				rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
//				rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
								
			}
			catch (LoadSaveReportException Exp)
			{
				string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
				//MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
				MessageBox.Show(str, str1);
			}
			catch (Exception Exp)
			{
				string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

				//MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
				MessageBox.Show(Exp.Message,str2);
			}

			//							MessageBox.Show("OK");

			if(rptDoc != null)
			{
				SetDBLogonForReport(rptDoc);	
			}
			return rptDoc;
		}
		private ReportDocument SetReport_JP()
		{
			ReportDocument rptDoc = new ReportDocument();

			ParameterValues pvFromDate = new ParameterValues();
			ParameterValues pvToDate = new ParameterValues();
			ParameterValues pvUserName = new ParameterValues();
			ParameterDiscreteValue pdvFromDate = new ParameterDiscreteValue();
			ParameterDiscreteValue pdvToDate = new ParameterDiscreteValue();
			ParameterDiscreteValue pdvUserName = new ParameterDiscreteValue();
			pdvUserName.Value = WorkingContext.Username;
			pvUserName.Add(pdvUserName);
			try
			{
				// Load the report
				rptDoc.Load(@"Reports_JP\SocialInsuranceAllowance.rpt");
				// Set the connection information for all the tables used in the report
				// Set the discreet value to the customers name.
				pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
				pdvToDate.Value = dtpToDate.Value.ToShortDateString();
				//								pdvDepartmentID.Value = cboDepartment.SelectedValue;
				// Add it to the parameter collection.
				pvFromDate.Add(pdvFromDate);
				pvToDate.Add(pdvToDate);
				//				pvDepartmentID.Add(pdvDepartmentID);
				// Apply the current parameter values.
				rptDoc.DataDefinition.ParameterFields["@FromDate"].ApplyCurrentValues(pvFromDate);
				rptDoc.DataDefinition.ParameterFields["@ToDate"].ApplyCurrentValues(pvToDate);
				rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
				//				rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
								
			}
			catch (LoadSaveReportException Exp)
			{
				string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
				//MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
				MessageBox.Show(str, str1);
			}
			catch (Exception Exp)
			{
				string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

				//MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
				MessageBox.Show(Exp.Message,str2);
			}

			//							MessageBox.Show("OK");

			if(rptDoc != null)
			{
				SetDBLogonForReport(rptDoc);	
			}
			return rptDoc;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="reportDocument"></param>
		private void SetDBLogonForReport(ReportDocument reportDocument)
		{
			crConnectioninfo = new ConnectionInfo();
			crConnectioninfo.ServerName = WorkingContext.Setting.Server;
			crConnectioninfo.DatabaseName = WorkingContext.Setting.Database;
			crConnectioninfo.UserID = WorkingContext.Setting.UserName;
			crConnectioninfo.Password = WorkingContext.Setting.Password;

			crTables = reportDocument.Database.Tables;
			crDatabase = reportDocument.Database;
			crTables = crDatabase.Tables;

			foreach (CrystalDecisions.CrystalReports.Engine.Table crTable in crTables)
			{
				try
				{
					crTableLogOnInfo = crTable.LogOnInfo;
					crTableLogOnInfo.ConnectionInfo = crConnectioninfo;
					crTable.ApplyLogOnInfo(crTableLogOnInfo);
					//					crTable.Location = WorkingContext.Setting.Server + crTable.Name;
					// Note that if you wish to change Database (catalog) name as well as
					// the server, you must set new crTable.Location property as follows:
					// crTable.Location = "<new_database_name>.<owner>." + crTable.Name;
				}
				catch
				{
					string str = WorkingContext.LangManager.GetString("frmListReport_thongbao");
					string str1 = WorkingContext.LangManager.GetString("frmListReport_thongbao_Title");
					//MessageBox.Show("Không thể đăng nhập được vào cơ sở dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
					MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmSocialSheet_Xoa_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				//MessageBox.Show("Bạn chưa chọn nhân viên nào để xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmSocialSheet_Xoa_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_Sinh_Title");
				if (MessageBox.Show(str,str1,MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					dsSocialInsurance.Tables[0].Select(dataFilter, dataSort)[selectedRowIndex].Delete();
					//dsRestSheet.Tables[0].Rows[SelectedItem].Delete();
					socialInsuranceD0.DeleteSocialSheetDO(dsSocialInsurance);
					dsSocialInsurance.AcceptChanges();
					PopulateSocialSheet(dtpFromDate.Value,dtpToDate.Value);

				}
			}
		}

		private void lvwSocialInsuranceSheet_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwSocialInsuranceSheet.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}
	}
}
