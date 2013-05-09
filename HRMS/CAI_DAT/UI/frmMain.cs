//------------------------------------------------------------------------------------
//Class	    : frmMain
//Purpose	: Form giao diện chính của chương trình	
//Note	    :		  
//Author	: chinhnd
//Modify	: sửa lại một số menu, icon by chinhnd 23-8-2005
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using EVsoft.HRMS.UI;
using EVsoft.HRMS.UI.Admin;
using EVSoft.HRMS.UI.Admin;
using EVSoft.HRMS.UI;
using EVSoft.HRMS.UI.Employee;
using EVSoft.HRMS.UI.Report;
using EVSoft.HRMS.UI.Schedule;
using System.Data.SqlClient;

//using EVSoft.HRMS.DO;
using System.Data;
using EVSoft.HRMS.UI.BHXH;
using System.IO;
using EVSoft.Ketoan.User_Interface.He_thong;
//using EVSoft.HRMSLisence;
//using System.Data.SqlClient;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
        private ModuleSettings settingsModule;
	    DataSet dsUser=null;
	    DataSet dsEmployee=null;
		public frmMain()
		{
			ShowSplashScreen();
			InitializeComponent();
			this.Refresh();
			//SetMenuStatus(false);
			this.Show();
			this.Activate();
			login = new frmLogin(this);

            AdminDO adminDO = new AdminDO();
            EmployeeDO employeeDO = new EmployeeDO();

            settingsModule = new ModuleSettings();
            settingsModule = ModuleConfig.GetSettings();

            if (!WorkingContext.CheckConnection(settingsModule.Server, settingsModule.Database, settingsModule.UserName, settingsModule.Password))
            {
                string str4 = WorkingContext.LangManager.GetString("frmSetting_Error1_Title");
                string str5 = WorkingContext.LangManager.GetString("frmSetting_Error2");
                //MessageBox.Show("Không thể kết nối được cơ sở dữ liệu. Hãy nhập lại thông số cấu hình hệ thống", "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str5, str4, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                frmSettings frm = new frmSettings();
                frm.ShowDialog(this);
            }
		    else 
            {
                
                dsUser = adminDO.GetAllUsers();
                dsEmployee = employeeDO.GetAllEmployees(1);
                
                if (dsUser.Tables[0].Rows.Count == 0 || dsEmployee.Tables[0].Rows.Count == 0)
                {
                    NotLogin(true);
                }
                else
                    login.ShowDialog(this);
            }
		}

        private void NotLogin(bool isLogin)
	    {
            mnuLogin.Enabled = !isLogin;

            //Toolbar
            tbbDangNhap.Enabled = !isLogin;
            tbbSettings.Enabled = true;
            tbbHelp.Enabled = true;
            tbbExit.Enabled = true;
            mnuLogin.Visible = !isLogin;
            mnuLogout.Visible = isLogin;
            mnuExit.Visible = true;
            mnuBackup.Visible = isLogin;
            mnuBackupAll.Visible = true;
            mnuBackupInMonth.Visible = true;
            mnuRestore.Visible = isLogin;
            mnuRestoreAll.Visible = true;
            mnuRestoreInMonth.Visible = true;
            mnuEditPass.Visible = isLogin;


            foreach (MenuItem menu in mainMenu1.MenuItems)
            {
                foreach (MenuItem menu1 in menu.MenuItems)
                {
                      menu1.Visible = true;
                }
            }

            foreach (ToolBarButton button in tbaMain.Buttons)
            {
                button.Enabled = true;
            }
	    }
		private frmLogin login;
		
		private System.Windows.Forms.MenuItem mnuEditPass;
		private System.Windows.Forms.MenuItem mnuThanhToanTienPhep;
		private System.Windows.Forms.MenuItem mnuEnglish;
		private System.Windows.Forms.MenuItem mnuVietNamese;
		private System.Windows.Forms.MenuItem mnuJapanese;
		//public int check1 = 0;
		private System.Windows.Forms.MenuItem mnuVersion;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem6;
        private MenuItem menuItem4;
        private MenuItem menuItem9;
        private MenuItem menuItem12;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem mnuDSCapBHXH;
	
		//		public int t
		//		{
		//			get {return check1 ;}
		//			set {check1 = value;}
		//
		//		}
		//private bool thu = true;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		/// <summary>
		/// Hàm refresh gọi tất cả các refresh trong các MDI children
		/// </summary>
		public override void Refresh()
		{
			ChangeToCurrentLang();

			foreach (Form form in this.MdiChildren)
			{
				form.Refresh();
			}

			base.Refresh ();
		}

		public MainMenu mainMenu1;
		public MenuItem mmnuSystem;
		public MenuItem mnuExit;
		public MenuItem mmnuHuman;
		public MenuItem mnuEmployeeProfile;
		public MenuItem mmnuReport;
		public MenuItem mmnuHelp;
		public MenuItem mnuEmployeeStatus;
		public MenuItem mnuInOut;
		public MenuItem mnuLogin;
		public MenuItem mnuListReport;
		public MenuItem mnuHelp;
		public MenuItem mnuAbout;
		public StatusBarPanel staState;
		public StatusBarPanel staUser;
		public StatusBarPanel staName;
		public StatusBarPanel staCompany;
		public StatusBarPanel staDate;
		public StatusBar stbMain;
		internal System.Windows.Forms.ToolBar tbaMain;
		public ToolBarButton tbbSeparator1;
		public ToolBarButton tbbSeparator2;
		public ToolBarButton tbbStatus;
		public ToolBarButton tbbManage;
		public ToolBarButton tbbSeparator3;
		public ToolBarButton tbbHelp;
		public ToolBarButton tbbSeparator4;
		public ToolBarButton tbbExit;
		public ImageList imgMain;
		public ContextMenu mnuManage;
		public MenuItem menuItem5;
		public MenuItem menuItem7;
		public MenuItem mnuNS;
		public MenuItem mnuCV;
		public MenuItem mnuPB;
		public MenuItem mnuQT;
		public MenuItem mnuDT;
		public MenuItem mnuLL;
		public MenuItem mnuLogout;
		public MenuItem mmnuWindows;
		public MenuItem menuItem15;
		public MenuItem mnuSeparate2;
		public ToolBarButton tbbDangNhap;
		public System.Windows.Forms.ToolBarButton tbbReport;
		private System.Windows.Forms.ImageList imgMenu;
		private ControlVault.MenuSuite.MenuEx menuEx1;
		private ControlVault.MenuSuite.VisualStudioMenuPainter visualStudioMenuPainter1;
		private ControlVault.MenuSuite.Office2003MenuPainter office2003MenuPainter1;
		public System.Windows.Forms.MenuItem mmnuOption;
		public System.Windows.Forms.MenuItem mnuDisplay;
		private System.Windows.Forms.MenuItem mnuLanguage;
		private System.Windows.Forms.MenuItem mmnuXP;
		private System.Windows.Forms.MenuItem mmnuVS2003;
		private System.Windows.Forms.MenuItem mmnuOffice2003;
		private System.Windows.Forms.MenuItem mnuOrganization;
		public System.Windows.Forms.ImageList imgTab;
		public System.Windows.Forms.MenuItem mnuCuaSoTang;
		public System.Windows.Forms.MenuItem mnuCuaSoDoc;
		public System.Windows.Forms.MenuItem mnuCuaSoNgang;
		public System.Windows.Forms.MenuItem mnuCuaSoDong;
		public System.Windows.Forms.MenuItem mnuBCChamCongNgay;
		private System.Windows.Forms.StatusBarPanel staNone;
		private System.Windows.Forms.MenuItem mmnuSalary;
		private System.Windows.Forms.MenuItem mnuCalculateSalary;
		private System.Windows.Forms.MenuItem menuItem1;
		private ControlVault.MenuSuite.PlainMenuPainter plainMenuPainter1;
		private System.Windows.Forms.MenuItem mnuPosition;
		private System.Windows.Forms.MenuItem mnuBackup;
		private System.Windows.Forms.MenuItem mnuBackupAll;
		private System.Windows.Forms.MenuItem mnuBackupInMonth;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem mnuAdmin;
		private System.Windows.Forms.MenuItem mnuPreference;
		private System.Windows.Forms.MenuItem mnuSearch;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuRestore;
		private System.Windows.Forms.MenuItem mnuRestoreAll;
		private System.Windows.Forms.MenuItem mnuRestoreInMonth;
		private System.Windows.Forms.ToolBarButton tbbSettings;
		private System.Windows.Forms.Timer tmrTimeUpdate;
		private System.Windows.Forms.ToolBarButton tbbTimeSheet;
		private System.Windows.Forms.MenuItem mnuTimeSheet;
		private System.Windows.Forms.ToolBarButton tbbSalary;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		public System.Windows.Forms.ToolBarButton tbbLunch;
		private System.Windows.Forms.MenuItem mmnuDefinition;
		private System.Windows.Forms.MenuItem mmnuRegistration;
		private System.Windows.Forms.MenuItem mnuLunch;
		private System.Windows.Forms.MenuItem mnuLeaveSchedule;
		private System.Windows.Forms.MenuItem mnuOverTime;
		private System.Windows.Forms.MenuItem mnuRest;
		private System.Windows.Forms.MenuItem mnuPunish;
		private System.Windows.Forms.MenuItem mnuDayType;
		private System.Windows.Forms.MenuItem mnuShift;
		private System.Windows.Forms.MenuItem mnuListPunish;
		private System.Windows.Forms.MenuItem mnuWorkingTime;
		private System.Windows.Forms.MenuItem mnuContract;
		private IContainer components;

		public bool checkLang = true;
		//private DataSet dsGroupPermission = null;
		//public string UserName = null;
		//private AdminDO adminDO = null;

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mmnuSystem = new System.Windows.Forms.MenuItem();
            this.mnuLogin = new System.Windows.Forms.MenuItem();
            this.mnuLogout = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.mnuEditPass = new System.Windows.Forms.MenuItem();
            this.mnuSeparate2 = new System.Windows.Forms.MenuItem();
            this.mnuAdmin = new System.Windows.Forms.MenuItem();
            this.mnuBackup = new System.Windows.Forms.MenuItem();
            this.mnuBackupInMonth = new System.Windows.Forms.MenuItem();
            this.mnuBackupAll = new System.Windows.Forms.MenuItem();
            this.mnuRestore = new System.Windows.Forms.MenuItem();
            this.mnuRestoreInMonth = new System.Windows.Forms.MenuItem();
            this.mnuRestoreAll = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mmnuOption = new System.Windows.Forms.MenuItem();
            this.mnuDisplay = new System.Windows.Forms.MenuItem();
            this.mmnuXP = new System.Windows.Forms.MenuItem();
            this.mmnuVS2003 = new System.Windows.Forms.MenuItem();
            this.mmnuOffice2003 = new System.Windows.Forms.MenuItem();
            this.mnuLanguage = new System.Windows.Forms.MenuItem();
            this.mnuEnglish = new System.Windows.Forms.MenuItem();
            this.mnuVietNamese = new System.Windows.Forms.MenuItem();
            this.mnuJapanese = new System.Windows.Forms.MenuItem();
            this.mnuSearch = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuPreference = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mmnuHuman = new System.Windows.Forms.MenuItem();
            this.mnuEmployeeProfile = new System.Windows.Forms.MenuItem();
            this.mnuInOut = new System.Windows.Forms.MenuItem();
            this.mnuEmployeeStatus = new System.Windows.Forms.MenuItem();
            this.mnuThanhToanTienPhep = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuPosition = new System.Windows.Forms.MenuItem();
            this.mnuOrganization = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.mnuDSCapBHXH = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.mmnuDefinition = new System.Windows.Forms.MenuItem();
            this.mnuPunish = new System.Windows.Forms.MenuItem();
            this.mnuDayType = new System.Windows.Forms.MenuItem();
            this.mnuShift = new System.Windows.Forms.MenuItem();
            this.mnuContract = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mmnuRegistration = new System.Windows.Forms.MenuItem();
            this.mnuLunch = new System.Windows.Forms.MenuItem();
            this.mnuOverTime = new System.Windows.Forms.MenuItem();
            this.mnuWorkingTime = new System.Windows.Forms.MenuItem();
            this.mnuLeaveSchedule = new System.Windows.Forms.MenuItem();
            this.mnuRest = new System.Windows.Forms.MenuItem();
            this.mnuListPunish = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mmnuReport = new System.Windows.Forms.MenuItem();
            this.mnuListReport = new System.Windows.Forms.MenuItem();
            this.mmnuSalary = new System.Windows.Forms.MenuItem();
            this.mnuTimeSheet = new System.Windows.Forms.MenuItem();
            this.mnuCalculateSalary = new System.Windows.Forms.MenuItem();
            this.mmnuWindows = new System.Windows.Forms.MenuItem();
            this.mnuCuaSoTang = new System.Windows.Forms.MenuItem();
            this.mnuCuaSoDoc = new System.Windows.Forms.MenuItem();
            this.mnuCuaSoNgang = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.mnuCuaSoDong = new System.Windows.Forms.MenuItem();
            this.mmnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuVersion = new System.Windows.Forms.MenuItem();
            this.stbMain = new System.Windows.Forms.StatusBar();
            this.staState = new System.Windows.Forms.StatusBarPanel();
            this.staUser = new System.Windows.Forms.StatusBarPanel();
            this.staNone = new System.Windows.Forms.StatusBarPanel();
            this.staName = new System.Windows.Forms.StatusBarPanel();
            this.staCompany = new System.Windows.Forms.StatusBarPanel();
            this.staDate = new System.Windows.Forms.StatusBarPanel();
            this.tbaMain = new System.Windows.Forms.ToolBar();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbDangNhap = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbReport = new System.Windows.Forms.ToolBarButton();
            this.tbbLunch = new System.Windows.Forms.ToolBarButton();
            this.tbbStatus = new System.Windows.Forms.ToolBarButton();
            this.tbbManage = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbTimeSheet = new System.Windows.Forms.ToolBarButton();
            this.tbbSalary = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbSettings = new System.Windows.Forms.ToolBarButton();
            this.tbbHelp = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
            this.tbbExit = new System.Windows.Forms.ToolBarButton();
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.mnuManage = new System.Windows.Forms.ContextMenu();
            this.mnuNS = new System.Windows.Forms.MenuItem();
            this.mnuCV = new System.Windows.Forms.MenuItem();
            this.mnuPB = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuQT = new System.Windows.Forms.MenuItem();
            this.mnuDT = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuLL = new System.Windows.Forms.MenuItem();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.menuEx1 = new ControlVault.MenuSuite.MenuEx(this.components);
            this.visualStudioMenuPainter1 = new ControlVault.MenuSuite.VisualStudioMenuPainter(this.components);
            this.office2003MenuPainter1 = new ControlVault.MenuSuite.Office2003MenuPainter(this.components);
            this.imgTab = new System.Windows.Forms.ImageList(this.components);
            this.plainMenuPainter1 = new ControlVault.MenuSuite.PlainMenuPainter(this.components);
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staDate)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mmnuSystem,
            this.mmnuOption,
            this.mmnuHuman,
            this.mmnuDefinition,
            this.mmnuRegistration,
            this.mmnuReport,
            this.mmnuSalary,
            this.mmnuWindows,
            this.mmnuHelp});
            // 
            // mmnuSystem
            // 
            this.menuEx1.SetImageIndex(this.mmnuSystem, -1);
            this.mmnuSystem.Index = 0;
            this.mmnuSystem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.menuItem13,
            this.mnuEditPass,
            this.mnuSeparate2,
            this.mnuAdmin,
            this.mnuBackup,
            this.mnuRestore,
            this.menuItem8,
            this.mnuExit});
            this.mmnuSystem.OwnerDraw = true;
            this.mmnuSystem.Text = "&Hệ thống";
            // 
            // mnuLogin
            // 
            this.menuEx1.SetImageIndex(this.mnuLogin, 0);
            this.mnuLogin.Index = 0;
            this.mnuLogin.OwnerDraw = true;
            this.mnuLogin.Text = "Đăng &nhập...";
            this.mnuLogin.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuLogout
            // 
            this.menuEx1.SetImageIndex(this.mnuLogout, 1);
            this.mnuLogout.Index = 1;
            this.mnuLogout.OwnerDraw = true;
            this.mnuLogout.Text = "Đăng &xuất...";
            this.mnuLogout.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // menuItem13
            // 
            this.menuEx1.SetImageIndex(this.menuItem13, 64);
            this.menuItem13.Index = 2;
            this.menuItem13.OwnerDraw = true;
            this.menuItem13.Text = "Thông tin công ty";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // mnuEditPass
            // 
            this.menuEx1.SetImageIndex(this.mnuEditPass, 2);
            this.mnuEditPass.Index = 3;
            this.mnuEditPass.OwnerDraw = true;
            this.mnuEditPass.Text = "Thay đổi mật khẩu...";
            this.mnuEditPass.Click += new System.EventHandler(this.mnuEditPass_Click);
            // 
            // mnuSeparate2
            // 
            this.menuEx1.SetImageIndex(this.mnuSeparate2, -1);
            this.mnuSeparate2.Index = 4;
            this.mnuSeparate2.OwnerDraw = true;
            this.mnuSeparate2.Text = "-";
            // 
            // mnuAdmin
            // 
            this.menuEx1.SetImageIndex(this.mnuAdmin, 2);
            this.mnuAdmin.Index = 5;
            this.mnuAdmin.OwnerDraw = true;
            this.mnuAdmin.Text = "Quản trị người dùng...";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdministration_Click);
            // 
            // mnuBackup
            // 
            this.menuEx1.SetImageIndex(this.mnuBackup, 3);
            this.mnuBackup.Index = 6;
            this.mnuBackup.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuBackupInMonth,
            this.mnuBackupAll});
            this.mnuBackup.OwnerDraw = true;
            this.mnuBackup.Text = "&Sao lưu dữ liệu...";
            // 
            // mnuBackupInMonth
            // 
            this.menuEx1.SetImageIndex(this.mnuBackupInMonth, -1);
            this.mnuBackupInMonth.Index = 0;
            this.mnuBackupInMonth.OwnerDraw = true;
            this.mnuBackupInMonth.Text = "Sao lưu dữ liệu &theo tháng";
            this.mnuBackupInMonth.Click += new System.EventHandler(this.mnuBackupInMonth_Click);
            // 
            // mnuBackupAll
            // 
            this.menuEx1.SetImageIndex(this.mnuBackupAll, -1);
            this.mnuBackupAll.Index = 1;
            this.mnuBackupAll.OwnerDraw = true;
            this.mnuBackupAll.Text = "Sao lưu toàn bộ &dữ liệu";
            this.mnuBackupAll.Click += new System.EventHandler(this.mnuBackupAll_Click);
            // 
            // mnuRestore
            // 
            this.menuEx1.SetImageIndex(this.mnuRestore, 40);
            this.mnuRestore.Index = 7;
            this.mnuRestore.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuRestoreInMonth,
            this.mnuRestoreAll});
            this.mnuRestore.OwnerDraw = true;
            this.mnuRestore.Text = "Khôi phục dữ liệu...";
            // 
            // mnuRestoreInMonth
            // 
            this.menuEx1.SetImageIndex(this.mnuRestoreInMonth, -1);
            this.mnuRestoreInMonth.Index = 0;
            this.mnuRestoreInMonth.OwnerDraw = true;
            this.mnuRestoreInMonth.Text = "Khôi phục dữ liệu &theo tháng";
            this.mnuRestoreInMonth.Click += new System.EventHandler(this.mnuRestoreInMonth_Click);
            // 
            // mnuRestoreAll
            // 
            this.menuEx1.SetImageIndex(this.mnuRestoreAll, -1);
            this.mnuRestoreAll.Index = 1;
            this.mnuRestoreAll.OwnerDraw = true;
            this.mnuRestoreAll.Text = "Khôi phục toàn bộ &dữ liệu";
            this.mnuRestoreAll.Click += new System.EventHandler(this.mnuRestoreAll_Click);
            // 
            // menuItem8
            // 
            this.menuEx1.SetImageIndex(this.menuItem8, -1);
            this.menuItem8.Index = 8;
            this.menuItem8.OwnerDraw = true;
            this.menuItem8.Text = "-";
            // 
            // mnuExit
            // 
            this.menuEx1.SetImageIndex(this.mnuExit, 4);
            this.mnuExit.Index = 9;
            this.mnuExit.OwnerDraw = true;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "&Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mmnuOption
            // 
            this.menuEx1.SetImageIndex(this.mmnuOption, -1);
            this.mmnuOption.Index = 1;
            this.mmnuOption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDisplay,
            this.mnuLanguage,
            this.mnuSearch,
            this.menuItem2,
            this.mnuPreference,
            this.menuItem3,
            this.menuItem6});
            this.mmnuOption.OwnerDraw = true;
            this.mmnuOption.Text = "&Tùy chọn";
            // 
            // mnuDisplay
            // 
            this.menuEx1.SetImageIndex(this.mnuDisplay, 5);
            this.mnuDisplay.Index = 0;
            this.mnuDisplay.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mmnuXP,
            this.mmnuVS2003,
            this.mmnuOffice2003});
            this.mnuDisplay.OwnerDraw = true;
            this.mnuDisplay.Text = "Hiển thị";
            // 
            // mmnuXP
            // 
            this.menuEx1.SetImageIndex(this.mmnuXP, -1);
            this.mmnuXP.Index = 0;
            this.mmnuXP.OwnerDraw = true;
            this.mmnuXP.Text = "XP";
            this.mmnuXP.Click += new System.EventHandler(this.mmnuXP_Click);
            // 
            // mmnuVS2003
            // 
            this.mmnuVS2003.Checked = true;
            this.menuEx1.SetImageIndex(this.mmnuVS2003, -1);
            this.mmnuVS2003.Index = 1;
            this.mmnuVS2003.OwnerDraw = true;
            this.mmnuVS2003.Text = "VS 2003";
            this.mmnuVS2003.Click += new System.EventHandler(this.mmnuVS2003_Click);
            // 
            // mmnuOffice2003
            // 
            this.menuEx1.SetImageIndex(this.mmnuOffice2003, -1);
            this.mmnuOffice2003.Index = 2;
            this.mmnuOffice2003.OwnerDraw = true;
            this.mmnuOffice2003.Text = "Office2003";
            this.mmnuOffice2003.Click += new System.EventHandler(this.mmnuOffice2003_Click);
            // 
            // mnuLanguage
            // 
            this.menuEx1.SetImageIndex(this.mnuLanguage, 58);
            this.mnuLanguage.Index = 1;
            this.mnuLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEnglish,
            this.mnuVietNamese,
            this.mnuJapanese});
            this.mnuLanguage.OwnerDraw = true;
            this.mnuLanguage.Text = "Ngôn ngữ";
            // 
            // mnuEnglish
            // 
            this.menuEx1.SetImageIndex(this.mnuEnglish, -1);
            this.mnuEnglish.Index = 0;
            this.mnuEnglish.OwnerDraw = true;
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuVietNamese
            // 
            this.mnuVietNamese.Checked = true;
            this.menuEx1.SetImageIndex(this.mnuVietNamese, -1);
            this.mnuVietNamese.Index = 1;
            this.mnuVietNamese.OwnerDraw = true;
            this.mnuVietNamese.Text = "Tiếng Việt";
            this.mnuVietNamese.Click += new System.EventHandler(this.mnuVietNam_Click);
            // 
            // mnuJapanese
            // 
            this.menuEx1.SetImageIndex(this.mnuJapanese, -1);
            this.mnuJapanese.Index = 2;
            this.mnuJapanese.OwnerDraw = true;
            this.mnuJapanese.Text = "Japanese";
            this.mnuJapanese.Click += new System.EventHandler(this.mmnJapanese_Click);
            // 
            // mnuSearch
            // 
            this.menuEx1.SetImageIndex(this.mnuSearch, 7);
            this.mnuSearch.Index = 2;
            this.mnuSearch.OwnerDraw = true;
            this.mnuSearch.Text = "Tìm kiếm...";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // menuItem2
            // 
            this.menuEx1.SetImageIndex(this.menuItem2, -1);
            this.menuItem2.Index = 3;
            this.menuItem2.OwnerDraw = true;
            this.menuItem2.Text = "-";
            // 
            // mnuPreference
            // 
            this.menuEx1.SetImageIndex(this.mnuPreference, 8);
            this.mnuPreference.Index = 4;
            this.mnuPreference.OwnerDraw = true;
            this.mnuPreference.Text = "Thiết lập thông số...";
            this.mnuPreference.Click += new System.EventHandler(this.mnuPreference_Click);
            // 
            // menuItem3
            // 
            this.menuEx1.SetImageIndex(this.menuItem3, 56);
            this.menuItem3.Index = 5;
            this.menuItem3.OwnerDraw = true;
            this.menuItem3.Text = "Gửi Email";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem6
            // 
            this.menuEx1.SetImageIndex(this.menuItem6, 59);
            this.menuItem6.Index = 6;
            this.menuItem6.OwnerDraw = true;
            this.menuItem6.Text = "Đặt tham số hệ thống";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // mmnuHuman
            // 
            this.menuEx1.SetImageIndex(this.mmnuHuman, -1);
            this.mmnuHuman.Index = 2;
            this.mmnuHuman.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEmployeeProfile,
            this.mnuInOut,
            this.mnuEmployeeStatus,
            this.mnuThanhToanTienPhep,
            this.menuItem1,
            this.mnuPosition,
            this.mnuOrganization,
            this.menuItem14,
            this.menuItem10,
            this.menuItem11,
            this.mnuDSCapBHXH,
            this.menuItem12});
            this.mmnuHuman.OwnerDraw = true;
            this.mmnuHuman.Text = "&Nhân sự";
            // 
            // mnuEmployeeProfile
            // 
            this.menuEx1.SetImageIndex(this.mnuEmployeeProfile, 20);
            this.mnuEmployeeProfile.Index = 0;
            this.mnuEmployeeProfile.OwnerDraw = true;
            this.mnuEmployeeProfile.Text = "Quản lý hồ sơ...";
            this.mnuEmployeeProfile.Click += new System.EventHandler(this.mnuHoSoNhanVien_Click);
            // 
            // mnuInOut
            // 
            this.menuEx1.SetImageIndex(this.mnuInOut, 17);
            this.mnuInOut.Index = 1;
            this.mnuInOut.OwnerDraw = true;
            this.mnuInOut.Text = "Quản lý vào ra...";
            this.mnuInOut.Click += new System.EventHandler(this.mnuVaoRa_Click);
            // 
            // mnuEmployeeStatus
            // 
            this.menuEx1.SetImageIndex(this.mnuEmployeeStatus, 18);
            this.mnuEmployeeStatus.Index = 2;
            this.mnuEmployeeStatus.OwnerDraw = true;
            this.mnuEmployeeStatus.Text = "Kiểm soát trạng thái...";
            this.mnuEmployeeStatus.Click += new System.EventHandler(this.mnuTrangThaiNhanVien_Click);
            // 
            // mnuThanhToanTienPhep
            // 
            this.menuEx1.SetImageIndex(this.mnuThanhToanTienPhep, 55);
            this.mnuThanhToanTienPhep.Index = 3;
            this.mnuThanhToanTienPhep.OwnerDraw = true;
            this.mnuThanhToanTienPhep.Text = "Thanh toán tiền phép...";
            this.mnuThanhToanTienPhep.Click += new System.EventHandler(this.mnuThanhToanTienPhep_Click);
            // 
            // menuItem1
            // 
            this.menuEx1.SetImageIndex(this.menuItem1, -1);
            this.menuItem1.Index = 4;
            this.menuItem1.OwnerDraw = true;
            this.menuItem1.Text = "-";
            // 
            // mnuPosition
            // 
            this.menuEx1.SetImageIndex(this.mnuPosition, 24);
            this.mnuPosition.Index = 5;
            this.mnuPosition.OwnerDraw = true;
            this.mnuPosition.Text = "Quản lý chức vụ...";
            this.mnuPosition.Click += new System.EventHandler(this.mnuPosition_Click);
            // 
            // mnuOrganization
            // 
            this.menuEx1.SetImageIndex(this.mnuOrganization, 20);
            this.mnuOrganization.Index = 6;
            this.mnuOrganization.OwnerDraw = true;
            this.mnuOrganization.Text = "Quản lý phòng ban...";
            this.mnuOrganization.Click += new System.EventHandler(this.mmnuOrganization_Click);
            // 
            // menuItem14
            // 
            this.menuEx1.SetImageIndex(this.menuItem14, 65);
            this.menuItem14.Index = 7;
            this.menuItem14.OwnerDraw = true;
            this.menuItem14.Text = "Quản lý nhóm phòng ban...";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem10
            // 
            this.menuEx1.SetImageIndex(this.menuItem10, 53);
            this.menuItem10.Index = 8;
            this.menuItem10.OwnerDraw = true;
            this.menuItem10.Text = "Danh sách LĐ điều chỉnh (mẫu C47)";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuEx1.SetImageIndex(this.menuItem11, 54);
            this.menuItem11.Index = 9;
            this.menuItem11.OwnerDraw = true;
            this.menuItem11.Text = "Đối chiếu số liệu nộp BH (mẫu C46)";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // mnuDSCapBHXH
            // 
            this.menuEx1.SetImageIndex(this.mnuDSCapBHXH, 52);
            this.mnuDSCapBHXH.Index = 10;
            this.mnuDSCapBHXH.OwnerDraw = true;
            this.mnuDSCapBHXH.Text = "Danh sách LĐ đề nghị cấp BHXH";
            this.mnuDSCapBHXH.Click += new System.EventHandler(this.mnuDSCapBHXH_Click);
            // 
            // menuItem12
            // 
            this.menuEx1.SetImageIndex(this.menuItem12, 63);
            this.menuItem12.Index = 11;
            this.menuItem12.OwnerDraw = true;
            this.menuItem12.Text = "Danh sách bệnh viện";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // mmnuDefinition
            // 
            this.menuEx1.SetImageIndex(this.mmnuDefinition, -1);
            this.mmnuDefinition.Index = 3;
            this.mmnuDefinition.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuPunish,
            this.mnuDayType,
            this.mnuShift,
            this.mnuContract,
            this.menuItem4});
            this.mmnuDefinition.OwnerDraw = true;
            this.mmnuDefinition.Text = "Định nghĩa";
            // 
            // mnuPunish
            // 
            this.menuEx1.SetImageIndex(this.mnuPunish, 16);
            this.mnuPunish.Index = 0;
            this.mnuPunish.OwnerDraw = true;
            this.mnuPunish.Text = "Định nghĩa thẻ phạt...";
            this.mnuPunish.Click += new System.EventHandler(this.mnuPunish_Click);
            // 
            // mnuDayType
            // 
            this.menuEx1.SetImageIndex(this.mnuDayType, 11);
            this.mnuDayType.Index = 1;
            this.mnuDayType.OwnerDraw = true;
            this.mnuDayType.Text = "Định nghĩa kiểu ngày...";
            this.mnuDayType.Click += new System.EventHandler(this.mnuDayType_Click);
            // 
            // mnuShift
            // 
            this.menuEx1.SetImageIndex(this.mnuShift, 12);
            this.mnuShift.Index = 2;
            this.mnuShift.OwnerDraw = true;
            this.mnuShift.Text = "Định nghĩa ca làm việc...";
            this.mnuShift.Click += new System.EventHandler(this.mnuShift_Click);
            // 
            // mnuContract
            // 
            this.menuEx1.SetImageIndex(this.mnuContract, 61);
            this.mnuContract.Index = 3;
            this.mnuContract.OwnerDraw = true;
            this.mnuContract.Text = "Định nghĩa loại hợp đồng...";
            this.mnuContract.Click += new System.EventHandler(this.mnuContract_Click);
            // 
            // menuItem4
            // 
            this.menuEx1.SetImageIndex(this.menuItem4, 62);
            this.menuItem4.Index = 4;
            this.menuItem4.OwnerDraw = true;
            this.menuItem4.Text = "Định nghĩa lương cố định..";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click_1);
            // 
            // mmnuRegistration
            // 
            this.menuEx1.SetImageIndex(this.mmnuRegistration, -1);
            this.mmnuRegistration.Index = 4;
            this.mmnuRegistration.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLunch,
            this.mnuOverTime,
            this.mnuWorkingTime,
            this.mnuLeaveSchedule,
            this.mnuRest,
            this.mnuListPunish,
            this.menuItem9});
            this.mmnuRegistration.OwnerDraw = true;
            this.mmnuRegistration.Text = "Đăng ký";
            // 
            // mnuLunch
            // 
            this.menuEx1.SetImageIndex(this.mnuLunch, 46);
            this.mnuLunch.Index = 0;
            this.mnuLunch.OwnerDraw = true;
            this.mnuLunch.Text = "Ăn trưa...";
            this.mnuLunch.Click += new System.EventHandler(this.mnuListLunch_Click);
            // 
            // mnuOverTime
            // 
            this.menuEx1.SetImageIndex(this.mnuOverTime, 51);
            this.mnuOverTime.Index = 1;
            this.mnuOverTime.OwnerDraw = true;
            this.mnuOverTime.Text = "Làm thêm giờ...";
            this.mnuOverTime.Click += new System.EventHandler(this.mnuRegOverTime_Click);
            // 
            // mnuWorkingTime
            // 
            this.menuEx1.SetImageIndex(this.mnuWorkingTime, 50);
            this.mnuWorkingTime.Index = 2;
            this.mnuWorkingTime.OwnerDraw = true;
            this.mnuWorkingTime.Text = "Lịch làm việc...";
            this.mnuWorkingTime.Click += new System.EventHandler(this.mnuRegWorkingTime_Click);
            // 
            // mnuLeaveSchedule
            // 
            this.menuEx1.SetImageIndex(this.mnuLeaveSchedule, 47);
            this.mnuLeaveSchedule.Index = 3;
            this.mnuLeaveSchedule.OwnerDraw = true;
            this.mnuLeaveSchedule.Text = "Lịch công tác...";
            this.mnuLeaveSchedule.Click += new System.EventHandler(this.mnuLichCongTac_Click);
            // 
            // mnuRest
            // 
            this.menuEx1.SetImageIndex(this.mnuRest, 48);
            this.mnuRest.Index = 4;
            this.mnuRest.OwnerDraw = true;
            this.mnuRest.Text = "Nhân viên nghỉ...";
            this.mnuRest.Click += new System.EventHandler(this.mnuRegRestEmployee_Click);
            // 
            // mnuListPunish
            // 
            this.menuEx1.SetImageIndex(this.mnuListPunish, 49);
            this.mnuListPunish.Index = 5;
            this.mnuListPunish.OwnerDraw = true;
            this.mnuListPunish.Text = "Thẻ phạt...";
            this.mnuListPunish.Click += new System.EventHandler(this.mnuListPunish_Click);
            // 
            // menuItem9
            // 
            this.menuEx1.SetImageIndex(this.menuItem9, 57);
            this.menuItem9.Index = 6;
            this.menuItem9.OwnerDraw = true;
            this.menuItem9.Text = "Đăng ký ngày nghỉ";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // mmnuReport
            // 
            this.menuEx1.SetImageIndex(this.mmnuReport, -1);
            this.mmnuReport.Index = 5;
            this.mmnuReport.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuListReport});
            this.mmnuReport.OwnerDraw = true;
            this.mmnuReport.Text = "&Báo cáo";
            // 
            // mnuListReport
            // 
            this.menuEx1.SetImageIndex(this.mnuListReport, 25);
            this.mnuListReport.Index = 0;
            this.mnuListReport.OwnerDraw = true;
            this.mnuListReport.Text = "Danh sách báo cáo...";
            this.mnuListReport.Click += new System.EventHandler(this.mnuListReport_Click);
            // 
            // mmnuSalary
            // 
            this.menuEx1.SetImageIndex(this.mmnuSalary, -1);
            this.mmnuSalary.Index = 6;
            this.mmnuSalary.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTimeSheet,
            this.mnuCalculateSalary});
            this.mmnuSalary.OwnerDraw = true;
            this.mmnuSalary.Text = "&Tính lương";
            // 
            // mnuTimeSheet
            // 
            this.menuEx1.SetImageIndex(this.mnuTimeSheet, 45);
            this.mnuTimeSheet.Index = 0;
            this.mnuTimeSheet.OwnerDraw = true;
            this.mnuTimeSheet.Text = "Bảng chấm công chi tiết tháng...";
            this.mnuTimeSheet.Click += new System.EventHandler(this.mnuTimeSheet_Click);
            // 
            // mnuCalculateSalary
            // 
            this.menuEx1.SetImageIndex(this.mnuCalculateSalary, 44);
            this.mnuCalculateSalary.Index = 1;
            this.mnuCalculateSalary.OwnerDraw = true;
            this.mnuCalculateSalary.Text = "Bảng lương tháng...";
            this.mnuCalculateSalary.Click += new System.EventHandler(this.mnuSalary_Click);
            // 
            // mmnuWindows
            // 
            this.menuEx1.SetImageIndex(this.mmnuWindows, -1);
            this.mmnuWindows.Index = 7;
            this.mmnuWindows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCuaSoTang,
            this.mnuCuaSoDoc,
            this.mnuCuaSoNgang,
            this.menuItem15,
            this.mnuCuaSoDong});
            this.mmnuWindows.OwnerDraw = true;
            this.mmnuWindows.Text = "&Cửa sổ";
            // 
            // mnuCuaSoTang
            // 
            this.menuEx1.SetImageIndex(this.mnuCuaSoTang, 33);
            this.mnuCuaSoTang.Index = 0;
            this.mnuCuaSoTang.OwnerDraw = true;
            this.mnuCuaSoTang.Text = "Theo tầng";
            this.mnuCuaSoTang.Click += new System.EventHandler(this.mnuCuaSoTang_Click);
            // 
            // mnuCuaSoDoc
            // 
            this.menuEx1.SetImageIndex(this.mnuCuaSoDoc, 34);
            this.mnuCuaSoDoc.Index = 1;
            this.mnuCuaSoDoc.OwnerDraw = true;
            this.mnuCuaSoDoc.Text = "Theo chiều dọc";
            this.mnuCuaSoDoc.Click += new System.EventHandler(this.mnuCuaSoDoc_Click);
            // 
            // mnuCuaSoNgang
            // 
            this.menuEx1.SetImageIndex(this.mnuCuaSoNgang, 35);
            this.mnuCuaSoNgang.Index = 2;
            this.mnuCuaSoNgang.OwnerDraw = true;
            this.mnuCuaSoNgang.Text = "Theo chiều ngang";
            this.mnuCuaSoNgang.Click += new System.EventHandler(this.mnuCuaSoNgang_Click);
            // 
            // menuItem15
            // 
            this.menuEx1.SetImageIndex(this.menuItem15, -1);
            this.menuItem15.Index = 3;
            this.menuItem15.OwnerDraw = true;
            this.menuItem15.Text = "-";
            // 
            // mnuCuaSoDong
            // 
            this.menuEx1.SetImageIndex(this.mnuCuaSoDong, 36);
            this.mnuCuaSoDong.Index = 4;
            this.mnuCuaSoDong.OwnerDraw = true;
            this.mnuCuaSoDong.Text = "Đóng tất cả";
            this.mnuCuaSoDong.Click += new System.EventHandler(this.mnuCuaSoDong_Click);
            // 
            // mmnuHelp
            // 
            this.menuEx1.SetImageIndex(this.mmnuHelp, -1);
            this.mmnuHelp.Index = 8;
            this.mmnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout,
            this.mnuHelp,
            this.mnuVersion});
            this.mmnuHelp.OwnerDraw = true;
            this.mmnuHelp.Text = "Trợ &giúp";
            // 
            // mnuAbout
            // 
            this.menuEx1.SetImageIndex(this.mnuAbout, 38);
            this.mnuAbout.Index = 0;
            this.mnuAbout.OwnerDraw = true;
            this.mnuAbout.Text = "Về chương trình...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuHelp
            // 
            this.menuEx1.SetImageIndex(this.mnuHelp, 37);
            this.mnuHelp.Index = 1;
            this.mnuHelp.OwnerDraw = true;
            this.mnuHelp.Text = "Hướng dẫn sử dụng...";
            // 
            // mnuVersion
            // 
            this.menuEx1.SetImageIndex(this.mnuVersion, -1);
            this.mnuVersion.Index = 2;
            this.mnuVersion.OwnerDraw = true;
            this.mnuVersion.Text = "Phiên bản chương trình ...";
            this.mnuVersion.Click += new System.EventHandler(this.mnuVersion_Click);
            // 
            // stbMain
            // 
            this.stbMain.Location = new System.Drawing.Point(0, 503);
            this.stbMain.Name = "stbMain";
            this.stbMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.staState,
            this.staUser,
            this.staNone,
            this.staName,
            this.staCompany,
            this.staDate});
            this.stbMain.ShowPanels = true;
            this.stbMain.Size = new System.Drawing.Size(772, 22);
            this.stbMain.TabIndex = 0;
            // 
            // staState
            // 
            this.staState.Name = "staState";
            this.staState.Text = "Đang khởi tạo...";
            this.staState.Width = 90;
            // 
            // staUser
            // 
            this.staUser.Icon = ((System.Drawing.Icon)(resources.GetObject("staUser.Icon")));
            this.staUser.Name = "staUser";
            this.staUser.Text = "Chưa đăng nhập...";
            this.staUser.Width = 120;
            // 
            // staNone
            // 
            this.staNone.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.staNone.Name = "staNone";
            this.staNone.Width = 75;
            // 
            // staName
            // 
            this.staName.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.staName.Name = "staName";
            this.staName.Text = "Hệ thống quản lý nhân sự";
            this.staName.Width = 180;
            // 
            // staCompany
            // 
            this.staCompany.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.staCompany.Name = "staCompany";
            this.staCompany.Text = "Công ty TNHH Estelle Việt Nam";
            this.staCompany.Width = 200;
            // 
            // staDate
            // 
            this.staDate.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.staDate.Icon = ((System.Drawing.Icon)(resources.GetObject("staDate.Icon")));
            this.staDate.Name = "staDate";
            this.staDate.Text = "12:00 AM";
            this.staDate.Width = 90;
            // 
            // tbaMain
            // 
            this.tbaMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbaMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbSeparator1,
            this.tbbDangNhap,
            this.tbbSeparator2,
            this.tbbReport,
            this.tbbLunch,
            this.tbbStatus,
            this.tbbManage,
            this.tbbSeparator4,
            this.tbbTimeSheet,
            this.tbbSalary,
            this.tbbSeparator3,
            this.tbbSettings,
            this.tbbHelp,
            this.tbbSeparator5,
            this.tbbExit});
            this.tbaMain.ButtonSize = new System.Drawing.Size(63, 44);
            this.tbaMain.DropDownArrows = true;
            this.tbaMain.ImageList = this.imgMain;
            this.tbaMain.Location = new System.Drawing.Point(0, 0);
            this.tbaMain.Name = "tbaMain";
            this.tbaMain.ShowToolTips = true;
            this.tbaMain.Size = new System.Drawing.Size(772, 50);
            this.tbaMain.TabIndex = 4;
            this.tbaMain.Tag = "mnuMain";
            this.tbaMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbaMain_ButtonClick);
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbbSeparator1.Tag = "Option";
            this.tbbSeparator1.ToolTipText = "Thêm mới";
            // 
            // tbbDangNhap
            // 
            this.tbbDangNhap.ImageIndex = 0;
            this.tbbDangNhap.Name = "tbbDangNhap";
            this.tbbDangNhap.Tag = "DangNhap";
            this.tbbDangNhap.Text = "Đăng nhập";
            this.tbbDangNhap.ToolTipText = "Đăng nhập vào hệ thống";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbReport
            // 
            this.tbbReport.ImageIndex = 2;
            this.tbbReport.Name = "tbbReport";
            this.tbbReport.Tag = "Report";
            this.tbbReport.Text = "Báo cáo";
            this.tbbReport.ToolTipText = "Báo cáo";
            // 
            // tbbLunch
            // 
            this.tbbLunch.ImageIndex = 3;
            this.tbbLunch.Name = "tbbLunch";
            this.tbbLunch.Tag = "Antrua";
            this.tbbLunch.Text = "Ăn trưa";
            this.tbbLunch.ToolTipText = "Thiết lập ăn trưa cho nhân viên";
            // 
            // tbbStatus
            // 
            this.tbbStatus.ImageIndex = 4;
            this.tbbStatus.Name = "tbbStatus";
            this.tbbStatus.Tag = "Status";
            this.tbbStatus.Text = "Theo dõi";
            this.tbbStatus.ToolTipText = "Theo dõi trạng thái nhân viên";
            // 
            // tbbManage
            // 
            this.tbbManage.ImageIndex = 5;
            this.tbbManage.Name = "tbbManage";
            this.tbbManage.Tag = "Manage";
            this.tbbManage.Text = "Nhân sự";
            this.tbbManage.ToolTipText = "Quản lý nhân viên";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbTimeSheet
            // 
            this.tbbTimeSheet.ImageIndex = 6;
            this.tbbTimeSheet.Name = "tbbTimeSheet";
            this.tbbTimeSheet.Tag = "TimeSheet";
            this.tbbTimeSheet.Text = "Chấm công";
            this.tbbTimeSheet.ToolTipText = "Chấm công";
            // 
            // tbbSalary
            // 
            this.tbbSalary.ImageIndex = 7;
            this.tbbSalary.Name = "tbbSalary";
            this.tbbSalary.Tag = "Salary";
            this.tbbSalary.Text = "Bảng lương";
            this.tbbSalary.ToolTipText = "Xem bảng lương chi tiết tháng";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSettings
            // 
            this.tbbSettings.ImageIndex = 8;
            this.tbbSettings.Name = "tbbSettings";
            this.tbbSettings.Tag = "Settings";
            this.tbbSettings.Text = "Thiết lập";
            this.tbbSettings.ToolTipText = "Thiết lập";
            // 
            // tbbHelp
            // 
            this.tbbHelp.ImageIndex = 9;
            this.tbbHelp.Name = "tbbHelp";
            this.tbbHelp.Tag = "Help";
            this.tbbHelp.Text = "Trợ giúp";
            this.tbbHelp.ToolTipText = "Trợ giúp";
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbExit
            // 
            this.tbbExit.ImageIndex = 10;
            this.tbbExit.Name = "tbbExit";
            this.tbbExit.Tag = "Exit";
            this.tbbExit.Text = "Thoát";
            this.tbbExit.ToolTipText = "Thoát khỏi hệ thống";
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "");
            this.imgMain.Images.SetKeyName(1, "");
            this.imgMain.Images.SetKeyName(2, "");
            this.imgMain.Images.SetKeyName(3, "");
            this.imgMain.Images.SetKeyName(4, "");
            this.imgMain.Images.SetKeyName(5, "");
            this.imgMain.Images.SetKeyName(6, "");
            this.imgMain.Images.SetKeyName(7, "");
            this.imgMain.Images.SetKeyName(8, "");
            this.imgMain.Images.SetKeyName(9, "");
            this.imgMain.Images.SetKeyName(10, "");
            this.imgMain.Images.SetKeyName(11, "");
            this.imgMain.Images.SetKeyName(12, "");
            this.imgMain.Images.SetKeyName(13, "");
            this.imgMain.Images.SetKeyName(14, "");
            this.imgMain.Images.SetKeyName(15, "");
            // 
            // mnuManage
            // 
            this.mnuManage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNS,
            this.mnuCV,
            this.mnuPB,
            this.menuItem5,
            this.mnuQT,
            this.mnuDT,
            this.menuItem7,
            this.mnuLL});
            // 
            // mnuNS
            // 
            this.menuEx1.SetImageIndex(this.mnuNS, -1);
            this.mnuNS.Index = 0;
            this.mnuNS.OwnerDraw = true;
            this.mnuNS.Text = "&Nhân sự";
            // 
            // mnuCV
            // 
            this.menuEx1.SetImageIndex(this.mnuCV, -1);
            this.mnuCV.Index = 1;
            this.mnuCV.OwnerDraw = true;
            this.mnuCV.Text = "&Chức vụ";
            // 
            // mnuPB
            // 
            this.menuEx1.SetImageIndex(this.mnuPB, -1);
            this.mnuPB.Index = 2;
            this.mnuPB.OwnerDraw = true;
            this.mnuPB.Text = "&Phòng ban";
            // 
            // menuItem5
            // 
            this.menuEx1.SetImageIndex(this.menuItem5, -1);
            this.menuItem5.Index = 3;
            this.menuItem5.OwnerDraw = true;
            this.menuItem5.Text = "-";
            // 
            // mnuQT
            // 
            this.menuEx1.SetImageIndex(this.mnuQT, -1);
            this.mnuQT.Index = 4;
            this.mnuQT.OwnerDraw = true;
            this.mnuQT.Text = "&Quản trị hệ thống";
            // 
            // mnuDT
            // 
            this.menuEx1.SetImageIndex(this.mnuDT, -1);
            this.mnuDT.Index = 5;
            this.mnuDT.OwnerDraw = true;
            this.mnuDT.Text = "&Thiết bị đọc thẻ";
            // 
            // menuItem7
            // 
            this.menuEx1.SetImageIndex(this.menuItem7, -1);
            this.menuItem7.Index = 6;
            this.menuItem7.OwnerDraw = true;
            this.menuItem7.Text = "-";
            // 
            // mnuLL
            // 
            this.menuEx1.SetImageIndex(this.mnuLL, -1);
            this.mnuLL.Index = 7;
            this.mnuLL.OwnerDraw = true;
            this.mnuLL.Text = "&Lịch làm việc";
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "");
            this.imgMenu.Images.SetKeyName(1, "");
            this.imgMenu.Images.SetKeyName(2, "");
            this.imgMenu.Images.SetKeyName(3, "");
            this.imgMenu.Images.SetKeyName(4, "");
            this.imgMenu.Images.SetKeyName(5, "");
            this.imgMenu.Images.SetKeyName(6, "");
            this.imgMenu.Images.SetKeyName(7, "");
            this.imgMenu.Images.SetKeyName(8, "");
            this.imgMenu.Images.SetKeyName(9, "");
            this.imgMenu.Images.SetKeyName(10, "");
            this.imgMenu.Images.SetKeyName(11, "");
            this.imgMenu.Images.SetKeyName(12, "");
            this.imgMenu.Images.SetKeyName(13, "");
            this.imgMenu.Images.SetKeyName(14, "");
            this.imgMenu.Images.SetKeyName(15, "");
            this.imgMenu.Images.SetKeyName(16, "");
            this.imgMenu.Images.SetKeyName(17, "");
            this.imgMenu.Images.SetKeyName(18, "");
            this.imgMenu.Images.SetKeyName(19, "");
            this.imgMenu.Images.SetKeyName(20, "");
            this.imgMenu.Images.SetKeyName(21, "");
            this.imgMenu.Images.SetKeyName(22, "");
            this.imgMenu.Images.SetKeyName(23, "");
            this.imgMenu.Images.SetKeyName(24, "");
            this.imgMenu.Images.SetKeyName(25, "");
            this.imgMenu.Images.SetKeyName(26, "");
            this.imgMenu.Images.SetKeyName(27, "");
            this.imgMenu.Images.SetKeyName(28, "");
            this.imgMenu.Images.SetKeyName(29, "");
            this.imgMenu.Images.SetKeyName(30, "");
            this.imgMenu.Images.SetKeyName(31, "");
            this.imgMenu.Images.SetKeyName(32, "");
            this.imgMenu.Images.SetKeyName(33, "");
            this.imgMenu.Images.SetKeyName(34, "");
            this.imgMenu.Images.SetKeyName(35, "");
            this.imgMenu.Images.SetKeyName(36, "");
            this.imgMenu.Images.SetKeyName(37, "");
            this.imgMenu.Images.SetKeyName(38, "");
            this.imgMenu.Images.SetKeyName(39, "");
            this.imgMenu.Images.SetKeyName(40, "");
            this.imgMenu.Images.SetKeyName(41, "");
            this.imgMenu.Images.SetKeyName(42, "");
            this.imgMenu.Images.SetKeyName(43, "");
            this.imgMenu.Images.SetKeyName(44, "");
            this.imgMenu.Images.SetKeyName(45, "");
            this.imgMenu.Images.SetKeyName(46, "");
            this.imgMenu.Images.SetKeyName(47, "");
            this.imgMenu.Images.SetKeyName(48, "");
            this.imgMenu.Images.SetKeyName(49, "");
            this.imgMenu.Images.SetKeyName(50, "");
            this.imgMenu.Images.SetKeyName(51, "");
            this.imgMenu.Images.SetKeyName(52, "");
            this.imgMenu.Images.SetKeyName(53, "");
            this.imgMenu.Images.SetKeyName(54, "");
            this.imgMenu.Images.SetKeyName(55, "");
            this.imgMenu.Images.SetKeyName(56, "");
            this.imgMenu.Images.SetKeyName(57, "");
            this.imgMenu.Images.SetKeyName(58, "");
            this.imgMenu.Images.SetKeyName(59, "");
            this.imgMenu.Images.SetKeyName(60, "");
            this.imgMenu.Images.SetKeyName(61, "");
            this.imgMenu.Images.SetKeyName(62, "");
            this.imgMenu.Images.SetKeyName(63, "");
            this.imgMenu.Images.SetKeyName(64, "home.ico");
            this.imgMenu.Images.SetKeyName(65, "users_family.ico");
            // 
            // menuEx1
            // 
            this.menuEx1.ImageList = this.imgMenu;
            this.menuEx1.MenuPainter = this.visualStudioMenuPainter1;
            // 
            // imgTab
            // 
            this.imgTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTab.ImageStream")));
            this.imgTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTab.Images.SetKeyName(0, "");
            this.imgTab.Images.SetKeyName(1, "");
            this.imgTab.Images.SetKeyName(2, "");
            this.imgTab.Images.SetKeyName(3, "");
            this.imgTab.Images.SetKeyName(4, "");
            this.imgTab.Images.SetKeyName(5, "");
            this.imgTab.Images.SetKeyName(6, "");
            this.imgTab.Images.SetKeyName(7, "");
            this.imgTab.Images.SetKeyName(8, "");
            this.imgTab.Images.SetKeyName(9, "");
            this.imgTab.Images.SetKeyName(10, "");
            this.imgTab.Images.SetKeyName(11, "");
            this.imgTab.Images.SetKeyName(12, "");
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 200;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(772, 525);
            this.Controls.Add(this.tbaMain);
            this.Controls.Add(this.stbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#region Các hàm tự định nghĩa

		/// <summary>
		/// Thiết lập trạng thái các menu sau khi thực hiện đăng nhập hoặc đăng xuất khỏi hệ thống
		/// </summary>
		/// <param name="isLogin"></param>
		public void SetMenuStatus(bool isLogin)
		{
			string sttr = WorkingContext.LangManager.GetString("Bosung4_1");
			staState.Text = sttr;
			staUser.Text = WorkingContext.Username;
			ShowCurrentTime();
			//int ktPermision=0;
			foreach (MenuItem menuItem in mainMenu1.MenuItems)
			{
				if ((!menuItem.Equals(mmnuOption))&& (!menuItem.Equals(mmnuWindows))&&(!menuItem.Equals(mmnuHelp)))
				{
					SetMenuStatusRec(menuItem,false);
			//		ktPermision = 1;
				}
			}
			//if(ktPermision==1)
			foreach (ToolBarButton button in tbaMain.Buttons)
			{
				button.Enabled = false;
			}
			
			if(isLogin)
			{
				SetMenuPermission();
				SetToolBarPermission();
			}
			
			mnuLogin.Enabled = !isLogin;

			//Toolbar
			tbbDangNhap.Enabled = !isLogin;
			tbbSettings.Enabled = true;
			tbbHelp.Enabled = true;
			tbbExit.Enabled = true;
			mnuLogin.Visible = !isLogin;
			mnuLogout.Visible = isLogin;
			mnuExit.Visible = true;
			mnuBackup.Visible = isLogin;
			mnuBackupAll.Visible = true;
			mnuBackupInMonth.Visible = true;
			mnuRestore.Visible = isLogin;
			mnuRestoreAll.Visible = true;
			mnuRestoreInMonth.Visible = true;
			mnuEditPass.Visible = isLogin;
			//mnuThanhToanTienPhep.Visible = isLogin;
			//			mnuAdmin.Visible = true;
			//mnuSocial.Visible = true;
			
			
		}
		
		/// <summary>
		/// Thiết lập thuộc tính Enable của menu (thực hiện đệ quy)
		/// </summary>
		/// <param name="menuItem"></param>
		/// <param name="isLogin"></param>
		private void SetMenuStatusRec(MenuItem menuItem,bool isLogin)
		{
			foreach (MenuItem childMenu in menuItem.MenuItems)
			{
				if (!childMenu.IsParent)
				{
					childMenu.Visible = isLogin;
				}
				else
				{
					SetMenuStatusRec(childMenu,isLogin);
				}
			
			}
		}

		private void SetToolBarPermission()
		{
			DataRow[] dataRow = login.PermissionDataSet.Tables[0].Select();
			int i = 0;
			//int t = 0;
			while(i < dataRow.Length )
			{
				
				string str;
				if (checkLang == true)
				{
					str = dataRow[i]["ToolbarName"].ToString();
				}
				else
				{
					str = dataRow[i]["ToolbarNameTN"].ToString(); 
				}
				foreach (ToolBarButton button in tbaMain.Buttons)
				{
					if (button.Text== str)
					{
						button.Enabled = true;
						break;
					}
				}
				i = i+ 1;
			}
		}
		/// <summary>
		/// Thiết lập trạng thái của các menu theo các quyền của người sử dụng
		/// tuyetna
		/// </summary>
		private void SetMenuPermission()
		{
			//frmLogin formlogin = new frmLogin(this);

			DataRow[] dataRow = login.PermissionDataSet.Tables[0].Select();
			int i = 0;// đếm từng phần tử từ dataRow chứa các quyền
			int t = 0;
			while(i < dataRow.Length )
			{
				
				string str;
				if (checkLang==true)
				{
					str = dataRow[i]["ItemName"].ToString();
				}
				else
				{
					str = dataRow[i]["ItemNameTN"].ToString();
				}
				if ((str =="Feature")||(str=="Employee")||(str=="TimeSheet")||(str=="Salary")||(str=="InOut")||(str=="Department")||(str=="Schedule")||(str=="Definition")||(str=="Report")||(str=="Admin"))
				{
					///
				}
				else
				{
					if(t==0)
					{
						foreach(MenuItem menu in mainMenu1.MenuItems)
						{
							if (t==0)
							{
								if ((!menu.Equals(mmnuOption))&& (!menu.Equals(mmnuWindows))&&(!menu.Equals(mmnuHelp)))
								{
						
									foreach(MenuItem menu1 in menu.MenuItems)
									{
										//check (menu1,str);
										if (menu1.Text.ToUpper() == str.ToUpper())
										{
											menu1.Visible = true;
											t = 1;
											break;
									
										}
										
							
									}
								}
							}
						}
					}
					else
					{
						
					}
					t=0;
				}
				i = i+ 1;
			}
		}


		/// <summary>
		/// Hiển thị splash screen trước khi vào chương trình chính
		/// </summary>
		public void ShowSplashScreen()
		{
			SplashForm.StartSplash(@"IMAGES\about.jpg", Color.FromArgb(128, 128, 128));

			// simulating operations at startup
			Thread.Sleep(2000);

			// close the splash screen
			SplashForm.CloseSplash();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			string str = WorkingContext.LangManager.GetString("frmMain_MessaThem");
			string str1 = WorkingContext.LangManager.GetString("frmMain_MessaThem1");
			if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		#endregion

        //internal bool CheckMdiClientDuplicates(string WndCls)
        //{
        //    Form[] mdichld= this.MdiChildren; 
        //    if (this.MdiChildren.Length == 0) 
        //    {
        //        return true;
        //    }
        //    foreach (Form selfm in mdichld) 
        //    {
        //        string str=selfm.Name;
        //        str = str.IndexOf(WndCls).ToString();
        //        if (str != "-1")
        //        {
        //            selfm.Activate();
        //            return false;
        //        }
        //    }
        //    return true;
        //}
		

		#region Windows Form Events Handlers

		private void mnuCuaSoTang_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mnuCuaSoDoc_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnuCuaSoNgang_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void mnuCuaSoDong_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
		}

		private void tbaMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch (Convert.ToString(e.Button.Tag))
			{
				case "DangNhap":
                    settingsModule= new  ModuleSettings();
                    settingsModule = ModuleConfig.GetSettings();

                    if (WorkingContext.CheckConnection(settingsModule.Server, settingsModule.Database, settingsModule.UserName, settingsModule.Password))
                    {
                        AdminDO adminDO = new AdminDO();
                        EmployeeDO employeeDO = new EmployeeDO();
                        dsUser = adminDO.GetAllUsers();
                        dsEmployee = employeeDO.GetAllEmployees(1);
                        if (dsUser.Tables[0].Rows.Count == 0 || dsEmployee.Tables[0].Rows.Count == 0)
                        {
                            NotLogin(true);
                        }
                        else
                            login.ShowDialog(this);
                    }
                    else
                    {
                        string str4 = WorkingContext.LangManager.GetString("frmSetting_Error1_Title");
                        string str5 = WorkingContext.LangManager.GetString("frmSetting_Error2");
                        //MessageBox.Show("Không thể kết nối được cơ sở dữ liệu. Hãy nhập lại thông số cấu hình hệ thống", "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                        MessageBox.Show(str5, str4, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        frmSettings settings = new frmSettings();
                        settings.ShowDialog(this);
                        this.Refresh();
                    }
					break;
				case "Search":
					if (CheckMdiClientDuplicates("frmSearch"))
					{
						frmSearch search = new frmSearch();
						search.Show();
						search.MdiParent = this;
					}
					break;
				case "Report":
					if (CheckMdiClientDuplicates("frmListReport"))
					{
						frmListReport report = new frmListReport();
						report.Show();
						report.MdiParent = this;
					}
					
					break;
				case "Status":
					if (CheckMdiClientDuplicates("frmEmployeeStatus"))
					{
						frmEmployeeStatus status = new frmEmployeeStatus();
						status.Show();
						status.MdiParent = this;
					}
					break;
				case "Schedule":
					if (CheckMdiClientDuplicates("frmRegWorkingTime"))
					{
						frmRegWorkingTime workingTime1 = new frmRegWorkingTime();
						workingTime1.Show();
						workingTime1.MdiParent = this;
                    }
					break;
				case "Manage":
					if (CheckMdiClientDuplicates("frmListEmployees"))
					{
						frmListEmployees listEmployees = new frmListEmployees();
						listEmployees.Show();
						listEmployees.MdiParent = this;
					}
					break;
				case "Salary":
					if (CheckMdiClientDuplicates("frmListSalary"))
					{
						frmListSalary salary = new frmListSalary();
						salary.Show();
						salary.MdiParent = this;
					}
					break;
				case "TimeSheet":
					if (CheckMdiClientDuplicates("frmTimeSheet"))
					{
						frmTimeSheet timesheet = new frmTimeSheet();
						timesheet.Show();
						timesheet.MdiParent = this;
					}
					break;
				case "Settings":
					frmSettings frmsettings = new frmSettings();
                    frmsettings.ShowDialog(this);
					this.Refresh();
					break;
				case "Help":
					MessageBox.Show("Chức năng này đang được xây dựng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				case "Antrua":
					if (CheckMdiClientDuplicates("frmLunch"))
					{
						frmLunch frm = new frmLunch();
						frm.Show();
						frm.MdiParent = this;
					}
					break;
				case "Exit":
					string str = WorkingContext.LangManager.GetString("frmMain_MessaThem");
					string str1 = WorkingContext.LangManager.GetString("frmMain_MessaThem1");
					if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Application.Exit();
					}
					break;
			}
		}

		//menu dang nhap hệ thống
		private void mnuDangNhap_Click(object sender, EventArgs e)
		{
            settingsModule = ModuleConfig.GetSettings();

            if (WorkingContext.CheckConnection(settingsModule.Server, settingsModule.Database, settingsModule.UserName, settingsModule.Password))
            {
                AdminDO adminDO = new AdminDO();
                EmployeeDO employeeDO = new EmployeeDO();
                dsUser = adminDO.GetAllUsers();
                dsEmployee = employeeDO.GetAllEmployees(1);
                if (dsUser.Tables[0].Rows.Count == 0 || dsEmployee.Tables[0].Rows.Count == 0)
                {
                    NotLogin(true);
                }
                else
                    login.ShowDialog(this);
            }
            else
            {
                string str4 = WorkingContext.LangManager.GetString("frmSetting_Error1_Title");
                string str5 = WorkingContext.LangManager.GetString("frmSetting_Error2");
                //MessageBox.Show("Không thể kết nối được cơ sở dữ liệu. Hãy nhập lại thông số cấu hình hệ thống", "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str5, str4, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                frmSettings frmsettings = new frmSettings();
                frmsettings.ShowDialog(this);
                this.Refresh();
            }
		}
            
	    [STAThread]
		private static void Main()
		{
           //Thiết lập thuộc tính Style XP cho chương trình
            Application.EnableVisualStyles();


            //WorkingContext.RegistionType = CheckRegistion();
            ////Kiểm tra trial
            //if (WorkingContext.RegistionType == RegistionType.UnRegistered)
            //{
            //    if(TrialVersion.IsRegister())//Nếu đã đăng ký trial
            //    {
            //        if (TrialVersion.PeriodOfValidity())//Còn thời hạn
            //            WorkingContext.RegistionType = RegistionType.Trial;
            //        else
            //            Application.Run(new frmActivation());
            //    }
            //    else
            //        Application.Run(new frmActivation());
            //}
            ////Gọi form cho phép đăng ký lại
            //else if (WorkingContext.RegistionType == RegistionType.ErrorRegistered)
            //{
            //    Application.Run(new frmActivation());
            //}

            //if ((WorkingContext.RegistionType == RegistionType.Trial) || (WorkingContext.RegistionType == RegistionType.Registered))
            //{
                Application.DoEvents();
                WorkingContext.InitWorkingContext();
                Application.Run(new frmMain());
                WorkingContext.DisposeWorkingContext();
            //}
		}

        #region Lisence

        public const string strFileRegistion = "Lisence.reg";
        //public static RegistionType CheckRegistion()
        //{
        //    FileInfo f = new FileInfo(Application.StartupPath + "\\" + strFileRegistion);
        //    if (!f.Exists)
        //        return RegistionType.UnRegistered;
        //    else
        //    {
        //        string keyInstall =
        //            HRMSLicense.FileReadWrite.ReadFile(Application.StartupPath + "\\" + strFileRegistion);
        //        string key = HRMSLicense.License.GenerationKey(HRMSLicense.License.GetSystemInfo());
        //        if (keyInstall == key)
        //            return RegistionType.Registered;
        //        else
        //            return RegistionType.ErrorRegistered;
        //    }
        //}
        #endregion

        #region TrialVersion
        private static DateTime BeginAllowTime = new DateTime(2007, 5, 7);
        private static DateTime DeadLineTime = new DateTime(2007, 6, 1);
        private static bool CheckTrialVersion()
        {
            FileInfo flie = new FileInfo(Application.ExecutablePath);
            if (DateTime.Now > BeginAllowTime)
                if (DateTime.Now < DeadLineTime)
                    if ((DateTime.Now > (new FileInfo(Application.ExecutablePath)).CreationTime) & (DateTime.Now < (new FileInfo(Application.ExecutablePath)).CreationTime.AddDays(30)))
                        return true;
            return true;
        }
        #endregion

        private void mnuTrangThaiNhanVien_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmEmployeeStatus"))
			{
				frmEmployeeStatus status = new frmEmployeeStatus();
				status.Show();
				status.MdiParent = this;
			}
		}

		private void mnuGioiThieu_Click(object sender, EventArgs e)
		{
			SplashForm.StartSplash(@"IMAGES\\about.jpg", Color.FromArgb(128, 128, 128));
		}

		private void mnuDangXuat_Click(object sender, EventArgs e)
		{
		
			SetMenuStatus(false);
			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
			string str = WorkingContext.LangManager.GetString("Bosung8_1");
			staUser.Text = str;
			login.ClearData();
			
		}

		private void mnuHoSoNhanVien_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListEmployees"))
			{
				frmListEmployees listEmployees = new frmListEmployees();
				listEmployees.Show();
				listEmployees.MdiParent = this;
			}
		}

		
		private void mmnuOrganization_Click(object sender, EventArgs e)
		{
			frmListDepartment frm = new frmListDepartment();
			frm.ShowDialog();
		}
	
		private void mnuPosition_Click(object sender, EventArgs e)
		{
			frmListPosition frm = new frmListPosition();
			frm.Show();
			frm.MdiParent	= this;
		}

		private void mnuLichCongTac_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListLeaveSchedule"))
			{
				frmListLeaveSchedule  listLeaveSchedule = new frmListLeaveSchedule();
				listLeaveSchedule.Show();
				listLeaveSchedule.MdiParent = this;
			}
		}

		private void mnuRegOverTime_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListRegOverTime"))
			{
				frmListRegOverTime listRegOverTime = new frmListRegOverTime();
				listRegOverTime.Show();
				listRegOverTime.MdiParent = this;
			}
		}

		private void mnuRegRestEmployee_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListRegRestEmployee"))
			{
				frmListRegRestEmployee regRestEmployee = new frmListRegRestEmployee();
				regRestEmployee.Show();
				regRestEmployee.MdiParent = this;
			}
		}

		private void mmnuOffice2003_Click(object sender, EventArgs e)
		{
			this.menuEx1.MenuPainter = this.office2003MenuPainter1;
			this.mmnuVS2003.Checked = false;
			this.mmnuXP.Checked = false;
			this.mmnuOffice2003.Checked = true;
		}

		private void mmnuXP_Click(object sender, EventArgs e)
		{
			this.menuEx1.MenuPainter = this.plainMenuPainter1;
			this.mmnuVS2003.Checked = false;
			this.mmnuXP.Checked = true;
			this.mmnuOffice2003.Checked = false;
		}

		private void mmnuVS2003_Click(object sender, EventArgs e)
		{
			this.menuEx1.MenuPainter = this.visualStudioMenuPainter1;
			this.mmnuVS2003.Checked = true;
			this.mmnuXP.Checked = false;
			this.mmnuOffice2003.Checked = false;
		}

		private void mnuSearch_Click(object sender, EventArgs e)
		{
			frmSearch search = new frmSearch();
			search.Show();
		}

		private void mnuSalary_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListSalary"))
			{
				frmListSalary salary = new frmListSalary();
				salary.Show();
				salary.MdiParent = this;
			}
		}

		private void mnuAdministration_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("FrmUserAdmin"))
			{
				FrmUserAdmin frmAdmin = new FrmUserAdmin();
				frmAdmin.MdiParent = this;
				frmAdmin.Show();
			}
		}

		private void frmMain_Closing(object sender, CancelEventArgs e)
		{
			string str = WorkingContext.LangManager.GetString("frmMain_MessaThem");
			string str1 = WorkingContext.LangManager.GetString("frmMain_MessaThem1");
			if (MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
			else 
			{
				e.Cancel = true;
			}
		}

		private void mnuPreference_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmSettings"))
			{
				frmSettings frm = new frmSettings();
				frm.Show();
				frm.MdiParent = this;
				this.Refresh();
			}
		}

		private void mnuVaoRa_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmChooseTimeInOut"))
			{
				frmChooseTimeInOut frm = new frmChooseTimeInOut();
				frm.MdiParent = this;
				frm.Show();
			}
		}

		private void mnuListPunish_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListPunish"))
			{
				frmListPunish frm = new frmListPunish();
				frm.MdiParent = this;
				frm.Show();
			}
		}
		
		private void ShowCurrentTime()
		{
			DateTime now = DateTime.Now;
			staDate.Text = now.ToLongTimeString();
		}

		private void tmrTimeUpdate_Tick(object sender, EventArgs e)
		{
			ShowCurrentTime();
		}

		private void mnuListLunch_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListLunch"))
			{
				frmListLunch frm = new frmListLunch();
				frm.MdiParent = this;
				frm.Show();
			}
		}

		private void mnuTimeSheet_Click(object sender, EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmTimeSheet"))
			{
				frmTimeSheet timesheet = new frmTimeSheet();
				timesheet.Show();
				timesheet.MdiParent = this;
			}
		}

		
		private void mnuPunish_Click(object sender, System.EventArgs e)
		{
			frmPunishCard frm = new frmPunishCard();
			frm.ShowDialog();
		}

		private void mnuDayType_Click(object sender, System.EventArgs e)
		{
			frmListDayType frm = new frmListDayType();
			frm.Show();
			frm.MdiParent = this;
		}

		private void mnuShift_Click(object sender, System.EventArgs e)
		{
			frmListShift frm = new frmListShift();
			frm.Show();
			frm.MdiParent = this;
		}

		private void mnuRegWorkingTime_Click(object sender, System.EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmRegWorkingTime"))
			{
				frmRegWorkingTime frm = new frmRegWorkingTime();
				frm.Show();
				frm.MdiParent = this;
			}
		}

        /// <summary>
        /// Danh sách báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void mnuListReport_Click(object sender, System.EventArgs e)
		{
			if (CheckMdiClientDuplicates("frmListReport"))
			{
				frmListReport report = new frmListReport();
				report.Show();
				report.MdiParent = this;
			}
		}

		#endregion

		private void mnuContract_Click(object sender, System.EventArgs e)
		{
			frmListContractType frm = new frmListContractType();
			frm.Show();
			frm.MdiParent = this;
		}

		private void mnuEditPass_Click(object sender, System.EventArgs e)
		{
			frmChangePassword frm = new frmChangePassword();
			frm.Show();
			frm.MdiParent = this;
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
            SetMenuStatus(false);

		}


		private void mnuThanhToanTienPhep_Click(object sender, System.EventArgs e)
		{
			frmRestSheet frm = new frmRestSheet();
			frm.Show();
			frm.MdiParent = this;
		}

		private void mmnJapanese_Click(object sender, System.EventArgs e)
		{
			WorkingContext.Language = "ja-JP";
			mnuEnglish.Checked = false;
			mnuVietNamese.Checked = false;
			mnuJapanese.Checked = true;
			checkLang = false;
			this.mnuJapanese.Text = "日本語";
			this.mnuVietNamese.Text = "VietNamese";
			this.mnuEnglish.Text = "English";
			
			this.Refresh();
		}

		private void mnuEnglish_Click(object sender, System.EventArgs e)
		{
			WorkingContext.Language = "en-US";
			mnuVietNamese.Checked = false;
			mnuJapanese.Checked = false;
			mnuEnglish.Checked = true;
			this.mnuJapanese.Text = "Japanese";
			this.mnuVietNamese.Text = "VietNamese";
			this.Refresh();
			
		}

		private void mnuVietNam_Click(object sender, System.EventArgs e)
		{
			WorkingContext.Language = "vi-VN";
			mnuEnglish.Checked = false;
			mnuJapanese.Checked = false;
			mnuVietNamese.Checked = true;
			this.Refresh();
			checkLang = true;
			this.mnuJapanese.Text = "Tiếng Nhật";
			this.mnuVietNamese.Text = "Tiếng Việt";
			this.mnuEnglish.Text = "Tiếng Anh";
		}

		public void ChangeToCurrentLang()
		{
			this.mnuLanguage.Text = WorkingContext.LangManager.GetString("TXT_MAIN_00002");
			this.mnuExit.Text = WorkingContext.LangManager.GetString("TXT_MENU_00001");
			this.mnuHelp.Text = WorkingContext.LangManager.GetString("TXT_MENU_00002");
			
			this.mmnuSystem.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem");
			this.mmnuOption.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption");
			this.mmnuHuman.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman");
			this.mmnuRegistration.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration");
			this.mmnuDefinition.Text = WorkingContext.LangManager.GetString("frmMain_mmnuDefinition");
			this.mmnuReport.Text = WorkingContext.LangManager.GetString("frmMain_mmnuReport");
			this.mmnuSalary.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSalary");
			this.mmnuWindows.Text = WorkingContext.LangManager.GetString("frmMain_mmnuWindows");
			this.mmnuHelp.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHelp");
			this.tbbDangNhap.Text = WorkingContext.LangManager.GetString("frmMain_tbbDangNhap");
			this.tbbDangNhap.ToolTipText = WorkingContext.LangManager.GetString("Bosung7_1");
			this.tbbReport.Text = WorkingContext.LangManager.GetString("frmMain_tbbReport");
			this.tbbReport.ToolTipText = WorkingContext.LangManager.GetString("frmMain_tbbReport");
			this.tbbLunch.Text = WorkingContext.LangManager.GetString("frmMain_tbbLunch");
			this.tbbLunch.ToolTipText = WorkingContext.LangManager.GetString("Bosung_tool1");
			this.tbbStatus.Text = WorkingContext.LangManager.GetString("frmMain_tbbStatus");
			this.tbbStatus.ToolTipText = WorkingContext.LangManager.GetString("frmEmployeeStatus_Text");
			this.tbbManage.Text = WorkingContext.LangManager.GetString("frmMain_tbblManage");
			this.tbbManage.ToolTipText = WorkingContext.LangManager.GetString("Bosung_tool2");
			this.tbbTimeSheet.Text = WorkingContext.LangManager.GetString("frmMain_tbbTimeSheet");
			this.tbbTimeSheet.ToolTipText = WorkingContext.LangManager.GetString("Bosung_tool3");
			this.tbbSalary.Text = WorkingContext.LangManager.GetString("frmMain_tbbSalary");
			this.tbbSalary.ToolTipText = WorkingContext.LangManager.GetString("frmListSalary_groupbox1");
			this.tbbSettings.Text = WorkingContext.LangManager.GetString("frmMain_tbbSetting");
			this.tbbSettings.ToolTipText = WorkingContext.LangManager.GetString("frmMain_tbbSetting");
			this.tbbHelp.Text = WorkingContext.LangManager.GetString("frmMain_tbbHelp");
			this.tbbHelp.ToolTipText = WorkingContext.LangManager.GetString("frmMain_tbbHelp");
			this.tbbExit.Text = WorkingContext.LangManager.GetString("frmMain_tbbExit");
			this.tbbExit.ToolTipText = WorkingContext.LangManager.GetString("Bosung_tool4");
			this.staState.Text = WorkingContext.LangManager.GetString("Bosung4_1");
			this.staName.Text = WorkingContext.LangManager.GetString("frmMain_Name");
			this.staCompany.Text = WorkingContext.LangManager.GetString("frmMain_StaCompany");
			this.mnuLogout.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuLogout");
			this.mnuLogin.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuLogin");
			this.mnuEditPass.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuChangePass");
			this.mnuAdmin.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuAdmin");
			this.mnuBackup.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuBachup");
			this.mnuBackupAll.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuBachupAll");
			this.mnuBackupInMonth.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuBachupInMonth");
			this.mnuRestore.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuRestore");
			this.mnuRestoreAll.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuRestoreAll");
			this.mnuRestoreInMonth.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuRestoreInMonth");
			this.mnuExit.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSystem_mnuExit");
			this.mnuDisplay.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuDisplay");
			this.mnuLanguage.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuLanguage");
			this.mnuSearch.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuSearch");
			this.mnuPreference.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuPreference");
			this.mnuEmployeeProfile.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman_mnuEmployeeProfile");
			this.mnuEmployeeStatus.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman_mnuEmployeeStatus");
			this.mnuInOut.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman_mnuInOut");
			this.mnuPosition.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman_mnuPosition");
			this.mnuOrganization.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHuman_mnuOrganization");
			//this.mnuEnglish.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuLanguage_mnuEnglish");
			//this.mnuVietNamese.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuLanguage_mnuVietNamese");
			//this.mnuJapanese.Text = WorkingContext.LangManager.GetString("frmMain_mmnuOption_mnuLanguage_mnuJapanese");
			this.mnuPunish.Text = WorkingContext.LangManager.GetString("frmMain_mmnuDefinition_mnuPunish");
			this.mnuDayType.Text = WorkingContext.LangManager.GetString("frmMain_mmnuDefinition_mnuDayType");
			this.mnuShift.Text = WorkingContext.LangManager.GetString("frmMain_mmnuDefinition_mnuShift");
			this.mnuContract.Text = WorkingContext.LangManager.GetString("frmMain_mmnuDefinition_mnuContract");
			this.mnuLunch.Text = WorkingContext.LangManager.GetString("frmMian_mmnuRegistration_mnuLunch");
			this.mnuOverTime.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration_mnuOverTime");
			this.mnuWorkingTime.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration_mnuWorkingTime");
			this.mnuLeaveSchedule.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration_mnuLeaveShedule");
			this.mnuRest.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration_mnuRest");
			this.mnuListPunish.Text = WorkingContext.LangManager.GetString("frmMain_mmnuRegistration_mnuListPunish");
			this.mnuListReport.Text = WorkingContext.LangManager.GetString("frmMain_mmnuReport_mnuListReport");
			this.mnuTimeSheet.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSalary_mnuTimeSheet");
			this.mnuCalculateSalary.Text = WorkingContext.LangManager.GetString("frmMain_mmnuSalary_mnuCalculateSalary");
			this.mnuCuaSoTang.Text = WorkingContext.LangManager.GetString("frmMain_mmnuWindows_mnuCuaSoTang");
			this.mnuCuaSoDoc.Text = WorkingContext.LangManager.GetString("frmMain_mmnuWindows_mnuCuaSoDoc");
			this.mnuCuaSoNgang.Text = WorkingContext.LangManager.GetString("frmMain_mmnuWindows_mnuCuaSoNgang");
			this.mnuCuaSoDong.Text = WorkingContext.LangManager.GetString("frmMain_mmnuWindows_mnuCuaSoDong");
			this.mnuHelp.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHelp_mnuHelp");
			this.mnuAbout.Text = WorkingContext.LangManager.GetString("frmMain_mmnuHelp_mnuAbout");
			this.mnuThanhToanTienPhep.Text = WorkingContext.LangManager.GetString("frmMain_MessaThem2");
			this.mnuEditPass.Text = WorkingContext.LangManager.GetString("frmMain_MessaThem4");
			this.mnuVersion.Text = WorkingContext.LangManager.GetString("frmVersion_text");
            if (WorkingContext.Language == "en-US")
                this.Text = WorkingContext.LangManager.GetString("frmMain_Name");
            else
                this.Text = WorkingContext.LangManager.GetString("frmMain_Name") + " " + WorkingContext.LangManager.GetString("frmMain_StaCompany");

			//			this.mnuVietnamese.Text = WorkingContext.LangManager.GetString("TXT_MENU_00003");
			//			this.mnuJapanese.Text = WorkingContext.LangManager.GetString("TXT_MENU_00003");
            
		}

        internal bool CheckMdiClientDuplicates(string WndCls)
        {
            Form[] mdichld = MdiChildren;
            if (MdiChildren.Length == 0)
            {
                return true;
            }
            foreach (Form selfm in mdichld)
            {
                if (selfm.Name.ToUpper() == WndCls.ToUpper())
                {
                    selfm.Activate();
                    return false;
                }
            }
            return true;
        }

		private void mnuVersion_Click(object sender, System.EventArgs e)
		{
			frmVersion frm = new frmVersion();
			frm.ShowDialog();

		}

		private void mnuBackupAll_Click(object sender, System.EventArgs e)
		{
			frmBackup frm = new frmBackup();
			frm.ShowDialog();
		}

		private void mnuRestoreAll_Click(object sender, System.EventArgs e)
		{
			frmRestore frm = new frmRestore();
			frm.ShowDialog();
		}

		private void mnuBackupInMonth_Click(object sender, System.EventArgs e)
		{
			frmBackUpInMonth frm = new frmBackUpInMonth();
			frm.ShowDialog();
		}

		private void mnuRestoreInMonth_Click(object sender, System.EventArgs e)
		{
			frmRestoreInMonth frm = new frmRestoreInMonth();
			frm.ShowDialog();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if(CheckMdiClientDuplicates("FrmSendMail"))
            {
            FrmSendMail frm = new FrmSendMail();
			frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            }
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
            if (CheckMdiClientDuplicates("frmRestDay"))
            {
                frmRestDay frm = new frmRestDay();
                frm.MdiParent = this;
                frm.Show();
            }
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
            if (CheckMdiClientDuplicates("frmThamsohethong"))
            {
                frmThamsohethong frm = new frmThamsohethong();
                frm.MdiParent = this;
                frm.Show();
            }
		}

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            if (CheckMdiClientDuplicates("frmListTypeSalarys"))
            {
                frmListTypeSalarys frm = new frmListTypeSalarys();
                frm.MdiParent = this;
                frm.Show();

            }
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            if (CheckMdiClientDuplicates("frmRestDay"))
            {
                frmRestDay frm = new frmRestDay();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            frmInsuranceC47 frm = new frmInsuranceC47();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmInsuranceC46 frm = new frmInsuranceC46();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDSCapBHXH_Click(object sender, EventArgs e)
        {
            frmListEmployeeInsurance frm = new frmListEmployeeInsurance();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            frmListHospital frm = new frmListHospital();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmCompanyUserInfo frm = new frmCompanyUserInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            frmListDepartmentGroup frm = new frmListDepartmentGroup();
            frm.MdiParent = this;
            frm.Show();

        }
	}
}