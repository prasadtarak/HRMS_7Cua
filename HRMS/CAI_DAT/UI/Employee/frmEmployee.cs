//------------------------------------------------------------------------------------
//Class	    : frmEmployee
//Purpose	: Form quản lý các thông tin về hồ sơ nhân viên
//Note	    :		  
//Author	: chinhnd 7-2005
//Modify	: dungnt 17-6-2005
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AMS.TextBox;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Models;
using TextBox = System.Windows.Forms.TextBox;


namespace EVSoft.HRMS.UI.Employee
{
    /// <summary>
    /// Form quản lý các thông tin về hồ sơ nhân viên
    /// Thêm, sửa, xóa hồ sơ nhân viên
    /// 
    /// </summary>
    public class frmEmployee : Form
    {
        #region Windows Form generated code

        private ImageList imageList1;
        private Panel pnProfile;
        private Button btnClose;
        private Panel pnButtons;
        private ErrorProvider errorProvider1;
        private GroupBox grbProfessional;
        private Label lblNganhHoc;
        private TextBox txtDiscipline;
        private Label lblInformaticLevel;
        private Label lblProfessionalLevel;
        private Label lblEnglishLevel;
        private TextBox txtOtherCertificate;
        private Label lblOtherCertificate;
        private GroupBox grbEmployeeProfile;
        private DateTimePicker dtpDateOfBirth;
        private NumericTextBox txtPhone;
        private Label lblMarriageStatus;
        private TextBox txtResident;
        private Label lblResident;
        private Label lblBirthPlace;
        private TextBox txtBirthPlace;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnChoosePic;
        private PictureBox picEmployee;
        private TextBox txtCardID;
        private Label lblCardID;
        private TextBox txtAddress;
        private TextBox txtEmployeeName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblGender;
        private Label lblBirthday;
        private Label lblEmployeeName;
        private TabControl tabEmployeeProfile;
        private GroupBox grbHiringInfo;
        private CurrencyTextBox txtJobAllowance;
        private CurrencyTextBox txtPositionAllowance;
        private Label lblResponsibleAllowance;
        private Label lblHarmfulAllowance;
        private CurrencyTextBox txtLunchAllowance;
        private CurrencyTextBox txtBasicSalary;
        private Label lblLunchAllowance;
        private Label lblBasicSalary;
        private DateTimePicker dtpRecruitDate;
        private Label lblRecruitDate;
        private Label lblContract;
        private GroupBox groupBox2;
        private Label lblIdentityCard;
        private Label lblInsuranceID;
        private DateTimePicker dtpIssue;
        private Label lblIssue;
        private GroupBox groupBox4;
        private GroupBox grbAllowance;
        private GroupBox grbBasicSalary;
        private TextColumn cSTT;
        private TextColumn cModifiedDate;
        private TextColumn cDecisionNumber;
        private TextColumn cNote;
        private Table lvwDepartmentHistory;
        private TextColumn chSTT;
        private TextColumn chModifiedDate;
        private TextColumn chDecisionNumber;
        private TextColumn chNote;
        private Label lblReligious;
        private Label lblPeople;
        private TextBox txtSalaryNote;
        private Label lblSalaryNote;
        private Label lblSalaryDN;
        private TextBox txtPositionNote;
        private Label lblPositionNote;
        private Label lblPositionDN;
        private Label lblPositionName;
        private TextBox txtDepartmentNote;
        private Label lblDepartmentNote;
        private Label lblDepartmentDN;
        private Label lblDepartmentName;
        private LookupComboBox cboGender;
        private LookupComboBox cboMarriageStatus;
        private LookupComboBox cboPeople;
        private LookupComboBox cboReligious;
        private LookupComboBox cboProfessionalLevel;
        private LookupComboBox cboEnglishLevel;
        private LookupComboBox cboInformaticLevel;
        //		private MTGCComboBox cboContract;
        private MTGCComboBox cboDepartment;
        private MTGCComboBox cboPosition;
        private MTGCComboBox cbHospital;
        private LookupComboBox cboQualification;
        private Label lblQualification;
        private DateTimePicker dtpStartDate;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private TextBox txtRecordNum;
        private Table lvwSalaryHistory;
        private Button btnCancel;
        private TabPage tpGeneralInfo;
        private TabPage tpSalary;
        private TabPage tpDepartment;
        private TabPage tpOtherInfo;
        private Button btnChangeSalary;
        private Button btnChangePosition;
        private Button btnChangeDepartment;
        private Table lvwPositionHistory;
        private ColumnModel cmSalary;
        private TableModel tmSalary;
        private ColumnModel cmDepartment;
        private TableModel tmDepartment;
        private TableModel tmPosition;
        private ContextMenu ctxSalary;
        private ContextMenu ctxDepartment;
        private ContextMenu ctxPosition;
        private MenuItem mnuEditSalaryHistory;
        private MenuItem mnuDeleteSalaryHistory;
        private MenuItem mnuEditDepartmentHistory;
        private MenuItem mnuDeleteDepartmentHistory;
        private MenuItem mnuEditPositionHistory;
        private MenuItem mnuDeletePositionHistory;
        private TextColumn chDepartmentName;
        private ColumnModel cmPosition;
        private TextColumn cPositionName;
        private TextColumn cBasicSalary;
        private TextBox txtNote;
        private Label label1;
        private TextBox txtDistrict;
        private Label label2;
        private TextBox txtCommune;
        private Label label3;
        private TextBox txtProvince;
        private Label label4;
        private DateTimePicker dtpStartTrial;
        private TextBox txtSalaryDN;
        private TextBox txtDepartmentDN;
        private TextBox txtPositionDN;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDateInsurance;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.TextBox txtInsurenceID;
        private System.Windows.Forms.ComboBox cboNationality;
        private MTGCComboBox cboContract;
        private Button btnSave;
        private System.Windows.Forms.CheckBox cboInsuranceShelf;
        private System.Windows.Forms.Label lblSalaryChangedDay;
        private System.Windows.Forms.DateTimePicker dtpSalaryChangedDay;
        private Label label7;
        private MTGCComboBox mtgcComboFixSalary;
        private Label label9;
        private CheckBox label5;
        private CheckBox label8;
        private DateTimePicker dtpStopDate;
        private Label label10;
        private DateTimePicker dtpChangePosition;
        private Label label11;
        private DateTimePicker dtpDepartment;
        private Label label12;
        private Label label13;
        private CurrencyTextBox txtIntimateAllowance;
        private TextBox txtFamilyConditionNumber;
        private Label label15;
        private TextBox txtTaxID;
        private Label label14;
        private Label lblBarCode;
        private TextBox txtBarcode;
        private CurrencyTextBox txtTaskAllowance;
        private Label label17;
        private CurrencyTextBox txtJapaneseAllowance;
        private Label label16;
        private CheckBox chk_PCDL_CoDinhThang;
        private TextBox txtNoiCapCMND;
        private Label label18;
        private TextBox txtTemAddress;
        private Label label19;
        private DateTimePicker dtpStopWork;
        private CheckBox chkStopWork;
        //private ComboBox lcbHospital;
        private bool check = true;
        public bool checkkq
        {
            get { return check; }
            set { check = value; }
        }

        public frmEmployee()
        {
            InitializeComponent();
        }

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

        protected void ShowCurrentRecord()
        {
        }

        protected void dtEmployee_PositionChanged(object sender, EventArgs e)
        {
        }

        private IContainer components;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnProfile = new System.Windows.Forms.Panel();
            this.tabEmployeeProfile = new System.Windows.Forms.TabControl();
            this.tpGeneralInfo = new System.Windows.Forms.TabPage();
            this.grbProfessional = new System.Windows.Forms.GroupBox();
            this.cboInformaticLevel = new System.Windows.Forms.LookupComboBox();
            this.cboEnglishLevel = new System.Windows.Forms.LookupComboBox();
            this.cboQualification = new System.Windows.Forms.LookupComboBox();
            this.cboProfessionalLevel = new System.Windows.Forms.LookupComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblNganhHoc = new System.Windows.Forms.Label();
            this.txtDiscipline = new System.Windows.Forms.TextBox();
            this.lblInformaticLevel = new System.Windows.Forms.Label();
            this.lblProfessionalLevel = new System.Windows.Forms.Label();
            this.lblEnglishLevel = new System.Windows.Forms.Label();
            this.txtOtherCertificate = new System.Windows.Forms.TextBox();
            this.lblOtherCertificate = new System.Windows.Forms.Label();
            this.grbEmployeeProfile = new System.Windows.Forms.GroupBox();
            this.txtTemAddress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNoiCapCMND = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFamilyConditionNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboInsuranceShelf = new System.Windows.Forms.CheckBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtInsurenceID = new System.Windows.Forms.TextBox();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.dtpStartDateInsurance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCommune = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReligious = new System.Windows.Forms.LookupComboBox();
            this.cboPeople = new System.Windows.Forms.LookupComboBox();
            this.cboMarriageStatus = new System.Windows.Forms.LookupComboBox();
            this.cboGender = new System.Windows.Forms.LookupComboBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblReligious = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new AMS.TextBox.NumericTextBox();
            this.lblMarriageStatus = new System.Windows.Forms.Label();
            this.txtResident = new System.Windows.Forms.TextBox();
            this.lblResident = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.tpSalary = new System.Windows.Forms.TabPage();
            this.grbAllowance = new System.Windows.Forms.GroupBox();
            this.chk_PCDL_CoDinhThang = new System.Windows.Forms.CheckBox();
            this.txtTaskAllowance = new AMS.TextBox.CurrencyTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtJapaneseAllowance = new AMS.TextBox.CurrencyTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIntimateAllowance = new AMS.TextBox.CurrencyTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHarmfulAllowance = new System.Windows.Forms.Label();
            this.txtPositionAllowance = new AMS.TextBox.CurrencyTextBox();
            this.lblLunchAllowance = new System.Windows.Forms.Label();
            this.txtLunchAllowance = new AMS.TextBox.CurrencyTextBox();
            this.lblResponsibleAllowance = new System.Windows.Forms.Label();
            this.txtJobAllowance = new AMS.TextBox.CurrencyTextBox();
            this.grbBasicSalary = new System.Windows.Forms.GroupBox();
            this.lblSalaryChangedDay = new System.Windows.Forms.Label();
            this.txtSalaryDN = new System.Windows.Forms.TextBox();
            this.txtSalaryNote = new System.Windows.Forms.TextBox();
            this.lblSalaryNote = new System.Windows.Forms.Label();
            this.lblSalaryDN = new System.Windows.Forms.Label();
            this.txtBasicSalary = new AMS.TextBox.CurrencyTextBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.btnChangeSalary = new System.Windows.Forms.Button();
            this.lvwSalaryHistory = new XPTable.Models.Table();
            this.cmSalary = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.TextColumn();
            this.cBasicSalary = new XPTable.Models.TextColumn();
            this.cModifiedDate = new XPTable.Models.TextColumn();
            this.cDecisionNumber = new XPTable.Models.TextColumn();
            this.cNote = new XPTable.Models.TextColumn();
            this.ctxSalary = new System.Windows.Forms.ContextMenu();
            this.mnuEditSalaryHistory = new System.Windows.Forms.MenuItem();
            this.mnuDeleteSalaryHistory = new System.Windows.Forms.MenuItem();
            this.tmSalary = new XPTable.Models.TableModel();
            this.dtpSalaryChangedDay = new System.Windows.Forms.DateTimePicker();
            this.grbHiringInfo = new System.Windows.Forms.GroupBox();
            this.dtpStopWork = new System.Windows.Forms.DateTimePicker();
            this.chkStopWork = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.CheckBox();
            this.mtgcComboFixSalary = new MTGCComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboContract = new MTGCComboBox();
            this.dtpStartTrial = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRecruitDate = new System.Windows.Forms.DateTimePicker();
            this.lblRecruitDate = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.tpDepartment = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpChangePosition = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lvwPositionHistory = new XPTable.Models.Table();
            this.cmPosition = new XPTable.Models.ColumnModel();
            this.cPositionName = new XPTable.Models.TextColumn();
            this.ctxPosition = new System.Windows.Forms.ContextMenu();
            this.mnuEditPositionHistory = new System.Windows.Forms.MenuItem();
            this.mnuDeletePositionHistory = new System.Windows.Forms.MenuItem();
            this.tmPosition = new XPTable.Models.TableModel();
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.cboPosition = new MTGCComboBox();
            this.txtPositionNote = new System.Windows.Forms.TextBox();
            this.lblPositionNote = new System.Windows.Forms.Label();
            this.lblPositionDN = new System.Windows.Forms.Label();
            this.lblPositionName = new System.Windows.Forms.Label();
            this.txtPositionDN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDepartment = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepartmentDN = new System.Windows.Forms.TextBox();
            this.btnChangeDepartment = new System.Windows.Forms.Button();
            this.cboDepartment = new MTGCComboBox();
            this.txtDepartmentNote = new System.Windows.Forms.TextBox();
            this.lblDepartmentNote = new System.Windows.Forms.Label();
            this.lblDepartmentDN = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lvwDepartmentHistory = new XPTable.Models.Table();
            this.cmDepartment = new XPTable.Models.ColumnModel();
            this.chSTT = new XPTable.Models.TextColumn();
            this.chDepartmentName = new XPTable.Models.TextColumn();
            this.chModifiedDate = new XPTable.Models.TextColumn();
            this.chDecisionNumber = new XPTable.Models.TextColumn();
            this.chNote = new XPTable.Models.TextColumn();
            this.ctxDepartment = new System.Windows.Forms.ContextMenu();
            this.mnuEditDepartmentHistory = new System.Windows.Forms.MenuItem();
            this.mnuDeleteDepartmentHistory = new System.Windows.Forms.MenuItem();
            this.tmDepartment = new XPTable.Models.TableModel();
            this.tpOtherInfo = new System.Windows.Forms.TabPage();
            this.dtpStopDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHospital = new MTGCComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRecordNum = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnProfile.SuspendLayout();
            this.tabEmployeeProfile.SuspendLayout();
            this.tpGeneralInfo.SuspendLayout();
            this.grbProfessional.SuspendLayout();
            this.grbEmployeeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.tpSalary.SuspendLayout();
            this.grbAllowance.SuspendLayout();
            this.grbBasicSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwSalaryHistory)).BeginInit();
            this.grbHiringInfo.SuspendLayout();
            this.tpDepartment.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwPositionHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwDepartmentHistory)).BeginInit();
            this.tpOtherInfo.SuspendLayout();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.tabEmployeeProfile);
            this.pnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProfile.Location = new System.Drawing.Point(0, 0);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(644, 576);
            this.pnProfile.TabIndex = 3;
            // 
            // tabEmployeeProfile
            // 
            this.tabEmployeeProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEmployeeProfile.Controls.Add(this.tpGeneralInfo);
            this.tabEmployeeProfile.Controls.Add(this.tpSalary);
            this.tabEmployeeProfile.Controls.Add(this.tpDepartment);
            this.tabEmployeeProfile.Controls.Add(this.tpOtherInfo);
            this.tabEmployeeProfile.Location = new System.Drawing.Point(0, 0);
            this.tabEmployeeProfile.Name = "tabEmployeeProfile";
            this.tabEmployeeProfile.SelectedIndex = 0;
            this.tabEmployeeProfile.Size = new System.Drawing.Size(644, 578);
            this.tabEmployeeProfile.TabIndex = 0;
            // 
            // tpGeneralInfo
            // 
            this.tpGeneralInfo.Controls.Add(this.grbProfessional);
            this.tpGeneralInfo.Controls.Add(this.grbEmployeeProfile);
            this.tpGeneralInfo.Location = new System.Drawing.Point(4, 22);
            this.tpGeneralInfo.Name = "tpGeneralInfo";
            this.tpGeneralInfo.Size = new System.Drawing.Size(636, 552);
            this.tpGeneralInfo.TabIndex = 0;
            this.tpGeneralInfo.Text = "Thông tin chung";
            // 
            // grbProfessional
            // 
            this.grbProfessional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProfessional.Controls.Add(this.cboInformaticLevel);
            this.grbProfessional.Controls.Add(this.cboEnglishLevel);
            this.grbProfessional.Controls.Add(this.cboQualification);
            this.grbProfessional.Controls.Add(this.cboProfessionalLevel);
            this.grbProfessional.Controls.Add(this.lblQualification);
            this.grbProfessional.Controls.Add(this.lblNganhHoc);
            this.grbProfessional.Controls.Add(this.txtDiscipline);
            this.grbProfessional.Controls.Add(this.lblInformaticLevel);
            this.grbProfessional.Controls.Add(this.lblProfessionalLevel);
            this.grbProfessional.Controls.Add(this.lblEnglishLevel);
            this.grbProfessional.Controls.Add(this.txtOtherCertificate);
            this.grbProfessional.Controls.Add(this.lblOtherCertificate);
            this.grbProfessional.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbProfessional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbProfessional.Location = new System.Drawing.Point(5, 476);
            this.grbProfessional.Name = "grbProfessional";
            this.grbProfessional.Size = new System.Drawing.Size(628, 72);
            this.grbProfessional.TabIndex = 9;
            this.grbProfessional.TabStop = false;
            this.grbProfessional.Text = "Học vấn";
            // 
            // cboInformaticLevel
            // 
            this.cboInformaticLevel.AllowTypeAllSymbols = false;
            this.cboInformaticLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboInformaticLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInformaticLevel.ItemHeight = 13;
            this.cboInformaticLevel.Items.AddRange(new object[] {
            "Chưa biết",
            "Cơ bản",
            "Thành thạo"});
            this.cboInformaticLevel.Location = new System.Drawing.Point(540, 40);
            this.cboInformaticLevel.Name = "cboInformaticLevel";
            this.cboInformaticLevel.Size = new System.Drawing.Size(88, 21);
            this.cboInformaticLevel.TabIndex = 5;
            // 
            // cboEnglishLevel
            // 
            this.cboEnglishLevel.AllowTypeAllSymbols = false;
            this.cboEnglishLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEnglishLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnglishLevel.ItemHeight = 13;
            this.cboEnglishLevel.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Nhật",
            "Tiếng Trung"});
            this.cboEnglishLevel.Location = new System.Drawing.Point(540, 16);
            this.cboEnglishLevel.Name = "cboEnglishLevel";
            this.cboEnglishLevel.Size = new System.Drawing.Size(88, 21);
            this.cboEnglishLevel.TabIndex = 2;
            // 
            // cboQualification
            // 
            this.cboQualification.AllowTypeAllSymbols = false;
            this.cboQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualification.ItemHeight = 13;
            this.cboQualification.Items.AddRange(new object[] {
            "Không có",
            "Trung học cơ sở 9/12",
            "Tú tài (12/12)",
            "Trung cấp",
            "Cử nhân",
            "Kỹ sư",
            "Thạc sỹ",
            "Tiến sỹ"});
            this.cboQualification.Location = new System.Drawing.Point(312, 16);
            this.cboQualification.Name = "cboQualification";
            this.cboQualification.Size = new System.Drawing.Size(120, 21);
            this.cboQualification.TabIndex = 1;
            // 
            // cboProfessionalLevel
            // 
            this.cboProfessionalLevel.AllowTypeAllSymbols = false;
            this.cboProfessionalLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfessionalLevel.Items.AddRange(new object[] {
            "Phổ thông",
            "Trung cấp",
            "Cao đẳng",
            "Đại học",
            "Sau đại học"});
            this.cboProfessionalLevel.Location = new System.Drawing.Point(104, 16);
            this.cboProfessionalLevel.Name = "cboProfessionalLevel";
            this.cboProfessionalLevel.Size = new System.Drawing.Size(104, 21);
            this.cboProfessionalLevel.TabIndex = 0;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQualification.Location = new System.Drawing.Point(216, 16);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(96, 24);
            this.lblQualification.TabIndex = 48;
            this.lblQualification.Text = "Bằng cấp";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNganhHoc
            // 
            this.lblNganhHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNganhHoc.Location = new System.Drawing.Point(8, 40);
            this.lblNganhHoc.Name = "lblNganhHoc";
            this.lblNganhHoc.Size = new System.Drawing.Size(90, 24);
            this.lblNganhHoc.TabIndex = 46;
            this.lblNganhHoc.Text = "Ngành học";
            this.lblNganhHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscipline
            // 
            this.txtDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiscipline.Location = new System.Drawing.Point(104, 40);
            this.txtDiscipline.Name = "txtDiscipline";
            this.txtDiscipline.Size = new System.Drawing.Size(104, 20);
            this.txtDiscipline.TabIndex = 3;
            // 
            // lblInformaticLevel
            // 
            this.lblInformaticLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformaticLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInformaticLevel.Location = new System.Drawing.Point(484, 40);
            this.lblInformaticLevel.Name = "lblInformaticLevel";
            this.lblInformaticLevel.Size = new System.Drawing.Size(64, 24);
            this.lblInformaticLevel.TabIndex = 33;
            this.lblInformaticLevel.Text = "Tin học";
            this.lblInformaticLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfessionalLevel
            // 
            this.lblProfessionalLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProfessionalLevel.Location = new System.Drawing.Point(8, 16);
            this.lblProfessionalLevel.Name = "lblProfessionalLevel";
            this.lblProfessionalLevel.Size = new System.Drawing.Size(90, 24);
            this.lblProfessionalLevel.TabIndex = 29;
            this.lblProfessionalLevel.Text = "Trình độ văn hóa";
            this.lblProfessionalLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnglishLevel
            // 
            this.lblEnglishLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnglishLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnglishLevel.Location = new System.Drawing.Point(484, 16);
            this.lblEnglishLevel.Name = "lblEnglishLevel";
            this.lblEnglishLevel.Size = new System.Drawing.Size(64, 24);
            this.lblEnglishLevel.TabIndex = 31;
            this.lblEnglishLevel.Text = "Ngoại ngữ";
            this.lblEnglishLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOtherCertificate
            // 
            this.txtOtherCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOtherCertificate.Location = new System.Drawing.Point(312, 40);
            this.txtOtherCertificate.Name = "txtOtherCertificate";
            this.txtOtherCertificate.Size = new System.Drawing.Size(120, 20);
            this.txtOtherCertificate.TabIndex = 4;
            // 
            // lblOtherCertificate
            // 
            this.lblOtherCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOtherCertificate.Location = new System.Drawing.Point(216, 40);
            this.lblOtherCertificate.Name = "lblOtherCertificate";
            this.lblOtherCertificate.Size = new System.Drawing.Size(96, 24);
            this.lblOtherCertificate.TabIndex = 42;
            this.lblOtherCertificate.Text = "Chứng chỉ khác";
            this.lblOtherCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbEmployeeProfile
            // 
            this.grbEmployeeProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEmployeeProfile.Controls.Add(this.txtTemAddress);
            this.grbEmployeeProfile.Controls.Add(this.label19);
            this.grbEmployeeProfile.Controls.Add(this.txtNoiCapCMND);
            this.grbEmployeeProfile.Controls.Add(this.label18);
            this.grbEmployeeProfile.Controls.Add(this.txtFamilyConditionNumber);
            this.grbEmployeeProfile.Controls.Add(this.label15);
            this.grbEmployeeProfile.Controls.Add(this.txtTaxID);
            this.grbEmployeeProfile.Controls.Add(this.label14);
            this.grbEmployeeProfile.Controls.Add(this.cboInsuranceShelf);
            this.grbEmployeeProfile.Controls.Add(this.lblBarCode);
            this.grbEmployeeProfile.Controls.Add(this.cboNationality);
            this.grbEmployeeProfile.Controls.Add(this.txtBarcode);
            this.grbEmployeeProfile.Controls.Add(this.txtInsurenceID);
            this.grbEmployeeProfile.Controls.Add(this.txtIdentityCard);
            this.grbEmployeeProfile.Controls.Add(this.dtpStartDateInsurance);
            this.grbEmployeeProfile.Controls.Add(this.label6);
            this.grbEmployeeProfile.Controls.Add(this.lblNationality);
            this.grbEmployeeProfile.Controls.Add(this.txtProvince);
            this.grbEmployeeProfile.Controls.Add(this.label4);
            this.grbEmployeeProfile.Controls.Add(this.txtCommune);
            this.grbEmployeeProfile.Controls.Add(this.label3);
            this.grbEmployeeProfile.Controls.Add(this.txtDistrict);
            this.grbEmployeeProfile.Controls.Add(this.label2);
            this.grbEmployeeProfile.Controls.Add(this.cboReligious);
            this.grbEmployeeProfile.Controls.Add(this.cboPeople);
            this.grbEmployeeProfile.Controls.Add(this.cboMarriageStatus);
            this.grbEmployeeProfile.Controls.Add(this.cboGender);
            this.grbEmployeeProfile.Controls.Add(this.lblIdentityCard);
            this.grbEmployeeProfile.Controls.Add(this.lblInsuranceID);
            this.grbEmployeeProfile.Controls.Add(this.dtpIssue);
            this.grbEmployeeProfile.Controls.Add(this.lblIssue);
            this.grbEmployeeProfile.Controls.Add(this.lblReligious);
            this.grbEmployeeProfile.Controls.Add(this.lblPeople);
            this.grbEmployeeProfile.Controls.Add(this.dtpDateOfBirth);
            this.grbEmployeeProfile.Controls.Add(this.txtPhone);
            this.grbEmployeeProfile.Controls.Add(this.lblMarriageStatus);
            this.grbEmployeeProfile.Controls.Add(this.txtResident);
            this.grbEmployeeProfile.Controls.Add(this.lblResident);
            this.grbEmployeeProfile.Controls.Add(this.lblBirthPlace);
            this.grbEmployeeProfile.Controls.Add(this.txtBirthPlace);
            this.grbEmployeeProfile.Controls.Add(this.txtEmail);
            this.grbEmployeeProfile.Controls.Add(this.lblEmail);
            this.grbEmployeeProfile.Controls.Add(this.btnChoosePic);
            this.grbEmployeeProfile.Controls.Add(this.picEmployee);
            this.grbEmployeeProfile.Controls.Add(this.txtCardID);
            this.grbEmployeeProfile.Controls.Add(this.lblCardID);
            this.grbEmployeeProfile.Controls.Add(this.txtAddress);
            this.grbEmployeeProfile.Controls.Add(this.txtEmployeeName);
            this.grbEmployeeProfile.Controls.Add(this.lblPhone);
            this.grbEmployeeProfile.Controls.Add(this.lblAddress);
            this.grbEmployeeProfile.Controls.Add(this.lblGender);
            this.grbEmployeeProfile.Controls.Add(this.lblBirthday);
            this.grbEmployeeProfile.Controls.Add(this.lblEmployeeName);
            this.grbEmployeeProfile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbEmployeeProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbEmployeeProfile.Location = new System.Drawing.Point(8, 8);
            this.grbEmployeeProfile.Name = "grbEmployeeProfile";
            this.grbEmployeeProfile.Size = new System.Drawing.Size(620, 462);
            this.grbEmployeeProfile.TabIndex = 0;
            this.grbEmployeeProfile.TabStop = false;
            this.grbEmployeeProfile.Text = "Thông tin chung";
            // 
            // txtTemAddress
            // 
            this.txtTemAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTemAddress.Location = new System.Drawing.Point(104, 188);
            this.txtTemAddress.Name = "txtTemAddress";
            this.txtTemAddress.Size = new System.Drawing.Size(328, 20);
            this.txtTemAddress.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(8, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 24);
            this.label19.TabIndex = 93;
            this.label19.Text = "Địa chỉ tạm trú";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoiCapCMND
            // 
            this.txtNoiCapCMND.Location = new System.Drawing.Point(462, 324);
            this.txtNoiCapCMND.Multiline = true;
            this.txtNoiCapCMND.Name = "txtNoiCapCMND";
            this.txtNoiCapCMND.Size = new System.Drawing.Size(152, 20);
            this.txtNoiCapCMND.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(417, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 92;
            this.label18.Text = "Nơi cấp";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFamilyConditionNumber
            // 
            this.txtFamilyConditionNumber.Location = new System.Drawing.Point(328, 425);
            this.txtFamilyConditionNumber.Name = "txtFamilyConditionNumber";
            this.txtFamilyConditionNumber.Size = new System.Drawing.Size(92, 20);
            this.txtFamilyConditionNumber.TabIndex = 25;
            this.txtFamilyConditionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressInteger);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(238, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 24);
            this.label15.TabIndex = 91;
            this.label15.Text = "Số người GTGC";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(104, 425);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(120, 20);
            this.txtTaxID.TabIndex = 24;
            this.txtTaxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressInteger);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(10, 421);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 24);
            this.label14.TabIndex = 89;
            this.label14.Text = "Mã số thuế";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboInsuranceShelf
            // 
            this.cboInsuranceShelf.Location = new System.Drawing.Point(440, 387);
            this.cboInsuranceShelf.Name = "cboInsuranceShelf";
            this.cboInsuranceShelf.Size = new System.Drawing.Size(112, 24);
            this.cboInsuranceShelf.TabIndex = 23;
            this.cboInsuranceShelf.Text = "Tự đóng BHXH";
            // 
            // lblBarCode
            // 
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBarCode.Location = new System.Drawing.Point(443, 422);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(56, 24);
            this.lblBarCode.TabIndex = 46;
            this.lblBarCode.Text = "Mã vạch";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNationality
            // 
            this.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNationality.Items.AddRange(new object[] {
            "Việt Nam",
            "Nhật",
            "Hàn Quốc",
            "Trung Quốc",
            "Thái Lan",
            "Lào",
            "Các nước khác"});
            this.cboNationality.Location = new System.Drawing.Point(106, 255);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(120, 21);
            this.cboNationality.TabIndex = 12;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBarcode.Location = new System.Drawing.Point(500, 425);
            this.txtBarcode.MaxLength = 8;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(114, 20);
            this.txtBarcode.TabIndex = 26;
            this.txtBarcode.TabStop = false;
            // 
            // txtInsurenceID
            // 
            this.txtInsurenceID.Location = new System.Drawing.Point(104, 391);
            this.txtInsurenceID.Name = "txtInsurenceID";
            this.txtInsurenceID.Size = new System.Drawing.Size(120, 20);
            this.txtInsurenceID.TabIndex = 21;
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Location = new System.Drawing.Point(106, 324);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(120, 20);
            this.txtIdentityCard.TabIndex = 16;
            this.txtIdentityCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressInteger);
            // 
            // dtpStartDateInsurance
            // 
            this.dtpStartDateInsurance.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDateInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDateInsurance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDateInsurance.Location = new System.Drawing.Point(300, 391);
            this.dtpStartDateInsurance.Name = "dtpStartDateInsurance";
            this.dtpStartDateInsurance.Size = new System.Drawing.Size(120, 20);
            this.dtpStartDateInsurance.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(240, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày đóng BHXH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNationality
            // 
            this.lblNationality.Location = new System.Drawing.Point(10, 252);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(90, 24);
            this.lblNationality.TabIndex = 68;
            this.lblNationality.Text = "Quốc tịch";
            this.lblNationality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProvince.Location = new System.Drawing.Point(500, 222);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(114, 20);
            this.txtProvince.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(414, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tỉnh/thành phố";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommune
            // 
            this.txtCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCommune.Location = new System.Drawing.Point(104, 222);
            this.txtCommune.Name = "txtCommune";
            this.txtCommune.Size = new System.Drawing.Size(120, 20);
            this.txtCommune.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Phường/xã";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDistrict.Location = new System.Drawing.Point(300, 222);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(108, 20);
            this.txtDistrict.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(232, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Quận/huyện";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboReligious
            // 
            this.cboReligious.AllowTypeAllSymbols = false;
            this.cboReligious.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReligious.Items.AddRange(new object[] {
            "Không",
            "Thiên chúa giáo",
            "Khác.."});
            this.cboReligious.Location = new System.Drawing.Point(300, 359);
            this.cboReligious.Name = "cboReligious";
            this.cboReligious.Size = new System.Drawing.Size(120, 21);
            this.cboReligious.TabIndex = 20;
            // 
            // cboPeople
            // 
            this.cboPeople.AllowTypeAllSymbols = false;
            this.cboPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeople.Items.AddRange(new object[] {
            "Kinh",
            "Thái",
            "Tày",
            "Khác..."});
            this.cboPeople.Location = new System.Drawing.Point(104, 356);
            this.cboPeople.Name = "cboPeople";
            this.cboPeople.Size = new System.Drawing.Size(120, 21);
            this.cboPeople.TabIndex = 19;
            // 
            // cboMarriageStatus
            // 
            this.cboMarriageStatus.AllowTypeAllSymbols = false;
            this.cboMarriageStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarriageStatus.Items.AddRange(new object[] {
            "Độc thân",
            "Đã có gia đình"});
            this.cboMarriageStatus.Location = new System.Drawing.Point(300, 255);
            this.cboMarriageStatus.Name = "cboMarriageStatus";
            this.cboMarriageStatus.Size = new System.Drawing.Size(108, 21);
            this.cboMarriageStatus.TabIndex = 13;
            // 
            // cboGender
            // 
            this.cboGender.AllowTypeAllSymbols = false;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(328, 52);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(104, 21);
            this.cboGender.TabIndex = 3;
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdentityCard.Location = new System.Drawing.Point(10, 320);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(90, 24);
            this.lblIdentityCard.TabIndex = 68;
            this.lblIdentityCard.Text = "Số CMND";
            this.lblIdentityCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInsuranceID.Location = new System.Drawing.Point(10, 387);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(96, 24);
            this.lblInsuranceID.TabIndex = 69;
            this.lblInsuranceID.Text = "Số sổ BHXH";
            this.lblInsuranceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIssue
            // 
            this.dtpIssue.CustomFormat = "dd/MM/yyyy";
            this.dtpIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssue.Location = new System.Drawing.Point(300, 324);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(96, 20);
            this.dtpIssue.TabIndex = 17;
            this.dtpIssue.Validating += new System.ComponentModel.CancelEventHandler(this.dtpIssue_Validating);
            // 
            // lblIssue
            // 
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIssue.Location = new System.Drawing.Point(240, 320);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(60, 24);
            this.lblIssue.TabIndex = 70;
            this.lblIssue.Text = "Ngày cấp";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReligious
            // 
            this.lblReligious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblReligious.Location = new System.Drawing.Point(240, 356);
            this.lblReligious.Name = "lblReligious";
            this.lblReligious.Size = new System.Drawing.Size(62, 24);
            this.lblReligious.TabIndex = 62;
            this.lblReligious.Text = "Tôn giáo";
            this.lblReligious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPeople
            // 
            this.lblPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPeople.Location = new System.Drawing.Point(10, 353);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(96, 24);
            this.lblPeople.TabIndex = 60;
            this.lblPeople.Text = "Dân tộc";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(104, 53);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(104, 20);
            this.dtpDateOfBirth.TabIndex = 2;
            this.dtpDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateOfBirth_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.AllowNegative = false;
            this.txtPhone.DigitsInGroup = 0;
            this.txtPhone.Flags = 65536;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhone.Location = new System.Drawing.Point(106, 290);
            this.txtPhone.MaxDecimalPlaces = 4;
            this.txtPhone.MaxWholeDigits = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Prefix = "";
            this.txtPhone.RangeMax = 1.7976931348623157E+308;
            this.txtPhone.RangeMin = -1.7976931348623157E+308;
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // lblMarriageStatus
            // 
            this.lblMarriageStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMarriageStatus.Location = new System.Drawing.Point(240, 252);
            this.lblMarriageStatus.Name = "lblMarriageStatus";
            this.lblMarriageStatus.Size = new System.Drawing.Size(56, 24);
            this.lblMarriageStatus.TabIndex = 56;
            this.lblMarriageStatus.Text = "Hôn nhân";
            this.lblMarriageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResident
            // 
            this.txtResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtResident.Location = new System.Drawing.Point(104, 119);
            this.txtResident.Name = "txtResident";
            this.txtResident.Size = new System.Drawing.Size(328, 20);
            this.txtResident.TabIndex = 5;
            // 
            // lblResident
            // 
            this.lblResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResident.Location = new System.Drawing.Point(10, 115);
            this.lblResident.Name = "lblResident";
            this.lblResident.Size = new System.Drawing.Size(90, 24);
            this.lblResident.TabIndex = 52;
            this.lblResident.Text = "Hộ khẩu";
            this.lblResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBirthPlace.Location = new System.Drawing.Point(10, 82);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(90, 24);
            this.lblBirthPlace.TabIndex = 27;
            this.lblBirthPlace.Text = "Nơi sinh";
            this.lblBirthPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBirthPlace.Location = new System.Drawing.Point(104, 86);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(328, 20);
            this.txtBirthPlace.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(300, 290);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(240, 286);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 24);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChoosePic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChoosePic.Location = new System.Drawing.Point(440, 184);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(174, 23);
            this.btnChoosePic.TabIndex = 8;
            this.btnChoosePic.Text = "Chọn ảnh...";
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.picEmployee.Location = new System.Drawing.Point(441, 15);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(173, 167);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 13;
            this.picEmployee.TabStop = false;
            // 
            // txtCardID
            // 
            this.txtCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCardID.Location = new System.Drawing.Point(328, 20);
            this.txtCardID.MaxLength = 10;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(104, 20);
            this.txtCardID.TabIndex = 1;
            this.txtCardID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCardID_Validating);
            // 
            // lblCardID
            // 
            this.lblCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCardID.Location = new System.Drawing.Point(280, 16);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(48, 24);
            this.lblCardID.TabIndex = 10;
            this.lblCardID.Text = "Mã thẻ";
            this.lblCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.Location = new System.Drawing.Point(104, 154);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmployeeName.Location = new System.Drawing.Point(104, 20);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(160, 20);
            this.txtEmployeeName.TabIndex = 0;
            this.txtEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeName_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhone.Location = new System.Drawing.Point(10, 286);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Điện thoại";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.Location = new System.Drawing.Point(10, 148);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 26);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ thường trú";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGender.Location = new System.Drawing.Point(280, 49);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 24);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Giới tính";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthday
            // 
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBirthday.Location = new System.Drawing.Point(8, 49);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(90, 24);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Ngày sinh";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployeeName.Location = new System.Drawing.Point(8, 16);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(90, 24);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Tên nhân viên";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpSalary
            // 
            this.tpSalary.Controls.Add(this.grbAllowance);
            this.tpSalary.Controls.Add(this.grbBasicSalary);
            this.tpSalary.Controls.Add(this.grbHiringInfo);
            this.tpSalary.Location = new System.Drawing.Point(4, 22);
            this.tpSalary.Name = "tpSalary";
            this.tpSalary.Size = new System.Drawing.Size(636, 552);
            this.tpSalary.TabIndex = 1;
            this.tpSalary.Text = "Lương và tuyển dụng";
            // 
            // grbAllowance
            // 
            this.grbAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAllowance.Controls.Add(this.chk_PCDL_CoDinhThang);
            this.grbAllowance.Controls.Add(this.txtTaskAllowance);
            this.grbAllowance.Controls.Add(this.label17);
            this.grbAllowance.Controls.Add(this.txtJapaneseAllowance);
            this.grbAllowance.Controls.Add(this.label16);
            this.grbAllowance.Controls.Add(this.txtIntimateAllowance);
            this.grbAllowance.Controls.Add(this.label13);
            this.grbAllowance.Controls.Add(this.label1);
            this.grbAllowance.Controls.Add(this.lblHarmfulAllowance);
            this.grbAllowance.Controls.Add(this.txtPositionAllowance);
            this.grbAllowance.Controls.Add(this.lblLunchAllowance);
            this.grbAllowance.Controls.Add(this.txtLunchAllowance);
            this.grbAllowance.Controls.Add(this.lblResponsibleAllowance);
            this.grbAllowance.Controls.Add(this.txtJobAllowance);
            this.grbAllowance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbAllowance.Location = new System.Drawing.Point(8, 466);
            this.grbAllowance.Name = "grbAllowance";
            this.grbAllowance.Size = new System.Drawing.Size(620, 78);
            this.grbAllowance.TabIndex = 14;
            this.grbAllowance.TabStop = false;
            this.grbAllowance.Text = "Các loại phụ cấp";
            // 
            // chk_PCDL_CoDinhThang
            // 
            this.chk_PCDL_CoDinhThang.AutoSize = true;
            this.chk_PCDL_CoDinhThang.Location = new System.Drawing.Point(161, 49);
            this.chk_PCDL_CoDinhThang.Name = "chk_PCDL_CoDinhThang";
            this.chk_PCDL_CoDinhThang.Size = new System.Drawing.Size(63, 17);
            this.chk_PCDL_CoDinhThang.TabIndex = 4;
            this.chk_PCDL_CoDinhThang.Text = "Cố định";
            this.chk_PCDL_CoDinhThang.UseVisualStyleBackColor = true;
            // 
            // txtTaskAllowance
            // 
            this.txtTaskAllowance.AllowNegative = false;
            this.txtTaskAllowance.Flags = 73216;
            this.txtTaskAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaskAllowance.Location = new System.Drawing.Point(318, 47);
            this.txtTaskAllowance.MaxWholeDigits = 9;
            this.txtTaskAllowance.Name = "txtTaskAllowance";
            this.txtTaskAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtTaskAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtTaskAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtTaskAllowance.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(247, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 85;
            this.label17.Text = "PC công việc";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJapaneseAllowance
            // 
            this.txtJapaneseAllowance.AllowNegative = false;
            this.txtJapaneseAllowance.Flags = 73216;
            this.txtJapaneseAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtJapaneseAllowance.Location = new System.Drawing.Point(502, 47);
            this.txtJapaneseAllowance.MaxWholeDigits = 9;
            this.txtJapaneseAllowance.Name = "txtJapaneseAllowance";
            this.txtJapaneseAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtJapaneseAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtJapaneseAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtJapaneseAllowance.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(427, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 83;
            this.label16.Text = "PC tiếng Nhật";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIntimateAllowance
            // 
            this.txtIntimateAllowance.AllowNegative = false;
            this.txtIntimateAllowance.Flags = 73216;
            this.txtIntimateAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIntimateAllowance.Location = new System.Drawing.Point(65, 47);
            this.txtIntimateAllowance.MaxWholeDigits = 9;
            this.txtIntimateAllowance.Name = "txtIntimateAllowance";
            this.txtIntimateAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtIntimateAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtIntimateAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtIntimateAllowance.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(17, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "PC đi lại";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "/ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHarmfulAllowance
            // 
            this.lblHarmfulAllowance.AutoSize = true;
            this.lblHarmfulAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHarmfulAllowance.Location = new System.Drawing.Point(255, 26);
            this.lblHarmfulAllowance.Name = "lblHarmfulAllowance";
            this.lblHarmfulAllowance.Size = new System.Drawing.Size(63, 13);
            this.lblHarmfulAllowance.TabIndex = 77;
            this.lblHarmfulAllowance.Text = "PC chức vụ";
            this.lblHarmfulAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPositionAllowance
            // 
            this.txtPositionAllowance.AllowNegative = false;
            this.txtPositionAllowance.Flags = 73216;
            this.txtPositionAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPositionAllowance.Location = new System.Drawing.Point(319, 22);
            this.txtPositionAllowance.MaxWholeDigits = 9;
            this.txtPositionAllowance.Name = "txtPositionAllowance";
            this.txtPositionAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtPositionAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtPositionAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtPositionAllowance.TabIndex = 1;
            // 
            // lblLunchAllowance
            // 
            this.lblLunchAllowance.AutoSize = true;
            this.lblLunchAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLunchAllowance.Location = new System.Drawing.Point(6, 26);
            this.lblLunchAllowance.Name = "lblLunchAllowance";
            this.lblLunchAllowance.Size = new System.Drawing.Size(57, 13);
            this.lblLunchAllowance.TabIndex = 74;
            this.lblLunchAllowance.Text = "PC ăn trưa";
            this.lblLunchAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLunchAllowance
            // 
            this.txtLunchAllowance.AllowNegative = false;
            this.txtLunchAllowance.Flags = 73216;
            this.txtLunchAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLunchAllowance.Location = new System.Drawing.Point(65, 22);
            this.txtLunchAllowance.MaxWholeDigits = 9;
            this.txtLunchAllowance.Name = "txtLunchAllowance";
            this.txtLunchAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtLunchAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtLunchAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtLunchAllowance.TabIndex = 0;
            // 
            // lblResponsibleAllowance
            // 
            this.lblResponsibleAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsibleAllowance.AutoSize = true;
            this.lblResponsibleAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResponsibleAllowance.Location = new System.Drawing.Point(437, 26);
            this.lblResponsibleAllowance.Name = "lblResponsibleAllowance";
            this.lblResponsibleAllowance.Size = new System.Drawing.Size(83, 13);
            this.lblResponsibleAllowance.TabIndex = 78;
            this.lblResponsibleAllowance.Text = "PC nghề nghiệp";
            this.lblResponsibleAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJobAllowance
            // 
            this.txtJobAllowance.AllowNegative = false;
            this.txtJobAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobAllowance.Flags = 73216;
            this.txtJobAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtJobAllowance.Location = new System.Drawing.Point(522, 22);
            this.txtJobAllowance.MaxWholeDigits = 9;
            this.txtJobAllowance.Name = "txtJobAllowance";
            this.txtJobAllowance.RangeMax = 1.7976931348623157E+308;
            this.txtJobAllowance.RangeMin = -1.7976931348623157E+308;
            this.txtJobAllowance.Size = new System.Drawing.Size(90, 20);
            this.txtJobAllowance.TabIndex = 2;
            // 
            // grbBasicSalary
            // 
            this.grbBasicSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBasicSalary.Controls.Add(this.lblSalaryChangedDay);
            this.grbBasicSalary.Controls.Add(this.txtSalaryDN);
            this.grbBasicSalary.Controls.Add(this.txtSalaryNote);
            this.grbBasicSalary.Controls.Add(this.lblSalaryNote);
            this.grbBasicSalary.Controls.Add(this.lblSalaryDN);
            this.grbBasicSalary.Controls.Add(this.txtBasicSalary);
            this.grbBasicSalary.Controls.Add(this.lblBasicSalary);
            this.grbBasicSalary.Controls.Add(this.btnChangeSalary);
            this.grbBasicSalary.Controls.Add(this.lvwSalaryHistory);
            this.grbBasicSalary.Controls.Add(this.dtpSalaryChangedDay);
            this.grbBasicSalary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbBasicSalary.Location = new System.Drawing.Point(8, 123);
            this.grbBasicSalary.Name = "grbBasicSalary";
            this.grbBasicSalary.Size = new System.Drawing.Size(620, 337);
            this.grbBasicSalary.TabIndex = 13;
            this.grbBasicSalary.TabStop = false;
            this.grbBasicSalary.Text = "Diễn biến lương";
            // 
            // lblSalaryChangedDay
            // 
            this.lblSalaryChangedDay.Location = new System.Drawing.Point(339, 14);
            this.lblSalaryChangedDay.Name = "lblSalaryChangedDay";
            this.lblSalaryChangedDay.Size = new System.Drawing.Size(73, 23);
            this.lblSalaryChangedDay.TabIndex = 78;
            this.lblSalaryChangedDay.Text = "Ngày thay đổi";
            this.lblSalaryChangedDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalaryDN
            // 
            this.txtSalaryDN.Enabled = false;
            this.txtSalaryDN.Location = new System.Drawing.Point(264, 16);
            this.txtSalaryDN.Name = "txtSalaryDN";
            this.txtSalaryDN.Size = new System.Drawing.Size(72, 20);
            this.txtSalaryDN.TabIndex = 2;
            // 
            // txtSalaryNote
            // 
            this.txtSalaryNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalaryNote.Enabled = false;
            this.txtSalaryNote.Location = new System.Drawing.Point(88, 40);
            this.txtSalaryNote.Name = "txtSalaryNote";
            this.txtSalaryNote.Size = new System.Drawing.Size(428, 20);
            this.txtSalaryNote.TabIndex = 4;
            // 
            // lblSalaryNote
            // 
            this.lblSalaryNote.Location = new System.Drawing.Point(8, 40);
            this.lblSalaryNote.Name = "lblSalaryNote";
            this.lblSalaryNote.Size = new System.Drawing.Size(80, 23);
            this.lblSalaryNote.TabIndex = 76;
            this.lblSalaryNote.Text = "Ghi chú";
            this.lblSalaryNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalaryDN
            // 
            this.lblSalaryDN.Location = new System.Drawing.Point(184, 16);
            this.lblSalaryDN.Name = "lblSalaryDN";
            this.lblSalaryDN.Size = new System.Drawing.Size(80, 23);
            this.lblSalaryDN.TabIndex = 74;
            this.lblSalaryDN.Text = "Quyết định số";
            this.lblSalaryDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.AllowNegative = false;
            this.txtBasicSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasicSalary.Flags = 73216;
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBasicSalary.Location = new System.Drawing.Point(88, 16);
            this.txtBasicSalary.MaxWholeDigits = 10;
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.RangeMax = 1.7976931348623157E+308;
            this.txtBasicSalary.RangeMin = -1.7976931348623157E+308;
            this.txtBasicSalary.Size = new System.Drawing.Size(108, 20);
            this.txtBasicSalary.TabIndex = 0;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBasicSalary.Location = new System.Drawing.Point(8, 16);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(80, 24);
            this.lblBasicSalary.TabIndex = 73;
            this.lblBasicSalary.Text = "Lương cơ bản";
            this.lblBasicSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeSalary
            // 
            this.btnChangeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSalary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeSalary.Location = new System.Drawing.Point(524, 24);
            this.btnChangeSalary.Name = "btnChangeSalary";
            this.btnChangeSalary.Size = new System.Drawing.Size(88, 24);
            this.btnChangeSalary.TabIndex = 1;
            this.btnChangeSalary.Text = "Mức lương mới";
            this.btnChangeSalary.Click += new System.EventHandler(this.btnChangeSalary_Click);
            this.btnChangeSalary.EnabledChanged += new System.EventHandler(this.btnChangeSalary_EnabledChanged);
            // 
            // lvwSalaryHistory
            // 
            this.lvwSalaryHistory.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwSalaryHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSalaryHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwSalaryHistory.ColumnModel = this.cmSalary;
            this.lvwSalaryHistory.ContextMenu = this.ctxSalary;
            this.lvwSalaryHistory.EnableToolTips = true;
            this.lvwSalaryHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwSalaryHistory.FullRowSelect = true;
            this.lvwSalaryHistory.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwSalaryHistory.GridLines = XPTable.Models.GridLines.Both;
            this.lvwSalaryHistory.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwSalaryHistory.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwSalaryHistory.Location = new System.Drawing.Point(8, 64);
            this.lvwSalaryHistory.Name = "lvwSalaryHistory";
            this.lvwSalaryHistory.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwSalaryHistory.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwSalaryHistory.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwSalaryHistory.Size = new System.Drawing.Size(604, 267);
            this.lvwSalaryHistory.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwSalaryHistory.TabIndex = 11;
            this.lvwSalaryHistory.TableModel = this.tmSalary;
            this.lvwSalaryHistory.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwSalaryHistory.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            // 
            // cmSalary
            // 
            this.cmSalary.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cBasicSalary,
            this.cModifiedDate,
            this.cDecisionNumber,
            this.cNote});
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Text = "STT";
            this.cSTT.Width = 50;
            // 
            // cBasicSalary
            // 
            this.cBasicSalary.Editable = false;
            this.cBasicSalary.Text = "Lương cơ bản";
            this.cBasicSalary.Width = 120;
            // 
            // cModifiedDate
            // 
            this.cModifiedDate.Editable = false;
            this.cModifiedDate.Text = "Ngày thay đổi";
            this.cModifiedDate.Width = 95;
            // 
            // cDecisionNumber
            // 
            this.cDecisionNumber.Editable = false;
            this.cDecisionNumber.Text = "Quyết định số";
            this.cDecisionNumber.Width = 100;
            // 
            // cNote
            // 
            this.cNote.Editable = false;
            this.cNote.Text = "Ghi chú";
            this.cNote.Width = 170;
            // 
            // ctxSalary
            // 
            this.ctxSalary.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditSalaryHistory,
            this.mnuDeleteSalaryHistory});
            // 
            // mnuEditSalaryHistory
            // 
            this.mnuEditSalaryHistory.Index = 0;
            this.mnuEditSalaryHistory.Text = "&Sửa diễn biến lương...";
            this.mnuEditSalaryHistory.Click += new System.EventHandler(this.mnuEditSalaryHistory_Click);
            // 
            // mnuDeleteSalaryHistory
            // 
            this.mnuDeleteSalaryHistory.Index = 1;
            this.mnuDeleteSalaryHistory.Text = "&Xóa diễn biến lương...";
            this.mnuDeleteSalaryHistory.Click += new System.EventHandler(this.mnuDeleteSalaryHistory_Click);
            // 
            // dtpSalaryChangedDay
            // 
            this.dtpSalaryChangedDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSalaryChangedDay.CustomFormat = "dd/MM/yyyy";
            this.dtpSalaryChangedDay.Enabled = false;
            this.dtpSalaryChangedDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpSalaryChangedDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryChangedDay.Location = new System.Drawing.Point(412, 77);
            this.dtpSalaryChangedDay.Name = "dtpSalaryChangedDay";
            this.dtpSalaryChangedDay.Size = new System.Drawing.Size(88, 20);
            this.dtpSalaryChangedDay.TabIndex = 3;
            // 
            // grbHiringInfo
            // 
            this.grbHiringInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbHiringInfo.Controls.Add(this.dtpStopWork);
            this.grbHiringInfo.Controls.Add(this.chkStopWork);
            this.grbHiringInfo.Controls.Add(this.label8);
            this.grbHiringInfo.Controls.Add(this.label5);
            this.grbHiringInfo.Controls.Add(this.mtgcComboFixSalary);
            this.grbHiringInfo.Controls.Add(this.label9);
            this.grbHiringInfo.Controls.Add(this.cboContract);
            this.grbHiringInfo.Controls.Add(this.dtpStartTrial);
            this.grbHiringInfo.Controls.Add(this.dtpStartDate);
            this.grbHiringInfo.Controls.Add(this.dtpRecruitDate);
            this.grbHiringInfo.Controls.Add(this.lblRecruitDate);
            this.grbHiringInfo.Controls.Add(this.lblContract);
            this.grbHiringInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbHiringInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbHiringInfo.Location = new System.Drawing.Point(8, 8);
            this.grbHiringInfo.Name = "grbHiringInfo";
            this.grbHiringInfo.Size = new System.Drawing.Size(620, 109);
            this.grbHiringInfo.TabIndex = 11;
            this.grbHiringInfo.TabStop = false;
            this.grbHiringInfo.Text = "Thông tin tuyển dụng";
            // 
            // dtpStopWork
            // 
            this.dtpStopWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStopWork.CustomFormat = "dd/MM/yyyy";
            this.dtpStopWork.Enabled = false;
            this.dtpStopWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStopWork.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStopWork.Location = new System.Drawing.Point(448, 46);
            this.dtpStopWork.Name = "dtpStopWork";
            this.dtpStopWork.Size = new System.Drawing.Size(104, 20);
            this.dtpStopWork.TabIndex = 6;
            // 
            // chkStopWork
            // 
            this.chkStopWork.AutoSize = true;
            this.chkStopWork.Location = new System.Drawing.Point(333, 49);
            this.chkStopWork.Name = "chkStopWork";
            this.chkStopWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStopWork.Size = new System.Drawing.Size(94, 17);
            this.chkStopWork.TabIndex = 5;
            this.chkStopWork.Text = "Ngày thôi việc";
            this.chkStopWork.UseVisualStyleBackColor = true;
            this.chkStopWork.CheckedChanged += new System.EventHandler(this.chkStopWork_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày làm chính thức";
            this.label8.UseVisualStyleBackColor = true;
            this.label8.CheckedChanged += new System.EventHandler(this.label8_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.errorProvider1.SetIconAlignment(this.label5, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label5.Location = new System.Drawing.Point(333, 23);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bắt đầu thử việc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.UseVisualStyleBackColor = true;
            this.label5.CheckedChanged += new System.EventHandler(this.label5_CheckedChanged);
            // 
            // mtgcComboFixSalary
            // 
            this.mtgcComboFixSalary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mtgcComboFixSalary.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.mtgcComboFixSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboFixSalary.ColumnNum = 2;
            this.mtgcComboFixSalary.ColumnWidth = "0;220";
            this.mtgcComboFixSalary.DisplayMember = "Text";
            this.mtgcComboFixSalary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboFixSalary.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboFixSalary.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboFixSalary.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.mtgcComboFixSalary.DropDownWidth = 120;
            this.mtgcComboFixSalary.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboFixSalary.GridLineHorizontal = true;
            this.mtgcComboFixSalary.GridLineVertical = false;
            this.mtgcComboFixSalary.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboFixSalary.Location = new System.Drawing.Point(448, 72);
            this.mtgcComboFixSalary.ManagingFastMouseMoving = true;
            this.mtgcComboFixSalary.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboFixSalary.Name = "mtgcComboFixSalary";
            this.mtgcComboFixSalary.Size = new System.Drawing.Size(104, 21);
            this.mtgcComboFixSalary.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hợp đồng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboContract
            // 
            this.cboContract.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboContract.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboContract.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboContract.ColumnNum = 2;
            this.cboContract.ColumnWidth = "0;220";
            this.cboContract.DisplayMember = "Text";
            this.cboContract.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboContract.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboContract.DropDownForeColor = System.Drawing.Color.Black;
            this.cboContract.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboContract.DropDownWidth = 120;
            this.cboContract.GridLineColor = System.Drawing.Color.LightGray;
            this.cboContract.GridLineHorizontal = true;
            this.cboContract.GridLineVertical = false;
            this.cboContract.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboContract.Location = new System.Drawing.Point(137, 72);
            this.cboContract.ManagingFastMouseMoving = true;
            this.cboContract.ManagingFastMouseMovingInterval = 30;
            this.cboContract.Name = "cboContract";
            this.cboContract.Size = new System.Drawing.Size(104, 21);
            this.cboContract.TabIndex = 7;
            this.cboContract.SelectedIndexChanged += new System.EventHandler(this.cboContract_SelectedIndexChanged);
            // 
            // dtpStartTrial
            // 
            this.dtpStartTrial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpStartTrial.CustomFormat = "dd/MM/yyyy";
            this.dtpStartTrial.Enabled = false;
            this.dtpStartTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartTrial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTrial.Location = new System.Drawing.Point(448, 20);
            this.dtpStartTrial.Name = "dtpStartTrial";
            this.dtpStartTrial.Size = new System.Drawing.Size(104, 20);
            this.dtpStartTrial.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(137, 46);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(104, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpRecruitDate
            // 
            this.dtpRecruitDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpRecruitDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRecruitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpRecruitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRecruitDate.Location = new System.Drawing.Point(137, 20);
            this.dtpRecruitDate.Name = "dtpRecruitDate";
            this.dtpRecruitDate.Size = new System.Drawing.Size(104, 20);
            this.dtpRecruitDate.TabIndex = 0;
            // 
            // lblRecruitDate
            // 
            this.lblRecruitDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecruitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRecruitDate.Location = new System.Drawing.Point(6, 16);
            this.lblRecruitDate.Name = "lblRecruitDate";
            this.lblRecruitDate.Size = new System.Drawing.Size(134, 24);
            this.lblRecruitDate.TabIndex = 38;
            this.lblRecruitDate.Text = "Ngày tuyển";
            this.lblRecruitDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContract
            // 
            this.lblContract.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblContract.Location = new System.Drawing.Point(333, 69);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(65, 24);
            this.lblContract.TabIndex = 40;
            this.lblContract.Text = "Kiểu lương";
            this.lblContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpDepartment
            // 
            this.tpDepartment.Controls.Add(this.groupBox4);
            this.tpDepartment.Controls.Add(this.groupBox2);
            this.tpDepartment.Location = new System.Drawing.Point(4, 22);
            this.tpDepartment.Name = "tpDepartment";
            this.tpDepartment.Size = new System.Drawing.Size(636, 552);
            this.tpDepartment.TabIndex = 2;
            this.tpDepartment.Text = "Bộ phận-chức vụ";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dtpChangePosition);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lvwPositionHistory);
            this.groupBox4.Controls.Add(this.btnChangePosition);
            this.groupBox4.Controls.Add(this.cboPosition);
            this.groupBox4.Controls.Add(this.txtPositionNote);
            this.groupBox4.Controls.Add(this.lblPositionNote);
            this.groupBox4.Controls.Add(this.lblPositionDN);
            this.groupBox4.Controls.Add(this.lblPositionName);
            this.groupBox4.Controls.Add(this.txtPositionDN);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(8, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(628, 168);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thay đổi chức vụ";
            // 
            // dtpChangePosition
            // 
            this.dtpChangePosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpChangePosition.CustomFormat = "dd/MM/yyyy";
            this.dtpChangePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpChangePosition.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChangePosition.Location = new System.Drawing.Point(408, 39);
            this.dtpChangePosition.Name = "dtpChangePosition";
            this.dtpChangePosition.Size = new System.Drawing.Size(96, 20);
            this.dtpChangePosition.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(312, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 77;
            this.label11.Text = "Ngày thay đổi";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwPositionHistory
            // 
            this.lvwPositionHistory.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwPositionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPositionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwPositionHistory.ColumnModel = this.cmPosition;
            this.lvwPositionHistory.ContextMenu = this.ctxPosition;
            this.lvwPositionHistory.EnableToolTips = true;
            this.lvwPositionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPositionHistory.FullRowSelect = true;
            this.lvwPositionHistory.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwPositionHistory.GridLines = XPTable.Models.GridLines.Both;
            this.lvwPositionHistory.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwPositionHistory.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwPositionHistory.Location = new System.Drawing.Point(8, 64);
            this.lvwPositionHistory.Name = "lvwPositionHistory";
            this.lvwPositionHistory.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwPositionHistory.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPositionHistory.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwPositionHistory.Size = new System.Drawing.Size(612, 96);
            this.lvwPositionHistory.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwPositionHistory.TabIndex = 76;
            this.lvwPositionHistory.TableModel = this.tmPosition;
            this.lvwPositionHistory.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwPositionHistory.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            // 
            // cmPosition
            // 
            this.cmPosition.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cPositionName,
            this.cModifiedDate,
            this.cDecisionNumber,
            this.cNote});
            // 
            // cPositionName
            // 
            this.cPositionName.Text = "Tên chức vụ";
            this.cPositionName.Width = 140;
            // 
            // ctxPosition
            // 
            this.ctxPosition.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditPositionHistory,
            this.mnuDeletePositionHistory});
            // 
            // mnuEditPositionHistory
            // 
            this.mnuEditPositionHistory.Index = 0;
            this.mnuEditPositionHistory.Text = "&Sửa...";
            this.mnuEditPositionHistory.Click += new System.EventHandler(this.mnuEditPositionHistory_Click);
            // 
            // mnuDeletePositionHistory
            // 
            this.mnuDeletePositionHistory.Index = 1;
            this.mnuDeletePositionHistory.Text = "&Xóa...";
            this.mnuDeletePositionHistory.Click += new System.EventHandler(this.mnuDeletePositionHistory_Click);
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangePosition.Location = new System.Drawing.Point(524, 24);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(96, 24);
            this.btnChangePosition.TabIndex = 39;
            this.btnChangePosition.Text = "Chuyển chức vụ";
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            this.btnChangePosition.EnabledChanged += new System.EventHandler(this.btnChangePosition_EnabledChanged);
            // 
            // cboPosition
            // 
            this.cboPosition.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboPosition.ColumnNum = 2;
            this.cboPosition.ColumnWidth = "0;220";
            this.cboPosition.DisplayMember = "Text";
            this.cboPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPosition.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboPosition.DropDownForeColor = System.Drawing.Color.Black;
            this.cboPosition.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboPosition.DropDownWidth = 240;
            this.cboPosition.GridLineColor = System.Drawing.Color.LightGray;
            this.cboPosition.GridLineHorizontal = true;
            this.cboPosition.GridLineVertical = false;
            this.cboPosition.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboPosition.Location = new System.Drawing.Point(96, 16);
            this.cboPosition.ManagingFastMouseMoving = true;
            this.cboPosition.ManagingFastMouseMovingInterval = 30;
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(200, 21);
            this.cboPosition.TabIndex = 35;
            // 
            // txtPositionNote
            // 
            this.txtPositionNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPositionNote.Enabled = false;
            this.txtPositionNote.Location = new System.Drawing.Point(96, 40);
            this.txtPositionNote.Name = "txtPositionNote";
            this.txtPositionNote.Size = new System.Drawing.Size(212, 20);
            this.txtPositionNote.TabIndex = 37;
            // 
            // lblPositionNote
            // 
            this.lblPositionNote.Location = new System.Drawing.Point(8, 40);
            this.lblPositionNote.Name = "lblPositionNote";
            this.lblPositionNote.Size = new System.Drawing.Size(88, 23);
            this.lblPositionNote.TabIndex = 72;
            this.lblPositionNote.Text = "Ghi chú";
            this.lblPositionNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPositionDN
            // 
            this.lblPositionDN.Location = new System.Drawing.Point(312, 16);
            this.lblPositionDN.Name = "lblPositionDN";
            this.lblPositionDN.Size = new System.Drawing.Size(80, 23);
            this.lblPositionDN.TabIndex = 70;
            this.lblPositionDN.Text = "Quyết định số";
            this.lblPositionDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPositionName
            // 
            this.lblPositionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPositionName.Location = new System.Drawing.Point(8, 16);
            this.lblPositionName.Name = "lblPositionName";
            this.lblPositionName.Size = new System.Drawing.Size(88, 24);
            this.lblPositionName.TabIndex = 66;
            this.lblPositionName.Text = "Chức vụ";
            this.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPositionDN
            // 
            this.txtPositionDN.Enabled = false;
            this.txtPositionDN.Location = new System.Drawing.Point(408, 16);
            this.txtPositionDN.Name = "txtPositionDN";
            this.txtPositionDN.Size = new System.Drawing.Size(96, 20);
            this.txtPositionDN.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpDepartment);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDepartmentDN);
            this.groupBox2.Controls.Add(this.btnChangeDepartment);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.txtDepartmentNote);
            this.groupBox2.Controls.Add(this.lblDepartmentNote);
            this.groupBox2.Controls.Add(this.lblDepartmentDN);
            this.groupBox2.Controls.Add(this.lblDepartmentName);
            this.groupBox2.Controls.Add(this.lvwDepartmentHistory);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 364);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển đổi bộ phận";
            // 
            // dtpDepartment
            // 
            this.dtpDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDepartment.CustomFormat = "dd/MM/yyyy";
            this.dtpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDepartment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartment.Location = new System.Drawing.Point(408, 17);
            this.dtpDepartment.Name = "dtpDepartment";
            this.dtpDepartment.Size = new System.Drawing.Size(96, 20);
            this.dtpDepartment.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(322, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 80;
            this.label12.Text = "Ngày chuyển";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepartmentDN
            // 
            this.txtDepartmentDN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDepartmentDN.Enabled = false;
            this.txtDepartmentDN.Location = new System.Drawing.Point(408, 40);
            this.txtDepartmentDN.Name = "txtDepartmentDN";
            this.txtDepartmentDN.Size = new System.Drawing.Size(96, 20);
            this.txtDepartmentDN.TabIndex = 33;
            // 
            // btnChangeDepartment
            // 
            this.btnChangeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeDepartment.Location = new System.Drawing.Point(524, 24);
            this.btnChangeDepartment.Name = "btnChangeDepartment";
            this.btnChangeDepartment.Size = new System.Drawing.Size(96, 24);
            this.btnChangeDepartment.TabIndex = 38;
            this.btnChangeDepartment.Text = "Chuyển công tác";
            this.btnChangeDepartment.Click += new System.EventHandler(this.btnChangeDepartment_Click);
            this.btnChangeDepartment.EnabledChanged += new System.EventHandler(this.btnChangeDepartment_EnabledChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboDepartment.ColumnNum = 2;
            this.cboDepartment.ColumnWidth = "0;220";
            this.cboDepartment.DisplayMember = "Text";
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDepartment.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboDepartment.DropDownForeColor = System.Drawing.Color.Black;
            this.cboDepartment.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboDepartment.DropDownWidth = 240;
            this.cboDepartment.GridLineColor = System.Drawing.Color.LightGray;
            this.cboDepartment.GridLineHorizontal = true;
            this.cboDepartment.GridLineVertical = false;
            this.cboDepartment.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboDepartment.Location = new System.Drawing.Point(88, 16);
            this.cboDepartment.ManagingFastMouseMoving = true;
            this.cboDepartment.ManagingFastMouseMovingInterval = 30;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(192, 21);
            this.cboDepartment.TabIndex = 32;
            // 
            // txtDepartmentNote
            // 
            this.txtDepartmentNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartmentNote.Enabled = false;
            this.txtDepartmentNote.Location = new System.Drawing.Point(88, 40);
            this.txtDepartmentNote.Name = "txtDepartmentNote";
            this.txtDepartmentNote.Size = new System.Drawing.Size(204, 20);
            this.txtDepartmentNote.TabIndex = 34;
            // 
            // lblDepartmentNote
            // 
            this.lblDepartmentNote.Location = new System.Drawing.Point(8, 40);
            this.lblDepartmentNote.Name = "lblDepartmentNote";
            this.lblDepartmentNote.Size = new System.Drawing.Size(80, 23);
            this.lblDepartmentNote.TabIndex = 68;
            this.lblDepartmentNote.Text = "Ghi chú";
            this.lblDepartmentNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartmentDN
            // 
            this.lblDepartmentDN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentDN.Location = new System.Drawing.Point(322, 37);
            this.lblDepartmentDN.Name = "lblDepartmentDN";
            this.lblDepartmentDN.Size = new System.Drawing.Size(80, 23);
            this.lblDepartmentDN.TabIndex = 66;
            this.lblDepartmentDN.Text = "Quyết định số";
            this.lblDepartmentDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartmentName.Location = new System.Drawing.Point(8, 16);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(80, 24);
            this.lblDepartmentName.TabIndex = 65;
            this.lblDepartmentName.Text = "Bộ phận";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwDepartmentHistory
            // 
            this.lvwDepartmentHistory.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwDepartmentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDepartmentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwDepartmentHistory.ColumnModel = this.cmDepartment;
            this.lvwDepartmentHistory.ContextMenu = this.ctxDepartment;
            this.lvwDepartmentHistory.EnableToolTips = true;
            this.lvwDepartmentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwDepartmentHistory.FullRowSelect = true;
            this.lvwDepartmentHistory.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwDepartmentHistory.GridLines = XPTable.Models.GridLines.Both;
            this.lvwDepartmentHistory.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwDepartmentHistory.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwDepartmentHistory.Location = new System.Drawing.Point(8, 64);
            this.lvwDepartmentHistory.Name = "lvwDepartmentHistory";
            this.lvwDepartmentHistory.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwDepartmentHistory.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwDepartmentHistory.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwDepartmentHistory.Size = new System.Drawing.Size(612, 292);
            this.lvwDepartmentHistory.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwDepartmentHistory.TabIndex = 12;
            this.lvwDepartmentHistory.TableModel = this.tmDepartment;
            this.lvwDepartmentHistory.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwDepartmentHistory.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            // 
            // cmDepartment
            // 
            this.cmDepartment.Columns.AddRange(new XPTable.Models.Column[] {
            this.chSTT,
            this.chDepartmentName,
            this.chModifiedDate,
            this.chDecisionNumber,
            this.chNote});
            // 
            // chSTT
            // 
            this.chSTT.Editable = false;
            this.chSTT.Text = "STT";
            this.chSTT.Width = 50;
            // 
            // chDepartmentName
            // 
            this.chDepartmentName.Editable = false;
            this.chDepartmentName.Text = "Tên bộ phận";
            this.chDepartmentName.Width = 140;
            // 
            // chModifiedDate
            // 
            this.chModifiedDate.Editable = false;
            this.chModifiedDate.Text = "Ngày thay đổi";
            this.chModifiedDate.Width = 95;
            // 
            // chDecisionNumber
            // 
            this.chDecisionNumber.Editable = false;
            this.chDecisionNumber.Text = "Quyết định số";
            this.chDecisionNumber.Width = 100;
            // 
            // chNote
            // 
            this.chNote.Editable = false;
            this.chNote.Text = "Ghi chú";
            this.chNote.Width = 170;
            // 
            // ctxDepartment
            // 
            this.ctxDepartment.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditDepartmentHistory,
            this.mnuDeleteDepartmentHistory});
            // 
            // mnuEditDepartmentHistory
            // 
            this.mnuEditDepartmentHistory.Index = 0;
            this.mnuEditDepartmentHistory.Text = "&Sửa...";
            this.mnuEditDepartmentHistory.Click += new System.EventHandler(this.mnuEditDepartmentHistory_Click);
            // 
            // mnuDeleteDepartmentHistory
            // 
            this.mnuDeleteDepartmentHistory.Index = 1;
            this.mnuDeleteDepartmentHistory.Text = "&Xóa...";
            this.mnuDeleteDepartmentHistory.Click += new System.EventHandler(this.mnuDeleteDepartmentHistory_Click);
            // 
            // tpOtherInfo
            // 
            this.tpOtherInfo.Controls.Add(this.dtpStopDate);
            this.tpOtherInfo.Controls.Add(this.label10);
            this.tpOtherInfo.Controls.Add(this.cbHospital);
            this.tpOtherInfo.Controls.Add(this.label7);
            this.tpOtherInfo.Controls.Add(this.txtNote);
            this.tpOtherInfo.Location = new System.Drawing.Point(4, 22);
            this.tpOtherInfo.Name = "tpOtherInfo";
            this.tpOtherInfo.Size = new System.Drawing.Size(636, 552);
            this.tpOtherInfo.TabIndex = 3;
            this.tpOtherInfo.Text = "Thông tin khác";
            // 
            // dtpStopDate
            // 
            this.dtpStopDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStopDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStopDate.Location = new System.Drawing.Point(220, 36);
            this.dtpStopDate.Name = "dtpStopDate";
            this.dtpStopDate.Size = new System.Drawing.Size(104, 20);
            this.dtpStopDate.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ngày thôi việc";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHospital
            // 
            this.cbHospital.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbHospital.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbHospital.ColumnNum = 2;
            this.cbHospital.ColumnWidth = "0;220";
            this.cbHospital.DisplayMember = "Text";
            this.cbHospital.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHospital.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbHospital.DropDownForeColor = System.Drawing.Color.Black;
            this.cbHospital.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cbHospital.DropDownWidth = 240;
            this.cbHospital.GridLineColor = System.Drawing.Color.LightGray;
            this.cbHospital.GridLineHorizontal = true;
            this.cbHospital.GridLineVertical = false;
            this.cbHospital.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbHospital.Location = new System.Drawing.Point(220, 10);
            this.cbHospital.ManagingFastMouseMoving = true;
            this.cbHospital.ManagingFastMouseMovingInterval = 30;
            this.cbHospital.Name = "cbHospital";
            this.cbHospital.Size = new System.Drawing.Size(200, 21);
            this.cbHospital.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nơi đăng ký khám chữa bệnh ban đầu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(8, 62);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(620, 483);
            this.txtNote.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(564, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnCancel);
            this.pnButtons.Controls.Add(this.txtRecordNum);
            this.pnButtons.Controls.Add(this.btnLast);
            this.pnButtons.Controls.Add(this.btnNext);
            this.pnButtons.Controls.Add(this.btnPrevious);
            this.pnButtons.Controls.Add(this.btnFirst);
            this.pnButtons.Controls.Add(this.btnClose);
            this.pnButtons.Controls.Add(this.btnSave);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 576);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(644, 40);
            this.pnButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(492, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Bỏ qua";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRecordNum
            // 
            this.txtRecordNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRecordNum.Location = new System.Drawing.Point(56, 8);
            this.txtRecordNum.Name = "txtRecordNum";
            this.txtRecordNum.ReadOnly = true;
            this.txtRecordNum.Size = new System.Drawing.Size(48, 20);
            this.txtRecordNum.TabIndex = 36;
            this.txtRecordNum.Text = "3/26";
            this.txtRecordNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.ImageIndex = 5;
            this.btnLast.ImageList = this.imageList1;
            this.btnLast.Location = new System.Drawing.Point(128, 8);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 23);
            this.btnLast.TabIndex = 35;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.ImageIndex = 4;
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(104, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 23);
            this.btnNext.TabIndex = 34;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.ImageIndex = 3;
            this.btnPrevious.ImageList = this.imageList1;
            this.btnPrevious.Location = new System.Drawing.Point(32, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 23);
            this.btnPrevious.TabIndex = 33;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.ImageIndex = 2;
            this.btnFirst.ImageList = this.imageList1;
            this.btnFirst.Location = new System.Drawing.Point(8, 8);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 23);
            this.btnFirst.TabIndex = 32;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(420, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "&Đồng ý";
            this.btnSave.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEmployee
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(644, 616);
            this.Controls.Add(this.pnProfile);
            this.Controls.Add(this.pnButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ nhân viên";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.pnProfile.ResumeLayout(false);
            this.tabEmployeeProfile.ResumeLayout(false);
            this.tpGeneralInfo.ResumeLayout(false);
            this.grbProfessional.ResumeLayout(false);
            this.grbProfessional.PerformLayout();
            this.grbEmployeeProfile.ResumeLayout(false);
            this.grbEmployeeProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.tpSalary.ResumeLayout(false);
            this.grbAllowance.ResumeLayout(false);
            this.grbAllowance.PerformLayout();
            this.grbBasicSalary.ResumeLayout(false);
            this.grbBasicSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwSalaryHistory)).EndInit();
            this.grbHiringInfo.ResumeLayout(false);
            this.grbHiringInfo.PerformLayout();
            this.tpDepartment.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwPositionHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwDepartmentHistory)).EndInit();
            this.tpOtherInfo.ResumeLayout(false);
            this.tpOtherInfo.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.pnButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Các biến tự định nghĩa

        /// <summary>
        /// Kiểm tra nhân viên có tự đóng BHXH
        /// </summary>
        private bool InsuranceShelf = false;
        /// <summary>
        /// 
        /// </summary>
        private EmployeeDO employeeDO = null;
        private ContractTypeDO contract = null;

        /// <summary>
        /// DataSet nhân viên
        /// </summary>
        private DataSet dsEmployee = null;

        /// <summary>
        /// Vị trí nhân viên hiện tại trong DataSet
        /// </summary>
        private int selectedEmployee = -1;

        /// <summary>
        /// 
        /// </summary>
        private int EmployeeID = 0;

        /// <summary>
        /// Đường dẫn ảnh
        /// </summary>
        private string PictureFileName = "";

        /// <summary>
        /// 
        /// </summary>
        private DataSet dsDepartmentHistory = null;

        /// <summary>
        /// 
        /// </summary>
        private DataSet dsPositionHistory = null;

        /// <summary>
        /// 
        /// </summary>
        private DataSet dsSalaryHistory = null;

        /// <summary>
        /// Kiểm tra có thay đổi mức lương cơ bản hay ko
        /// </summary>
        private bool isSalaryChanged = false;

        /// <summary>
        /// Kiểm tra có thay đổi phòng ban ko
        /// </summary>
        private bool isDepartmentChanged = false;

        /// <summary>
        /// Kiểm tra có thay đổi chức vụ hay ko
        /// </summary>
        private bool isPositionChanged = false;

        /// <summary>
        /// Lấy về DataSet nhân viên
        /// </summary>
        public DataSet EmployeeDataSet
        {
            get { return dsEmployee; }
            set { dsEmployee = value; }
        }

        /// <summary>
        /// Lấy vị trí của nhân viên được chọn trong DataSet
        /// </summary>
        public int SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; }
        }

        //Các biến lưu thông tin thay đổi lương của nhân viên
        private double dbOldSalary = 0;
        private double dbCurrentSalary = 0;
        private DateTime dtModifiedDate;
        private string strDecNumber;
        private string strNote;

        //Các biến lưu thông tin thay đổi phòng ban công tác của nhân viên
        private int iOldDepartment = 0;
        private int iCurrentDepartment = 0;
        private DateTime dtModifiedDateDept;
        private string strDecNumberDept;
        private string strNoteDept;

        private int iReturnEmployeeID = 0;
        #endregion

        #region Các hàm khai báo
        #region Employee

        /// <summary>
        /// Lấy danh sách phòng ban hiện lên cây tổ chức
        /// </summary>
        private void PopulateDepartmentAndPositionCombos()
        {
            DepartmentDO departmentDO = new DepartmentDO();

            DataSet dsDepartment = new DataSet();
            dsDepartment = departmentDO.GetDepartments();

            cboDepartment.SourceDataString = new string[] { "DepartmentID", "DepartmentName" };
            cboDepartment.SourceDataTable = dsDepartment.Tables[0];
            cboDepartment.SelectedIndex = 0;

            DataSet dsPosition = new DataSet();
            dsPosition = departmentDO.GetAllPositions();

            cboPosition.SourceDataString = new string[] { "PositionID", "PositionName" };
            cboPosition.SourceDataTable = dsPosition.Tables[0];
            cboPosition.SelectedIndex = 0;
        }

        /// <summary>
        /// Lấy danh sách phòng khám và bệnh viện hiện lên combo
        /// </summary>
        private void PopulateHospitalCombos()
        {
            DepartmentDO departmentDO = new DepartmentDO();
            DataSet dsHospital = new DataSet();
            dsHospital = departmentDO.GetAllHospitals();
            if (dsHospital != null)
            {
                cbHospital.SourceDataString = new string[] { "HospitalID", "HospitalName" };
                cbHospital.SourceDataTable = dsHospital.Tables[0];
                //cbHospital.SelectedIndex = 0;
            }
        }

        private void PopulateContractCombo()
        {
            try
            {
                contract = new ContractTypeDO();

                DataSet dsContract = new DataSet();

                dsContract = contract.GetAllContract();
                if (dsContract != null)
                {
                    cboContract.SourceDataString = new string[] { "ContractID", "ContractName" };
                    cboContract.SourceDataTable = dsContract.Tables[0];
                    //cboContract.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Phải thêm các loại hợp đồng trước khi thêm nhân viên mới!");
                this.Close();
            }



        }

        /// <summary>
        /// Điền thông tin nhân viên hiện tại vào form
        /// </summary>
        public void LoadCurrentEmployee()
        {
            ResetForm();
            DataRow dr = dsEmployee.Tables[0].Rows[selectedEmployee];
            if (dr != null)
            {
                // Dữ liệu nhân viên
                txtEmployeeName.Text = dr["EmployeeName"].ToString();
                txtCardID.Text = dr["CardID"].ToString();
                txtIdentityCard.Text = dr["IdentityCard"].ToString();
                txtNoiCapCMND.Text = dr["AllocationPlace"].ToString();
                if (dr["Issue"] != DBNull.Value)
                {
                    dtpIssue.Value = (DateTime)dr["Issue"];
                }
                txtInsurenceID.Text = dr["InsuranceID"].ToString();
                if (dr["StartDateInsurance"] != DBNull.Value)
                {
                    dtpStartDateInsurance.Value = (DateTime)dr["StartDateInsurance"];
                }
                if (dr["DateOfBirth"] != DBNull.Value)
                {
                    dtpDateOfBirth.Value = DateTime.Parse(dr["DateOfBirth"].ToString());
                }
                cboGender.SelectedIndex = Int32.Parse(dr["Gender"].ToString());
                txtAddress.Text = dr["Address"].ToString();//Địa chỉ thường trú
                txtTemAddress.Text = dr["TemporaryAddress"].ToString();//Địa chỉ tạm trú
                txtCommune.Text = dr["Commune"].ToString();
                txtDistrict.Text = dr["District"].ToString();
                txtProvince.Text = dr["Province"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtBirthPlace.Text = dr["BirthPlace"].ToString();
                txtResident.Text = dr["Resident"].ToString();
                cboNationality.Text = dr["Nationality"].ToString();

                if (dr["BarCode"] != DBNull.Value)
                    txtBarcode.Text = dr["BarCode"].ToString();
                else//Tao ma vach cho nhan vien
                {
                    string employeeID = dr["EmployeeID"].ToString().Trim();
                    string employeeIDLen12 = employeeID;
                    if (employeeID.Length < 12)
                        for (int i = 0; i < (12 - employeeID.Length); i++)
                            employeeIDLen12 = "0" + employeeIDLen12;

                    if (employeeIDLen12.Length == 12)
                        txtBarcode.Text = employeeIDLen12 + BarCodeHelper.CreateCheckCode(employeeIDLen12);
                }

                if (dr["MarriageStatus"] != DBNull.Value)
                {
                    cboMarriageStatus.SelectedIndex = Int32.Parse(dr["MarriageStatus"].ToString());
                }
                if (dr["People"] != DBNull.Value)
                {
                    cboPeople.SelectedIndex = Int32.Parse(dr["People"].ToString());
                }
                if (dr["Religious"] != DBNull.Value)
                {
                    cboReligious.SelectedIndex = Int32.Parse(dr["Religious"].ToString());
                }
                cboContract.Text = dr["ContractName"].ToString();
                cboDepartment.Text = dr["DepartmentName"].ToString();

                iOldDepartment = Convert.ToInt32(dr["DepartmentID"]); //Lưu lại ID bộ phận công tác trước khi cập nhật

                cboPosition.Text = dr["PositionName"].ToString();

                //Mã số thuế
                if (dr["TaxID"] != DBNull.Value)
                    txtTaxID.Text = dr["TaxID"].ToString();
                //Số người giảm trừ gia cảnh
                if (dr["FamilyConditionNumber"] != DBNull.Value)
                    txtFamilyConditionNumber.Text = dr["FamilyConditionNumber"].ToString();
                else
                    txtFamilyConditionNumber.Text = "0";

                DepartmentDO departmentDO = new DepartmentDO();

                if (dr["HospitalID"] != DBNull.Value)
                {
                    DataSet dsHospital = departmentDO.GetHospital(dr["HospitalID"].ToString());
                    if (dsHospital.Tables.Count > 0)
                        if (dsHospital.Tables[0].Rows.Count > 0)
                            cbHospital.Text = dsHospital.Tables[0].Rows[0]["HospitalName"].ToString();
                }
                if (dr["SalaryID"] != DBNull.Value)
                    if (Convert.ToInt32(dr["SalaryID"]) != 0)
                    {
                        DayTypeDO DayType = new DayTypeDO();
                        DataSet dsSalary = DayType.GetsalaryByID(Convert.ToInt32(dr["SalaryID"]));
                        if (dsSalary.Tables[0].Rows.Count > 0)
                            mtgcComboFixSalary.Text = dsSalary.Tables[0].Rows[0]["SalaryName"].ToString();
                    }
                if (dr["Qualification"] != DBNull.Value)
                {
                    cboQualification.SelectedIndex = Int32.Parse(dr["Qualification"].ToString());
                }
                if (dr["ProfessionalLevel"] != DBNull.Value)
                {
                    cboProfessionalLevel.SelectedIndex = Int32.Parse(dr["ProfessionalLevel"].ToString());
                }
                if (dr["EnglishLevel"] != DBNull.Value)
                {
                    cboEnglishLevel.SelectedIndex = Int32.Parse(dr["EnglishLevel"].ToString());
                }
                else
                {
                    cboEnglishLevel.SelectedIndex = 0;
                }
                if (dr["InformaticLevel"] != DBNull.Value)
                {
                    cboInformaticLevel.SelectedIndex = Int32.Parse(dr["InformaticLevel"].ToString());
                }
                else
                {
                    cboInformaticLevel.SelectedIndex = 0;
                }
                txtOtherCertificate.Text = dr["OtherCertificate"].ToString();
                txtDiscipline.Text = dr["Discipline"].ToString();

                if (dr["RecruitDate"] != DBNull.Value)
                {
                    dtpRecruitDate.Value = DateTime.Parse(dr["RecruitDate"].ToString());
                }
                if (dr["StartDate"] != DBNull.Value)
                {
                    dtpStartDate.Value = DateTime.Parse(dr["StartDate"].ToString());
                    label8.Checked = true;
                    dtpStartDate.Enabled = true;
                }
                else
                {
                    label8.Checked = false;
                    dtpStartDate.Enabled = false;
                }
                if (dr["StartTrial"] != DBNull.Value)
                {
                    dtpStartTrial.Value = DateTime.Parse(dr["StartTrial"].ToString());
                    label5.Checked = true;
                    dtpStartTrial.Enabled = true;
                }
                else
                {
                    label5.Checked = false;
                    dtpStartTrial.Enabled = false;
                }
                label10.Visible = true;
                dtpStopDate.Visible = true;

                if (dr["StopDate"] != DBNull.Value)
                {
                    dtpStopDate.Enabled = true;
                    dtpStopDate.Value = DateTime.Parse(dr["StopDate"].ToString());
                    //Bổ sung ngày thôi việc bên tap Lương và tuyển dụng
                    chkStopWork.Checked = true;
                    dtpStopWork.Value = DateTime.Parse(dr["StopDate"].ToString());
                }
                else
                {
                    dtpStopDate.Enabled = false;
                    chkStopWork.Checked = false;
                    dtpStopWork.Enabled = false;
                }

                if (dr["BasicSalary"] != DBNull.Value)
                {
                    txtBasicSalary.Double = Double.Parse(dr["BasicSalary"].ToString());
                    dbOldSalary = Double.Parse(dr["BasicSalary"].ToString());
                }

                if (dr["LunchAllowance"] != DBNull.Value)
                {
                    txtLunchAllowance.Double = Double.Parse(dr["LunchAllowance"].ToString());
                }
                if (dr["HarmfulAllowance"] != DBNull.Value)
                {
                    txtPositionAllowance.Double = Double.Parse(dr["HarmfulAllowance"].ToString());
                }
                if (dr["ResponsibleAllowance"] != DBNull.Value)
                {
                    txtJobAllowance.Double = Double.Parse(dr["ResponsibleAllowance"].ToString());
                }
                if (dr["IntimateAllowance"] != DBNull.Value)
                {
                    txtIntimateAllowance.Double = Double.Parse(dr["IntimateAllowance"].ToString());
                }
                if (dr["IntimateAllowanceFixed"] != DBNull.Value)
                {
                    chk_PCDL_CoDinhThang.Checked = Convert.ToBoolean(dr["IntimateAllowanceFixed"]);
                }
                //chinhND 20101030 bo sung them phan xu ly tro cap nguy hiem va tro cap tieng Nhat
                if (dr["DangerousAllowance"] != DBNull.Value)
                {
                    txtTaskAllowance.Double = Double.Parse(dr["DangerousAllowance"].ToString());
                }
                if (dr["JapaneseAllowance"] != DBNull.Value)
                {
                    txtJapaneseAllowance.Double = Double.Parse(dr["JapaneseAllowance"].ToString());
                }
                ///end chinhND 20101030
                if (dr["Picture"] != DBNull.Value)
                {
                    PictureFileName = dr["Picture"].ToString();
                    if (PictureFileName.Equals(""))
                    {
                        picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");
                    }
                    else
                    {
                        string PictureFilePath = WorkingContext.Setting.PicturePath + '\\' + dr["Picture"].ToString();
                        try
                        {
                            picEmployee.Image = Image.FromFile(PictureFilePath);
                        }
                        catch
                        {
                            picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");
                        }
                    }
                }
                else
                {
                    picEmployee.Image = Image.FromFile(Application.StartupPath + "/IMAGES/noimage3.jpg");
                }
                txtNote.Text = dr["Note"].ToString();
                InsuranceShelf = bool.Parse(dr["InsuranceShelf"].ToString());
                cboInsuranceShelf.Checked = InsuranceShelf;
                //this.Text = "Hồ sơ nhân viên: " + txtEmployeeName.Text;
                this.Text = WorkingContext.LangManager.GetString("frmE_text") + ": " + txtEmployeeName.Text;
                txtRecordNum.Text = (selectedEmployee + 1) + "/" + dsEmployee.Tables[0].Rows.Count;
                EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                PopulateDepartmentHistoryListView();
                PopulatePositionHistoryListView();
                PopulateSalaryHistoryListView();
                //PopulateContractCombo();
            }
        }

        /// <summary>
        /// Thêm mới một nhân viên
        /// </summary>
        public void AddEmployee()
        {
            int ret = 0;
            DataRow dr = dsEmployee.Tables[0].NewRow();
            try
            {
                dr = dsEmployee.Tables[0].NewRow();
                SetEmployeeData(ref dr);
                dsEmployee.Tables[0].Rows.Add(dr);

                ret = employeeDO.AddNewEmployee(dsEmployee);
                iReturnEmployeeID = ret;
            }
            catch
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_CapNhat_Loi_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmEmployee_CapNhat_Loi_TItle");
                //MessageBox.Show("Lỗi cập nhật cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsEmployee.Tables[0].RejectChanges();
            }
            if (ret != 0 && ret != -1)
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_AddE_ThongBao_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmEmployee_AddE_ThongBao_Title");

                string employeeIDLen12 = ret.ToString();
                if (ret.ToString().Length < 12)
                    for (int i = 0; i < (12 - ret.ToString().Length); i++)
                        employeeIDLen12 = "0" + employeeIDLen12;

                if (employeeIDLen12.Length == 12)
                {
                    dr["BarCode"] = employeeIDLen12 + BarCodeHelper.CreateCheckCode(employeeIDLen12);
                    employeeDO.UpdateBarCode(dsEmployee);
                }


                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsEmployee.Tables[0].AcceptChanges();
                ResetForm();
            }
            else if (ret == -1)
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_AddE_Error_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmEmployee_AddE_ThongBao_Title");
                //MessageBox.Show("Mã thẻ nhân viên đã tồn tại. Không thể thêm nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsEmployee.Tables[0].RejectChanges();
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_AddE_Error_Messa2");
                string str1 = WorkingContext.LangManager.GetString("frmEmployee_AddE_ThongBao_Title");
                //MessageBox.Show("Không thể thêm được nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsEmployee.Tables[0].RejectChanges();
            }
        }

        /// <summary>
        /// Cập nhật nhân viên
        /// </summary>
        public void UpdateEmployee()
        {
            int ret = 0;
            try
            {
                DataRow dr = dsEmployee.Tables[0].Rows[selectedEmployee];
                SetEmployeeData(ref dr);
                ret = employeeDO.UpdateEmployee(dsEmployee);
            }
            catch
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_CapNhat_Loi_Messa");
                string str2 = WorkingContext.LangManager.GetString("frmEmployee_CapNhat_Loi_TItle");
                //MessageBox.Show("Lỗi cập nhật cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsEmployee.Tables[0].RejectChanges();
            }

            string str1 = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Thongbao_Title");
            if (ret == 1)
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Thongbao_Messa");

                //MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsEmployee.Tables[0].AcceptChanges();
            }
            else if (ret == -1)
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa1");
                //MessageBox.Show("Mã thẻ nhân viên đã tồn tại. Không thể cập nhật nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsEmployee.Tables[0].RejectChanges();
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa2");
                //MessageBox.Show("Không thể cập nhật nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsEmployee.Tables[0].RejectChanges();
            }
        }

        /// <summary>
        /// Dùng chung cho AddEmployee() và UpdateEmployee()
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private void SetEmployeeData(ref DataRow dr)
        {
            dr.BeginEdit();

            dr["CardID"] = txtCardID.Text.Trim();
            dr["EmployeeName"] = txtEmployeeName.Text.Trim();

            //Ma vach
            if (txtBarcode.Text.Trim() != string.Empty)
                dr["BarCode"] = txtBarcode.Text.Trim();

            dr["IdentityCard"] = txtIdentityCard.Text.Trim();
            dr["Issue"] = dtpIssue.Value;
            dr["InsuranceID"] = txtInsurenceID.Text;
            dr["AllocationPlace"] = txtNoiCapCMND.Text;

            dr["DateOfBirth"] = dtpDateOfBirth.Value;
            dr["Gender"] = cboGender.SelectedIndex;
            dr["BirthPlace"] = txtBirthPlace.Text;
            dr["Resident"] = txtResident.Text;
            dr["Address"] = txtAddress.Text; //Địa chỉ thường trú
            dr["TemporaryAddress"] = txtTemAddress.Text; //Địa chỉ tạm trú
            dr["Commune"] = txtCommune.Text;
            dr["District"] = txtDistrict.Text;
            dr["Province"] = txtProvince.Text;
            dr["Phone"] = txtPhone.Text;
            dr["Email"] = txtEmail.Text;
            dr["MarriageStatus"] = cboMarriageStatus.SelectedIndex;
            dr["People"] = cboPeople.SelectedIndex;
            dr["Religious"] = cboReligious.SelectedIndex;

            dr["DepartmentID"] = ((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1;
            dr["DepartmentName"] = ((MTGCComboBoxItem)cboDepartment.SelectedItem).Col2;
            dr["PositionID"] = ((MTGCComboBoxItem)cboPosition.SelectedItem).Col1;
            dr["PositionName"] = ((MTGCComboBoxItem)cboPosition.SelectedItem).Col2;

            dr["Qualification"] = cboQualification.SelectedIndex;
            dr["ProfessionalLevel"] = cboProfessionalLevel.SelectedIndex;
            dr["EnglishLevel"] = cboEnglishLevel.SelectedIndex;
            dr["InformaticLevel"] = cboInformaticLevel.SelectedIndex;
            dr["OtherCertificate"] = txtOtherCertificate.Text;
            dr["Discipline"] = txtDiscipline.Text;

            dr["RecruitDate"] = dtpRecruitDate.Value;
            if (label8.Checked)
                dr["StartDate"] = dtpStartDate.Value;
            if (label5.Checked)
                dr["StartTrial"] = dtpStartTrial.Value;
            if (chkStopWork.Checked)
                dr["StopDate"] = dtpStopWork.Value;

            if (cboContract.Text.Trim() != "")
            {
                dr["ContractID"] = ((MTGCComboBoxItem)cboContract.SelectedItem).Col1;
                dr["ContractName"] = ((MTGCComboBoxItem)cboContract.SelectedItem).Col2;
            }
            if (mtgcComboFixSalary.Text.Trim() != "")
                dr["SalaryID"] = ((MTGCComboBoxItem)mtgcComboFixSalary.SelectedItem).Col1;
            else
                dr["SalaryID"] = 0;
            dr["BasicSalary"] = txtBasicSalary.Double;
            dbCurrentSalary = txtBasicSalary.Double; //Lưu  lại lương hiện tại

            dr["LunchAllowance"] = txtLunchAllowance.Double;
            dr["HarmfulAllowance"] = txtPositionAllowance.Double;
            dr["ResponsibleAllowance"] = txtJobAllowance.Double;
            dr["IntimateAllowance"] = txtIntimateAllowance.Double;
            dr["IntimateAllowanceFixed"] = chk_PCDL_CoDinhThang.Checked;

            dr["DangerousAllowance"] = txtTaskAllowance.Double;
            dr["JapaneseAllowance"] = txtJapaneseAllowance.Double;

            //if (dtpStopDate.Enabled)
            //{
            //    dr["StopDate"] = dtpStopDate.Value;
            //}
            //Anh nhan vien
            if (PictureFileName != string.Empty)
                dr["Picture"] = PictureFileName;

            dr["Note"] = txtNote.Text;

            dr["Nationality"] = cboNationality.SelectedItem;
            dr["StartDateInsurance"] = dtpStartDateInsurance.Value;
            if (cboInsuranceShelf.CheckState == CheckState.Checked)
            {
                dr["InsuranceShelf"] = 1;
            }
            else
            {
                dr["InsuranceShelf"] = 0;
            }
            if (cbHospital.Text.Trim() != "")
                dr["HospitalID"] = ((MTGCComboBoxItem)cbHospital.SelectedItem).Col1;
            //Mã số thuế
            dr["TaxID"] = txtTaxID.Text.Trim();
            //Số người giảm trừ gia cảnh
            if (txtFamilyConditionNumber.Text.Trim() == string.Empty)
                dr["FamilyConditionNumber"] = 0;
            else dr["FamilyConditionNumber"] = ConvertStringToInt(txtFamilyConditionNumber.Text.Trim());

            dr.EndEdit();
        }
        #endregion 

        #region Các hàm hiển thị History về lương, bộ phận công tác, vị trí của nhân viên
        /// <summary>
        /// Hiển thị danh sách HistorySalary của nhân viên
        /// </summary>
        private void PopulateSalaryHistoryListView()
        {
            dsSalaryHistory = employeeDO.GetSalaryHistory(EmployeeID);
            lvwSalaryHistory.BeginUpdate();
            lvwSalaryHistory.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dsSalaryHistory.Tables[0].Rows)
            {
                STT++;
                double BasicSalary = Double.Parse(dr["BasicSalary"].ToString());
                string ModifiedDate = DateTime.Parse(dr["ModifiedDate"].ToString()).ToString("dd/MM/yyyy");
                string DecisionNumber = dr["DecisionNumber"].ToString();
                string Note = dr["Note"].ToString();

                Row row = new Row(new string[] { STT.ToString(), BasicSalary.ToString(), ModifiedDate, DecisionNumber, Note });
                lvwSalaryHistory.TableModel.Rows.Add(row);
            }

            lvwSalaryHistory.EndUpdate();
        }

        /// <summary>
        /// Hiển thị danh sách HistoryDepartement của nhân viên
        /// </summary>
        private void PopulateDepartmentHistoryListView()
        {
            dsDepartmentHistory = employeeDO.GetDepartmentHistory(EmployeeID);
            lvwDepartmentHistory.BeginUpdate();
            lvwDepartmentHistory.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dsDepartmentHistory.Tables[0].Rows)
            {
                STT++;
                string DepartmentName = dr["DepartmentName"].ToString();
                string ModifiedDate = DateTime.Parse(dr["ModifiedDate"].ToString()).ToString("dd/MM/yyyy");
                string DecisionNumber = dr["DecisionNumber"].ToString();
                string Note = dr["Note"].ToString();

                Row row = new Row(new string[] { STT.ToString(), DepartmentName, ModifiedDate, DecisionNumber, Note });
                lvwDepartmentHistory.TableModel.Rows.Add(row);
            }
            lvwDepartmentHistory.EndUpdate();
        }

        /// <summary>
        /// Hiển thị danh sách HistoryPosition của nhân viên
        /// </summary>
        private void PopulatePositionHistoryListView()
        {
            dsPositionHistory = employeeDO.GetPositionHistory(EmployeeID);
            lvwPositionHistory.BeginUpdate();
            lvwPositionHistory.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dsPositionHistory.Tables[0].Rows)
            {
                STT++;
                string PositionName = dr["PositionName"].ToString();
                string ModifiedDate = DateTime.Parse(dr["ModifiedDate"].ToString()).ToString("dd/MM/yyyy");
                string DecisionNumber = dr["DecisionNumber"].ToString();
                string Note = dr["Note"].ToString();

                Row row = new Row(new string[] { STT.ToString(), PositionName, ModifiedDate, DecisionNumber, Note });
                lvwPositionHistory.TableModel.Rows.Add(row);
            }

            lvwPositionHistory.EndUpdate();
        }
        #endregion

        #region Các hàm thực hiện insert/update/delete History về lương, bộ phận công tác, vị trí
        /// <summary>
        /// Thực hiện lưu (insert/update) các thay đổi vào lịch sử của nhân viên
        /// </summary>
        private void UpdateEmployeeHistory()
        {
            //Thực hiện cập nhật Salary history nếu có sự thay đổi thông tin salary
            if (isSalaryChanged || txtBasicSalary.Double != dbOldSalary)
            {
                int ret = 0;
                DataSet dsSalaryHistoryByMonth = employeeDO.GetSalaryHistoryByMonth(EmployeeID, dtpSalaryChangedDay.Value.Year, dtpSalaryChangedDay.Value.Month);
                try
                {
                    //Thực hiện cập nhật SalaryHistory nếu đã có thông tin SalaryHistory của tháng cần cập nhật
                    if (dsSalaryHistoryByMonth.Tables[0].Rows.Count > 0)
                    {
                        DataRow drUpdate = dsSalaryHistoryByMonth.Tables[0].Rows[0];
                        drUpdate.BeginEdit();
                        drUpdate["SalaryHistoryID"] = Convert.ToInt32(dsSalaryHistoryByMonth.Tables[0].Rows[0]["SalaryHistoryID"]);
                        drUpdate["EmployeeID"] = EmployeeID;
                        drUpdate["BasicSalary"] = txtBasicSalary.Double;
                        drUpdate["DecisionNumber"] = txtSalaryDN.Text;
                        drUpdate["Note"] = txtSalaryNote.Text;
                        drUpdate["ModifiedDate"] = dtpSalaryChangedDay.Value.Date;
                        drUpdate.EndEdit();
                        ret = employeeDO.UpdateSalaryHistory(dsSalaryHistoryByMonth);
                    }
                    //Thực hiện thêm mới SalaryHistory nếu chưa tồn tại thông tin SalaryHistory nào của tháng cần cập nhật
                    else
                    {
                        DataRow drNew = dsSalaryHistoryByMonth.Tables[0].NewRow();
                        drNew.BeginEdit();
                        drNew["EmployeeID"] = EmployeeID;
                        drNew["BasicSalary"] = txtBasicSalary.Double;
                        drNew["DecisionNumber"] = txtSalaryDN.Text;
                        drNew["Note"] = txtSalaryNote.Text;
                        drNew["ModifiedDate"] = dtpSalaryChangedDay.Value.Date;
                        drNew.EndEdit();
                        dsSalaryHistoryByMonth.Tables[0].Rows.Add(drNew);
                        ret = employeeDO.AddSalaryHistory(dsSalaryHistoryByMonth);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (ret == 0)
                {
                    dsSalaryHistoryByMonth.RejectChanges();
                }
                else
                {
                    dsSalaryHistoryByMonth.AcceptChanges();
                }
            }

            // Kiểm tra nếu có sự thay đổi công tác
            if (isDepartmentChanged || iOldDepartment != Convert.ToInt32(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1))
            {
                int ret = 0;
                DataSet dsDepartmentHistoryByMonth = employeeDO.GetDepartmentHistoryByMonth(EmployeeID, dtpDepartment.Value.Year, dtpDepartment.Value.Month);
                try
                {
                    //Thực hiện cập nhật log department nếu đã có thông tin department của tháng cần cập nhật
                    if (dsDepartmentHistoryByMonth.Tables[0].Rows.Count > 0)
                    {
                        DataRow drUpdateDept = dsDepartmentHistoryByMonth.Tables[0].Rows[0];
                        drUpdateDept.BeginEdit();
                        drUpdateDept["DepartmentHistoryID"] = Convert.ToInt32(dsDepartmentHistoryByMonth.Tables[0].Rows[0]["DepartmentHistoryID"]);
                        drUpdateDept["EmployeeID"] = EmployeeID;
                        drUpdateDept["DepartmentID"] = ((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1;
                        drUpdateDept["DecisionNumber"] = txtDepartmentDN.Text;
                        drUpdateDept["Note"] = txtDepartmentNote.Text;
                        drUpdateDept["ModifiedDate"] = dtpDepartment.Value.Date;
                        drUpdateDept.EndEdit();
                        ret = employeeDO.UpdateDepartmentHistory(dsDepartmentHistoryByMonth);
                    }
                        //Thực hiện thêm mới log department nếu chưa tồn tại log department nào trong tháng
                    else
                    {
                        DataRow dr = dsDepartmentHistoryByMonth.Tables[0].NewRow();
                        dr.BeginEdit();
                        dr["EmployeeID"] = EmployeeID;
                        dr["DepartmentID"] = ((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1;
                        dr["DecisionNumber"] = txtDepartmentDN.Text;
                        dr["Note"] = txtDepartmentNote.Text;
                        dr["ModifiedDate"] = dtpDepartment.Value.Date;
                        dr.EndEdit();
                        dsDepartmentHistoryByMonth.Tables[0].Rows.Add(dr);
                        ret = employeeDO.AddDepartmentHistory(dsDepartmentHistoryByMonth);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (ret == 0)
                {
                    dsDepartmentHistoryByMonth.RejectChanges();
                }
                else
                {
                    dsDepartmentHistoryByMonth.AcceptChanges();
                }
            }
            // Kiểm tra nếu có sự thay đổi chức vụ
            if (isPositionChanged)
            {
                int ret = 0;
                try
                {
                    dsPositionHistory = employeeDO.GetPositionHistory(EmployeeID);
                    DataRow dr = dsPositionHistory.Tables[0].NewRow();
                    dr.BeginEdit();
                    dr["EmployeeID"] = EmployeeID;
                    dr["PositionID"] = ((MTGCComboBoxItem)cboPosition.SelectedItem).Col1;
                    dr["DecisionNumber"] = txtPositionDN.Text;
                    dr["Note"] = txtPositionNote.Text;
                    dr["ModifiedDate"] = dtpChangePosition.Value.Date;
                    dr.EndEdit();
                    dsPositionHistory.Tables[0].Rows.Add(dr);
                    ret = employeeDO.AddPositionHistory(dsPositionHistory);
                }
                catch
                {
                }
                if (ret == 0)
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa4");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Title1");
                    //MessageBox.Show("Không thể thêm thay đổi vào diễn biến lương của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Không thể thêm thay đổi vào quá trình công tác của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsDepartmentHistory.RejectChanges();
                }
                else
                {
                    dsDepartmentHistory.AcceptChanges();
                }
            }
        }

        /// <summary>
        /// Thực hiện lưu (insert) log các thông tin lương của nhân viên
        /// </summary>
        /// <param name="iEmployeeIDPara"></param>
        private void AddSalaryLogOfEmployee(int iEmployeeIDPara)
        {
            int ret = 0;
            try
            {
                dsSalaryHistory = employeeDO.GetSalaryHistory(iEmployeeIDPara);
                DataRow dr = dsSalaryHistory.Tables[0].NewRow();
                dr.BeginEdit();
                dr["EmployeeID"] = iEmployeeIDPara;
                dr["BasicSalary"] = dbCurrentSalary;
                dr["DecisionNumber"] = strDecNumber;
                dr["Note"] = strNote;
                dr["ModifiedDate"] = dtModifiedDate;
                dr.EndEdit();
                dsSalaryHistory.Tables[0].Rows.Add(dr);
                ret = employeeDO.AddSalaryHistory(dsSalaryHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (ret == 0)
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa3"),
                    WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Title1"), 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsSalaryHistory.RejectChanges();
            }
            else
            {
                dsSalaryHistory.AcceptChanges();
            }
        }

        /// <summary>
        /// Thực hiện lưu (insert) log thông tin bộ phận công tác của nhân viên
        /// </summary>
        /// <param name="iEmployeeIDPara"></param>
        private void AddDepartmentLogOfEmployee(int iEmployeeIDPara)
        {
            int ret = 0;
            try
            {
                dsDepartmentHistory = employeeDO.GetDepartmentHistory(iEmployeeIDPara);
                DataRow dr = dsDepartmentHistory.Tables[0].NewRow();
                dr.BeginEdit();
                dr["EmployeeID"] = iEmployeeIDPara;
                dr["DepartmentID"] = iCurrentDepartment;
                dr["DecisionNumber"] = strDecNumberDept;
                dr["Note"] = strNoteDept;
                dr["ModifiedDate"] = dtModifiedDateDept;
                dr.EndEdit();
                dsDepartmentHistory.Tables[0].Rows.Add(dr);
                ret = employeeDO.AddDepartmentHistory(dsDepartmentHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (ret == 0)
            {
                //string str = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Messa4");
                //string str1 = WorkingContext.LangManager.GetString("frmEmployee_UpdateE_Error_Title1");
                ////MessageBox.Show("Không thể thêm thay đổi vào diễn biến lương của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ////MessageBox.Show("Không thể thêm thay đổi vào quá trình công tác của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsDepartmentHistory.RejectChanges();
            }
            else
            {
                dsDepartmentHistory.AcceptChanges();
            }
        }

        /// <summary>
        /// Sửa một diễn biến thay đổi lương
        /// </summary>
        private void EditSelectedSalaryHistory()
        {
            if (lvwSalaryHistory.SelectedIndicies.Length > 0)
            {
                DataRow rowUpdate = dsSalaryHistory.Tables[0].Rows[lvwSalaryHistory.SelectedIndicies[0]];
                int iEmployeeID = Convert.ToInt32(rowUpdate["EmployeeID"]);
                int iIndex = lvwSalaryHistory.SelectedIndicies[0];
                decimal dbSalary = Convert.ToDecimal(rowUpdate["BasicSalary"]);
                DateTime dtModifiedDate = Convert.ToDateTime(rowUpdate["ModifiedDate"]);
                string strDecNumber = rowUpdate["DecisionNumber"].ToString();
                string strNote = rowUpdate["Note"].ToString();
                FrmUpdateSalaryHistory frmChild = new FrmUpdateSalaryHistory(iEmployeeID, dbSalary, strDecNumber, dtModifiedDate, strNote, iIndex);
                if (frmChild.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateSalaryHistoryListView();
                }
            }
        }

        /// <summary>
        /// Sửa một diễn biến thay đổi bộ phận công tác
        /// </summary>
        private void EditSelectedDepartmentHistory()
        {
            if (lvwDepartmentHistory.SelectedIndicies.Length > 0)
            {
                DataRow rowUpdate = dsDepartmentHistory.Tables[0].Rows[lvwDepartmentHistory.SelectedIndicies[0]];
                int iIndex = lvwDepartmentHistory.SelectedIndicies[0];
                int iEmployeeID = Convert.ToInt32(rowUpdate["EmployeeID"]);
                string strDepartmentName = rowUpdate["DepartmentName"].ToString();
                DateTime dtModifiedDate = Convert.ToDateTime(rowUpdate["ModifiedDate"]);
                string strDecNumber = rowUpdate["DecisionNumber"].ToString();
                string strNote = rowUpdate["Note"].ToString();

                FrmUpdateDepartmentHistory frmChild = new FrmUpdateDepartmentHistory(iEmployeeID, strDepartmentName, dtModifiedDate, strDecNumber, strNote, iIndex);
                if (frmChild.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateDepartmentHistoryListView();
                }
            }
        }

        /// <summary>
        /// Sửa một thay đổi chức vụ
        /// </summary>
        private void EditSelectedPositionHistory()
        {
        }

        /// <summary>
        /// Xóa một diễn biến lương
        /// </summary>
        private void DeleteSelectedSalaryHistory()
        {
            if (lvwSalaryHistory.SelectedIndicies.Length > 0)
            {
                int ret = 0;
                try
                {
                    dsSalaryHistory.Tables[0].Rows[lvwSalaryHistory.SelectedIndicies[0]].Delete();
                    ret = employeeDO.DeleteSalaryHistory(dsSalaryHistory);
                }
                catch
                {
                }
                if (ret != 0)
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteE_ThongBao_Messa");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteE_ThongBao_Title");
                    //MessageBox.Show("Xóa diễn biến lương thành công", "Xóa diễn biến lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateSalaryHistoryListView();
                    dsSalaryHistory.AcceptChanges();
                }
                else
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteE_ThongBao_Messa1");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteE_ThongBao_Title");
                    //MessageBox.Show("Xóa diễn biến lương thành công", "Xóa diễn biến lương", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsSalaryHistory.RejectChanges();
                }
            }
        }

        /// <summary>
        /// Xóa một quá trình chuyển công tác
        /// </summary>
        private void DeleteSelectedDepartmentHistory()
        {
            if (lvwDepartmentHistory.SelectedIndicies.Length > 0)
            {
                int ret = 0;
                try
                {
                    dsDepartmentHistory.Tables[0].Rows[lvwDepartmentHistory.SelectedIndicies[0]].Delete();
                    ret = employeeDO.DeleteDepartmentHistory(dsDepartmentHistory);
                }
                catch
                {
                }
                if (ret != 0)
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteCT_ThongBao_Messa1");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteCT_ThongBao_Title");
                    //MessageBox.Show("Xóa quá trình chuyển công tác thành công", "Xóa quá trình chuyển công tác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateDepartmentHistoryListView();
                    dsDepartmentHistory.AcceptChanges();
                }
                else
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteCT_ThongBao_Messa2");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteCT_ThongBao_Title");
                    //MessageBox.Show("Xóa quá trình chuyển công tác thành công", "Xóa quá trình chuyển công tác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsDepartmentHistory.RejectChanges();
                }
            }
        }

        /// <summary>
        /// Xóa một quá trình chuyển chức vụ
        /// </summary>
        private void DeleteSelectedPositionHistory()
        {
            if (lvwPositionHistory.SelectedIndicies.Length > 0)
            {
                int ret = 0;
                try
                {
                    dsPositionHistory.Tables[0].Rows[lvwPositionHistory.SelectedIndicies[0]].Delete();
                    ret = employeeDO.DeletePositionHistory(dsPositionHistory);
                }
                catch
                {
                }
                if (ret != 0)
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteCV_ThongBao_Messa");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteCV_ThongBao_Title");

                    //MessageBox.Show("Xóa quá trình chuyển chức vụ thành công", "Xóa quá trình chuyển chức vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulatePositionHistoryListView();
                    dsPositionHistory.AcceptChanges();
                }
                else
                {
                    string str = WorkingContext.LangManager.GetString("frmEmployee_DeleteCV_ThongBao_Messa1");
                    string str1 = WorkingContext.LangManager.GetString("frmEmployee_DeleteCV_ThongBao_Title");

                    //MessageBox.Show("Xóa quá trình chuyển chức vụ thành công", "Xóa quá trình chuyển chức vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsPositionHistory.RejectChanges();
                }
            }
        }
        #endregion

        #region Utility methods
        private void initComboFixSalary(int Idcontract)
        {

            DataSet dsFixSalary = new DataSet();
            dsFixSalary = contract.GetFixSalaryByContract(Idcontract);
            if (dsFixSalary != null)
            {
                mtgcComboFixSalary.SourceDataString = new string[] { "SalaryID", "SalaryName" };
                mtgcComboFixSalary.SourceDataTable = dsFixSalary.Tables[0];
                //mtgcComboFixSalary.SelectedIndex = 0;
            }
        }

        public override void Refresh()
        {
            ChangeToCurrentLang();
            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }
            base.Refresh();
        }

        private void ChangeToCurrentLang()
        {
            this.Text = WorkingContext.LangManager.GetString("frmE_text");
            this.cboInsuranceShelf.Text = WorkingContext.LangManager.GetString("frmE_BHXH");
            this.grbAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance");
            this.lblRecruitDate.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo_lblNgayTuyenDung");
            this.lblLunchAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_lblLunchAllowance");
            this.label1.Text = WorkingContext.LangManager.GetString("frmE_lbl1");
            this.lblHarmfulAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance_lblPCDocHai");
            this.lblResponsibleAllowance.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpAllowance_lblPCTrachNhiem");
            this.tpGeneralInfo.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile");
            this.grbEmployeeProfile.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile");
            this.lblAddress.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblAddr");
            this.lblBasicSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpBasicSalary_lblBasicSalary");
            this.lblEmployeeName.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_blEmployeeName");
            this.lblCardID.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblMaThe");
            this.lblBirthday.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblDateOfBirth");
            this.lblGender.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblGioiTinh");
            this.label3.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblPhuongXa");
            this.label2.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_blQuanHuyen");
            this.label4.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_blCity");
            this.lblPhone.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblPhone");
            this.lblEmail.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblEmail");
            this.lblBirthPlace.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblNoiSinh");
            this.lblResident.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblHoKhau");
            this.lblNationality.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblQuocTich");
            this.lblMarriageStatus.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblHonNhan");
            this.lblIdentityCard.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblCMND");
            this.lblPeople.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblDanToc");
            this.lblReligious.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblTonGiao");
            this.lblInsuranceID.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblBHXH");
            this.label6.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblDateOfBHXH");
            this.grbProfessional.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_grpProfessional");
            this.lblProfessionalLevel.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblTrinhDoVanHoa");
            this.lblNganhHoc.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblNganhHoc");
            this.lblQualification.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblBangCap");
            this.lblOtherCertificate.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblChungChi");
            this.lblEnglishLevel.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblNgoaiNgu");
            this.lblInformaticLevel.Text = WorkingContext.LangManager.GetString("frmEmployee_tbProfile_lblTinHoc");
            this.tpSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary");
            this.grbHiringInfo.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo");
            this.lblIssue.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_lblIssue");

            //this.lblRecruitDate.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo_lblNgayTuyenDung");
            this.label8.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo_lblNgayLamChinhThuc");
            this.label5.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo_lblNgayThuViec");
            this.lblContract.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpHiringInfo_lblkieuluong");
            this.grbBasicSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_grpBasicSalary");
            this.lblBasicSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpBasicSalary_lblBasicSalary");
            this.lblSalaryDN.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpBasicSalary_lblQDS");
            this.lblSalaryNote.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpBasicSalary_lblNote");
            this.btnChangeSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_grpBasicSalary_bntChangeSalary");
            this.chSTT.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_vwSalaryHistory_STT");
            this.chDepartmentName.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwDeparrtmentHistory_TenBoPhan");
            this.chModifiedDate.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwDeparrtmentHistory_NgayThayDoi");
            this.chDecisionNumber.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwDeparrtmentHistory_QDS");
            this.chNote.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwDeparrtmentHistory_Note");
            this.cSTT.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwPostionHistory_STT");
            this.cPositionName.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lblChucVu");
            this.cDecisionNumber.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwPostionHistory_QDS");
            this.cNote.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lvwPostionHistory_Note");
            this.cBasicSalary.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_lvwSalaryHistory_BasicSalary");
            this.cModifiedDate.Text = WorkingContext.LangManager.GetString("frmEmployee_tbSalary_lvwSalaryHistory_NgayThayDoi");
            this.tpDepartment.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment");
            this.lblDepartmentName.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lblBoPhan");
            this.groupBox2.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_GroupBox2");
            this.lblDepartmentDN.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lblQDS");
            this.lblDepartmentNote.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lblGhiChu");
            this.btnChangeDepartment.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_bntChangeDepartment");
            this.groupBox4.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_GroupBox4");
            this.lblPositionName.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_lblChucVu");
            this.lblPositionDN.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_GroupBox4_lblQDS");
            this.lblPositionNote.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_GroupBox4_lblGhiChu");
            this.btnChangePosition.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_GroupBox4_bntChangePosition");
            //this.tpOtherInfo.Text = WorkingContext.LangManager.GetString("")
            this.btnCancel.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_bntCancle");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_bntClose");
            this.btnSave.Text = WorkingContext.LangManager.GetString("frmEmployee_tbDepartment_bntSave");
            this.tpDepartment.Text = WorkingContext.LangManager.GetString("frmEmployee_BoPhanChucVu");
            this.tpOtherInfo.Text = WorkingContext.LangManager.GetString("frmEmployee_ThongTinKhac");
            this.btnChoosePic.Text = WorkingContext.LangManager.GetString("frmE_btnAnh");
            this.lvwDepartmentHistory.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            this.lvwPositionHistory.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            this.lvwSalaryHistory.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
            this.lblSalaryChangedDay.Text = WorkingContext.LangManager.GetString("frmE_lblSalaryChangedDay");
        }

        /// <summary>
        /// Xóa dữ liệu trên form
        /// </summary>
        private void ResetForm()
        {
            foreach (TabPage tabPage in tabEmployeeProfile.TabPages)
            {
                foreach (Control ct1 in tabPage.Controls)
                {
                    if (ct1 is GroupBox)
                    {
                        foreach (Control ct2 in ct1.Controls)
                        {
                            if (ct2 is TextBox)
                            {
                                ct2.Text = String.Empty;
                            }
                            else if (ct2 is Button)
                            {
                                ct2.Enabled = true;
                            }
                            else if (ct2 is DateTimePicker)
                            {
                                ((DateTimePicker)ct2).Value = DateTime.Today;
                            }
                            //else if (ct2 is ComboBox)
                            //{
                            //    ((ComboBox) ct2).SelectedIndex = 0;
                            //}
                        }
                    }
                }
            }
            if (picEmployee.Image != null)
            {
                picEmployee.Image.Dispose();
                picEmployee.Image = null;
            }
            txtSalaryDN.Enabled = false;
            txtSalaryNote.Enabled = false;
            txtDepartmentDN.Enabled = false;
            txtDepartmentNote.Enabled = false;
            txtPositionDN.Enabled = false;
            txtPositionNote.Enabled = false;
            dtpChangePosition.Enabled = false;
            dtpDepartment.Enabled = false;
        }

        /// <summary>
        /// Kiểm tra dữ liệu đầu vào
        /// </summary>
        /// <returns>Chuỗi xác định lỗi</returns>
        private string ValidateInputData()
        {
            if (txtEmail.Text.Trim() != "")
            {
                if (!isEmail(txtEmail.Text.Trim()))
                {
                    string str0 = "Địa chỉ email không hợp lệ";
                    return str0;
                }
            }
            if (txtEmployeeName.Text.Trim() == "")
            {
                string str1 = WorkingContext.LangManager.GetString("frmEmployee_Message1");

                //return "Bạn chưa nhập tên nhân viên";

                return str1;
            }
            if (txtCardID.Text.Trim() == "")
            {
                string str2 = WorkingContext.LangManager.GetString("frmEmployee_Message2");
                //return "Bạn chưa nhập mã thẻ nhân viên";
                return str2;
            }
            if (dtpDateOfBirth.Value.Date > DateTime.Now)
            {
                string str3 = WorkingContext.LangManager.GetString("frmEmployee_Message3");
                //return "Ngày sinh phải trước ngày hiện tại";
                return str3;
            }
            if (dtpIssue.Value.Date > DateTime.Now || dtpIssue.Value < dtpDateOfBirth.Value)
            {
                string str4 = WorkingContext.LangManager.GetString("frmEmployee_Message4");
                //return "Ngày cấp CMND phải nhỏ hơn ngày hiện tại và lớn hơn ngày sinh";
                return str4;
            }
            if (dtpStartDateInsurance.Value.Date > DateTime.Now || dtpStartDateInsurance.Value < dtpDateOfBirth.Value)
            {
                string str5 = WorkingContext.LangManager.GetString("frmEmployee_Message5");
                //return "Ngày đóng BHXH phải nhỏ hơn ngày hiện tại và lớn hơn ngày sinh";
                return str5;
            }
            if (label8.Checked)
                if (dtpRecruitDate.Value.Date > dtpStartDate.Value.Date)
                {
                    string str6 = WorkingContext.LangManager.GetString("frmEmployee_Message6");
                    //return "Ngày tuyển phải trước ngày làm việc chính thức";
                    return str6;
                }
            if (label5.Checked)
                if (dtpRecruitDate.Value.Date > dtpStartTrial.Value.Date)
                {
                    string str7 = WorkingContext.LangManager.GetString("frmEmployee_Message7");
                    //return "Ngày thử việc phải lớn hơn hoặc bằng ngày tuyển
                    return str7;
                }
            string contract = cboContract.Text.Trim();
            if (label8.Checked && label5.Checked)
                if (dtpStartTrial.Value.Date > dtpStartDate.Value.Date && cboContract.Text != "Thử việc")
                {
                    string str8 = WorkingContext.LangManager.GetString("frmEmployee_Message8");
                    //return "Ngày làm chính thức phải sau ngày thử việc
                    return str8;
                }
            //So nguoi giam tru gia canh
            if (txtFamilyConditionNumber.Text.Trim() != string.Empty)
            {
                bool checkNumber = CheckNumber(txtFamilyConditionNumber.Text.Trim());

                if (!checkNumber)
                    return "Số người giảm trừ gia cảnh kiểu số !";
            }

            return "";
        }

        public bool isEmail(string inputEmail)
        {

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void ValidateNullTextBox(TextBox textBox)
        {
            if (textBox.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(textBox, "This field cannot be null");
            }
            else
            {
                // Clear the Error
                errorProvider1.SetError(textBox, string.Empty);
            }
        }

        public static bool CheckNumber(string number)
        {
            if (number == string.Empty)
                return false;

            foreach (char c in number)
            {
                if (c == 46)
                {
                    if (number.IndexOf(c) == 0 || number.IndexOf(c) == (number.Length - 1))
                    {
                        return false;
                    }
                }
                if (!char.IsNumber(c) && c != 46)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Chuyển chuổi về kiểu int, nếu không đúng định dạng sẽ trả kết quả = 0
        /// </summary>
        public static int ConvertStringToInt(string decString)
        {
            if (string.IsNullOrEmpty(decString))
                return 0;

            int intNumber;

            //decString = ConvertJapaneseToASCII(decString);

            if (!int.TryParse(decString, NumberStyles.Integer, null, out intNumber))
            {
                intNumber = 0;
            }

            return intNumber;
        }

        /// <summary>
        /// Phương thức này cho phép một TextBox cấm gõ các ký tự chỉ cho phép gõ các số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void KeyPressInteger(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Lấy về đối tượng TextBox
            TextBox textBox = (TextBox)sender;
            textBox.ImeMode = ImeMode.Disable;

            // Lấy về mã ASCII của ký tự vừa được gõ vào TextBox
            char keycode = e.KeyChar;
            int c = (int)keycode;

            // Kiểm tra ký tự vừa nhập vào có phải là các số nằm trong khoảng
            // 0..9
            if (Char.IsNumber(keycode) || c == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        #endregion 

        #region Các hàm sự kiện
        #region Chung
        private void btnOK_Click(object sender, EventArgs e)
        {
            string errMsg = ValidateInputData();
            if (errMsg != "")
            {

                string str = WorkingContext.LangManager.GetString("frmEmployee_Loi_Messa");
                MessageBox.Show(errMsg, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (selectedEmployee >= 0)
                {
                    UpdateEmployeeHistory();
                    UpdateEmployee();
                    LoadCurrentEmployee();
                }
                else
                {
                    //Lưu lại thông tin thay đổi lương
                    strNote = txtSalaryNote.Text.Trim();
                    strDecNumber = txtSalaryDN.Text.Trim();
                    dtModifiedDate = dtpStartTrial.Value.Date;
                    //Lưu lại thông tin thay đổi bộ phận công tác
                    iCurrentDepartment = Convert.ToInt32(((MTGCComboBoxItem)cboDepartment.SelectedItem).Col1);
                    strNoteDept = txtDepartmentNote.Text.Trim();
                    strDecNumberDept = txtDepartmentDN.Text.Trim();
                    dtModifiedDateDept = dtpDepartment.Value.Date;

                    AddEmployee();
                    if (iReturnEmployeeID > 0)
                    {
                        AddSalaryLogOfEmployee(iReturnEmployeeID);
                        AddDepartmentLogOfEmployee(iReturnEmployeeID);
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedEmployee > 0)
            {
                dsEmployee.RejectChanges();
                LoadCurrentEmployee();
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Refresh();
            check = false;
            employeeDO = new EmployeeDO();

            //Lấy danh sách các phòng ban, chức vụ trong công ty
            PopulateDepartmentAndPositionCombos();
            PopulateContractCombo();
            PopulateHospitalCombos();
            mtgcComboFixSalary.DataSource = null;

            txtBasicSalary.Prefix = "";
            txtBasicSalary.MaxDecimalPlaces = 0;
            txtLunchAllowance.Prefix = "";
            txtLunchAllowance.MaxDecimalPlaces = 0;
            txtPositionAllowance.Prefix = "";
            txtPositionAllowance.MaxDecimalPlaces = 0;
            txtJobAllowance.Prefix = "";
            txtJobAllowance.MaxDecimalPlaces = 0;
            txtIntimateAllowance.Prefix = "";
            txtIntimateAllowance.MaxDecimalPlaces = 0;
            txtTaskAllowance.Prefix = "";
            txtTaskAllowance.MaxDecimalPlaces = 0;
            txtJapaneseAllowance.Prefix = "";
            txtJapaneseAllowance.MaxDecimalPlaces = 0;



            if (selectedEmployee >= 0)
            {
                // Hiển thị thông nhân viên
                LoadCurrentEmployee();
            }
            else
            {
                //this.Text = "Thêm nhân viên mới";
                label10.Visible = false;
                btnFirst.Visible = false;
                btnPrevious.Visible = false;
                btnNext.Visible = false;
                btnLast.Visible = false;
                txtRecordNum.Visible = false;
                cboGender.SelectedIndex = 0;
                cboContract.SelectedIndex = 0;
                dtpStopDate.Visible = false;
                dtpChangePosition.Enabled = false;
                dtpDepartment.Enabled = false;

                lblBarCode.Visible = false;
                txtBarcode.Visible = false;
                cboNationality.SelectedIndex = 0;
                cboReligious.SelectedIndex = 0;
                cboPeople.SelectedIndex = 0;
                dtpDateOfBirth.Value = DateTime.Now.AddYears(-20);
                dtpIssue.Value = DateTime.Now.AddYears(-4);

            }
            this.ActiveControl = txtEmployeeName;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            selectedEmployee = 0;
            LoadCurrentEmployee();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (selectedEmployee > 0)
            {
                selectedEmployee -= 1;
                LoadCurrentEmployee();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedEmployee < dsEmployee.Tables[0].Rows.Count - 1)
            {
                selectedEmployee += 1;
                LoadCurrentEmployee();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            selectedEmployee = dsEmployee.Tables[0].Rows.Count - 1;
            LoadCurrentEmployee();
        }
        #endregion

        #region Tap Thông tin chung
        private void txtEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            ValidateNullTextBox(txtEmployeeName);
        }

        private void txtCardID_Validating(object sender, CancelEventArgs e)
        {
            ValidateNullTextBox(txtCardID);
        }

        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDateOfBirth.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpDateOfBirth, "Ngày sinh phải nhỏ hơn ngày hiện tại");
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All File|*.*|Bitmaps|*.bmp|Jpeg|*.jpg|Gif|*.gif";
            ofd.InitialDirectory = WorkingContext.Setting.PicturePath;
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string PictureFilePath = ofd.FileName;
                PictureFileName = Path.GetFileName(PictureFilePath);
                //File.Move(PictureFilePath, WorkingContext.Setting.PicturePath);
                try
                {
                    if (!File.Exists(PictureFilePath))
                        File.Copy(PictureFilePath, WorkingContext.Setting.PicturePath + "\\" + PictureFileName, true);
                    picEmployee.Image = Image.FromFile(PictureFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ảnh được chọn đang được sử dụng bởi chương trình khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //picEmployee.Image = Image.FromFile(WorkingContext.Setting.PicturePath + "/noimage3.jpg");
                }
            }
        }

        private void dtpIssue_Validating(object sender, CancelEventArgs e)
        {
            if ((dtpIssue.Value > DateTime.Now) || (dtpIssue.Value < dtpDateOfBirth.Value))
            {
                errorProvider1.SetError(dtpIssue, "Ngày cấp CMND phải nhỏ hơn ngày hiện tại và lớn hơn ngày sinh");
            }
            else
            {
                errorProvider1.SetError(dtpIssue, String.Empty);
            }
        }
        #endregion

        #region Tap Lương tuyển dụng
        private void label8_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Checked)
                dtpStartDate.Enabled = true;
            else dtpStartDate.Enabled = false;
        }

        private void label5_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Checked)
                dtpStartTrial.Enabled = true;
            else dtpStartTrial.Enabled = false;
        }

        private void cboContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ContractID = Convert.ToInt16(((MTGCComboBoxItem)cboContract.SelectedItem).Col1);
            mtgcComboFixSalary.DataSource = null;
            mtgcComboFixSalary.Items.Clear();
            mtgcComboFixSalary.Text = string.Empty;
            initComboFixSalary(ContractID);
        }

        private void btnChangeSalary_EnabledChanged(object sender, EventArgs e)
        {
            isSalaryChanged = !btnChangeSalary.Enabled;
        }

        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            txtSalaryDN.Enabled = true;
            txtSalaryNote.Enabled = true;
            dtpSalaryChangedDay.Enabled = true;
            btnChangeSalary.Enabled = false;
            txtSalaryDN.Focus();
        }

        private void mnuEditSalaryHistory_Click(object sender, EventArgs e)
        {
            EditSelectedSalaryHistory();
        }

        private void mnuDeleteSalaryHistory_Click(object sender, EventArgs e)
        {
            DeleteSelectedSalaryHistory();
        }

        private void chkStopWork_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStopWork.Checked)
                dtpStopWork.Enabled = true;
            else
                dtpStopWork.Enabled = false;
        }
        #endregion

        #region Tap Bộ phận và vị trí
        private void btnChangeDepartment_Click(object sender, EventArgs e)
        {
            txtDepartmentDN.Enabled = true;
            txtDepartmentNote.Enabled = true;
            dtpDepartment.Enabled = true;
            btnChangeDepartment.Enabled = false;
            txtDepartmentDN.Focus();
        }

        private void btnChangeDepartment_EnabledChanged(object sender, EventArgs e)
        {
            isDepartmentChanged = !btnChangeDepartment.Enabled;
        }

        private void mnuEditDepartmentHistory_Click(object sender, EventArgs e)
        {
            EditSelectedDepartmentHistory();
        }

        private void mnuDeleteDepartmentHistory_Click(object sender, EventArgs e)
        {
            DeleteSelectedDepartmentHistory();
        }

        private void btnChangePosition_EnabledChanged(object sender, EventArgs e)
        {
            isPositionChanged = !btnChangePosition.Enabled;
        }

        private void btnChangePosition_Click(object sender, EventArgs e)
        {
            txtPositionDN.Enabled = true;
            txtPositionNote.Enabled = true;
            dtpChangePosition.Enabled = true;
            btnChangePosition.Enabled = false;
            txtPositionDN.Focus();
        }

        private void mnuEditPositionHistory_Click(object sender, EventArgs e)
        {
            EditSelectedPositionHistory();
        }

        private void mnuDeletePositionHistory_Click(object sender, EventArgs e)
        {
            DeleteSelectedPositionHistory();
        }
        #endregion        
        #endregion
    }
}