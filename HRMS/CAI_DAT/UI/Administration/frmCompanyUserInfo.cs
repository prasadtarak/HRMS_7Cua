using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
//

namespace EVSoft.Ketoan.User_Interface.He_thong
{
	/// <summary>
	/// Summary description for frmCompanyUserInfo.
	/// </summary>
	public class frmCompanyUserInfo : Form
	{
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		private Button btnCancel;
		private DateTimePicker dtFoundedDay;
		private TextBox txtCompanyName;
		private TextBox txtTaxCode;
		private TextBox txtAddress;
		private TextBox txtDistrict;
		private TextBox txtCity;
		private TextBox txtCountry;
		private TextBox txtBankAccount;
		private TextBox txtBankName;
		private TextBox txtTel;
		private TextBox txtFax;
		private TextBox txtEmail;
		private TextBox txtWeb;
		private Button btnAccept;
		private TextBox txtNote;
		private Label label15;
        private TextBox txtHealthInsuranceID;
        private TextBox txtCompanyCode;
        private Label label14;
        private Label label16;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public frmCompanyUserInfo()
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtFoundedDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtHealthInsuranceID = new System.Windows.Forms.TextBox();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công ty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ trụ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quận / huyện";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(260, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tỉnh / Thành phố";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đất nước";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày thành lập";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tại ngân hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số tài khoản";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã số thuế";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(260, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Website";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(260, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Số Fax";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHealthInsuranceID);
            this.groupBox1.Controls.Add(this.txtCompanyCode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtTaxCode);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 154);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(104, 106);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(154, 20);
            this.txtCountry.TabIndex = 24;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(358, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 20);
            this.txtCity.TabIndex = 23;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(104, 84);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(154, 20);
            this.txtDistrict.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(408, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(104, 40);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(154, 20);
            this.txtTaxCode.TabIndex = 20;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(104, 18);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(408, 20);
            this.txtCompanyName.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtBankName);
            this.groupBox2.Controls.Add(this.txtBankAccount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(2, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 62);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngân hàng";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(104, 40);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(408, 20);
            this.txtBankName.TabIndex = 21;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Location = new System.Drawing.Point(104, 18);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(408, 20);
            this.txtBankAccount.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtWeb);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtFax);
            this.groupBox3.Controls.Add(this.txtTel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(2, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 64);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin liên hệ";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(358, 40);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(154, 20);
            this.txtWeb.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(358, 18);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(154, 20);
            this.txtFax.TabIndex = 26;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(104, 18);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(154, 20);
            this.txtTel.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtNote);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.dtFoundedDay);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(2, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 100);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khác";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(104, 40);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(408, 56);
            this.txtNote.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Ghi chú";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFoundedDay
            // 
            this.dtFoundedDay.CustomFormat = "dd/MM/yyyy";
            this.dtFoundedDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFoundedDay.Location = new System.Drawing.Point(104, 18);
            this.dtFoundedDay.Name = "dtFoundedDay";
            this.dtFoundedDay.Size = new System.Drawing.Size(154, 20);
            this.dtFoundedDay.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnAccept);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(2, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 50);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(318, 18);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(116, 26);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Thay đổi thông tin";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(436, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHealthInsuranceID
            // 
            this.txtHealthInsuranceID.Location = new System.Drawing.Point(358, 128);
            this.txtHealthInsuranceID.Name = "txtHealthInsuranceID";
            this.txtHealthInsuranceID.Size = new System.Drawing.Size(154, 20);
            this.txtHealthInsuranceID.TabIndex = 28;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(104, 128);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(154, 20);
            this.txtCompanyCode.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Mã đơn vị";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(260, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Mã thẻ BHYT";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCompanyUserInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 449);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCompanyUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đơn vị sử dụng";
            this.Load += new System.EventHandler(this.frmCompanyUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		//private SystemDataConnect Sysconnect = new SystemDataConnect();
		private void frmCompanyUserInfo_Load(object sender, EventArgs e)
		{
            CompanyDO companyDO = new CompanyDO();
            DataSet dsCompany = companyDO.GetCompanyInfo();

            if (dsCompany.Tables[0].Rows.Count == 0)
				return;
            DataRow row = dsCompany.Tables[0].Rows[0];
			txtCompanyName.Text = row["Name"].ToString();
			txtAddress.Text = row["Address"].ToString();
			txtDistrict.Text = row["District"].ToString();
			txtCity.Text = row["City"].ToString();
			txtCountry.Text = row["Country"].ToString();
			txtTaxCode.Text = row["TaxCode"].ToString();
            txtBankAccount.Text = row["BankAccount"].ToString();
            txtBankName.Text = row["BankName"].ToString();
			txtTel.Text = row["Tel"].ToString();
			txtFax.Text = row["Fax"].ToString();
			txtEmail.Text = row["Email"].ToString();
			txtWeb.Text = row["Website"].ToString();
            dtFoundedDay.Value = DateTime.Parse(row["FoundedDay"].ToString());
			txtNote.Text = row["Note"].ToString();
            txtCompanyCode.Text = row["CompanyCode"].ToString();
            txtHealthInsuranceID.Text = row["HealthInsuranceID"].ToString();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			string Name = txtCompanyName.Text;
			string Address = txtAddress.Text;
			string District = txtDistrict.Text;
			string City = txtCity.Text;
			string Country = txtCountry.Text;
			string TaxCode = txtTaxCode.Text;
			string BankName = txtBankName.Text;
			string BankAccount = txtBankAccount.Text;
			string Tel = txtTel.Text;
			string Fax = txtFax.Text;
			string Email = txtEmail.Text;
			string Website = txtWeb.Text;
			DateTime FoundedDay = dtFoundedDay.Value;
			string Note = txtNote.Text;
            string companycode = txtCompanyCode.Text;
            string healthInsuranceID = txtHealthInsuranceID.Text;
            CompanyDO companyDO = new CompanyDO();
            int result = 0;
                try
                {
                    result=companyDO.UpdateDefaultCompanyInfo(Name, Address, City, Country, Tel, Fax, Email, District, Website, TaxCode, BankName, BankAccount, FoundedDay, Note, healthInsuranceID, companycode);
                }
		        catch(Exception ex)
		        {
                    MessageBox.Show("Lỗi cập nhật CSDL !", "Thông báo");
		        }
		    if(result==1)
                MessageBox.Show("Cập nhật thành công !", "Thông báo");
			this.Close();
		}
	}
}
