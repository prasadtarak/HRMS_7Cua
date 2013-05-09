//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: quandh 25/11/2006
//Note		: Quản lý thời gian vào ra cho phép làm việc đồng thời hai hoặc nhiều cửa sổ 1 lúc
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmChooseTimeInOut.
	/// </summary>
	public class frmChooseTimeInOut : Form
	{
		private Button btnDisplay;
		private Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpToDateDefault;
		private System.Windows.Forms.DateTimePicker dtpFromDateDefault;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public frmChooseTimeInOut()
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
			this.btnDisplay = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dtpToDateDefault = new System.Windows.Forms.DateTimePicker();
			this.dtpFromDateDefault = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDisplay
			// 
			this.btnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDisplay.Location = new System.Drawing.Point(184, 58);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.TabIndex = 7;
			this.btnDisplay.Text = "Hiển thị";
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(266, 58);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dtpToDateDefault
			// 
			this.dtpToDateDefault.CustomFormat = "dd/MM/yyyy";
			this.dtpToDateDefault.Enabled = false;
			this.dtpToDateDefault.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDateDefault.Location = new System.Drawing.Point(232, 16);
			this.dtpToDateDefault.Name = "dtpToDateDefault";
			this.dtpToDateDefault.Size = new System.Drawing.Size(88, 20);
			this.dtpToDateDefault.TabIndex = 12;
			// 
			// dtpFromDateDefault
			// 
			this.dtpFromDateDefault.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDateDefault.Enabled = false;
			this.dtpFromDateDefault.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDateDefault.Location = new System.Drawing.Point(64, 16);
			this.dtpFromDateDefault.Name = "dtpFromDateDefault";
			this.dtpFromDateDefault.Size = new System.Drawing.Size(88, 20);
			this.dtpFromDateDefault.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(176, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Đến ngày";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Từ ngày";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpToDateDefault);
			this.groupBox1.Controls.Add(this.dtpFromDateDefault);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 48);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Khoảng thời gian mặc định";
			// 
			// frmChooseTimeInOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(346, 88);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnDisplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChooseTimeInOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn khoảng thời gian vào ra";
			this.Load += new System.EventHandler(this.frmChooseTimeInOut_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			if(dtpFromDateDefault.Value > dtpToDateDefault.Value)
			{
				string str = WorkingContext.LangManager.GetString("frmChooseInOut_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListReport_thongbao_Title");
				//MessageBox.Show("Khoảng thời gian chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				//this.Close();
				frmChangeTimeInOut frm = new frmChangeTimeInOut();
				frm.FromDate = dtpFromDateDefault.Value;
				frm.ToDate = dtpToDateDefault.Value;
				frm.Show();	
				//frm.MdiParent = this;
			}
		}

		private void frmChooseTimeInOut_Load(object sender, System.EventArgs e)
		{
			Refresh();	
			DateTime now = DateTime.Now;
			dtpFromDateDefault.Value = new DateTime(now.Year, now.Month, 1);
			SetStatus(false);
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
			this.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1");
			this.label4.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1_lblFromDate");
			this.label1.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1_lblToDate");
			this.btnDisplay.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_bntDisplay");
			this.btnCancel.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_bntCancle");
			
			
			
		}
		private void SetStatus(bool edit)
		{
			dtpFromDateDefault.Enabled = !edit;
			dtpToDateDefault.Enabled = !edit;
		}

		private void rdoDefault_CheckedChanged(object sender, System.EventArgs e)
		{
			SetStatus(false);
			DateTime now = DateTime.Now;
			dtpFromDateDefault.Value = new DateTime(now.Year, now.Month, 1);
			dtpToDateDefault.Value = now;
		}
	}
}