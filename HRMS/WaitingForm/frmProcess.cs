using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WaitingForm
{
	/// <summary>
	/// Summary description for frmProcess.
	/// </summary>
	public class frmProcess : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblMsg;
		private KDHLib.Controls.GradientWaitingBar gradientWaitingBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmProcess()
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
			this.lblMsg = new System.Windows.Forms.Label();
			this.gradientWaitingBar1 = new KDHLib.Controls.GradientWaitingBar();
			this.SuspendLayout();
			// 
			// lblMsg
			// 
			this.lblMsg.Location = new System.Drawing.Point(4, 40);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(350, 30);
			this.lblMsg.TabIndex = 4;
			this.lblMsg.Text = "Processing ...";
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gradientWaitingBar1
			// 
			this.gradientWaitingBar1.BackColor = System.Drawing.Color.White;
			this.gradientWaitingBar1.GradientColor1 = System.Drawing.Color.Gainsboro;
			this.gradientWaitingBar1.GradientColor2 = System.Drawing.SystemColors.InactiveCaption;
			this.gradientWaitingBar1.Interval = 30;
			this.gradientWaitingBar1.Location = new System.Drawing.Point(5, 5);
			this.gradientWaitingBar1.Name = "gradientWaitingBar1";
			this.gradientWaitingBar1.ScrollWAY = KDHLib.Controls.GradientWaitingBar.SCROLLGRADIENTALIGN.HORIZONTAL;
			this.gradientWaitingBar1.Size = new System.Drawing.Size(350, 30);
			this.gradientWaitingBar1.Speed = 5;
			this.gradientWaitingBar1.TabIndex = 5;
			this.gradientWaitingBar1.Text = "gradientWaitingBar1";
			// 
			// frmProcess
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(358, 73);
			this.ControlBox = false;
			this.Controls.Add(this.gradientWaitingBar1);
			this.Controls.Add(this.lblMsg);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmProcess";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		#region Hiển thị thông tin
		public void ShowMe()
		{
			this.Cursor=Cursors.WaitCursor;
			this.Show();
			Application.DoEvents();
		}
		public void ShowMe(string msg)
		{
			this.Cursor=Cursors.WaitCursor;
			lblMsg.Text=msg;
			this.Show();
			Application.DoEvents();
		}
		#endregion

		public void CloseMe()
		{
			Cursor = Cursors.Default;
			this.Hide();
		}
		
	}
}
