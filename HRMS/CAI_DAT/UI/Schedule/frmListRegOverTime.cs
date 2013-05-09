using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Events;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// form thong ke danh sach nhan vien lam them gio
	/// </summary>
	public class frmListRegOverTime : Form
	{
		#region Các biến tự định nghĩa
		private DataSet dsRegOverTime = null;
		RegOverTimeDO regOverTimeDO = null;
		private int selectedRowIndex = -1;
		#endregion
		#region Khai báo các control
		private GroupBox groupBox1;
		private Label label1;
		private Button btnAdd;
		private Button btnUpdate;
		private Button btnClose;
		private ComboBox cboDepartment;
		private Button btnView;
		private DateTimePicker dtpWorkingDay;
		private Label lblDepartment;
		private Button btnDelete;
		private ColumnModel columnModel1;
		private TableModel tableModel1;
		private TextColumn chCardID;
		private TextColumn chEmployeeName;
		private TextColumn chDepartment;
		private TextColumn chWorkOverTimeInfo;
		private TextColumn chWorkingDay;
		private Table lvwOverTime;
		private TextColumn chStartOverTime;
		private GroupBox groupBox2;
		private Button btnExcel;
		private TextColumn chLength;
		private Container components = null;
		private NumberColumn cDinnerAmount;
		private NumberColumn cSTT;

		#endregion
		#region Xử lý các sự kiện

		public frmListRegOverTime()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

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
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwOverTime = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cSTT = new XPTable.Models.NumberColumn();
			this.chDepartment = new XPTable.Models.TextColumn();
			this.chCardID = new XPTable.Models.TextColumn();
			this.chEmployeeName = new XPTable.Models.TextColumn();
			this.chStartOverTime = new XPTable.Models.TextColumn();
			this.chLength = new XPTable.Models.TextColumn();
			this.chWorkingDay = new XPTable.Models.TextColumn();
			this.cDinnerAmount = new XPTable.Models.NumberColumn();
			this.chWorkOverTimeInfo = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExcel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwOverTime)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwOverTime);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 432);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách";
			// 
			// lvwOverTime
			// 
			this.lvwOverTime.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwOverTime.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwOverTime.ColumnModel = this.columnModel1;
			this.lvwOverTime.EnableToolTips = true;
			this.lvwOverTime.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwOverTime.FullRowSelect = true;
			this.lvwOverTime.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwOverTime.GridLines = XPTable.Models.GridLines.Both;
			this.lvwOverTime.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwOverTime.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwOverTime.Location = new System.Drawing.Point(8, 16);
			this.lvwOverTime.MultiSelect = true;
			this.lvwOverTime.Name = "lvwOverTime";
			this.lvwOverTime.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwOverTime.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwOverTime.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwOverTime.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwOverTime.Size = new System.Drawing.Size(680, 408);
			this.lvwOverTime.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwOverTime.TabIndex = 12;
			this.lvwOverTime.TableModel = this.tableModel1;
			this.lvwOverTime.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwOverTime.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwOverTime.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwOverTime_SelectionChanged);
			this.lvwOverTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwOverTime_MouseDown);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cSTT,
																			   this.chDepartment,
																			   this.chCardID,
																			   this.chEmployeeName,
																			   this.chStartOverTime,
																			   this.chLength,
																			   this.chWorkingDay,
																			   this.cDinnerAmount,
																			   this.chWorkOverTimeInfo});
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
			this.chCardID.Width = 55;
			// 
			// chEmployeeName
			// 
			this.chEmployeeName.Editable = false;
			this.chEmployeeName.Text = "Tên nhân viên";
			this.chEmployeeName.Width = 130;
			// 
			// chStartOverTime
			// 
			this.chStartOverTime.Editable = false;
			this.chStartOverTime.Text = "Bắt đầu";
			this.chStartOverTime.Width = 70;
			// 
			// chLength
			// 
			this.chLength.Editable = false;
			this.chLength.Text = "Thời gian";
			this.chLength.Width = 70;
			// 
			// chWorkingDay
			// 
			this.chWorkingDay.Editable = false;
			this.chWorkingDay.Text = "Ngày làm thêm";
			this.chWorkingDay.Width = 100;
			// 
			// cDinnerAmount
			// 
			this.cDinnerAmount.Alignment = XPTable.Models.ColumnAlignment.Right;
			this.cDinnerAmount.Editable = false;
			this.cDinnerAmount.Format = "#,##0;(#,##0);-";
			this.cDinnerAmount.Maximum = new System.Decimal(new int[] {
																		  100000,
																		  0,
																		  0,
																		  0});
			this.cDinnerAmount.Text = "Ăn thêm";
			// 
			// chWorkOverTimeInfo
			// 
			this.chWorkOverTimeInfo.Editable = false;
			this.chWorkOverTimeInfo.Text = "Thông tin làm thêm";
			this.chWorkOverTimeInfo.Width = 150;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Location = new System.Drawing.Point(552, 488);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(632, 488);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnView
			// 
			this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnView.Location = new System.Drawing.Point(8, 488);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 3;
			this.btnView.Text = "Xem";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnUpdate.Location = new System.Drawing.Point(472, 488);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(392, 488);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Thêm ";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ngày làm thêm";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpWorkingDay
			// 
			this.dtpWorkingDay.CustomFormat = "dd/MM/yyyy    ";
			this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWorkingDay.Location = new System.Drawing.Point(96, 16);
			this.dtpWorkingDay.Name = "dtpWorkingDay";
			this.dtpWorkingDay.Size = new System.Drawing.Size(88, 20);
			this.dtpWorkingDay.TabIndex = 3;
			// 
			// lblDepartment
			// 
			this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDepartment.Location = new System.Drawing.Point(400, 16);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(64, 23);
			this.lblDepartment.TabIndex = 6;
			this.lblDepartment.Text = "Bộ phận";
			this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboDepartment
			// 
			this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDepartment.Location = new System.Drawing.Point(464, 16);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(224, 21);
			this.cboDepartment.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpWorkingDay);
			this.groupBox2.Controls.Add(this.lblDepartment);
			this.groupBox2.Controls.Add(this.cboDepartment);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(696, 48);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExcel.Location = new System.Drawing.Point(264, 488);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(120, 23);
			this.btnExcel.TabIndex = 9;
			this.btnExcel.Text = "Xuất Excel";
			this.btnExcel.Click += new System.EventHandler(this.ExportExcel_Click);
			// 
			// frmListRegOverTime
			// 
			this.AcceptButton = this.btnView;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(712, 518);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClose);
			this.Name = "frmListRegOverTime";
			this.Text = "Danh sách nhân viên làm thêm giờ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListRegOverTime_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwOverTime)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmRegOverTime regOverTime = new frmRegOverTime();
			regOverTime.DsOverTime = dsRegOverTime;
			regOverTime.ShowDialog(this);
			PopulateOverTime();
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if(selectedRowIndex >= 0)
			{
				frmRegOverTime regOverTime = new frmRegOverTime();
				regOverTime.DsOverTime = dsRegOverTime;
				regOverTime.CurrentOverTime = selectedRowIndex;
				regOverTime.ShowDialog(this);
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmRegOverTime_Edit_messa");
				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime_Edit_Title");
				//MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Sửa thời gian làm thêm giờ", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
			}
			lvwOverTime.Refresh();
			PopulateOverTime();
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void frmListRegOverTime_Load(object sender, EventArgs e)
		{
			Refresh();
			
			regOverTimeDO = new RegOverTimeDO();
			BindingDepartmentCombo();
			dtpWorkingDay.Value	= DateTime.Today;
			cboDepartment.SelectedIndex = 0;
			PopulateOverTime();
			this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
			this.dtpWorkingDay.ValueChanged += new System.EventHandler(this.dtpWorkingDay_ValueChanged);
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			PopulateOverTime();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lvwOverTime.SelectedItems.Length == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Title");
				//MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Xóa đăng ký làm thêm giờ ", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Title");
				//confirm lại có chắc chắn muốn xóa ko?
				DialogResult dr=MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr ==DialogResult.Yes)
				{
					try 
					{
						foreach (Row row in lvwOverTime.SelectedItems) 
						{
							int selectedIndex = (int)row.Tag;
							dsRegOverTime.Tables[0].Rows[selectedIndex].Delete();
						}
						regOverTimeDO.DeleteRegOverTime(dsRegOverTime);
					}
					catch
					{
						string str2 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Messa3");
						string str3 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Title");
						//MessageBox.Show("Có lỗi xảy ra khi xóa đăng ký làm thêm giờ.", "Xóa đăng ký thêm giờ", MessageBoxButtons.OK,  MessageBoxIcon.Error);
						MessageBox.Show(str2, str3, MessageBoxButtons.OK,  MessageBoxIcon.Error);
						return;
					}
					dsRegOverTime.AcceptChanges();
					string str4 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Messa4");
					string str5 = WorkingContext.LangManager.GetString("frmRegOverTime_Del_Title");
					//MessageBox.Show("Xóa đăng ký làm thêm giờ thành công", "Xóa đăng ký thêm giờ", MessageBoxButtons.OK,  MessageBoxIcon.Information);
					MessageBox.Show(str4, str5, MessageBoxButtons.OK,  MessageBoxIcon.Information);
					PopulateOverTime();
				}
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void lvwOverTime_SelectionChanged(object sender, SelectionEventArgs e)
		{
			
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwOverTime.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}

		private void lvwOverTime_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if (lvwOverTime.SelectedItems.Length > 0)
				{
					frmRegOverTime regOverTime = new frmRegOverTime();
					regOverTime.DsOverTime = dsRegOverTime;
					regOverTime.CurrentOverTime = selectedRowIndex;
					regOverTime.ShowDialog(this);
					PopulateOverTime();
				}
				selectedRowIndex = -1;
				tableModel1.Selections.Clear();
			}
		}

		private void dtpWorkingDay_ValueChanged(object sender, EventArgs e)
		{
			PopulateOverTime();
		}

		private void ExportExcel_Click(object sender, EventArgs e)
		{
			
			frmStatusMessage message = new frmStatusMessage();
			string str = WorkingContext.LangManager.GetString("frmRegOverTime_Excell_Messa1");
			//message.Show("Đang xuất dữ liệu bảng đăng ký làm thêm giờ ra file Excel...");
			message.Show(str);
			this.Cursor = Cursors.WaitCursor;
			if (!Utils.ExportExcel(lvwOverTime,this.Text.ToUpper()))
			{
				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime_Excell_Messa2");
				string str2 = WorkingContext.LangManager.GetString("frmRegOverTime_btnExcel");
				//MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra file excel", "Xuất excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str1, str2, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			message.Close();
			this.Cursor = Cursors.Default;
		}
		#endregion
		#region Các hàm xử lý chính
		/// <summary>
		/// Điền danh sách nhân viên làm thêm giờ vào listview
		/// </summary>
		private void PopulateOverTime()
		{
			dsRegOverTime = regOverTimeDO.GetRegOverTime(dtpWorkingDay.Value, (int)cboDepartment.SelectedValue);

			lvwOverTime.BeginUpdate();
			lvwOverTime.TableModel.Rows.Clear();
			DataTable dtRegOverTime = dsRegOverTime.Tables[0];
			int STT = 0;
			foreach (DataRow dr in dtRegOverTime.Rows)
			{
				Cell CardID = new Cell(dr["CardID"].ToString());
				Cell EmployeeName = new Cell(dr["EmployeeName"].ToString());
				Cell DepartmentName = new Cell(dr["DepartmentName"].ToString());
				Cell DinnerAmount;
				if (dr["DinnerAmount"] != DBNull.Value) 
				{
					DinnerAmount = new Cell(Double.Parse(dr["DinnerAmount"].ToString()));
				}
				else
				{
					DinnerAmount = new Cell(0);
				}
				Cell StartOverTime = new Cell(DateTime.Parse(dr["StartOverTime"].ToString()).ToString("HH:mm"));
				Cell Length = new Cell(DateTime.Parse(dr["Length"].ToString()).ToString("HH:mm"));
				Cell WorkingDay = new Cell(DateTime.Parse(dr["WorkingDay"].ToString()).ToString("dd/MM/yyyy"));
				Cell WorkOverTimeInfo = new Cell(dr["WorkOverTimeInfo"].ToString());

				Row row = new Row(new Cell[]{new Cell(STT + 1), DepartmentName, CardID,EmployeeName , StartOverTime, Length, WorkingDay, DinnerAmount, WorkOverTimeInfo});
				row.Tag = STT;
				lvwOverTime.TableModel.Rows.Add(row);

				STT++;
			}
			lvwOverTime.EndUpdate();
          
		}

		
		private void BindingDepartmentCombo()
		{
			DepartmentDO departmentDO = new DepartmentDO();
			DataSet departmentDS = departmentDO.GetAllDepartments();
			cboDepartment.DataSource = departmentDS.Tables[0];
			cboDepartment.ValueMember = "DepartmentID";
			cboDepartment.DisplayMember = "DepartmentName";
		}
		#endregion

		private void cboDepartment_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			PopulateOverTime();
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
			this.Text = WorkingContext.LangManager.GetString("frmRegOverTime_text");
			this.lblDepartment.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lblDepartment");
			this.label1.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lable1");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmRegOverTime_groupbox1");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_STT");
			this.chDepartment.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_BoPhan");
			this.chCardID.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_MaThe");
			this.chEmployeeName.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_TenNV");
			this.chStartOverTime.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_BatDau");
			this.chLength.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_ThoiGian");
			this.chWorkingDay.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_NgayLT");
			this.chWorkOverTimeInfo.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_TTLT");
			this.cDinnerAmount.Text = WorkingContext.LangManager.GetString("frmRegOverTime_lvw_Anthem");
			this.btnView.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnView");
			this.btnExcel.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnExcel");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnAdd");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnEdit");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegOverTime_btnClose");
			this.lvwOverTime.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			
			
			
		}
	}
}
