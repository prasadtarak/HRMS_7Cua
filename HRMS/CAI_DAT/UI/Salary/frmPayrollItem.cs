using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EVSoft.HRMS.UI.Salary
{
	/// <summary>
	/// Summary description for frmPayrollItem.
	/// </summary>
	public class frmPayrollItem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblPayrollItemID;
		private System.Windows.Forms.TextBox txtPayrollItemID;
		private System.Windows.Forms.TextBox txtPIName;
		private System.Windows.Forms.Label lblPIName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.ComboBox comboBox10;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPayrollItem()
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
			this.lblPayrollItemID = new System.Windows.Forms.Label();
			this.txtPayrollItemID = new System.Windows.Forms.TextBox();
			this.txtPIName = new System.Windows.Forms.TextBox();
			this.lblPIName = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPIName);
			this.groupBox1.Controls.Add(this.lblPIName);
			this.groupBox1.Controls.Add(this.txtPayrollItemID);
			this.groupBox1.Controls.Add(this.lblPayrollItemID);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lblPayrollItemID
			// 
			this.lblPayrollItemID.Location = new System.Drawing.Point(8, 16);
			this.lblPayrollItemID.Name = "lblPayrollItemID";
			this.lblPayrollItemID.Size = new System.Drawing.Size(80, 23);
			this.lblPayrollItemID.TabIndex = 0;
			this.lblPayrollItemID.Text = "&Mã khoản";
			this.lblPayrollItemID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPayrollItemID
			// 
			this.txtPayrollItemID.Location = new System.Drawing.Point(88, 16);
			this.txtPayrollItemID.Name = "txtPayrollItemID";
			this.txtPayrollItemID.Size = new System.Drawing.Size(112, 20);
			this.txtPayrollItemID.TabIndex = 1;
			this.txtPayrollItemID.Text = "";
			// 
			// txtPIName
			// 
			this.txtPIName.Location = new System.Drawing.Point(288, 16);
			this.txtPIName.Name = "txtPIName";
			this.txtPIName.Size = new System.Drawing.Size(280, 20);
			this.txtPIName.TabIndex = 3;
			this.txtPIName.Text = "";
			// 
			// lblPIName
			// 
			this.lblPIName.Location = new System.Drawing.Point(208, 16);
			this.lblPIName.Name = "lblPIName";
			this.lblPIName.Size = new System.Drawing.Size(80, 23);
			this.lblPIName.TabIndex = 2;
			this.lblPIName.Text = "&Tên khoản";
			this.lblPIName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox6);
			this.groupBox2.Controls.Add(this.comboBox5);
			this.groupBox2.Controls.Add(this.comboBox4);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(8, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(408, 192);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Loại khoản";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(208, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Loại thu nhập";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(88, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(112, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Hệ số";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(208, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tính thuế TN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(88, 64);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(288, 20);
			this.textBox5.TabIndex = 11;
			this.textBox5.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Công thức";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "TK chi phí";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "...";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(88, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 21);
			this.comboBox1.TabIndex = 15;
			// 
			// comboBox2
			// 
			this.comboBox2.Location = new System.Drawing.Point(288, 16);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(112, 21);
			this.comboBox2.TabIndex = 16;
			// 
			// comboBox3
			// 
			this.comboBox3.Location = new System.Drawing.Point(288, 40);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(112, 21);
			this.comboBox3.TabIndex = 17;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(312, 20);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "Giá thành";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(208, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "TK chi phí";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "TK chi phí";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(288, 136);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(112, 20);
			this.textBox7.TabIndex = 25;
			this.textBox7.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(208, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "TK chi phí";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(88, 160);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(312, 20);
			this.textBox8.TabIndex = 27;
			this.textBox8.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 26;
			this.label11.Text = "Giá thành";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox4
			// 
			this.comboBox4.Location = new System.Drawing.Point(88, 136);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(112, 21);
			this.comboBox4.TabIndex = 28;
			// 
			// comboBox5
			// 
			this.comboBox5.Location = new System.Drawing.Point(88, 88);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(112, 21);
			this.comboBox5.TabIndex = 29;
			// 
			// comboBox6
			// 
			this.comboBox6.Location = new System.Drawing.Point(288, 88);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(112, 21);
			this.comboBox6.TabIndex = 30;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox8);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.comboBox7);
			this.groupBox3.Location = new System.Drawing.Point(424, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(160, 88);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Liên quan thuế";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboBox9);
			this.groupBox4.Controls.Add(this.comboBox10);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Location = new System.Drawing.Point(424, 160);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(160, 96);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chấm công";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(432, 264);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "&Đồng ý";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(512, 264);
			this.button3.Name = "button3";
			this.button3.TabIndex = 6;
			this.button3.Text = "&Hủy bỏ";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 18;
			this.label13.Text = "Loại khoản";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 23);
			this.label12.TabIndex = 16;
			this.label12.Text = "Loại khoản";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 20;
			this.label14.Text = "Khoản nộp";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 23);
			this.label15.TabIndex = 19;
			this.label15.Text = "Loại thuế";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox7
			// 
			this.comboBox7.Location = new System.Drawing.Point(72, 16);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(80, 21);
			this.comboBox7.TabIndex = 31;
			// 
			// comboBox8
			// 
			this.comboBox8.Location = new System.Drawing.Point(72, 40);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(80, 21);
			this.comboBox8.TabIndex = 32;
			// 
			// comboBox9
			// 
			this.comboBox9.Location = new System.Drawing.Point(72, 40);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(80, 21);
			this.comboBox9.TabIndex = 34;
			// 
			// comboBox10
			// 
			this.comboBox10.Location = new System.Drawing.Point(72, 16);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(80, 21);
			this.comboBox10.TabIndex = 33;
			// 
			// frmPayrollItem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 294);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmPayrollItem";
			this.Text = " Khoản lương mới";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
