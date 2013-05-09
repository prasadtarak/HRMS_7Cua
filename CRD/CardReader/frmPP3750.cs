#define Win32
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using EVSoft.CardReader;
using Protocal;
using XPTable.Models;
using System.ServiceProcess;

namespace CardReader
{
	public class frmPP3750 : Form
	{
		private bool bClose;
		
	#region "Windows Form Designer generated code "
		public frmPP3750()
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
						if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
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
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button1;
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

		private IContainer components;
		public ToolTip ToolTip1;
		private Button btnReceive;
		private GroupBox grbMessage;
		private Table xptMessage;
		private TableModel tableModel1;
		private ColumnModel columnModel1;
		private TextColumn cSTT;
		private TextColumn cCardID;
		private TextColumn cName;
		private TextColumn cWorkingDay;
		private TextColumn cTimeIn;
		private TextColumn cDepartment;
		private Timer aTimer;
		private ImageColumn cPic;
		private Button btnClear;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal Button btnClose;
		[DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPP3750));
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
			this.aTimer = new System.Windows.Forms.Timer(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnuShow = new System.Windows.Forms.MenuItem();
			this.mnuHide = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuStart = new System.Windows.Forms.MenuItem();
			this.mnuStop = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.grbMessage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xptMessage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.AccessibleDescription = resources.GetString("btnClose.AccessibleDescription");
			this.btnClose.AccessibleName = resources.GetString("btnClose.AccessibleName");
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnClose.Anchor")));
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnClose.Dock")));
			this.btnClose.Enabled = ((bool)(resources.GetObject("btnClose.Enabled")));
			this.btnClose.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnClose.FlatStyle")));
			this.btnClose.Font = ((System.Drawing.Font)(resources.GetObject("btnClose.Font")));
			this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClose.ImageAlign")));
			this.btnClose.ImageIndex = ((int)(resources.GetObject("btnClose.ImageIndex")));
			this.btnClose.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnClose.ImeMode")));
			this.btnClose.Location = ((System.Drawing.Point)(resources.GetObject("btnClose.Location")));
			this.btnClose.Name = "btnClose";
			this.btnClose.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnClose.RightToLeft")));
			this.btnClose.Size = ((System.Drawing.Size)(resources.GetObject("btnClose.Size")));
			this.btnClose.TabIndex = ((int)(resources.GetObject("btnClose.TabIndex")));
			this.btnClose.Text = resources.GetString("btnClose.Text");
			this.btnClose.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClose.TextAlign")));
			this.ToolTip1.SetToolTip(this.btnClose, resources.GetString("btnClose.ToolTip"));
			this.btnClose.Visible = ((bool)(resources.GetObject("btnClose.Visible")));
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnReceive
			// 
			this.btnReceive.AccessibleDescription = resources.GetString("btnReceive.AccessibleDescription");
			this.btnReceive.AccessibleName = resources.GetString("btnReceive.AccessibleName");
			this.btnReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnReceive.Anchor")));
			this.btnReceive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceive.BackgroundImage")));
			this.btnReceive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnReceive.Dock")));
			this.btnReceive.Enabled = ((bool)(resources.GetObject("btnReceive.Enabled")));
			this.btnReceive.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnReceive.FlatStyle")));
			this.btnReceive.Font = ((System.Drawing.Font)(resources.GetObject("btnReceive.Font")));
			this.btnReceive.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnReceive.Image")));
			this.btnReceive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnReceive.ImageAlign")));
			this.btnReceive.ImageIndex = ((int)(resources.GetObject("btnReceive.ImageIndex")));
			this.btnReceive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnReceive.ImeMode")));
			this.btnReceive.Location = ((System.Drawing.Point)(resources.GetObject("btnReceive.Location")));
			this.btnReceive.Name = "btnReceive";
			this.btnReceive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnReceive.RightToLeft")));
			this.btnReceive.Size = ((System.Drawing.Size)(resources.GetObject("btnReceive.Size")));
			this.btnReceive.TabIndex = ((int)(resources.GetObject("btnReceive.TabIndex")));
			this.btnReceive.Text = resources.GetString("btnReceive.Text");
			this.btnReceive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnReceive.TextAlign")));
			this.ToolTip1.SetToolTip(this.btnReceive, resources.GetString("btnReceive.ToolTip"));
			this.btnReceive.Visible = ((bool)(resources.GetObject("btnReceive.Visible")));
			this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
			// 
			// grbMessage
			// 
			this.grbMessage.AccessibleDescription = resources.GetString("grbMessage.AccessibleDescription");
			this.grbMessage.AccessibleName = resources.GetString("grbMessage.AccessibleName");
			this.grbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("grbMessage.Anchor")));
			this.grbMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbMessage.BackgroundImage")));
			this.grbMessage.Controls.Add(this.xptMessage);
			this.grbMessage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("grbMessage.Dock")));
			this.grbMessage.Enabled = ((bool)(resources.GetObject("grbMessage.Enabled")));
			this.grbMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbMessage.Font = ((System.Drawing.Font)(resources.GetObject("grbMessage.Font")));
			this.grbMessage.ForeColor = System.Drawing.Color.Black;
			this.grbMessage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("grbMessage.ImeMode")));
			this.grbMessage.Location = ((System.Drawing.Point)(resources.GetObject("grbMessage.Location")));
			this.grbMessage.Name = "grbMessage";
			this.grbMessage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("grbMessage.RightToLeft")));
			this.grbMessage.Size = ((System.Drawing.Size)(resources.GetObject("grbMessage.Size")));
			this.grbMessage.TabIndex = ((int)(resources.GetObject("grbMessage.TabIndex")));
			this.grbMessage.TabStop = false;
			this.grbMessage.Text = resources.GetString("grbMessage.Text");
			this.ToolTip1.SetToolTip(this.grbMessage, resources.GetString("grbMessage.ToolTip"));
			this.grbMessage.Visible = ((bool)(resources.GetObject("grbMessage.Visible")));
			// 
			// xptMessage
			// 
			this.xptMessage.AccessibleDescription = resources.GetString("xptMessage.AccessibleDescription");
			this.xptMessage.AccessibleName = resources.GetString("xptMessage.AccessibleName");
			this.xptMessage.AlternatingRowColor = System.Drawing.Color.Azure;
			this.xptMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xptMessage.Anchor")));
			this.xptMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xptMessage.BackgroundImage")));
			this.xptMessage.ColumnModel = this.columnModel1;
			this.xptMessage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xptMessage.Dock")));
			this.xptMessage.Enabled = ((bool)(resources.GetObject("xptMessage.Enabled")));
			this.xptMessage.Font = ((System.Drawing.Font)(resources.GetObject("xptMessage.Font")));
			this.xptMessage.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.xptMessage.FullRowSelect = true;
			this.xptMessage.GridColor = System.Drawing.SystemColors.ControlDark;
			this.xptMessage.GridLines = XPTable.Models.GridLines.Rows;
			this.xptMessage.GridLineStyle = XPTable.Models.GridLineStyle.Dash;
			this.xptMessage.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.xptMessage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xptMessage.ImeMode")));
			this.xptMessage.Location = ((System.Drawing.Point)(resources.GetObject("xptMessage.Location")));
			this.xptMessage.Name = "xptMessage";
			this.xptMessage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xptMessage.RightToLeft")));
			this.xptMessage.Size = ((System.Drawing.Size)(resources.GetObject("xptMessage.Size")));
			this.xptMessage.TabIndex = ((int)(resources.GetObject("xptMessage.TabIndex")));
			this.xptMessage.TableModel = this.tableModel1;
			this.xptMessage.Text = resources.GetString("xptMessage.Text");
			this.ToolTip1.SetToolTip(this.xptMessage, resources.GetString("xptMessage.ToolTip"));
			this.xptMessage.Visible = ((bool)(resources.GetObject("xptMessage.Visible")));
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
			this.btnClear.AccessibleDescription = resources.GetString("btnClear.AccessibleDescription");
			this.btnClear.AccessibleName = resources.GetString("btnClear.AccessibleName");
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnClear.Anchor")));
			this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
			this.btnClear.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnClear.Dock")));
			this.btnClear.Enabled = ((bool)(resources.GetObject("btnClear.Enabled")));
			this.btnClear.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnClear.FlatStyle")));
			this.btnClear.Font = ((System.Drawing.Font)(resources.GetObject("btnClear.Font")));
			this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClear.ImageAlign")));
			this.btnClear.ImageIndex = ((int)(resources.GetObject("btnClear.ImageIndex")));
			this.btnClear.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnClear.ImeMode")));
			this.btnClear.Location = ((System.Drawing.Point)(resources.GetObject("btnClear.Location")));
			this.btnClear.Name = "btnClear";
			this.btnClear.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnClear.RightToLeft")));
			this.btnClear.Size = ((System.Drawing.Size)(resources.GetObject("btnClear.Size")));
			this.btnClear.TabIndex = ((int)(resources.GetObject("btnClear.TabIndex")));
			this.btnClear.Text = resources.GetString("btnClear.Text");
			this.btnClear.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnClear.TextAlign")));
			this.ToolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
			this.btnClear.Visible = ((bool)(resources.GetObject("btnClear.Visible")));
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.AccessibleDescription = resources.GetString("btnConfig.AccessibleDescription");
			this.btnConfig.AccessibleName = resources.GetString("btnConfig.AccessibleName");
			this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnConfig.Anchor")));
			this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
			this.btnConfig.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnConfig.Dock")));
			this.btnConfig.Enabled = ((bool)(resources.GetObject("btnConfig.Enabled")));
			this.btnConfig.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnConfig.FlatStyle")));
			this.btnConfig.Font = ((System.Drawing.Font)(resources.GetObject("btnConfig.Font")));
			this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
			this.btnConfig.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnConfig.ImageAlign")));
			this.btnConfig.ImageIndex = ((int)(resources.GetObject("btnConfig.ImageIndex")));
			this.btnConfig.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnConfig.ImeMode")));
			this.btnConfig.Location = ((System.Drawing.Point)(resources.GetObject("btnConfig.Location")));
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnConfig.RightToLeft")));
			this.btnConfig.Size = ((System.Drawing.Size)(resources.GetObject("btnConfig.Size")));
			this.btnConfig.TabIndex = ((int)(resources.GetObject("btnConfig.TabIndex")));
			this.btnConfig.Text = resources.GetString("btnConfig.Text");
			this.btnConfig.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnConfig.TextAlign")));
			this.ToolTip1.SetToolTip(this.btnConfig, resources.GetString("btnConfig.ToolTip"));
			this.btnConfig.Visible = ((bool)(resources.GetObject("btnConfig.Visible")));
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
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
			this.contextMenu1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenu1.RightToLeft")));
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// mnuShow
			// 
			this.mnuShow.Enabled = ((bool)(resources.GetObject("mnuShow.Enabled")));
			this.mnuShow.Index = 0;
			this.mnuShow.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuShow.Shortcut")));
			this.mnuShow.ShowShortcut = ((bool)(resources.GetObject("mnuShow.ShowShortcut")));
			this.mnuShow.Text = resources.GetString("mnuShow.Text");
			this.mnuShow.Visible = ((bool)(resources.GetObject("mnuShow.Visible")));
			this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
			// 
			// mnuHide
			// 
			this.mnuHide.Enabled = ((bool)(resources.GetObject("mnuHide.Enabled")));
			this.mnuHide.Index = 1;
			this.mnuHide.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuHide.Shortcut")));
			this.mnuHide.ShowShortcut = ((bool)(resources.GetObject("mnuHide.ShowShortcut")));
			this.mnuHide.Text = resources.GetString("mnuHide.Text");
			this.mnuHide.Visible = ((bool)(resources.GetObject("mnuHide.Visible")));
			this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Enabled = ((bool)(resources.GetObject("menuItem3.Enabled")));
			this.menuItem3.Index = 2;
			this.menuItem3.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem3.Shortcut")));
			this.menuItem3.ShowShortcut = ((bool)(resources.GetObject("menuItem3.ShowShortcut")));
			this.menuItem3.Text = resources.GetString("menuItem3.Text");
			this.menuItem3.Visible = ((bool)(resources.GetObject("menuItem3.Visible")));
			// 
			// mnuStart
			// 
			this.mnuStart.Enabled = ((bool)(resources.GetObject("mnuStart.Enabled")));
			this.mnuStart.Index = 3;
			this.mnuStart.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuStart.Shortcut")));
			this.mnuStart.ShowShortcut = ((bool)(resources.GetObject("mnuStart.ShowShortcut")));
			this.mnuStart.Text = resources.GetString("mnuStart.Text");
			this.mnuStart.Visible = ((bool)(resources.GetObject("mnuStart.Visible")));
			this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
			// 
			// mnuStop
			// 
			this.mnuStop.Enabled = ((bool)(resources.GetObject("mnuStop.Enabled")));
			this.mnuStop.Index = 4;
			this.mnuStop.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuStop.Shortcut")));
			this.mnuStop.ShowShortcut = ((bool)(resources.GetObject("mnuStop.ShowShortcut")));
			this.mnuStop.Text = resources.GetString("mnuStop.Text");
			this.mnuStop.Visible = ((bool)(resources.GetObject("mnuStop.Visible")));
			this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Enabled = ((bool)(resources.GetObject("menuItem6.Enabled")));
			this.menuItem6.Index = 5;
			this.menuItem6.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem6.Shortcut")));
			this.menuItem6.ShowShortcut = ((bool)(resources.GetObject("menuItem6.ShowShortcut")));
			this.menuItem6.Text = resources.GetString("menuItem6.Text");
			this.menuItem6.Visible = ((bool)(resources.GetObject("menuItem6.Visible")));
			// 
			// mnuExit
			// 
			this.mnuExit.Enabled = ((bool)(resources.GetObject("mnuExit.Enabled")));
			this.mnuExit.Index = 6;
			this.mnuExit.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mnuExit.Shortcut")));
			this.mnuExit.ShowShortcut = ((bool)(resources.GetObject("mnuExit.ShowShortcut")));
			this.mnuExit.Text = resources.GetString("mnuExit.Text");
			this.mnuExit.Visible = ((bool)(resources.GetObject("mnuExit.Visible")));
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.contextMenu1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = resources.GetString("notifyIcon1.Text");
			this.notifyIcon1.Visible = ((bool)(resources.GetObject("notifyIcon1.Visible")));
			this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = ((System.Drawing.Size)(resources.GetObject("imageList1.ImageSize")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.ToolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmPP3750
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnConfig);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.grbMessage);
			this.Controls.Add(this.btnReceive);
			this.Controls.Add(this.btnClose);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "frmPP3750";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ToolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.Resize += new System.EventHandler(this.frmPP3750_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmPP3750_Closing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grbMessage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xptMessage)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		#region "Upgrade Support "
		private static frmPP3750 m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPP3750 DefInstance
		{
			get
			{
				frmPP3750 returnValue;
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmPP3750();
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
		
		PP3750DO pp3750 = null;
		
//		Protocal.Call SetCom = new Protocal.Call();
	    private Protocal.Call SetCom = null;
		
		private void btnClose_Click(Object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Xử lý dữ liệu
		/// </summary>
		/// <returns></returns>
		private void btnReceive_Click(object sender, EventArgs e)
		{
			if(pp3750.CheckConnection())//kiem tra ket noi den CSDL, neu OK thi moi lay du lieu ve
			{
				ReceiveData();
//				MessageBox.Show("Kết nối thành công đến CSDL","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Không kết nối được cơ sở dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
			

		private void frmMain_Load(object sender, EventArgs e)
		{
			pp3750 = new PP3750DO();
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
		/// Nhận dữ liệu từ máy quẹt thẻ va hien thi thong tin nhan vien len grid
		/// </summary>
		private void ReceiveData()
		{
            try
            {
                SetCom = new Protocal.Call();
                short temp_short = 1;
                string temp_string = "4800";
                //			SetCom.OpenCom(ref temp_short, ref temp_string);
                SetCom.OpenCom(ref temp_short);
                // thông số của máy quẹt thẻ
                string temp_string14 = "00";
                // Độ trễ khi máy quẹt thẻ trừ bỏ đi một bản ghi
                int temp_int2 = 500;

                int RecordCount = 0;
                string temp = "";
                //			xptMessage.TableModel.Rows.Clear();
                temp = SetCom.ReceiveData(ref temp_string14, ref temp_int2);
                if (temp.Length < 20)
                {
                    RecordCount = 0;
                }
                else
                {
                    try
                    {
                        RecordCount = int.Parse(temp.Substring(26, 4)) + 1;
                    }
                    catch (Exception)
                    {
                        //ko lam gi  khi du lieu bi sai
                    }
                }
                ///Lấy tung ban ghi theo stack cho đến hết các bản ghi từ máy quẹt thẻ
                while (RecordCount > 0)
                {
                    string str1 = string.Empty;
                    string CardID = string.Empty;
                    string CheckIn = string.Empty;
                    DateTime WorkingDay = DateTime.Now;
                    try
                    {
                        str1 = temp.Substring(temp.Length - 39, 39);
                        // mã thẻ
                        CardID = str1.Substring(4, 6);
                        //giờ quet the
                        CheckIn = str1.Substring(20, 4);
                        //ngày làm việc
                        WorkingDay = ConvertString2Day("20" + str1.Substring(12, 6));
                        WriteLog.WriteTimeLog(CardID,WorkingDay.ToString("yyyyMMdd"),CheckIn);
                    }
                    catch
                    {
                    }
                    // Lấy thông tin nhân viên dựa trên mã thẻ vừa quẹt
                    string EmployeeName = "";
                    string DepartmentName = "";
                    string PictureFileName = "";

                    string DefaultPicturePath = Application.StartupPath + "/IMAGES/noimage3.jpg";

                    int employeeID = 0;
                    //lay thong tin nhan vien theo ma the nhan duoc tu may doc the
                    DataSet dataSet = pp3750.GetEmployeeInfo(CardID);

                    DataTable dbtable = dataSet.Tables[0];

                    if (dbtable.Rows.Count == 0) //ko co nhan vien nao co ma the nay`
                    {
                        ///MessageBox.Show((" Thẻ "+CardID+ " không hợp lệ !!!"),"Thông báo");
                    }
                    else //co nhan vien trung ma the
                    {
                        foreach (DataRow dataRow in dbtable.Rows)
                        {
                            // Lấy mã thẻ của nhân viên vừa quẹt
                            employeeID = (int) dataRow["EmployeeID"];

                            if (dataRow["Picture"] != DBNull.Value) //trong database co duong dan anh
                            {
                                PictureFileName = Utils.settings.PicturePath + '\\' + dataRow["Picture"].ToString();
                            }
                            else //database chua co duong dan anh nhan vien, lay anh mac dinh
                            {
                                PictureFileName = DefaultPicturePath;
                            }

                            EmployeeName = dataRow["EmployeeName"].ToString();
                            DepartmentName = dataRow["DepartmentName"].ToString();
                            DateTime timeInOut = ConvertString2Time(CheckIn);

                            try
                            {
                                //Hien thi thong tin nhan vien len Grid
                                PopulateEmployee(count, EmployeeName, DepartmentName, CardID, WorkingDay, timeInOut,
                                                 PictureFileName);
                            }
                            catch
                            {
                                //Hien thi thong tin nhan vien len Grid voi anh mac dinh	
                                PopulateEmployee(count, EmployeeName, DepartmentName, CardID, WorkingDay, timeInOut,
                                                 DefaultPicturePath);
                            }
                        }

                        /// Lấy giờ quẹt thẻ
                        String TimeInOut = ConvertString2Time(CheckIn).ToShortTimeString();

                        /// Kiểm tra thời gian quẹt thẻ là giờ vào hay ra
                        string TimeIn = pp3750.GetTimeIn(employeeID, WorkingDay);

                        /// Lưu dữ liệu quẹt thẻ vào cơ sở dữ liệu
                        pp3750.SaveCardData(WorkingDay.ToString(), employeeID, TimeInOut, TimeIn);
                    }
                    count++;
                    RecordCount--;
                    temp = SetCom.ReceiveData(ref temp_string14, ref temp_int2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
		}


		private void aTimerUpdate(object sender, EventArgs e)
		{
			if(pp3750.CheckConnection())
			{
				ReceiveData();
				if(count >= 20)// sau khi hien thi 10 nguoi tren danh sách thì xóa danh sách
				{
					ClearList();
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
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

		private void frmPP3750_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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

		private void frmPP3750_Resize(object sender, System.EventArgs e)
		{
			if (this.WindowState==FormWindowState.Minimized)
				this.Hide();
		}

		private void notifyIcon1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
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
                this.WindowState = FormWindowState.Normal;
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Card Reader 20110519 4PM","Last update by ChinhND",MessageBoxButtons.OK);
		}

		
	}
}
