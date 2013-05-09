using System;
using System.Windows.Forms;
namespace EVSoft.HRMS.UI
{
	public class frmStatusMessage:System.Windows.Forms.Form 
	{

		#region " Windows Form Designer generated code "

		public frmStatusMessage() 
		{
			//This call is required by the Windows Form Designer.

			InitializeComponent();

			//Add any initialization after the InitializeComponent() call

		}

		//Form overrides dispose to clean up the component list.

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

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ProgressBar progressBar;

		public ProgressBar ProgressBar
		{
			get { return progressBar; }
			set { progressBar = value; }
		}

		//NOTE: The following procedure is required by the Windows Form Designer

		//It can be modified using the Windows Form Designer.  

		//Do not modify it using the code editor.

		private System.Windows.Forms.Label lblStatus;

		private void InitializeComponent() 
		{
			this.lblStatus = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStatus.Location = new System.Drawing.Point(16, 8);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(236, 48);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Label1";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBar1
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(16, 64);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(232, 23);
			this.progressBar.TabIndex = 1;
			// 
			// frmStatusMessage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(256, 96);
			this.ControlBox = false;
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblStatus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmStatusMessage";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Status";
			this.ResumeLayout(false);

		}

		#endregion

		public void Show(string Message )
		{

			lblStatus.Text = Message;

			this.Show();

			Application.DoEvents();

		}

	}

}