//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	
//Note	    :		  
//Author	: 	
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using XPTable.Models;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmChangeTimeInOut.
	/// </summary>
	public class frmChangeTimeInOut : Form
	{

		private Button btnDelete;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnHelp;
		private EVSoft.HRMS.Controls.DepartmentTreeView departmentTreeView;
		private XPTable.Models.Table lvwTimeInOut;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TableModel tableModel1;
		private MTGCComboBox cboEmployee;
		private XPTable.Models.TextColumn chWorkingDay;
		private XPTable.Models.TextColumn chTimeIn;
		private XPTable.Models.TextColumn chTimeOut;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnModify;
		private XPTable.Models.NumberColumn cSTT;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmployeeName;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public frmChangeTimeInOut()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//


//			tree = new treeDepart(treDepart);
//			tree.Maketree();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChangeTimeInOut));
			this.btnModify = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
			this.lvwTimeInOut = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cSTT = new XPTable.Models.NumberColumn();
			this.chWorkingDay = new XPTable.Models.TextColumn();
			this.chTimeIn = new XPTable.Models.TextColumn();
			this.chTimeOut = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.cboEmployee = new MTGCComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.lvwTimeInOut)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnModify
			// 
			this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModify.Location = new System.Drawing.Point(288, 344);
			this.btnModify.Name = "btnModify";
			this.btnModify.TabIndex = 5;
			this.btnModify.Text = "&Sửa";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Location = new System.Drawing.Point(368, 344);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "&Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(448, 344);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHelp.Location = new System.Drawing.Point(8, 344);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 9;
			this.btnHelp.Text = "Trợ giúp";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(208, 344);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "&Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// departmentTreeView
			// 
			this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.departmentTreeView.DepartmentDataSet = null;
			this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
			this.departmentTreeView.Name = "departmentTreeView";
			this.departmentTreeView.Size = new System.Drawing.Size(176, 300);
			this.departmentTreeView.TabIndex = 8;
			this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
			// 
			// lvwTimeInOut
			// 
			this.lvwTimeInOut.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwTimeInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwTimeInOut.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwTimeInOut.ColumnModel = this.columnModel1;
			this.lvwTimeInOut.EnableToolTips = true;
			this.lvwTimeInOut.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwTimeInOut.FullRowSelect = true;
			this.lvwTimeInOut.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwTimeInOut.GridLines = XPTable.Models.GridLines.Both;
			this.lvwTimeInOut.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwTimeInOut.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwTimeInOut.Location = new System.Drawing.Point(8, 16);
			this.lvwTimeInOut.Name = "lvwTimeInOut";
			this.lvwTimeInOut.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwTimeInOut.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwTimeInOut.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwTimeInOut.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwTimeInOut.Size = new System.Drawing.Size(296, 272);
			this.lvwTimeInOut.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwTimeInOut.TabIndex = 3;
			this.lvwTimeInOut.TableModel = this.tableModel1;
			this.lvwTimeInOut.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwTimeInOut.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwTimeInOut.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwTimeInOut_SelectionChanged);
			this.lvwTimeInOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwTimeInOut_MouseDown);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cSTT,
																			   this.chWorkingDay,
																			   this.chTimeIn,
																			   this.chTimeOut});
			// 
			// cSTT
			// 
			this.cSTT.Editable = false;
			this.cSTT.Text = "STT";
			this.cSTT.Width = 35;
			// 
			// chWorkingDay
			// 
			this.chWorkingDay.Editable = false;
			this.chWorkingDay.Text = "Ngày làm việc";
			this.chWorkingDay.Width = 100;
			// 
			// chTimeIn
			// 
			this.chTimeIn.Editable = false;
			this.chTimeIn.Text = "Giờ vào";
			this.chTimeIn.Width = 70;
			// 
			// chTimeOut
			// 
			this.chTimeOut.Editable = false;
			this.chTimeOut.Text = "Giờ ra";
			// 
			// cboEmployee
			// 
			this.cboEmployee.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
			this.cboEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboEmployee.ColumnNum = 3;
			this.cboEmployee.ColumnWidth = "0;45;115";
			this.cboEmployee.DisplayMember = "Text";
			this.cboEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboEmployee.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.cboEmployee.DropDownForeColor = System.Drawing.Color.Black;
			this.cboEmployee.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
			this.cboEmployee.DropDownWidth = 180;
			this.cboEmployee.GridLineColor = System.Drawing.Color.LightGray;
			this.cboEmployee.GridLineHorizontal = true;
			this.cboEmployee.GridLineVertical = true;
			this.cboEmployee.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.cboEmployee.Location = new System.Drawing.Point(272, 8);
			this.cboEmployee.ManagingFastMouseMoving = true;
			this.cboEmployee.ManagingFastMouseMovingInterval = 30;
			this.cboEmployee.Name = "cboEmployee";
			this.cboEmployee.Size = new System.Drawing.Size(64, 21);
			this.cboEmployee.TabIndex = 1;
			this.cboEmployee.SelectedIndexChanged += new System.EventHandler(this.cboEmployee_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.departmentTreeView);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 328);
			this.groupBox1.TabIndex = 100;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách phòng ban";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.lvwTimeInOut);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(208, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 296);
			this.groupBox2.TabIndex = 101;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin vào ra";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(208, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 102;
			this.label1.Text = "Nhân viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmployeeName.Location = new System.Drawing.Point(336, 8);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.ReadOnly = true;
			this.txtEmployeeName.Size = new System.Drawing.Size(184, 20);
			this.txtEmployeeName.TabIndex = 2;
			this.txtEmployeeName.Text = "";
			// 
			// frmChangeTimeInOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(530, 376);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.cboEmployee);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmChangeTimeInOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý thời gian vào ra";
			this.Load += new System.EventHandler(this.frmChangeTimeInOut_Load);
			((System.ComponentModel.ISupportInitialize)(this.lvwTimeInOut)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion


		private DataSet dsEmployee = null;
		private EmployeeDO employeeDO = null;
		private TimeInOutDO timeInOutDO = null;
		private DataSet dsTimeInOut = null;
		private int selectedRowIndex = -1 ;
		private DateTime fromDate;
		private DateTime toDate;

		public DateTime FromDate
		{
			set { fromDate = value; }
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ToDate
		{
			set { toDate = value; }
		}

		/// <summary>
		/// Điền danh sách thời gian vào ra của từng nhân viên lên listview
		/// </summary>
		private void FillListTimeInOut()
		{
			int emplID = int.Parse(((MTGCComboBoxItem)cboEmployee.SelectedItem).Col1);
			dsTimeInOut = timeInOutDO.GetTimeInOut(emplID,fromDate,toDate);
			lvwTimeInOut.BeginUpdate();
			lvwTimeInOut.TableModel.Rows.Clear();
			int STT = 0;
			foreach (DataRow dr in dsTimeInOut.Tables[0].Rows)
			{
				
				//Điền các dữ liệu ngày làm việc, thời gian vào ra vào list view.
				string WorkingDay = DateTime.Parse(dr["WorkingDay"].ToString()).ToString("dd/MM/yyyy");
				string TimeIn = "";
				if (dr["TimeIn"] != DBNull.Value)
				{
					TimeIn = DateTime.Parse(dr["TimeIn"].ToString()).ToString("HH:mm");
				}
				string TimeOut = "";
				if (dr["TimeOut"] != DBNull.Value)
				{
					TimeOut = DateTime.Parse(dr["TimeOut"].ToString()).ToString("HH:mm");
				}

				Cell[] listTimeInOut = new Cell[4];
				listTimeInOut[0]= new Cell(STT+1);
				listTimeInOut[1]= new Cell(WorkingDay);
				listTimeInOut[2]= new Cell(TimeIn);
				listTimeInOut[3]= new Cell(TimeOut);
				Row row = new Row(listTimeInOut);
				row.Tag = STT;
                //if (dr["ManuallyEdited"].ToString() == "1")
                //{
                //    row.BackColor = System.Drawing.Color.MistyRose; //doi mau nen cua row bi sua du lieu bang tay
                //}
                lvwTimeInOut.TableModel.Rows.Add(row);
				STT ++;
			}

			lvwTimeInOut.EndUpdate();
		}
		/// <summary>
		/// Hiển thị danh sách nhân viên lên combobox khi một phòng ban được chọn
		/// </summary>
		/// <param name="DepartmentID"></param>
		private void PopulateEmployeeCombo(int DepartmentID)
		{
			// DataTable tbEmployee = dsEmployee.Tables["tblEmployee"];
			try
			{
				dsEmployee = employeeDO.GetEmployeeByDepartment(DepartmentID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
						
			cboEmployee.Items.Clear();
			
			if (dsEmployee != null) 
			{
				cboEmployee.SourceDataString = new string[3] {"EmployeeID", "CardID", "EmployeeName"};
				cboEmployee.SourceDataTable = dsEmployee.Tables[0];
			}
			//nếu phòng ban đang chọn có nhân viên thì hiển thị nhân viên đầu tiên lên combobox
			if (dsEmployee.Tables[0].Rows.Count > 0)
			{
				cboEmployee.SelectedIndex = 0;
			}
			else
			{
				cboEmployee.Text = "";
				lvwTimeInOut.TableModel.Rows.Clear();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_CanhBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_CanhBao_Title");
				
				//MessageBox.Show("Bạn chưa chọn thời gian cần xóa!", "Xóa thời gian", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_ThongBao1_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_CanhBao_Title");
				//DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				DialogResult dr = MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					DeleteTimeInOut();
					FillListTimeInOut();
				}
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}
		private void frmChangeTimeInOut_Load(object sender, System.EventArgs e)
		{
			Refresh();
			timeInOutDO = new TimeInOutDO();
			employeeDO = new EmployeeDO();
			DepartmentDO departmentDO = new DepartmentDO();
			departmentTreeView.DepartmentDataSet = departmentDO.GetAllDepartments();
			departmentTreeView.BuildTree();
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;
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
			this.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox2");
			this.label1.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_lblNhanVien");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox2_lvwTimeInOut_STT");
			this.chWorkingDay.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox2_lvwTimeInOut_NgaylamViec");
			this.chTimeIn.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox2_lvwTimeInOut_TimeIn");
			this.chTimeOut.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_GroupBox2_lvwTimeInOut_TimeOut");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntHelp");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntAdd");
			this.btnModify.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntModifile");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmChangeTimeInOut_bntClose");
			
			
		}


		private void departmentTreeView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);
			PopulateEmployeeCombo((int) e.Node.Tag);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cboEmployee_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtEmployeeName.Text = ((MTGCComboBoxItem)cboEmployee.SelectedItem).Col3;
			if(cboEmployee.SelectedIndex >= 0)
			{
				FillListTimeInOut();	
			}
			
		}

		private void lvwTimeInOut_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if(e.NewSelectedIndicies.Length > 0)
			{
				selectedRowIndex = (int)lvwTimeInOut.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string errStr = CheckInput();
			if(errStr != "")
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Messa1");
				//MessageBox.Show(errStr, "Thêm thời gian", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
				MessageBox.Show(errStr, str, MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
			}
			else
			{
				frmAddTimeInOut frm = new frmAddTimeInOut();
				frm.EmployeeId = int.Parse(((MTGCComboBoxItem)cboEmployee.SelectedItem).Col1);
				frm.EmployeeName = (((MTGCComboBoxItem)cboEmployee.SelectedItem).Col3);
				frm.DsTimeInOut = dsTimeInOut;
				frm.ShowDialog();
				FillListTimeInOut();	
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		
		}

		/// <summary>
		/// Xóa thời gian vào ra
		/// </summary>
		public void DeleteTimeInOut()
		{
			
			int ret = 0;
			try
			{
				dsTimeInOut.Tables[0].Rows[selectedRowIndex].Delete();
				ret = timeInOutDO.DeleteTimeInOut(dsTimeInOut);
			}
			catch
			{
				dsTimeInOut.Tables[0].RejectChanges();
			}
			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_ThongBao2_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_ThongBao2_Title");
				//MessageBox.Show("Thông tin đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsTimeInOut.Tables[0].AcceptChanges();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmChangeInOut_Delete_ThongBao2_Title");
				//MessageBox.Show("Không thể xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsTimeInOut.Tables[0].RejectChanges();
			}
		}

		private void btnModify_Click(object sender, System.EventArgs e)
		{
			if(selectedRowIndex < 0)
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Sua_CanhBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmChangeInOut_Sua_CanhBao_Title");
				//MessageBox.Show("Không có thời gian nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				string errStr = CheckInput();
				if(errStr != "")
				{
					string str = WorkingContext.LangManager.GetString("frmChangeInOut_Messa3");
					//MessageBox.Show(errStr, "Sửa thời gian", MessageBoxButtons.OK,  MessageBoxIcon.Information);
					MessageBox.Show(errStr, str, MessageBoxButtons.OK,  MessageBoxIcon.Information);
				}
				else
				{
					frmAddTimeInOut frm = new frmAddTimeInOut();
					frm.EmployeeId = int.Parse(((MTGCComboBoxItem)cboEmployee.SelectedItem).Col1);
					frm.EmployeeName = (((MTGCComboBoxItem)cboEmployee.SelectedItem).Col3);
					frm.DsTimeInOut = dsTimeInOut;
					frm.SelectedRowIndex = selectedRowIndex;
					frm.ShowDialog();
					FillListTimeInOut();
				}
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		/// <summary>
		/// Kiểm tra thông tin Input
		/// </summary>
		/// <returns></returns>
		private string CheckInput()
		{
			if(cboEmployee.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmChangeInOut_Messa4");
				//return "Chưa có nhân viên nào được chọn";
				return str;
			}
			return "";
		}

		private void lvwTimeInOut_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && e.Clicks== 2)
			{
				if(lvwTimeInOut.SelectedIndicies.Length > 0)
				{
					frmAddTimeInOut frm = new frmAddTimeInOut();
					frm.EmployeeId = int.Parse(((MTGCComboBoxItem)cboEmployee.SelectedItem).Col1);
					frm.EmployeeName = (((MTGCComboBoxItem)cboEmployee.SelectedItem).Col3);
					frm.DsTimeInOut = dsTimeInOut;
					frm.SelectedRowIndex = selectedRowIndex;
					frm.ShowDialog();
					FillListTimeInOut();
					selectedRowIndex = -1;
					tableModel1.Selections.Clear();
				}
			}
		}
		
	}

}