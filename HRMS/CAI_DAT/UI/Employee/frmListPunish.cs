using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Events;
using XPTable.Models;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmLishPunish.
	/// </summary>
	public class frmListPunish : Form
	{
		#region Các biến tự định nghĩa
		private DataSet dsPunish = null;
		private PunishDO punishDO = null;
		/// <summary>
		/// Vị trí của hàng được chọn trên listview, mặc định chưa chọn hàng nào
		/// </summary>
		private int selectedRowIndex = -1;

				
		#endregion
		#region khai báo các control
		private TextColumn cWorkingDay;
		private TextColumn cReason;
		private TextColumn cCardName;
		private TextColumn cCardID;
		private TextColumn cEmployeeName;
		private TextColumn cDepartmentName;
		private Button btnAdd;
		private DataGridTextBoxColumn dgsCardID;
		private TableModel tableModel1;
		private Button btnView;
		private DataGridTextBoxColumn dgsEmployeeName;
		private DataGridTextBoxColumn dtgStartRest;
		private GroupBox groupBox1;
		private Table lvwListPunish;
		private ColumnModel columnModel1;
		private ComboBox cboDepartment;
		private Button btnDelete;
		private DataGridTextBoxColumn dgsDepartment;
		private Label label3;
		private Label label2;
		private Button btnModify;
		private Label label1;
		private DataGridTextBoxColumn dgsEndRest;
		private DataGridTextBoxColumn dtgDayName;
		private DataGridTextBoxColumn dgsRestReason;
		private Button btnClose;
		private GroupBox groupBox2;
		private DateTimePicker dtpToDate;
		private DateTimePicker dtpFromDate;
		private Button btnExcel;
		private XPTable.Models.NumberColumn cSTT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		#endregion
		#region Xử lý các sự kiện
		public frmListPunish()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmListPunish));
			this.cWorkingDay = new XPTable.Models.TextColumn();
			this.cReason = new XPTable.Models.TextColumn();
			this.cCardName = new XPTable.Models.TextColumn();
			this.cCardID = new XPTable.Models.TextColumn();
			this.cEmployeeName = new XPTable.Models.TextColumn();
			this.cDepartmentName = new XPTable.Models.TextColumn();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgsCardID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnView = new System.Windows.Forms.Button();
			this.dgsEmployeeName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgStartRest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwListPunish = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cSTT = new XPTable.Models.NumberColumn();
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgsDepartment = new System.Windows.Forms.DataGridTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnModify = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgsEndRest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgDayName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgsRestReason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExcel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwListPunish)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cWorkingDay
			// 
			this.cWorkingDay.Editable = false;
			this.cWorkingDay.Text = "Ngày làm việc";
			this.cWorkingDay.Width = 90;
			// 
			// cReason
			// 
			this.cReason.Editable = false;
			this.cReason.Text = "Lý do phạt";
			this.cReason.Width = 170;
			// 
			// cCardName
			// 
			this.cCardName.Editable = false;
			this.cCardName.Text = "Hình thức phạt";
			this.cCardName.Width = 110;
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
			// cDepartmentName
			// 
			this.cDepartmentName.Editable = false;
			this.cDepartmentName.Text = "Tên bộ phận";
			this.cDepartmentName.Width = 100;
			// 
			// dtpToDate
			// 
			this.dtpToDate.CustomFormat = "dd/MM/yyyy   ";
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDate.Location = new System.Drawing.Point(224, 16);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(88, 20);
			this.dtpToDate.TabIndex = 15;
			this.dtpToDate.CloseUp += new System.EventHandler(this.dtpToDate_CloseUp);
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.CustomFormat = "dd/MM/yyyy    ";
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDate.Location = new System.Drawing.Point(64, 16);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(88, 20);
			this.dtpFromDate.TabIndex = 13;
			this.dtpFromDate.CloseUp += new System.EventHandler(this.dtpFromDate_CloseUp);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(464, 480);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "Thêm &mới";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgsCardID
			// 
			this.dgsCardID.Format = "";
			this.dgsCardID.FormatInfo = null;
			this.dgsCardID.HeaderText = "Mã nhân viên";
			this.dgsCardID.MappingName = "CardID";
			this.dgsCardID.Width = 75;
			// 
			// btnView
			// 
			this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnView.Location = new System.Drawing.Point(4, 480);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 20;
			this.btnView.Text = "Xem";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// dgsEmployeeName
			// 
			this.dgsEmployeeName.Format = "";
			this.dgsEmployeeName.FormatInfo = null;
			this.dgsEmployeeName.HeaderText = "Tên nhân viên";
			this.dgsEmployeeName.MappingName = "EmployeeName";
			this.dgsEmployeeName.Width = 120;
			// 
			// dtgStartRest
			// 
			this.dtgStartRest.Format = "dd/MM/yyyy    ";
			this.dtgStartRest.FormatInfo = null;
			this.dtgStartRest.HeaderText = "Bắt đầu";
			this.dtgStartRest.MappingName = "StartRest";
			this.dtgStartRest.Width = 75;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwListPunish);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 424);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhân viên bị phạt";
			// 
			// lvwListPunish
			// 
			this.lvwListPunish.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwListPunish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwListPunish.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwListPunish.ColumnModel = this.columnModel1;
			this.lvwListPunish.EnableToolTips = true;
			this.lvwListPunish.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListPunish.FullRowSelect = true;
			this.lvwListPunish.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwListPunish.GridLines = XPTable.Models.GridLines.Both;
			this.lvwListPunish.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwListPunish.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwListPunish.Location = new System.Drawing.Point(8, 16);
			this.lvwListPunish.Name = "lvwListPunish";
			this.lvwListPunish.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwListPunish.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwListPunish.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListPunish.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwListPunish.Size = new System.Drawing.Size(752, 392);
			this.lvwListPunish.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwListPunish.TabIndex = 11;
			this.lvwListPunish.TableModel = this.tableModel1;
			this.lvwListPunish.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwListPunish.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListPunish.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwListPunish_SelectionChanged);
			this.lvwListPunish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwListPunish_MouseDown);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cSTT,
																			   this.cDepartmentName,
																			   this.cCardID,
																			   this.cEmployeeName,
																			   this.cCardName,
																			   this.cWorkingDay,
																			   this.cReason});
			// 
			// cSTT
			// 
			this.cSTT.Editable = false;
			this.cSTT.Maximum = new System.Decimal(new int[] {
																 10000,
																 0,
																 0,
																 0});
			this.cSTT.Text = "STT";
			this.cSTT.Width = 40;
			// 
			// cboDepartment
			// 
			this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDepartment.Location = new System.Drawing.Point(584, 16);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(176, 21);
			this.cboDepartment.TabIndex = 17;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Location = new System.Drawing.Point(624, 480);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "&Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgsDepartment
			// 
			this.dgsDepartment.Format = "";
			this.dgsDepartment.FormatInfo = null;
			this.dgsDepartment.HeaderText = "Phòng";
			this.dgsDepartment.MappingName = "DepartmentName";
			this.dgsDepartment.Width = 80;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(504, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tên bộ phận";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Đến ngày";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnModify
			// 
			this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModify.Location = new System.Drawing.Point(544, 480);
			this.btnModify.Name = "btnModify";
			this.btnModify.TabIndex = 22;
			this.btnModify.Text = "&Sửa";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Từ ngày";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgsEndRest
			// 
			this.dgsEndRest.Format = "dd/MM/yyyy    ";
			this.dgsEndRest.FormatInfo = null;
			this.dgsEndRest.HeaderText = "Kết thúc";
			this.dgsEndRest.MappingName = "EndRest";
			this.dgsEndRest.Width = 75;
			// 
			// dtgDayName
			// 
			this.dtgDayName.Format = "";
			this.dtgDayName.FormatInfo = null;
			this.dtgDayName.HeaderText = "Kiểu ngày";
			this.dtgDayName.MappingName = "DayName";
			this.dtgDayName.Width = 90;
			// 
			// dgsRestReason
			// 
			this.dgsRestReason.Format = "";
			this.dgsRestReason.FormatInfo = null;
			this.dgsRestReason.HeaderText = "Lý do nghỉ";
			this.dgsRestReason.MappingName = "RestReason";
			this.dgsRestReason.Width = 120;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(704, 480);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.cboDepartment);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.dtpFromDate);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.dtpToDate);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(768, 48);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExcel.Location = new System.Drawing.Point(352, 480);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(104, 24);
			this.btnExcel.TabIndex = 25;
			this.btnExcel.Text = "Xuất &Excel";
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// frmListPunish
			// 
			this.AcceptButton = this.btnView;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(784, 510);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmListPunish";
			this.Text = "Danh sách nhân viên bị phạt";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmLishPunish_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwListPunish)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmPunish frmpunish = new frmPunish();
			frmpunish.DSPunish = dsPunish;
			frmpunish.ShowDialog();
			PopulateListPunish();
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();

		}

		private void frmLishPunish_Load(object sender, EventArgs e)
		{
			Refresh();
			punishDO = new PunishDO();
			BindingDepartmentCombo();
			PopulateListPunish();
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
			this.Text = WorkingContext.LangManager.GetString("frmListPunish_Text1");
			this.label1.Text = WorkingContext.LangManager.GetString("frmListPunish_lable1");
			this.label2.Text = WorkingContext.LangManager.GetString("frmListPunish_lable2");
			this.label3.Text = WorkingContext.LangManager.GetString("frmListPunish_lable3");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListPunish_groupbox1");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_STT");
			this.cDepartmentName.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_BoPhan");
			this.cCardID.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_MaThe");
			this.cEmployeeName.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_HoTen");
			this.cWorkingDay.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_NgayLamViec");
			this.cReason.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_LyDo");
			this.cCardName.Text = WorkingContext.LangManager.GetString("frmListPunish_lvwListPunish_HinhThucPhat");
			this.btnView.Text = WorkingContext.LangManager.GetString("frmListPunish_btnView");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListPunish_btnAdd");
			this.btnExcel.Text = WorkingContext.LangManager.GetString("frmListPunish_btnExcel");
			this.btnModify.Text = WorkingContext.LangManager.GetString("frmListPunish_btnModifile");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListPunish_btnDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListPunish_btnClose");
			this.lvwListPunish.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			
			
			
		}


		private void btnView_Click(object sender, EventArgs e)
		{
			PopulateListPunish();
		
		}
		#endregion
		#region các hàm xử lý chính
		/// <summary>
		/// 
		/// </summary>
		private void PopulateListPunish()
		{
			if(dtpFromDate.Value.Date <= dtpToDate.Value.Date)
			{
				dsPunish = punishDO.GetListPunish(dtpFromDate.Value.Date,dtpToDate.Value.Date,(int)cboDepartment.SelectedValue);
				lvwListPunish.BeginUpdate();
				lvwListPunish.TableModel.Rows.Clear();
				DataTable dtPunish = new DataTable();
				dtPunish = dsPunish.Tables[0];
				int STT = 0;
				foreach(DataRow dr in dtPunish.Rows)
				{
					string CardID = dr["CardID"].ToString();
					string EmployeeName = dr["EmployeeName"].ToString();
					string DepartmentName = dr["DepartmentName"].ToString();
					string CardName = dr["CardName"].ToString();
					string WorkingDay = DateTime.Parse(dr["WorkingDay"].ToString()).ToString("dd/MM/yyyy");
					string Reason = dr["Reason"].ToString();
					Cell[] ListPunish = new Cell[7];
					ListPunish[0] = new Cell(STT+1);
					ListPunish[1] = new Cell(DepartmentName);
					ListPunish[2] = new Cell(CardID);
					ListPunish[3] = new Cell(EmployeeName);
					ListPunish[4] = new Cell(CardName);
					ListPunish[5] = new Cell(WorkingDay);
					ListPunish[6] = new Cell(Reason);

					Row row = new Row(ListPunish);
					row.Tag = STT;
					lvwListPunish.TableModel.Rows.Add(row);
					STT++;
				}
				lvwListPunish.EndUpdate();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				
				//MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		private void BindingDepartmentCombo()
		{
			DepartmentDO departmentDO = new DepartmentDO();
			DataSet departmentDS = departmentDO.GetAllDepartments();

			cboDepartment.DataSource = departmentDS.Tables[0];
			cboDepartment.ValueMember = "DepartmentID";
			cboDepartment.DisplayMember = "DepartmentName";
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			if(selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Sua_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Không có nhân viên nào được chọn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				frmPunish frm = new frmPunish();
				frm.DSPunish = dsPunish;
				frm.CurrentPunish = selectedRowIndex;
				frm.ShowDialog();
				PopulateListPunish();
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void lvwListPunish_SelectionChanged(object sender, SelectionEventArgs e)
		{
			if(e.NewSelectedIndicies.Length > 0)//có ít nhất một hàng được chọn
			{
				// lấy ra vị trí của hàng đuợc chọn, NewSelectedIndicies[0]= chỉ chọn một hàng 
				selectedRowIndex  = (int)lvwListPunish.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(selectedRowIndex >= 0 )
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Xoa_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//comfirm xem có chắc muốn xóa ko?
				DialogResult dr = MessageBox.Show(str,str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					DeletePunish();
					PopulateListPunish();
				}
					
				else
				{
					dsPunish.RejectChanges();
				}
				
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Xoa_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Bạn chưa chọn nhân viên cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}
		/// <summary>
		/// xóa
		/// </summary>
		private void DeletePunish()
		{
			int ret = 0;
			try
			{
				dsPunish.Tables[0].Rows[selectedRowIndex].Delete();
				ret = punishDO.DeletePunish(dsPunish);
			}
			catch
			{
				dsPunish.RejectChanges();
			}
			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Xoa_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Xóa thành công khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsPunish.AcceptChanges();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListPunish_Xoa_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Không thể xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsPunish.RejectChanges();
			}
		}

		private void lvwListPunish_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if(lvwListPunish.SelectedItems.Length > 0)
				{
					frmPunish frm = new frmPunish();
					frm.DSPunish = dsPunish;
					frm.CurrentPunish = selectedRowIndex;
					frm.ShowDialog();
					PopulateListPunish();	
				}
				selectedRowIndex = -1;
				tableModel1.Selections.Clear();
			}
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmListPunish_messa1");
			//message.Show("Đang xuất dữ liệu bảng thẻ phạt ra file Excel...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			if (!Utils.ExportExcel(lvwListPunish,this.Text))
			{
				string str1 = WorkingContext.LangManager.GetString("frmListSalary_btnXuatE_ThongBao1");
				string str2 = WorkingContext.LangManager.GetString("Xuất Excel");
				//MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			message.Close();
			this.Cursor = Cursors.Default;
		}
		#endregion

		private void dtpToDate_CloseUp(object sender, System.EventArgs e)
		{
			PopulateListPunish();
		}

		private void dtpFromDate_CloseUp(object sender, System.EventArgs e)
		{
			PopulateListPunish();
		}
	}
}
