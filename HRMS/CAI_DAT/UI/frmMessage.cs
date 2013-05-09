using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmLunchMessage.
	/// </summary>
	public class frmMessage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstLunchMessage;
		/// <summary>
		/// Thông tin nhân viên truyền từ frmLunch sang
		/// </summary>
		private System.Windows.Forms.Button btnClose;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;








		public frmMessage()
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
			this.lstLunchMessage = new System.Windows.Forms.ListBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstLunchMessage
			// 
			this.lstLunchMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lstLunchMessage.HorizontalScrollbar = true;
			this.lstLunchMessage.Location = new System.Drawing.Point(8, 8);
			this.lstLunchMessage.Name = "lstLunchMessage";
			this.lstLunchMessage.Size = new System.Drawing.Size(292, 290);
			this.lstLunchMessage.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(104, 304);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmMessage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 334);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lstLunchMessage);
			this.Name = "frmMessage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông báo ";
			this.Load += new System.EventHandler(this.frmLunchMessage_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLunchMessage_Load(object sender, System.EventArgs e)
		{
			Refresh();

		}
		public void AddMessage(string message)
		{
			lstLunchMessage.BeginUpdate();
			lstLunchMessage.Items.Add(message);
			lstLunchMessage.EndUpdate();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
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
			this.Text = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegWork_btnClose");
		}
		

	}
}
