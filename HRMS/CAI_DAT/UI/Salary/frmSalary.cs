using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using EVSoft.HRMS.Controls;

namespace EVSoft.HRMS.UI
{
	public class frmSalary : Form
	{
		private GroupBox grbNgayCong;
		private Label label1;
		private Label label3;
		private Label label4;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label25;
		private Label label5;
		private TextBox txtPhuCapAT;
		private TextBox txtPhuCapDH;
		private TextBox txtPhuCapTN;
		private TextBox txtNgoaiRa;
		private TextBox txtThueTNCN;
		private TextBox txtBaoHiem;
		private Label label24;
		private TextBox txtNgayThuong;
		private TextBox txtTienLamThem;
		private TextBox txtNgayNghi;
		private DepartmentTreeView departmentTreeView;
		private ComboBox cboEmployeeName;
		private TextBox txtMucLuong;
		private Label lblSalary;
		private Label lblEmployeeName;
		private TextBox textBox7;
		private Label label23;
		private GroupBox grbThongTinChung;
		private Button btnCancel;
		private TextBox txtRecordNum;
		private Button btnLast;
		private Button btnNext;
		private Button btnPrevious;
		private Button btnFirst;
		private Button btnClose;
		private Button btnSave;
		private ImageList imageList1;
		private GroupBox groupBox3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private Label label6;
		private IContainer components;

		public frmSalary()
		{
			InitializeComponent();
		}

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
			this.components = new Container();
			ResourceManager resources = new ResourceManager(typeof (frmSalary));
			this.txtPhuCapAT = new TextBox();
			this.label4 = new Label();
			this.txtPhuCapDH = new TextBox();
			this.label3 = new Label();
			this.txtPhuCapTN = new TextBox();
			this.label1 = new Label();
			this.grbNgayCong = new GroupBox();
			this.groupBox1 = new GroupBox();
			this.txtNgayNghi = new TextBox();
			this.txtTienLamThem = new TextBox();
			this.txtNgayThuong = new TextBox();
			this.label5 = new Label();
			this.label25 = new Label();
			this.label24 = new Label();
			this.groupBox2 = new GroupBox();
			this.txtNgoaiRa = new TextBox();
			this.label13 = new Label();
			this.txtThueTNCN = new TextBox();
			this.label12 = new Label();
			this.txtBaoHiem = new TextBox();
			this.label11 = new Label();
			this.departmentTreeView = new DepartmentTreeView();
			this.cboEmployeeName = new ComboBox();
			this.txtMucLuong = new TextBox();
			this.lblSalary = new Label();
			this.lblEmployeeName = new Label();
			this.textBox7 = new TextBox();
			this.label23 = new Label();
			this.grbThongTinChung = new GroupBox();
			this.btnCancel = new Button();
			this.txtRecordNum = new TextBox();
			this.btnLast = new Button();
			this.btnNext = new Button();
			this.btnPrevious = new Button();
			this.btnFirst = new Button();
			this.btnClose = new Button();
			this.btnSave = new Button();
			this.imageList1 = new ImageList(this.components);
			this.groupBox3 = new GroupBox();
			this.textBox1 = new TextBox();
			this.textBox2 = new TextBox();
			this.label2 = new Label();
			this.label6 = new Label();
			this.grbNgayCong.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.grbThongTinChung.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPhuCapAT
			// 
			this.txtPhuCapAT.Location = new Point(104, 16);
			this.txtPhuCapAT.Name = "txtPhuCapAT";
			this.txtPhuCapAT.Size = new Size(72, 20);
			this.txtPhuCapAT.TabIndex = 9;
			this.txtPhuCapAT.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new Size(96, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "PC tiền ăn";
			this.label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPhuCapDH
			// 
			this.txtPhuCapDH.Location = new Point(104, 64);
			this.txtPhuCapDH.Name = "txtPhuCapDH";
			this.txtPhuCapDH.Size = new Size(72, 20);
			this.txtPhuCapDH.TabIndex = 7;
			this.txtPhuCapDH.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new Size(96, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "PC độc hại:";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPhuCapTN
			// 
			this.txtPhuCapTN.Location = new Point(104, 40);
			this.txtPhuCapTN.Name = "txtPhuCapTN";
			this.txtPhuCapTN.Size = new Size(72, 20);
			this.txtPhuCapTN.TabIndex = 3;
			this.txtPhuCapTN.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new Size(96, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "PC trách nhiệm";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// grbNgayCong
			// 
			this.grbNgayCong.Controls.Add(this.txtPhuCapTN);
			this.grbNgayCong.Controls.Add(this.label3);
			this.grbNgayCong.Controls.Add(this.txtPhuCapDH);
			this.grbNgayCong.Controls.Add(this.label4);
			this.grbNgayCong.Controls.Add(this.txtPhuCapAT);
			this.grbNgayCong.Controls.Add(this.label1);
			this.grbNgayCong.Location = new Point(208, 112);
			this.grbNgayCong.Name = "grbNgayCong";
			this.grbNgayCong.Size = new Size(184, 96);
			this.grbNgayCong.TabIndex = 1;
			this.grbNgayCong.TabStop = false;
			this.grbNgayCong.Text = "Phụ cấp";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtNgayNghi);
			this.groupBox1.Controls.Add(this.txtTienLamThem);
			this.groupBox1.Controls.Add(this.txtNgayThuong);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Location = new Point(400, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(232, 96);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Làm thêm giờ";
			// 
			// txtNgayNghi
			// 
			this.txtNgayNghi.Location = new Point(64, 40);
			this.txtNgayNghi.Name = "txtNgayNghi";
			this.txtNgayNghi.Size = new Size(48, 20);
			this.txtNgayNghi.TabIndex = 37;
			this.txtNgayNghi.Text = "";
			// 
			// txtTienLamThem
			// 
			this.txtTienLamThem.Location = new Point(96, 64);
			this.txtTienLamThem.Name = "txtTienLamThem";
			this.txtTienLamThem.ReadOnly = true;
			this.txtTienLamThem.Size = new Size(128, 20);
			this.txtTienLamThem.TabIndex = 36;
			this.txtTienLamThem.Text = "";
			// 
			// txtNgayThuong
			// 
			this.txtNgayThuong.Location = new Point(64, 16);
			this.txtNgayThuong.Name = "txtNgayThuong";
			this.txtNgayThuong.Size = new Size(48, 20);
			this.txtNgayThuong.TabIndex = 34;
			this.txtNgayThuong.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new Size(88, 23);
			this.label5.TabIndex = 32;
			this.label5.Text = "Cộng làm thêm";
			this.label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label25
			// 
			this.label25.Location = new Point(8, 38);
			this.label25.Name = "label25";
			this.label25.Size = new Size(56, 23);
			this.label25.TabIndex = 29;
			this.label25.Text = "Hệ số 1.5";
			this.label25.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.Location = new Point(8, 16);
			this.label24.Name = "label24";
			this.label24.Size = new Size(56, 23);
			this.label24.TabIndex = 28;
			this.label24.Text = "Hệ số 1";
			this.label24.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNgoaiRa);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtThueTNCN);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.txtBaoHiem);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Location = new Point(208, 256);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(432, 80);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Các khoản khấu trừ";
			// 
			// txtNgoaiRa
			// 
			this.txtNgoaiRa.Location = new Point(104, 40);
			this.txtNgoaiRa.Name = "txtNgoaiRa";
			this.txtNgoaiRa.TabIndex = 17;
			this.txtNgoaiRa.Text = "0";
			// 
			// label13
			// 
			this.label13.Location = new Point(8, 40);
			this.label13.Name = "label13";
			this.label13.Size = new Size(96, 20);
			this.label13.TabIndex = 16;
			this.label13.Text = "Ngoải ra";
			this.label13.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtThueTNCN
			// 
			this.txtThueTNCN.Location = new Point(304, 16);
			this.txtThueTNCN.Name = "txtThueTNCN";
			this.txtThueTNCN.TabIndex = 15;
			this.txtThueTNCN.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new Point(216, 16);
			this.label12.Name = "label12";
			this.label12.Size = new Size(80, 20);
			this.label12.TabIndex = 14;
			this.label12.Text = "Thuế TNCN";
			this.label12.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtBaoHiem
			// 
			this.txtBaoHiem.Location = new Point(104, 16);
			this.txtBaoHiem.Name = "txtBaoHiem";
			this.txtBaoHiem.TabIndex = 13;
			this.txtBaoHiem.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new Size(96, 20);
			this.label11.TabIndex = 12;
			this.label11.Text = "BHYT + BHXH";
			this.label11.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// departmentTreeView
			// 
			this.departmentTreeView.Anchor = ((AnchorStyles) ((((AnchorStyles.Top | AnchorStyles.Bottom)
				| AnchorStyles.Left)
				| AnchorStyles.Right)));
			this.departmentTreeView.DepartmentDataSet = null;
			this.departmentTreeView.Location = new Point(8, 16);
			this.departmentTreeView.Name = "departmentTreeView";
			this.departmentTreeView.Size = new Size(176, 322);
			this.departmentTreeView.TabIndex = 0;
			this.departmentTreeView.AfterSelect += new TreeViewEventHandler(this.departmentTreeView_AfterSelect);
			// 
			// cboEmployeeName
			// 
			this.cboEmployeeName.ItemHeight = 13;
			this.cboEmployeeName.Location = new Point(104, 16);
			this.cboEmployeeName.Name = "cboEmployeeName";
			this.cboEmployeeName.Size = new Size(304, 21);
			this.cboEmployeeName.TabIndex = 18;
			// 
			// txtMucLuong
			// 
			this.txtMucLuong.Location = new Point(104, 40);
			this.txtMucLuong.Name = "txtMucLuong";
			this.txtMucLuong.TabIndex = 3;
			this.txtMucLuong.Text = "";
			// 
			// lblSalary
			// 
			this.lblSalary.Location = new Point(8, 40);
			this.lblSalary.Name = "lblSalary";
			this.lblSalary.Size = new Size(96, 20);
			this.lblSalary.TabIndex = 2;
			this.lblSalary.Text = "Lương cơ bản";
			this.lblSalary.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.Location = new Point(8, 16);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new Size(96, 20);
			this.lblEmployeeName.TabIndex = 0;
			this.lblEmployeeName.Text = "Họ và tên";
			this.lblEmployeeName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox7
			// 
			this.textBox7.Location = new Point(104, 64);
			this.textBox7.Name = "textBox7";
			this.textBox7.TabIndex = 17;
			this.textBox7.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new Point(8, 64);
			this.label23.Name = "label23";
			this.label23.Size = new Size(96, 23);
			this.label23.TabIndex = 16;
			this.label23.Text = "Số ngày công";
			this.label23.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// grbThongTinChung
			// 
			this.grbThongTinChung.Controls.Add(this.cboEmployeeName);
			this.grbThongTinChung.Controls.Add(this.txtMucLuong);
			this.grbThongTinChung.Controls.Add(this.lblSalary);
			this.grbThongTinChung.Controls.Add(this.lblEmployeeName);
			this.grbThongTinChung.Controls.Add(this.textBox7);
			this.grbThongTinChung.Controls.Add(this.label23);
			this.grbThongTinChung.Location = new Point(208, 8);
			this.grbThongTinChung.Name = "grbThongTinChung";
			this.grbThongTinChung.Size = new Size(416, 96);
			this.grbThongTinChung.TabIndex = 0;
			this.grbThongTinChung.TabStop = false;
			this.grbThongTinChung.Text = "Thông tin chung";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Right)));
			this.btnCancel.FlatStyle = FlatStyle.System;
			this.btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte) (163)));
			this.btnCancel.Location = new Point(496, 368);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(72, 23);
			this.btnCancel.TabIndex = 45;
			this.btnCancel.Text = "&Bỏ qua";
			// 
			// txtRecordNum
			// 
			this.txtRecordNum.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.txtRecordNum.Location = new Point(56, 368);
			this.txtRecordNum.Name = "txtRecordNum";
			this.txtRecordNum.ReadOnly = true;
			this.txtRecordNum.Size = new Size(48, 20);
			this.txtRecordNum.TabIndex = 44;
			this.txtRecordNum.Text = "3/26";
			this.txtRecordNum.TextAlign = HorizontalAlignment.Center;
			// 
			// btnLast
			// 
			this.btnLast.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.btnLast.ImageIndex = 3;
			this.btnLast.ImageList = this.imageList1;
			this.btnLast.Location = new Point(128, 368);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new Size(24, 23);
			this.btnLast.TabIndex = 43;
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.btnNext.ImageIndex = 2;
			this.btnNext.ImageList = this.imageList1;
			this.btnNext.Location = new Point(104, 368);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new Size(24, 23);
			this.btnNext.TabIndex = 42;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.btnPrevious.ImageIndex = 1;
			this.btnPrevious.ImageList = this.imageList1;
			this.btnPrevious.Location = new Point(32, 368);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new Size(24, 23);
			this.btnPrevious.TabIndex = 41;
			// 
			// btnFirst
			// 
			this.btnFirst.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
			this.btnFirst.ImageIndex = 0;
			this.btnFirst.ImageList = this.imageList1;
			this.btnFirst.Location = new Point(8, 368);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new Size(24, 23);
			this.btnFirst.TabIndex = 40;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Right)));
			this.btnClose.FlatStyle = FlatStyle.System;
			this.btnClose.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte) (163)));
			this.btnClose.Location = new Point(568, 368);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(72, 23);
			this.btnClose.TabIndex = 39;
			this.btnClose.Text = "&Đóng";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Right)));
			this.btnSave.FlatStyle = FlatStyle.System;
			this.btnSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte) (163)));
			this.btnSave.Location = new Point(424, 368);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new Size(72, 23);
			this.btnSave.TabIndex = 38;
			this.btnSave.Text = "&Đồng ý";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new Size(16, 16);
			this.imageList1.ImageStream = ((ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = Color.Transparent;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((AnchorStyles) (((AnchorStyles.Top | AnchorStyles.Bottom)
				| AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.departmentTreeView);
			this.groupBox3.Location = new Point(8, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new Size(192, 352);
			this.groupBox3.TabIndex = 46;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh sách bộ phận";
			// 
			// textBox1
			// 
			this.textBox1.Location = new Point(176, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(48, 20);
			this.textBox1.TabIndex = 41;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new Point(176, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Size(48, 20);
			this.textBox2.TabIndex = 40;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new Point(120, 40);
			this.label2.Name = "label2";
			this.label2.Size = new Size(56, 23);
			this.label2.TabIndex = 39;
			this.label2.Text = "Hệ số 3";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new Point(120, 16);
			this.label6.Name = "label6";
			this.label6.Size = new Size(56, 23);
			this.label6.TabIndex = 38;
			this.label6.Text = "Hệ số 2";
			this.label6.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// frmSalary
			// 
			this.AutoScaleBaseSize = new Size(5, 13);
			this.ClientSize = new Size(650, 400);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtRecordNum);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.grbNgayCong);
			this.Controls.Add(this.grbThongTinChung);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmSalary";
			this.Text = "Nhập lương tháng";
			this.Load += new EventHandler(this.frmSalary_Load);
			this.grbNgayCong.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.grbThongTinChung.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void frmSalary_Load(object sender, EventArgs e)
		{
			departmentTreeView.BuildTree();
			departmentTreeView.ExpandNodes(true);
		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);
			int id = (int) e.Node.Tag;
		}
	}
}