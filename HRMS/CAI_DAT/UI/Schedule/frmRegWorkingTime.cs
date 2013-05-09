using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
using Pabo.Calendar;
using XPTable.Models;
using MonthCalendar = Pabo.Calendar.MonthCalendar;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Form đăng ký thời gian làm việc
	/// </summary>
	public class frmRegWorkingTime : Form
	{
		#region Windows Form Design generated code

		private Button btnClose;
		private Button btnUpdate;
		private Button btnHelp;
		private MonthCalendar monthCalendar1;
		private GroupBox groupBox5;
		private DepartmentTreeView departmentTreeView;
		private Button btnCancel;
		private LookupComboBox cboShift;
		private GroupBox groupBox2;
		private RadioButton rbtWorkingDay;
		private RadioButton rbtNonWorkingDay;
		private Label lblShift;
		private GroupBox groupBox4;
		private Label lblWorkingDay;
		private Label lblNonWorkingDay;
		private Label lblNonWorkingDayLegend;
		private Label lblWorkingDayLegend;
		private GroupBox groupBox3;
		private Label label2;
		private RadioButton rbtHoliday;
		private Label lblHolidayLegend;
		private Label lblOverTime;
		private Label lblOverTimeLegend;
		private RadioButton rbtOverTime;
		private System.Windows.Forms.GroupBox groupBox1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TableModel tableModel1;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.Button btnSelectNone;
		private EmployeeDO employeeDO = null;
		private DataSet dsEmployee = null;
		private XPTable.Models.Table lvwListEmployee;
		private XPTable.Models.TextColumn cCardID;
		private XPTable.Models.TextColumn cEmployeeName;
		private XPTable.Models.NumberColumn cSTT;
		private int selectedRowIndex = -1;

		private IContainer components = null;
		private DataRow[] WorkingTimeDataRows = null;
		/// <summary>
		/// 
		/// </summary>
		private string dataFilter = "";
		/// <summary>
		/// 
		/// </summary>
		private string dataSort = "";

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

		public frmRegWorkingTime()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboShift = new System.Windows.Forms.LookupComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtOverTime = new System.Windows.Forms.RadioButton();
            this.rbtHoliday = new System.Windows.Forms.RadioButton();
            this.lblShift = new System.Windows.Forms.Label();
            this.rbtWorkingDay = new System.Windows.Forms.RadioButton();
            this.rbtNonWorkingDay = new System.Windows.Forms.RadioButton();
            this.lblWorkingDay = new System.Windows.Forms.Label();
            this.lblNonWorkingDay = new System.Windows.Forms.Label();
            this.lblNonWorkingDayLegend = new System.Windows.Forms.Label();
            this.lblWorkingDayLegend = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOverTime = new System.Windows.Forms.Label();
            this.lblOverTimeLegend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHolidayLegend = new System.Windows.Forms.Label();
            this.lvwListEmployee = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwListEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(792, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(632, 568);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Location = new System.Drawing.Point(8, 568);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 6;
            this.monthCalendar1.ActiveMonth.RaiseEvent = true;
            this.monthCalendar1.ActiveMonth.Year = 2006;
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(8, 16);
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1995, 11, 9, 19, 19, 39, 781);
            this.monthCalendar1.Month.Colors.Background = System.Drawing.Color.GhostWhite;
            this.monthCalendar1.Month.Colors.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.monthCalendar1.Month.Colors.FocusBorder = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.Month.Colors.FocusDate = System.Drawing.Color.Black;
            this.monthCalendar1.Month.Colors.FocusText = System.Drawing.Color.Black;
            this.monthCalendar1.Month.Colors.SelectedBackground = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.Month.Colors.SelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(185)))));
            this.monthCalendar1.Month.Colors.SelectedDate = System.Drawing.Color.Black;
            this.monthCalendar1.Month.Colors.SelectedText = System.Drawing.Color.Black;
            this.monthCalendar1.Month.Colors.WeekendBackground = System.Drawing.Color.MistyRose;
            this.monthCalendar1.Month.Colors.WeekendDate = System.Drawing.Color.DarkRed;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionMode = Pabo.Calendar.mcSelectionMode.MultiExtended;
            this.monthCalendar1.SelectTrailingDates = false;
            this.monthCalendar1.ShowTrailingDates = false;
            this.monthCalendar1.Size = new System.Drawing.Size(552, 456);
            this.monthCalendar1.TabIndex = 67;
            this.monthCalendar1.WeekDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.WeekDays.TextColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.WeekNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.WeekNumbers.TextColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.monthCalendar1_DaySelected);
            this.monthCalendar1.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar1_MonthChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.monthCalendar1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(296, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 480);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lịch làm việc";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentTreeView);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 240);
            this.groupBox5.TabIndex = 76;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phòng ban";
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
            this.departmentTreeView.Size = new System.Drawing.Size(264, 216);
            this.departmentTreeView.TabIndex = 4;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(712, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboShift
            // 
            this.cboShift.AllowTypeAllSymbols = false;
            this.cboShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShift.DropDownWidth = 200;
            this.cboShift.ItemHeight = 13;
            this.cboShift.Location = new System.Drawing.Point(184, 16);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(152, 21);
            this.cboShift.TabIndex = 0;
            this.cboShift.SelectedIndexChanged += new System.EventHandler(this.cboShift_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbtOverTime);
            this.groupBox2.Controls.Add(this.rbtHoliday);
            this.groupBox2.Controls.Add(this.lblShift);
            this.groupBox2.Controls.Add(this.rbtWorkingDay);
            this.groupBox2.Controls.Add(this.rbtNonWorkingDay);
            this.groupBox2.Controls.Add(this.cboShift);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(296, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 72);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập ngày";
            // 
            // rbtOverTime
            // 
            this.rbtOverTime.Location = new System.Drawing.Point(16, 40);
            this.rbtOverTime.Name = "rbtOverTime";
            this.rbtOverTime.Size = new System.Drawing.Size(112, 24);
            this.rbtOverTime.TabIndex = 76;
            this.rbtOverTime.Text = "Làm thêm (HS1)";
            this.rbtOverTime.CheckedChanged += new System.EventHandler(this.rbtOverTime_CheckedChanged);
            // 
            // rbtHoliday
            // 
            this.rbtHoliday.Location = new System.Drawing.Point(240, 40);
            this.rbtHoliday.Name = "rbtHoliday";
            this.rbtHoliday.Size = new System.Drawing.Size(96, 24);
            this.rbtHoliday.TabIndex = 75;
            this.rbtHoliday.Text = "Ngày lễ (HS3)";
            this.rbtHoliday.CheckedChanged += new System.EventHandler(this.rbtHoliday_CheckedChanged);
            // 
            // lblShift
            // 
            this.lblShift.Location = new System.Drawing.Point(128, 16);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(56, 23);
            this.lblShift.TabIndex = 72;
            this.lblShift.Text = "Chọn ca:";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtWorkingDay
            // 
            this.rbtWorkingDay.Location = new System.Drawing.Point(16, 16);
            this.rbtWorkingDay.Name = "rbtWorkingDay";
            this.rbtWorkingDay.Size = new System.Drawing.Size(112, 24);
            this.rbtWorkingDay.TabIndex = 70;
            this.rbtWorkingDay.Text = "Ngày làm việc";
            this.rbtWorkingDay.CheckedChanged += new System.EventHandler(this.rbtWorkingDay_CheckedChanged);
            // 
            // rbtNonWorkingDay
            // 
            this.rbtNonWorkingDay.Location = new System.Drawing.Point(128, 40);
            this.rbtNonWorkingDay.Name = "rbtNonWorkingDay";
            this.rbtNonWorkingDay.Size = new System.Drawing.Size(112, 24);
            this.rbtNonWorkingDay.TabIndex = 71;
            this.rbtNonWorkingDay.Text = "Ngày nghỉ (HS2)";
            this.rbtNonWorkingDay.CheckedChanged += new System.EventHandler(this.rbtNonWorkingDay_CheckedChanged);
            // 
            // lblWorkingDay
            // 
            this.lblWorkingDay.Location = new System.Drawing.Point(40, 16);
            this.lblWorkingDay.Name = "lblWorkingDay";
            this.lblWorkingDay.Size = new System.Drawing.Size(80, 23);
            this.lblWorkingDay.TabIndex = 0;
            this.lblWorkingDay.Text = "Ngày làm việc";
            this.lblWorkingDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNonWorkingDay
            // 
            this.lblNonWorkingDay.Location = new System.Drawing.Point(40, 40);
            this.lblNonWorkingDay.Name = "lblNonWorkingDay";
            this.lblNonWorkingDay.Size = new System.Drawing.Size(80, 23);
            this.lblNonWorkingDay.TabIndex = 1;
            this.lblNonWorkingDay.Text = "Ngày nghỉ";
            this.lblNonWorkingDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNonWorkingDayLegend
            // 
            this.lblNonWorkingDayLegend.BackColor = System.Drawing.Color.MistyRose;
            this.lblNonWorkingDayLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNonWorkingDayLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNonWorkingDayLegend.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNonWorkingDayLegend.Location = new System.Drawing.Point(8, 40);
            this.lblNonWorkingDayLegend.Name = "lblNonWorkingDayLegend";
            this.lblNonWorkingDayLegend.Size = new System.Drawing.Size(32, 23);
            this.lblNonWorkingDayLegend.TabIndex = 4;
            this.lblNonWorkingDayLegend.Text = "15";
            this.lblNonWorkingDayLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkingDayLegend
            // 
            this.lblWorkingDayLegend.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWorkingDayLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorkingDayLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWorkingDayLegend.ForeColor = System.Drawing.Color.Navy;
            this.lblWorkingDayLegend.Location = new System.Drawing.Point(8, 16);
            this.lblWorkingDayLegend.Name = "lblWorkingDayLegend";
            this.lblWorkingDayLegend.Size = new System.Drawing.Size(32, 23);
            this.lblWorkingDayLegend.TabIndex = 3;
            this.lblWorkingDayLegend.Text = "1";
            this.lblWorkingDayLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblOverTime);
            this.groupBox3.Controls.Add(this.lblOverTimeLegend);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblHolidayLegend);
            this.groupBox3.Controls.Add(this.lblNonWorkingDay);
            this.groupBox3.Controls.Add(this.lblNonWorkingDayLegend);
            this.groupBox3.Controls.Add(this.lblWorkingDay);
            this.groupBox3.Controls.Add(this.lblWorkingDayLegend);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(648, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 72);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quy ước mầu";
            // 
            // lblOverTime
            // 
            this.lblOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverTime.Location = new System.Drawing.Point(152, 16);
            this.lblOverTime.Name = "lblOverTime";
            this.lblOverTime.Size = new System.Drawing.Size(56, 23);
            this.lblOverTime.TabIndex = 7;
            this.lblOverTime.Text = "Làm thêm";
            this.lblOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOverTimeLegend
            // 
            this.lblOverTimeLegend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblOverTimeLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOverTimeLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOverTimeLegend.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOverTimeLegend.Location = new System.Drawing.Point(120, 16);
            this.lblOverTimeLegend.Name = "lblOverTimeLegend";
            this.lblOverTimeLegend.Size = new System.Drawing.Size(32, 23);
            this.lblOverTimeLegend.TabIndex = 8;
            this.lblOverTimeLegend.Text = "7";
            this.lblOverTimeLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(152, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày lễ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHolidayLegend
            // 
            this.lblHolidayLegend.BackColor = System.Drawing.Color.Salmon;
            this.lblHolidayLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHolidayLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHolidayLegend.ForeColor = System.Drawing.Color.Maroon;
            this.lblHolidayLegend.Location = new System.Drawing.Point(120, 40);
            this.lblHolidayLegend.Name = "lblHolidayLegend";
            this.lblHolidayLegend.Size = new System.Drawing.Size(32, 23);
            this.lblHolidayLegend.TabIndex = 6;
            this.lblHolidayLegend.Text = "31";
            this.lblHolidayLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwListEmployee
            // 
            this.lvwListEmployee.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwListEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwListEmployee.ColumnModel = this.columnModel1;
            this.lvwListEmployee.EnableToolTips = true;
            this.lvwListEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwListEmployee.FullRowSelect = true;
            this.lvwListEmployee.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwListEmployee.GridLines = XPTable.Models.GridLines.Both;
            this.lvwListEmployee.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwListEmployee.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwListEmployee.Location = new System.Drawing.Point(8, 16);
            this.lvwListEmployee.MultiSelect = true;
            this.lvwListEmployee.Name = "lvwListEmployee";
            this.lvwListEmployee.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwListEmployee.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwListEmployee.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwListEmployee.Size = new System.Drawing.Size(264, 280);
            this.lvwListEmployee.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwListEmployee.TabIndex = 80;
            this.lvwListEmployee.TableModel = this.tableModel1;
            this.lvwListEmployee.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwListEmployee.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwListEmployee.Click += new System.EventHandler(this.lvwListEmployee_Click);
            this.lvwListEmployee.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwListEmployee_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cCardID,
            this.cEmployeeName});
            // 
            // cSTT
            // 
            this.cSTT.Text = "STT";
            this.cSTT.Width = 45;
            // 
            // cCardID
            // 
            this.cCardID.Text = "Mã thẻ";
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Text = "Tên nhânviên";
            this.cEmployeeName.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lvwListEmployee);
            this.groupBox1.Location = new System.Drawing.Point(8, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 304);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectAll.Location = new System.Drawing.Point(88, 568);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 82;
            this.btnSelectAll.Text = "Chọn tất";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectNone.Location = new System.Drawing.Point(168, 568);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 83;
            this.btnSelectNone.Text = "Bỏ chọn";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // frmRegWorkingTime
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(872, 598);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmRegWorkingTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký lịch làm việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegWorkingTime_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwListEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		#region Các biến tự định nghĩa

		/// <summary>
		/// 
		/// </summary>
		private RegWorkingTimeDO workingTimeDO = null;

		/// <summary>
		/// 
		/// </summary>
		private ShiftDO shiftDO = null;

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsWorkingTime = null;

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsDepartment = null;

		/// <summary>
		/// 
		/// </summary>
		private int selectedDepartment = 0;

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsShift = null;

		/// <summary>
		/// 
		/// </summary>
		private string[] selectedDates = null;

		/// <summary>
		/// 
		/// </summary>
		private int CurrentMonth;

		/// <summary>
		/// 
		/// </summary>
		private int CurrentYear;

		#endregion

		#region Các hàm xử lý chính

		/// <summary>
		/// thiet lap lich lam viec cho nhung nhan vien duoc chon
		/// </summary>
		private void SetWorkingTime()
		{
			int DeparmentID = (int) departmentTreeView.SelectedNode.Tag;
			int employeeID = 0;
			try 
			{
				//				dsWorkingTime = workingTimeDO.GetWorkingTimeByMonthNew(1, CurrentMonth, CurrentYear);
				dsEmployee = employeeDO.GetEmployeeByDepartment(DeparmentID);
				WorkingTimeDataRows = dsEmployee.Tables[0].Select(dataFilter, dataSort);
				// hien thi form thong bao trang thai hoan thanh
				frmStatusMessage message = new frmStatusMessage();
				string strStatus = WorkingContext.LangManager.GetString("frmStatus_thongbao");
				//message.Show("Đang sinh dữ liệu bảng chấm công, xin chờ trong giây lát...");
				message.Show("Đang cập nhật lịch làm việc cho nhân viên ...");
				message.ProgressBar.Value = 0;
				//			int totalEmployees = dataRows.Length;
				this.Cursor = Cursors.WaitCursor;
				int percentToComplete = 0;
				int percentProcessing = 0;

				for (int i=0;i<lvwListEmployee.SelectedIndicies.Length;i++)
				{
					++percentProcessing;
					//					AddWorkingTimeByEmployee(dsWorkingTime,1);
					// chỉ số hàng được chọn
					int rowIndex = (int)lvwListEmployee.SelectedItems[i].Tag;
					DataRow dr = dsEmployee.Tables[0].Rows[rowIndex];
					employeeID = int.Parse(dr["EmployeeID"].ToString());
					dsWorkingTime = workingTimeDO.GetWorkingTimeByMonth(employeeID, CurrentMonth, CurrentYear);
					if(dsWorkingTime.Tables[0].Rows.Count > 0)
					{
						UpdateWorkingTimeByEmployee(dsWorkingTime,employeeID);
					}
					else
					{
						AddWorkingTimeByEmployee(dsWorkingTime,employeeID);
					}
					percentToComplete = (percentProcessing*100) / lvwListEmployee.SelectedIndicies.Length;
					message.ProgressBar.Value = percentToComplete;
					
				}
				message.Close();
			
				this.Cursor = Cursors.Default;

				string str = WorkingContext.LangManager.GetString("frmRegWork_Up_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmRegWork_Up_Title");
				//MessageBox.Show("Đăng ký thời gian làm việc thành công", "Đăng ký thời gian làm việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				string str = WorkingContext.LangManager.GetString("frmLunch_SetLunch_ThongBao");
				string str1 = WorkingContext.LangManager.GetString("frmLunch_SetLunch_Title");
				//MessageBox.Show("Có lỗi xảy ra khi cập nhật dữ liệu ăn trưa", "Thiết lập ăn trưa", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str,str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		/// <summary>
		/// Thêm thông tin đăng ký thời gian làm việc cho tung nhan vien
		/// </summary>
		/// <param name="dsWorkingTime"></param>
		/// <param name="employeeID"></param>
		/// <returns></returns>
		private int AddWorkingTimeByEmployee(DataSet dsWorkingTime, int employeeID)		
		{
			int ret = 0;
			try
			{
				int NumDays = DateTime.DaysInMonth(CurrentYear, CurrentMonth);
				DateTime DayInMonth = new DateTime(CurrentYear, CurrentMonth, 1);

				for (int i = 1; i <= NumDays; i++)
				{
					DataRow dr = dsWorkingTime.Tables[0].NewRow();
					dr.BeginEdit();
					dr["EmployeeID"] = employeeID;
					dr["Day"] = DayInMonth;
					DateItem[] dateItem = monthCalendar1.GetDateInfo(DayInMonth);
					if (dateItem.Length > 0)
					{
						if (dateItem[0].BackColor == lblWorkingDayLegend.BackColor)
						{
							DataRow[] drShift = dsShift.Tables[0].Select("ShiftName='" + dateItem[0].Text + "'");
                           	dr["ShiftID"] = drShift[0]["ShiftID"];
                            decimal Times = Convert.ToDecimal(drShift[0]["TimeSheet"]);
                            dr["TimeSheet"] = Times;
						}
						else if (dateItem[0].BackColor == lblNonWorkingDayLegend.BackColor)
						{
							dr["ShiftID"] = 0;
                            dr["TimeSheet"] = 0;
						}
						else if (dateItem[0].BackColor == lblHolidayLegend.BackColor)
						{
							dr["ShiftID"] = -1;
                            dr["TimeSheet"] = 1;
						}
						else if (dateItem[0].BackColor == lblOverTimeLegend.BackColor)
						{
							dr["ShiftID"] = -2;
                            dr["TimeSheet"] = 0;
						}
					}
					else
					{
						dr["ShiftID"] = 0;
                        dr["TimeSheet"] = 0;
					}
					dr.EndEdit();
					dsWorkingTime.Tables[0].Rows.Add(dr);
					DayInMonth = DayInMonth.AddDays(1);
				}
				ret = workingTimeDO.AddWorkingTime(dsWorkingTime);
			}
			catch
			{
			}
			return ret;
		}
		/// <summary>
		/// Thêm thông tin đăng ký thời gian làm việc cho tung nhan vien
		/// </summary>
		/// <param name="dsWorkingTime"></param>
		/// <returns></returns>
		private int UpdateWorkingTimeByEmployee(DataSet dsWorkingTime, int employeeID)		
		{
			int ret = 0;
			try
			{
				foreach (DateItem dateItem in monthCalendar1.Dates)
				{
					if (dateItem.Date.Month == CurrentMonth)
					{
						DataRow dr = dsWorkingTime.Tables[0].Rows[dateItem.Date.Day - 1];
						dr.BeginEdit();
						dr["EmployeeID"] = employeeID;
						if (dateItem.BackColor == lblWorkingDayLegend.BackColor)
						{
							DataRow[] drShiftName = dsShift.Tables[0].Select("ShiftName='" + dateItem.Text + "'");
							dr["ShiftID"] = drShiftName[0]["ShiftID"];
                            string TimeSheet = drShiftName[0]["TimeSheet"].ToString();
                            //float TimeSheet = (float)drShiftName[0]["TimeSheet"];
                            if(TimeSheet != "")
                            dr["TimeSheet"] = Convert.ToDecimal(TimeSheet);
                           
						}
						else if (dateItem.BackColor == lblNonWorkingDayLegend.BackColor)
						{
							dr["ShiftID"] = 0;
                            dr["TimeSheet"] = 0;
						}
						else if (dateItem.BackColor == lblHolidayLegend.BackColor)
						{
							dr["ShiftID"] = -1;
                            dr["TimeSheet"] = 1;
						}
						else if (dateItem.BackColor == lblOverTimeLegend.BackColor)
						{
							dr["ShiftID"] = -2;
                            dr["TimeSheet"] = 0;
						}
						dr.EndEdit();
					}
				}
				ret = workingTimeDO.UpdateWorkingTime(dsWorkingTime);
			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}
			return ret;
		}
		/// <summary>
		/// Thiết lập những ngày được chọn là ngày làm việc
		/// </summary>
		private void SetWorkingDay()
		{
			foreach (string selectedDate in selectedDates)
			{
				// Thiết lập ngày làm việc
				DateItem dateItem = new DateItem();
				dateItem.Date = DateTime.Parse(selectedDate);
				dateItem.BackColor = lblWorkingDayLegend.BackColor;
				dateItem.DateColor = lblWorkingDayLegend.ForeColor;

				dateItem.Text = cboShift.Text;
				monthCalendar1.AddDateInfo(dateItem);
			}
		}

		/// <summary>
		/// Thiết lập những ngày được chọn là ngày nghỉ
		/// </summary>
		private void SetNonWorkingDay()
		{
			foreach (string selectedDate in selectedDates)
			{
				// Thiết lập ngày nghỉ
				DateItem dateItem = new DateItem();
				dateItem.Date = DateTime.Parse(selectedDate);
				dateItem.BackColor = lblNonWorkingDayLegend.BackColor;
				dateItem.DateColor = lblNonWorkingDayLegend.ForeColor;
				dateItem.Text = "";
				monthCalendar1.AddDateInfo(dateItem);

			}
		}

		/// <summary>
		/// Thiết lập những ngày được chọn là ngày nghỉ
		/// </summary>
		private void SetHoliday()
		{
			foreach (string selectedDate in selectedDates)
			{
				// Thiết lập ngày lễ
				DateItem dateItem = new DateItem();
				dateItem.Date = DateTime.Parse(selectedDate);
				dateItem.BackColor = lblHolidayLegend.BackColor;
				dateItem.DateColor = lblHolidayLegend.ForeColor;
				dateItem.Text = "";
				monthCalendar1.AddDateInfo(dateItem);

			}
		}

		/// <summary>
		/// Thiết lập những ngày được chọn là ngày làm thêm hệ số 1
		/// </summary>
		private void SetOverTime()
		{
			foreach (string selectedDate in selectedDates)
			{
				// Thiết lập ngày lễ
				DateItem dateItem = new DateItem();
				dateItem.Date = DateTime.Parse(selectedDate);
				dateItem.BackColor = lblOverTimeLegend.BackColor;
				dateItem.DateColor = lblOverTimeLegend.ForeColor;
				dateItem.Text = "";
				monthCalendar1.AddDateInfo(dateItem);
			}
		}

		/// <summary>
		/// Xóa các thiết lập cũ của những ngày được chọn
		/// </summary>
		private void RemoveOldDateInfo()
		{
			foreach (string selectedDate in selectedDates)
			{
				DateItem[] oldDateItems = monthCalendar1.GetDateInfo(DateTime.Parse(selectedDate));
				if (oldDateItems.Length > 0)
				{
					foreach (DateItem oldDateItem in oldDateItems)
					{
						monthCalendar1.RemoveDateInfo(oldDateItem);
					}
				}
			}
		}

		/// <summary>
		/// Tạo ComboBox danh sách các ca làm việc
		/// </summary>
		private void PopulateShiftCombo()
		{
			shiftDO = new ShiftDO();
			dsShift = shiftDO.GetShift();

			cboShift.DataSource = dsShift.Tables[0];
			cboShift.DisplayMember = "ShiftName";
			cboShift.ValueMember = "ShiftID";
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDateStatus()
		{
			//			// Kiểm tra những ngày được chọn có cùng kiểu ngày: Ngày nghỉ, làm việc, mặc định
			//			bool isDayTypeSimilar = true;
			//			// Kiểm tra những ngày được chọn có cùng ca làm việc
			//			bool isShiftSimilar = true;
			// Lay trang thai cua ngay duoc chon dau tien
			DateItem[] firstDateItems = monthCalendar1.GetDateInfo(DateTime.Parse(selectedDates[0]));

			if (selectedDates.Length == 1)
			{
				if (firstDateItems.Length > 0)
				{
					cboShift.Text = firstDateItems[0].Text;
					if (firstDateItems[0].DateColor == lblWorkingDayLegend.ForeColor)
					{
						rbtWorkingDay.Checked = true;
					}
					else if (firstDateItems[0].DateColor == lblNonWorkingDayLegend.ForeColor)
					{
						rbtNonWorkingDay.Checked = true;
					}
					else if (firstDateItems[0].DateColor == lblHolidayLegend.ForeColor)
					{
						rbtHoliday.Checked = true;
					}
					else if (firstDateItems[0].DateColor == lblOverTimeLegend.ForeColor)
					{
						rbtOverTime.Checked = true;
					}
				}
			}
			else
			{
				cboShift.Text = "";
				rbtWorkingDay.Checked = false;
				rbtNonWorkingDay.Checked = false;
				rbtHoliday.Checked = false;
			}
			
		}

		#endregion

		#region Windows Form event handlers

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa3");
			string str1 = WorkingContext.LangManager.GetString("frmRegRest_DK_Title");
			//MessageBox.Show("Chức năng này đang được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frmRegWorkingTime_Load(object sender, EventArgs e)
		{
			Refresh();
			workingTimeDO = new RegWorkingTimeDO();
			employeeDO = new EmployeeDO();

			DepartmentDO departmentDO = new DepartmentDO();
			dsDepartment = departmentDO.GetAllDepartments();

			departmentTreeView.DepartmentDataSet = dsDepartment;
			departmentTreeView.BuildTree();
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;

			monthCalendar1.SelectDate(DateTime.Today);
			
			//CurrentYear = DateTime.Today.Year;
			CurrentYear = DateTime.Now.Year;
			monthCalendar1.ActiveMonth.Year = CurrentYear;
			CurrentMonth = DateTime.Today.Month;
			monthCalendar1.ActiveMonth.Month = CurrentMonth;
			
			monthCalendar1.SelectDate(DateTime.Today);
			SetStatus(false);

			PopulateShiftCombo();
		}

		private void monthCalendar1_DaySelected(object sender, DaySelectedEventArgs e)
		{
			selectedDates = e.Days;
			SetStatus(true);
			LoadDateStatus();
		}

		private void rbtWorkingDay_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtWorkingDay.Checked)
			{
				cboShift.Enabled = true;
				RemoveOldDateInfo();
				SetWorkingDay();
			}
		}

		private void rbtNonWorkingDay_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtNonWorkingDay.Checked)
			{
				cboShift.Text = "";
				cboShift.Enabled = false;
				RemoveOldDateInfo();
				SetNonWorkingDay();
			}
		}

		private void rbtHoliday_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtHoliday.Checked)
			{
				cboShift.Text = "";
				cboShift.Enabled = false;
				RemoveOldDateInfo();
				SetHoliday();
			}
		}

		private void rbtOverTime_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtOverTime.Checked)
			{
				cboShift.Text = "";
				cboShift.Enabled = false;
				RemoveOldDateInfo();
				SetOverTime();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if(monthCalendar1.Dates.Count > 0)
			{
				SetWorkingTime();
			}

		}

		private void monthCalendar1_MonthChanged(object sender, MonthChangedEventArgs e)
		{
			CurrentMonth = e.Month;
			CurrentYear = e.Year;
			//			LoadWorkingCalendar();
		}

		private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (rbtWorkingDay.Checked)
			{
				cboShift.Enabled = true;
				RemoveOldDateInfo();
				SetWorkingDay();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//			LoadWorkingCalendar();
		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			selectedDepartment = (int) departmentTreeView.SelectedNode.Tag;
			departmentTreeView.ExpandNodes(true);
			LoadEmployeeeInDepartment();
			//			LoadWorkingCalendar();
		}
		/// <summary>
		/// Dien thong tin nhan vien un'g voi' phong duoc chon
		/// </summary>
		private void  LoadEmployeeeInDepartment()
		{
			//			dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
			dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
			//			LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);
			

			lvwListEmployee.BeginUpdate();
			lvwListEmployee.TableModel.Rows.Clear();

			int STT = 0;
			foreach (DataRow dr in  dsEmployee.Tables[0].Rows)
			{
				string CardID = dr["CardID"].ToString();
				string EmployeeName = dr["EmployeeName"].ToString();
				string EmployeeID = dr["EmployeeID"].ToString();
				Cell[] cells = new Cell[4];
				cells[0] = new Cell(STT+1);
				cells[1] = new Cell(CardID);
				cells[2] = new Cell(EmployeeName);
				cells[3] = new Cell(EmployeeID);
				Row row = new Row(cells);
				row.Tag = STT;
				lvwListEmployee.TableModel.Rows.Add(row);
				STT++;
			}
			lvwListEmployee.EndUpdate();
			
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="status"></param>
		private void SetStatus(bool status)
		{
			rbtHoliday.Enabled = status;
			rbtWorkingDay.Enabled = status;
			rbtNonWorkingDay.Enabled = status;
			rbtOverTime.Enabled = status;
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
			this.Text = WorkingContext.LangManager.GetString("frmRegWork_Text");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmRegWork_groupbox2");
			this.groupBox3.Text = WorkingContext.LangManager.GetString("frmRegWork_groupbox3");
			this.groupBox4.Text = WorkingContext.LangManager.GetString("frmRegWork_groupbox4");
			this.groupBox5.Text = WorkingContext.LangManager.GetString("frmRegWork_groupbox5");
			this.rbtWorkingDay.Text = WorkingContext.LangManager.GetString("frmRegWork_rptWork");
			this.rbtOverTime.Text = WorkingContext.LangManager.GetString("frmRegWork_rptOverTime");
			this.rbtNonWorkingDay.Text = WorkingContext.LangManager.GetString("frmRegWork_rptNonWork");
			this.rbtHoliday.Text = WorkingContext.LangManager.GetString("frmRegWork_rptHoliday");
			this.lblShift.Text = WorkingContext.LangManager.GetString("frmRegWork_lblShif");
			this.lblWorkingDay.Text = WorkingContext.LangManager.GetString("frmRegWork_lblWork");
			this.lblNonWorkingDay.Text = WorkingContext.LangManager.GetString("frmRegWork_lblNonWork");
			this.lblOverTime.Text = WorkingContext.LangManager.GetString("frmRegWork_lblOverTime");
			this.label2.Text = WorkingContext.LangManager.GetString("frmRegWork_lable2");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmRegWork_btnHelp");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmRegWork_btnUpdate");
			this.btnCancel.Text = WorkingContext.LangManager.GetString("frmRegWork_btnCancel");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegWork_btnClose");
			this.btnSelectAll.Text = WorkingContext.LangManager.GetString("frmGroup_cmdSelectAll");
			this.btnSelectNone.Text = WorkingContext.LangManager.GetString("frmGroup_cmdClearAll");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntHelp");
			this.groupBox1 .Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpEmployee");
			
			
			
		}
		#endregion

		private void btnSelectAll_Click(object sender, System.EventArgs e)
		{
			tableModel1.Selections.SelectCells(0, 0, lvwListEmployee.RowCount - 1,0);
		}

		private void btnSelectNone_Click(object sender, System.EventArgs e)
		{
			tableModel1.Selections.Clear();
		}

		private void lvwListEmployee_Click(object sender, System.EventArgs e)
		{
			monthCalendar1.TodayColor = Color.Red;
			//			monthCalendar1.BackColor = Color.Red;
			LoadWorkingCalendarByEmployee();
		}
		/// <summary>
		/// 
		/// </summary>
		private void LoadWorkingCalendarByEmployee()
		{
			monthCalendar1.Dates.Clear();
			int DeparmentID = (int) departmentTreeView.SelectedNode.Tag;
			dsEmployee = employeeDO.GetEmployeeByDepartment(DeparmentID);
			int employeeID = (int)dsEmployee.Tables[0].Rows[selectedRowIndex]["EmployeeID"];
			dsWorkingTime = workingTimeDO.GetWorkingTimeByMonth(employeeID, CurrentMonth, CurrentYear);
			if (dsWorkingTime.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in dsWorkingTime.Tables[0].Rows)
				{
					DateTime Day = DateTime.Parse(dr["Day"].ToString());
					int ShiftID = int.Parse(dr["ShiftID"].ToString());

					if (ShiftID > 0)
					{
						DateItem dateItem = new DateItem();
						dateItem.DateColor = lblWorkingDayLegend.ForeColor;
						dateItem.BackColor = lblWorkingDayLegend.BackColor;
						dateItem.Date = Day;
						dateItem.Text = dr["ShiftName"].ToString();
						monthCalendar1.AddDateInfo(dateItem);
					}
					else if (ShiftID == 0)
					{
						DateItem dateItem = new DateItem();
						dateItem.DateColor = lblNonWorkingDayLegend.ForeColor;
						dateItem.BackColor = lblNonWorkingDayLegend.BackColor;
						dateItem.Date = Day;
						monthCalendar1.AddDateInfo(dateItem);
					}
					else if (ShiftID == -1)
					{
						DateItem dateItem = new DateItem();
						dateItem.DateColor = lblHolidayLegend.ForeColor;
						dateItem.BackColor = lblHolidayLegend.BackColor;
						dateItem.Date = Day;
						monthCalendar1.AddDateInfo(dateItem);
					}
					else
					{
						DateItem dateItem = new DateItem();
						dateItem.DateColor = lblOverTimeLegend.ForeColor;
						dateItem.BackColor = lblOverTimeLegend.BackColor;
						dateItem.Date = Day;
						monthCalendar1.AddDateInfo(dateItem);
					}
				}
			}
			monthCalendar1.Refresh();
			monthCalendar1.ClearSelection();

		}

		private void lvwListEmployee_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwListEmployee.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}
	}
}