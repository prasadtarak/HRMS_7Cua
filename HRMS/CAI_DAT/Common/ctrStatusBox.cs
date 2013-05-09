using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.UI.Employee;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Summary description for ctrStatusBox.
	/// </summary>
	public class ctrStatusBox : System.Windows.Forms.UserControl
	{
		public System.Windows.Forms.Label lblEmployeeName;
		public System.Windows.Forms.PictureBox picEmployee;
		public System.Windows.Forms.PictureBox picStatus;
		public System.Windows.Forms.Label lblYellowCard;
		public System.Windows.Forms.Label lblRedCard;
		public System.Windows.Forms.Label lblTimeIn;
		public System.Windows.Forms.Label lblTimeOut;
		
		private EmployeeDO	employeeDO = null;
		public int EmployeeID;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsEmployee = null;
		/// <summary>
		/// 
		/// </summary>
		private int selectedEmployee = 0;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lblLate;
//		private System.Windows.Forms.Label lblTimeIn;
//		private System.Windows.Forms.Label lblTimeOut;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctrStatusBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ctrStatusBox));
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.picEmployee = new System.Windows.Forms.PictureBox();
			this.picStatus = new System.Windows.Forms.PictureBox();
			this.lblYellowCard = new System.Windows.Forms.Label();
			this.lblRedCard = new System.Windows.Forms.Label();
			this.lblTimeIn = new System.Windows.Forms.Label();
			this.lblTimeOut = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblLate = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblEmployeeName.BackColor = System.Drawing.Color.CornflowerBlue;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.lblEmployeeName.ForeColor = System.Drawing.Color.Navy;
			this.lblEmployeeName.Location = new System.Drawing.Point(0, 0);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(112, 24);
			this.lblEmployeeName.TabIndex = 0;
			this.lblEmployeeName.Text = "Bùi Thị Giao Linh";
			this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
			this.lblEmployeeName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEmployeeName_MouseMove);
			this.lblEmployeeName.MouseLeave += new System.EventHandler(this.lblEmployeeName_MouseLeave);
			// 
			// picEmployee
			// 
			this.picEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
			this.picEmployee.Location = new System.Drawing.Point(0, 24);
			this.picEmployee.Name = "picEmployee";
			this.picEmployee.Size = new System.Drawing.Size(112, 128);
			this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEmployee.TabIndex = 1;
			this.picEmployee.TabStop = false;
			this.picEmployee.Click += new System.EventHandler(this.picEmployee_Click);
			this.picEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picEmployee_MouseMove);
			this.picEmployee.MouseLeave += new System.EventHandler(this.picEmployee_MouseLeave);
			// 
			// picStatus
			// 
			this.picStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picStatus.Image = ((System.Drawing.Image)(resources.GetObject("picStatus.Image")));
			this.picStatus.Location = new System.Drawing.Point(8, 14);
			this.picStatus.Name = "picStatus";
			this.picStatus.Size = new System.Drawing.Size(22, 22);
			this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picStatus.TabIndex = 5;
			this.picStatus.TabStop = false;
			// 
			// lblYellowCard
			// 
			this.lblYellowCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblYellowCard.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.lblYellowCard.ForeColor = System.Drawing.Color.Navy;
			this.lblYellowCard.Location = new System.Drawing.Point(80, 16);
			this.lblYellowCard.Name = "lblYellowCard";
			this.lblYellowCard.Size = new System.Drawing.Size(16, 24);
			this.lblYellowCard.TabIndex = 3;
			this.lblYellowCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRedCard
			// 
			this.lblRedCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRedCard.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblRedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.lblRedCard.ForeColor = System.Drawing.Color.Navy;
			this.lblRedCard.Location = new System.Drawing.Point(96, 16);
			this.lblRedCard.Name = "lblRedCard";
			this.lblRedCard.Size = new System.Drawing.Size(16, 24);
			this.lblRedCard.TabIndex = 4;
			this.lblRedCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTimeIn
			// 
			this.lblTimeIn.Location = new System.Drawing.Point(8, -1);
			this.lblTimeIn.Name = "lblTimeIn";
			this.lblTimeIn.Size = new System.Drawing.Size(56, 18);
			this.lblTimeIn.TabIndex = 6;
			this.lblTimeIn.Text = "TimeIn";
			this.lblTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTimeOut
			// 
			this.lblTimeOut.Location = new System.Drawing.Point(56, -1);
			this.lblTimeOut.Name = "lblTimeOut";
			this.lblTimeOut.Size = new System.Drawing.Size(56, 18);
			this.lblTimeOut.TabIndex = 7;
			this.lblTimeOut.Text = "TimeOut";
			this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblLate);
			this.panel1.Controls.Add(this.lblYellowCard);
			this.panel1.Controls.Add(this.picStatus);
			this.panel1.Controls.Add(this.lblRedCard);
			this.panel1.Controls.Add(this.lblTimeOut);
			this.panel1.Controls.Add(this.lblTimeIn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 136);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 48);
			this.panel1.TabIndex = 8;
			// 
			// lblLate
			// 
			this.lblLate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblLate.Location = new System.Drawing.Point(40, 20);
			this.lblLate.Name = "lblLate";
			this.lblLate.Size = new System.Drawing.Size(40, 24);
			this.lblLate.TabIndex = 8;
			// 
			// ctrStatusBox
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.picEmployee);
			this.Controls.Add(this.lblEmployeeName);
			this.Name = "ctrStatusBox";
			this.Size = new System.Drawing.Size(120, 184);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void picEmployee_Click(object sender, System.EventArgs e)
		{
//            MessageBox.Show("Hello Chính"+lblEmployeeName.Text);
			ShowEmployeeDetail();
		}

		private void picEmployee_MouseHover(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}
		/// <summary>
		/// Hiển thị thông tin chi tiết nhân viên trong ảnh
		/// </summary>
		private void ShowEmployeeDetail()
		{
			UI.Employee.frmEmployee frmemployee = new frmEmployee();
			employeeDO = new EmployeeDO();
			dsEmployee = employeeDO.GetEmployeeProfile(EmployeeID);
			frmemployee.EmployeeDataSet= dsEmployee; 
			frmemployee.SelectedEmployee = selectedEmployee;
			frmemployee.ShowDialog();
			
		}

		private void lblEmployeeName_MouseHover(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.Hand;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			
		}

		private void lblEmployeeName_Click(object sender, System.EventArgs e)
		{
			ShowEmployeeDetail();
		}

		private void lblEmployeeName_MouseLeave(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.Default;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
		}

		private void picEmployee_MouseLeave(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void picEmployee_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblEmployeeName_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Hand;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
		}


	}
}
