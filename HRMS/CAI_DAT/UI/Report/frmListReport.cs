//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	
//Note	    :		  
//Author	: 
//Modify	: quandh 29/11/2006
//Note		: Them bao cao tong xuat an lam them cua tung ngay
//------------------------------------------------------------------------------------

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Reports;
using EVSoft.HRMS.Reports_JP;
using WaitingForm;
using System.IO;



namespace EVSoft.HRMS.UI.Report
{
    /// <summary>
    /// Summary description for frmListReport.
    /// </summary>
    public class frmListReport : System.Windows.Forms.Form
    {
        Database crDatabase;
        Tables crTables;
        TableLogOnInfo crTableLogOnInfo;
        ConnectionInfo crConnectioninfo;
        private ModuleSettings settings;
        private string reportName = "test";
        private DateTime reportDate = DateTime.Now;

        private System.Windows.Forms.ListBox lstGroupReport;
        private System.Windows.Forms.ListBox lstDetailReport;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.GroupBox grbPhamVi;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optGlobal;
        private System.Windows.Forms.RadioButton optLocal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private int t;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmListReport()
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListReport));
            this.lstGroupReport = new System.Windows.Forms.ListBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lstDetailReport = new System.Windows.Forms.ListBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbPhamVi = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.optGlobal = new System.Windows.Forms.RadioButton();
            this.optLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbPhamVi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroupReport
            // 
            this.lstGroupReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstGroupReport.BackColor = System.Drawing.SystemColors.Info;
            this.lstGroupReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstGroupReport.ItemHeight = 15;
            this.lstGroupReport.Items.AddRange(new object[] {
            "Báo cáo nhân sự",
            "Báo cáo chấm công",
            "Báo cáo lương",
            "Báo cáo thưởng phạt",
            "Báo cáo BHXH"});
            this.lstGroupReport.Location = new System.Drawing.Point(8, 16);
            this.lstGroupReport.Name = "lstGroupReport";
            this.lstGroupReport.Size = new System.Drawing.Size(176, 244);
            this.lstGroupReport.TabIndex = 0;
            this.lstGroupReport.SelectedIndexChanged += new System.EventHandler(this.lstGroupReport_SelectedIndexChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(8, 40);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(112, 20);
            this.dtpFromDate.TabIndex = 6;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(176, 40);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(112, 20);
            this.dtpToDate.TabIndex = 7;
            // 
            // lstDetailReport
            // 
            this.lstDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDetailReport.BackColor = System.Drawing.Color.GhostWhite;
            this.lstDetailReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstDetailReport.ItemHeight = 15;
            this.lstDetailReport.Location = new System.Drawing.Point(8, 16);
            this.lstDetailReport.Name = "lstDetailReport";
            this.lstDetailReport.Size = new System.Drawing.Size(280, 244);
            this.lstDetailReport.TabIndex = 8;
            this.lstDetailReport.DoubleClick += new System.EventHandler(this.lstDetailReport_DoubleClick);
            this.lstDetailReport.SelectedIndexChanged += new System.EventHandler(this.lstDetailReport_SelectedIndexChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Location = new System.Drawing.Point(8, 344);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(99, 23);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Xem lại báo cáo";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnView.Location = new System.Drawing.Point(350, 344);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(430, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbPhamVi
            // 
            this.grbPhamVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbPhamVi.Controls.Add(this.cboDepartment);
            this.grbPhamVi.Controls.Add(this.optGlobal);
            this.grbPhamVi.Controls.Add(this.optLocal);
            this.grbPhamVi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbPhamVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbPhamVi.Location = new System.Drawing.Point(8, 264);
            this.grbPhamVi.Name = "grbPhamVi";
            this.grbPhamVi.Size = new System.Drawing.Size(192, 72);
            this.grbPhamVi.TabIndex = 20;
            this.grbPhamVi.TabStop = false;
            this.grbPhamVi.Text = "Phạm vi";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Enabled = false;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboDepartment.ItemHeight = 13;
            this.cboDepartment.Location = new System.Drawing.Point(8, 40);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(176, 21);
            this.cboDepartment.TabIndex = 2;
            // 
            // optGlobal
            // 
            this.optGlobal.Checked = true;
            this.optGlobal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optGlobal.Location = new System.Drawing.Point(8, 16);
            this.optGlobal.Name = "optGlobal";
            this.optGlobal.Size = new System.Drawing.Size(72, 24);
            this.optGlobal.TabIndex = 0;
            this.optGlobal.TabStop = true;
            this.optGlobal.Text = "Toàn thể";
            this.optGlobal.CheckedChanged += new System.EventHandler(this.optToanThe_CheckedChanged);
            // 
            // optLocal
            // 
            this.optLocal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optLocal.Location = new System.Drawing.Point(112, 16);
            this.optLocal.Name = "optLocal";
            this.optLocal.Size = new System.Drawing.Size(72, 24);
            this.optLocal.TabIndex = 1;
            this.optLocal.Text = "Bộ phận";
            this.optLocal.CheckedChanged += new System.EventHandler(this.optBoPhan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(208, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 72);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian";
            // 
            // lblToDate
            // 
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblToDate.Location = new System.Drawing.Point(176, 16);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(112, 21);
            this.lblToDate.TabIndex = 8;
            this.lblToDate.Text = "Đến ngày";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFromDate.Location = new System.Drawing.Point(8, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(112, 21);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "Từ ngày";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstGroupReport);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 264);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhóm báo cáo";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstDetailReport);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(208, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 264);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo cáo chi tiết";
            // 
            // frmListReport
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbPhamVi);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách báo cáo";
            this.Load += new System.EventHandler(this.frmListReport_Load);
            this.grbPhamVi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public override void Refresh()
        {
            ChangeToCurrentLang();

            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();
            lstGroupReport.SelectedIndex = 0;
        }

        private void ChangeToCurrentLang()
        {
            this.Text = WorkingContext.LangManager.GetString("frmListReport_Text");
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListReport_groupbox1");
            this.groupBox2.Text = WorkingContext.LangManager.GetString("frmListReport_groupbox2");
            this.groupBox3.Text = WorkingContext.LangManager.GetString("frmListReport_groupbox3");
            string str1 = WorkingContext.LangManager.GetString("frmListReport_baocaonhansu");
            string str2 = WorkingContext.LangManager.GetString("frmListReport_baocaochamcong");
            string str3 = WorkingContext.LangManager.GetString("frmListReport_baocaoluong");
            string str4 = WorkingContext.LangManager.GetString("frmListReport_baocaothuongphat");
            string str5 = WorkingContext.LangManager.GetString("frmListReport_bhxh");

            this.lstGroupReport.Items.Clear();
            this.lstGroupReport.Items.AddRange(new object[] {
																str1,
																str2,
																str3,
																str4,
																str5});
            this.optGlobal.Text = WorkingContext.LangManager.GetString("frmListReport_grpPhamVi_optGlobal");
            this.optLocal.Text = WorkingContext.LangManager.GetString("frmListReport_grpPhamVi_optLocal");
            this.lblFromDate.Text = WorkingContext.LangManager.GetString("frmListReport_groupbox1_lblFromDate");
            this.lblToDate.Text = WorkingContext.LangManager.GetString("frmListReport_groupbox1_lblToDate");
            this.btnHelp.Text = WorkingContext.LangManager.GetString("frmListReport_btnHelp");
            this.btnView.Text = WorkingContext.LangManager.GetString("frmListReport_btnView");
            this.btnExit.Text = WorkingContext.LangManager.GetString("frmListReport_btnExit");
            this.grbPhamVi.Text = WorkingContext.LangManager.GetString("frmListReport_grpPhamVi");
            switch (t)
            {
                case 0: 	// bao cao nhan su
                    this.lstDetailReport.Items.Clear();
                    string str31 = WorkingContext.LangManager.GetString("frmListReport_1");
                    string str = WorkingContext.LangManager.GetString("frmListReport_NVN");
                    string str32 = WorkingContext.LangManager.GetString("frmListReport_2");
                    string str33 = WorkingContext.LangManager.GetString("frmListReport_3");
                    string str34 = WorkingContext.LangManager.GetString("frmListReport_4");
                    string str35 = WorkingContext.LangManager.GetString("frmListReport_5");
                    string str66 = WorkingContext.LangManager.GetString("Bosung5_1");
                    string str7 = WorkingContext.LangManager.GetString("frmListReport_7");
                    string str8 = WorkingContext.LangManager.GetString("frmListReport_8");
                    string str9 = WorkingContext.LangManager.GetString("frmListReport_9");
                    string str23 = WorkingContext.LangManager.GetString("frmListReport_23");
                    string str24 = WorkingContext.LangManager.GetString("frmListReport_24");
                    string str25 = WorkingContext.LangManager.GetString("frmListReport_25");
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str31,	
																		 str,
																		 str32,
																		 str33,
																		 str34,
																		 str35,
																		 str66,
																		 str7,
																		 str8,
																		 str9,
																		 str23,
																		 str24,
																		 str25	});
                    break;
                case 1:// bao cao cham cong
                    this.lstDetailReport.Items.Clear();
                    string str10 = WorkingContext.LangManager.GetString("frmListReport_10");
                    string str11 = WorkingContext.LangManager.GetString("frmListReport_11");
                    string str12 = WorkingContext.LangManager.GetString("frmListReport_12");
                    string str13 = WorkingContext.LangManager.GetString("frmListReport_13");
                    string str14 = WorkingContext.LangManager.GetString("frmListReport_14");
                    string str15 = WorkingContext.LangManager.GetString("frmListReport_15");
                    string str21 = WorkingContext.LangManager.GetString("frmListReport_21");
                    string str67 = WorkingContext.LangManager.GetString("frmListReport_67");
                    this.lstDetailReport.Items.AddRange(new object[] {  str10,
																		 str11,
																		 str12,
																		 str13,
																		 str14,
																		 str15,
																		 str21,
																		 str67,
					});
                    break;
                case 2://bao cao luong
                    this.lstDetailReport.Items.Clear();
                    string str16 = WorkingContext.LangManager.GetString("frmListReport_16");
                    string str17 = WorkingContext.LangManager.GetString("frmListReport_17");
                    string str18 = WorkingContext.LangManager.GetString("frmListReport_18");
                    string str19 = WorkingContext.LangManager.GetString("frmListReport_19");
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str16});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str17});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str18});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str19});
                    break;
                case 3://bao cao thuong phat
                    this.lstDetailReport.Items.Clear();
                    string str20 = WorkingContext.LangManager.GetString("frmListReport_20");
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str20,});
                    break;
                case 4://báo cáo thanh toán BHXH
                    this.lstDetailReport.Items.Clear();
                    string st = WorkingContext.LangManager.GetString("frmListReport_bhxh1");
                    string st1 = WorkingContext.LangManager.GetString("frmListReport_bhxh2");
                    string st2 = WorkingContext.LangManager.GetString("frmListReport_bhxh3");
                    string st3 = WorkingContext.LangManager.GetString("frmListReport_bhxh4");
                    //string st4 = WorkingContext.LangManager.GetString("frmListReport_bhxh5");
                    //string st5 = WorkingContext.LangManager.GetString("frmListReport_bhxh6");
                    //this.lstDetailReport.Items.AddRange(new object[] {"Danh sách nhân viên phải nộp BHXH theo tháng",});
                    //this.lstDetailReport.Items.AddRange(new object[] {"Danh sách nhân viên điều chỉnh BHXH ",});
                    //Danh sách lao động và quỹ tiền lương trích nộp BHXH
                    this.lstDetailReport.Items.AddRange(new object[] { st, });
                    this.lstDetailReport.Items.AddRange(new object[] { st1, });
                    this.lstDetailReport.Items.AddRange(new object[] { st2, });
                    this.lstDetailReport.Items.AddRange(new object[] { st3, });
                    //this.lstDetailReport.Items.AddRange(new object[] {st4,});
                    //this.lstDetailReport.Items.AddRange(new object[] {st5,});

                    break;
            }


        }

        private void frmListReport_Load(object sender, System.EventArgs e)
        {
            Refresh();
            cboDepartment.Enabled = false;
            optGlobal.Checked = true;
            lstGroupReport.SelectedIndex = 0;//mac dinh ban dau chon bao cao nhan su            
        }


        /// <summary>
        /// Bắt sự kiện khi chọn một nhóm báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstGroupReport_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            t = lstGroupReport.SelectedIndex;
            switch (lstGroupReport.SelectedIndex)
            {
                case 0: 	// bao cao nhan su
                    this.lstDetailReport.Items.Clear();
                    string str1 = WorkingContext.LangManager.GetString("frmListReport_1");//"Báo cáo danh sách nhân viên"
                    string str = WorkingContext.LangManager.GetString("frmListReport_NVN");//"Danh sách nhân viên nghỉ"
                    string str2 = WorkingContext.LangManager.GetString("frmListReport_2");//"Bảng theo dõi cơm trưa"
                    string str3 = WorkingContext.LangManager.GetString("frmListReport_3");//"Danh sách làm thêm giờ"
                    string str4 = WorkingContext.LangManager.GetString("frmListReport_4");//"Danh sách nhân viên đi công tác"
                    string str5 = WorkingContext.LangManager.GetString("frmListReport_5");//"Theo dõi thay đổi phòng ban "
                    string str6 = WorkingContext.LangManager.GetString("Bosung5_1");//"Theo dõi thay đổi chức vụ "
                    string str7 = WorkingContext.LangManager.GetString("frmListReport_7");//"Diễn biến lương của nhân viên"
                    string str8 = WorkingContext.LangManager.GetString("frmListReport_8");
                    string str9 = WorkingContext.LangManager.GetString("frmListReport_9");//"Thanh toán tiền phép theo phòng ban"
                    string str26 = WorkingContext.LangManager.GetString("frmListReport_26");//"Tổng hợp Thanh toán tiền phép"
                    string str23 = WorkingContext.LangManager.GetString("frmListReport_23");//"Danh sách suất ăn làm thêm"
                    string str24 = WorkingContext.LangManager.GetString("frmListReport_24");//"Danh sách suất ăn làm thêm trong tháng"
                    string str25 = WorkingContext.LangManager.GetString("frmListReport_25");
                    
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str1,
																		 str,
																		 str2,
																		 str3,
																		 str4,
																		 str5,
																		 str6,
																		 str7,
																		 str8,
																		 str9,
                                                                         str26,
																		 str23,                                                                         
																		 str24,
																		 str25});
                    break;
                case 1:// bao cao cham cong
                    this.lstDetailReport.Items.Clear();
                    string str10 = WorkingContext.LangManager.GetString("frmListReport_10");//"Báo cáo chấm công chi tiết ngày"
                    string str11 = WorkingContext.LangManager.GetString("frmListReport_11");//"Báo cáo chấm công chi tiết tháng"
                    string str12 = WorkingContext.LangManager.GetString("frmListReport_12");//"Danh sách nhân viên không quẹt thẻ"
                    string str13 = WorkingContext.LangManager.GetString("frmListReport_13");//"Báo cáo tổng hợp nhân viên trong ngày"
                    string str14 = WorkingContext.LangManager.GetString("frmListReport_14");//"Báo cáo tổng hợp nhân viên trong tháng"
                    string str15 = WorkingContext.LangManager.GetString("frmListReport_15");//"Báo cáo tổng hợp nhân viên trong năm"
                    string str21 = WorkingContext.LangManager.GetString("frmListReport_21");//"Báo cáo chi tiết của từng nhân viên trong tháng"
                    string str67 = WorkingContext.LangManager.GetString("frmListReport_67");
                    string str68 = WorkingContext.LangManager.GetString("frmListReport_68");																	
                    this.lstDetailReport.Items.AddRange(new object[] {  str10,
																		 str11,
																		 str12,
																		 str13,
																		 str14,
																		 str15,
																		 str21,
					                                                     str67,
					                                                     str68,
					});
                    break;
                case 2://bao cao luong
                    this.lstDetailReport.Items.Clear();
                    string str16 = WorkingContext.LangManager.GetString("frmListReport_16");//"Bảng thanh toán lương tổng hợp"
                    string str17 = WorkingContext.LangManager.GetString("frmListReport_17");//"Bảng thanh toán lương chi tiết nhân viên"
                    string str18 = WorkingContext.LangManager.GetString("frmListReport_18");//"Bảng tóm tắt lương nhân viên"
                    string str19 = WorkingContext.LangManager.GetString("frmListReport_19");//"Bảng thanh toán lương theo phòng ban"
                    string str22 = WorkingContext.LangManager.GetString("frmListReport_SalaryPerEm");
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str16});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str17});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str18});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str19});
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str22});
                    break;
                case 3://bao cao thuong phat
                    this.lstDetailReport.Items.Clear();
                    string str20 = WorkingContext.LangManager.GetString("frmListReport_20");//"Danh sách nhân viên bị phạt"
                    this.lstDetailReport.Items.AddRange(new object[] {
																		 str20,});
                    break;
                case 4://báo cáo thanh toán BHXH
                    this.lstDetailReport.Items.Clear();
                    string st = WorkingContext.LangManager.GetString("frmListReport_bhxh1");
                    string st1 = WorkingContext.LangManager.GetString("frmListReport_bhxh2");
                    string st2 = WorkingContext.LangManager.GetString("frmListReport_bhxh3");
                    string st3 = WorkingContext.LangManager.GetString("frmListReport_bhxh4");
                    this.lstDetailReport.Items.AddRange(new object[] { st, });
                    this.lstDetailReport.Items.AddRange(new object[] { st1, });
                    this.lstDetailReport.Items.AddRange(new object[] { st2, });
                    this.lstDetailReport.Items.AddRange(new object[] { st3, });
                    break;
            }
        }

        private void optBoPhan_CheckedChanged(object sender, System.EventArgs e)
        {
            cboDepartment.Enabled = true;
            BindingDepartmentCombo();
        }

        /// <summary>
        /// Hiển thị danh sách phòng bao vào combobox
        /// </summary>
        private void BindingDepartmentCombo()
        {
            DepartmentDO departmentDO = new DepartmentDO();
            DataSet departmentDS = departmentDO.GetAllDepartments();

            cboDepartment.DataSource = departmentDS.Tables[0];
            cboDepartment.ValueMember = "DepartmentID";// = selected value
            cboDepartment.DisplayMember = "DepartmentName";
        }

        private void optToanThe_CheckedChanged(object sender, System.EventArgs e)
        {
            cboDepartment.Enabled = false;
        }

        private void btnView_Click(object sender, System.EventArgs e)
        {
            ViewReport();
        }

        /// <summary>
        /// Thiết lập các thông tin kết nối cơ sở dữ liệu cho báo cáo
        /// </summary>
        /// <param name="reportDocument"></param>
        private void SetDBLogonForReport(ReportDocument reportDocument)
        {
            crConnectioninfo = new ConnectionInfo();
            crConnectioninfo.ServerName = WorkingContext.Setting.Server;
            crConnectioninfo.DatabaseName = WorkingContext.Setting.Database;
            crConnectioninfo.UserID = WorkingContext.Setting.UserName;
            crConnectioninfo.Password = WorkingContext.Setting.Password;

            crTables = reportDocument.Database.Tables;
            crDatabase = reportDocument.Database;
            crTables = crDatabase.Tables;


            foreach (Table crTable in crTables)
            {
                try
                {
                    crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectioninfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                }
                catch
                {
                    string str = WorkingContext.LangManager.GetString("frmListReport_thongbao");
                    string str1 = WorkingContext.LangManager.GetString("frmListReport_thongbao_Title");
                    //MessageBox.Show("Không thể đăng nhập được vào cơ sở dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Method gọi các báo cáo để hiển thị
        /// </summary>
        /// <returns></returns>
        private ReportDocument SetReport()
        {
            ReportDocument rptDoc = null;

            ParameterValues pvFromDate = new ParameterValues();
            ParameterValues pvToDate = new ParameterValues();
            ParameterValues pvMonth = new ParameterValues();
            ParameterValues pvYear = new ParameterValues();
            ParameterValues pvUserName = new ParameterValues();
            ParameterValues pvPicURL = new ParameterValues();
            ParameterDiscreteValue pdvFromDate = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvToDate = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvMonth = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvYear = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvUserName = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvPicURL = new ParameterDiscreteValue();
            ParameterValues pvDepartmentID = new ParameterValues();
            ParameterDiscreteValue pdvDepartmentID = new ParameterDiscreteValue();
            if (optGlobal.Checked)
            {
                pdvDepartmentID.Value = 1;//mac dinh ban dau chon ca cong ty
            }
            else
            {
                pdvDepartmentID.Value = cboDepartment.SelectedValue;
            }
            pdvUserName.Value = WorkingContext.Username;
            pvUserName.Add(pdvUserName);
            switch (lstGroupReport.SelectedIndex)
            {

                #region báo cáo nhân sự
                case 0:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Báo cáo danh sách nhân viên

                            rptDoc = new Reports.EmployeeDepartment();                            
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            reportName = "Bao cao danh sach nhan vien";

                            break;
                        case 1:// Thông tin chi tiết nhân viên
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            rptDoc = new Reports.AllEmployeeInfo();
                            
                            pdvPicURL.Value = WorkingContext.Setting.PicturePath;
                            pvPicURL.Add(pdvPicURL);
                            pvDepartmentID.Add(pdvDepartmentID);

                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["PicURL"].ApplyCurrentValues(pvPicURL);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "Thong tin chi tiet nhan vien";

                            break;

                        case 2:// Danh sách nhân viên nghỉ
                            try
                            {
                                rptDoc = new Reports.RestEmployee();

                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFrom"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpTo"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach nhan vien nghi";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 3:// Bảng theo dõi cơm trưa
                            try
                            {
                                rptDoc = new Reports.LunchSheet();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Bang theo doi com trua";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 4:// Danh sách làm thêm giờ
                            try
                            {
                                rptDoc = new Reports.RegOverTime();

                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);                                
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);

                                reportName = "Danh sach lam them gio";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;

                        case 5://Danh sách nhân viên đi công tác

                            try
                            {
                                rptDoc = new Reports.LeaveSchedule();

                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@dtpFrom"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpEnd"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach nhan vien di cong tac";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 6:// Theo dõi thay đổi phòng ban
                            rptDoc = new Reports.DepartmentHistory();

                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "Theo doi thay doi phong ban";

                            break;
                        case 7:// Theo dõi thay đổi chức vụ
                            rptDoc = new Reports.PositionHistory();

                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);                            
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "Theo doi thay doi chuc vu";


                            break;
                        case 8:// Theo dõi diễn biến lương nhân viên
                            rptDoc = new Reports.SalaryHistory();
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "Theo doi dien bien luong";
                            break;
                        case 9://Thanh toán tiền phép theo phòng ban
                            try
                            {
                                rptDoc = new Reports.RestSheet_New();//Thay report mới theo yêu cầu E3112
                                pvDepartmentID.Add(pdvDepartmentID);
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvYear.Add(pdvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Thanh toan tien phep theo phong ban";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;

                        case 10://Bảng Tổng hợp thanh toán tiền phép
                            try
                            {
                                rptDoc = new Reports.TotalRestSheetDepartment();//E3134
                                pvDepartmentID.Add(pdvDepartmentID);
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvYear.Add(pdvYear);
                                rptDoc.DataDefinition.ParameterFields["@Department"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);                                
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //Lỗi đọc file báo cáo;
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                //Không tìm thấy đường dẫn của file báo cáo..
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");

                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;

                        case 11:// Danh sách suất ăn làm thêm 
                            try
                            {
                                rptDoc = new Reports.LunchOverTime();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Danh sach xuat an lam them";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 12:// Danh sách suất ăn làm thêm theo thang
                            try
                            {
                                rptDoc = new Reports.LunchOverTimeInMonth();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach xuat an lam them theo thang";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;

                        case 13:// Báo cáo trung bình nhân sự
                            try
                            {
                                rptDoc = new Reports.AverageEmployee();

                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@dtpFromDate"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Bao cao trung binh nhan su";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                    }
                    break;
                #endregion

                #region báo cáo chấm công
                case 1:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Báo cáo chấm công chi tiết ngày
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\DetailAttendance.rpt");
                                rptDoc = new Reports.DetailAttendance();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@FromDate"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@ToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bao cao cham cong chi tiet ngay";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 1:// báo cáo chấm công tháng 
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\TimeSheet.rpt");
                                rptDoc = new Reports.TimeSheet();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //								pdvUserName.Value = WorkingContext.Username;
                                //								pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);

                                reportName = "Bao cao cham cong thang";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 2:// Danh sách nhân viên không quẹt thẻ
                            try
                            {
                                //rptDoc.Load(@"Reports\InvalidStrike.rpt");
                                rptDoc = new Reports.InvalidStrike();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Danh sach nhan vien ko quet the";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 3:// Tổng hợp nhân viên trong ngày
                            try
                            {
                                //rptDoc.Load(@"Reports\EmployeeSummary.rpt");
                                rptDoc = new Reports.EmployeeSummary();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                reportName = "Tong hop nhan vien trong ngay";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 4:// báo cáo tổng hợp dữ liệu của một nhân viên trong tháng 
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\EmployeeSummaryInMonth.rpt");
                                rptDoc = new Reports.EmployeeSummaryInMonth();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //								pdvUserName.Value = WorkingContext.Username;
                                //								pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Tong hop nhan vien trong thang";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 5:// báo cáo tổng hợp dữ liệu của nhân viên trong một năm
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\EmployeeSummaryInYear.rpt");
                                rptDoc = new Reports.EmployeeSummaryInYear();
                                // Set the discreet value to the customers name.
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Tong hop nhan vien trong nam";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 6:// báo cáo chi tiết của từng nhân viên trong tháng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\AttendanceRecord.rpt");
                                rptDoc = new Reports.AttendanceRecord();
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bao cao chi tiet nhan vien trong thang";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 7:// Danh sách nhân viên quẹt thẻ không hợp lệ
                            try
                            {
                                //rptDoc.Load(@"Reports\InvalidStrike.rpt");
                                //rptDoc = new Reports.InvalidStrikeYesterday();
                                rptDoc = new Reports.InvalidStrikeYesterday();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Danh sach nhan vien quet the ko hop le";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 8://Bảng thanh toán lương tổng hợp theo phòng ban
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SalarySummary.rpt");
                                rptDoc = new Reports.TimeSheetSummary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bao cao cham cong theo phong ban";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;

                    }
                    break;

                #endregion

                #region báo cáo lương
                case 2:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0://Bảng thanh toán lương tổng hợp
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SalarySheet.rpt");
                                rptDoc = new Reports.SalarySheet();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bang thanh toan luong tong hop";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 1://Bảng thanh toán lương chi tiết nhân viên
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\DetailSalary.rpt");
                                rptDoc = new Reports.DetailSalary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //							pdvUserName.Value = WorkingContext.Username;
                                //							pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bang thanh toan luong chi tiet nhan vien";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 2://Bảng tóm tắt lương nhân viên=> in lên phong bì
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\BriefSalary.rpt");
                                rptDoc = new Reports.BriefSalary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Bang tom tat luong nhan vien";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 3://Bảng thanh toán lương tổng hợp theo phòng ban
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SalarySummary.rpt");
                                rptDoc = new Reports.SalarySummary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Thanh toan luong tong hop theo phong ban";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 4://Bảng lương chi tiết từng nhân viên
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SalaryPerEmployee.rpt");
                                rptDoc = new Reports.SalaryPerEmployee();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //							pdvUserName.Value = WorkingContext.Username;
                                //							pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bang luong chi tiet tung nhan vien";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                    }
                    break;
                #endregion

                #region báo cáo thưởng phạt
                case 3:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Danh sách nhân viên được thưởng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\PunishEmployee.rpt");
                                rptDoc = new Reports.PunishEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFromDate"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach nhan vien duoc thuong";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                    }
                    break;
                #endregion

                #region Bảo hiểm Xã hội
                case 4:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Danh sách nhân viên đóng BHXH theo tháng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SocialInsurance.rpt");
                                rptDoc = new Reports.SocialInsurance();

                                pvDepartmentID.Add(pdvDepartmentID);
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);

                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                //rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Danh sach nhan vien dong BHXH theo thang";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                        case 1:// Danh sách nhân viên điều chỉnh BHXH
                            try
                            {
                                optLocal.Enabled = false;
                                // Load the report
                                //rptDoc.Load(@"Reports\SocialInsuranceAdjust.rpt");
                                rptDoc = new Reports.SocialInsuranceAdjust();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                //							pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                //							rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach nhan vien dieu chinh BHXH";
                                reportDate = dtpFromDate.Value;


                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;

                        case 2:// Danh sách lao động và quỹ tiền lương trích nộp BHXH
                            try
                            {
                                optLocal.Enabled = false;
                                // Load the report
                                //rptDoc.Load(@"Reports\BHXH\InsuranceC45.rpt");
                                rptDoc = new Reports.BHXH.InsuranceC45();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                //							pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                //							rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Danh sach lao dong va quy tien luong trich nop BHXH";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;

                        case 3:// Xác nhận người lao động nghỉ việc trông con ốm
                            try
                            {
                                optLocal.Enabled = true;
                                // Load the report
                                //rptDoc.Load(@"Reports\BHXH\RestLookChildEmployee.rpt");
                                rptDoc = new Reports.BHXH.RestLookChildEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "Xac nhan nguoi lao dong nghi viec trong con om";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;

                    }

                    break;
                #endregion
            }
            if (rptDoc != null)
            {
                SetDBLogonForReport(rptDoc);
            }
            return rptDoc;
        }

        private ReportDocument SetReport_JP()
        {
            //ReportDocument rptDoc = new ReportDocument();
            ReportDocument rptDoc = null;

            ParameterValues pvFromDate = new ParameterValues();
            ParameterValues pvToDate = new ParameterValues();
            ParameterValues pvMonth = new ParameterValues();
            ParameterValues pvYear = new ParameterValues();
            ParameterValues pvUserName = new ParameterValues();
            ParameterValues pvPicURL = new ParameterValues();
            ParameterDiscreteValue pdvFromDate = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvToDate = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvMonth = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvYear = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvUserName = new ParameterDiscreteValue();
            ParameterDiscreteValue pdvPicURL = new ParameterDiscreteValue();
            ParameterValues pvDepartmentID = new ParameterValues();
            ParameterDiscreteValue pdvDepartmentID = new ParameterDiscreteValue();
            if (optGlobal.Checked)
            {
                pdvDepartmentID.Value = 1;//mac dinh ban dau chon ca cong ty
            }
            else
            {
                pdvDepartmentID.Value = cboDepartment.SelectedValue;
            }
            pdvUserName.Value = WorkingContext.Username;
            pvUserName.Add(pdvUserName);
            switch (lstGroupReport.SelectedIndex)
            {

                #region  báo cáo nhân sự
                case 0:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Báo cáo danh sách nhân viên
                            //rptDoc = new Reports_JP.EmployeeDepartment();
                            //rptDoc.Load(@"Reports_JP\EmployeeDepartment.rpt");
                            rptDoc = new Reports_JP.EmployeeDepartment();
                            reportName = "EmployeeDepartment";

                            break;
                        case 1:// Thông tin chi tiết nhân viên
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            //rptDoc.Load(@"Reports_JP\AllEmployeeInfo.rpt");
                            rptDoc = new Reports_JP.AllEmployeeInfo();
                            //							pdvUserName.Value = WorkingContext.Username;
                            //							pvUserName.Add(pdvUserName);
                            pdvPicURL.Value = WorkingContext.Setting.PicturePath;
                            pvPicURL.Add(pdvPicURL);
                            //MessageBox.Show(pdvPicURL.Value.ToString());
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["PicURL"].ApplyCurrentValues(pvPicURL);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "AllEmployeeInfo";

                            break;

                        case 2:// Danh sách nhân viên nghỉ
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\RestEmployee.rpt");
                                rptDoc = new Reports_JP.RestEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFrom"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpTo"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "RestEmployee";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }

                            //							MessageBox.Show("OK");

                            break;
                        case 3:// Bảng theo dõi cơm trưa
                            try
                            {
                                rptDoc = new Reports_JP.LunchSheet();

                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;

                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "LunchSheet";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 4:// Danh sách làm thêm giờ
                            try
                            {
                                rptDoc = new Reports_JP.RegOverTime();

                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "RegOverTime";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;

                        case 5://Danh sách nhân viên đi công tác

                            try
                            {
                                rptDoc = new Reports_JP.LeaveSchedule();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFrom"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpEnd"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "LeaveSchedule";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 6:// Theo dõi thay đổi phòng ban
                            //rptDoc.Load(@"Reports_JP\DepartmentHistory.rpt");
                            rptDoc = new Reports_JP.DepartmentHistory();
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "DepartmentHistory";


                            break;
                        case 7:// Theo dõi thay đổi chức vụ
                            rptDoc = new Reports_JP.PositionHistory();
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "PositionHistory";

                            break;
                        case 8:// Theo dõi diễn biến lương nhân viên;
                            rptDoc = new Reports_JP.SalaryHistory();
                            pvDepartmentID.Add(pdvDepartmentID);
                            rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                            //							pvUserName.Add(pdvUserName);
                            rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                            reportName = "SalaryHistory";

                            break;
                        case 9://Thanh toán tiền phép theo phòng ban
                            try
                            {
                                rptDoc = new Reports_JP.RestSheet();
                                pvDepartmentID.Add(pdvDepartmentID);
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvYear.Add(pdvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "RestSheet";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 10:// Danh sách suất ăn làm thêm 
                            try
                            {
                                //rptDoc.Load(@"Reports_JP\LunchOverTime.rpt");
                                rptDoc = new Reports_JP.LunchOverTime();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                //								pdvUserName.Value = WorkingContext.Username;
                                //								pvUserName.Add(pdvUserName);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);

                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "LunchOverTime";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 11:// Danh sách suất ăn làm thêm theo thang
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP/LunchOverTimeInMonth.rpt");
                                rptDoc = new Reports_JP.LunchOverTimeInMonth();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "LunchOverTimeInMonth";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;

                        case 12:// Danh sách nhân viên được thưởng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\PunishEmployee.rpt");
                                rptDoc = new Reports.AverageEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                //pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFromDate"].ApplyCurrentValues(pvFromDate);
                                //rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "AverageEmployee";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                    }
                    break;
                #endregion
                #region báo cáo chấm công
                case 1:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Báo cáo chấm công chi tiết ngày
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\DetailAttendance.rpt");
                                rptDoc = new Reports_JP.DetailAttendance();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@FromDate"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@ToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "DetailAttendance";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 1:// báo cáo chấm công tháng 
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\TimeSheet.rpt");
                                rptDoc = new Reports_JP.TimeSheet();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //								pdvUserName.Value = WorkingContext.Username;
                                //								pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "TimeSheet";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 2:// Danh sách nhân viên không quẹt thẻ
                            try
                            {
                                //rptDoc.Load(@"Reports_JP\InvalidStrike.rpt");
                                rptDoc = new Reports_JP.InvalidStrike();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "InvalidStrike";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 3:// Tổng hợp nhân viên trong ngày
                            try
                            {
                                //rptDoc.Load(@"Reports_JP\EmployeeSummary.rpt");
                                rptDoc = new Reports_JP.EmployeeSummary();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                reportName = "EmployeeSummary";
                                reportDate = dtpFromDate.Value;
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                        case 4:// báo cáo tổng hợp dữ liệu của một nhân viên trong tháng 
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\EmployeeSummaryInMonth.rpt");
                                rptDoc = new Reports_JP.EmployeeSummaryInMonth();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //								pdvUserName.Value = WorkingContext.Username;
                                //								pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "EmployeeSummaryInMonth";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 5:// báo cáo tổng hợp dữ liệu của nhân viên trong một năm
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\EmployeeSummaryInYear.rpt");
                                rptDoc = new Reports_JP.EmployeeSummaryInYear();
                                // Set the discreet value to the customers name.
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "EmployeeSummaryInYear";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 6:// báo cáo chi tiết của từng nhân viên trong tháng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\AttendanceRecord.rpt");
                                rptDoc = new Reports_JP.AttendanceRecord();
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "AttendanceRecord";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;

                        case 7:// Danh sách nhân viên không quẹt thẻ
                            try
                            {
                                //rptDoc.Load(@"Reports\InvalidStrike.rpt");
                                rptDoc = new Reports.InvalidStrikeYesterday();
                                //rptDoc = new Reports.InvalidStrikeYesterday();
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@WorkingDay"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "InvalidStrikeYesterday";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;

                        case 8://Bảng thanh toán lương tổng hợp theo phòng ban
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports\SalarySummary.rpt");
                                rptDoc = new Reports.TimeSheetSummary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "Bao cao cham cong theo phong ban";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //							
                            break;
                    }
                    break;
                #endregion
                #region báo cáo lương
                case 2:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0://Bảng thanh toán lương tổng hợp
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\SalarySheet.rpt");
                                rptDoc = new Reports_JP.SalarySheet();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "SalarySheet";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 1://Bảng thanh toán lương chi tiết nhân viên
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\DetailSalary.rpt");
                                rptDoc = new Reports_JP.DetailSalary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //							pdvUserName.Value = WorkingContext.Username;
                                //							pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "DetailSalary";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 2://Bảng tóm tắt lương nhân viên=> in lên phong bì
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\BriefSalary.rpt");
                                rptDoc = new Reports_JP.BriefSalary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "BriefSalary";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 3://Bảng thanh toán lương tổng hợp theo phòng ban
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\SalarySummary.rpt");
                                rptDoc = new Reports_JP.SalarySummary();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "SalarySummary";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                        case 4://Bảng lương chi tiết từng nhân viên
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\SalaryPerEmployee.rpt");
                                rptDoc = new Reports_JP.SalaryPerEmployee();
                                // Set the discreet value to the customers name.
                                pdvMonth.Value = dtpFromDate.Value.Month;
                                pdvYear.Value = dtpFromDate.Value.Year;
                                //							pdvUserName.Value = WorkingContext.Username;
                                //							pvUserName.Add(pdvUserName);
                                // Add it to the parameter collection.
                                pvMonth.Add(pdvMonth);
                                pvYear.Add(pdvYear);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvMonth);
                                rptDoc.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(pvYear);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "SalaryPerEmployee";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            break;
                    }
                    break;
                #endregion
                #region báo cáo thưởng phạt
                case 3:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Danh sách nhân viên được thưởng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\PunishEmployee.rpt");
                                rptDoc = new Reports_JP.PunishEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@dtpFromDate"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "PunishEmployee";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                    }
                    break;
                #endregion
                #region Bảo hiểm Xã hội
                case 4:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// Danh sách nhân viên đóng BHXH theo tháng
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\SocialInsurance.rpt");
                                rptDoc = new Reports_JP.SocialInsurance();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                //							pdvFromDate.Value = dtpFromDate.Value.ToShortDateString();
                                //							pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                //							// Add it to the parameter collection.
                                //							pvFromDate.Add(pdvFromDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                //							rptDoc.DataDefinition.ParameterFields["@dtpFromDate"].ApplyCurrentValues(pvFromDate);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                reportName = "SocialInsurance";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                        case 1:// Danh sách nhân viên điều chỉnh BHXH
                            try
                            {
                                // Load the report
                                //rptDoc.Load(@"Reports_JP\SocialInsuranceAdjust.rpt");
                                rptDoc = new Reports_JP.SocialInsuranceAdjust();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                //							pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                //							rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                optLocal.Enabled = false;
                                reportName = "SocialInsuranceAdjust";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;

                        case 2:// Danh sách lao động và quỹ tiền lương trích nộp BHXH
                            try
                            {
                                optLocal.Enabled = false;
                                // Load the report
                                //rptDoc.Load(@"Reports\BHXH\InsuranceC45.rpt");
                                rptDoc = new Reports.BHXH.InsuranceC45();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //								pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                //							pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                //							rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "InsuranceC45";
                                reportDate = dtpFromDate.Value;


                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;

                        case 3:// Xác nhận người lao động nghỉ việc trông con ốm
                            try
                            {
                                optLocal.Enabled = true;
                                // Load the report
                                //rptDoc.Load(@"Reports\BHXH\RestLookChildEmployee.rpt");
                                rptDoc = new Reports.BHXH.RestLookChildEmployee();
                                // Set the connection information for all the tables used in the report
                                // Set the discreet value to the customers name.
                                pdvFromDate.Value = dtpFromDate.Value;
                                //							pdvToDate.Value = dtpToDate.Value.ToShortDateString();
                                //pdvDepartmentID.Value = cboDepartment.SelectedValue;
                                // Add it to the parameter collection.
                                pvFromDate.Add(pdvFromDate);
                                //							pvToDate.Add(pdvToDate);
                                pvDepartmentID.Add(pdvDepartmentID);
                                // Apply the current parameter values.
                                rptDoc.DataDefinition.ParameterFields["@Date"].ApplyCurrentValues(pvFromDate);
                                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                                //							rptDoc.DataDefinition.ParameterFields["@dtpToDate"].ApplyCurrentValues(pvToDate);
                                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                                reportName = "RestLookChildEmployee";
                                reportDate = dtpFromDate.Value;

                            }
                            catch (LoadSaveReportException Exp)
                            {
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                                MessageBox.Show(str, str1);
                            }
                            catch (Exception Exp)
                            {
                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                                MessageBox.Show(Exp.Message, str2);
                            }
                            //	MessageBox.Show("OK");

                            break;
                    }
                    break;
                #endregion
            }
            if (rptDoc != null)
            {
                SetDBLogonForReport(rptDoc);
            }
            return rptDoc;
        }


        private void lstDetailReport_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            optGlobal.Enabled = true;
            switch (lstGroupReport.SelectedIndex)
            {
                #region  Báo cáo nhân sự
                case 0:

                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:// báo cáo tổng hợp nhân viên
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            string str = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str;
                            ResetOptState();
                            break;
                        case 1://báo cáo chi tiết từng nhân viên
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            string str1 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str1;
                            ResetOptState();
                            break;

                        case 2://báo cáo số nhân viên đi làm trong ngày
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str2 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str2;
                            ResetOptState();
                            break;
                        case 3://Bang theo doi an trua
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string st1 = WorkingContext.LangManager.GetString("frmListReport_52");
                            lblFromDate.Text = st1;
                            ResetOptState();
                            //lblFromDate.Text = "Chọn ngày";
                            break;
                        case 4:// báo cáo tổng kết nghỉ
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st2 = WorkingContext.LangManager.GetString("frmListReport_52");
                            lblFromDate.Text = st2;
                            ResetOptState();
                            break;
                        case 5://Báo cáo chi tiết làm thêm giờ
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str3 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str3;
                            ResetOptState();
                            break;
                        case 6://Theo dõi thay đổi phòng ban
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            string str4 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str4;
                            ResetOptState();
                            break;
                        case 7://Theo dõi thay đổi chức vụ
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            string str5 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str5;
                            ResetOptState();
                            break;
                        case 8://Diễn biến lương của nhân viên
                            dtpFromDate.Enabled = false;
                            dtpToDate.Enabled = false;
                            string str6 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str6;
                            ResetOptState();
                            break;
                        case 9://Thanh toán tiền phép
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Năm";
                            string st9 = WorkingContext.LangManager.GetString("frmListReport_56");
                            lblFromDate.Text = st9;
                            ResetOptState();
                            break;
                        case 10://Bảng tổng hợp thanh toán tiền phép
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str10 = WorkingContext.LangManager.GetString("frmListReport_56");
                            lblFromDate.Text = str10;
                            ResetOptState();
                            break;
                        case 11://Báo cáo suất ăn nhân viên làm thêm 
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st11 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st11;
                            ResetOptState();
                            break;
                        case 12://Báo cáo suất ăn nhân viên làm thêm theo thang
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str12 = WorkingContext.LangManager.GetString("frmListReport_52");
                            lblFromDate.Text = str12;
                            ResetOptState();
                            //lblFromDate.Text = "Chọn thang";
                            break;
                        case 13:// báo cáo tổng hợp nhân viên
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str13 = WorkingContext.LangManager.GetString("frmListReport_51");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str13;
                            ResetOptState();
                            break;

                        default:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str7 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str7;
                            string st = WorkingContext.LangManager.GetString("frmSocialSheet_lable2");
                            //lblToDate.Text = "Đến ngày";
                            lblToDate.Text = st;
                            optGlobal.Enabled = true;
                            break;
                    }
                    break;
                #endregion

                #region  Báo cáo chấm công
                case 1:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0://báo cáo chấm công chi tiết
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string st11 = WorkingContext.LangManager.GetString("frmListReport_54");
                            //lblFromDate.Text = "Ngày";
                            lblFromDate.Text = st11;
                            ResetOptState();
                            break;
                        case 1: // Chấm công tháng theo nhân viên
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st1 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st1;
                            ResetOptState();
                            break;
                        case 2://Báo cáo chi tiết làm thêm giờ
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st2 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st2;
                            ResetOptState();
                            break;
                        case 3://Báo cáo tổng hợp nhân viên ngày
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st3 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st3;
                            optLocal.Enabled = false;
                            break;
                        case 4://Báo cáo chi tiết 1 nhân viên tháng
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "Chọn tháng";
                            lblFromDate.Text = str;
                            ResetOptState();
                            break;
                        case 5://Báo cáo chi tiết 1 nhân viên năm
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str1 = WorkingContext.LangManager.GetString("frmListReport_53");
                            //lblFromDate.Text = "Chọn năm";
                            lblFromDate.Text = str1;
                            ResetOptState();
                            break;
                        case 6://Báo cáo chi tiết 1 nhân viên năm
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str2 = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "Chọn tháng";
                            lblFromDate.Text = str2;
                            optLocal.Checked = true;
                            optGlobal.Enabled = false;
                            break;
                        case 7://Báo cáo nhân viên quẹt thẻ ko hợp lệ
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st7 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st7;
                            ResetOptState();
                            break;
                        case 8://Báo cáo chấm công theo phòng ban
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st12 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st12;
                            ResetOptState();
                            break;
                        default:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str8 = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str8;
                            optGlobal.Enabled = true;
                            break;
                    }
                    break;
                #endregion

                #region  Báo cáo tính lương
                case 2:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st1 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st1;
                            ResetOptState();
                            break;
                        case 1:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st2 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st2;
                            ResetOptState();
                            break;
                        case 2:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st11 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st11;
                            ResetOptState();
                            break;
                        case 3:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            string st12 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st12;
                            ResetOptState();
                            break;
                        case 4:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            //lblFromDate.Text = "Chọn ngày";
                            st12 = WorkingContext.LangManager.GetString("frmListReport_51");
                            lblFromDate.Text = st12;
                            ResetOptState();
                            break;
                        default:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str;
                            break;
                    }
                    break;
                #endregion

                #region báo cáo thưởng phạt
                case 3:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = true;
                            string str = WorkingContext.LangManager.GetString("frmSocialSheet_lable1");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str;
                            ResetOptState();
                            break;
                    }
                    break;
                #endregion

                #region bảo hiểm xã hội
                case 4:
                    switch (lstDetailReport.SelectedIndex)
                    {
                        case 0:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "chọn tháng";
                            lblFromDate.Text = str;
                            optGlobal.Enabled = true;
                            break;
                        case 1:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str1 = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str1;
                            optGlobal.Enabled = true;
                            optLocal.Enabled = false;
                            break;
                        case 2:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str2 = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str2;
                            optGlobal.Enabled = true;
                            optLocal.Enabled = false;
                            break;
                        case 3:
                            dtpFromDate.Enabled = true;
                            dtpToDate.Enabled = false;
                            string str3 = WorkingContext.LangManager.GetString("frmListReport_52");
                            //lblFromDate.Text = "Từ ngày";
                            lblFromDate.Text = str3;
                            optGlobal.Enabled = true;
                            optLocal.Enabled = true;
                            break;
                        default:
                            ResetOptState();
                            break;
                    }
                    break;
                #endregion
            }
        }

        /// <summary>
        /// Kiểm tra ngày đầu <= ngày cuối
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private bool CheckValidDate(DateTime start, DateTime end)
        {
            if (start.Date <= end.Date)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Chuyển trạng thái của lựa chọn hiển thị theo phòng ban hoặc cả công ty về mặc định
        /// </summary>
        private void ResetOptState()
        {
            optGlobal.Enabled = true;
            optLocal.Enabled = true;
        }

        private void lstDetailReport_DoubleClick(object sender, System.EventArgs e)
        {
            //			PleaseWait.ShowProcess();
            ViewReport();
            //			PleaseWait.CloseProcess();
        }
        /// <summary>
        /// Gọi form hiển thị báo cáo chi tiết
        /// </summary>
        private void ViewReport()
        {
            //			frmBusyBar frmbusy = new frmBusyBar();
            //			frmbusy.Show();
            if (lstDetailReport.SelectedIndex < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListReport_btnView_thongBao");
                string str1 = WorkingContext.LangManager.GetString("frmListReport_btnView_thongBao_Title");
                //MessageBox.Show("Bạn phải chọn một loại báo cáo chi tiết!", "Xem báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                switch (lstGroupReport.SelectedIndex)
                {
                    case 0:// báo cáo nhân sự
                        switch (lstDetailReport.SelectedIndex)
                        {
                            case 2:
                                if (!CheckValidDate(dtpFromDate.Value, dtpToDate.Value))
                                {
                                    string str2 = WorkingContext.LangManager.GetString("Bosung1");
                                    string str3 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;
                            case 5:
                                if (!CheckValidDate(dtpFromDate.Value, dtpToDate.Value))
                                {
                                    string str2 = WorkingContext.LangManager.GetString("Bosung1");
                                    string str3 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;


                        }
                        break;

                    case 1:// báo cáo chấm công
                        switch (lstDetailReport.SelectedIndex)
                        {
                            case 0:
                                if (!CheckValidDate(dtpFromDate.Value, dtpToDate.Value))
                                {
                                    string str2 = WorkingContext.LangManager.GetString("Bosung1");
                                    string str3 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;

                            case 5:
                                if (!CheckValidDate(dtpFromDate.Value, dtpToDate.Value))
                                {
                                    string str4 = WorkingContext.LangManager.GetString("Bosung1");
                                    string str5 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str4, str5, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;
                            case 6:
                                if (cboDepartment.SelectedIndex == 0)
                                {
                                    string str6 = WorkingContext.LangManager.GetString("Bosung2");
                                    string str7 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str6, str7, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;
                        }
                        break;
                    case 3:// báo cáo thưởng phạt
                        switch (lstDetailReport.SelectedIndex)
                        {
                            case 0:
                                if (!CheckValidDate(dtpFromDate.Value, dtpToDate.Value))
                                {
                                    string str2 = WorkingContext.LangManager.GetString("Bosung1");
                                    string str3 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                                    //MessageBox.Show("Ngày chọn không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    MessageBox.Show(str2, str3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                break;
                        }
                        break;


                }
            }
            ReportDocument rptDocument = new ReportDocument();
            PleaseWait.ShowProcess();
            if (this.Text == "Danh sách báo cáo")
            {

                rptDocument = SetReport();

            }
            else
            {
                rptDocument = SetReport_JP();
            }
            PleaseWait.CloseProcess();
            frmReportPreview frm = new frmReportPreview();
            frm.SetReportDocument = rptDocument;
            frm.ReportName = reportName;
            frm.ReportDate = reportDate;
            frm.Show();
            //			frmbusy.CloseBusyBar();
            //			frmbusy.Close();
        }

        public void ViewEmpInsurance(int departmentID)
        {
            //ReportDocument rptDoc = new ReportDocument();
            ReportDocument rptDoc = null;
            PleaseWait.ShowProcess();
            ParameterValues pvUserName = new ParameterValues();
            ParameterDiscreteValue pdvUserName = new ParameterDiscreteValue();
            ParameterValues pvDepartmentID = new ParameterValues();
            ParameterDiscreteValue pdvDepartmentID = new ParameterDiscreteValue();

            pdvDepartmentID.Value = departmentID;

            pdvUserName.Value = WorkingContext.Username;
            pvUserName.Add(pdvUserName);

            try
            {
                // Load the report
                //rptDoc.Load(@"Reports/BHXH/InsuranceSDH02.rpt");
                rptDoc = new Reports.BHXH.InsuranceSDH02();
                pvDepartmentID.Add(pdvDepartmentID);
                rptDoc.DataDefinition.ParameterFields["@DepartmentID"].ApplyCurrentValues(pvDepartmentID);
                rptDoc.DataDefinition.ParameterFields["@UserName"].ApplyCurrentValues(pvUserName);
                reportName = "InsuranceSDH02";

            }
            catch (LoadSaveReportException Exp)
            {
                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                MessageBox.Show(str, str1);
            }
            catch (Exception Exp)
            {
                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                MessageBox.Show(Exp.Message, str2);
            }

            if (rptDoc != null)
            {
                SetDBLogonForReport(rptDoc);
            }
            PleaseWait.CloseProcess();
            frmReportPreview frm = new frmReportPreview();
            frm.SetReportDocument = rptDoc;
            frm.Show();
        }
        private string ReportFileName = "";
        private void btnHelp_Click(object sender, EventArgs e)
        {
            settings = ModuleConfig.GetSettings();
            //string reportPart = settings.ReportPath;

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "All File|*.*|CrystalReports|*.rpt";
            ofd.InitialDirectory = WorkingContext.Setting.ReportPath;
            ofd.FilterIndex = 1;

            string ReportFilePath = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReportFilePath = ofd.FileName;
                ReportFileName = Path.GetFileName(ReportFilePath);

                #region ShowReport

                ReportDocument rptDoc = new ReportDocument();
                PleaseWait.ShowProcess();

                try
                {
                    // Load the report
                    //rptDoc.Load(@"Reports/BHXH/InsuranceSDH02.rpt");
                    rptDoc.Load(ReportFilePath);
                }
                catch (LoadSaveReportException Exp)
                {
                    //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                    string str = WorkingContext.LangManager.GetString("frmListReport_Error_Messa1");
                    string str1 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa2");
                    //MessageBox.Show("Không tìm thấy đường dẫn của file báo cáo..", "Lỗi đọc file báo cáo.");
                    MessageBox.Show(str, str1);
                }
                catch (Exception Exp)
                {
                    //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                    string str2 = WorkingContext.LangManager.GetString("frmListReport_Error_Messa3");

                    //MessageBox.Show(Exp.Message, "Có lỗi xảy ra");
                    MessageBox.Show(Exp.Message, str2);
                }

                if (rptDoc != null)
                {
                    SetDBLogonForReport(rptDoc);
                }
                PleaseWait.CloseProcess();
                frmReportPreview frm = new frmReportPreview();
                frm.ExportReport = false;

                frm.SetReportDocument = rptDoc;
                frm.Show();
            }

                #endregion

        }
    }
}
