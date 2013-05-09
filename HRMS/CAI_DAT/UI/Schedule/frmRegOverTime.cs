//------------------------------------------------------------------------------------
//Class	    : Class đăng ký làm thêm giờ
//Purpose	: 
//Note	    : đang làm chức năng Update, xóa		  
//Author	: chinhnd 9-2005
//Modify	: chinhnd 20_3_2006 by chinhnd điều kiện ret = employeestatus = 5
//Modify	: chinhnd 27_11_2006 by quandh - cho phép thêm đồng thời nhiều nhân viên làm thêm giờ
//------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Form đăng ký làm thêm giờ
    /// </summary>
    public class frmRegOverTime : Form
    {
        private Button btnClose;
        private Button btnSave;
        private Label label5;
        private Label label3;
        private Label label2;
        private IContainer components;
        private DateTimePicker dtpDayWorking;
        private TextBox txtWorkOverTimeInfo;
        private DateTimePicker dtpStartTimeOver;
        private EVSoft.HRMS.Controls.DepartmentTreeView departmentTreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DateTimePicker dtpLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckHaveDinner;
        private XPTable.Models.Table lvwListEmployee;
        private System.Windows.Forms.GroupBox groupBox4;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn cEmployeeName;
        private XPTable.Models.TextColumn cCardID;
        private XPTable.Models.NumberColumn cSTT;
        private System.Windows.Forms.ComboBox cboDinnnerAmount;
        private System.Windows.Forms.Button btnSelectAll;
        private MTGCComboBox cboEmployeeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnClearAll;
        /// <summary>
        /// 
        /// </summary>
        private int selectedDepartment = 0;

        public frmRegOverTime()
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegOverTime));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWorkOverTimeInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDayWorking = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTimeOver = new System.Windows.Forms.DateTimePicker();
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.cboEmployeeName = new MTGCComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDinnnerAmount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckHaveDinner = new System.Windows.Forms.CheckBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.dtpLength = new System.Windows.Forms.DateTimePicker();
            this.lvwListEmployee = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.NumberColumn();
            this.cCardID = new XPTable.Models.TextColumn();
            this.cEmployeeName = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwListEmployee)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(520, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(440, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Ghi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWorkOverTimeInfo
            // 
            this.txtWorkOverTimeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkOverTimeInfo.Location = new System.Drawing.Point(8, 144);
            this.txtWorkOverTimeInfo.Multiline = true;
            this.txtWorkOverTimeInfo.Name = "txtWorkOverTimeInfo";
            this.txtWorkOverTimeInfo.Size = new System.Drawing.Size(312, 336);
            this.txtWorkOverTimeInfo.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nội dung công việc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Bắt đầu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày làm ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDayWorking
            // 
            this.dtpDayWorking.CustomFormat = "dd/MM/yyyy    ";
            this.dtpDayWorking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayWorking.Location = new System.Drawing.Point(88, 48);
            this.dtpDayWorking.Name = "dtpDayWorking";
            this.dtpDayWorking.Size = new System.Drawing.Size(232, 20);
            this.dtpDayWorking.TabIndex = 56;
            // 
            // dtpStartTimeOver
            // 
            this.dtpStartTimeOver.CustomFormat = "HH:mm";
            this.dtpStartTimeOver.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTimeOver.Location = new System.Drawing.Point(88, 72);
            this.dtpStartTimeOver.Name = "dtpStartTimeOver";
            this.dtpStartTimeOver.ShowUpDown = true;
            this.dtpStartTimeOver.Size = new System.Drawing.Size(56, 20);
            this.dtpStartTimeOver.TabIndex = 75;
            this.dtpStartTimeOver.Value = new System.DateTime(2005, 9, 30, 17, 0, 0, 0);
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
            this.departmentTreeView.Size = new System.Drawing.Size(240, 152);
            this.departmentTreeView.TabIndex = 76;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentTreeView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 176);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bộ phận";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtEmployeeName);
            this.groupBox2.Controls.Add(this.cboEmployeeName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboDinnnerAmount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ckHaveDinner);
            this.groupBox2.Controls.Add(this.lblLength);
            this.groupBox2.Controls.Add(this.dtpLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDayWorking);
            this.groupBox2.Controls.Add(this.dtpStartTimeOver);
            this.groupBox2.Controls.Add(this.txtWorkOverTimeInfo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(272, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 488);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin làm thêm giờ";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.Location = new System.Drawing.Point(152, 24);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(168, 20);
            this.txtEmployeeName.TabIndex = 85;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // cboEmployeeName
            // 
            this.cboEmployeeName.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboEmployeeName.ColumnNum = 3;
            this.cboEmployeeName.ColumnWidth = "0;60;121";
            this.cboEmployeeName.DisplayMember = "Text";
            this.cboEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmployeeName.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboEmployeeName.DropDownForeColor = System.Drawing.Color.Black;
            this.cboEmployeeName.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboEmployeeName.DropDownWidth = 201;
            this.cboEmployeeName.Enabled = false;
            this.cboEmployeeName.GridLineColor = System.Drawing.Color.LightGray;
            this.cboEmployeeName.GridLineHorizontal = true;
            this.cboEmployeeName.GridLineVertical = true;
            this.cboEmployeeName.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboEmployeeName.Location = new System.Drawing.Point(88, 24);
            this.cboEmployeeName.ManagingFastMouseMoving = true;
            this.cboEmployeeName.ManagingFastMouseMovingInterval = 30;
            this.cboEmployeeName.Name = "cboEmployeeName";
            this.cboEmployeeName.Size = new System.Drawing.Size(64, 21);
            this.cboEmployeeName.TabIndex = 84;
            this.cboEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cboEmployeeName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "Tên nhân viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDinnnerAmount
            // 
            this.cboDinnnerAmount.Items.AddRange(new object[] {
            "15000",
            "16000",
            "25000"});
            this.cboDinnnerAmount.Location = new System.Drawing.Point(264, 96);
            this.cboDinnnerAmount.Name = "cboDinnnerAmount";
            this.cboDinnnerAmount.Size = new System.Drawing.Size(56, 21);
            this.cboDinnnerAmount.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(176, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "PC tiền ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckHaveDinner
            // 
            this.ckHaveDinner.Location = new System.Drawing.Point(8, 96);
            this.ckHaveDinner.Name = "ckHaveDinner";
            this.ckHaveDinner.Size = new System.Drawing.Size(152, 24);
            this.ckHaveDinner.TabIndex = 79;
            this.ckHaveDinner.Text = "Hưởng suất ăn thêm";
            this.ckHaveDinner.CheckedChanged += new System.EventHandler(this.ckHaveDinner_CheckedChanged);
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(176, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(80, 23);
            this.lblLength.TabIndex = 77;
            this.lblLength.Text = "Thời gian";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpLength
            // 
            this.dtpLength.CustomFormat = "HH:mm";
            this.dtpLength.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLength.Location = new System.Drawing.Point(264, 72);
            this.dtpLength.Name = "dtpLength";
            this.dtpLength.ShowUpDown = true;
            this.dtpLength.Size = new System.Drawing.Size(56, 20);
            this.dtpLength.TabIndex = 78;
            this.dtpLength.Value = new System.DateTime(2005, 12, 3, 3, 30, 0, 0);
            // 
            // lvwListEmployee
            // 
            this.lvwListEmployee.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwListEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwListEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwListEmployee.ColumnModel = this.columnModel1;
            this.lvwListEmployee.EnableToolTips = true;
            this.lvwListEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwListEmployee.FullRowSelect = true;
            this.lvwListEmployee.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwListEmployee.GridLines = XPTable.Models.GridLines.Both;
            this.lvwListEmployee.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwListEmployee.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwListEmployee.Location = new System.Drawing.Point(8, 16);
            this.lvwListEmployee.MultiSelect = true;
            this.lvwListEmployee.Name = "lvwListEmployee";
            this.lvwListEmployee.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwListEmployee.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwListEmployee.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwListEmployee.Size = new System.Drawing.Size(240, 288);
            this.lvwListEmployee.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwListEmployee.TabIndex = 81;
            this.lvwListEmployee.TableModel = this.tableModel1;
            this.lvwListEmployee.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwListEmployee.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cCardID,
            this.cEmployeeName});
            // 
            // cSTT
            // 
            this.cSTT.Text = "STT";
            this.cSTT.Width = 42;
            // 
            // cCardID
            // 
            this.cCardID.Text = "Mã thẻ";
            this.cCardID.Width = 66;
            // 
            // cEmployeeName
            // 
            this.cEmployeeName.Text = "Tên nhân viên";
            this.cEmployeeName.Width = 120;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.lvwListEmployee);
            this.groupBox4.Location = new System.Drawing.Point(8, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 312);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectAll.Location = new System.Drawing.Point(16, 504);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 83;
            this.btnSelectAll.Text = "Chọn tất";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearAll.Location = new System.Drawing.Point(96, 504);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 84;
            this.btnClearAll.Text = "Bỏ chọn";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmRegOverTime
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(602, 536);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegOverTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký làm thêm giờ";
            this.Load += new System.EventHandler(this.frmRegOverTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwListEmployee)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Các biến tự định nghĩa

        private DataSet dsEmployee = null;
        private DataSet dsRegOverTime = null;
        private DepartmentDO departnemtDO = null;
        private EmployeeDO employeeDO = null;
        private RegOverTimeDO regOverTimeDO = null;
        private DataTable dtRegOverTime = null;
        private int selectedRegOverTime = -1;
        public DataSet DsOverTime
        {
            get { return dsRegOverTime; }
            set { dsRegOverTime = value; }
        }

        public int CurrentOverTime
        {
            get { return selectedRegOverTime; }
            set { selectedRegOverTime = value; }
        }

        #endregion

        #region Các hàm xử lý dữ liệu chính
        /// <summary>
        /// Đăng ký làm thêm giờ 
        /// </summary>
        public void RegDepartmentOverTime()
        {
            frmMessage frmMessage = new frmMessage();
            string OverTimeMessage = "";
            int STT = 0;

            for (int i = 0; i < lvwListEmployee.SelectedIndicies.Length; i++)
            {
                // chỉ số hàng được chọn
                int rowIndex = (int)lvwListEmployee.SelectedItems[i].Tag;
                DataRow drEmployee = dsEmployee.Tables[0].Rows[rowIndex];
                //				dr.BeginEdit();

                //			foreach (DataRow drEmployee in dsEmployee.Tables[0].Rows)
                //			{
                int ret = 0;
                try
                {
                    DataRow dr = dsRegOverTime.Tables[0].NewRow();
                    //					dr.BeginEdit();

                    dr.BeginEdit();
                    dr["EmployeeID"] = drEmployee["EmployeeID"];
                    dr["StartOverTime"] = dtpStartTimeOver.Value.ToShortTimeString();
                    dr["Length"] = dtpLength.Value.ToShortTimeString();
                    dr["WorkingDay"] = dtpDayWorking.Value.ToShortDateString();
                    DateTime dt = Convert.ToDateTime(dr["Length"]);
                    dr["WorkOverTimeInfo"] = txtWorkOverTimeInfo.Text;
                    if (ckHaveDinner.Checked)
                    {
                        dr["DinnerAmount"] = Double.Parse(cboDinnnerAmount.Text);
                    }
                    else
                    {
                        dr["DinnerAmount"] = DBNull.Value;
                    }
                    dr.EndEdit();
                    dsRegOverTime.Tables[0].Rows.Add(dr);

                    ret = regOverTimeDO.AddRegOverTime(dsRegOverTime);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                switch (ret)
                {
                    case EmployeeStatus.EMPLOYEE_LEAVE:
                        OverTimeMessage = drEmployee["CardID"] + " - " + drEmployee["EmployeeName"] + " đã đi công tác";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                    case EmployeeStatus.EMPLOYEE_REST:
                        OverTimeMessage = drEmployee["CardID"] + " - " + drEmployee["EmployeeName"] + " đã đăng ký nghỉ";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                    case EmployeeStatus.EMPLOYEE_ABSENT:
                        OverTimeMessage = drEmployee["CardID"] + " - " + drEmployee["EmployeeName"] + " vắng mặt";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                    case 11:
                        OverTimeMessage = "Thời gian đăng ký đã vượt thời gian làm thêm thực tế. Vui lòng kiểm tra lại!";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                    case 12:
                        OverTimeMessage = "Thời gian làm thực tế không đủ để đăng ký làm thêm. Vui lòng kiểm tra lại!";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                    case 13:
                        OverTimeMessage = "Không thể đăng ký làm thêm với nhân viên đăng ký nghỉ không phải là nghỉ phép 1/2 ngày. Vui lòng kiểm tra lại!";
                        STT++;
                        frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                        break;
                }
                //if(ret == EmployeeStatus.EMPLOYEE_LEAVE)
                //{
                //    OverTimeMessage = drEmployee["CardID"]+" - "+drEmployee["EmployeeName"]+" đã đi công tác";
                //    STT++;
                //    frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                //}

                //if(ret == EmployeeStatus.EMPLOYEE_REST)
                //{
                //    OverTimeMessage = drEmployee["CardID"]+" - "+drEmployee["EmployeeName"]+" đã đăng ký nghỉ";
                //    STT++;
                //    frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                //}
                //else if(ret == EmployeeStatus.EMPLOYEE_ABSENT)
                //{
                //    OverTimeMessage = drEmployee["CardID"]+" - "+drEmployee["EmployeeName"]+" vắng mặt";
                //    STT++;
                //    frmMessage.AddMessage(STT.ToString() + ". " + OverTimeMessage);
                //}
            }
            if (STT != 0)
            {
                frmMessage.Show();
            }
            else
            {
                frmMessage.Close();
                //Thông báo đăng ký làm thêm thành công
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Title");
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //				if ((this.Text =="Thêm đăng ký làm thêm giờ" )|| (this.Text == "Sửa đăng ký làm thêm giờ"))
                //				{
                //					MessageBox.Show("Đăng ký làm thêm giờ cho bộ phận " + departmentTreeView.SelectedNode.Text + " thành công!", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //				}
                //				else
                //				{
                //					MessageBox.Show(departmentTreeView.SelectedNode.Text +" の部門の残業登録が正常に完了しました !","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                //						
                //				}
            }
        }

        /// <summary>
        /// Thêm mới đăng ký làm thêm giờ
        /// </summary>
        //		public void AddEmployeeOverTime()
        //		{
        //			//disable  các trường liên quan đến nhân viên
        //			DataRow dr = dsRegOverTime.Tables[0].NewRow();
        //			dsRegOverTime.Tables[0].Rows.Add(SetData(dr));
        //
        //			int ret = 0;
        //			try
        //			{
        //				ret = regOverTimeDO.AddRegOverTime(dsRegOverTime);
        //			}
        //			catch
        //			{
        //				ret = 0;
        //			}
        //			if(ret == 1 || ret ==5)
        //			{
        //				string str = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Messa1");
        //				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Title");
        //				//MessageBox.Show("Đăng ký làm thêm giờ cho nhân viên thành công", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
        ////				this.Close();
        //			}
        //			else if (ret == -1) 
        //			{
        //				if (this.Text =="Thêm đăng ký làm thêm giờ")
        //				{
        //					MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký làm thêm giờ trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //				else
        //				{
        //					MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に残業登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //			}
        //			else if(ret == EmployeeStatus.EMPLOYEE_LEAVE)
        //			{
        //				if (this.Text =="Thêm đăng ký làm thêm giờ")
        //				{
        //					MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký đi công tác trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //				else
        //				{
        //					MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に出張登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //			}
        //			else if(ret == EmployeeStatus.EMPLOYEE_REST)
        //			{
        //				if (this.Text =="Thêm đăng ký làm thêm giờ")
        //				{
        //					MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký nghỉ trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //				else
        //				{
        //					MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に休暇登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //				
        //			}
        //			else if (ret == EmployeeStatus.EMPLOYEE_ABSENT)
        //			{
        //				if (this.Text =="Thêm đăng ký làm thêm giờ")
        //				{
        //					MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " hiện đang vắng mặt. Không thể đăng ký làm thêm cho nhân viên này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //				else
        //				{
        //					MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員が欠席中ので、この社員に残業登録できませんでした","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //				}
        //			}
        //			else 
        //			{
        //				string str = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Messa1");
        //				string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Title");
        //				//MessageBox.Show("Không thể đăng ký làm thêm giờ cho nhân viên này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //			}
        //		}

        /// <summary>
        /// Thiết lập dữ liệu đăng ký làm thêm giờ (dùng chung cho AddRegOverTime va` UpdateRegOverTime)
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private DataRow SetData(DataRow dr)
        {
            dr.BeginEdit();
            //			if (selectedRegOverTime < 0) //che do them moi
            //			{
            //				dr["EmployeeID"] = ((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col1;
            //			}
            dr["StartOverTime"] = dtpStartTimeOver.Value.ToShortTimeString();
            dr["Length"] = dtpLength.Value.ToShortTimeString();
            dr["WorkingDay"] = dtpDayWorking.Value.ToShortDateString();
            dr["WorkOverTimeInfo"] = txtWorkOverTimeInfo.Text;
            if (ckHaveDinner.Checked)
            {
                dr["DinnerAmount"] = Double.Parse(cboDinnnerAmount.Text);
            }
            else
            {
                dr["DinnerAmount"] = DBNull.Value;
            }
            dr.EndEdit();
            return dr;
        }

        /// <summary>
        /// Cập nhật đăng ký làm thêm giờ
        /// </summary>
        private void UpdateEmployeeOverTime()
        {
            DataRow dr = dtRegOverTime.Rows[selectedRegOverTime];
            dr = SetData(dr);
            string OverTimeMessage = string.Empty;
            int ret = 0;
            try
            {
                ret = regOverTimeDO.UpdateRegOverTime(dsRegOverTime);
            }
            catch
            {
                ret = 0;
            }

            switch (ret)
            {
                case 5: //Sửa đăng ký làm thêm thành công
                    MessageBox.Show(WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Messa1"),
                        WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Title"),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 10: //Sửa đăng ký làm thêm thành công
                    MessageBox.Show(WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Messa1"),
                        WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Title"),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case -1:
                    if (this.Text == "Thêm đăng ký làm thêm giờ")
                    {
                        MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " đã được đăng ký làm thêm giờ trong ngày này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に残業登録されています", "残業登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EmployeeStatus.EMPLOYEE_LEAVE:
                    if (this.Text == "Thêm đăng ký làm thêm giờ")
                    {
                        MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " đã được đăng ký đi công tác trong ngày này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に出張登録されています", "残業登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EmployeeStatus.EMPLOYEE_REST:
                    if (this.Text == "Thêm đăng ký làm thêm giờ")
                    {
                        MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " đã được đăng ký nghỉ trong ngày này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に休暇登録されています", "残業登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EmployeeStatus.EMPLOYEE_ABSENT:
                    if (this.Text == "Thêm đăng ký làm thêm giờ")
                    {
                        MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " hiện đang vắng mặt. Không thể đăng ký làm thêm cho nhân viên này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3 + " の社員が欠席中ので、この社員に残業登録できませんでした", "残業登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 11:
                    OverTimeMessage = "Thời gian đăng ký đã vượt thời gian làm thêm thực tế. Vui lòng kiểm tra lại!";
                    MessageBox.Show(this, OverTimeMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 12:
                    OverTimeMessage = "Thời gian làm thực tế không đủ để đăng ký làm thêm. Vui lòng kiểm tra lại!";
                    MessageBox.Show(this, OverTimeMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 13:
                    OverTimeMessage = "Không thể đăng ký làm thêm với nhân viên đăng ký nghỉ không phải là nghỉ phép 1/2 ngày. Vui lòng kiểm tra lại!";
                    MessageBox.Show(this, OverTimeMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    //MessageBox.Show("Không thể sửa đăng ký làm thêm giờ cho nhân viên này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Messa2"),
                        WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Title"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            //if (ret == 10 || ret == 5)
            //{
            //    string str = WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Messa1");
            //    string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Title");
            //    //MessageBox.Show("Sửa đăng ký làm thêm giờ cho nhân viên thành công", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else if (ret == -1) 
            //{
            //    if (this.Text =="Thêm đăng ký làm thêm giờ")
            //    {
            //        MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký làm thêm giờ trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に残業登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //else if(ret == EmployeeStatus.EMPLOYEE_LEAVE)
            //{
            //    if (this.Text =="Thêm đăng ký làm thêm giờ")
            //    {
            //        MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký đi công tác trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に出張登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //else if(ret == EmployeeStatus.EMPLOYEE_REST)
            //{
            //    if (this.Text =="Thêm đăng ký làm thêm giờ")
            //    {
            //        MessageBox.Show("Nhân viên "+((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3+ " đã được đăng ký nghỉ trong ngày này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員がこの日に休暇登録されています","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }

            //}
            //else if (ret == EmployeeStatus.EMPLOYEE_ABSENT)
            //{
            //    if (this.Text =="Thêm đăng ký làm thêm giờ")
            //    {
            //        MessageBox.Show("Nhân viên " + ((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " hiện đang vắng mặt. Không thể đăng ký làm thêm cho nhân viên này","Đăng ký làm thêm giờ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show(((MTGCComboBoxItem) cboEmployeeName.SelectedItem).Col3 + " の社員が欠席中ので、この社員に残業登録できませんでした","残業登録",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //else {
            //    string str = WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Messa2");
            //    string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_SuaDangKyOT_Title");
            //    //MessageBox.Show("Không thể sửa đăng ký làm thêm giờ cho nhân viên này", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Hiển thị dữ liệu đăng ký làm thêm giờ của một nhân viên
        /// </summary>
        private void LoadRegOverTime()
        {
            DataRow dr = dtRegOverTime.Rows[selectedRegOverTime];
            if (dr != null)
            {
                cboEmployeeName.Text = dr["CardID"].ToString();
                dtpDayWorking.Value = DateTime.Parse(dr["WorkingDay"].ToString());
                dtpStartTimeOver.Value = DateTime.Parse(dr["StartOverTime"].ToString());
                dtpLength.Value = DateTime.Parse(dr["Length"].ToString());
                txtWorkOverTimeInfo.Text = dr["WorkOverTimeInfo"].ToString();
                if (dr["DinnerAmount"] != DBNull.Value)
                {
                    ckHaveDinner.Checked = true;
                    cboDinnnerAmount.Enabled = true;
                    cboDinnnerAmount.Text = dr["DinnerAmount"].ToString();
                    //					txtDinnerAmount.Enabled = true;
                    //					txtDinnerAmount.Double = Double.Parse(dr["DinnerAmount"].ToString());
                }
                else
                {

                    ckHaveDinner.Checked = false;
                    cboDinnnerAmount.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Kiểm tra dữ liệu đầu vào
        /// </summary>
        /// <returns></returns>
        private string ValidateInputData()
        {
            if (cboEmployeeName.Text == "")
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa1");
                //return "Bạn phải chọn một nhân viên ! ";
                return str;
            }

            if (dtpDayWorking.Text == "")
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa2");
                //return "Bạn chưa chọn kiểu ngày ";
                return str;
            }

            return "";
        }

        #endregion

        #region Windows Form Events Handler

        private void frmRegOverTime_Load(object sender, EventArgs e)
        {
            Refresh();

            cboDinnnerAmount.Enabled = false;
            employeeDO = new EmployeeDO();

            departnemtDO = new DepartmentDO();
            departmentTreeView.DepartmentDataSet = departnemtDO.GetAllDepartments();
            departmentTreeView.BuildTree();
            departmentTreeView.ExpandNodes(true);
            departmentTreeView.SelectedNode = departmentTreeView.TopNode;

            regOverTimeDO = new RegOverTimeDO();
            dtRegOverTime = dsRegOverTime.Tables[0];

            if (selectedRegOverTime >= 0)
            {
                // disable các thuộc tính liên quan đến nhân viên
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Text2");
                //this.Text = "Sửa đăng ký làm thêm giờ";
                this.Text = str;
                LoadRegOverTime();
                //				optEmployee.Checked = true;
                departmentTreeView.Enabled = false;
                //				optAll.Enabled = false;
                dtpDayWorking.Enabled = false;
                cboEmployeeName.Enabled = false;
                lvwListEmployee.Enabled = false;
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Text1");
                //this.Text = "Thêm đăng ký làm thêm giờ";
                this.Text = str;
                txtEmployeeName.Enabled = false;
                cboEmployeeName.Enabled = false;


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa3");
            string str1 = WorkingContext.LangManager.GetString("frmRegOverTime1_DangKyOT_Title");
            //MessageBox.Show("Chức năng này đang được xây dựng", "Đăng ký làm thêm giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMsg = ValidateInputData();
            if (errMsg != "")
            {
                string str = WorkingContext.LangManager.GetString("frmRegOverTime1_Messa4");
                //MessageBox.Show(errMsg, "Lỗi đăng ký làm thêm giờ cho nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(errMsg, str, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (selectedRegOverTime >= 0)
                {
                    UpdateEmployeeOverTime();
                }
                else
                {
                    RegDepartmentOverTime();
                    //					if (optAll.Checked)
                    //					{
                    //						RegDepartmentOverTime();
                    //					}
                    //					else 
                    //					{
                    //						AddEmployeeOverTime();
                    //					}
                }
            }
        }

        private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            departmentTreeView.ExpandNodes(true);
            cboEmployeeName.Text = "";
            cboEmployeeName.Items.Clear();
            dsEmployee = employeeDO.GetEmployeeByDepartment((int)e.Node.Tag);
            cboEmployeeName.SourceDataString = new string[] { "EmployeeID", "CardID", "EmployeeName" };
            cboEmployeeName.SourceDataTable = dsEmployee.Tables[0];
            // kiểm tra nếu phòng có nhân viên thì hiển thị thông tin của nhân viên đầu tiên
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                cboEmployeeName.SelectedIndex = 0;
            }
            selectedDepartment = (int)departmentTreeView.SelectedNode.Tag;
            departmentTreeView.ExpandNodes(true);
            LoadEmployeeeInDepartment();
        }

        private void ckHaveDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHaveDinner.Checked)
            {
                cboDinnnerAmount.Enabled = true;
                if (cboDinnnerAmount.Items.Count > 2)
                    cboDinnnerAmount.SelectedIndex = 1;
            }
            else
            {
                cboDinnnerAmount.SelectedIndex = -1;
                cboDinnnerAmount.Enabled = false;
            }
        }

        //		private void optAll_CheckedChanged(object sender, EventArgs e)
        //		{
        //			cboEmployeeName.Enabled = false;
        //		}
        //
        //		private void optEmployee_CheckedChanged(object sender, EventArgs e)
        //		{
        //			cboEmployeeName.Enabled = true;
        //		}
        //
        #endregion
        //
        private void cboEmployeeName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtEmployeeName.Text = ((MTGCComboBoxItem)cboEmployeeName.SelectedItem).Col3;
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
            this.groupBox1.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_groupbox1");
            //			this.groupBox3.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_groupbox3");
            ////			this.optAll.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_groupbox1_optAll");
            //			this.optEmployee.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_groupbox1_optEm");
            this.label6.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lable6");
            this.groupBox2.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_groupbox2");
            this.label1.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lable1");
            this.label2.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lable2");
            this.label3.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lable3");
            this.lblLength.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lblLength");
            this.ckHaveDinner.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_ckHaveDinner");
            this.label5.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_lable5");
            this.btnClearAll.Text = WorkingContext.LangManager.GetString("frmLunch_btnClearAll");
            this.btnSelectAll.Text = WorkingContext.LangManager.GetString("frmLunch_btnSelectAll");
            this.btnSave.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_btnSave");
            this.btnClose.Text = WorkingContext.LangManager.GetString("frmRegOverTime1_btnClose");
        }
        /// <summary>
        /// Dien thong tin nhan vien un'g voi' phong duoc chon
        /// </summary>
        private void LoadEmployeeeInDepartment()
        {
            //			dsLunch = lunchDO.GetLunch((int)departmentTreeView.SelectedNode.Tag, dtpWorkingDay.Value.Date);
            dsEmployee = employeeDO.GetEmployeeByDepartment((int)departmentTreeView.SelectedNode.Tag);
            //			LunchDataRows = dsLunch.Tables[0].Select(dataFilter, dataSort);


            lvwListEmployee.BeginUpdate();
            lvwListEmployee.TableModel.Rows.Clear();

            int STT = 0;
            foreach (DataRow dr in dsEmployee.Tables[0].Rows)
            {
                string CardID = dr["CardID"].ToString();
                string EmployeeName = dr["EmployeeName"].ToString();
                string EmployeeID = dr["EmployeeID"].ToString();
                Cell[] cells = new Cell[4];
                cells[0] = new Cell(STT + 1);
                cells[1] = new Cell(CardID);
                cells[2] = new Cell(EmployeeName);
                cells[3] = new Cell(EmployeeID);
                Row row = new Row(cells);
                row.Tag = STT;
                lvwListEmployee.TableModel.Rows.Add(row);
                STT++;
            }
            lvwListEmployee.EndUpdate();

        }

        /// <summary>
        /// Chon tat ca nhung nguoi trong phong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {

            tableModel1.Selections.SelectCells(0, 0, lvwListEmployee.RowCount - 1, 0);
        }


        private void txtEmployeeName_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, System.EventArgs e)
        {
            tableModel1.Selections.Clear();
        }
    }
}