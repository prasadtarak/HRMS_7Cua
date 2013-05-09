using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Form đăng ký lịch công tác
	/// </summary>
	public class frmRegLeaveSchedule : Form
	{
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button btnOK;
		private Label label6;
		private Button btnClose;
		private Button btnHelp;
		private TextBox txtWorkInfo;
		private DateTimePicker dtpEndLeave;
		private DateTimePicker dtpStartLeave;
		private TextBox txtLeaveLocation;

		private Container components = null;
		private DepartmentTreeView departmentTreeView;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private MTGCComboBox cboEmployeeName;
		private System.Windows.Forms.TextBox txtEmployeeName;

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

		public frmRegLeaveSchedule()
		{
			InitializeComponent();


		}

		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRegLeaveSchedule));
			this.dtpEndLeave = new System.Windows.Forms.DateTimePicker();
			this.dtpStartLeave = new System.Windows.Forms.DateTimePicker();
			this.txtWorkInfo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLeaveLocation = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
			this.cboEmployeeName = new MTGCComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpEndLeave
			// 
			this.dtpEndLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dtpEndLeave.CustomFormat = "dd/MM/yyyy";
			this.dtpEndLeave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndLeave.Location = new System.Drawing.Point(96, 64);
			this.dtpEndLeave.Name = "dtpEndLeave";
			this.dtpEndLeave.Size = new System.Drawing.Size(208, 20);
			this.dtpEndLeave.TabIndex = 4;
			// 
			// dtpStartLeave
			// 
			this.dtpStartLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dtpStartLeave.CustomFormat = "dd/MM/yyyy";
			this.dtpStartLeave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartLeave.Location = new System.Drawing.Point(96, 40);
			this.dtpStartLeave.Name = "dtpStartLeave";
			this.dtpStartLeave.Size = new System.Drawing.Size(208, 20);
			this.dtpStartLeave.TabIndex = 3;
			// 
			// txtWorkInfo
			// 
			this.txtWorkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtWorkInfo.Location = new System.Drawing.Point(8, 136);
			this.txtWorkInfo.Multiline = true;
			this.txtWorkInfo.Name = "txtWorkInfo";
			this.txtWorkInfo.Size = new System.Drawing.Size(294, 174);
			this.txtWorkInfo.TabIndex = 6;
			this.txtWorkInfo.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 112);
			this.label5.Name = "label5";
			this.label5.TabIndex = 22;
			this.label5.Text = "Nội dung công việc";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtLeaveLocation
			// 
			this.txtLeaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtLeaveLocation.Location = new System.Drawing.Point(96, 88);
			this.txtLeaveLocation.Name = "txtLeaveLocation";
			this.txtLeaveLocation.Size = new System.Drawing.Size(208, 20);
			this.txtLeaveLocation.TabIndex = 5;
			this.txtLeaveLocation.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Nơi công tác";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Kết thúc";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Bắt đầu";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(384, 336);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "Đồng ý";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(464, 336);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "Tên nhân viên";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHelp.Location = new System.Drawing.Point(8, 336);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 68;
			this.btnHelp.Text = "Trợ giúp";
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// departmentTreeView
			// 
			this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.departmentTreeView.DepartmentDataSet = null;
			this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
			this.departmentTreeView.Name = "departmentTreeView";
			this.departmentTreeView.Size = new System.Drawing.Size(200, 294);
			this.departmentTreeView.TabIndex = 9;
			this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
			// 
			// cboEmployeeName
			// 
			this.cboEmployeeName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
			this.cboEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboEmployeeName.ColumnNum = 3;
			this.cboEmployeeName.ColumnWidth = "0;50;120";
			this.cboEmployeeName.DisplayMember = "Text";
			this.cboEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboEmployeeName.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.cboEmployeeName.DropDownForeColor = System.Drawing.Color.Black;
			this.cboEmployeeName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
			this.cboEmployeeName.DropDownWidth = 200;
			this.cboEmployeeName.GridLineColor = System.Drawing.Color.LightGray;
			this.cboEmployeeName.GridLineHorizontal = true;
			this.cboEmployeeName.GridLineVertical = true;
			this.cboEmployeeName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.cboEmployeeName.Location = new System.Drawing.Point(96, 16);
			this.cboEmployeeName.ManagingFastMouseMoving = true;
			this.cboEmployeeName.ManagingFastMouseMovingInterval = 30;
			this.cboEmployeeName.Name = "cboEmployeeName";
			this.cboEmployeeName.Size = new System.Drawing.Size(64, 21);
			this.cboEmployeeName.TabIndex = 1;
			this.cboEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cboEmployeeName_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtEmployeeName);
			this.groupBox1.Controls.Add(this.dtpEndLeave);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtpStartLeave);
			this.groupBox1.Controls.Add(this.txtWorkInfo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtLeaveLocation);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cboEmployeeName);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(232, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 318);
			this.groupBox1.TabIndex = 82;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmployeeName.Location = new System.Drawing.Point(160, 16);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.ReadOnly = true;
			this.txtEmployeeName.Size = new System.Drawing.Size(144, 20);
			this.txtEmployeeName.TabIndex = 2;
			this.txtEmployeeName.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.departmentTreeView);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 318);
			this.groupBox2.TabIndex = 83;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách phòng ban";
			// 
			// frmRegLeaveSchedule
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(552, 366);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegLeaveSchedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Đăng ký lịch công tác";
			this.Load += new System.EventHandler(this.frmRegLeaveSchedule_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#region Variables
        
		private EmployeeDO employeeDO = null;
		private DataSet dsEmployee = null;
		private DataSet dsLeaveSchedule = null;
		private DepartmentDO departnemtDO = null;
		private LeaveScheduleDO leaveScheduleDO = null;
		private DataRow dr = null;
		/// <summary>
		/// 
		/// </summary>
		private int selectedLeaveSchedule = -1; // vi tri' cua row hien tai
		public DataSet DsLeaveSchedule
		{
			get { return dsLeaveSchedule; }
			set { dsLeaveSchedule = value; }
		}

		public int CurrentLeaveSchedule
		{
			get { return selectedLeaveSchedule; }
			set { selectedLeaveSchedule = value; }
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		public void RegLeaveSchedule()
		{
			int ret = 0;
			if (selectedLeaveSchedule >= 0)
			{
				DataRow dr = dsLeaveSchedule.Tables[0].Rows[selectedLeaveSchedule];
				dr = SetData(dr);
				ret = leaveScheduleDO.UpdateLeaveSchedule(dsLeaveSchedule);
			}
			else
			{
				dr = dsLeaveSchedule.Tables[0].NewRow();
				dsLeaveSchedule.Tables[0].Rows.Add(SetData(dr));
				ret = leaveScheduleDO.AddLeaveSchedule(dsLeaveSchedule);
			}
			if (ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_DK_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//MessageBox.Show("Đăng ký công tác cho nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsLeaveSchedule.AcceptChanges();
			}
			else if (ret == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_DK_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//MessageBox.Show("Ngày đăng ký trùng với ngày nghỉ đã đăng ký trước đây của nhân viên. Không thể cập nhật đăng ký công tác cho nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsLeaveSchedule.RejectChanges();
			}
			else if (ret == 3)
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_DK_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//MessageBox.Show("Ngày đăng ký trùng với ngày công tác đã đăng ký trước đây của nhân viên. Không thể cập nhật đăng ký công tác cho nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsLeaveSchedule.RejectChanges();
			}
			else if (ret == 4)
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_DK_Messa4");
				string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//MessageBox.Show("Nhân viên này có đi làm (quẹt thẻ) trong khoảng thời gian đăng ký. Không thể cập nhật đăng ký công tác cho nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsLeaveSchedule.RejectChanges();
			}
		}

		/// <summary>
		/// Thiết lập dữ liệu DataSet (dùng chung cho AddLeaveSchedule va` UpdateLeaveSchedule)
		/// </summary>
		/// <param name="dr"></param>
		/// <returns></returns>
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			if (selectedLeaveSchedule < 0) //che do them moi
			{
				dr["EmployeeID"] = ((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col1;
			}
			dr["LeaveLocation"] = txtLeaveLocation.Text;
			dr["WorkInfo"] = txtWorkInfo.Text;
			dr["StartLeave"] = dtpStartLeave.Value.ToShortDateString();
			dr["EndLeave"] = dtpEndLeave.Value.Date.ToShortDateString();
			dr.EndEdit();
			return dr;
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadLeaveSchedule()
		{
			DataRow dr = dsLeaveSchedule.Tables[0].Rows[selectedLeaveSchedule];
			if (dr != null)
			{
				cboEmployeeName.Text = dr["CardID"].ToString();
				dtpStartLeave.Value = DateTime.Parse(dr["StartLeave"].ToString());
				dtpEndLeave.Value = DateTime.Parse(dr["EndLeave"].ToString());
				txtLeaveLocation.Text = dr["LeaveLocation"].ToString();
				txtWorkInfo.Text = dr["WorkInfo"].ToString();
			}
		}

		/// <summary>
		/// Kiểm tra dữ liệu đầu vào
		/// </summary>
		/// <returns>Thông báo lỗi</returns>
		private string ValidateInputData()
		{
			if (cboEmployeeName.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa1");
				//string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
				//return "Bạn phải chọn một nhân viên ! ";
				return str;
			}

			if (txtLeaveLocation.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa2");
				//string str1 = WorkingContext.LangManager.GetString("");
				//return "Bạn chưa nhập nơi công tác !";
				return str;
			}

			if (dtpStartLeave.Value.Date > dtpEndLeave.Value.Date)
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa3");
				//string str1 = WorkingContext.LangManager.GetString("");
				//return "Ngày không hợp lệ, ngày bắt đầu phải trước ngày kết thúc!";
				return str;
			}
			return "";
		}

		#region Windows Form event handlers

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa4");
			string str1 = WorkingContext.LangManager.GetString("frmListLeaveSchedule_Thongbao_Title");
			//MessageBox.Show("Chức năng này đang được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string errMsg = ValidateInputData();
			if (errMsg != "")
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa5");
				//string str1 = WorkingContext.LangManager.GetString("");
				//MessageBox.Show(errMsg, "Lỗi đăng ký công tác cho nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(errMsg, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				RegLeaveSchedule();
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
			this.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_groupbox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_groupbox2");
			this.label2.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_lable2");
			this.label3.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_lable3");
			this.label4.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_lable4");
			this.label5.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_lable5");
			this.label6.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_lable6");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_btnClose");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_btnhelp");
			this.btnOK.Text = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_btnOK");
			
		}
		private void frmRegLeaveSchedule_Load(object sender, EventArgs e)
		{
			Refresh();
			employeeDO = new EmployeeDO();

			departnemtDO = new DepartmentDO();
			departmentTreeView.DepartmentDataSet = departnemtDO.GetAllDepartments();
			departmentTreeView.BuildTree();
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;
			departmentTreeView.ExpandNodes(true);

			leaveScheduleDO = new LeaveScheduleDO();

			if (selectedLeaveSchedule >= 0)
			{
				// disable các thuộc tính liên quan đến nhân viên
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Text2");
				this.Text = str;
				//this.Text = "Sửa đăng ký công tác";
				LoadLeaveSchedule();
				cboEmployeeName.Enabled = false;
				departmentTreeView.Enabled = false;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Text");
				this.Text = str;
				dsLeaveSchedule = leaveScheduleDO.getLeaveSchedule();
			}

		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);

			cboEmployeeName.Items.Clear();
			dsEmployee = employeeDO.GetEmployeeByDepartment((int) e.Node.Tag);
			cboEmployeeName.SourceDataString = new string[] {"EmployeeID", "CardID", "EmployeeName"};
			cboEmployeeName.SourceDataTable = dsEmployee.Tables[0];
			// kiểm tra nếu phòng có nhân viên thì hiển thị thông tin của nhân viên đầu tiên
			if (dsEmployee.Tables[0].Rows.Count > 0)
			{
				cboEmployeeName.SelectedIndex = 0;
			}
			else
			{
				cboEmployeeName.Items.Clear();
				cboEmployeeName.Text = "";
			}
		}

		#endregion

		private void cboEmployeeName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtEmployeeName.Text = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3;
		}
	}
}