using System;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmCopyLunch.
	/// </summary>
	public class frmCopyLunch : Form
	{
		#region Các biến tự định nghĩa
		private DateTime previousDay;// ngày chứa dữ liệu đã thiết lập
		private DateTime currentDay;//ngày cần thiết lập
		public DateTime CurrentDay
		{
			get { return currentDay; }
			set { currentDay = value; }
		}

		private frmLunch lunchForm = null;
		#endregion
		#region Window Form generated code
		private Button btnCopyLunch;
		private GroupBox groupBox1;
		private MonthCalendar mcPreviousWorkingDay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		private Button btnClose;
		public frmCopyLunch(frmLunch frmlunch)
		{
			this.lunchForm = frmlunch;
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
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCopyLunch));
			this.mcPreviousWorkingDay = new System.Windows.Forms.MonthCalendar();
			this.btnCopyLunch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mcPreviousWorkingDay
			// 
			this.mcPreviousWorkingDay.Location = new System.Drawing.Point(8, 16);
			this.mcPreviousWorkingDay.MaxSelectionCount = 1;
			this.mcPreviousWorkingDay.Name = "mcPreviousWorkingDay";
			this.mcPreviousWorkingDay.ShowToday = false;
			this.mcPreviousWorkingDay.ShowTodayCircle = false;
			this.mcPreviousWorkingDay.TabIndex = 0;
			// 
			// btnCopyLunch
			// 
			this.btnCopyLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyLunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCopyLunch.Location = new System.Drawing.Point(40, 184);
			this.btnCopyLunch.Name = "btnCopyLunch";
			this.btnCopyLunch.TabIndex = 1;
			this.btnCopyLunch.Text = "Sao chép";
			this.btnCopyLunch.Click += new System.EventHandler(this.btnCopyLunch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mcPreviousWorkingDay);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 176);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(120, 184);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmCopyLunch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(202, 216);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCopyLunch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCopyLunch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Chọn ngày đã thiết lập";
			this.Load += new System.EventHandler(this.frmCopyLunch_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region Các hàm xử lý sự kiện
		private void btnCopyLunch_Click(object sender, EventArgs e)
		{
			previousDay = mcPreviousWorkingDay.SelectionStart;
			DialogResult dr = new DialogResult();
			if (this.Text == "Chọn ngày đã thiết lập !")
			{
				dr=MessageBox.Show("Bạn có thực sự muốn copy dữ liệu từ ngày "+ previousDay.ToString("dd/MM/yyyy")+" sang ngày "+currentDay.ToString("dd/MM/yyyy")+" ? ", "Xác nhận sao chép", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			else
			{
				//string 
				dr=MessageBox.Show("確かに、自 "+ previousDay.ToString("dd/MM/yyyy")+" 至 "+currentDay.ToString("dd/MM/yyyy")+" のデータをコピーしましか ? ", "コピー確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			if (dr ==DialogResult.Yes)
			{	
				lunchForm.previousWorkingDay = previousDay;
				lunchForm.CopyFromPreviousLunchStatus = 1;
				this.Close();
			}
			else
			{
				lunchForm.CopyFromPreviousLunchStatus = 0;
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			lunchForm.CopyFromPreviousLunchStatus = 0;
			this.Close();
		}
		#endregion

		private void frmCopyLunch_Load(object sender, System.EventArgs e)
		{
			Refresh();
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
			this.Text = WorkingContext.LangManager.GetString("frmCopyLunch_Text");
			this.btnCopyLunch.Text = WorkingContext.LangManager.GetString("frmCopyLunch_btnSaoChep");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmCopyLunch_btnClose");
		}

	}
}
