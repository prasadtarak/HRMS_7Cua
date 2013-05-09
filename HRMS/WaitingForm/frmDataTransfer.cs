using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WaitingForm
{/// <summary>
	/// Summary description for frmDataTransfer.
	/// </summary>
	public class frmDataTransfer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.BusyBar.ColorFadeBusyBar colorFadeBusyBar1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public frmDataTransfer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			colorFadeBusyBar1.Start();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDataTransfer));
			this.lblMsg = new System.Windows.Forms.Label();
			this.colorFadeBusyBar1 = new System.Windows.Forms.BusyBar.ColorFadeBusyBar();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// lblMsg
			// 
			this.lblMsg.Location = new System.Drawing.Point(5, 50);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(350, 45);
			this.lblMsg.TabIndex = 3;
			this.lblMsg.Text = "DataTransfer ...";
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// colorFadeBusyBar1
			// 
			this.colorFadeBusyBar1.BackColor = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.BorderStyle3D = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.colorFadeBusyBar1.Color2 = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.FadeLength = -1;
			this.colorFadeBusyBar1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.colorFadeBusyBar1.Location = new System.Drawing.Point(55, 15);
			this.colorFadeBusyBar1.Name = "colorFadeBusyBar1";
			this.colorFadeBusyBar1.PingPong = true;
			this.colorFadeBusyBar1.ShowBorder = true;
			this.colorFadeBusyBar1.Size = new System.Drawing.Size(250, 35);
			this.colorFadeBusyBar1.StepSize = 5;
			this.colorFadeBusyBar1.StepTimeout = 50;
			this.colorFadeBusyBar1.TabIndex = 6;
			this.colorFadeBusyBar1.TextColor = System.Drawing.SystemColors.ControlText;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(305, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 45);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 45);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmDataTransfer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(358, 98);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.colorFadeBusyBar1);
			this.Controls.Add(this.lblMsg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmDataTransfer";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Closed += new System.EventHandler(this.frmDataTransfer_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmDataTransfer_Closed(object sender, System.EventArgs e)
		{
			colorFadeBusyBar1.Stop();
		}

	}
}
