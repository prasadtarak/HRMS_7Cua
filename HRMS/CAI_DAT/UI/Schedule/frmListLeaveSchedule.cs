using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Events;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for ListLeaveSchedule.
	/// </summary>
	public class frmListLeaveSchedule : Form
	{
		LeaveScheduleDO leaveScheduleDO = null;
		private DataSet dsLeaveSchedule = null;

		private int selectedRowIndex = -1;
		private ComboBox cboDepartment;
		private Label label1;
		private DateTimePicker dtpTo;
		private DateTimePicker dtpFrom;
		private Label label3;
		private Label label2;
		private DataGridTextBoxColumn dtgcCardID;
		private DataGridTextBoxColumn dtgcEmployeeName;
		private DataGridTextBoxColumn dtgcDepartment;
		private DataGridTextBoxColumn dtgcLeaveLocation;
		private DataGridTextBoxColumn dtgcWorkInfo;
		private DataGridTextBoxColumn dtgcStartLeave;
		private DataGridTextBoxColumn dtgcEndLeave;
		private TableModel tableModel1;
		private ColumnModel columnModel1;
		private GroupBox groupBox1;
		private Table lvwLeaveSchedule;
		private TextColumn chCardID;
		private TextColumn chEmployeeName;
		private TextColumn chDepartment;
		private TextColumn chStartLeave;
		private TextColumn EndLeave;
		private TextColumn chLeaveLocation;
		private TextColumn chWorkInfo;
		private GroupBox groupBox2;
		private Button btnEdit;
		private Button btnDelete;
		private Button btnAdd;
		private Button btnView;
		private Button btnClose;
		private Button btnExcel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		private NumberColumn cSTT;

		public frmListLeaveSchedule()
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
			XPTable.Models.Row row1 = new XPTable.Models.Row();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmListLeaveSchedule));
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtgcCardID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcEmployeeName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcDepartment = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcLeaveLocation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcWorkInfo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcStartLeave = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dtgcEndLeave = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cSTT = new XPTable.Models.NumberColumn();
			this.chDepartment = new XPTable.Models.TextColumn();
			this.chCardID = new XPTable.Models.TextColumn();
			this.chEmployeeName = new XPTable.Models.TextColumn();
			this.chStartLeave = new XPTable.Models.TextColumn();
			this.EndLeave = new XPTable.Models.TextColumn();
			this.chLeaveLocation = new XPTable.Models.TextColumn();
			this.chWorkInfo = new XPTable.Models.TextColumn();
			this.lvwLeaveSchedule = new XPTable.Models.Table();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.lvwLeaveSchedule)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboDepartment
			// 
			this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDepartment.Location = new System.Drawing.Point(472, 16);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(224, 21);
			this.cboDepartment.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(408, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Bộ phận";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "dd/MM/yyyy    ";
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(224, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(88, 20);
			this.dtpTo.TabIndex = 20;
			this.dtpTo.CloseUp += new System.EventHandler(this.dtpTo_CloseUp);
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "dd/MM/yyyy    ";
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(64, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(88, 20);
			this.dtpFrom.TabIndex = 19;
			this.dtpFrom.CloseUp += new System.EventHandler(this.dtpFrom_CloseUp);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(160, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Đến ngày";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "Từ ngày";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtgcCardID
			// 
			this.dtgcCardID.Format = "";
			this.dtgcCardID.FormatInfo = null;
			this.dtgcCardID.HeaderText = "Mã thẻ";
			this.dtgcCardID.MappingName = "CardID";
			this.dtgcCardID.Width = 75;
			// 
			// dtgcEmployeeName
			// 
			this.dtgcEmployeeName.Format = "";
			this.dtgcEmployeeName.FormatInfo = null;
			this.dtgcEmployeeName.HeaderText = "Tên nhân viên";
			this.dtgcEmployeeName.MappingName = "EmployeeName";
			this.dtgcEmployeeName.Width = 120;
			// 
			// dtgcDepartment
			// 
			this.dtgcDepartment.Format = "";
			this.dtgcDepartment.FormatInfo = null;
			this.dtgcDepartment.HeaderText = "Phòng";
			this.dtgcDepartment.MappingName = "DepartmentName";
			this.dtgcDepartment.Width = 80;
			// 
			// dtgcLeaveLocation
			// 
			this.dtgcLeaveLocation.Format = "";
			this.dtgcLeaveLocation.FormatInfo = null;
			this.dtgcLeaveLocation.HeaderText = "Nơi công tác";
			this.dtgcLeaveLocation.MappingName = "LeaveLocation";
			this.dtgcLeaveLocation.Width = 75;
			// 
			// dtgcWorkInfo
			// 
			this.dtgcWorkInfo.Format = "";
			this.dtgcWorkInfo.FormatInfo = null;
			this.dtgcWorkInfo.HeaderText = "Công việc";
			this.dtgcWorkInfo.MappingName = "WorkInfo";
			this.dtgcWorkInfo.Width = 150;
			// 
			// dtgcStartLeave
			// 
			this.dtgcStartLeave.Format = "";
			this.dtgcStartLeave.FormatInfo = null;
			this.dtgcStartLeave.HeaderText = "Ngày đi";
			this.dtgcStartLeave.MappingName = "StartLeave";
			this.dtgcStartLeave.Width = 75;
			// 
			// dtgcEndLeave
			// 
			this.dtgcEndLeave.Format = "";
			this.dtgcEndLeave.FormatInfo = null;
			this.dtgcEndLeave.HeaderText = "Ngày về";
			this.dtgcEndLeave.MappingName = "EndLeave";
			this.dtgcEndLeave.Width = 75;
			// 
			// tableModel1
			// 
			this.tableModel1.Rows.AddRange(new XPTable.Models.Row[] {
																		row1});
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cSTT,
																			   this.chDepartment,
																			   this.chCardID,
																			   this.chEmployeeName,
																			   this.chStartLeave,
																			   this.EndLeave,
																			   this.chLeaveLocation,
																			   this.chWorkInfo});
			// 
			// cSTT
			// 
			this.cSTT.Editable = false;
			this.cSTT.Text = "STT";
			this.cSTT.Width = 40;
			// 
			// chDepartment
			// 
			this.chDepartment.Editable = false;
			this.chDepartment.Text = "Bộ phận";
			this.chDepartment.Width = 100;
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
			// chStartLeave
			// 
			this.chStartLeave.Editable = false;
			this.chStartLeave.Text = "Bắt đầu";
			// 
			// EndLeave
			// 
			this.EndLeave.Editable = false;
			this.EndLeave.Text = "Kết thúc";
			// 
			// chLeaveLocation
			// 
			this.chLeaveLocation.Editable = false;
			this.chLeaveLocation.Text = "Nơi công tác";
			this.chLeaveLocation.Width = 90;
			// 
			// chWorkInfo
			// 
			this.chWorkInfo.Editable = false;
			this.chWorkInfo.Text = "Nội dung công việc";
			this.chWorkInfo.Width = 140;
			// 
			// lvwLeaveSchedule
			// 
			this.lvwLeaveSchedule.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwLeaveSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwLeaveSchedule.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwLeaveSchedule.ColumnModel = this.columnModel1;
			this.lvwLeaveSchedule.EnableToolTips = true;
			this.lvwLeaveSchedule.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwLeaveSchedule.FullRowSelect = true;
			this.lvwLeaveSchedule.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwLeaveSchedule.GridLines = XPTable.Models.GridLines.Both;
			this.lvwLeaveSchedule.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwLeaveSchedule.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwLeaveSchedule.Location = new System.Drawing.Point(8, 16);
			this.lvwLeaveSchedule.Name = "lvwLeaveSchedule";
			this.lvwLeaveSchedule.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwLeaveSchedule.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwLeaveSchedule.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwLeaveSchedule.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwLeaveSchedule.Size = new System.Drawing.Size(688, 400);
			this.lvwLeaveSchedule.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwLeaveSchedule.TabIndex = 30;
			this.lvwLeaveSchedule.TableModel = this.tableModel1;
			this.lvwLeaveSchedule.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwLeaveSchedule.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwLeaveSchedule.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwLeaveSchedule_SelectionChanged);
			this.lvwLeaveSchedule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwLeaveSchedule_MouseDown);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwLeaveSchedule);
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 424);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.dtpTo);
			this.groupBox2.Controls.Add(this.dtpFrom);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cboDepartment);
			this.groupBox2.Location = new System.Drawing.Point(8, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(704, 48);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEdit.Location = new System.Drawing.Point(472, 480);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 36;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Location = new System.Drawing.Point(552, 480);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 37;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(392, 480);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 35;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnView
			// 
			this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnView.Location = new System.Drawing.Point(8, 480);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 33;
			this.btnView.Text = "Xem";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(632, 480);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 34;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExcel.Location = new System.Drawing.Point(272, 480);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(112, 23);
			this.btnExcel.TabIndex = 38;
			this.btnExcel.Text = "Xuất Excel";
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// frmListLeaveSchedule
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 510);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmListLeaveSchedule";
			this.Text = "Danh sách nhân viên đi công tác";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ListLeaveSchedule_Load);
			((System.ComponentModel.ISupportInitialize)(this.lvwLeaveSchedule)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			PopulateLeaveSchedule();
		}

		/// <summary>
		/// Hiển thị tất cả lịch công tác của nhân viên trong một khoảng thời gian
		/// </summary>
		private void PopulateLeaveSchedule()
		{
			if (dtpFrom.Value.Date <= dtpTo.Value.Date)
			{
				dsLeaveSchedule = leaveScheduleDO.GetListLeaveSchedule(dtpFrom.Value.Date,dtpTo.Value.Date,(int)cboDepartment.SelectedValue);
				lvwLeaveSchedule.BeginUpdate();
				lvwLeaveSchedule.TableModel.Rows.Clear();

				DataTable dtLeaveSchedule = dsLeaveSchedule.Tables[0];

				int STT = 0;
				foreach (DataRow dr in dtLeaveSchedule.Rows)
				{
					string CardID = dr["CardID"].ToString();
					string EmployeeName = dr["EmployeeName"].ToString();
					string DepartmentName = dr["DepartmentName"].ToString();
					string WorkInfo = dr["WorkInfo"].ToString();
					
					string StartLeave = DateTime.Parse(dr["StartLeave"].ToString()).ToString("dd/MM/yyyy");
					string EndLeave = DateTime.Parse(dr["EndLeave"].ToString()).ToString("dd/MM/yyyy");
					string LeaveLocation = dr["LeaveLocation"].ToString();
					
					Cell[] LeaveSchedule = new Cell[8];
					LeaveSchedule[0] = new Cell(STT+1);
					LeaveSchedule[1] = new Cell(DepartmentName);
					LeaveSchedule[2] = new Cell(CardID);
					LeaveSchedule[3] = new Cell(EmployeeName);
					LeaveSchedule[4] = new Cell(StartLeave);
					LeaveSchedule[5] = new Cell(EndLeave);
					LeaveSchedule[6] = new Cell(LeaveLocation);
					LeaveSchedule[7] = new Cell(WorkInfo);

					Row row = new Row(LeaveSchedule);
					row.Tag = STT;
					lvwLeaveSchedule.TableModel.Rows.Add(row);
					STT++;
				}
				lvwLeaveSchedule.EndUpdate();
			
			}

			else
			{
				string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//MessageBox.Show("Không hợp lệ! Ngày bắt đầu phải trước ngày kết thúc!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
			this.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Text");
			this.label1.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lable1");
			this.label2.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lable2");
			this.label3.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lable3");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_STT");
			this.chDepartment.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_BoPhan");
			this.chCardID.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_MaTHe");
			this.chEmployeeName.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_TenNV");
			this.chStartLeave.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_BatDau");
			this.chLeaveLocation.Text= WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_NoiCT");
			this.chWorkInfo.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_NDCV");
			this.EndLeave.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_lvwLeave_KetThuc");
			this.btnView.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnView");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnAdd");
			this.btnEdit.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnEdit");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnClose");
			this.btnExcel.Text = WorkingContext.LangManager.GetString("frmListLeaveSchedule_btnExcel");
			this.lvwLeaveSchedule.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
		}


		/// <summary>
		/// khởi tạo form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListLeaveSchedule_Load(object sender, EventArgs e)
		{
			Refresh();
			leaveScheduleDO = new LeaveScheduleDO();
			BindingDepartmentCombo();
			cboDepartment.SelectedIndex = 0;
			
			DateTime now = DateTime.Now;
			dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
			dtpTo.Value = DateTime.Today;
			
			PopulateLeaveSchedule();

			this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmRegLeaveSchedule leaveSchedule = new frmRegLeaveSchedule();
			leaveSchedule.ShowDialog(this);
			PopulateLeaveSchedule();
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if(selectedRowIndex >= 0)
			{
				if(dsLeaveSchedule.Tables[0].Rows.Count > 0)
				{
					frmRegLeaveSchedule leaveSchedule = new frmRegLeaveSchedule();
					leaveSchedule.DsLeaveSchedule = dsLeaveSchedule;
					leaveSchedule.CurrentLeaveSchedule = selectedRowIndex;
					leaveSchedule.ShowDialog(this);
					PopulateLeaveSchedule();
				}
				else
				{
					string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2");
					string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2_Title1");
					//MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Sửa đăng ký công tác", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
					MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2_Title1");
				//MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Sửa đăng ký công tác", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2_Title2");
				//MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Xóa đăng ký công tác", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa2_Title2");
				//confirm lại có chắcchắn muốn xóa ko?
				DialogResult dr=MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr ==DialogResult.Yes) 
				{	
					dsLeaveSchedule.Tables[0].Rows[selectedRowIndex].Delete();
					leaveScheduleDO.DeleteLeaveSchedule(dsLeaveSchedule);
					dsLeaveSchedule.AcceptChanges();
					PopulateLeaveSchedule();
				}
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void lvwLeaveSchedule_SelectionChanged(object sender, SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwLeaveSchedule.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}

		private void lvwLeaveSchedule_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if (lvwLeaveSchedule.SelectedItems.Length > 0)
				{
					frmRegLeaveSchedule leaveSchedule = new frmRegLeaveSchedule();
					leaveSchedule.DsLeaveSchedule = dsLeaveSchedule;
					leaveSchedule.CurrentLeaveSchedule = selectedRowIndex;
					leaveSchedule.ShowDialog(this);
					PopulateLeaveSchedule();
				}
				selectedRowIndex = -1;
				tableModel1.Selections.Clear();
			}
		}
		/// <summary>
		/// Hiển thị các phòng ban lên combobox
		/// </summary>
		private void BindingDepartmentCombo()
		{
			DepartmentDO departmentDO = new DepartmentDO();
			DataSet departmentDS = departmentDO.GetAllDepartments();

			cboDepartment.DataSource = departmentDS.Tables[0];
			cboDepartment.ValueMember = "DepartmentID";
			cboDepartment.DisplayMember = "DepartmentName";
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa3");
			//message.Show("Đang xuất dữ liệu bảng đăng ký công tác ra file Excel...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			if (!Utils.ExportExcel(lvwLeaveSchedule,this.Text.ToUpper()))
			{
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa4");
				string str2 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Messa4_Title");
				//MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1,str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			message.Close();
			this.Cursor = Cursors.Default;
		}

	private void cboDepartment_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			PopulateLeaveSchedule();
		}

		private void dtpTo_CloseUp(object sender, System.EventArgs e)
		{
			PopulateLeaveSchedule();
		}

		private void dtpFrom_CloseUp(object sender, System.EventArgs e)
		{
			PopulateLeaveSchedule();
		}

	}
}
