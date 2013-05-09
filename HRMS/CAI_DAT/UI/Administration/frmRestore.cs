using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Security;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using EVsoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmRestore : System.Windows.Forms.Form
	{
		private SystemProcess sysProcess = new SystemProcess();
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox UserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton SQLServer;
		private System.Windows.Forms.RadioButton rdoWindowsIntergrated;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBackUpFile;
		private System.Windows.Forms.Button BackUp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox DatabaseList;
		private System.Windows.Forms.RadioButton NewDatabase;
		private System.Windows.Forms.RadioButton ExistingDatabase;
		private System.Windows.Forms.TextBox txtDataBasePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDataBaseName;
		private System.Windows.Forms.Button btnPathToSaveFile;
		private System.Windows.Forms.Button btnChooseExistDatabases;
		private System.Windows.Forms.ProgressBar pbar;
		private System.Windows.Forms.Panel SQLServerPanel;
		private System.Windows.Forms.Panel FilePanel;
		private System.Windows.Forms.Panel ProgressPanel;
		private System.Windows.Forms.Panel WelcomePanel;
		private System.Windows.Forms.Panel DestinationPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button Finish;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button Previous;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel FinishPanel;
		private System.Windows.Forms.Label FinsihLabel;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboServer;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRestore()
		{
			//
			// Required for rdoWindowsIntergrated Form Designer support
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
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region rdoWindowsIntergrated Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.UserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SQLServer = new System.Windows.Forms.RadioButton();
			this.rdoWindowsIntergrated = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBackUpFile = new System.Windows.Forms.TextBox();
			this.BackUp = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.DatabaseList = new System.Windows.Forms.ComboBox();
			this.NewDatabase = new System.Windows.Forms.RadioButton();
			this.ExistingDatabase = new System.Windows.Forms.RadioButton();
			this.txtDataBasePath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDataBaseName = new System.Windows.Forms.TextBox();
			this.btnPathToSaveFile = new System.Windows.Forms.Button();
			this.btnChooseExistDatabases = new System.Windows.Forms.Button();
			this.pbar = new System.Windows.Forms.ProgressBar();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.SQLServerPanel = new System.Windows.Forms.Panel();
			this.FilePanel = new System.Windows.Forms.Panel();
			this.ProgressPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.WelcomePanel = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.DestinationPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Finish = new System.Windows.Forms.Button();
			this.Next = new System.Windows.Forms.Button();
			this.Previous = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.FinishPanel = new System.Windows.Forms.Panel();
			this.FinsihLabel = new System.Windows.Forms.Label();
			this.cboServer = new System.Windows.Forms.ComboBox();
			this.SQLServerPanel.SuspendLayout();
			this.FilePanel.SuspendLayout();
			this.ProgressPanel.SuspendLayout();
			this.WelcomePanel.SuspendLayout();
			this.DestinationPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.FinishPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(6, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// Password
			// 
			this.Password.Enabled = false;
			this.Password.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.Password.Location = new System.Drawing.Point(152, 192);
			this.Password.Name = "Password";
			this.Password.PasswordChar = '•';
			this.Password.Size = new System.Drawing.Size(144, 21);
			this.Password.TabIndex = 19;
			this.Password.Text = "";
			// 
			// label5
			// 
			this.label5.Enabled = false;
			this.label5.Location = new System.Drawing.Point(56, 192);
			this.label5.Name = "label5";
			this.label5.TabIndex = 18;
			this.label5.Text = "&Password:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserName
			// 
			this.UserName.Enabled = false;
			this.UserName.Location = new System.Drawing.Point(152, 160);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(144, 20);
			this.UserName.TabIndex = 17;
			this.UserName.Text = "";
			// 
			// label4
			// 
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(56, 160);
			this.label4.Name = "label4";
			this.label4.TabIndex = 16;
			this.label4.Text = "&Login name:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SQLServer
			// 
			this.SQLServer.Location = new System.Drawing.Point(24, 128);
			this.SQLServer.Name = "SQLServer";
			this.SQLServer.Size = new System.Drawing.Size(176, 24);
			this.SQLServer.TabIndex = 15;
			this.SQLServer.Text = "S&QL Server authentication";
			// 
			// rdoWindowsIntergrated
			// 
			this.rdoWindowsIntergrated.Checked = true;
			this.rdoWindowsIntergrated.Location = new System.Drawing.Point(24, 96);
			this.rdoWindowsIntergrated.Name = "rdoWindowsIntergrated";
			this.rdoWindowsIntergrated.Size = new System.Drawing.Size(256, 24);
			this.rdoWindowsIntergrated.TabIndex = 14;
			this.rdoWindowsIntergrated.TabStop = true;
			this.rdoWindowsIntergrated.Text = "Windows Intergrated authentication";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 32);
			this.label3.Name = "label3";
			this.label3.TabIndex = 12;
			this.label3.Text = "&SQL Server:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBackUpFile
			// 
			this.txtBackUpFile.Location = new System.Drawing.Point(24, 72);
			this.txtBackUpFile.Name = "txtBackUpFile";
			this.txtBackUpFile.Size = new System.Drawing.Size(256, 20);
			this.txtBackUpFile.TabIndex = 22;
			this.txtBackUpFile.Text = "";
			// 
			// BackUp
			// 
			this.BackUp.Location = new System.Drawing.Point(288, 72);
			this.BackUp.Name = "BackUp";
			this.BackUp.Size = new System.Drawing.Size(24, 20);
			this.BackUp.TabIndex = 23;
			this.BackUp.Text = "...";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "&Backup File Address:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DatabaseList
			// 
			this.DatabaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DatabaseList.Enabled = false;
			this.DatabaseList.Location = new System.Drawing.Point(160, 34);
			this.DatabaseList.Name = "DatabaseList";
			this.DatabaseList.Size = new System.Drawing.Size(146, 21);
			this.DatabaseList.TabIndex = 32;
			// 
			// NewDatabase
			// 
			this.NewDatabase.Checked = true;
			this.NewDatabase.Location = new System.Drawing.Point(16, 64);
			this.NewDatabase.Name = "NewDatabase";
			this.NewDatabase.Size = new System.Drawing.Size(120, 24);
			this.NewDatabase.TabIndex = 31;
			this.NewDatabase.TabStop = true;
			this.NewDatabase.Text = "&Tạo database mới";
			// 
			// ExistingDatabase
			// 
			this.ExistingDatabase.Location = new System.Drawing.Point(16, 32);
			this.ExistingDatabase.Name = "ExistingDatabase";
			this.ExistingDatabase.Size = new System.Drawing.Size(128, 24);
			this.ExistingDatabase.TabIndex = 30;
			this.ExistingDatabase.Text = "&Database đã tồn tại";
			// 
			// txtDataBasePath
			// 
			this.txtDataBasePath.Location = new System.Drawing.Point(160, 122);
			this.txtDataBasePath.Name = "txtDataBasePath";
			this.txtDataBasePath.Size = new System.Drawing.Size(144, 20);
			this.txtDataBasePath.TabIndex = 27;
			this.txtDataBasePath.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 120);
			this.label2.Name = "label2";
			this.label2.TabIndex = 26;
			this.label2.Text = "Chọn đường dẫn ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 88);
			this.label1.Name = "label1";
			this.label1.TabIndex = 24;
			this.label1.Text = "&Tên database";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDataBaseName
			// 
			this.txtDataBaseName.Location = new System.Drawing.Point(160, 90);
			this.txtDataBaseName.Name = "txtDataBaseName";
			this.txtDataBaseName.Size = new System.Drawing.Size(144, 20);
			this.txtDataBaseName.TabIndex = 25;
			this.txtDataBaseName.Text = "";
			// 
			// btnPathToSaveFile
			// 
			this.btnPathToSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPathToSaveFile.Location = new System.Drawing.Point(309, 123);
			this.btnPathToSaveFile.Name = "btnPathToSaveFile";
			this.btnPathToSaveFile.Size = new System.Drawing.Size(24, 20);
			this.btnPathToSaveFile.TabIndex = 29;
			this.btnPathToSaveFile.Text = "...";
			// 
			// btnChooseExistDatabases
			// 
			this.btnChooseExistDatabases.Enabled = false;
			this.btnChooseExistDatabases.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnChooseExistDatabases.Location = new System.Drawing.Point(309, 35);
			this.btnChooseExistDatabases.Name = "btnChooseExistDatabases";
			this.btnChooseExistDatabases.Size = new System.Drawing.Size(24, 20);
			this.btnChooseExistDatabases.TabIndex = 28;
			this.btnChooseExistDatabases.Text = "...";
			// 
			// pbar
			// 
			this.pbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pbar.Location = new System.Drawing.Point(56, 104);
			this.pbar.Name = "pbar";
			this.pbar.Size = new System.Drawing.Size(352, 16);
			this.pbar.TabIndex = 3;
			// 
			// StatusLabel
			// 
			this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.StatusLabel.Location = new System.Drawing.Point(16, 40);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(424, 32);
			this.StatusLabel.TabIndex = 2;
			// 
			// SQLServerPanel
			// 
			this.SQLServerPanel.Controls.Add(this.UserName);
			this.SQLServerPanel.Controls.Add(this.Password);
			this.SQLServerPanel.Controls.Add(this.label3);
			this.SQLServerPanel.Controls.Add(this.rdoWindowsIntergrated);
			this.SQLServerPanel.Controls.Add(this.SQLServer);
			this.SQLServerPanel.Controls.Add(this.label4);
			this.SQLServerPanel.Controls.Add(this.label5);
			this.SQLServerPanel.Controls.Add(this.pictureBox1);
			this.SQLServerPanel.Controls.Add(this.cboServer);
			this.SQLServerPanel.Location = new System.Drawing.Point(0, 80);
			this.SQLServerPanel.Name = "SQLServerPanel";
			this.SQLServerPanel.Size = new System.Drawing.Size(464, 264);
			this.SQLServerPanel.TabIndex = 35;
			// 
			// FilePanel
			// 
			this.FilePanel.Controls.Add(this.label6);
			this.FilePanel.Controls.Add(this.BackUp);
			this.FilePanel.Controls.Add(this.txtBackUpFile);
			this.FilePanel.Location = new System.Drawing.Point(0, 80);
			this.FilePanel.Name = "FilePanel";
			this.FilePanel.Size = new System.Drawing.Size(464, 264);
			this.FilePanel.TabIndex = 36;
			// 
			// ProgressPanel
			// 
			this.ProgressPanel.Controls.Add(this.label11);
			this.ProgressPanel.Controls.Add(this.pbar);
			this.ProgressPanel.Controls.Add(this.StatusLabel);
			this.ProgressPanel.Location = new System.Drawing.Point(0, 80);
			this.ProgressPanel.Name = "ProgressPanel";
			this.ProgressPanel.Size = new System.Drawing.Size(464, 264);
			this.ProgressPanel.TabIndex = 37;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Location = new System.Drawing.Point(16, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Please wait...";
			// 
			// WelcomePanel
			// 
			this.WelcomePanel.Controls.Add(this.label10);
			this.WelcomePanel.Location = new System.Drawing.Point(0, 80);
			this.WelcomePanel.Name = "WelcomePanel";
			this.WelcomePanel.Size = new System.Drawing.Size(464, 264);
			this.WelcomePanel.TabIndex = 38;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(448, 88);
			this.label10.TabIndex = 0;
			this.label10.Text = "Hãy làm theo hướng dẫn để thực hiện việc khôi phục dữ liệu";
			// 
			// DestinationPanel
			// 
			this.DestinationPanel.Controls.Add(this.btnChooseExistDatabases);
			this.DestinationPanel.Controls.Add(this.btnPathToSaveFile);
			this.DestinationPanel.Controls.Add(this.txtDataBaseName);
			this.DestinationPanel.Controls.Add(this.label1);
			this.DestinationPanel.Controls.Add(this.label2);
			this.DestinationPanel.Controls.Add(this.txtDataBasePath);
			this.DestinationPanel.Controls.Add(this.ExistingDatabase);
			this.DestinationPanel.Controls.Add(this.NewDatabase);
			this.DestinationPanel.Controls.Add(this.DatabaseList);
			this.DestinationPanel.Location = new System.Drawing.Point(0, 80);
			this.DestinationPanel.Name = "DestinationPanel";
			this.DestinationPanel.Size = new System.Drawing.Size(464, 264);
			this.DestinationPanel.TabIndex = 39;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 48);
			this.panel1.TabIndex = 40;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(384, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(368, 32);
			this.label9.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(176, 24);
			this.label8.TabIndex = 0;
			this.label8.Text = "Khôi phục dữ liệu";
			// 
			// Finish
			// 
			this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Finish.Location = new System.Drawing.Point(376, 352);
			this.Finish.Name = "Finish";
			this.Finish.Size = new System.Drawing.Size(80, 24);
			this.Finish.TabIndex = 42;
			this.Finish.Text = "&Kết thúc";
			this.Finish.Click += new System.EventHandler(this.Finish_Click);
			// 
			// Next
			// 
			this.Next.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Next.Location = new System.Drawing.Point(288, 352);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(80, 24);
			this.Next.TabIndex = 42;
			this.Next.Text = "&Tiếp tục >";
			this.Next.Click += new System.EventHandler(this.Next_Click);
			// 
			// Previous
			// 
			this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Previous.Location = new System.Drawing.Point(200, 352);
			this.Previous.Name = "Previous";
			this.Previous.Size = new System.Drawing.Size(80, 24);
			this.Previous.TabIndex = 42;
			this.Previous.Text = "< &Trở lại";
			this.Previous.Click += new System.EventHandler(this.Previous_Click);
			// 
			// Cancel
			// 
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Cancel.Location = new System.Drawing.Point(112, 352);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(80, 24);
			this.Cancel.TabIndex = 42;
			this.Cancel.Text = "Hủy";
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 339);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 7);
			this.groupBox1.TabIndex = 43;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(0, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(464, 7);
			this.groupBox2.TabIndex = 45;
			this.groupBox2.TabStop = false;
			// 
			// FinishPanel
			// 
			this.FinishPanel.Controls.Add(this.FinsihLabel);
			this.FinishPanel.Location = new System.Drawing.Point(0, 80);
			this.FinishPanel.Name = "FinishPanel";
			this.FinishPanel.Size = new System.Drawing.Size(464, 264);
			this.FinishPanel.TabIndex = 46;
			// 
			// FinsihLabel
			// 
			this.FinsihLabel.Location = new System.Drawing.Point(8, 16);
			this.FinsihLabel.Name = "FinsihLabel";
			this.FinsihLabel.Size = new System.Drawing.Size(448, 88);
			this.FinsihLabel.TabIndex = 0;
			// 
			// cboServer
			// 
			this.cboServer.Location = new System.Drawing.Point(152, 32);
			this.cboServer.Name = "cboServer";
			this.cboServer.Size = new System.Drawing.Size(144, 21);
			this.cboServer.TabIndex = 33;
			this.cboServer.Click += new System.EventHandler(this.cboServer_Click);
			// 
			// frmRestore
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 384);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.Finish);
			this.Controls.Add(this.Next);
			this.Controls.Add(this.Previous);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.DestinationPanel);
			this.Controls.Add(this.ProgressPanel);
			this.Controls.Add(this.FilePanel);
			this.Controls.Add(this.SQLServerPanel);
			this.Controls.Add(this.FinishPanel);
			this.Controls.Add(this.WelcomePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRestore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khôi phục dữ liệu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SQLServerPanel.ResumeLayout(false);
			this.FilePanel.ResumeLayout(false);
			this.ProgressPanel.ResumeLayout(false);
			this.WelcomePanel.ResumeLayout(false);
			this.DestinationPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.FinishPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmRestore());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
			rdoWindowsIntergrated.Text = "Windows Intergrated authentication";
			this.rdoWindowsIntergrated.CheckedChanged += new EventHandler(OnChangeAuthenticationType);
			this.SQLServer.CheckedChanged += new EventHandler(OnChangeAuthenticationType);

			this.ExistingDatabase.CheckedChanged += new EventHandler(OnChangeDestination);
			this.NewDatabase.CheckedChanged += new EventHandler(OnChangeDestination);

			this.BackUp.Click += new EventHandler(this.BackUp_Click);

			this.btnPathToSaveFile.Click += new EventHandler(this.Path_Click);

			this.Navigate(true);

			//			this.introductionPage1.IntroductionText = @"This wizard helps you restore a database in different Microsoft SQL Server database.
			//
			//
			//
			//Programmer : Phorozan@gmail.com";

		}
		private void OnChangeAuthenticationType(object sender , EventArgs e)
		{
			bool b = !(this.rdoWindowsIntergrated.Checked);
			this.UserName.Enabled = b;
			this.Password.Enabled = b;
			this.label4.Enabled = b;
			this.label5.Enabled = b;

			if(((RadioButton)sender).Name == "SQLServer" && ((RadioButton)sender).Checked)
			{
				this.UserName.Focus();
				this.UserName.SelectAll();
			}

		}
		

		private void OnChangeDestination(object sender , EventArgs e)
		{
			bool b = !(this.ExistingDatabase.Checked);
			this.txtDataBaseName.Enabled = b;
			this.txtDataBasePath.Enabled = b;
			this.label1.Enabled = b;
			this.label2.Enabled = b;
			this.btnPathToSaveFile.Enabled = b;

			this.DatabaseList.Enabled= !b;
			this.btnChooseExistDatabases.Enabled= !b;


			if(((RadioButton)sender).Name == "NewDatabase" && ((RadioButton)sender).Checked)
			{
				this.txtDataBaseName.Focus();
				this.txtDataBaseName.SelectAll();
			}
			else
			{
				this.DatabaseList.Focus();
				this.FillDatabaseList(this.ConnectionStr());
			}

		}

		private void Path_Click(object sender, System.EventArgs e)
		{
			
			FolderBrowserDialog f = new FolderBrowserDialog();

			f.ShowNewFolderButton = true;

			f.Description = "Select path to create new database:";

			if(System.IO.Directory.Exists(this.txtDataBasePath.Text))
				f.SelectedPath = this.txtDataBasePath.Text;

			if (f.ShowDialog()==DialogResult.OK)
				this.txtDataBasePath.Text = f.SelectedPath;
			
			f.Dispose();
		}

		private string ConnectionStr()
		{

			string s;

			s = string.Format("Server={0};",this.cboServer.SelectedItem.ToString());

			if(this.rdoWindowsIntergrated.Checked)
				s += "Trusted_Connection=True;";
			else
				s += string.Format("UId={0};PWD={1};",this.UserName.Text,this.Password.Text);

			s+="Connect Timeout=1;Max Pool Size=1;Connection Lifetime=10;";
			return s;
		}

		private void FillDatabaseList(string ConnectionString)
		{
			this.DatabaseList.Items.Clear();

			SqlConnection	connection	= new SqlConnection(ConnectionString);
			SqlCommand		cmd			= connection.CreateCommand();
			SqlDataReader	reader;

			cmd.CommandText = "Select Name From sysDatabases";

			try
			{

				connection.Open();
                
				reader = cmd.ExecuteReader();

				string Database="";
				while(reader.Read())
				{
					Database = reader.GetString(0);
					if(Database != "master" && Database != "model" && Database != "msdb" && Database != "tempdb" )
						this.DatabaseList.Items.Add(Database);
				}

				
				reader.Close();

				(reader as IDisposable).Dispose();
				
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.ToString(),"SQL Server Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			finally
			{
				if(connection.State == ConnectionState.Open)
					connection.Close();
			

				cmd.Dispose();

				connection.Dispose();

				if(this.DatabaseList.Items.Count>0)
					this.DatabaseList.SelectedIndex = 0;
			}

		}

		private void RefreshDatabases_Click(object sender, System.EventArgs e)
		{
			this.FillDatabaseList(this.ConnectionStr());
		}

		//		private bool CheckInput()
		//		{
		//			if (this.Server.Text == "")
		//			{
		//				MessageBox.Show("Specify SQL Server .","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//				this.Server.Focus();
		//
		//				return false;
		//			}
		//
		//			if (this.UserName.Text == "" && this.SQLServer.Checked == true)
		//			{
		//				MessageBox.Show("Enter User Name.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//				this.UserName.Focus();
		//
		//				return false;
		//			}
		//
		//			if(!System.IO.File.Exists(this.txtBackUpFile.Text))
		//			{
		//				MessageBox.Show("Select BackUp File.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//				this.UserName.Focus();
		//
		//				return false;
		//			}
		//			if (this.ExistingDatabase.Checked)
		//			{
		//
		//				if(this.DatabaseList.SelectedIndex < 0)
		//				{
		//					MessageBox.Show("Select Database.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//					this.DatabaseList.Focus();
		//
		//					return false;
		//				}
		//			}
		//			else
		//			{
		//				if(this.txtDataBaseName.Text=="")
		//				{
		//					MessageBox.Show("Enter Database Name.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//					this.txtDataBaseName.Focus();
		//
		//					return false;
		//				}
		//				if(!System.IO.Directory.Exists(this.txtDataBasePath.Text))
		//				{
		//					MessageBox.Show("Enter a valid path.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		//
		//					this.txtDataBasePath.Focus();
		//
		//					return false;
		//				}
		//			}
		//			
		//			return true;
		//		}
		

		private bool GetFileRestored(string ConnectionString,string DatabaseName,ref string DataFile , ref string LogFile)
		{
			SqlConnection	connection	= new SqlConnection(ConnectionString);
			SqlCommand		cmd			= connection.CreateCommand();
			SqlDataReader	reader;
			
			cmd.CommandText = this.PrepareCommand("Restore.sql",DatabaseName);

			try
			{

				connection.Open();

				reader = cmd.ExecuteReader();

				while(reader.Read())
				{
					if(reader.GetString(2)=="D")
						DataFile = reader.GetString(0);
					else
						LogFile = reader.GetString(0);
				}

				reader.Close();

				(reader as IDisposable).Dispose();

			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.ToString(),"SQL Server Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				return false;
			}
			finally
			{
				if(connection.State == ConnectionState.Open)
					connection.Close();
			
				cmd.Dispose();

				connection.Dispose();

			}
			return true;
		}
		private string PrepareCommand(string fileName , string databaseName)
		{
			string Commands = this.LoadSQLFromAssembly(fileName);

			if (Commands == null)
				return null;

			Commands = Commands.Replace("%Database%" , databaseName);

			Commands = Commands.Replace("%DatabasePath%" , this.txtDataBasePath.Text + "\\");

			Commands = Commands.Replace("%BackUpPath%" , this.txtBackUpFile.Text);

			return Commands;

		}

		private bool ExecuteSQLCommand(string ConnectionString , string Commands)
		{

			SqlConnection	connection	= new SqlConnection(ConnectionString);
			SqlCommand		cmd			= connection.CreateCommand();

			cmd.CommandText = Commands;

			try
			{

				connection.Open();

				cmd.ExecuteNonQuery();

			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.ToString(),"SQL Server Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				return false;
			}
			finally
			{
				if(connection.State == ConnectionState.Open)
					connection.Close();
			
				cmd.Dispose();

				connection.Dispose();

			}

			return true;
		}
		private string LoadSQLFromAssembly (string fileName)
		{
			System.IO.Stream stream = null;
			try
			{
				stream = this.GetType().Assembly.GetManifestResourceStream("EVSoft.HRMS.SQL." + fileName);
			}
			catch(ArgumentNullException ex1)
			{
				MessageBox.Show("ArgumentNullException: " + ex1.ToString());
			}
			catch(ArgumentException ex2)
			{
				MessageBox.Show("ArgumentException: " + ex2.ToString());
			}
			catch(SecurityException ex3)
			{
				MessageBox.Show("SecurityException: " + ex3.ToString());
			}

			if(stream == null)
			{
				MessageBox.Show("Internal Error occured! Close Application & try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

				return null;
			}

			System.IO.StreamReader reader= new System.IO.StreamReader(stream);

//			System.IO.StreamReader reader= new System.IO.StreamReader(Application.StartupPath+"/SQL/"+fileName);
			
			if (reader == null)
			{
				MessageBox.Show("Internal Error occured! Close Application & try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

				return null;
			}

			string s = reader.ReadToEnd();

			reader.Close();

			return s;
								
		}

		private void BackUp_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog f = new OpenFileDialog();

			f.Filter = "SQL Server BackUp Files|*.bak|All Files|*.*";

			f.Title = "Open Backup File";

			if(System.IO.File.Exists(this.txtBackUpFile.Text))

				f.FileName = this.txtBackUpFile.Text;

			if(f.ShowDialog()==DialogResult.OK)
			{
				this.txtBackUpFile.Text = f.FileName;
			}

			f.Dispose();
		}

		#region Validation

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool Validate_File()
		{
			if(!System.IO.File.Exists(this.txtBackUpFile.Text))
			{
				MessageBox.Show("Select BackUp File.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				this.UserName.Focus();

				return false;
			}
			return true;
		}
		/// <summary>
		/// Check connection to SQL server
		/// </summary>
		/// <returns></returns>
		private bool Validate_SQLServer()
		{

			SqlConnection connection	= new SqlConnection(this.ConnectionStr());
			
			try
			{
				connection.Open();
				connection.Close();
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				connection.Dispose();
			}
			
			
		}


		private bool Validate_Destination()
		{
			if (this.ExistingDatabase.Checked)
			{

				if(this.DatabaseList.SelectedIndex < 0)
				{
					MessageBox.Show("Select Database.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

					this.DatabaseList.Focus();

					return false;
				}
			}
			else
			{
				if(this.txtDataBaseName.Text=="")
				{
					MessageBox.Show("Enter Database Name.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

					this.txtDataBaseName.Focus();

					return false;
				}
				if(this.DatabaseList.Items.Contains(this.txtDataBaseName.Text))
				{

					MessageBox.Show("Database already exists!","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

					this.txtDataBaseName.Focus();

					return false;
				}
				if(!System.IO.Directory.Exists(this.txtDataBasePath.Text))
				{
					MessageBox.Show("Enter a valid path.","User",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

					this.txtDataBasePath.Focus();

					return false;
				}
			}
			return true;
		}
		#endregion

		private void DoRestore()
		{
			
			this.StatusLabel.Text = "Gathering information about operation...";

			this.SetProgressBar(0);

			string Commands , DataFile="" , LogFile ="" , DatabaseName ="";

			if(this.NewDatabase.Checked)
			{
			
				Commands =  this.PrepareCommand("CreateNewDatabase.sql" , this.txtDataBaseName.Text);

				if(Commands == null)
				{
					this.FinsihLabel.Text = "Wizard can not do operation!";

					this.Navigate(true);

					return;
				}

				this.StatusLabel.Text = string.Format( "Creating new database with name {0} ..." , this.txtDataBaseName.Text) ;

				this.SetProgressBar(10);

				if(this.ExecuteSQLCommand(this.ConnectionStr() , Commands))
				{
					this.StatusLabel.Text = "Database Created Successfully!" ;
				}
				else
				{
					return;
				}

				this.SetProgressBar(40);

				DatabaseName = this.txtDataBaseName.Text;

			}
			else
			{
				this.StatusLabel.Text = "" ;

				DatabaseName = this.DatabaseList.SelectedItem.ToString();

			}

			this.StatusLabel.Text += string.Format( "\nLoading {0} ..." , this.txtBackUpFile.Text) ;

			this.SetProgressBar(50);

			if (this.GetFileRestored(this.ConnectionStr(),DatabaseName,ref DataFile , ref LogFile))
			{
				this.StatusLabel.Text = "Generating SQL scripts ..." ;

				Commands =  this.PrepareCommand("RestoreFinall.sql" , DatabaseName);

				if(Commands == null)
				{
					this.FinsihLabel.Text = "Wizard can not do operation!";

					this.Navigate(true);

					return;
				}

				this.StatusLabel.Text = "Finalizing SQL scripts ..." ;

				this.SetProgressBar(60);

				Commands = Commands.Replace("%OldData%" , DataFile).Replace("%OldLog%",LogFile);
                
				this.SetProgressBar(70);

				this.StatusLabel.Text = "Finalizing operation ..." ;

				this.ExecuteSQLCommand(this.ConnectionStr() , Commands);

				this.StatusLabel.Text = "Operation successfully done." ;

				this.SetProgressBar(100);
			}

			this.FinsihLabel.Text = string.Format ("Restore wizard successfully finished. Result : \n\nFile {0} successfully restore to {1}.",this.txtBackUpFile.Text , DatabaseName);

			this.Navigate(true);

		}
		private void SetProgressBar(int value)
		{

			this.pbar.Value = value;

			Application.DoEvents();
		}


		private int Pointer = 0;
		private const int MaxPages = 6;
		private void Navigate(bool forward)
		{

			Pointer = forward ? Pointer + 1 : ((Pointer == MaxPages) ? Pointer - 2 : Pointer - 1);

			this.Previous.Enabled = (Pointer == 1) ? false : true;

			this.Next.Enabled = (Pointer == MaxPages) ? false : true;

			this.Finish.Enabled = !this.Next.Enabled;

			this.Cancel.Enabled = this.Next.Enabled;

			this.WelcomePanel.Visible = (Pointer == 1 ) ? true : false;

			this.SQLServerPanel.Visible = (Pointer == 2 ) ? true : false;

			this.FilePanel.Visible = (Pointer == 3 ) ? true : false;

			this.DestinationPanel.Visible = (Pointer == 4 ) ? true : false;

			this.ProgressPanel.Visible = (Pointer == 5 ) ? true : false;

			this.FinishPanel.Visible = (Pointer == 6 ) ? true : false;

			if(Pointer == 5)
			{

				this.Cancel.Enabled = false;

				this.Finish.Enabled = false;

				this.Next.Enabled = false;

				this.Previous.Enabled = false;

				this.DoRestore();
			}

			if(Pointer == 3)
			{
				this.FillDatabaseList(this.ConnectionStr());
			}
			
		}

		private void Next_Click(object sender, System.EventArgs e)
		{
			switch(this.Pointer)
			{
				case 2 :
					if (cboServer.Text=="")
					{
						MessageBox.Show("Connection false" ,"Restore fail",MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
						this.Navigate(false);
					}
					else
						if(!this.Validate_SQLServer())
						return;
					break;
				case 3:
					if(!this.Validate_File())
						return;
					break;
				case 4:
					if(!this.Validate_Destination())
						return;
					break;
			}

			this.Navigate(true);
		}

		private void Previous_Click(object sender, System.EventArgs e)
		{
			this.Navigate(false);
		}

		private void Finish_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Cancel_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Are you sure want to cancel wizard?","Restore Database",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
				return;

			this.Close();
		}

		private void cboServer_Click(object sender, System.EventArgs e)
		{
			LoadServerCbo();
		}
		/// <summary>
		/// Get all instances of Database Server on Network
		/// </summary>
		private void LoadServerCbo()
		{
			string[] server = sysProcess.GetServers();
			cboServer.DataSource = server;
			
		}
		
	}
}
