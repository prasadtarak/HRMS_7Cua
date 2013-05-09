#define Win32
using System.Timers;
using EVSoft.CardReader;
using Microsoft.VisualBasic;
using System.Data;
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
//using AxMSCommLib;
using System.Drawing;
using XPTable.Models;
using System.ServiceProcess;

namespace CardReader
{
	public class frmPP6750 : System.Windows.Forms.Form
	{
		private bool bClose;
	
		#region "Windows Form Designer generated code "
		public frmPP6750()
		{
			bClose=false;
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnuShow;
		private System.Windows.Forms.MenuItem mnuHide;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuStart;
		private System.Windows.Forms.MenuItem mnuStop;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button btnHelp;
		//Form overrides dispose to clean up the component list.
		private int count = 1;//dùng để đếm số nhân viên đã quẹt thẻ
		protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}

		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Button btnReceive;
		private System.Windows.Forms.GroupBox grbMessage;
		private XPTable.Models.Table xptMessage;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn cSTT;
		private XPTable.Models.TextColumn cCardID;
		private XPTable.Models.TextColumn cName;
		private XPTable.Models.TextColumn cWorkingDay;
		private XPTable.Models.TextColumn cTimeIn;
		private XPTable.Models.TextColumn cDepartment;
		private System.Windows.Forms.Timer aTimer;
		private XPTable.Models.ImageColumn cPic;
		private System.Windows.Forms.Button btnClear;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Button btnClose;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPP6750));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.xptMessage = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.TextColumn();
            this.cDepartment = new XPTable.Models.TextColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cName = new XPTable.Models.TextColumn();
            this.cWorkingDay = new XPTable.Models.TextColumn();
            this.cTimeIn = new XPTable.Models.TextColumn();
            this.cPic = new XPTable.Models.ImageColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuShow = new System.Windows.Forms.MenuItem();
            this.mnuHide = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuStart = new System.Windows.Forms.MenuItem();
            this.mnuStop = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xptMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Name = "btnClose";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReceive
            // 
            resources.ApplyResources(this.btnReceive, "btnReceive");
            this.btnReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // grbMessage
            // 
            resources.ApplyResources(this.grbMessage, "grbMessage");
            this.grbMessage.Controls.Add(this.xptMessage);
            this.grbMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbMessage.ForeColor = System.Drawing.Color.Black;
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.TabStop = false;
            // 
            // xptMessage
            // 
            this.xptMessage.AlternatingRowColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.xptMessage, "xptMessage");
            this.xptMessage.ColumnModel = this.columnModel1;
            this.xptMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.xptMessage.FullRowSelect = true;
            this.xptMessage.GridColor = System.Drawing.SystemColors.ControlDark;
            this.xptMessage.GridLines = XPTable.Models.GridLines.Rows;
            this.xptMessage.GridLineStyle = XPTable.Models.GridLineStyle.Dash;
            this.xptMessage.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xptMessage.Name = "xptMessage";
            this.xptMessage.TableModel = this.tableModel1;
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cDepartment,
            this.cCardID,
            this.cName,
            this.cWorkingDay,
            this.cTimeIn,
            this.cPic});
            this.columnModel1.HeaderHeight = 30;
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Text = "STT";
            this.cSTT.Width = 40;
            // 
            // cDepartment
            // 
            this.cDepartment.Text = "Phòng";
            this.cDepartment.Width = 120;
            // 
            // cCardID
            // 
            this.cCardID.Editable = false;
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 50;
            // 
            // cName
            // 
            this.cName.Editable = false;
            this.cName.Text = "Tên nhân viên";
            this.cName.Width = 140;
            // 
            // cWorkingDay
            // 
            this.cWorkingDay.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.cWorkingDay.Editable = false;
            this.cWorkingDay.Text = "Ngày làm việc";
            this.cWorkingDay.Width = 95;
            // 
            // cTimeIn
            // 
            this.cTimeIn.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.cTimeIn.Editable = false;
            this.cTimeIn.Text = "Giờ quẹt thẻ";
            this.cTimeIn.Width = 80;
            // 
            // cPic
            // 
            this.cPic.Text = "Ảnh";
            this.cPic.Width = 70;
            // 
            // tableModel1
            // 
            this.tableModel1.RowHeight = 100;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfig
            // 
            resources.ApplyResources(this.btnConfig, "btnConfig");
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 120000;
            this.aTimer.Tick += new System.EventHandler(this.aTimerUpdate);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuShow,
            this.mnuHide,
            this.menuItem3,
            this.mnuStart,
            this.mnuStop,
            this.menuItem6,
            this.mnuExit});
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // mnuShow
            // 
            this.mnuShow.Index = 0;
            resources.ApplyResources(this.mnuShow, "mnuShow");
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuHide
            // 
            this.mnuHide.Index = 1;
            resources.ApplyResources(this.mnuHide, "mnuHide");
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // mnuStart
            // 
            this.mnuStart.Index = 3;
            resources.ApplyResources(this.mnuStart, "mnuStart");
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Index = 4;
            resources.ApplyResources(this.mnuStop, "mnuStop");
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // frmPP6750
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbMessage);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPP6750";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmPP6750_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmPP6750_Resize);
            this.grbMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xptMessage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		#region "Upgrade Support "
		private static frmPP6750 m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPP6750 DefInstance
		{
			get
			{
				frmPP6750 returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmPP6750();
					m_InitializingDefInstance = false;
				}
				returnValue = m_vb6FormDefInstance;
				return returnValue;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}
		#endregion
		
		PP6750DO pp6750 = null;
		
//		Protocal.Call SetCom = new Protocal.Call();
		Protocal.Call SetCom = new Protocal.Call();
		
		private void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Xử lý dữ liệu
		/// </summary>
		/// <returns></returns>
		private void btnReceive_Click(object sender, System.EventArgs e)
		{
			if(pp6750.CheckConnection())
			{
				ReceiveData();
//				MessageBox.Show("Kết nối thành công đến CSDL","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Không kết nối được cơ sở dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
			

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			pp6750 = new PP6750DO();
		}
		/// <summary>
		/// Chuyển xâu sang kiểu ngày
		/// </summary>
		/// <param name="temp"></param>
		/// <returns></returns>
		private DateTime ConvertString2Day(string temp)
		{
			DateTime WorkingDay = new DateTime();
			string str = temp.Substring(0,4)+ "/" +temp.Substring(4,2)+"/"+temp.Substring(6,2);
			try 
				{
					WorkingDay	 =DateTime.Parse(str);
				}
			catch(Exception)
				{
					
				}
			return  WorkingDay;
		}
		/// <summary>
		/// chuyển một xâu sang kiểu ngày
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private DateTime ConvertString2Time(string str)
			{
				int Hour = Int32.Parse(str.Substring(0,2));
				int Minute = Int32.Parse(str.Substring(2,2));
				return new DateTime(1900, 1 , 1, Hour, Minute, 0);
			}
		
		
		/// <summary>
		/// Lấy thông tin nhân viên vừa quẹt thẻ hiển thị lên danh sách
		/// </summary>
		private void PopulateEmployee(int stt,string EmployeeName, string DepartmentName,string CardID, DateTime workingDay, DateTime checkIn,string PicPath )
		{
			
			xptMessage.BeginUpdate();

				string WorkingDay = workingDay.ToString("dd/MM/yyyy");
				string CheckIn = checkIn.ToString("HH:mm");
			Row row = new Row();
//				Row row = new Row(new string[]{stt.ToString(),DepartmentName,CardID,EmployeeName,WorkingDay,CheckIn});
			row.Cells.Add(new Cell(stt.ToString()));
			row.Cells.Add(new Cell(DepartmentName));
			row.Cells.Add(new Cell(CardID));
			row.Cells.Add(new Cell(EmployeeName));
			row.Cells.Add(new Cell(WorkingDay));
			row.Cells.Add(new Cell(CheckIn));
			if (System.IO.File.Exists(PicPath))
				row.Cells.Add(new Cell("",Image.FromFile(PicPath)));

				xptMessage.TableModel.Rows.Add(row);
			
			xptMessage.EndUpdate();
//			pictureBox1.Image = Image.FromFile(PicPath);
			
		}
		/// <summary>
		/// Nhận dữ liệu từ máy quẹt thẻ
		/// </summary>
		private void ReceiveData()
		{	
			short temp_short = 1;
			string temp_string = "4800";
//			SetCom.OpenCom(ref temp_short, ref temp_string);
			SetCom.OpenCom(ref temp_short);
			// thông số của máy quẹt thẻ
			string temp_string14 = "00";
			// Độ trễ khi máy quẹt thẻ trừ bỏ đi một bản ghi
			int temp_int2 = 500;
			
			int RecordCount = 0;
			string temp =""	;
//			xptMessage.TableModel.Rows.Clear();
			temp= SetCom.ReceiveData( ref temp_string14, ref temp_int2);
			if(temp.Length < 20)
			{
				RecordCount = 0;
			}
			else
			{
				try
				{
					RecordCount = int.Parse(temp.Substring(37,4))+1;
				}
				catch(Exception)
				{
					//ko lam gi  khi du lieu bi sai
				}

			}
			///Lấy cho đến hết các bản ghi từ máy quẹt thẻ
			while(RecordCount > 0)
			{
				string str1=string.Empty;
				string CardID = string.Empty;
				DateTime WorkingDay=DateTime.Now;
				string CheckIn=string.Empty;
				
				try
				{
					str1 = temp.Substring(temp.Length-39,39);
					// mã thẻ
					//				string CardID = str1.Substring(4,6);
					CardID = "0"+str1.Substring(7,5);
					//giờ vào
					//				string CheckIn = str1.Substring(20,4);
					//ngày làm việc
					//				DateTime WorkingDay = ConvertString2Day("20"+str1.Substring(12,6));
					WorkingDay = ConvertString2Day("20"+str1.Substring(16,6));
					CheckIn = str1.Substring(24,4);
                    WriteLog.WriteTimeLog(CardID, WorkingDay.ToString("yyyyMMdd"), CheckIn);
				}
				catch{}
		
				// Lấy thông tin nhân viên dựa trên mã thẻ vừa quẹt
				string EmployeeName = "";
				string DepartmentName = "";
				string PictureFileName = "";
				string PictureFileNameDefault = Application.StartupPath + "/IMAGES/noimage3.jpg";
				int employeeID = 0;
				DataSet dataSet = pp6750.GetEmployeeInfo(CardID);
				DataTable dbtable = dataSet.Tables[0];

				if (dbtable.Rows.Count == 0)
				{
					///MessageBox.Show((" Thẻ "+CardID+ " không hợp lệ !!!"),"Thông báo");
				}
				else
				{
					foreach (DataRow dataRow in dbtable.Rows)
					{
						// Lấy mã thẻ của nhân viên vừa quẹt
						employeeID = (int) dataRow["EmployeeID"];

						if (dataRow["Picture"] != DBNull.Value)
						{
							PictureFileName = Utils.settings.PicturePath+'\\'+dataRow["Picture"].ToString();
							
						}
						else
						{
							PictureFileName = PictureFileNameDefault;
						}

						EmployeeName = dataRow["EmployeeName"].ToString();
						DepartmentName = dataRow["DepartmentName"].ToString();
						DateTime gioQuetthe = ConvertString2Time(CheckIn);
						try 
						{
							PopulateEmployee(count,EmployeeName,DepartmentName,CardID,WorkingDay,gioQuetthe,PictureFileName);
						}
						catch
						{
							PopulateEmployee(count,EmployeeName,DepartmentName,CardID,WorkingDay,gioQuetthe,PictureFileNameDefault);
						}
						
		
					}
					/// Lấy giờ quẹt thẻ
					String TimeInOut = ConvertString2Time(CheckIn).ToShortTimeString();
					/// Kiểm tra thời gian quẹt thẻ là giờ vào hay ra
					string TimeIn = pp6750.GetTimeIn(employeeID,WorkingDay);
					/// Lưu dữ liệu quẹt thẻ vào cơ sở dữ liệu
					pp6750.SaveCardData(WorkingDay.ToString(), employeeID, TimeInOut, TimeIn);
	
				}
				count++;
				RecordCount--;
				temp= SetCom.ReceiveData( ref temp_string14, ref temp_int2);
			}
		}


		private void aTimerUpdate(object sender, EventArgs e)
		{
			if(pp6750.CheckConnection())
			{
				ReceiveData();
				if(count >= 20)// sau khi hien thi 10 nguoi tren danh sách thì xóa danh sách
				{
					ClearList();
				}
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			ClearList();
		}
		/// <summary>
		/// Xóa danh sách hiển thị nhân viên
		/// </summary>
		private void ClearList()
		{
			xptMessage.TableModel.Rows.Clear();
			count = 1;
		}

		private void btnConfig_Click(object sender, System.EventArgs e)
		{
			frmConfig frm = new frmConfig();
			frm.ShowDialog();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			mnuShow.Enabled=!(this.Visible);
			mnuHide.Enabled=this.Visible;
			Load_Service();
		}
		private void Load_Service()
		{
			ServiceController sc = new ServiceController("CardReaderService");

			if (sc.Status.ToString()=="Stopped")
			{
				mnuStart.Enabled=true;
				mnuStop.Enabled=false;
			}
			else
			{
				mnuStart.Enabled=false;
				mnuStop.Enabled=true;
			}
		}

		private void frmPP6750_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
			if (!bClose)
				e.Cancel=true;
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			bClose=true;
			this.Close();
		}

		private void frmPP6750_Resize(object sender, System.EventArgs e)
		{
			if (this.WindowState==FormWindowState.Minimized)
				this.Hide();
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
		}

		private void mnuStart_Click(object sender, System.EventArgs e)
		{
            try
            {
                ServiceController sc = new ServiceController("CardReaderService");
                if (sc.Status.ToString() == "Stopped")
                {
                    sc.Start();
                    sc.Refresh();
                    mnuStart.Enabled = false;
                    mnuStop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
		}

		private void mnuStop_Click(object sender, System.EventArgs e)
		{
            try
            {
                ServiceController sc = new ServiceController("CardReaderService");
                if (sc.CanStop)
                {
                    if (sc.Status.ToString() != "Stopped")
                    {
                        sc.Stop();
                        sc.Refresh();
                        mnuStart.Enabled = true;
                        mnuStop.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
		}

		private void mnuShow_Click(object sender, System.EventArgs e)
		{
            try
            {
			    this.Show();
			    this.WindowState=FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
		}

		private void mnuHide_Click(object sender, System.EventArgs e)
		{
            try
            {
			    this.Hide();
			    this.WindowState=FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
		}

		private void btnHelp_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Card Reader 20110519 5PM","Last update by ChinhND",MessageBoxButtons.OK);
		}
		
	}
}
