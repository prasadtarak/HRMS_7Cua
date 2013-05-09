using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmDepartment.
	/// </summary>
	public class frmDepartment : Form
	{
		private GroupBox groupBox2;
		private Label lblDepartmentName;
		private TextBox txtDepartmentName;
		private TextBox txtDescription;
		private Button btnOK;
		private Button btnClose;
		private System.Windows.Forms.Label lblDescription;
        private Label label1;
        private TextBox txtSort;
        private Label label2;
        private MTGCComboBox cboGroup;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public frmDepartment()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboGroup = new MTGCComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboGroup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSort);
            this.groupBox2.Controls.Add(this.lblDepartmentName);
            this.groupBox2.Controls.Add(this.txtDepartmentName);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 198);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng ban";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Thứ tự ưu tiên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSort
            // 
            this.txtSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSort.Location = new System.Drawing.Point(88, 137);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(210, 20);
            this.txtSort.TabIndex = 51;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartmentName.Location = new System.Drawing.Point(8, 16);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(80, 23);
            this.lblDepartmentName.TabIndex = 47;
            this.lblDepartmentName.Text = "Tên phòng";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDepartmentName.Location = new System.Drawing.Point(88, 16);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(210, 20);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDescription.Location = new System.Drawing.Point(8, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 23);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Mô tả";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDescription.Location = new System.Drawing.Point(88, 40);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 93);
            this.txtDescription.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(156, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(236, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboGroup
            // 
            this.cboGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboGroup.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboGroup.ColumnNum = 2;
            this.cboGroup.ColumnWidth = "0;220";
            this.cboGroup.DisplayMember = "Text";
            this.cboGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGroup.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboGroup.DropDownForeColor = System.Drawing.Color.Black;
            this.cboGroup.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboGroup.DropDownWidth = 120;
            this.cboGroup.GridLineColor = System.Drawing.Color.LightGray;
            this.cboGroup.GridLineHorizontal = true;
            this.cboGroup.GridLineVertical = false;
            this.cboGroup.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboGroup.Location = new System.Drawing.Point(88, 162);
            this.cboGroup.ManagingFastMouseMoving = true;
            this.cboGroup.ManagingFastMouseMovingInterval = 30;
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(210, 21);
            this.cboGroup.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nhóm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDepartment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(322, 242);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phòng ban";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private DepartmentDO departmentDO = null;

		/// <summary>
		/// 
		/// </summary>
		public int DepartmentID;
		public int SortIndex;
		public int GroupID;

		/// <summary>
		/// 
		/// </summary>
		public string DepartmentName;

		/// <summary>
		/// public
		/// </summary>
		public string Description;

		/// <summary>
		/// Thêm một phòng ban mới vào cây phòng ban
		/// </summary>
		private void AddNewDepartment()
		{
            int result = departmentDO.AddDepartment(txtDepartmentName.Text.Trim(), txtDescription.Text, DepartmentID, SortIndex, Convert.ToInt32(((MTGCComboBoxItem)cboGroup.SelectedItem).Col1));
			string str1 = WorkingContext.LangManager.GetString("frmDepartment_Add_ThongBao_Title");
			if (result == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmDepartment_Add_ThongBao_Messa");

				//MessageBox.Show("Thêm phòng thành công!", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			if(result == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmDepartment_Add_Error_Messa2");
				//MessageBox.Show("Phòng ban này đã tồn tại trong cơ sở dữ liệu!", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Cập nhật một phòng ban
		/// </summary>
		private void UpdateDepartment()
		{
			//update in database
            int result = departmentDO.UpdateDepartmentInfo(DepartmentID, txtDepartmentName.Text.Trim(), txtDescription.Text, SortIndex, Convert.ToInt32(((MTGCComboBoxItem)cboGroup.SelectedItem).Col1));

			if (result == 2)
			{
				string str = WorkingContext.LangManager.GetString("frmDepartment_UpDate_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDepartment_UpDate_ThongBao_Title");
				//MessageBox.Show("Cập nhật phòng ban thành công!", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			if(result == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmDep_CapNhat_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmDepartment_UpDate_ThongBao_Title");
				//MessageBox.Show("Phòng ban này đã tồn tại trong hệ thống!", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool IsValidated()
		{
			if (txtDepartmentName.Text.Trim().Equals(""))
			{
				string str = WorkingContext.LangManager.GetString("frmDepartment_Add_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmDepartment_UpDate_ThongBao_Title");

				//MessageBox.Show("Bạn chưa nhập tên phòng ban!", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str,str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
            if (!txtSort.Text.Trim().Equals(""))
            {
                try
                {
                    if (Convert.ToInt32(txtSort.Text) > 0)
                        SortIndex = Convert.ToInt32(txtSort.Text);
                    else
                    {
                        MessageBox.Show("Thứ tự ưu tiên > 0!", "Cập nhật nhân viên", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Thứ tự ưu tiên là kiểu số > 0!", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else SortIndex = 1;
			return true;
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
			this.Text = WorkingContext.LangManager.GetString("frmDepartment_Text1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmDepartment_GroupBox2");
			this.lblDepartmentName.Text = WorkingContext.LangManager.GetString("frmDepartment_GroupBox2_lblDepartmentName");
			this.lblDescription.Text = WorkingContext.LangManager.GetString("frmDepartment_GroupBox2_lblDecription");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmDepartment_bntClose");
			this.btnOK.Text = WorkingContext.LangManager.GetString("frmDepartment_bntOK");
		}


		private void frmDepartment_Load(object sender, EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
            DataSet dsDepartmentGroup = new DataSet();
            dsDepartmentGroup = departmentDO.GetAllGroupDepartments();
            if (dsDepartmentGroup != null)
            {
                cboGroup.SourceDataString = new string[] { "GroupID", "GroupName" };
                cboGroup.SourceDataTable = dsDepartmentGroup.Tables[0];
                cboGroup.SelectedIndex = 0;
            }
			if (DepartmentName != "")
			{
				
				string str = WorkingContext.LangManager.GetString("frmDep_Text1");
				//this.Text = "Sửa thông tin phòng ban";
				this.Text = str;
				txtDepartmentName.Text = DepartmentName;
				txtDescription.Text = Description;
                if (SortIndex > 0)
                    txtSort.Text = SortIndex.ToString();
                else
                {
                    txtSort.Text = "1";
                    SortIndex = 1;
                }
			    
                DataSet dsGroupName = departmentDO.GetGroupDepartments(GroupID);
                if (dsGroupName != null)
                    cboGroup.Text = dsGroupName.Tables[0].Rows[0]["GroupName"].ToString();
			    
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmDep_Text2");
				//this.Text = "Thêm một phòng ban mới";
				this.Text = str;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (IsValidated())
			{
                //SortIndex = Convert.ToInt32(txtSort.Text);
				if (DepartmentName != "") //Cập nhật thông tin phòng ban
				{
					UpdateDepartment();
				}
				else //Thêm nphòng ban mới
				{
					AddNewDepartment();
					txtDepartmentName.Text = String.Empty;
					txtDescription.Text = String.Empty;
                    txtSort.Text = String.Empty;
				}
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}