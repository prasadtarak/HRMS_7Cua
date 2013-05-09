using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmAbout.
	/// </summary>
	public class frmVersion : System.Windows.Forms.Form
	{
		private MySys.ScrollText scrollText1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmVersion()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmVersion));
			this.scrollText1 = new MySys.ScrollText();
			this.SuspendLayout();
			// 
			// scrollText1
			// 
			this.scrollText1.AutosizeLabels = false;
			this.scrollText1.BackColor = System.Drawing.SystemColors.Control;
			this.scrollText1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrollText1.BackgroundImage")));
			this.scrollText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.scrollText1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.scrollText1.Location = new System.Drawing.Point(0, 8);
			this.scrollText1.Name = "scrollText1";
			this.scrollText1.OffSet = 5;
			this.scrollText1.SetDelay = "20";
			this.scrollText1.SetText = "Nguyễn Đình Chính";
			this.scrollText1.Size = new System.Drawing.Size(336, 200);
			this.scrollText1.TabIndex = 6;
			this.scrollText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmVersion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(338, 208);
			this.Controls.Add(this.scrollText1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmVersion";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phiên bản chương trình";
			this.Load += new System.EventHandler(this.frmVersion_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
//		private void ShowVersion()
//		{
//			FileInfo fr = new FileInfo(@"readme.txt"); // input file
//			StreamReader reader = fr.OpenText();  // OpenText returns StreamReader
//			string sline; 
//			sline = reader.ReadLine();
//			while (sline != null)
//			{   
//				txtVersion.Text += sline.ToString()+"\r\n";
//				sline = reader.ReadLine();
//			}
//		}

		private void frmVersion_Load(object sender, System.EventArgs e)
		{
			Refresh();
//			ShowVersion();
//			txtVersion.WordWrap = true;
//			btnClose.Focus();
			ShowScrollText();
			
			
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
			this.Text = WorkingContext.LangManager.GetString("frmVersion_text");
//			this.btnClose.Text = WorkingContext.LangManager.GetString("frmVersion_Close");
		}
		/// <summary>
		/// 
		/// </summary>
		/// 
		private void ShowScrollText()
		{
			scrollText1.BackgroundImage =  Image.FromFile("IMAGES/about.jpg");
			scrollText1.Text = "Hệ thống quản lý nhân sự EVC."+"\r\n\n Phiên bản 2.1"+"\r\n Tác giả: Nguyễn Đình Chính. "+"\r\n\r\n Release 11/11/2010."+"\r\n Copy right 2005- 2010 by LIFETIME technologies Co. Ltd."+"\r\n Add: 3D Creative Center, Nguyen Phong Sac str., Hanoi, Vietnam"+"\r\n Website: http://www.lifetimetech.vn";
//			picAbout.Image = Image.FromFile("IMAGES/about.jpg");
//			picCompany.Image = Image.FromFile("IMAGES/evsoft.jpg");
			
			
//			scrollText1.SetText ="Hệ thống quản lý nhân sự công ty EVSoft";

		}


	
		
	}
}
