using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;


namespace EVSoft.HRMS.UI.Schedule
{
	/// <summary>
	/// Summary description for frmContractType.
	/// </summary>
	public class frmContractType : System.Windows.Forms.Form
	{
		private DataSet dsContractType = null;
		private int selectedRowIndex = -1;
		private DataTable dtContractType = null;
		ContractTypeDO contractDO = null;

		public DataSet DsContractType
		{
			get { return dsContractType; }
			set { dsContractType = value; }
		}

		public int SelectedRowIndex
		{
			get { return selectedRowIndex; }
			set { selectedRowIndex = value; }
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtContractName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtNote;
        private CheckBox chkInsurance;
        private Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmContractType()
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkInsurance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtContractName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kiểu hợp đồng";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(104, 161);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(15, 14);
            this.chkInsurance.TabIndex = 8;
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đóng bảo hiểm";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(104, 40);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(240, 112);
            this.txtNote.TabIndex = 5;
            // 
            // txtContractName
            // 
            this.txtContractName.Location = new System.Drawing.Point(104, 16);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(240, 20);
            this.txtContractName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hợp đồng";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(210, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ghi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(288, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmContractType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(370, 232);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContractType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin hợp đồng";
            this.Load += new System.EventHandler(this.frmContractType_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			dr["ContractName"] = txtContractName.Text.Trim();
            dr["InsurancePay"] = chkInsurance.Checked;
			dr["Note"] = txtNote.Text.Trim();
			dr.EndEdit();
			return dr;
		}
		// <summary>
		/// Thêm mới kiểu hợp đồng
		/// </summary>
		public void AddContractType()
		{
			
			DataRow dr = dtContractType.NewRow();

			dtContractType.Rows.Add(SetData(dr));

			int ret = 0;
			try
			{
				ret = contractDO.AddContractTypeDO(dsContractType);
			}
			catch
			{
			}
			if( ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Them_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Them_Title");
				//MessageBox.Show("Đã tồn tại tên kiểu hợp đồng !", "Thêm kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsContractType.RejectChanges();
			}
			if (ret == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Them_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Them_Title");
				//MessageBox.Show("Đã thêm kiểu hợp đồng thành công.", "Thêm kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsContractType.AcceptChanges();
				this.Close();
//				ClearFormData();
			}
			if( ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Them_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Them_Title");
				//MessageBox.Show("Có lỗi xảy ra. Thêm kiểu hợp đồng thất bại !", "Thêm kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsContractType.RejectChanges();
			}
		}
		/// <summary>
		/// Xóa dữ liệu trên các textbox
		/// </summary>
		
		public void ClearFormData()
		{
			//txtContractID.Text = "";
			txtContractName.Text = "";
			txtNote.Text = "";
			
		}

		/// <summary>
		/// Cập nhật kiểu hợp đồng
		/// </summary>
		public void UpdateContractType()
		{
			DataRow dr = dtContractType.Rows[selectedRowIndex];
			dr = SetData(dr);

			int ret = 0;
			try
			{
				ret = contractDO.UpdateContractType(dsContractType);
			}
			catch
			{
			}

			if( ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Update_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Update_Title");
				//MessageBox.Show("Đã tồn tại tên kiểu hợp đồng. Không thể cập nhật kiểu hợp đồng này !", "Cập nhật kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsContractType.RejectChanges();
			}
			if (ret == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Update_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Update_Title");
				//MessageBox.Show("Cập nhật kiểu hợp đồng thành công.", "Cập nhật kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsContractType.AcceptChanges();
				this.Close();
			}
			if( ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Update_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmContract_Update_Title");
				//MessageBox.Show("Có lỗi xảy ra. Cập nhật kiểu hợp đồng thất bại !", "Cập nhật kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				dsContractType.RejectChanges();
			}
		}
		private void LoadContractTypeData()
		{
			DataRow dr = dtContractType.Rows[selectedRowIndex];
			if (dr != null)
			{
//				txtContractID.Text = dr["ContractID"].ToString();
				txtContractName.Text = dr["ContractName"].ToString();
                if (dr["InsurancePay"]!=DBNull.Value)
			        chkInsurance.Checked = bool.Parse(dr["InsurancePay"].ToString());
				txtNote.Text = dr["Note"].ToString();
			}
		}
		private string CheckInputData()
		{
			if(txtContractName.Text.Trim() == "")
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Messa");
				//return "Chưa nhập tên hợp đồng";
				return str;
			}
			return "";
				
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			string errStr = CheckInputData();
			if(errStr != "")
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Messa2");
				//MessageBox.Show(errStr,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(errStr,str,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else 
			{
				if (selectedRowIndex < 0)//chế độ thêm mới
				{
					AddContractType();
				}
				else 
				{
					UpdateContractType();
				}
			}
		}

		private void frmContractType_Load_1(object sender, System.EventArgs e)
		{
			Refresh();
			contractDO = new ContractTypeDO();
			dsContractType = contractDO.GetContractType();
			dtContractType = dsContractType.Tables[0];
			if(selectedRowIndex >= 0)// chế độ sửa, hiển thị lại dữ liệu
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Sua_Title");
				this.Text = str;
				//this.Text = "Sửa kiểu hợp đồng";
				LoadContractTypeData();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmContract_Text");
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
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmContract_groupbox1");
			this.label2.Text = WorkingContext.LangManager.GetString("frmContract_lable2");
			this.label3.Text = WorkingContext.LangManager.GetString("frmContract_lable3");
			this.btnSave.Text = WorkingContext.LangManager.GetString("frmContract_btnSave");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmContract_btnClose");
			
		}




	}
}
