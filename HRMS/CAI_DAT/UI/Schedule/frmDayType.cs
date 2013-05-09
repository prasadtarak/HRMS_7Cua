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
	/// Summary description for frmDayType.
	/// </summary>
	public class frmDayType : System.Windows.Forms.Form
	{
		#region Các biến tự định nghĩa
		private DataSet dsDayType = null;
		private int selectedRowIndex = -1;
		private DataTable dtDayType = null;
		DayTypeDO dayTypeDO = null;

		public DataSet DsDayType
		{
			get { return dsDayType; }
			set { dsDayType = value; }
		}

		public int SelectedRowIndex
		{
			get { return selectedRowIndex; }
			set { selectedRowIndex = value; }
		}

		#endregion 
		
		private System.Windows.Forms.GroupBox groupBox2;
		private AMS.TextBox.NumericTextBox txtFactor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDayShortName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDayName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ColorDialog clrDayColor;
		private System.Windows.Forms.Label lblInsurance;
		private System.Windows.Forms.RadioButton rdoYes;
		private System.Windows.Forms.RadioButton rdoNo;
		private System.Windows.Forms.Label lblInsuranceFactor;
		private System.Windows.Forms.ComboBox cboInsuranceFactor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDayType()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayType));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboInsuranceFactor = new System.Windows.Forms.ComboBox();
            this.lblInsuranceFactor = new System.Windows.Forms.Label();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.txtFactor = new AMS.TextBox.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayShortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.clrDayColor = new System.Windows.Forms.ColorDialog();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboInsuranceFactor);
            this.groupBox2.Controls.Add(this.lblInsuranceFactor);
            this.groupBox2.Controls.Add(this.rdoNo);
            this.groupBox2.Controls.Add(this.rdoYes);
            this.groupBox2.Controls.Add(this.txtFactor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDayShortName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDayName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblInsurance);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 144);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kiểu ngày nghỉ";
            // 
            // cboInsuranceFactor
            // 
            this.cboInsuranceFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsuranceFactor.Enabled = false;
            this.cboInsuranceFactor.Items.AddRange(new object[] {
            "50%",
            "75%",
            "100%"});
            this.cboInsuranceFactor.Location = new System.Drawing.Point(208, 112);
            this.cboInsuranceFactor.Name = "cboInsuranceFactor";
            this.cboInsuranceFactor.Size = new System.Drawing.Size(121, 21);
            this.cboInsuranceFactor.TabIndex = 22;
            // 
            // lblInsuranceFactor
            // 
            this.lblInsuranceFactor.Location = new System.Drawing.Point(8, 112);
            this.lblInsuranceFactor.Name = "lblInsuranceFactor";
            this.lblInsuranceFactor.Size = new System.Drawing.Size(112, 23);
            this.lblInsuranceFactor.TabIndex = 21;
            this.lblInsuranceFactor.Text = "Hệ số trợ cấp BHXH";
            // 
            // rdoNo
            // 
            this.rdoNo.Checked = true;
            this.rdoNo.Location = new System.Drawing.Point(248, 88);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(64, 24);
            this.rdoNo.TabIndex = 20;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "Không";
            // 
            // rdoYes
            // 
            this.rdoYes.Location = new System.Drawing.Point(184, 88);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(48, 24);
            this.rdoYes.TabIndex = 19;
            this.rdoYes.Text = "Có";
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // txtFactor
            // 
            this.txtFactor.AllowNegative = false;
            this.txtFactor.DigitsInGroup = 0;
            this.txtFactor.Flags = 65536;
            this.txtFactor.Location = new System.Drawing.Point(88, 64);
            this.txtFactor.MaxDecimalPlaces = 4;
            this.txtFactor.MaxWholeDigits = 4;
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Prefix = "";
            this.txtFactor.RangeMax = 10;
            this.txtFactor.RangeMin = 0;
            this.txtFactor.Size = new System.Drawing.Size(64, 20);
            this.txtFactor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hệ số ngày";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDayShortName
            // 
            this.txtDayShortName.Location = new System.Drawing.Point(88, 40);
            this.txtDayShortName.Name = "txtDayShortName";
            this.txtDayShortName.Size = new System.Drawing.Size(240, 20);
            this.txtDayShortName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ký hiệu ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDayName
            // 
            this.txtDayName.Location = new System.Drawing.Point(88, 16);
            this.txtDayName.Name = "txtDayName";
            this.txtDayName.Size = new System.Drawing.Size(240, 20);
            this.txtDayName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kiểu ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInsurance
            // 
            this.lblInsurance.Location = new System.Drawing.Point(6, 88);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(100, 23);
            this.lblInsurance.TabIndex = 18;
            this.lblInsurance.Text = "Trợ cấp BHXH";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(192, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(274, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDayType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(354, 192);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Định nghĩa kiểu ngày nghỉ";
            this.Load += new System.EventHandler(this.frmDayType_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
	
		/// <summary>
		/// Chọn màu từ ColorDialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
//		protected void ChooseColor(object sender, EventArgs e)
//		{
//			ColorDialog MyDialog = new ColorDialog();
//			// Keeps the user from selecting a custom color.
//			MyDialog.AllowFullOpen = true;
//			// Allows the user to get help. (The default is false.)
//			MyDialog.ShowHelp = true;
//			// Sets the initial color select to the current text color.
//			MyDialog.Color = lblDayColor.BackColor;
//
//			// Update the text box color if the user clicks OK 
//			if (MyDialog.ShowDialog() == DialogResult.OK)
//			lblDayColor.BackColor = MyDialog.Color;
//		}
		/// <summary>
		/// Lấy dữ liệu vào DataRow dùng để thêm mới hoặc cập nhật
		/// </summary>
		/// <param name="dr"></param>
		/// <returns></returns>
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			dr["DayName"] = txtDayName.Text.Trim();//cắt khoảng trống đầu và cuối
			dr["DayFactor"] = txtFactor.Text.Trim();
			dr["DayShortName"] = txtDayShortName.Text.Trim();
//			if(rdoYes.Checked)
//			{
//				InsuranceCheck = 1;
//			}
//			else
//			{
//				Insuan
//			}
			double InsuranceFactor = 0;
			dr["InsuranceCheck"] = rdoYes.Checked?1:0;
			switch (cboInsuranceFactor.Text)
			{
				case "75%":
					InsuranceFactor = 0.75;
					break;
				case "50%":
					InsuranceFactor = 0.5;
                    break;
				case "100%":
					InsuranceFactor = 1;
					break;
				default:
					InsuranceFactor = 0;
					break;
				
			}
			dr["InsuranceFactor"]= InsuranceFactor;
//			dr["Quantity"] = txtQuantity.Text;
			dr.EndEdit();

			return dr;
		}
		/// <summary>
		/// Thêm mới kiểu ngày
		/// </summary>
		public void AddDayType()
		{
			
			DataRow dr = dtDayType.NewRow();

			dtDayType.Rows.Add(SetData(dr));

			int ret = 0;
			try
			{
				ret = dayTypeDO.AddDayTypeDO(dsDayType);
			}
			catch
			{
			}
			if( ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Messa4");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Title4");
				//MessageBox.Show("Đã tồn tại tên kiểu ngày hoặc ký hiện ngày. Không thể thêm mới kiểu ngày này !", "Lỗi thêm kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsDayType.RejectChanges();
			}
			if (ret == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Add_ThongBao_Title");
				//MessageBox.Show("Đã thêm kiểu ngày thành công.", "Thêm kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsDayType.AcceptChanges();
				this.Close();
			}
			if( ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Title4");
				//MessageBox.Show("Có lỗi xảy ra !", "Lỗi thêm kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsDayType.RejectChanges();
			}
		}
		/// <summary>
		/// Xóa dữ liệu trên các textbox
		/// </summary>
		public void ClearFormData()
		{
			txtFactor.Text = "";
			txtDayName.Text = "";
			txtDayShortName.Text = "";
			
		}
		/// <summary>
		/// Cập nhật kiểu ngày
		/// </summary>
		public void UpdateDayType()
		{
			DataRow dr = dtDayType.Rows[selectedRowIndex];
			dr = SetData(dr);

			int ret = 0;
			try
			{
				ret = dayTypeDO.UpdateDayType(dsDayType);
			}
			catch
			{
			}

			if( ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Sua_Error1");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_UpDate_ThongBao_Title");
				//MessageBox.Show("Đã tồn tại tên kiểu ngày hoặc ký hiện ngày. Không thể cập nhật kiểu ngày này !", "Sửa kiểu ngày nghỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsDayType.RejectChanges();
			}
			if (ret == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_UpDate_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_UpDate_ThongBao_Title");
				//MessageBox.Show("Cập nhật kiểu ngày thành công.", "Sửa kiểu ngày nghỉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsDayType.AcceptChanges();
				this.Close();
			}
			if( ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Sua_Error2");
				string str1 = WorkingContext.LangManager.GetString("frmDayType_UpDate_ThongBao_Title");
				//MessageBox.Show("Có lỗi xảy ra !", "Sửa kiểu ngày nghỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsDayType.RejectChanges();
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private void LoadDayTypeData()
		{
			DataRow dr = dtDayType.Rows[selectedRowIndex];
			if (dr != null)
			{
				txtDayName.Text = dr["DayName"].ToString();
				txtDayShortName.Text = dr["DayShortName"].ToString();
				txtFactor.Text = dr["DayFactor"].ToString();
				if(dr["InsuranceCheck"].ToString().Equals("True"))
				{
					rdoYes.Checked = true;
					rdoNo.Checked = false;
				}
				else
				{
					rdoYes.Checked = false;
					rdoNo.Checked = true;
				}
				cboInsuranceFactor.Text = (float.Parse(dr["InsuranceFactor"].ToString())*100).ToString()+"%";
//				txtQuantity.Text = dr["Quantity"].ToString();
			}
		}
		private string CheckInputData()
		{
			if(txtDayName.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Messa1");
				//return "Chưa nhập tên kiểu ngày";
				return str;
			}
			if(txtDayShortName.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Messa2");
				//return "Chưa nhập ký hiệu ngày";
				return str;
			}
			if(txtFactor.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Messa3");
				//return "Chưa nhập hệ số ngày";
				return str;
			}
			if(txtFactor.Text.StartsWith(",") || txtFactor.Text.StartsWith(".") )
			{
				string str = WorkingContext.LangManager.GetString("Bosung_tool12");
				return str;
			}
				
//			if (int.Parse(txtFactor.Text)> 10)
//			{
//				string str = WorkingContext.LangManager.GetString("Bosung_tool12");
//				//return "Hệ số ngày không được lớn hơn 10";
//				return str;
//			}
			
//			if(txtQuantity.Text == "")
//			{
//				return "Chưa số ngày nghỉ được phép";
//			}
			return "";
				
		}

		private void frmDayType_Load(object sender, System.EventArgs e)
		{
            EVsoft.HRMS.Common.GeneralProcess.StandardFormControl(this);
            Refresh();
			dayTypeDO = new DayTypeDO();
			dtDayType = dsDayType.Tables[0];
			if(selectedRowIndex >= 0)// chế độ sửa, hiển thị lại dữ liệu
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Text2");
				//this.Text = "Sửa kiểu ngày nghỉ";
				this.Text = str;
				LoadDayTypeData();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Text");
				this.Text = str;
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
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2");
			this.label1.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblTenKieuNgay");
			this.label2.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblKyHieuNgay");
			this.label4.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblHeSoNgay");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmDayType_bntClose");
			this.btnSave.Text = WorkingContext.LangManager.GetString("frmDayType_bntSave");
			this.lblInsurance.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblTroCapBHXH");
			this.lblInsuranceFactor.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblHSTroCapBHXH");
			this.rdoNo.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblKhong");
			this.rdoYes.Text = WorkingContext.LangManager.GetString("frmDayType_GroupBox2_lblCo");
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			string errStr = CheckInputData();
			if(errStr != "")
			{
				string str = WorkingContext.LangManager.GetString("frmDayType_Add_Error_Title1");
				//MessageBox.Show(errStr,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(errStr,str,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else 
			{
				if (selectedRowIndex < 0)//chế độ thêm mới
				{
					AddDayType();
				}
				else 
				{
					UpdateDayType();
				}
			}
			
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void rdoYes_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoYes.Checked == true)
			{
				cboInsuranceFactor.Enabled = true;
			}
			else
			{
				cboInsuranceFactor.Enabled = false;
			}

		}
	}
}
