//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	Form cập nhật trạng thái của nhân viên
//Note	    :		  
//Author	: chinhnd
//Modify	: chinhnd 8-2005
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
//using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Form cập nhật trạng thái các nhân viên trong công ty: cập nhật số người đang ở trong công ty, số người nghỉ trong ngày
	/// </summary>
	// Cập nhật trạng thái của nhân viên trong công ty: mỗi mầu đại diện cho trạng thái khác nhau. Ví dụ: đỏ là có trong công ty
	// trắng là đang ở ngoài công ty
	public class frmEmployeeStatus : Form
	{
		private TextBox txtSearch;
		private GroupBox grbChonPhong;
		private Label lblChonPhong;
		private System.ComponentModel.IContainer components;

		private GroupBox groupBox2;
		private LookupComboBox cboDepartment;
		private Button btnClose;
		private Button btnRefresh;
		private Panel pnEmployee;
		private GroupBox grbEmployee;
		private Button btnOptions;
		private Label label1;
		private Label lblTotal;
		private int totalLate = 0;
		private LookupComboBox cboSort;
		private Label lblSort;
		private TextBox txtRecordNum;
		private Button btnLast;
		private Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label lblTotalLeave;
		private System.Windows.Forms.Label lblTotalAbsent;
		private System.Windows.Forms.Label lblTotalEmployee;
		private System.Windows.Forms.Label lblAbsent;
		private DataSet dsDepartment = null;
		private DataSet dsEmployeeRest = null;
		private DataSet dsEmployeeLate = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblWorking;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label lblHome;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboStatusFilter;
		private System.Windows.Forms.Label lblLate;
		private System.Windows.Forms.Label lblTotalLate;
		private DataSet dsEmployeeStatistics = null;
		private int RowCount;

		public frmEmployeeStatus()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeStatus));
            this.grbChonPhong = new System.Windows.Forms.GroupBox();
            this.cboSort = new System.Windows.Forms.LookupComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.LookupComboBox();
            this.lblChonPhong = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalLate = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWorking = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAbsent = new System.Windows.Forms.Label();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalLeave = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnEmployee = new System.Windows.Forms.Panel();
            this.grbEmployee = new System.Windows.Forms.GroupBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.txtRecordNum = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbChonPhong.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChonPhong
            // 
            this.grbChonPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChonPhong.Controls.Add(this.cboSort);
            this.grbChonPhong.Controls.Add(this.lblSort);
            this.grbChonPhong.Controls.Add(this.cboDepartment);
            this.grbChonPhong.Controls.Add(this.lblChonPhong);
            this.grbChonPhong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbChonPhong.Location = new System.Drawing.Point(8, 8);
            this.grbChonPhong.Name = "grbChonPhong";
            this.grbChonPhong.Size = new System.Drawing.Size(208, 72);
            this.grbChonPhong.TabIndex = 0;
            this.grbChonPhong.TabStop = false;
            this.grbChonPhong.Text = "Chọn bộ phận";
            // 
            // cboSort
            // 
            this.cboSort.AllowTypeAllSymbols = false;
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.Items.AddRange(new object[] {
            "Theo mã thẻ",
            "Theo họ tên",
            "Theo trạng thái",
            "Theo số thẻ vàng",
            "Theo số thẻ đỏ"});
            this.cboSort.Location = new System.Drawing.Point(80, 40);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(120, 21);
            this.cboSort.TabIndex = 1;
            // 
            // lblSort
            // 
            this.lblSort.BackColor = System.Drawing.SystemColors.Control;
            this.lblSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSort.ForeColor = System.Drawing.Color.Black;
            this.lblSort.Location = new System.Drawing.Point(8, 40);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(72, 23);
            this.lblSort.TabIndex = 5;
            this.lblSort.Text = "Sắp xếp";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDepartment
            // 
            this.cboDepartment.AllowTypeAllSymbols = false;
            this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Location = new System.Drawing.Point(80, 16);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(120, 21);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.cboDepartment_Validating);
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // lblChonPhong
            // 
            this.lblChonPhong.BackColor = System.Drawing.SystemColors.Control;
            this.lblChonPhong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChonPhong.ForeColor = System.Drawing.Color.Black;
            this.lblChonPhong.Location = new System.Drawing.Point(8, 16);
            this.lblChonPhong.Name = "lblChonPhong";
            this.lblChonPhong.Size = new System.Drawing.Size(72, 23);
            this.lblChonPhong.TabIndex = 0;
            this.lblChonPhong.Text = "Tên bộ phận";
            this.lblChonPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(8, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(88, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(8, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tổng số:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAbsent
            // 
            this.lblAbsent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAbsent.BackColor = System.Drawing.SystemColors.Control;
            this.lblAbsent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAbsent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAbsent.ForeColor = System.Drawing.Color.Black;
            this.lblAbsent.Location = new System.Drawing.Point(120, 45);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(56, 23);
            this.lblAbsent.TabIndex = 3;
            this.lblAbsent.Text = "Vắng mặt:";
            this.lblAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTotalLate);
            this.groupBox2.Controls.Add(this.lblLate);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblHome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblWorking);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTotalAbsent);
            this.groupBox2.Controls.Add(this.lblTotalEmployee);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblAbsent);
            this.groupBox2.Controls.Add(this.lblTotalLeave);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(432, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê trang hiện tại";
            // 
            // lblTotalLate
            // 
            this.lblTotalLate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalLate.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalLate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalLate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalLate.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLate.Location = new System.Drawing.Point(64, 45);
            this.lblTotalLate.Name = "lblTotalLate";
            this.lblTotalLate.Size = new System.Drawing.Size(32, 23);
            this.lblTotalLate.TabIndex = 23;
            this.lblTotalLate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLate
            // 
            this.lblLate.Location = new System.Drawing.Point(8, 45);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(56, 23);
            this.lblLate.TabIndex = 22;
            this.lblLate.Text = "Đi muộn:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(96, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(96, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(192, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHome.BackColor = System.Drawing.SystemColors.Control;
            this.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHome.ForeColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(272, 45);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(24, 23);
            this.lblHome.TabIndex = 15;
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(216, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Về nhà:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorking
            // 
            this.lblWorking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorking.BackColor = System.Drawing.SystemColors.Control;
            this.lblWorking.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblWorking.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWorking.ForeColor = System.Drawing.Color.Black;
            this.lblWorking.Location = new System.Drawing.Point(168, 21);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(24, 23);
            this.lblWorking.TabIndex = 12;
            this.lblWorking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(120, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Làm việc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAbsent
            // 
            this.lblTotalAbsent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalAbsent.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalAbsent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalAbsent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalAbsent.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAbsent.Location = new System.Drawing.Point(168, 45);
            this.lblTotalAbsent.Name = "lblTotalAbsent";
            this.lblTotalAbsent.Size = new System.Drawing.Size(24, 23);
            this.lblTotalAbsent.TabIndex = 7;
            this.lblTotalAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEmployee.Location = new System.Drawing.Point(64, 21);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(32, 23);
            this.lblTotalEmployee.TabIndex = 6;
            this.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(216, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Công tác:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalLeave
            // 
            this.lblTotalLeave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalLeave.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalLeave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalLeave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalLeave.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLeave.Location = new System.Drawing.Point(272, 21);
            this.lblTotalLeave.Name = "lblTotalLeave";
            this.lblTotalLeave.Size = new System.Drawing.Size(24, 23);
            this.lblTotalLeave.TabIndex = 8;
            this.lblTotalLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CausesValidation = false;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(664, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Location = new System.Drawing.Point(584, 440);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "&Nạp lại";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnEmployee
            // 
            this.pnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEmployee.AutoScroll = true;
            this.pnEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnEmployee.Location = new System.Drawing.Point(8, 16);
            this.pnEmployee.Name = "pnEmployee";
            this.pnEmployee.Size = new System.Drawing.Size(712, 328);
            this.pnEmployee.TabIndex = 10;
            this.pnEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEmployee_Paint);
            // 
            // grbEmployee
            // 
            this.grbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEmployee.Controls.Add(this.pnEmployee);
            this.grbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbEmployee.Location = new System.Drawing.Point(8, 80);
            this.grbEmployee.Name = "grbEmployee";
            this.grbEmployee.Size = new System.Drawing.Size(728, 352);
            this.grbEmployee.TabIndex = 11;
            this.grbEmployee.TabStop = false;
            this.grbEmployee.Text = "Danh sách nhân viên";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOptions.Location = new System.Drawing.Point(504, 440);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "&Tùy chọn...";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // txtRecordNum
            // 
            this.txtRecordNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRecordNum.Location = new System.Drawing.Point(56, 440);
            this.txtRecordNum.Name = "txtRecordNum";
            this.txtRecordNum.ReadOnly = true;
            this.txtRecordNum.Size = new System.Drawing.Size(48, 20);
            this.txtRecordNum.TabIndex = 41;
            this.txtRecordNum.Text = "0/0";
            this.txtRecordNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.ImageIndex = 5;
            this.btnLast.ImageList = this.imageList1;
            this.btnLast.Location = new System.Drawing.Point(128, 440);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
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
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.ImageIndex = 4;
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(104, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.ImageIndex = 3;
            this.btnPrevious.ImageList = this.imageList1;
            this.btnPrevious.Location = new System.Drawing.Point(32, 440);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.ImageIndex = 2;
            this.btnFirst.ImageList = this.imageList1;
            this.btnFirst.Location = new System.Drawing.Point(8, 440);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "Tất cả ",
            "Làm việc",
            "Công tác",
            "Vắng mặt",
            "Về nhà"});
            this.cboStatusFilter.Location = new System.Drawing.Point(88, 16);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(104, 21);
            this.cboStatusFilter.TabIndex = 0;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboStatusFilter);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(224, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lọc";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmployeeStatus
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(744, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecordNum);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.grbEmployee);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grbChonPhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeStatus";
            this.Text = "Theo dõi trạng thái nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.grbChonPhong.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private DepartmentDO departmentDO = null;

		/// <summary>
		/// 
		/// </summary>
		private StatusDO statusDO = null;

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsEmployeeStatus = null;
		/// <summary>
		/// 
		/// </summary>
		private DataRow[] dataRows = null;
		/// <summary>
		/// 
		/// </summary>
		private string dataFilter = "";
		/// <summary>
		/// 
		/// </summary>
		private int PanelWidth = 0;
		/// <summary>
		/// 
		/// </summary>
		private int PanelHeight = 0;
		/// <summary>
		/// Độ rộng box
		/// </summary>
		public int BoxWidth = 120;

		/// <summary>
		/// Chiều dài box
		/// </summary>
		public int BoxHeight = 184;
		/// <summary>
		/// Số ô trạng thái nhân viên trên một màn hình
		/// </summary>
		public int BoxesPerPage = 0;
		/// <summary>
		/// 
		/// </summary>
		private int NumPages = 0;
		/// <summary>
		/// 
		/// </summary>
		private int CurrentPage = 0;
		/// <summary>
		/// Lấy danh sách phòng ban
		/// </summary>
		private void PopulateDepartmentCombo()
		{
			dsDepartment = departmentDO.GetAllDepartments();

            if(dsDepartment !=null && dsDepartment.Tables.Count > 0)
            {
                cboDepartment.SelectedIndexChanged -= cboDepartment_SelectedIndexChanged;
                cboDepartment.DisplayMember = "DepartmentName";
                cboDepartment.ValueMember = "DepartmentID";
                cboDepartment.DataSource = dsDepartment.Tables[0];
                cboDepartment.SelectedIndex = -1;
                cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void RemoveStatusBox()
		{
			pnEmployee.Controls.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		private void AddNoEmployeeLabel()
		{
			Label lblNoEmployee = new Label();
			lblNoEmployee.Text = "Không có nhân viên nào";
			lblNoEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((Byte) (163)));
			lblNoEmployee.Location = new Point(PanelWidth/2 - 125, 16);
			lblNoEmployee.Size = new Size(250, 32);
			lblNoEmployee.TextAlign = ContentAlignment.MiddleCenter;
			pnEmployee.Controls.Add(lblNoEmployee);
		}


		/// <summary>
		/// Hiển thị trạng thái của từng nhân viên
		/// </summary>
		/// <param name="PageIndex"></param>
		private void LoadBoxesByPage(int PageIndex)
		{
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2");
            if (cboDepartment.SelectedIndex != -1)
            {
                dsEmployeeStatus =
                    statusDO.GetEmployeeStatus((int) cboDepartment.SelectedValue, DateTime.Today, cboSort.SelectedIndex,
                                               PageIndex - 1, BoxesPerPage);
                if (dsEmployeeStatus != null)
                {
                    dataRows = dsEmployeeStatus.Tables[1].Select(dataFilter);
                    if (dataRows.Length == 0)
                    {
                        RemoveStatusBox();
                        AddNoEmployeeLabel();
                        NumPages = 0;
                    }
                    else
                    {
                        totalLate = 0;
                        //				totalWorking=dsEmployeeStatus.Tables[1].Select("Status =" +1+"OR Status = "+7).Length;
                        //				totalLeave=dsEmployeeStatus.Tables[1].Select("Status =" +2).Length;
                        //				totalAbsent=dsEmployeeStatus.Tables[1].Select("Status =" +4+"OR Status = "+8+ "OR Status ="+3).Length;
                        //				totalGoHome=dsEmployeeStatus.Tables[1].Select("Status =" +5 +"OR Status = "+9).Length;

                        RowCount = int.Parse(dsEmployeeStatus.Tables[0].Rows[0][0].ToString());
                        NumPages = RowCount/BoxesPerPage;
                        if (RowCount%BoxesPerPage != 0)
                        {
                            NumPages++;
                        }
                    }


                    frmStatusMessage message = new frmStatusMessage();
                    string str = WorkingContext.LangManager.GetString("frmStatus_thongbao");
                    //message.Show("Đang sinh dữ liệu bảng chấm công, xin chờ trong giây lát...");
                    message.Show(str);
                    message.ProgressBar.Value = 0;
                    //			int totalEmployees = dataRows.Length;
                    this.Cursor = Cursors.WaitCursor;
                    int percentToComplete = 0;
                    int percentProcessing = 0;

                    RemoveStatusBox();
                    txtRecordNum.Text = PageIndex + "/" + NumPages;
                    int i = 0;
                    int lns = 0;
                    int cols = 0;
                    int numbox = 0;

                    numbox = PanelWidth/BoxWidth; // số box tối đa có thể vẽ được trong 1 dòng

                    ctrStatusBox statusBox;

                    for (int box = 0; box < dataRows.Length; box++)
                    {
                        ++percentProcessing;
                        DataRow dr = dataRows[box];
                        cols = i%numbox; //chỉ số của box trong 1 dòng
                        lns = i/numbox; //chỉ số của dòng

                        statusBox = new ctrStatusBox();
                        statusBox.EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                        // Tên nhân viên
                        statusBox.lblEmployeeName.Text = dr["EmployeeName"].ToString();
                        DateTime timeIn = new DateTime();
                        if (dr["TimeIn"] != DBNull.Value)
                        {
                            timeIn = DateTime.Parse(dr["TimeIn"].ToString());
                            statusBox.lblTimeIn.Text = timeIn.ToString("HH:mm");
                        }
                        else
                        {
                            statusBox.lblTimeIn.Text = "";
                        }

                        DateTime timeOut = new DateTime();
                        //				string TimeIn = "";
                        if (dr["TimeOut"] != DBNull.Value)
                        {
                            timeOut = DateTime.Parse(dr["TimeOut"].ToString());
                            statusBox.lblTimeOut.Text = timeOut.ToString("HH:mm");
                        }
                        else
                        {
                            statusBox.lblTimeOut.Text = "";
                        }

                        dsEmployeeLate =
                            statusDO.GetCheckInTime(int.Parse(dr["EmployeeID"].ToString()), DateTime.Today.Date);
                        DateTime checkIn = new DateTime(1900, 1, 1, 8, 0, 0, 0);
                            //mac dinh neu ko dang ky lich lam viec thi gio dau ca la 8h, cuoi ca la 17h
                        DateTime checkOut = new DateTime(1900, 1, 1, 17, 0, 0, 0);
                        DateTime lunchTime = new DateTime(1900, 1, 1, 1, 0, 0, 0);
                        if (dsEmployeeLate.Tables[0].Rows.Count > 0)
                        {
                            if (dsEmployeeLate.Tables[0].Rows[0]["CheckIn"] != DBNull.Value)
                            {
                                checkIn = DateTime.Parse(dsEmployeeLate.Tables[0].Rows[0]["CheckIn"].ToString());
                            }
                            if (dsEmployeeLate.Tables[0].Rows[0]["LunchTime"] != DBNull.Value)
                            {
                                lunchTime = DateTime.Parse(dsEmployeeLate.Tables[0].Rows[0]["LunchTime"].ToString());
                            }
                            if (dsEmployeeLate.Tables[0].Rows[0]["CheckOut"] != DBNull.Value)
                            {
                                checkOut = DateTime.Parse(dsEmployeeLate.Tables[0].Rows[0]["checkOut"].ToString());
                                checkOut = checkOut.Add(lunchTime.TimeOfDay);
                            }
                        }

                        // Trạng thái: 0-Vắng mặt; 1-Làm việc; 2-Công tác; 3-Nghỉ phép;
                        int Status = int.Parse(dr["Status"].ToString());
                        switch (Status)
                        {
                            case 1: //làm việc
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/working.gif");
                                if (timeIn.CompareTo(checkIn) > 0)
                                {
                                    statusBox.lblTimeIn.ForeColor = Color.Red;
                                    ++totalLate;
                                }
                                break;
                            case 2: //công tác
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/mission.gif");
                                //						totalLeave++;
                                break;
                            case 3: //đã đăng ký nghỉ phép
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/absent.gif");
                                dsEmployeeRest =
                                    statusDO.GetDayShortNameByEmployeeRest(int.Parse(dr["EmployeeID"].ToString()),
                                                                           DateTime.Today.Date);
                                statusBox.lblLate.Text = "(" +
                                                         dsEmployeeRest.Tables[0].Rows[0]["DayShortName"].ToString() +
                                                         ")";
                                break;
                            case 4: //vắng mặt ko lý do
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/absent.gif");
                                //						totalAbsent++;
                                break;
                            case 5: //về nhà
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/GoHome.gif");
                                //						totalGoHome++;
                                if (timeIn.CompareTo(checkIn) > 0)
                                {
                                    statusBox.lblTimeIn.ForeColor = Color.Red;
                                    ++totalLate;
                                }
                                if (checkOut.CompareTo(timeOut) > 0)
                                {
                                    statusBox.lblTimeOut.ForeColor = Color.Red;
                                }
                                break;
                            case 6: // đăng ký đi muộn
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/late.gif");
                                if (timeIn.CompareTo(checkIn) > 0)
                                {
                                    statusBox.lblTimeIn.ForeColor = Color.Red;
                                    ++totalLate;
                                }
                                statusBox.lblLate.Text = "(" + checkIn.ToString("HH:mm") + ")";
                                break;
                            case 7: //đi làm sau khi đã đăng ký đi muộn
                                if (timeIn.CompareTo(checkIn) > 0)
                                {
                                    statusBox.lblTimeIn.ForeColor = Color.Red;
                                    ++totalLate;
                                }
                                statusBox.lblLate.Text = "(" + checkIn.ToString("HH:mm") + ")";
                                break;
                            case 8: //đã đăng ký đi muộn nhưng vẫn chưa đến
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/absent.gif");
                                statusBox.lblLate.Text = "(" + checkIn.ToString("HH:mm") + ")";
                                break;
                            case 9: ///*Có làm việc, đã đi về sau khi đã đăng ký đi làm muộn */
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/GoHome.gif");
                                if (timeIn.CompareTo(checkIn) > 0)
                                {
                                    statusBox.lblTimeIn.ForeColor = Color.Red;
                                    ++totalLate;
                                }
                                if (timeOut.CompareTo(checkOut) < 0)
                                {
                                    statusBox.lblTimeOut.ForeColor = Color.Red;
                                }
                                statusBox.lblLate.Text = "(" + checkIn.ToString("HH:mm") + ")";
                                break;
                            case 10: //*Có làm việc, đã đi về +đăng ký nghỉ => ko xảy ra*/
                                statusBox.picStatus.Image = Image.FromFile("IMAGES/GoHome.gif");
                                dsEmployeeRest =
                                    statusDO.GetDayShortNameByEmployeeRest(int.Parse(dr["EmployeeID"].ToString()),
                                                                           DateTime.Today.Date);
                                statusBox.lblLate.Text = "(" +
                                                         dsEmployeeRest.Tables[0].Rows[0]["DayShortName"].ToString() +
                                                         ")";
                                break;
                        }
                        // Ảnh nhân viên
                        if (dr["Picture"] != DBNull.Value)
                        {
                            try
                            {
                                string EmployeePicture = WorkingContext.Setting.PicturePath + '\\' +
                                                         dr["Picture"].ToString();
                                statusBox.picEmployee.Image = Image.FromFile(EmployeePicture);
                            }
                            catch
                            {
                                statusBox.picEmployee.Image = Image.FromFile(@"IMAGES/noimage3.jpg");
                            }
                        }
                        else
                        {
                            statusBox.picEmployee.Image = Image.FromFile(@"IMAGES/noimage3.jpg");
                        }
                        int YellowCardCount = int.Parse(dr["YellowCardCount"].ToString());
                        int RedCardCount = int.Parse(dr["RedCardCount"].ToString());

                        if (YellowCardCount > 0)
                        {
                            statusBox.lblYellowCard.BackColor = Color.Yellow;
                            statusBox.lblYellowCard.Text = YellowCardCount.ToString();
                            //totalLeave++;
                        }
                        if (RedCardCount > 0)
                        {
                            statusBox.lblRedCard.BackColor = Color.Red;
                            statusBox.lblRedCard.Text = RedCardCount.ToString();
                            //totalAbsent++;
                        }

                        statusBox.Size = new Size(BoxWidth, BoxHeight);
                        statusBox.Location = new Point(cols*BoxWidth + 10, lns*BoxHeight + 10);

                        pnEmployee.Controls.Add(statusBox);

                        i++;
                        percentToComplete = (percentProcessing*100)/dataRows.Length;
                        message.ProgressBar.Value = percentToComplete;
                    }
                    if (PageIndex == 1)
                        LoadStatistics((int) cboDepartment.SelectedValue);
                    message.Close();
                }
            }
		    this.Cursor = Cursors.Default;
		}

		private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cboStatusFilter.SelectedIndex)
			{
				case 0://tất cả
					dataFilter = "";
					break;
				case 1:// làm việc
					dataFilter = "Status =" +1+"OR Status = "+7;
					break;
				case 2://công tác
					dataFilter = "Status =" +2;
					break;
				case 3:// vắng mặt
					dataFilter = "Status =" +4+"OR Status = "+8+ "OR Status ="+3;
					break;
				case 4:// về nhà
					dataFilter = "Status =" +5 +"OR Status = "+9;
					break;

			}
			LoadBoxesByPage(1);
		}

		private void frmStatus_Load(object sender, EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			statusDO = new StatusDO();
			
			cboSort.SelectedIndex =  2;
			PanelWidth = pnEmployee.Width;
			PanelHeight = pnEmployee.Height;
			BoxesPerPage = (PanelWidth / BoxWidth) * (PanelHeight / BoxHeight);
			CurrentPage = 1;
			PopulateDepartmentCombo();
			this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
		    cboDepartment.Focus();
		}

		public override void Refresh()
		{
			ChangeToCurrentLang();

			foreach (Form form in this.MdiChildren)
			{
				form.Refresh();
			}

			base.Refresh ();
		}

		private void ChangeToCurrentLang()
		{
			this.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_Text");
			this.grbChonPhong.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpChonPhong");
			this.lblChonPhong.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpChonPhong_lblChonPhong");
			this.lblSort.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpChonPhong_lblSort");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpChonPhong_groupBox1");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2");
			this.lblTotal.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblTongNhanVien");
			this.lblAbsent.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblNhanVienVang");
			this.label1.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblNhanVienDiCongTac");
			this.label6.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_label6");
			this.grbEmployee.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_grpEmployee");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_bntClose");
			this.btnOptions.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_bntOption");
			this.btnRefresh.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_bntRefresh");
			this.label3.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblWorking");
			this.btnSearch.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_btnSearch");
			this.label5.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblGoHome");
			this.lblLate.Text = WorkingContext.LangManager.GetString("frmEmployeeStatus_GroupBox2_lblLate");
//			this.btnThongke	.Text=WorkingContext.LangManager.GetString("frmEmployeeStatus_btnThongke");

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadBoxesByPage(CurrentPage);
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			frmStatusOptions frm = new frmStatusOptions(this);
			DialogResult result = frm.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				LoadBoxesByPage(CurrentPage);
			}
		}

		private void cboSort_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataFilter = "";
			LoadBoxesByPage(1);

		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			if (CurrentPage < NumPages)
			{
				CurrentPage += 1;
				LoadBoxesByPage(CurrentPage);
			}
		}

		private void btnPrevious_Click(object sender, System.EventArgs e)
		{
			if (CurrentPage > 1)
			{
				CurrentPage -= 1;
				LoadBoxesByPage(CurrentPage);
			}
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			if (NumPages > 0) 
			{
				CurrentPage = 1;
				LoadBoxesByPage(CurrentPage);
			}
		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			if (NumPages > 0) 
			{
				CurrentPage = NumPages;
				LoadBoxesByPage(CurrentPage);
			}
		}

		private void txtSearch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtSearch.SelectAll();
		}

		private void txtSearch_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		}

		private void pnEmployee_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			dataFilter = "CardID LIKE '%" + txtSearch.Text + "%' OR EmployeeName LIKE '%" + txtSearch.Text + "%'";
			LoadBoxesByPage(CurrentPage);
		}
		/// <summary>
		/// Lọc hiển thị trạng thái của nhân viên
		/// </summary>

		private void cboStatusFilter_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (cboStatusFilter.SelectedIndex)
			{
				case 0://tất cả
					dataFilter = "";
					break;
				case 1:// làm việc
					dataFilter = "Status =" +1+"OR Status = "+7;
					break;
				case 2://công tác
					dataFilter = "Status =" +2;
					break;
				case 3:// vắng mặt
					dataFilter = "Status =" +4+"OR Status = "+8+ "OR Status ="+3;
					break;
				case 4:// về nhà
					dataFilter = "Status =" +5 +"OR Status = "+9;
					break;
			}
			LoadBoxesByPage(CurrentPage);
		}
		
		/// <summary>
		/// Lấy thông tin tổng hợp trạng thái nhân viên 
		/// </summary>
		private void LoadStatistics(int departmentID)
		{
			lblTotalEmployee.Text = RowCount.ToString();
			dsEmployeeStatistics = statusDO.GetEmployeeStatusInDay(departmentID,DateTime.Today);	
			lblTotalLeave.Text = dsEmployeeStatistics.Tables[0].Rows[0]["TotalLeave"].ToString();
			lblTotalAbsent.Text = (int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalAbsent"].ToString())+int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalRest"].ToString())+int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalRestLate"].ToString())).ToString();
			lblHome.Text = (int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalGoHome"].ToString())+int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalGoHomeLate"].ToString())).ToString();
			lblWorking.Text = (int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalWork"].ToString())+int.Parse(dsEmployeeStatistics.Tables[0].Rows[0]["TotalWorkLate"].ToString())).ToString();
			lblTotalLate.Text =  totalLate.ToString();
		}

        private void cboDepartment_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ActiveControl !=btnClose && cboDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn 1 bộ phận cần xem trạng thái nhân viên !", "Thông báo");
                e.Cancel = true;
                cboDepartment.Focus();
            }
        }
	}
}