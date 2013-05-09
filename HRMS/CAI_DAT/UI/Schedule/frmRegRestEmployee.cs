//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: quandh 24/11/2006
//Note		: Đăng ký nhân viên nghỉ, sau khi nhấn Enter không được chuyển sang phòng khác
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using System.Data.SqlClient;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Form đăng ký nghỉ cho nhân viên
    /// </summary>
    public class frmRegRestEmployee : Form
    {
        #region Window Form generated code

        public frmRegRestEmployee()
        {
            InitializeComponent();
        }

        private Button btnClose;
        private Button btnSave;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnHelp;
        private IContainer components;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private TextBox txtRestReason;
        private GroupBox grbDepartment;
        private MTGCComboBox cboEmployeeName;
        private GroupBox grbRegRestInfo;
        private MTGCComboBox cboDayName;
        private GroupBox groupBox1;
        private RadioButton radioFullDay;
        private RadioButton radioChieu;
        private TextBox txtNameChild;
        private Label lbNameChild;
        private RadioButton radioSang;
        private DepartmentTreeView departmentTreeView;

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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegRestEmployee));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtRestReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.cboEmployeeName = new MTGCComboBox();
            this.grbRegRestInfo = new System.Windows.Forms.GroupBox();
            this.txtNameChild = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSang = new System.Windows.Forms.RadioButton();
            this.radioFullDay = new System.Windows.Forms.RadioButton();
            this.radioChieu = new System.Windows.Forms.RadioButton();
            this.lbNameChild = new System.Windows.Forms.Label();
            this.cboDayName = new MTGCComboBox();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.grbRegRestInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(461, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(381, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "&Đồng ý";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(86, 94);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(86, 69);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txtRestReason
            // 
            this.txtRestReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestReason.Location = new System.Drawing.Point(9, 219);
            this.txtRestReason.Multiline = true;
            this.txtRestReason.Name = "txtRestReason";
            this.txtRestReason.Size = new System.Drawing.Size(303, 157);
            this.txtRestReason.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Lý do nghỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kiểu ngày nghỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày kết thúc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ngày bắt đầu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Location = new System.Drawing.Point(5, 398);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 48;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeView.DepartmentDataSet = null;
            this.departmentTreeView.ImageIndex = 0;
            this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.SelectedImageIndex = 0;
            this.departmentTreeView.Size = new System.Drawing.Size(186, 360);
            this.departmentTreeView.TabIndex = 50;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // cboEmployeeName
            // 
            this.cboEmployeeName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboEmployeeName.ColumnNum = 3;
            this.cboEmployeeName.ColumnWidth = "0;50;120";
            this.cboEmployeeName.DisplayMember = "Text";
            this.cboEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmployeeName.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboEmployeeName.DropDownForeColor = System.Drawing.Color.Black;
            this.cboEmployeeName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboEmployeeName.DropDownWidth = 200;
            this.cboEmployeeName.GridLineColor = System.Drawing.Color.LightGray;
            this.cboEmployeeName.GridLineHorizontal = true;
            this.cboEmployeeName.GridLineVertical = true;
            this.cboEmployeeName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboEmployeeName.Location = new System.Drawing.Point(86, 17);
            this.cboEmployeeName.ManagingFastMouseMoving = true;
            this.cboEmployeeName.ManagingFastMouseMovingInterval = 30;
            this.cboEmployeeName.Name = "cboEmployeeName";
            this.cboEmployeeName.Size = new System.Drawing.Size(226, 21);
            this.cboEmployeeName.TabIndex = 0;
            this.cboEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cboEmployeeName_SelectedIndexChanged);
            // 
            // grbRegRestInfo
            // 
            this.grbRegRestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRegRestInfo.Controls.Add(this.txtNameChild);
            this.grbRegRestInfo.Controls.Add(this.groupBox1);
            this.grbRegRestInfo.Controls.Add(this.lbNameChild);
            this.grbRegRestInfo.Controls.Add(this.cboDayName);
            this.grbRegRestInfo.Controls.Add(this.label4);
            this.grbRegRestInfo.Controls.Add(this.label5);
            this.grbRegRestInfo.Controls.Add(this.txtRestReason);
            this.grbRegRestInfo.Controls.Add(this.dtpStartDate);
            this.grbRegRestInfo.Controls.Add(this.dtpEndDate);
            this.grbRegRestInfo.Controls.Add(this.cboEmployeeName);
            this.grbRegRestInfo.Controls.Add(this.label1);
            this.grbRegRestInfo.Controls.Add(this.label2);
            this.grbRegRestInfo.Controls.Add(this.label3);
            this.grbRegRestInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbRegRestInfo.Location = new System.Drawing.Point(218, 8);
            this.grbRegRestInfo.Name = "grbRegRestInfo";
            this.grbRegRestInfo.Size = new System.Drawing.Size(318, 384);
            this.grbRegRestInfo.TabIndex = 52;
            this.grbRegRestInfo.TabStop = false;
            this.grbRegRestInfo.Text = "Thông tin đăng ký nghỉ";
            // 
            // txtNameChild
            // 
            this.txtNameChild.Location = new System.Drawing.Point(86, 119);
            this.txtNameChild.Name = "txtNameChild";
            this.txtNameChild.Size = new System.Drawing.Size(226, 20);
            this.txtNameChild.TabIndex = 4;
            this.txtNameChild.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSang);
            this.groupBox1.Controls.Add(this.radioFullDay);
            this.groupBox1.Controls.Add(this.radioChieu);
            this.groupBox1.Location = new System.Drawing.Point(9, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 46);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian nghỉ";
            // 
            // radioSang
            // 
            this.radioSang.AutoSize = true;
            this.radioSang.Location = new System.Drawing.Point(75, 15);
            this.radioSang.Name = "radioSang";
            this.radioSang.Size = new System.Drawing.Size(50, 17);
            this.radioSang.TabIndex = 0;
            this.radioSang.Text = "Sáng";
            this.radioSang.UseVisualStyleBackColor = true;
            // 
            // radioFullDay
            // 
            this.radioFullDay.AutoSize = true;
            this.radioFullDay.Location = new System.Drawing.Point(229, 15);
            this.radioFullDay.Name = "radioFullDay";
            this.radioFullDay.Size = new System.Drawing.Size(64, 17);
            this.radioFullDay.TabIndex = 2;
            this.radioFullDay.Text = "Cả ngày";
            this.radioFullDay.UseVisualStyleBackColor = true;
            // 
            // radioChieu
            // 
            this.radioChieu.AutoSize = true;
            this.radioChieu.Location = new System.Drawing.Point(153, 15);
            this.radioChieu.Name = "radioChieu";
            this.radioChieu.Size = new System.Drawing.Size(52, 17);
            this.radioChieu.TabIndex = 1;
            this.radioChieu.Text = "Chiều";
            this.radioChieu.UseVisualStyleBackColor = true;
            // 
            // lbNameChild
            // 
            this.lbNameChild.Location = new System.Drawing.Point(8, 118);
            this.lbNameChild.Name = "lbNameChild";
            this.lbNameChild.Size = new System.Drawing.Size(88, 23);
            this.lbNameChild.TabIndex = 56;
            this.lbNameChild.Text = "Họ tên con";
            this.lbNameChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNameChild.Visible = false;
            // 
            // cboDayName
            // 
            this.cboDayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDayName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboDayName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboDayName.ColumnNum = 3;
            this.cboDayName.ColumnWidth = "60;120;0";
            this.cboDayName.DisplayMember = "Text";
            this.cboDayName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDayName.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboDayName.DropDownForeColor = System.Drawing.Color.Black;
            this.cboDayName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboDayName.DropDownWidth = 200;
            this.cboDayName.GridLineColor = System.Drawing.Color.LightGray;
            this.cboDayName.GridLineHorizontal = false;
            this.cboDayName.GridLineVertical = false;
            this.cboDayName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboDayName.Location = new System.Drawing.Point(86, 42);
            this.cboDayName.ManagingFastMouseMoving = true;
            this.cboDayName.ManagingFastMouseMovingInterval = 30;
            this.cboDayName.Name = "cboDayName";
            this.cboDayName.Size = new System.Drawing.Size(226, 21);
            this.cboDayName.TabIndex = 1;
            this.cboDayName.SelectedIndexChanged += new System.EventHandler(this.cboDayName_SelectedIndexChanged);
            // 
            // grbDepartment
            // 
            this.grbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grbDepartment.Controls.Add(this.departmentTreeView);
            this.grbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDepartment.Location = new System.Drawing.Point(8, 8);
            this.grbDepartment.Name = "grbDepartment";
            this.grbDepartment.Size = new System.Drawing.Size(202, 384);
            this.grbDepartment.TabIndex = 53;
            this.grbDepartment.TabStop = false;
            this.grbDepartment.Text = "Danh sách phòng ban";
            // 
            // frmRegRestEmployee
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(548, 433);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.grbRegRestInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegRestEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký nghỉ cho nhân viên";
            this.Load += new System.EventHandler(this.frmRegRestEmployee_Load);
            this.grbRegRestInfo.ResumeLayout(false);
            this.grbRegRestInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDepartment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Danh sách các biến
        private DepartmentDO departmentDO = null;
        private RegRestEmployeeDO regRestEmployeeDO = null;
        private DataSet dsEmployee = null;
        private DataTable dtRegRestEmployee = null;
        private DataTable tblTimeInTimeOut = null;
        private DataTable tblCheckInCheckOut = null;

        private int iEmployeeID;
        private int iDayIdBeforeUpdate;
        private DateTime dtStartRestBeforeUpdate;
        private DateTime dtEndRestBeforeUpdate;
        private float fNumDayBeforeUpdate = -1;
        private int iDayID;
        private float fNumDay = -1;
        private float fTotalRestAllow = 0.0f;
        private float fTotalRestRemain = 0.0f;
        #endregion

        #region Các thuộc tính
        private DataSet dsRegRestEmployee = null;
        public DataSet RestEmployeeDataSet
        {
            get { return dsRegRestEmployee; }
            set { dsRegRestEmployee = value; }
        }

        private int selectedRestEmployee = -1;
        public int CurrentRestEmployee
        {
            get { return selectedRestEmployee; }
            set { selectedRestEmployee = value; }
        }

        private bool update;
        public bool UPDATE
        {
            set { update = value; }
        }

        private int result;
        public int Result
        {
            set { result = value; }
            get { return result; }
        }
        #endregion

        #region Các hàm khai báo
        #region Kiểm tra
        /// <summary>
        /// Kiểm tra xem ngày đăng ký nghỉ có trùng với ngày dập thẻ 
        /// </summary>
        /// <param name="iEmployeeID"></param>
        /// <param name="dtWorkingDay"></param>
        /// <returns></returns>
        private string KiemTraRangBuocVoiThoiGianQuetThe()
        {
            string strKiemTraPri = string.Empty;
            int iTimeInPri = 0;
            int iTimeOutPri = 0;
            int iCheckOutPri = 0;
            int iShiftIDPri = 0;
            DateTime dtStartTimePri = dtpStartDate.Value.Date;

            while (dtStartTimePri <= dtpEndDate.Value.Date)
            {
                tblTimeInTimeOut = regRestEmployeeDO.GetTimeInTimeOutInDay(iEmployeeID, dtStartTimePri);
                if (tblTimeInTimeOut.Rows.Count > 0)
                {
                    //Lấy thời gian dập thẻ đến và về
                    if (tblTimeInTimeOut.Rows[0]["TimeIn"] != DBNull.Value)
                        iTimeInPri = Convert.ToDateTime(tblTimeInTimeOut.Rows[0]["TimeIn"]).Hour;
                    if (tblTimeInTimeOut.Rows[0]["TimeOut"] != DBNull.Value)
                        iTimeOutPri = Convert.ToDateTime(tblTimeInTimeOut.Rows[0]["TimeOut"]).Hour;

                    if (!radioSang.Enabled && !radioChieu.Enabled && !radioFullDay.Enabled)
                    {
                        if (iTimeInPri != 0 || iTimeOutPri != 0)
                        {
                            strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_Mess"), dtStartTimePri.ToString("dd/MM/yyyy"));
                            break;
                        }
                    }
                    else
                    {
                        tblCheckInCheckOut = regRestEmployeeDO.GetCheckInCheckOutInDay(iEmployeeID, dtStartTimePri);
                        if (tblCheckInCheckOut.Rows.Count > 0)
                        {
                            if (tblCheckInCheckOut.Rows[0]["CheckOut"] != DBNull.Value)
                            {
                                iCheckOutPri = Convert.ToDateTime(tblCheckInCheckOut.Rows[0]["CheckOut"]).Hour;
                            }
                            if (tblCheckInCheckOut.Rows[0]["ShiftID"] != DBNull.Value)
                            {
                                iShiftIDPri = Convert.ToInt32(tblCheckInCheckOut.Rows[0]["ShiftID"]);
                            }
                        }

                        if (radioFullDay.Checked)
                        {
                            if (iTimeInPri != 0 || iTimeOutPri != 0)
                            {
                                strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_FullDay"), dtStartTimePri.ToString("dd/MM/yyyy"));
                                break;
                            }
                        }

                        if (radioSang.Checked && iShiftIDPri == 45)
                        {
                            if (iTimeInPri != 0 && iTimeInPri <= iCheckOutPri)
                            {
                                strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_Mess"), dtStartTimePri.ToString("dd/MM/yyyy"));
                                break;
                            }
                            if (iTimeOutPri != 0 && iTimeOutPri >= iCheckOutPri)
                            {
                                strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_Mess"), dtStartTimePri.ToString("dd/MM/yyyy"));
                                break;
                            }
                        }
                        if (radioChieu.Checked && iShiftIDPri == 46)
                        {
                            if (iTimeInPri != 0 && iTimeInPri <= iCheckOutPri)
                            {
                                strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_Mess"), dtStartTimePri.ToString("dd/MM/yyyy"));
                                break;
                            }
                            if (iTimeOutPri != 0 && iTimeOutPri >= iCheckOutPri)
                            {
                                strKiemTraPri = string.Format(WorkingContext.LangManager.GetString("frmRegRestEmployee_Error_Mess"), dtStartTimePri.ToString("dd/MM/yyyy"));
                                break;
                            }
                        }
                    }

                }
                dtStartTimePri = dtStartTimePri.AddDays(1);
            }

            return strKiemTraPri;
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ khi nhập thông tin đăng ký nghỉ
        /// </summary>
        /// <returns>Thông báo lỗi</returns>
        private string ValidateInputData()
        {
            // Kiểm tra chọn nhân viên được đăng ký
            if (cboEmployeeName.Text == "")
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa1");
                return str;
            }

            // Kiểm tra chọn kiểu đăng ký
            if (cboDayName.Text == "")
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa2");
                return str;
            }

            //Kiểm tra chọn ngày đăng ký
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                string str = WorkingContext.LangManager.GetString("frmRegLeaveSchedule_Messa3");
                return str;
            }
            if ((iDayID == 200 || iDayID == 219) && dtpStartDate.Value.Year != dtpEndDate.Value.Year)
            {
                string str = WorkingContext.LangManager.GetString("frmRegRestEmployee_Error4_Messa");
                return str;
            }

            //Kiểm tra chọn thời gian đăng ký (sáng/chiều/cả ngày)
            if (radioSang.Enabled || radioChieu.Enabled || radioFullDay.Enabled)
            {
                if (dtpStartDate.Value.Date != dtpEndDate.Value.Date)
                {
                    if (radioChieu.Checked || radioSang.Checked)
                    {
                        string str = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa7");
                        return str;
                    }
                }

                iDayID = Convert.ToInt32(((MTGCComboBoxItem)cboDayName.SelectedItem).Col3);
                if (iDayID == 219 && (radioFullDay.Checked || dtpStartDate.Value.Date != dtpEndDate.Value.Date))
                {
                    string str = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa12");
                    return str;
                }

                if (!radioChieu.Checked && !radioSang.Checked && !radioFullDay.Checked)
                {
                    string str = "Vui lòng chọn thời gian nghỉ cho nhân viên";
                    return str;
                }
            }

            return "";
        }

        /// <summary>
        /// Kiểm tra đăng ký nghỉ phép
        /// </summary>
        /// <returns></returns>
        private float KiemTraDangKyNghiPhep()
        {
            //Thời gian nghỉ thực tế
            float fCurrentRestPri = regRestEmployeeDO.GetCurrentRest(iEmployeeID, dtpStartDate.Value.Date, dtpEndDate.Value.Date, fNumDay);
            if (fCurrentRestPri == -1)
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRegRestEmployee_Error1_Messa"),
                    WorkingContext.LangManager.GetString("Loi"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            else if (fCurrentRestPri == 0)
            {
                MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRegRestEmployee_Error2_Messa"),
                    WorkingContext.LangManager.GetString("Loi"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            else if (fCurrentRestPri > 0)
            {
                float fOldRestPri = 0.0f; //Thời gian nghỉ phép cũ (!= 0 trong trường hợp cập nhật phép)

                //Thời gian nghỉ cho phép còn lại         
                DataTable tblRestPri = regRestEmployeeDO.GetRestAllow(iEmployeeID, dtpStartDate.Value.Year, DateTime.Now.Month);
                if (tblRestPri != null)
                {
                    fTotalRestAllow = Convert.ToSingle(tblRestPri.Rows[0]["TotalRestAllow"]);
                    fTotalRestRemain = Convert.ToSingle(tblRestPri.Rows[0]["TotalRestRemain"]);
                }

                if (selectedRestEmployee >= 0)
                {
                    if (iDayIdBeforeUpdate == 200 || iDayIdBeforeUpdate == 219)
                    {
                        fOldRestPri = regRestEmployeeDO.GetCurrentRest(iEmployeeID, dtStartRestBeforeUpdate, dtEndRestBeforeUpdate, fNumDayBeforeUpdate);
                    }
                }
                if (fTotalRestRemain - fCurrentRestPri + fOldRestPri < 0)
                {
                    MessageBox.Show(this, WorkingContext.LangManager.GetString("frmRegRestEmployee_Error3_Messa"),
                    WorkingContext.LangManager.GetString("Loi"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 0;
                }
            }
            return 1;
        }
        #endregion

        /// <summary>
        /// Reset nội dung các trường dữ liệu
        /// </summary>
        private void ClearFields()
        {
            cboEmployeeName.SelectedIndex = 0;
            cboDayName.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtRestReason.Text = String.Empty;
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

        /// <summary>
        /// Thiết lập ngôn ngữ hiện thị cho các controls
        /// </summary>
        private void ChangeToCurrentLang()
        {
            this.grbDepartment.Text = WorkingContext.LangManager.GetString("frmRegRest_grpDepartment");
            this.grbRegRestInfo.Text = WorkingContext.LangManager.GetString("frmRegRest_grpRegRestInfo");
            this.label1.Text = WorkingContext.LangManager.GetString("frmRegRest_lable1");
            this.label4.Text = WorkingContext.LangManager.GetString("frmRegRest_lable4");
            this.label2.Text = WorkingContext.LangManager.GetString("frmRegRest_lable2");
            this.label3.Text = WorkingContext.LangManager.GetString("frmRegRest_lable3");
            this.label5.Text = WorkingContext.LangManager.GetString("frmRegRest_lable5");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegRest_btnClose");
            this.btnHelp.Text = WorkingContext.LangManager.GetString("frmRegRest_btnhelp");
            this.btnSave.Text = WorkingContext.LangManager.GetString("frmRegRest_btnSave");
        }
       
        /// <summary>
        /// Hiển thị thông báo lỗi khi đăng ký nghỉ cho nhân viên
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strMess"></param>
        /// <param name="strMess1"></param>
        private void ThongBaoLoiDangKyNghi(int iResultPara, string strMessPara, string strMessTitlePara)
        {
            switch (iResultPara)
            {
                case 2: /*Lỗi đăng ký nghỉ kết hôn trước ngày ký hợp đồng chính thức*/
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa10");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
                case 3: /*Lỗi đăng ký nghỉ phép/kết hôn với nhân viên đang thử việc*/
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa9");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
                case 4: /* Lỗi đăng ký nghỉ công tác/đám ma trước ngày bắt đầu thử việc*/
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa11");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
                case 5: /* Lỗi đăng ký nghỉ trùng với đăng ký lịch công tác */
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa3");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
                case 6: /*Lỗi ngày đăng ký nghỉ phép sau 1 năm ký hợp đồng chính thức*/
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa2");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
                //case 9: /*Lỗi ko cho đăng ký nghỉ phép/kết hôn với nhân viên đang thử việc*/
                //    strMess = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa9");
                //    MessageBox.Show(strMess, strMess1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    dsRegRestEmployee.RejectChanges();
                //    break;
                //case 10:/*Lỗi ko cho đăng ký nghỉ kết hôn trước ngày ký hợp đồng chính thức*/
                //    strMess = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa10");
                //    MessageBox.Show(strMess, strMess1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    dsRegRestEmployee.RejectChanges();
                //    break;
                //case 11:/*Lỗi không cho phép đăng ký công tác/nghỉ đám ma trước ngày bắt đầu thử việc*/
                //    strMess = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa11");
                //    MessageBox.Show(strMess, strMess1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    dsRegRestEmployee.RejectChanges();
                //    break;
                default: /*Lỗi cập nhật cơ sở dữ liệu*/
                    strMessPara = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa5");
                    MessageBox.Show(strMessPara, strMessTitlePara, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsRegRestEmployee.RejectChanges();
                    break;
            }
        }
       
        /// <summary>
        /// Đăng ký nghỉ cho nhân viên
        /// </summary>
        public void RegRestEmployee()
        {
            int iResultPri = 0;
           //string strError = string.Empty;
            string strMessPri = string.Empty;
            string strMessTitlePri = WorkingContext.LangManager.GetString("frmRegRest_DK_Title");
            bool bUpdateRestPri = false;
            DateTime dtStartRestPri = dtpStartDate.Value.Date;
            DateTime dtEndRestPri = dtpEndDate.Value.Date;

            //Lấy EmployeeID
            if (selectedRestEmployee >= 0)
            {
                DataRow drRestPri = dtRegRestEmployee.Rows[selectedRestEmployee];
                if (drRestPri != null)
                {
                    drRestPri = SetRestData(drRestPri);
                    iEmployeeID = Convert.ToInt32(drRestPri["EmployeeID"]);
                    fNumDay = Convert.ToSingle(drRestPri["NumDay"]);
                }
            }
            else
            {
                DataRow drRestPri = dtRegRestEmployee.NewRow();
                dtRegRestEmployee.Rows.Add(SetRestData(drRestPri));
                if (drRestPri != null)
                {
                    iEmployeeID = Convert.ToInt32(drRestPri["EmployeeID"]);
                    fNumDay = Convert.ToSingle(drRestPri["NumDay"]);
                }
            }

            //Kiểm tra số phép còn lại đủ để đăng ký hay không nếu là đăng ký nghỉ phép
            if (iDayID == 200 || iDayID == 219)
            {
                float fKiemTraPri = KiemTraDangKyNghiPhep();
                if (fKiemTraPri == 0)
                {
                    return;
                }
            }

            SqlConnection conn = WorkingContext.GetConnection();
            SqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                #region Thực hiện cập nhật ĐK nghỉ của NV
                if (selectedRestEmployee >= 0)
                {
                    //Cập nhật đăng ký nghỉ
                    iResultPri = regRestEmployeeDO.UpdateRegRestEmployee(dsRegRestEmployee, trans);

                    //Nếu là sửa đổi đăng ký nghỉ phép thì thực hiện cập nhật số ngày nghỉ vào bảng thanh toán tiến phép
                    if (iResultPri == 1 && (iDayIdBeforeUpdate == 200 || iDayIdBeforeUpdate == 219 || iDayID == 200 || iDayID == 219))
                    {
                        //Nếu ngày bắt đầu và ngày kết thúc nghỉ trong cùng 1 tháng thì chỉ thực hiện cập nhật tháng đó
                        if (dtStartRestBeforeUpdate.Month == dtEndRestBeforeUpdate.Month && dtStartRestPri.Month == dtEndRestPri.Month)
                        {
                            bUpdateRestPri = regRestEmployeeDO.UpdateRestSheetEmployee(iEmployeeID, dtStartRestBeforeUpdate, dtEndRestBeforeUpdate,
                                dtStartRestPri, dtEndRestPri, dtStartRestBeforeUpdate, dtStartRestPri, iDayIdBeforeUpdate, iDayID, fTotalRestAllow, trans);
                        }
                        //Ngược lại cập nhật thông tin cho 2 tháng
                        else
                        {
                            bUpdateRestPri = regRestEmployeeDO.UpdateRestSheetEmployee(iEmployeeID, dtStartRestBeforeUpdate, dtEndRestBeforeUpdate, dtStartRestPri,
                                dtEndRestPri, dtStartRestBeforeUpdate, dtStartRestPri, iDayIdBeforeUpdate, iDayID, fTotalRestAllow, trans);

                            bUpdateRestPri = regRestEmployeeDO.UpdateRestSheetEmployee(iEmployeeID, dtStartRestBeforeUpdate, dtEndRestBeforeUpdate, dtStartRestPri,
                                dtEndRestPri, dtEndRestBeforeUpdate, dtEndRestPri, iDayIdBeforeUpdate, iDayID, fTotalRestAllow, trans);
                        }
                    }

                }
                #endregion

                #region Thực hiện thêm mới ĐK nghỉ của NV
                else
                {
                    //Lưu thông tin đăng ký nghỉ
                    iResultPri = regRestEmployeeDO.AddRegRestEmployee(dsRegRestEmployee, trans);

                    //Nếu là đăng ký nghỉ phép thì thực hiện cập nhật số ngày nghỉ vào bảng thanh toán tiền phép
                    if (iResultPri == 1 && (iDayID == 200 || iDayID == 219))
                    {                     
                        //Nếu ngày bắt đầu và ngày kết thúc nghỉ trong cùng 1 tháng thì chỉ thực hiện cập nhật tháng đó
                        if (dtStartRestPri.Month == dtEndRestPri.Month)
                        {
                            bUpdateRestPri = regRestEmployeeDO.AddRestSheetEmployee(iEmployeeID, dtStartRestPri, dtEndRestPri, dtStartRestPri, fNumDay, fTotalRestAllow, trans);
                        }
                        //Ngược lại cập nhật thông tin cho 2 tháng
                        else
                        {
                            bUpdateRestPri = regRestEmployeeDO.AddRestSheetEmployee(iEmployeeID, dtStartRestPri, dtEndRestPri, dtStartRestPri, fNumDay, fTotalRestAllow, trans);
                            bUpdateRestPri = regRestEmployeeDO.AddRestSheetEmployee(iEmployeeID, dtStartRestPri, dtEndRestPri, dtEndRestPri, fNumDay, fTotalRestAllow, trans);
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                trans.Rollback();
                trans.Dispose();

                return;
            }

            bool bResultPri = false; //Kết quả cập nhật vào database
            if (iDayIdBeforeUpdate != 200 && iDayIdBeforeUpdate != 219 && iDayID != 200 && iDayID != 219)
            {
                if (iResultPri == 1)
                {
                    bResultPri = true;
                }
            }
            else
            {
                if (iResultPri == 1 && bUpdateRestPri)
                {
                    bResultPri = true;
                }
            }
            if (bResultPri) /*Đăng ký thành công*/
            {
                trans.Commit();
                trans.Dispose();

                if (selectedRestEmployee >= 0)
                {
                    strMessPri = WorkingContext.LangManager.GetString("frmRegRest_DK_Edit_Successfully");
                }
                else
                {
                    strMessPri = WorkingContext.LangManager.GetString("frmRegRest_DK_Messa1");
                }

                MessageBox.Show(strMessPri, strMessTitlePri, MessageBoxButtons.OK, MessageBoxIcon.Information);

                dsRegRestEmployee.AcceptChanges();

                if (selectedRestEmployee >= 0)
                {
                    this.Close();
                }
                else
                {
                    ClearFields();
                }
            }
            else
            {
                trans.Rollback();
                trans.Dispose();
            }
            //Thông báo nếu có lỗi khi đăng ký nghỉ
            if (iResultPri != 1) 
            {
                ThongBaoLoiDangKyNghi(iResultPri, strMessPri, strMessTitlePri);
            }

            result = iResultPri;
        }

        /// <summary>
        /// Thiết lập dữ liệu đăng ký nghỉ của nhân viên
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private DataRow SetRestData(DataRow dr)
        {
            dr.BeginEdit();
            if (selectedRestEmployee < 0 && cboEmployeeName.SelectedIndex >= 0) //chế độ thêm mới
            {
                dr["EmployeeID"] = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col1;
            }
            dr["DayID"] = ((MTGCComboBoxItem)cboDayName.SelectedItem).Col3;
            iDayID = Convert.ToInt32(((MTGCComboBoxItem)cboDayName.SelectedItem).Col3);
            dr["StartRest"] = dtpStartDate.Value.Date;
            dr["EndRest"] = dtpEndDate.Value.Date;
            dr["RestReason"] = txtRestReason.Text;
            dr["NameChild"] = txtNameChild.Text;
            dr["NumDay"] = (decimal)1;
            dr["TypeRest"] = DBNull.Value;

            if (radioSang.Checked)
            {
                dr["NumDay"] = (decimal)0.5;
                dr["TypeRest"] = true;
            }
            if (radioChieu.Checked)
            {
                dr["NumDay"] = (decimal)0.5;
                dr["TypeRest"] = false;
            }
            dr.EndEdit();
            return dr;
        }

        /// <summary>
        /// Lấy danh sách kiểu đăng ký nghỉ
        /// </summary>
        private void PopulateDayTypeCombo()
        {
            DayTypeDO dayTypeDO = new DayTypeDO();
            DataTable dtDayType = dayTypeDO.GetDayType().Tables[0];
            cboDayName.SourceDataString = new string[] { "DayShortName", "DayName", "DayID" };
            cboDayName.SourceDataTable = dtDayType;
        }

        /// <summary>
        /// Hiển thị thông tin đăng ký nghỉ khi cập nhật ĐK nghỉ
        /// </summary>
        private void LoadRestData()
        {
            DataRow dr = dtRegRestEmployee.Rows[selectedRestEmployee];
            if (dr != null)
            {
                cboEmployeeName.Text = dr["CardID"].ToString();
                cboDayName.Text = dr["DayName"].ToString();
                dtpStartDate.Value = DateTime.Parse(dr["StartRest"].ToString());
                dtpEndDate.Value = DateTime.Parse(dr["EndRest"].ToString());
                txtRestReason.Text = dr["RestReason"].ToString();
                if (dr["NumDay"] != DBNull.Value)
                {
                    string thu = dr["NumDay"].ToString();
                    Decimal Dc = Convert.ToDecimal(dr["NumDay"].ToString());
                    if (Dc == (decimal)0.5)
                    {
                        if (Convert.ToBoolean(dr["TypeRest"]))
                            radioSang.Checked = true;
                        else
                            radioChieu.Checked = true;
                    }
                    else
                    {
                        radioFullDay.Checked = true;
                    }
                }
                else radioFullDay.Checked = true;
                //Kieu ngay nghi la nghi trong con om
                if (Convert.ToInt32(dr["DayID"].ToString()) == 193)
                {
                    RegRestEmployeeDO regRestEmployeeDO = new RegRestEmployeeDO();
                    DataSet dsNameChild = regRestEmployeeDO.GetChildName(Convert.ToInt32(dr["RegRestID"].ToString()));
                    if (dsNameChild.Tables.Count > 0)
                        if (dsNameChild.Tables[0].Rows.Count > 0)
                            txtNameChild.Text = dsNameChild.Tables[0].Rows[0][0].ToString();
                        else txtNameChild.Text = "";
                }
            }
        }
        #endregion

        #region Các hàm sự kiện
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa3");
            string str1 = WorkingContext.LangManager.GetString("frmRegRest_DK_Title");
            MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmRegRestEmployee_Load(object sender, EventArgs e)
        {
            Refresh();
            departmentDO = new DepartmentDO();
            departmentTreeView.DepartmentDataSet = departmentDO.GetAllDepartments();
            departmentTreeView.BuildTree();
            departmentTreeView.SelectedNode = departmentTreeView.TopNode;

            departmentTreeView.ExpandNodes(true);

            regRestEmployeeDO = new RegRestEmployeeDO();
            dtRegRestEmployee = dsRegRestEmployee.Tables[0];

            PopulateDayTypeCombo();

            if (selectedRestEmployee >= 0) /*Load dữ liệu lên các control khi thực hiện sửa đổi*/
            {
                string str = WorkingContext.LangManager.GetString("frmRegRest_Text2");
                this.Text = str;
                LoadRestData();
                cboEmployeeName.Enabled = false;
                departmentTreeView.Enabled = false;

                //Lưu lại thông tin ngày đăng ký nghỉ, kiểu ngày nghỉ trước khi cập nhật
                if (dtRegRestEmployee.Rows[selectedRestEmployee]["NumDay"] != DBNull.Value)
                {
                    fNumDayBeforeUpdate = Convert.ToSingle(dtRegRestEmployee.Rows[selectedRestEmployee]["NumDay"]);
                }
                iDayIdBeforeUpdate = Convert.ToInt32(dtRegRestEmployee.Rows[selectedRestEmployee]["DayID"]);
                dtStartRestBeforeUpdate = Convert.ToDateTime(dtRegRestEmployee.Rows[selectedRestEmployee]["StartRest"]);
                dtEndRestBeforeUpdate = Convert.ToDateTime(dtRegRestEmployee.Rows[selectedRestEmployee]["EndRest"]);
            }
            else
            {
                string str1 = WorkingContext.LangManager.GetString("frmRegRest_Text1");
                this.Text = str1;
            }
        }

        private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            departmentTreeView.ExpandNodes(true);
            cboEmployeeName.Items.Clear();
            EmployeeDO employeeDO = new EmployeeDO();
            dsEmployee = employeeDO.GetEmployeeByDepartment((int)e.Node.Tag);
            cboEmployeeName.SourceDataString = new string[] { "EmployeeID", "CardID", "EmployeeName" };
            cboEmployeeName.SourceDataTable = dsEmployee.Tables[0];

            // kiểm tra nếu phòng có nhân viên thì hiển thị thông tin của nhân viên đầu tiên
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                cboEmployeeName.SelectedIndex = 0;
                cboEmployeeName.Text = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3;
            }
            else
            {
                cboEmployeeName.Items.Clear();
                cboEmployeeName.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            string strErrorMessagePri = ValidateInputData();
            if (strErrorMessagePri != "")
            {
                MessageBox.Show(this, strErrorMessagePri,
                    WorkingContext.LangManager.GetString("frmRegRest_DK_Messa6"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Kiểm tra ràng buộc thời gian quẹt thẻ
            //strErrorMessagePri = KiemTraRangBuocVoiThoiGianQuetThe();
            //if (strErrorMessagePri != "")
            //{
            //    MessageBox.Show(this, strErrorMessagePri,
            //        WorkingContext.LangManager.GetString("frmRegRest_DK_Messa6"),
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            /*Thực hiện lưu thông tin đăng ký nghỉ*/
            RegRestEmployee();
            if (update && result == 1)
            {
                this.Close();
            }
        }

        private void cboDayName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDayName.SourceDataTable.Rows.Count > 0)
            {
                int dayID = Convert.ToInt32(((MTGCComboBoxItem)cboDayName.SelectedItem).Col3);
                if (dayID == 193)
                {
                    lbNameChild.Visible = true;
                    txtNameChild.Visible = true;
                }
                else
                {
                    lbNameChild.Visible = false;
                    txtNameChild.Visible = false;
                }
            }
        }

        private void cboEmployeeName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboEmployeeName.SelectedIndex != -1)
            {
                string comboName = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3;
                cboEmployeeName.Text = comboName;
                iEmployeeID = Convert.ToInt32(((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col1);
            }
        }
        
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date != dtpEndDate.Value.Date)
            {
                if (radioSang.Checked)
                {
                    radioSang.Checked = false;
                }
                else if (radioChieu.Checked)
                {
                    radioChieu.Checked = false;
                }
                else if (radioFullDay.Checked)
                {
                    radioFullDay.Checked = false;
                }

                radioSang.Enabled = false;
                radioChieu.Enabled = false;
                radioFullDay.Enabled = false;
            }
            else
            {
                radioSang.Enabled = true;
                radioChieu.Enabled = true;
                radioFullDay.Enabled = true;
            }
        }
        #endregion
    }
}