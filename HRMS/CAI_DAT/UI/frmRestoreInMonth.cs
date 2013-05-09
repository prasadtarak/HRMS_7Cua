using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmRestoreInMonth.
	/// </summary>
	public class frmRestoreInMonth : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpToDateDefault;
		private System.Windows.Forms.DateTimePicker dtpFromDateDefault;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDisplay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRestoreInMonth()
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
			this.dtpToDateDefault = new System.Windows.Forms.DateTimePicker();
			this.dtpFromDateDefault = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpToDateDefault);
			this.groupBox1.Controls.Add(this.dtpFromDateDefault);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(5, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 48);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kho?ng th?i gian m?c ð?nh";
			// 
			// dtpToDateDefault
			// 
			this.dtpToDateDefault.CustomFormat = "dd/MM/yyyy";
			this.dtpToDateDefault.Enabled = false;
			this.dtpToDateDefault.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDateDefault.Location = new System.Drawing.Point(234, 16);
			this.dtpToDateDefault.Name = "dtpToDateDefault";
			this.dtpToDateDefault.Size = new System.Drawing.Size(88, 20);
			this.dtpToDateDefault.TabIndex = 12;
			// 
			// dtpFromDateDefault
			// 
			this.dtpFromDateDefault.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDateDefault.Enabled = false;
			this.dtpFromDateDefault.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDateDefault.Location = new System.Drawing.Point(63, 16);
			this.dtpFromDateDefault.Name = "dtpFromDateDefault";
			this.dtpFromDateDefault.Size = new System.Drawing.Size(88, 20);
			this.dtpFromDateDefault.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(168, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Ð?n tháng :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "T? tháng :";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(263, 58);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "H?y b?";
			// 
			// btnDisplay
			// 
			this.btnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDisplay.Location = new System.Drawing.Point(181, 58);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.TabIndex = 17;
			this.btnDisplay.Text = "Khôi ph?c";
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// frmRestoreInMonth
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(346, 88);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnDisplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRestoreInMonth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ch?n kho?ng th?i gian khôi ph?c d? li?u";
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
			string str = WorkingContext.LangManager.GetString("frmChooseInOut_Messa1");
			string str1 = WorkingContext.LangManager.GetString("frmListReport_thongbao_Title");
			string str2= WorkingContext.LangManager.GetString("frmRestoreInMonth_Messa3");
			string strSuccess=WorkingContext.LangManager.GetString("frmRestoreInMonth_Messa1");
			string strErorr=WorkingContext.LangManager.GetString("frmRestoreInMonth_Messa2");
			if(dtpFromDateDefault.Value > dtpToDateDefault.Value)
			{
				
				//MessageBox.Show("Kho?ng th?i gian ch?n không h?p l?","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				string strTb = WorkingContext.LangManager.GetString("frmRestoreInMonth_xacnhankhoiphucdulieu");
				string strTBTD = WorkingContext.LangManager.GetString("frmRestoreInMonth_title");
				//Xác nh?n mu?n sao lýu d? li?u theo tháng
				if (MessageBox.Show(strTb, strTBTD, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}
				frmStatusMessage message = new frmStatusMessage();
				string strBU = WorkingContext.LangManager.GetString("frmRestoreInMonth_dangkhoiphucdulieu");
				//message.Show("Ðang sao lýu d? li?u...");
				message.Show(strBU);
				this.Cursor = Cursors.WaitCursor;
				float f100 = 100;
				
				float percentToComplete = 0;
				int percentProcessing = 0;
				message.ProgressBar.Value = 0;
				for(int i=1;i<=100;i++)
				{
					percentProcessing= ++percentProcessing;
					//percentToComplete = percentProcessing / 100;
					percentToComplete = ((float)(percentProcessing) / (float)(f100));
					message.ProgressBar.Value = (int)percentProcessing;
					
				}
				
				AdminDO adminDO = new AdminDO();
				int result=adminDO.RestoreDataInMonth(dtpFromDateDefault.Value, dtpToDateDefault.Value);
				message.Close();
				this.Cursor = Cursors.Default;
				if(result!=-1)
					MessageBox.Show(strSuccess+"\n("+result+" "+str2+")",str1,MessageBoxButtons.OK,MessageBoxIcon.Information);
				else 
					MessageBox.Show(strErorr,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void frmChooseTimeInOut_Load(object sender, System.EventArgs e)
		{
			Refresh();	
			DateTime now = DateTime.Now.AddMonths(-6);
            dtpFromDateDefault.Value = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, 1);
            dtpToDateDefault.Value = new DateTime(now.Year, now.Month, 1);
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
			this.Text = WorkingContext.LangManager.GetString("frmChooseRestoreData_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1");
			this.label4.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1_lblFromMonth");
			this.label1.Text = WorkingContext.LangManager.GetString("frmChooseTimeInOut_GroupBox1_lblToMonth");
			this.btnDisplay.Text = WorkingContext.LangManager.GetString("frmE_btnKP");
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
