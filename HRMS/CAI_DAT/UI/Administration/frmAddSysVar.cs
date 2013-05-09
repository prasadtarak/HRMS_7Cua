using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for frmAddSysVar.
	/// </summary>
	public class frmAddSysVar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
        /// <summary>
        /// DataSet nhân viên
        /// </summary>
        private DataSet dsEmployee = null;
        private DataSet dsSalaryHistory = null;
        /// <summary>
        /// Lấy về DataSet nhân viên
        /// </summary>
        public DataSet EmployeeDataSet
        {
            get { return dsEmployee; }
            set { dsEmployee = value; }
        }

        string SysVarname;
		string SysVarDescript;
        string Sys_value;
	    private bool Sys_Modifyable = false;
		AdminDO DOadmin = new AdminDO();
		frmThamsohethong frm;
        private ComboBox cbValue;
        public DateTimePicker dtpTime;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public frmAddSysVar(frmThamsohethong frmThamso, string SysName, string Descript, string Sysvalue, bool Modifyable)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            SysVarname = SysName;
			SysVarDescript = Descript;
            Sys_value = Sysvalue;
            Sys_Modifyable = Modifyable;

			frm = frmThamso;
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "radioButton1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTime);
            this.panel1.Controls.Add(this.cbValue);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 143);
            this.panel1.TabIndex = 1;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(45, 87);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(56, 20);
            this.dtpTime.TabIndex = 8;
            this.dtpTime.Value = new System.DateTime(1900, 1, 1, 8, 0, 0, 0);
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(44, 86);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(240, 21);
            this.cbValue.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(209, 116);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá trị";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mô tả";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(125, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(239, 76);
            this.textBox1.TabIndex = 3;
            // 
            // frmAddSysVar
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(289, 143);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAddSysVar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa tham số hệ thống";
            this.Load += new System.EventHandler(this.frmAddSysVar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void frmAddSysVar_Load(object sender, System.EventArgs e)
		{
		     textBox1.Text  = SysVarDescript;
             if (string.Compare(Sys_value, "true") == 0 || string.Compare(Sys_value,"false")==0)
             {
                 textBox2.Visible = false;
                 dtpTime.Visible = false;
                 cbValue.Visible = true;
                 cbValue.Items.Clear();
                 cbValue.Items.Add("true");
                 cbValue.Items.Add("false");
                 cbValue.Text = Sys_value;
             }
		     else if(string.Compare(SysVarname,"TimeSheetSaturday")==0)
		     {
                 textBox2.Visible = false;
                 dtpTime.Visible = false;
                 cbValue.Visible = true;
                 cbValue.Items.Clear();
                 cbValue.Items.Add("1");
                 cbValue.Items.Add("0.5");
                 cbValue.Text = Sys_value;
		     }
             else if (string.Compare(SysVarname, "StartOverTime") == 0 || string.Compare(SysVarname, "StopOverTime") == 0)
             {
                 textBox2.Visible = false;
                 cbValue.Visible = false;
                 dtpTime.Visible = true;
                 dtpTime.Text = Convert.ToDateTime(Sys_value).ToShortTimeString();
                 //DataTable dtable = new DataTable("value");
                 //dtable.Columns.Add("Value");
                 //dtable.Rows.Add(Sys_value);

                 //dtpTime.DataBindings.Add("Value", dtable, "Value");
             }   
		     else 
             {
                 textBox2.Visible = true;
                 cbValue.Visible = false;
                 dtpTime.Visible = false;
                 textBox2.Text = Sys_value;
                 textBox2.SelectAll();
             }
             if(!Sys_Modifyable)//Ko cho phep sua gia tri
             {
                 textBox2.ReadOnly = true;
                 cbValue.Enabled = false;
                 dtpTime.Enabled = false;
             }
             else
             {
                 textBox2.ReadOnly = false;
                 cbValue.Enabled = true;
                 dtpTime.Enabled = true;
             }
		    textBox1.ReadOnly = true;
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void AddEmployeeHistory()
		{
			// Thay đổi diễn biến lương
            EmployeeDO employeeDO = new EmployeeDO();
			int ret = 0;
			try
			{
			    dsEmployee = employeeDO.GetAllEmployees(1);
			    foreach (DataRow row in dsEmployee.Tables[0].Rows)
			    {
			        int EmployeeID = Convert.ToInt32(row["EmployeeID"].ToString());
                    dsSalaryHistory = employeeDO.GetSalaryHistory(EmployeeID);
                    DataRow dr = dsSalaryHistory.Tables[0].NewRow();
                    dr.BeginEdit();
                    dr["EmployeeID"] = EmployeeID;
                    dr["BasicSalary"] = Convert.ToDouble(row["BasicSalary"].ToString());
                    dr["DecisionNumber"] = "001";
                    dr["Note"] = "Thay Đổi lương công ty !";
                    dr["ModifiedDate"] = DateTime.Now;
                    dr.EndEdit();
                    dsSalaryHistory.Tables[0].Rows.Add(dr);
                    ret = employeeDO.AddSalaryHistory(dsSalaryHistory);
			    }
				
			}
			catch
			{
			}
			if (ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Title1");
				//MessageBox.Show("Không thể thêm thay đổi vào diễn biến lương của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsSalaryHistory.RejectChanges();
			}
			else
			{
				dsSalaryHistory.AcceptChanges();
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			int check = CheckData();
			if(check ==0)
			{
                
                string value = "";
                if (cbValue.Visible)
                    value = cbValue.Text;
                else if (textBox2.Visible)
                    value = textBox2.Text;
                else if (dtpTime.Visible)
                {

                    value = "1900-01-01 " + dtpTime.Value.Hour + ":" + dtpTime.Value.Minute + ":00";
                        
                }

                if (string.Compare(SysVarname, "UpdateBasicSalary") == 0)
                {
                    try
                    {
                        double BasicSalary = Convert.ToDouble(value);
                        EmployeeDO employeeDO = new EmployeeDO();
                        int result = employeeDO.UpdateBasicSalary(BasicSalary);
                        if (result == 1)
                        {
                            AddEmployeeHistory();
                            MessageBox.Show("Cập nhật lương CB thành công !");
                        }
                        else
                            MessageBox.Show("Lỗi hệ thống !");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Giá trị kiểu số !");
                    }
                }
                else if (string.Compare(SysVarname, "UpdateLunchCompany") == 0)
                {
                    try
                    {
                        EmployeeDO employeeDO = new EmployeeDO();
                        int result = employeeDO.UpdateLunchCompany(Convert.ToDouble(value));
                        if (result == 1)
                        {

                            DOadmin.UpdateSysVar(SysVarname, textBox1.Text, value, true);
                            frm.GetSysVar();
                            MessageBox.Show("Cập nhật PC ăn trưa thành công !");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Lỗi hệ thống !");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Giá trị kiểu số !");
                    }
                }
                else
                {
                    DOadmin.UpdateSysVar(SysVarname, textBox1.Text, value, true);
                    frm.GetSysVar();
                    this.Close();
                }
			}
			else if(check == 1)
			{
				MessageBox.Show("Vui lòng nhập vào mô tả","Thông báo");
				textBox1.Focus();
			}
			else
			{
				MessageBox.Show("Vui lòng nhập vào gía trị","Thông báo");
				textBox2.Focus();
			}
		}
		private int CheckData()
		{
			if(textBox1.Text.Trim()== "")
				return 1;
		    if(textBox2.Visible)
			if(textBox2.Text.Trim()== "")
				return 2;
			return 0;
		}
	}
}
