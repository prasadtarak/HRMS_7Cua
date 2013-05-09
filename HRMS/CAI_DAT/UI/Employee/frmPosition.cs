using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmPosition.
	/// </summary>
	public class frmPosition : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPositionShortName;
		private System.Windows.Forms.Label lblPositionShortName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblPositionName;
		private System.Windows.Forms.TextBox txtPositionName;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPosition()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPosition));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPositionShortName = new System.Windows.Forms.TextBox();
			this.lblPositionShortName = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblPositionName = new System.Windows.Forms.Label();
			this.txtPositionName = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtPositionShortName);
			this.groupBox1.Controls.Add(this.lblPositionShortName);
			this.groupBox1.Controls.Add(this.lblDescription);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.lblPositionName);
			this.groupBox1.Controls.Add(this.txtPositionName);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 140);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chức vụ";
			// 
			// txtPositionShortName
			// 
			this.txtPositionShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPositionShortName.Location = new System.Drawing.Point(88, 40);
			this.txtPositionShortName.Name = "txtPositionShortName";
			this.txtPositionShortName.Size = new System.Drawing.Size(112, 20);
			this.txtPositionShortName.TabIndex = 2;
			this.txtPositionShortName.Text = "";
			// 
			// lblPositionShortName
			// 
			this.lblPositionShortName.Location = new System.Drawing.Point(8, 40);
			this.lblPositionShortName.Name = "lblPositionShortName";
			this.lblPositionShortName.Size = new System.Drawing.Size(80, 24);
			this.lblPositionShortName.TabIndex = 40;
			this.lblPositionShortName.Text = "Tên viết tắt";
			this.lblPositionShortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(8, 64);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(80, 24);
			this.lblDescription.TabIndex = 39;
			this.lblDescription.Text = "Mô tả";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(88, 64);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(216, 68);
			this.txtDescription.TabIndex = 3;
			this.txtDescription.Text = "";
			// 
			// lblPositionName
			// 
			this.lblPositionName.Location = new System.Drawing.Point(8, 16);
			this.lblPositionName.Name = "lblPositionName";
			this.lblPositionName.Size = new System.Drawing.Size(73, 24);
			this.lblPositionName.TabIndex = 38;
			this.lblPositionName.Text = "Tên chức vụ";
			this.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPositionName
			// 
			this.txtPositionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPositionName.Location = new System.Drawing.Point(88, 16);
			this.txtPositionName.Name = "txtPositionName";
			this.txtPositionName.Size = new System.Drawing.Size(216, 20);
			this.txtPositionName.TabIndex = 1;
			this.txtPositionName.Text = "";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(240, 156);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 42;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(160, 156);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 41;
			this.btnOK.Text = "&Đồng ý";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmPosition
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(328, 190);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPosition";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý chức vụ";
			this.Load += new System.EventHandler(this.frmPosition_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private DepartmentDO departmentDO = null;
		private DataSet dsPosition = null;
		private DataTable dtPosition = null;
		private int selectedPosition = -1;

		public DataSet PositionDataSet
		{
			set { dsPosition = value; }
		}

		public int SelectedPosition
		{
			set { selectedPosition = value; }
		}


		/// <summary>
		/// Nạp lại dữ liệu trong hàng được chọn hiện tại lên các textbox
		/// </summary>
		private void LoadCurrentPosition()
		{
			DataRow dr = dtPosition.Rows[selectedPosition];
			if (dr != null)
			{
				txtPositionName.Text = dr["PositionName"].ToString();
				txtPositionShortName.Text = dr["PositionShortName"].ToString();
				txtDescription.Text = dr["Description"].ToString();
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (txtPositionName.Text.Trim() == "")
			{
				string str = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Title1");
				//MessageBox.Show("Bạn chưa nhập tên chức vụ!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtPositionShortName.Text.Trim() == "")
			{
				string str = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_Error_Title1");
				//MessageBox.Show("Bạn chưa nhập tên viết tắt!", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (selectedPosition < 0)
			{
				DataRow dr = dtPosition.NewRow();
				
				dr.BeginEdit();
				dr["PositionName"] = txtPositionName.Text.Trim();
				dr["PositionShortName"] = txtPositionShortName.Text.Trim();
				dr["Description"] = txtDescription.Text;
				dr.EndEdit();
				dsPosition.Tables[0].Rows.Add(dr);

				int result = departmentDO.AddPosition(dsPosition);
				if (result == 2) 
				{
					string str = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Messa");
					string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Title");
					//MessageBox.Show("Thêm chức vụ thành công!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
					MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.AcceptChanges();
					this.Close();
				}
				if(result == 1)
				{
					string str = WorkingContext.LangManager.GetString("frmPosition_Add_CanhBao_Messa");
					string str1 = WorkingContext.LangManager.GetString("frmPosition_Add_ThongBao_Title");
					//MessageBox.Show("Chức vụ hoặc tên viết tắt chức vụ đã tồn tại trong hệ thống !", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.RejectChanges();
				}
			}
			else
			{
				DataRow dr = dsPosition.Tables[0].Rows[selectedPosition];
				dr.BeginEdit();
				dr["PositionName"] = txtPositionName.Text.Trim();
				dr["PositionShortName"] = txtPositionShortName.Text.Trim();
				dr["Description"] = txtDescription.Text;
				dr.EndEdit();

				int result = departmentDO.UpdatePosition(dsPosition);
				dsPosition.AcceptChanges();
				if (result ==2 ) 
				{
					string str = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Messa");
					string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Title");
					//MessageBox.Show("Cập nhật chức vụ thành công!", "Cập nhật",MessageBoxButtons.OK, MessageBoxIcon.Information);
					MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.AcceptChanges();
					this.Close();
				}
				if(result == 1)
				{
					string str = WorkingContext.LangManager.GetString("frmPosition_Add_CanhBao_Messa");
					string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_ThongBao_Title");
					//MessageBox.Show("Chức vụ hoặc tên viết tắt chức vụ đã tồn tại trong hệ thống !", "Cập nhật",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					MessageBox.Show(str, str1,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.RejectChanges();
				}
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmPosition_Load(object sender, System.EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			dtPosition = dsPosition.Tables[0];
			if (selectedPosition >= 0)
			{
				string str = WorkingContext.LangManager.GetString("frmPosition_Text3");
				//this.Text = "Sửa thông tin chức vụ";
				this.Text = str;
				LoadCurrentPosition();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmPosition_Text2");
				//this.Text = "Thêm một chức vụ mới";
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
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1");
			this.lblPositionName.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblPositionName");
			this.lblPositionShortName.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblPositionSortName");
			this.lblDescription.Text = WorkingContext.LangManager.GetString("frmPosition_GroupBox1_lblDecription");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmPosition_bntClose");
			this.btnOK.Text = WorkingContext.LangManager.GetString("frmPosition_bntOK");
		}
	}
}
