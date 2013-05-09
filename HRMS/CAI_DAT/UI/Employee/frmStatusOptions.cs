using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmStatusOptions.
	/// </summary>
	public class frmStatusOptions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grbOptions;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private AMS.TextBox.NumericTextBox txtBoxHeight;
		private AMS.TextBox.NumericTextBox txtBoxWidth;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private AMS.TextBox.NumericTextBox txtBoxesPerPage;
		private frmEmployeeStatus status = null;

		public frmStatusOptions(frmEmployeeStatus status)
		{
			this.status = status;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmStatusOptions));
			this.grbOptions = new System.Windows.Forms.GroupBox();
			this.txtBoxesPerPage = new AMS.TextBox.NumericTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxHeight = new AMS.TextBox.NumericTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxWidth = new AMS.TextBox.NumericTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.grbOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbOptions
			// 
			this.grbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grbOptions.Controls.Add(this.txtBoxesPerPage);
			this.grbOptions.Controls.Add(this.label3);
			this.grbOptions.Controls.Add(this.txtBoxHeight);
			this.grbOptions.Controls.Add(this.label2);
			this.grbOptions.Controls.Add(this.txtBoxWidth);
			this.grbOptions.Controls.Add(this.label1);
			this.grbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbOptions.Location = new System.Drawing.Point(8, 8);
			this.grbOptions.Name = "grbOptions";
			this.grbOptions.Size = new System.Drawing.Size(224, 96);
			this.grbOptions.TabIndex = 0;
			this.grbOptions.TabStop = false;
			this.grbOptions.Text = "Kích thước ô trạng thái";
			// 
			// txtBoxesPerPage
			// 
			this.txtBoxesPerPage.AllowNegative = true;
			this.txtBoxesPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxesPerPage.DigitsInGroup = 0;
			this.txtBoxesPerPage.Flags = 0;
			this.txtBoxesPerPage.Location = new System.Drawing.Point(88, 64);
			this.txtBoxesPerPage.MaxDecimalPlaces = 4;
			this.txtBoxesPerPage.MaxWholeDigits = 9;
			this.txtBoxesPerPage.Name = "txtBoxesPerPage";
			this.txtBoxesPerPage.Prefix = "";
			this.txtBoxesPerPage.RangeMax = 1.7976931348623157E+308;
			this.txtBoxesPerPage.RangeMin = -1.7976931348623157E+308;
			this.txtBoxesPerPage.Size = new System.Drawing.Size(124, 20);
			this.txtBoxesPerPage.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Số ô trạng thái";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBoxHeight
			// 
			this.txtBoxHeight.AllowNegative = true;
			this.txtBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxHeight.DigitsInGroup = 0;
			this.txtBoxHeight.Flags = 0;
			this.txtBoxHeight.Location = new System.Drawing.Point(88, 40);
			this.txtBoxHeight.MaxDecimalPlaces = 4;
			this.txtBoxHeight.MaxWholeDigits = 9;
			this.txtBoxHeight.Name = "txtBoxHeight";
			this.txtBoxHeight.Prefix = "";
			this.txtBoxHeight.RangeMax = 1.7976931348623157E+308;
			this.txtBoxHeight.RangeMin = -1.7976931348623157E+308;
			this.txtBoxHeight.Size = new System.Drawing.Size(124, 20);
			this.txtBoxHeight.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Chiều cao";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBoxWidth
			// 
			this.txtBoxWidth.AllowNegative = true;
			this.txtBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxWidth.DigitsInGroup = 0;
			this.txtBoxWidth.Flags = 0;
			this.txtBoxWidth.Location = new System.Drawing.Point(88, 16);
			this.txtBoxWidth.MaxDecimalPlaces = 4;
			this.txtBoxWidth.MaxWholeDigits = 9;
			this.txtBoxWidth.Name = "txtBoxWidth";
			this.txtBoxWidth.Prefix = "";
			this.txtBoxWidth.RangeMax = 1.7976931348623157E+308;
			this.txtBoxWidth.RangeMin = -1.7976931348623157E+308;
			this.txtBoxWidth.Size = new System.Drawing.Size(124, 20);
			this.txtBoxWidth.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chiều rộng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(80, 112);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "&Đồng ý";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(160, 112);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmStatusOptions
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(240, 142);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.grbOptions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmStatusOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tùy chọn hiển thị";
			this.Load += new System.EventHandler(this.frmStatusOptions_Load);
			this.grbOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmStatusOptions_Load(object sender, System.EventArgs e)
		{
			txtBoxWidth.Double = status.BoxWidth;
			txtBoxHeight.Double = status.BoxHeight;
			txtBoxesPerPage.Double = status.BoxesPerPage;
			Refresh();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			status.BoxWidth = (int)txtBoxWidth.Double;
			status.BoxHeight = (int)txtBoxHeight.Double;
			status.BoxesPerPage = (int)txtBoxesPerPage.Double;
			this.Close();
		}
		public override void Refresh()
		{
			ChangeToCurrentLang();

			//BuildTreeAgain();
			
			foreach (Form form in this.MdiChildren)
			{
				form.Refresh();
			}

			base.Refresh ();
		}

		private void ChangeToCurrentLang()
		{
			this.Text = WorkingContext.LangManager.GetString("frmStatusOptions_Text");
			this.grbOptions.Text = WorkingContext.LangManager.GetString("frmStatusOptions_grbOptions");
			this.label1.Text = WorkingContext.LangManager.GetString("frmStatusOptions_grbOptions_lblChieurong");
			this.label2.Text = WorkingContext.LangManager.GetString("frmStatusOptions_grbOptions_lblChieuCao");
			this.label3.Text = WorkingContext.LangManager.GetString("frmStatusOptions_grbOptions_SoTrangThai");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmStatusOptions_bntClose");
			this.btnOK.Text = WorkingContext.LangManager.GetString("frmStatusOptions_bntOK");
		}
	}
}
