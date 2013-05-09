using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for AddTimeInOut.
	/// </summary>
	public class frmAddTimeInOut : System.Windows.Forms.Form
	{
		private int employeeID;
		private string employeeName;
		private DateTime workingDay;
		private DateTime timeIn;
		private DateTime timeOut;
		private DataSet dsTimeInOut = null;
		private TimeInOutDO timeInOutDO = null;
		private int selectedRowIndex = -1;// chế độ thêm mới, >-1 chế độ sửa

		public int SelectedRowIndex
		{
			get { return selectedRowIndex; }
			set { selectedRowIndex = value; }
		}

		public DataSet DsTimeInOut
		{
			get { return dsTimeInOut; }
			set { dsTimeInOut = value; }
		}

		public string EmployeeName
		{
			get { return employeeName; }
			set { employeeName = value; }
		}

		public int EmployeeId
		{
			get { return employeeID; }
			set { employeeID = value; }
		}

		public DateTime WorkingDay
		{
			get { return workingDay; }
			set { workingDay = value; }
		}

		public DateTime TimeIn
		{
			get { return timeIn; }
			set { timeIn = value; }
		}

		public DateTime TimeOut
		{
			get { return timeOut; }
			set { timeOut = value; }
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpTimeIn;
		private System.Windows.Forms.DateTimePicker dtpTimeOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpWorkingDay;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.CheckBox optTimeOut;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmAddTimeInOut()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAddTimeInOut));
			this.label2 = new System.Windows.Forms.Label();
			this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
			this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.optTimeOut = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 90;
			this.label2.Text = "Giờ vào";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpTimeIn
			// 
			this.dtpTimeIn.CustomFormat = "HH:mm";
			this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTimeIn.Location = new System.Drawing.Point(88, 64);
			this.dtpTimeIn.Name = "dtpTimeIn";
			this.dtpTimeIn.ShowUpDown = true;
			this.dtpTimeIn.Size = new System.Drawing.Size(56, 20);
			this.dtpTimeIn.TabIndex = 89;
			this.dtpTimeIn.Value = new System.DateTime(2005, 11, 2, 0, 0, 0, 0);
			// 
			// dtpTimeOut
			// 
			this.dtpTimeOut.CustomFormat = "HH:mm";
			this.dtpTimeOut.Enabled = false;
			this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTimeOut.Location = new System.Drawing.Point(208, 64);
			this.dtpTimeOut.Name = "dtpTimeOut";
			this.dtpTimeOut.ShowUpDown = true;
			this.dtpTimeOut.Size = new System.Drawing.Size(56, 20);
			this.dtpTimeOut.TabIndex = 88;
			this.dtpTimeOut.Value = new System.DateTime(2005, 11, 2, 0, 0, 0, 0);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
			this.label5.Location = new System.Drawing.Point(8, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 86;
			this.label5.Text = "Ngày làm việc";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpWorkingDay
			// 
			this.dtpWorkingDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dtpWorkingDay.CustomFormat = "dd/MM/yyyy";
			this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWorkingDay.Location = new System.Drawing.Point(88, 40);
			this.dtpWorkingDay.Name = "dtpWorkingDay";
			this.dtpWorkingDay.Size = new System.Drawing.Size(176, 20);
			this.dtpWorkingDay.TabIndex = 85;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.optTimeOut);
			this.groupBox1.Controls.Add(this.dtpTimeOut);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpWorkingDay);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtpTimeIn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtEmployeeName);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 96);
			this.groupBox1.TabIndex = 92;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin vào ra";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 93;
			this.label1.Text = "Nhân viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmployeeName.Location = new System.Drawing.Point(88, 16);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.ReadOnly = true;
			this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
			this.txtEmployeeName.TabIndex = 94;
			this.txtEmployeeName.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSave.Location = new System.Drawing.Point(130, 108);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 93;
			this.btnSave.Text = "Ghi";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(210, 108);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 94;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// optTimeOut
			// 
			this.optTimeOut.Location = new System.Drawing.Point(152, 64);
			this.optTimeOut.Name = "optTimeOut";
			this.optTimeOut.Size = new System.Drawing.Size(56, 24);
			this.optTimeOut.TabIndex = 95;
			this.optTimeOut.Text = "Giờ ra";
			this.optTimeOut.CheckedChanged += new System.EventHandler(this.optTimeOut_CheckedChanged);
			// 
			// frmAddTimeInOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(290, 136);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddTimeInOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm thời gian vào ra";
			this.Load += new System.EventHandler(this.frmAddTimeInOut_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			string errMsg = CheckInput();
			if (errMsg != "")
			{
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa3");
				//MessageBox.Show(errMsg, "Lỗi thêm thời gian vào ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(errMsg,str, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else 
			{
				if (selectedRowIndex >= 0)// chế độ sửa
				{
					UpdateTimeInOut();
				}
				else
				{
					AddTimeInOut();
				}
			}
		}
		/// <summary>
		/// Kiểm tra trạng thái của form hiện tại: cập nhật hay thêm mới
		/// </summary>
		private void CheckStatus()
		{
			txtEmployeeName.Text = employeeName;
			if(selectedRowIndex >= 0) //chế độ sửa
			{
				DataRow dr = dsTimeInOut.Tables[0].Rows[selectedRowIndex];
				if (dr != null)
				{
					if (dr["TimeIn"] != DBNull.Value)
					{
						dtpTimeIn.Text= dr["TimeIn"].ToString();
					}
					else
					{
						dtpTimeIn.Text = "08:00";
					}
					if (dr["TimeOut"] != DBNull.Value)
					{
						dtpTimeOut.Text = dr["TimeOut"].ToString();
						optTimeOut.Checked = true;
					}
					else
					{
						dtpTimeOut.Text = "17:00";
						optTimeOut.Checked = false;
					}
					dtpWorkingDay.Text = dr["WorkingDay"].ToString();
				}
				dtpWorkingDay.Enabled = false;
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Text2");
				//this.Text = "Sửa thời gian vào ra";
				this.Text = str1;
			}
			else
			{
				dtpTimeIn.Text = "08:00";
				dtpTimeOut.Text = "17:00";
				optTimeOut.Checked = false;
				//this.Text = "Thêm thời gian vào ra";
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Text");
				this.Text = str;
				
			}
		}

		private void frmAddTimeInOut_Load(object sender, System.EventArgs e)
		{
		Refresh();
			timeInOutDO = new TimeInOutDO();
			CheckStatus();
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
			this.Text = WorkingContext.LangManager.GetString("frmAddInOut_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmAddInOut_GroupBox1");
			this.label1.Text = WorkingContext.LangManager.GetString("frmAddInOut_GroupBox1_lblNhanVien");
			this.label5.Text = WorkingContext.LangManager.GetString("frmAddInOut_GroupBox1_lblNgaylamViec");
			this.label2.Text = WorkingContext.LangManager.GetString("frmAddInOut_GroupBox1_lblTimeIn");
			this.optTimeOut.Text = WorkingContext.LangManager.GetString("frmAddInOut_GroupBox1_lblTimeOut");
			this.btnSave.Text = WorkingContext.LangManager.GetString("frmAddInOut_bntSave");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmAddInOut_bntClose");

		}

		/// <summary>
		/// Kiểm tra dữ liệu đầu vào
		/// </summary>
		/// <returns></returns>
		private string CheckInput()
		{
			if(dtpTimeIn.Value > dtpTimeOut.Value)
			{
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa2");
				//return "Giờ vào phải trước giờ ra";
				return str;
			}
			return "";
		}
		/// <summary>
		/// Thêm thời gian vào ra
		/// </summary>
		private void AddTimeInOut()
		{
			DataRow dr = dsTimeInOut.Tables[0].NewRow();
			dsTimeInOut.Tables[0].Rows.Add(SetData(dr));
			int ret = 0;
			try
			{
				ret = timeInOutDO.AddTimeInOut(dsTimeInOut);
			}
			catch
			{
				ret = 0;
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title");
				string str2 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa3");
				//MessageBox.Show("Có lỗi khi thêm thời gian vào ra ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				
			}

			if(ret == 1)
			{
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title");
				string str2 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa4");
				string str3 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa5");
				
				//MessageBox.Show("Nhân viên "+employeeName+" đã quẹt thẻ rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str2+employeeName+str3, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsTimeInOut.RejectChanges();
			}
			if(ret == 2)
			{
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title");
				string str2 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa4");
				string str3 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa6");
				//MessageBox.Show("Nhân viên "+employeeName+" đã đăng ký công tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str2+employeeName+str3,str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsTimeInOut.RejectChanges();
			}
			if(ret == 3)
			{
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title");
				string str2 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa4");
				string str3 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa7");
				//MessageBox.Show("Nhân viên "+employeeName+" đã đăng ký nghỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str2+employeeName+str3, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsTimeInOut.RejectChanges();
			}
			if (ret == 4)
			{
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Them_ThongBao_Title");
				//MessageBox.Show("Đã thêm thời gian vào ra thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsTimeInOut.AcceptChanges();
				this.Close();
			}
			
		}
		/// <summary>
		/// Lấy dữ liệu phục vụ cho cập nhật hoặc thêm mới
		/// </summary>
		/// <param name="dr"></param>
		/// <returns></returns>
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			if(selectedRowIndex < 0)
			{
				dr["WorkingDay"] = dtpWorkingDay.Value.ToShortDateString();
				dr["EmployeeID"] = employeeID;
			}
			dr["TimeIn"] = dtpTimeIn.Value;
			if (dtpTimeOut.Enabled) 
			{
				dr["TimeOut"] = dtpTimeOut.Value;
			}
			else
			{
				dr["TimeOut"] = DBNull.Value;
			}
			dr.EndEdit();
			return dr;
		}
		/// <summary>
		/// Cập nhật thời gian vào ra
		/// </summary>
		public void UpdateTimeInOut()
		{
			DataRow dr = dsTimeInOut.Tables[0].Rows[selectedRowIndex];
			dr = SetData(dr);
			int ret = 0;
			try
			{
				ret = timeInOutDO.UpdateTimeInOut(dsTimeInOut);
				dsTimeInOut.AcceptChanges();
			}
			catch
			{
			}

			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Title");
				
				//MessageBox.Show("Cập nhật thời gian thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmAddInOut_Sua_ThongBao_Title");
				
				//MessageBox.Show("Không thể sửa đổi thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void optTimeOut_CheckedChanged(object sender, System.EventArgs e)
		{
			dtpTimeOut.Enabled = optTimeOut.Checked;
		}
	}
}

