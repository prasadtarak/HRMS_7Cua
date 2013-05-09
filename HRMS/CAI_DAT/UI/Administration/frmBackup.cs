using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using EVsoft.HRMS.Common;
using SQLDMO;
using Application = System.Windows.Forms.Application;
//using System.ComponentModel.

namespace EVsoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for frmConnect.
	/// </summary>
	public class frmBackup : System.Windows.Forms.Form
	{
		private SystemProcess sysProcess = new SystemProcess();
		private Label label1;
		private ComboBox cboServer;
		private Button btnBackup;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog dlgSaveBackUp;
		private ComboBox cboSourceDatabase;
		private Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Finish;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton SQLServer;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUserNameDB;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdoWindowsIntergrated;
		private IContainer components;

		public frmBackup()
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveBackUp = new System.Windows.Forms.SaveFileDialog();
            this.cboSourceDatabase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserNameDB = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SQLServer = new System.Windows.Forms.RadioButton();
            this.rdoWindowsIntergrated = new System.Windows.Forms.RadioButton();
            this.Finish = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên máy chủ";
            // 
            // cboServer
            // 
            this.cboServer.Location = new System.Drawing.Point(144, 32);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(184, 21);
            this.cboServer.TabIndex = 1;
            this.cboServer.Click += new System.EventHandler(this.cboServer_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackup.Location = new System.Drawing.Point(288, 281);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(80, 24);
            this.btnBackup.TabIndex = 11;
            this.btnBackup.Text = "&Sao lưu";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // cboSourceDatabase
            // 
            this.cboSourceDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceDatabase.Location = new System.Drawing.Point(144, 152);
            this.cboSourceDatabase.Name = "cboSourceDatabase";
            this.cboSourceDatabase.Size = new System.Drawing.Size(184, 21);
            this.cboSourceDatabase.TabIndex = 14;
            this.cboSourceDatabase.Click += new System.EventHandler(this.cboSourceDatabase_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên CSDL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtUserNameDB);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.SQLServer);
            this.panel1.Controls.Add(this.rdoWindowsIntergrated);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboServer);
            this.panel1.Controls.Add(this.cboSourceDatabase);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 193);
            this.panel1.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(72, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 23);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtUserNameDB
            // 
            this.txtUserNameDB.Location = new System.Drawing.Point(144, 96);
            this.txtUserNameDB.Name = "txtUserNameDB";
            this.txtUserNameDB.Size = new System.Drawing.Size(184, 20);
            this.txtUserNameDB.TabIndex = 18;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(51, 96);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 24);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(144, 120);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(184, 20);
            this.txtPass.TabIndex = 20;
            // 
            // SQLServer
            // 
            this.SQLServer.Checked = true;
            this.SQLServer.Location = new System.Drawing.Point(48, 64);
            this.SQLServer.Name = "SQLServer";
            this.SQLServer.Size = new System.Drawing.Size(176, 24);
            this.SQLServer.TabIndex = 16;
            this.SQLServer.TabStop = true;
            this.SQLServer.Text = "S&QL Server authentication";
            // 
            // rdoWindowsIntergrated
            // 
            this.rdoWindowsIntergrated.Enabled = false;
            this.rdoWindowsIntergrated.Location = new System.Drawing.Point(20, 6);
            this.rdoWindowsIntergrated.Name = "rdoWindowsIntergrated";
            this.rdoWindowsIntergrated.Size = new System.Drawing.Size(160, 24);
            this.rdoWindowsIntergrated.TabIndex = 15;
            this.rdoWindowsIntergrated.Text = "&Windows authentication";
            this.rdoWindowsIntergrated.Visible = false;
            // 
            // Finish
            // 
            this.Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Finish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Finish.Location = new System.Drawing.Point(376, 281);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(80, 24);
            this.Finish.TabIndex = 45;
            this.Finish.Text = "Thoát";
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Thông số máy chủ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 80);
            this.panel2.TabIndex = 21;
            // 
            // frmBackup
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 311);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		

		//Tạo SQLDMO application
		//Tạo SQLDMO server
		SQLServer sqlSrv = new SQLServerClass();
		//Tạo SQLDMO database
		
		

	
		/// <summary>
		/// Huỷ kết nối trước đó
		/// </summary>
			private void disconnectDB()
			{
				if (sqlSrv != null )
					sqlSrv =null;
				sqlSrv =new SQLDMO.SQLServerClass();
			
			}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
			private bool connectDB()
			{
				
				bool b=false;	
				try
				{
					disconnectDB();
					sqlSrv.Connect(this.cboServer.Text.ToString(),this.txtUserNameDB.Text .Trim(),this.txtPass.Text.Trim());
	
					b=true;
					return b;
				}
				catch(Exception e)
				{
					MessageBox.Show("Can not connect to database!","Connect Database",MessageBoxButtons.OK,MessageBoxIcon.Information );
					return b;
				}
				
			}

		private void frmConnect_Load(object sender, EventArgs e)
		{
			
		}	
		/// <summary>
		/// 
		/// </summary>

		
		/// <summary>
		/// back up cơ sở dữ liệu đang chọn trong listbox lstDatabase
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBackup_Click(object sender, EventArgs e)
		{
			if (cboSourceDatabase.Text=="")
				MessageBox.Show("Connection false" ,"Backup fail",MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
			else
				backupToFile();
		}
		private void backupToFile()
	{
		//lọc file để lưu file backup chỉ có đuôi .bak
		dlgSaveBackUp.InitialDirectory = "C:\\" ;
		dlgSaveBackUp.Filter = "bak file(*.bak)|*.bak";
		dlgSaveBackUp.Title = "Nhập tên file sao lưu";
		dlgSaveBackUp.FileName = cboSourceDatabase.SelectedItem.ToString()+"_backup_"+DateTime.Now.Year+"_"+DateTime.Now.Month+"_"+DateTime.Now.Day;

		if(dlgSaveBackUp.ShowDialog() ==DialogResult.OK )
			{
				//tạo một đối tượng SQLDMO.Backup để thực hiện việc backup csdl
				SQLDMO.Backup bk=new SQLDMO.Backup();
				bk.Action =SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database;//kiểu backup toàn bộ csdl
				bk.Database=cboSourceDatabase.SelectedItem.ToString() ; //tên database cần backup
				
				//tao doi tuong backup device để lưu vào sql server, dùng lại khi restore
				SQLDMO.BackupDevice bkdv=new SQLDMO.BackupDevice ();
				
				string logicDevicename= GetFileName(dlgSaveBackUp.FileName);
				bkdv.Name=logicDevicename;
				bkdv.PhysicalLocation=dlgSaveBackUp.FileName;
				bkdv.Type=SQLDMO.SQLDMO_DEVICE_TYPE.SQLDMODevice_DiskDump;//lưu file backup vào disk

				
				//Lưu trữ bkdv vào sql server (tương tự lưu store procedure)
				try
				{
					addBackupdevice(sqlSrv,bkdv,dlgSaveBackUp.FileName );
				}
				catch(Exception ex)
				{
					MessageBox.Show("Can not backup database "+bk.Database ,"Backup fail",MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
					return;
				}
//				
				try
				{
					//gắn backup device vào đối tượng backup
					bk.Devices ="["+bkdv.Name +"]";
				}
				catch(Exception exc)
				{
					MessageBox.Show("The backup device already exist. Select another back up file name ! ","error",MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
					return;
				}
				
				try
				{
					//tiến hành back up csdl
					bk.SQLBackup(sqlSrv );
					MessageBox.Show("Successful back up full database "+ bk.Database,"Backup successful",MessageBoxButtons.OK, MessageBoxIcon.Information  );
				}
				catch(Exception ex)
				{
					MessageBox.Show("Can not backup database "+bk.Database ,"Backup fail",MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
					return;
				}
				
			}
	}
		
		/// <summary>
		/// Lấy riêng phần tên file của một file đầy đủ đường dẫn
		/// </summary>
		/// <param name="fullfilename"></param>
		/// <returns></returns>
		private string GetFileName(string fullfilename)
		{
			FileInfo fil= new FileInfo(fullfilename ) ;
			return fil.Name;
		}

	
		/// <summary>
		/// Get all instances of Database Server on Network
		/// </summary>
		private void LoadServerCbo()
		{
			string[] server = sysProcess.GetServers();
			cboServer.DataSource = server;
			
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cboSourceDatabase_Click(object sender, EventArgs e)
		{
			if(!Validate_SQLServer())
				return;
			else if(connectDB())
				{
					this.FillDatabaseList(this.ConnectionStr());
				}
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
		/// <summary>
		/// Them backup device vao sqlserver, neu da ton tai thi xoa truoc khi them.
		/// </summary>
		/// <param name="server"></param>
		/// <param name="bkdv"></param>
		/// <param name="bkdvPhysical">Chuoi ten file vat ly cua backup device dinh them</param>
		private void addBackupdevice(SQLServer server,BackupDevice bkdv, string bkdvPhysical)
		{
			for(int i = 0;i<server.BackupDevices.Count ;i++)
			{
				string backupname=sqlSrv.BackupDevices.Item(i+1).PhysicalLocation  ;
				if (backupname==dlgSaveBackUp.FileName)
					server.BackupDevices.Remove(i+1) ;
			}
			server.BackupDevices.Add(bkdv);
		}
		private void cboServer_Click(object sender, System.EventArgs e)
		{
			LoadServerCbo();
		}

		private void Finish_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	
		/// <summary>
		/// Điền danh sách các database vào combobox ứng với server được chọn
		/// </summary>
		/// <param name="ConnectionString"></param>
		private void FillDatabaseList(string ConnectionString)
		{
			this.cboSourceDatabase.Items.Clear();
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
						this.cboSourceDatabase.Items.Add(Database);
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

				if(this.cboSourceDatabase.Items.Count>0)
					this.cboSourceDatabase.SelectedIndex = 0;
			}
		}
		/// <summary>
		/// Câu lệnh kết nối đên server 
		/// </summary>
		/// <returns></returns>
		private string ConnectionStr()
		{

			string s;

			s = string.Format("Server={0};",this.cboServer.Text);

			if(this.rdoWindowsIntergrated.Checked)
				s += "Trusted_Connection=True;";
			else
				s += string.Format("UId={0};PWD={1};",this.txtUserNameDB.Text,this.txtPass.Text);

			s+="Connect Timeout=1;Max Pool Size=1;Connection Lifetime=10;";
			return s;
		}
		

		
	}
}
