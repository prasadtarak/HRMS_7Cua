using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmCard.
	/// </summary>
	public class frmPunish : Form
	{
		
		#region Các biến tự định nghĩa
		private DepartmentDO departmentDO = null;
		private EmployeeDO employeeDO = null;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsEmployee = null;
		private DataSet dsPunish = null;
		private PunishDO punishD0 = null;
		private PunishCardDO punishCardDO = null;
		private DataSet dsPunishCardDO = null;
		private DataTable dtPunish = null;

		private int selectedPunish = - 1;

		public DataSet DSPunish
		{
			get{ return dsPunish;}
			set { dsPunish = value;}
		}
		public int CurrentPunish
		{
			get{ return selectedPunish;}
			set{ selectedPunish = value;}
		}
		#endregion
		#region Các biến tự gen
		private Button btnClose;
		private Button btnHelp;
		private GroupBox groupBox2;
		private MTGCComboBox cboEmployeeName;
		private Label label2;
		private Label label6;
		private Label label5;
		private Button btnSave;
		private GroupBox groupBox1;
		private DepartmentTreeView departmentTreeView;
		private TextBox txtReason;
		private DateTimePicker dtpWorkingDay;
		private MTGCComboBox cboPunishCard;
		private Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPunish));
			this.btnClose = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboPunishCard = new MTGCComboBox();
			this.cboEmployeeName = new MTGCComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(424, 328);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHelp.Location = new System.Drawing.Point(8, 328);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 81;
			this.btnHelp.Text = "Trợ giúp";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboPunishCard);
			this.groupBox2.Controls.Add(this.cboEmployeeName);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.dtpWorkingDay);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtReason);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(224, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 312);
			this.groupBox2.TabIndex = 83;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin phạt";
			// 
			// cboPunishCard
			// 
			this.cboPunishCard.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
			this.cboPunishCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboPunishCard.ColumnNum = 2;
			this.cboPunishCard.ColumnWidth = "30;80";
			this.cboPunishCard.DisplayMember = "Text";
			this.cboPunishCard.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboPunishCard.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.cboPunishCard.DropDownForeColor = System.Drawing.Color.Black;
			this.cboPunishCard.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
			this.cboPunishCard.DropDownWidth = 130;
			this.cboPunishCard.GridLineColor = System.Drawing.Color.LightGray;
			this.cboPunishCard.GridLineHorizontal = true;
			this.cboPunishCard.GridLineVertical = true;
			this.cboPunishCard.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.cboPunishCard.Location = new System.Drawing.Point(104, 40);
			this.cboPunishCard.ManagingFastMouseMoving = true;
			this.cboPunishCard.ManagingFastMouseMovingInterval = 30;
			this.cboPunishCard.Name = "cboPunishCard";
			this.cboPunishCard.Size = new System.Drawing.Size(160, 21);
			this.cboPunishCard.TabIndex = 77;
			// 
			// cboEmployeeName
			// 
			this.cboEmployeeName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
			this.cboEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboEmployeeName.ColumnNum = 3;
            this.cboEmployeeName.ColumnWidth = "121;60;0";
			this.cboEmployeeName.DisplayMember = "Text";
			this.cboEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboEmployeeName.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.cboEmployeeName.DropDownForeColor = System.Drawing.Color.Black;
			this.cboEmployeeName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
			this.cboEmployeeName.DropDownWidth = 201;
			this.cboEmployeeName.GridLineColor = System.Drawing.Color.LightGray;
			this.cboEmployeeName.GridLineHorizontal = true;
			this.cboEmployeeName.GridLineVertical = true;
			this.cboEmployeeName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.cboEmployeeName.Location = new System.Drawing.Point(104, 16);
			this.cboEmployeeName.ManagingFastMouseMoving = true;
			this.cboEmployeeName.ManagingFastMouseMovingInterval = 30;
			this.cboEmployeeName.Name = "cboEmployeeName";
			this.cboEmployeeName.Size = new System.Drawing.Size(160, 21);
			this.cboEmployeeName.TabIndex = 76;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 51;
			this.label2.Text = "Ngày làm ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpWorkingDay
			// 
			this.dtpWorkingDay.CustomFormat = "dd/MM/yyyy    ";
			this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWorkingDay.Location = new System.Drawing.Point(104, 64);
			this.dtpWorkingDay.Name = "dtpWorkingDay";
			this.dtpWorkingDay.Size = new System.Drawing.Size(160, 20);
			this.dtpWorkingDay.TabIndex = 56;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 69;
			this.label4.Text = "Hình thức phạt";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 23);
			this.label6.TabIndex = 61;
			this.label6.Text = "Tên nhân viên";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtReason
			// 
			this.txtReason.Location = new System.Drawing.Point(8, 120);
			this.txtReason.Multiline = true;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(256, 184);
			this.txtReason.TabIndex = 55;
			this.txtReason.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 18);
			this.label5.TabIndex = 54;
			this.label5.Text = "Lý do phạt";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSave.Location = new System.Drawing.Point(344, 328);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 79;
			this.btnSave.Text = "Ghi";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.departmentTreeView);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 312);
			this.groupBox1.TabIndex = 82;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Phòng ban";
			// 
			// departmentTreeView
			// 
			this.departmentTreeView.DepartmentDataSet = null;
			this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
			this.departmentTreeView.Name = "departmentTreeView";
			this.departmentTreeView.Size = new System.Drawing.Size(192, 288);
			this.departmentTreeView.TabIndex = 76;
			this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
			// 
			// frmPunish
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(504, 358);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPunish";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý thẻ phạt";
			this.Load += new System.EventHandler(this.frmPunish_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region Các hàm sự kiện
		public frmPunish()
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

		

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmPunish_Load(object sender, EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			employeeDO = new EmployeeDO();
			departmentTreeView.DepartmentDataSet = departmentDO.GetAllDepartments();
			departmentTreeView.BuildTree();
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;
			departmentTreeView.ExpandNodes(true);
			LoadPunishCardCombo();
			punishD0 = new PunishDO();
			dtPunish = dsPunish.Tables[0];

			if(selectedPunish >= 0)//Sửa thông tin thẻ phạt
			{
				
				//this.Text = "Sửa thông tin thiết lập thẻ phạt";
				this.Text = WorkingContext.LangManager.GetString("frmPunish_Text1");
				LoadPunishData();
				cboEmployeeName.Enabled = false;
				departmentTreeView.Enabled = false;
			}
			else// thêm mới
			{
				//This.Text = "Thiết lập thẻ phạt";
				this.Text = WorkingContext.LangManager.GetString("frmPunish_Text2");
			}

		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);

			cboEmployeeName.Items.Clear();
			dsEmployee = employeeDO.GetEmployeeByDepartment((int) e.Node.Tag);
            cboEmployeeName.SourceDataString = new string[] { "EmployeeName", "CardID", "EmployeeID" };
			cboEmployeeName.SourceDataTable = dsEmployee.Tables[0];
			// kiểm tra nếu phòng có nhân viên thì hiển thị thông tin của nhân viên đầu tiên
			if(dsEmployee.Tables[0].Rows.Count > 0)
			{
				cboEmployeeName.SelectedIndex = 0;	
			}
			else
			{
				cboEmployeeName.Items.Clear();
				cboEmployeeName.Text = "";
			}	
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			String errStr = CheckInputData();  
			String str = WorkingContext.LangManager.GetString("frmContract_Messa2");
			if(errStr != "")
			{
				MessageBox.Show(errStr,str,MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			else
			{
				if(selectedPunish >= 0)
				{
					UpdatePunish();
					this.Close();

				}
				else
				{
					AddPunish();	
				}
			}
			
			
		}
		#endregion
		#region Các hàm xử lý chính
		/// <summary>
		/// Thêm thẻ phạt cho nhân viên
		/// </summary>
		private void AddPunish()
		{
			
			int ret = 0;
			try
			{
				DataRow dr = dtPunish.NewRow();
				dtPunish.Rows.Add(SetData(dr));
				ret = punishD0.AddPunish(dsPunish);
			}
			catch
			{
				
			}
			if(ret != 0)
			{
				String str = WorkingContext.LangManager.GetString("frmPunish_AddMessa1");
				String str1 = WorkingContext.LangManager.GetString("frmContract_Messa2");
				//MessageBox.Show("Thiết lập thẻ phạt thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
				dsPunish.AcceptChanges();
			}
			else
			{
				String str = WorkingContext.LangManager.GetString("frmPunish_AddMessa2");
				String str1 = WorkingContext.LangManager.GetString("frmContract_Messa2");
				//MessageBox.Show("Thiết lập thẻ phạt thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
				dsPunish.RejectChanges();
			}

		}
		/// <summary>
		/// Lấy dữ liệu đầu vào từ textbox, combo...
		/// </summary>
		/// <param name="dr"></param>
		/// <returns></returns>
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			if (selectedPunish < 0) // chế độ sửa
			{
				dr["EmployeeID"] = ((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3;
			}	
			dr["PunishCardID"] = ((MTGCComboBoxItem)cboPunishCard.SelectedItem).Col1;
			dr["WorkingDay"] = dtpWorkingDay.Value.Date;
			dr["Reason"] = txtReason.Text;
			dr.EndEdit();
			return dr;
			
		}
		
		/// <summary>
		/// Hiển thị các loại thẻ phạt vào combobox
		/// </summary>
		private void LoadPunishCardCombo()
		{
			punishCardDO = new PunishCardDO();
			dsPunishCardDO = punishCardDO.GetPunishCard();
			cboPunishCard.SourceDataString = new string[] {"PunishCardID", "CardName"};
			cboPunishCard.SourceDataTable = dsPunishCardDO.Tables[0];
		}
		
		/// <summary>
		/// Cập nhật thẻ phạt
		/// </summary>
		private void UpdatePunish()
		{
			int ret = 0;
			try
			{
				DataRow dr = dtPunish.Rows[selectedPunish];
				dr = SetData(dr);
				ret = punishD0.UpdatePunish(dsPunish);
			}
			catch
			{
				
			}
			if(ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmPunish_AddMessa1");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Thiết lập thẻ phạt thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
				dsPunish.AcceptChanges();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmPunish_AddMessa2");
				string str1 = WorkingContext.LangManager.GetString("frmListPunish_Messa_Title");
				//MessageBox.Show("Thiết lập thẻ phạt thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
				dsPunish.RejectChanges();
			}
		}
		/// <summary>
		/// Cập nhật lại dữ liệu về thẻ phạt của nhân viên
		/// </summary>
		private void LoadPunishData()
		{
			DataRow dr = dtPunish.Rows[selectedPunish];
			cboEmployeeName.Text = dr["EmployeeName"].ToString();
			cboPunishCard.Text = dr["CardName"].ToString();
			dtpWorkingDay.Value = DateTime.Parse(dr["WorkingDay"].ToString());
			txtReason.Text = dr["Reason"].ToString();

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
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmPunish_groupbox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmPunish_groupbox2");
			this.label2.Text = WorkingContext.LangManager.GetString("frmPunish_lable2");
			this.label4.Text = WorkingContext.LangManager.GetString("frmPunish_lable4");
			this.label5.Text = WorkingContext.LangManager.GetString("frmPunish_lable5");
			this.label6.Text = WorkingContext.LangManager.GetString("frmPunish_lable6");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmPunish_btnClose");
			this.btnHelp.Text = WorkingContext.LangManager.GetString("frmPunish_btnHelp");
			this.btnSave.Text = WorkingContext.LangManager.GetString("frmPunish_btnSave");
			
		}
		/// <summary>
		/// Kiểm tra dữ liệu đầu vào
		/// </summary>
		/// <returns></returns>
		private string CheckInputData()
		{
			if (cboEmployeeName.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmPunish_Messa2");
				//return "Bạn phải chọn một nhân viên ! ";
				return str;
			}
			if (cboPunishCard.Text == "")
			{
				string str = WorkingContext.LangManager.GetString("frmPunish_Messa");
				//return "Bạn chưa chọn loại thẻ phạt";
				return str;
			}
			return "";
		}
		#endregion
	}
}
