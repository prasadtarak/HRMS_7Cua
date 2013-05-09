using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Schedule
{
	/// <summary>
	/// Summary description for frmOverTime.
	/// </summary>
	public class frmOverTime : System.Windows.Forms.Form
	{
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.TextColumn chCardID;
		private XPTable.Models.TextColumn chEmployeeName;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn chSTT;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DateTimePicker dtpWorkingDay;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnuSet;
		private System.Windows.Forms.GroupBox groupBox2;
		private EVSoft.HRMS.Controls.DepartmentTreeView departmentTreeView;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private XPTable.Models.Table lvwLunch;
		private System.Windows.Forms.Button btnSlectAll;
		private System.Windows.Forms.Button btnClearAll;
		private XPTable.Models.TextColumn chStartOverTime;
		private XPTable.Models.TextColumn cLength;
		private XPTable.Models.TextColumn cDinnerAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private XPTable.Models.CheckBoxColumn cBus;
		private XPTable.Models.TextColumn cWorkOverTimeInfo;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lblTotalOverTime;
		private System.Windows.Forms.Label lblTotalLunch;
		private System.Windows.Forms.Label lblTotalBus;
		private System.Windows.Forms.Button btnRegOverTime;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmOverTime()
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
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnRegOverTime = new System.Windows.Forms.Button();
			this.chStartOverTime = new XPTable.Models.TextColumn();
			this.chCardID = new XPTable.Models.TextColumn();
			this.chEmployeeName = new XPTable.Models.TextColumn();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.chSTT = new XPTable.Models.TextColumn();
			this.cLength = new XPTable.Models.TextColumn();
			this.cDinnerAmount = new XPTable.Models.TextColumn();
			this.cBus = new XPTable.Models.CheckBoxColumn();
			this.cWorkOverTimeInfo = new XPTable.Models.TextColumn();
			this.btnHelp = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnuSet = new System.Windows.Forms.MenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTotalBus = new System.Windows.Forms.Label();
			this.lblTotalLunch = new System.Windows.Forms.Label();
			this.lblTotalOverTime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lvwLunch = new XPTable.Models.Table();
			this.btnClearAll = new System.Windows.Forms.Button();
			this.btnSlectAll = new System.Windows.Forms.Button();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwLunch)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegOverTime
			// 
			this.btnRegOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegOverTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRegOverTime.Location = new System.Drawing.Point(704, 464);
			this.btnRegOverTime.Name = "btnRegOverTime";
			this.btnRegOverTime.TabIndex = 86;
			this.btnRegOverTime.Text = "Đăng &ký";
			this.btnRegOverTime.Click += new System.EventHandler(this.btnRegOverTime_Click);
			// 
			// chStartOverTime
			// 
			this.chStartOverTime.Editable = false;
			this.chStartOverTime.Text = "Bắt đầu";
			this.chStartOverTime.Width = 70;
			// 
			// chCardID
			// 
			this.chCardID.Editable = false;
			this.chCardID.Text = "Mã thẻ";
			this.chCardID.Width = 50;
			// 
			// chEmployeeName
			// 
			this.chEmployeeName.Editable = false;
			this.chEmployeeName.Text = "Tên nhân viên";
			this.chEmployeeName.Width = 130;
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.chSTT,
																			   this.chCardID,
																			   this.chEmployeeName,
																			   this.chStartOverTime,
																			   this.cLength,
																			   this.cDinnerAmount,
																			   this.cBus,
																			   this.cWorkOverTimeInfo});
			// 
			// chSTT
			// 
			this.chSTT.Editable = false;
			this.chSTT.Text = "STT";
			this.chSTT.Width = 40;
			// 
			// cLength
			// 
			this.cLength.Text = "Thời gian";
			this.cLength.Width = 70;
			// 
			// cDinnerAmount
			// 
			this.cDinnerAmount.Text = "Ăn thêm";
			this.cDinnerAmount.Width = 60;
			// 
			// cBus
			// 
			this.cBus.Alignment = XPTable.Models.ColumnAlignment.Center;
			this.cBus.DrawText = false;
			this.cBus.Text = "Đi xe";
			this.cBus.Width = 50;
			// 
			// cWorkOverTimeInfo
			// 
			this.cWorkOverTimeInfo.Text = "Ghi chú";
			this.cWorkOverTimeInfo.Width = 140;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHelp.Location = new System.Drawing.Point(8, 464);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 85;
			this.btnHelp.Text = "Trợ giúp";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dtpWorkingDay);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(8, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(216, 48);
			this.groupBox4.TabIndex = 90;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ngày";
			// 
			// dtpWorkingDay
			// 
			this.dtpWorkingDay.CustomFormat = "dd/MM/yyyy    ";
			this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWorkingDay.Location = new System.Drawing.Point(8, 16);
			this.dtpWorkingDay.Name = "dtpWorkingDay";
			this.dtpWorkingDay.TabIndex = 74;
			this.dtpWorkingDay.ValueChanged += new System.EventHandler(this.dtpWorkingDay_ValueChanged);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuSet});
			// 
			// mnuSet
			// 
			this.mnuSet.Index = 0;
			this.mnuSet.Text = "&Thiết lập...";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.departmentTreeView);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 392);
			this.groupBox2.TabIndex = 88;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách phòng ban";
			// 
			// departmentTreeView
			// 
			this.departmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.departmentTreeView.BackColor = System.Drawing.Color.GhostWhite;
			this.departmentTreeView.DepartmentDataSet = null;
			this.departmentTreeView.Location = new System.Drawing.Point(8, 16);
			this.departmentTreeView.Name = "departmentTreeView";
			this.departmentTreeView.Size = new System.Drawing.Size(200, 368);
			this.departmentTreeView.TabIndex = 3;
			this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(784, 464);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 84;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lblTotalBus);
			this.groupBox1.Controls.Add(this.lblTotalLunch);
			this.groupBox1.Controls.Add(this.lblTotalOverTime);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbl1);
			this.groupBox1.Controls.Add(this.lvwLunch);
			this.groupBox1.Controls.Add(this.btnClearAll);
			this.groupBox1.Controls.Add(this.btnSlectAll);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(232, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(632, 448);
			this.groupBox1.TabIndex = 87;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhân viên";
			// 
			// lblTotalBus
			// 
			this.lblTotalBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalBus.Location = new System.Drawing.Point(592, 416);
			this.lblTotalBus.Name = "lblTotalBus";
			this.lblTotalBus.Size = new System.Drawing.Size(32, 23);
			this.lblTotalBus.TabIndex = 17;
			this.lblTotalBus.Text = "70";
			this.lblTotalBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotalLunch
			// 
			this.lblTotalLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalLunch.Location = new System.Drawing.Point(480, 416);
			this.lblTotalLunch.Name = "lblTotalLunch";
			this.lblTotalLunch.Size = new System.Drawing.Size(32, 23);
			this.lblTotalLunch.TabIndex = 16;
			this.lblTotalLunch.Text = "100";
			this.lblTotalLunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotalOverTime
			// 
			this.lblTotalOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalOverTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalOverTime.Location = new System.Drawing.Point(352, 416);
			this.lblTotalOverTime.Name = "lblTotalOverTime";
			this.lblTotalOverTime.Size = new System.Drawing.Size(32, 23);
			this.lblTotalOverTime.TabIndex = 15;
			this.lblTotalOverTime.Text = "123";
			this.lblTotalOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(520, 416);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Số đi xe buýt:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(392, 416);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Số lượng ăn cơm:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl1
			// 
			this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl1.Location = new System.Drawing.Point(272, 416);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(88, 24);
			this.lbl1.TabIndex = 12;
			this.lbl1.Text = "Tổng làm thêm:";
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvwLunch
			// 
			this.lvwLunch.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwLunch.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwLunch.ColumnModel = this.columnModel1;
			this.lvwLunch.ContextMenu = this.contextMenu1;
			this.lvwLunch.EnableToolTips = true;
			this.lvwLunch.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwLunch.FullRowSelect = true;
			this.lvwLunch.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwLunch.GridLines = XPTable.Models.GridLines.Both;
			this.lvwLunch.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwLunch.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwLunch.Location = new System.Drawing.Point(8, 16);
			this.lvwLunch.MultiSelect = true;
			this.lvwLunch.Name = "lvwLunch";
			this.lvwLunch.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwLunch.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwLunch.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwLunch.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwLunch.Size = new System.Drawing.Size(616, 400);
			this.lvwLunch.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwLunch.TabIndex = 11;
			this.lvwLunch.TableModel = this.tableModel1;
			this.lvwLunch.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwLunch.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			// 
			// btnClearAll
			// 
			this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClearAll.Location = new System.Drawing.Point(96, 416);
			this.btnClearAll.Name = "btnClearAll";
			this.btnClearAll.Size = new System.Drawing.Size(80, 23);
			this.btnClearAll.TabIndex = 78;
			this.btnClearAll.Text = "Bỏ chọn";
			this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
			// 
			// btnSlectAll
			// 
			this.btnSlectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSlectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSlectAll.Location = new System.Drawing.Point(8, 416);
			this.btnSlectAll.Name = "btnSlectAll";
			this.btnSlectAll.Size = new System.Drawing.Size(80, 23);
			this.btnSlectAll.TabIndex = 77;
			this.btnSlectAll.Text = "Chọn tất";
			this.btnSlectAll.Click += new System.EventHandler(this.btnSlectAll_Click);
			// 
			// frmOverTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(872, 494);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnRegOverTime);
			this.Controls.Add(this.btnHelp);
			this.Name = "frmOverTime";
			this.Text = "Danh sách nhân viên làm thêm giờ";
			this.Load += new System.EventHandler(this.frmOverTime_Load);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwLunch)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmOverTime_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnRegOverTime_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnSlectAll_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnClearAll_Click(object sender, System.EventArgs e)
		{
		
		}

		private void dtpWorkingDay_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void departmentTreeView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		
		}

	}
}
