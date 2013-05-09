using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Form cho phép thiết lập ca làm việc cho các bộ phận trong công ty.
    /// </summary>
    public class frmShift : System.Windows.Forms.Form
    {
        #region Thiết kế
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private ShiftDO shiftDO = null;
        private DataSet dsShift = null;
        private DataSet dsShiftOver = null;
        private DataTable dtShift = null;
        private DataTable dtShiftOver = null;
        private DataRow dr = null;
        int EditStatus = 0;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private CheckBox checkBox2;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox4;
        private Label label15;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox4;
        private CheckBox checkBox3;
        private TextBox textBox5;
        private Label label16;
        private TextBox textBox6;
        private Label label17;
        private Button button1;
        private Button button2;
        private GroupBox groupBox5;
        public DateTimePicker dateTimePicker1;
        private Label label18;
        public DateTimePicker dateTimePicker2;
        private Label label19;
        public DateTimePicker dateTimePicker3;
        public DateTimePicker dateTimePicker4;
        public DateTimePicker dateTimePicker5;
        private Label label20;
        public DateTimePicker dateTimePicker6;
        private Label label21;
        public DateTimePicker dateTimePicker7;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        public DateTimePicker dateTimePicker8;
        public DateTimePicker dateTimePicker9;
        private CheckBox checkBox4;
        private TextBox textBox7;
        private Label label27;
        private TextBox textBox8;
        private Label label28;
        public DateTimePicker dateTimePicker10;
        private Label label31;
        public DateTimePicker dateTimePicker11;
        private Label label32;
        public DateTimePicker dateTimePicker12;
        public DateTimePicker dateTimePicker13;
        public DateTimePicker dateTimePicker14;
        private Label label33;
        public DateTimePicker dateTimePicker15;
        private Label label34;
        public DateTimePicker dateTimePicker16;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        public DateTimePicker dateTimePicker17;
        public DateTimePicker dateTimePicker18;
        private GroupBox grbDetail;
        private Label lblMinute1;
        public DateTimePicker dtpCheckIn1;
        public DateTimePicker dtpCheckOut2;
        private Label lblShift1;
        public DateTimePicker dtpCheckOut1;
        private Label lblShift2;
        private Label lblDeltaAllowCheck;
        private Label lblMinute2;
        public DateTimePicker dtpCheckIn2;
        private Button btnUpdate;
        private Button btnClose;
        private GroupBox grbInfo;
        private CheckBox chkBreakShift;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtShiftName;
        private Label lblShiftName;
        private SplitContainer spcAll;
        private SplitContainer spcDetail;
        private TextBox txtDeltaAllowCheck;
        private TextBox txtDeltaLateTime;
        private Label lblDeltaLateTime;

        public System.Windows.Forms.DateTimePicker dTPLamThemDC;
        public System.Windows.Forms.DateTimePicker dTPDiSomCP;
        public System.Windows.Forms.DateTimePicker dTPDiMuonCP;
        public System.Windows.Forms.DateTimePicker dTPGioDauCa;
        public System.Windows.Forms.DateTimePicker dTPLamThemCC;
        public System.Windows.Forms.DateTimePicker dTPVeSomCP;
        public System.Windows.Forms.DateTimePicker dTPVeMuonCP;
        public System.Windows.Forms.DateTimePicker dTPChieuDaiCa;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShift));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.dateTimePicker12 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker13 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker14 = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.dateTimePicker15 = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.dateTimePicker16 = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.dateTimePicker17 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker18 = new System.Windows.Forms.DateTimePicker();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.lblDeltaLateTime = new System.Windows.Forms.Label();
            this.txtDeltaAllowCheck = new System.Windows.Forms.TextBox();
            this.txtDeltaLateTime = new System.Windows.Forms.TextBox();
            this.lblMinute1 = new System.Windows.Forms.Label();
            this.dtpCheckIn1 = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut2 = new System.Windows.Forms.DateTimePicker();
            this.lblShift1 = new System.Windows.Forms.Label();
            this.dtpCheckOut1 = new System.Windows.Forms.DateTimePicker();
            this.lblShift2 = new System.Windows.Forms.Label();
            this.lblDeltaAllowCheck = new System.Windows.Forms.Label();
            this.lblMinute2 = new System.Windows.Forms.Label();
            this.dtpCheckIn2 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.chkBreakShift = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtShiftName = new System.Windows.Forms.TextBox();
            this.lblShiftName = new System.Windows.Forms.Label();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.spcDetail = new System.Windows.Forms.SplitContainer();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            this.spcDetail.Panel1.SuspendLayout();
            this.spcDetail.Panel2.SuspendLayout();
            this.spcDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(184, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Ca đi muộn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(8, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mô tả";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên ca";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(184, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Ca đi muộn";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(304, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(8, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mô tả";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(8, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tên ca";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(22, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 48);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính công";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(226, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 công";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "0,5 công";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(23, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 72);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin ca";
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(184, 15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(160, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Ca đi muộn";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(56, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(304, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(8, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mô tả";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(56, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(8, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tên ca";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(311, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "&Đóng";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(231, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "&Đồng ý";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.dateTimePicker3);
            this.groupBox5.Controls.Add(this.dateTimePicker4);
            this.groupBox5.Controls.Add(this.dateTimePicker5);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.dateTimePicker6);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.dateTimePicker7);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.dateTimePicker8);
            this.groupBox5.Controls.Add(this.dateTimePicker9);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(23, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 162);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết ca";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(8, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 23);
            this.label18.TabIndex = 40;
            this.label18.Text = "Thời gian ăn trưa";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(248, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 23);
            this.label19.TabIndex = 33;
            this.label19.Text = "Về muộn cho phép";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(120, 16);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker3.TabIndex = 3;
            this.dateTimePicker3.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH:mm";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(184, 40);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker4.TabIndex = 6;
            this.dateTimePicker4.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH:mm";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(184, 64);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.ShowUpDown = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker5.TabIndex = 8;
            this.dateTimePicker5.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(8, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 23);
            this.label20.TabIndex = 9;
            this.label20.Text = "Giờ đầu ca";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "HH:mm";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(184, 88);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.ShowUpDown = true;
            this.dateTimePicker6.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker6.TabIndex = 10;
            this.dateTimePicker6.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(248, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "Làm thêm cuối ca";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "HH:mm";
            this.dateTimePicker7.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(184, 16);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.ShowUpDown = true;
            this.dateTimePicker7.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker7.TabIndex = 4;
            this.dateTimePicker7.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.Location = new System.Drawing.Point(8, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 23);
            this.label22.TabIndex = 31;
            this.label22.Text = "Làm thêm đầu ca";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.Location = new System.Drawing.Point(8, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 23);
            this.label23.TabIndex = 29;
            this.label23.Text = "Đi sớm cho phép";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.Location = new System.Drawing.Point(248, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 23);
            this.label24.TabIndex = 27;
            this.label24.Text = "Chiều dài ca";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label25.Location = new System.Drawing.Point(248, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 24);
            this.label25.TabIndex = 35;
            this.label25.Text = "Về sớm cho phép";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label26.Location = new System.Drawing.Point(8, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 23);
            this.label26.TabIndex = 39;
            this.label26.Text = "Đi muộn cho phép";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CustomFormat = "HH:mm";
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(120, 40);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.ShowUpDown = true;
            this.dateTimePicker8.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker8.TabIndex = 5;
            this.dateTimePicker8.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.CustomFormat = "HH:mm";
            this.dateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker9.Location = new System.Drawing.Point(120, 64);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.ShowUpDown = true;
            this.dateTimePicker9.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker9.TabIndex = 7;
            this.dateTimePicker9.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(184, 15);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(160, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ca đi muộn";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(56, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(304, 20);
            this.textBox7.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label27.Location = new System.Drawing.Point(8, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 23);
            this.label27.TabIndex = 1;
            this.label27.Text = "Mô tả";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(56, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(120, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label28.Location = new System.Drawing.Point(8, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 23);
            this.label28.TabIndex = 0;
            this.label28.Text = "Tên ca";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.CustomFormat = "HH:mm";
            this.dateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker10.Location = new System.Drawing.Point(120, 112);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.ShowUpDown = true;
            this.dateTimePicker10.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker10.TabIndex = 41;
            this.dateTimePicker10.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label31.Location = new System.Drawing.Point(8, 112);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(104, 23);
            this.label31.TabIndex = 40;
            this.label31.Text = "Thời gian ăn trưa";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.CustomFormat = "HH:mm";
            this.dateTimePicker11.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker11.Location = new System.Drawing.Point(120, 88);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.ShowUpDown = true;
            this.dateTimePicker11.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker11.TabIndex = 9;
            this.dateTimePicker11.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.Location = new System.Drawing.Point(248, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(112, 23);
            this.label32.TabIndex = 33;
            this.label32.Text = "Về muộn cho phép";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker12
            // 
            this.dateTimePicker12.CustomFormat = "HH:mm";
            this.dateTimePicker12.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker12.Location = new System.Drawing.Point(120, 16);
            this.dateTimePicker12.Name = "dateTimePicker12";
            this.dateTimePicker12.ShowUpDown = true;
            this.dateTimePicker12.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker12.TabIndex = 3;
            this.dateTimePicker12.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // dateTimePicker13
            // 
            this.dateTimePicker13.CustomFormat = "HH:mm";
            this.dateTimePicker13.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker13.Location = new System.Drawing.Point(184, 40);
            this.dateTimePicker13.Name = "dateTimePicker13";
            this.dateTimePicker13.ShowUpDown = true;
            this.dateTimePicker13.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker13.TabIndex = 6;
            this.dateTimePicker13.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker14
            // 
            this.dateTimePicker14.CustomFormat = "HH:mm";
            this.dateTimePicker14.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker14.Location = new System.Drawing.Point(184, 64);
            this.dateTimePicker14.Name = "dateTimePicker14";
            this.dateTimePicker14.ShowUpDown = true;
            this.dateTimePicker14.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker14.TabIndex = 8;
            this.dateTimePicker14.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label33.Location = new System.Drawing.Point(8, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 23);
            this.label33.TabIndex = 9;
            this.label33.Text = "Giờ đầu ca";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker15
            // 
            this.dateTimePicker15.CustomFormat = "HH:mm";
            this.dateTimePicker15.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker15.Location = new System.Drawing.Point(184, 88);
            this.dateTimePicker15.Name = "dateTimePicker15";
            this.dateTimePicker15.ShowUpDown = true;
            this.dateTimePicker15.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker15.TabIndex = 10;
            this.dateTimePicker15.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label34.Location = new System.Drawing.Point(248, 40);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(112, 24);
            this.label34.TabIndex = 37;
            this.label34.Text = "Làm thêm cuối ca";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker16
            // 
            this.dateTimePicker16.CustomFormat = "HH:mm";
            this.dateTimePicker16.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker16.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker16.Location = new System.Drawing.Point(184, 16);
            this.dateTimePicker16.Name = "dateTimePicker16";
            this.dateTimePicker16.ShowUpDown = true;
            this.dateTimePicker16.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker16.TabIndex = 4;
            this.dateTimePicker16.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(8, 40);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(104, 23);
            this.label35.TabIndex = 31;
            this.label35.Text = "Làm thêm đầu ca";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label36.Location = new System.Drawing.Point(8, 64);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(104, 23);
            this.label36.TabIndex = 29;
            this.label36.Text = "Đi sớm cho phép";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.Location = new System.Drawing.Point(248, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(112, 23);
            this.label37.TabIndex = 27;
            this.label37.Text = "Chiều dài ca";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(248, 64);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(112, 24);
            this.label38.TabIndex = 35;
            this.label38.Text = "Về sớm cho phép";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label39.Location = new System.Drawing.Point(8, 88);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(104, 23);
            this.label39.TabIndex = 39;
            this.label39.Text = "Đi muộn cho phép";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker17
            // 
            this.dateTimePicker17.CustomFormat = "HH:mm";
            this.dateTimePicker17.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker17.Location = new System.Drawing.Point(120, 40);
            this.dateTimePicker17.Name = "dateTimePicker17";
            this.dateTimePicker17.ShowUpDown = true;
            this.dateTimePicker17.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker17.TabIndex = 5;
            this.dateTimePicker17.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker18
            // 
            this.dateTimePicker18.CustomFormat = "HH:mm";
            this.dateTimePicker18.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker18.Location = new System.Drawing.Point(120, 64);
            this.dateTimePicker18.Name = "dateTimePicker18";
            this.dateTimePicker18.ShowUpDown = true;
            this.dateTimePicker18.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker18.TabIndex = 7;
            this.dateTimePicker18.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.lblDeltaLateTime);
            this.grbDetail.Controls.Add(this.txtDeltaAllowCheck);
            this.grbDetail.Controls.Add(this.txtDeltaLateTime);
            this.grbDetail.Controls.Add(this.lblMinute1);
            this.grbDetail.Controls.Add(this.dtpCheckIn1);
            this.grbDetail.Controls.Add(this.dtpCheckOut2);
            this.grbDetail.Controls.Add(this.lblShift1);
            this.grbDetail.Controls.Add(this.dtpCheckOut1);
            this.grbDetail.Controls.Add(this.lblShift2);
            this.grbDetail.Controls.Add(this.lblDeltaAllowCheck);
            this.grbDetail.Controls.Add(this.lblMinute2);
            this.grbDetail.Controls.Add(this.dtpCheckIn2);
            this.grbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbDetail.Location = new System.Drawing.Point(0, 0);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(421, 138);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết ca";
            // 
            // lblDeltaLateTime
            // 
            this.lblDeltaLateTime.AutoSize = true;
            this.lblDeltaLateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDeltaLateTime.Location = new System.Drawing.Point(10, 25);
            this.lblDeltaLateTime.Name = "lblDeltaLateTime";
            this.lblDeltaLateTime.Size = new System.Drawing.Size(93, 13);
            this.lblDeltaLateTime.TabIndex = 43;
            this.lblDeltaLateTime.Text = "Đi muộn cho phép";
            this.lblDeltaLateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeltaAllowCheck
            // 
            this.txtDeltaAllowCheck.Location = new System.Drawing.Point(235, 108);
            this.txtDeltaAllowCheck.Name = "txtDeltaAllowCheck";
            this.txtDeltaAllowCheck.Size = new System.Drawing.Size(75, 20);
            this.txtDeltaAllowCheck.TabIndex = 5;
            // 
            // txtDeltaLateTime
            // 
            this.txtDeltaLateTime.Location = new System.Drawing.Point(120, 21);
            this.txtDeltaLateTime.Name = "txtDeltaLateTime";
            this.txtDeltaLateTime.Size = new System.Drawing.Size(75, 20);
            this.txtDeltaLateTime.TabIndex = 0;
            // 
            // lblMinute1
            // 
            this.lblMinute1.AutoSize = true;
            this.lblMinute1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMinute1.Location = new System.Drawing.Point(195, 25);
            this.lblMinute1.Name = "lblMinute1";
            this.lblMinute1.Size = new System.Drawing.Size(29, 13);
            this.lblMinute1.TabIndex = 40;
            this.lblMinute1.Text = "phút";
            this.lblMinute1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckIn1
            // 
            this.dtpCheckIn1.CustomFormat = "HH:mm";
            this.dtpCheckIn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn1.Location = new System.Drawing.Point(120, 50);
            this.dtpCheckIn1.Name = "dtpCheckIn1";
            this.dtpCheckIn1.ShowUpDown = true;
            this.dtpCheckIn1.Size = new System.Drawing.Size(75, 20);
            this.dtpCheckIn1.TabIndex = 1;
            this.dtpCheckIn1.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // dtpCheckOut2
            // 
            this.dtpCheckOut2.CustomFormat = "HH:mm";
            this.dtpCheckOut2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut2.Location = new System.Drawing.Point(203, 79);
            this.dtpCheckOut2.Name = "dtpCheckOut2";
            this.dtpCheckOut2.ShowUpDown = true;
            this.dtpCheckOut2.Size = new System.Drawing.Size(75, 20);
            this.dtpCheckOut2.TabIndex = 4;
            this.dtpCheckOut2.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // lblShift1
            // 
            this.lblShift1.AutoSize = true;
            this.lblShift1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShift1.Location = new System.Drawing.Point(10, 54);
            this.lblShift1.Name = "lblShift1";
            this.lblShift1.Size = new System.Drawing.Size(100, 13);
            this.lblShift1.TabIndex = 9;
            this.lblShift1.Text = "Thời gian làm việc 1";
            this.lblShift1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckOut1
            // 
            this.dtpCheckOut1.CustomFormat = "HH:mm";
            this.dtpCheckOut1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpCheckOut1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut1.Location = new System.Drawing.Point(203, 50);
            this.dtpCheckOut1.Name = "dtpCheckOut1";
            this.dtpCheckOut1.ShowUpDown = true;
            this.dtpCheckOut1.Size = new System.Drawing.Size(75, 20);
            this.dtpCheckOut1.TabIndex = 2;
            this.dtpCheckOut1.Value = new System.DateTime(2005, 9, 1, 8, 0, 0, 0);
            // 
            // lblShift2
            // 
            this.lblShift2.AutoSize = true;
            this.lblShift2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShift2.Location = new System.Drawing.Point(10, 83);
            this.lblShift2.Name = "lblShift2";
            this.lblShift2.Size = new System.Drawing.Size(100, 13);
            this.lblShift2.TabIndex = 31;
            this.lblShift2.Text = "Thời gian làm việc 2";
            this.lblShift2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeltaAllowCheck
            // 
            this.lblDeltaAllowCheck.AutoSize = true;
            this.lblDeltaAllowCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDeltaAllowCheck.Location = new System.Drawing.Point(10, 112);
            this.lblDeltaAllowCheck.Name = "lblDeltaAllowCheck";
            this.lblDeltaAllowCheck.Size = new System.Drawing.Size(220, 13);
            this.lblDeltaAllowCheck.TabIndex = 29;
            this.lblDeltaAllowCheck.Text = "Khoảng ghi nhận sau về 1 hoặc trước đến 2:";
            this.lblDeltaAllowCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinute2
            // 
            this.lblMinute2.AutoSize = true;
            this.lblMinute2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMinute2.Location = new System.Drawing.Point(310, 112);
            this.lblMinute2.Name = "lblMinute2";
            this.lblMinute2.Size = new System.Drawing.Size(29, 13);
            this.lblMinute2.TabIndex = 39;
            this.lblMinute2.Text = "phút";
            this.lblMinute2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckIn2
            // 
            this.dtpCheckIn2.CustomFormat = "HH:mm";
            this.dtpCheckIn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn2.Location = new System.Drawing.Point(120, 79);
            this.dtpCheckIn2.Name = "dtpCheckIn2";
            this.dtpCheckIn2.ShowUpDown = true;
            this.dtpCheckIn2.Size = new System.Drawing.Size(75, 20);
            this.dtpCheckIn2.TabIndex = 3;
            this.dtpCheckIn2.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(250, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&Đồng ý";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(333, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.chkBreakShift);
            this.grbInfo.Controls.Add(this.txtDescription);
            this.grbInfo.Controls.Add(this.lblDescription);
            this.grbInfo.Controls.Add(this.txtShiftName);
            this.grbInfo.Controls.Add(this.lblShiftName);
            this.grbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbInfo.Location = new System.Drawing.Point(0, 0);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(421, 101);
            this.grbInfo.TabIndex = 0;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin ca";
            // 
            // chkBreakShift
            // 
            this.chkBreakShift.AutoSize = true;
            this.chkBreakShift.Checked = true;
            this.chkBreakShift.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBreakShift.Location = new System.Drawing.Point(184, 23);
            this.chkBreakShift.Name = "chkBreakShift";
            this.chkBreakShift.Size = new System.Drawing.Size(59, 17);
            this.chkBreakShift.TabIndex = 1;
            this.chkBreakShift.Text = "Ca gãy";
            this.chkBreakShift.CheckedChanged += new System.EventHandler(this.chkBreakShift_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(56, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 44);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDescription.Location = new System.Drawing.Point(10, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(34, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Mô tả";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShiftName
            // 
            this.txtShiftName.Location = new System.Drawing.Point(56, 21);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(120, 20);
            this.txtShiftName.TabIndex = 0;
            // 
            // lblShiftName
            // 
            this.lblShiftName.AutoSize = true;
            this.lblShiftName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShiftName.Location = new System.Drawing.Point(10, 25);
            this.lblShiftName.Name = "lblShiftName";
            this.lblShiftName.Size = new System.Drawing.Size(39, 13);
            this.lblShiftName.TabIndex = 0;
            this.lblShiftName.Text = "Tên ca";
            this.lblShiftName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spcAll
            // 
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.IsSplitterFixed = true;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Name = "spcAll";
            this.spcAll.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.grbInfo);
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.spcDetail);
            this.spcAll.Size = new System.Drawing.Size(421, 297);
            this.spcAll.SplitterDistance = 101;
            this.spcAll.TabIndex = 0;
            // 
            // spcDetail
            // 
            this.spcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcDetail.IsSplitterFixed = true;
            this.spcDetail.Location = new System.Drawing.Point(0, 0);
            this.spcDetail.Name = "spcDetail";
            this.spcDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcDetail.Panel1
            // 
            this.spcDetail.Panel1.Controls.Add(this.grbDetail);
            // 
            // spcDetail.Panel2
            // 
            this.spcDetail.Panel2.Controls.Add(this.btnClose);
            this.spcDetail.Panel2.Controls.Add(this.btnUpdate);
            this.spcDetail.Size = new System.Drawing.Size(421, 192);
            this.spcDetail.SplitterDistance = 138;
            this.spcDetail.TabIndex = 0;
            // 
            // frmShift
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(421, 297);
            this.Controls.Add(this.spcAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa ca làm việc";
            this.Load += new System.EventHandler(this.frmShift_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel2.ResumeLayout(false);
            this.spcAll.ResumeLayout(false);
            this.spcDetail.Panel1.ResumeLayout(false);
            this.spcDetail.Panel2.ResumeLayout(false);
            this.spcDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        #endregion

        #region Khai báo
        private bool bBreakShift = false;
        private int currentShift = -1;

        public DataSet DsOverTime
        {
            get { return dsShift; }
            set { dsShift = value; }
        }

        public DataSet DsShiftOverTime
        {
            get { return dsShiftOver; }
            set { dsShiftOver = value; }
        }

        public int CurrentShift
        {
            get { return currentShift; }
            set { currentShift = value; }
        }
        #endregion

        #region Khởi tạo
        public frmShift()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public frmShift(int i)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #endregion

        #region Hàm khai báo
        /// <summary>
        /// Khởi tạo giá trị mặc định của form
        /// </summary>
        private void DefaultValue()
        {
            txtShiftName.Text = "";
            txtDescription.Text = "";
            txtDeltaLateTime.Text = "15";
            dtpCheckIn1.Text = "08:00";
            dtpCheckOut1.Text = "08:00";
            dtpCheckOut2.Text = "08:00";
            dtpCheckIn2.Text = "08:00";
            txtDeltaAllowCheck.Text = "30";
        }

        /// <summary>
        /// Hiển thị thông tin của ca làm việc đã định nghĩa lên form
        /// </summary>
        private void LoadShiftData()
        {
            txtShiftName.DataBindings.Add("Text", dtShift, "ShiftName");
            txtDescription.DataBindings.Add("Text", dtShift, "Description");
            bBreakShift = bool.Parse(dtShift.Rows[currentShift]["BreakShift"].ToString());
            chkBreakShift.Checked = bBreakShift;
            txtDeltaLateTime.DataBindings.Add("Text", dtShift, "DeltaLateTime");
            dtpCheckOut1.DataBindings.Add("Value", dtShift, "CheckOut1");
            dtpCheckIn1.DataBindings.Add("Value", dtShift, "CheckIn1");
            dtpCheckOut2.DataBindings.Add("Value", dtShift, "CheckOut2");
            dtpCheckIn2.DataBindings.Add("Value", dtShift, "CheckIn2");
            txtDeltaAllowCheck.DataBindings.Add("Text", dtShift, "DeltaAllowCheck");
        }

        /// <summary>
        /// Lấy dữ liệu Input phục vụ cho việc thêm, sửa
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private DataRow SetData(DataRow dr)
        {
            dr.BeginEdit();

            dr["ShiftName"] = txtShiftName.Text.Trim();
            dr["Description"] = txtDescription.Text.Trim();
            dr["BreakShift"] = chkBreakShift.Checked ? 1 : 0;
            dr["DeltaLateTime"] = txtDeltaLateTime.Text;
            dr["CheckIn1"] = dtpCheckIn1.Value.ToShortTimeString();
            dr["CheckOut1"] = dtpCheckOut1.Value.ToShortTimeString();
            if (chkBreakShift.Checked)
            {
                dr["CheckIn2"] = dtpCheckIn2.Value.ToShortTimeString(); ;
                dr["CheckOut2"] = dtpCheckOut2.Value.ToShortTimeString();
                dr["DeltaAllowCheck"] = Convert.ToInt32(txtDeltaAllowCheck.Text);
            }

            dr.EndEdit();

            return dr;
        }

        /// <summary>
        /// thêm ca mới
        /// </summary>
        private void AddShift()
        {
            //dataSet = new DataSet();
            dtShift = dsShift.Tables[0];

            dr = dtShift.NewRow();

            dtShift.Rows.Add(SetData(dr));

            int ret = 0;
            try
            {
                ret = shiftDO.AddShift(dsShift);
            }
            catch
            {

            }
            if (ret == 1)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Add_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Add_Title");
                //MessageBox.Show("Tên ca đã tồn tại trong hệ thống. Không thể thêm ca này !", "Lỗi thêm ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsShift.RejectChanges();
            }
            if (ret == 2)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Add_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Đã thêm ca thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsShift.AcceptChanges();
                this.Close();
                EditStatus = 0;
            }
            if (ret == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Add_Messa2");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Có lỗi xảy ra .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsShift.RejectChanges();
            }

        }

        /// <summary>
        /// Cập nhật ca làm việc
        /// </summary>
        private void UpdateShift()
        {
            DataRow dr = dtShift.Rows[this.BindingContext[dtShift].Position];
            dr = SetData(dr);
            int ret = 0;
            try
            {
                ret = shiftDO.UpdateShift(dsShift);
            }
            catch
            {

            }
            if (ret == 1)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Update_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title");
                //MessageBox.Show("Tên ca đã tồn tại trong hệ thống, không thể cập nhật ca này !", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsShift.RejectChanges();
            }
            if (ret == 2)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Update_Messa2");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Đã sửa ca thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsShift.AcceptChanges();
                this.Close();
            }
            if (ret == 0)
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Update_Messa3");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Có lỗi xảy ra .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);	
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dsShift.RejectChanges();
            }
        }
        #endregion

        #region Hàm sự kiện
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (CheckData())
            {
                if (EditStatus == 0)// chế độ sửa ca
                {
                    UpdateShift();
                }
                else// thêm ca
                {
                    AddShift();
                    // sau khi thêm chuyển lại chế độ sửa ca
                }
            }

        }

        private bool CheckData()
        {
            if (txtShiftName.Text == "")
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Update_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Chưa nhập tên ca","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            int iMinute = 0;
            if (txtDeltaLateTime.Text == "" || (!Int32.TryParse(txtDeltaLateTime.Text, out iMinute) && txtDeltaLateTime.Text.Length != 0))
            {
                string str = "Thông tin thời gian đi muộn chưa đúng. Vui lòng kiểm tra lại!";
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Chưa nhập tên ca","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (chkBreakShift.Checked && (txtDeltaAllowCheck.Text == "" || (!Int32.TryParse(txtDeltaAllowCheck.Text, out iMinute) && txtDeltaAllowCheck.Text.Length != 0)))
            {
                string str = "Thông tin thời gian ghi nhận quẹt thẻ của lần quẹt thẻ về 1 và đến 2 chưa đúng. Vui lòng kiểm tra lại!";
                string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
                //MessageBox.Show("Chưa nhập tên ca","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void chkBreakShift_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBreakShift.Checked)
            {
                lblShift1.Text = "Thời gian làm việc 1";
                dtpCheckOut2.Text = "08:00";
                dtpCheckIn2.Text = "08:00";
                txtDeltaAllowCheck.Text = "30";

                lblShift2.Visible = true;
                dtpCheckIn2.Visible = true;
                dtpCheckOut2.Visible = true;
                lblDeltaAllowCheck.Visible = true;
                txtDeltaAllowCheck.Visible = true;
                lblMinute2.Visible = true;
            }
            else
            {
                lblShift1.Text = "Thời gian làm việc";

                lblShift2.Visible = false;
                dtpCheckIn2.Visible = false;
                dtpCheckOut2.Visible = false;
                lblDeltaAllowCheck.Visible = false;
                txtDeltaAllowCheck.Visible = false;
                lblMinute2.Visible = false;
            }
        }
        #endregion


        public override void Refresh()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();
        }

        private void frmShift_Load(object sender, System.EventArgs e)
        {
            Refresh();

            shiftDO = new ShiftDO();

            if (dsShift != null)
            {
                //tbShift.;

                txtShiftName.Focus();
                EditStatus = 0; // chế độ sửa
                dtShift = dsShift.Tables[0];
                if (currentShift >= 0)
                {
                    string str = WorkingContext.LangManager.GetString("frmShift_Text2");
                    this.Text = str;
                    //this.Text = "Sửa ca làm việc ";
                    // Hiển thị thông nhân viên
                    if (dsShift != null)
                        LoadShiftData();


                    this.BindingContext[dtShift].Position = currentShift;
                }
            }
            else if (dsShiftOver != null)
            {
                //tabPage1.Enabled = false;
                //tbShift.SelectedIndex = 1;
                //txtShiftOverName.Focus();
                //EditStatus = 0; // chế độ sửa
                //dtShiftOver = dsShiftOver.Tables[0];
                ////int thu = dsShiftOver.Tables[0].Rows.Count;

                //if (currentShift >= 0)
                //{
                //    string str = WorkingContext.LangManager.GetString("frmShift_Text2");
                //    this.Text = str;
                //    //this.Text = "Sửa ca làm việc ";
                //    // Hiển thị thông nhân viên
                //    LoadShiftOverData();


                //    this.BindingContext[dtShiftOver].Position = currentShift;
                //}

            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmShift_Text1");
                this.Text = str;
                EditStatus = 1; //chế độ thêm mới
                shiftDO = new ShiftDO();
                dsShift = shiftDO.GetShift();
                DefaultValue();
            }

        }

    }
}
