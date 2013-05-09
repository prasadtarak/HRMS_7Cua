//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 	Xây dựng cây tổ chức
//Note	    :	
//Author	: vietht
//Modify	: chinhnd 8-2005
//------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Controls;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.UI.Employee;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmListDepartment : Form
	{
		private ContextMenu contextMenu1;
		private MenuItem mnuThemPhong;
		private MenuItem mnuSuaTenPhong;
		private MenuItem mnuXoaPhong;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnAddNew;
		private Button btnClose;
		private ErrorProvider errorProvider1;
		private DepartmentTreeView departmentTreeView;
        private GroupBox groupBox1;
        private IContainer components;

		public frmListDepartment()
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
		/// 
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDepartment));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuThemPhong = new System.Windows.Forms.MenuItem();
            this.mnuSuaTenPhong = new System.Windows.Forms.MenuItem();
            this.mnuXoaPhong = new System.Windows.Forms.MenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.departmentTreeView = new EVSoft.HRMS.Controls.DepartmentTreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuThemPhong,
            this.mnuSuaTenPhong,
            this.mnuXoaPhong});
            // 
            // mnuThemPhong
            // 
            this.mnuThemPhong.Index = 0;
            this.mnuThemPhong.Text = "&Thêm Phòng...";
            this.mnuThemPhong.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // mnuSuaTenPhong
            // 
            this.mnuSuaTenPhong.Index = 1;
            this.mnuSuaTenPhong.Text = "&Sửa Tên...";
            this.mnuSuaTenPhong.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mnuXoaPhong
            // 
            this.mnuXoaPhong.Index = 2;
            this.mnuXoaPhong.Text = "&Xóa Phòng...";
            this.mnuXoaPhong.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(256, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(256, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddNew.Location = new System.Drawing.Point(256, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "&Thêm";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(256, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.departmentTreeView.Size = new System.Drawing.Size(224, 368);
            this.departmentTreeView.TabIndex = 59;
            this.departmentTreeView.DoubleClick += new System.EventHandler(this.departmentTreeView_DoubleClick);
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentTreeView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 392);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng ban";
            // 
            // frmListDepartment
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(334, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phòng ban, bộ phận";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsDepartment;
		/// <summary>
		/// 
		/// </summary>
		private DepartmentDO departmentDO;
		/// <summary>
		/// 
		/// </summary>
		private int DepartmentID;
		private int SortIndex=0;
		private int GroupID;
		/// <summary>
		/// 
		/// </summary>
		private string DepartmentName;
		/// <summary>
		/// 
		/// </summary>
		private string Description;

		/// <summary>
		/// Xóa một phòng ban
		/// </summary>
		private void DeleteDepartment()
		{
			int NodeIsEmpty = departmentDO.DeleteDepartment((int) departmentTreeView.SelectedNode.Tag);
			if (NodeIsEmpty == 1)
			{
				//Rebuild the tree
				departmentTreeView.ReBuild();
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_ThongBao_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Delete_ThongBao_Title");
				//MessageBox.Show("Xóa phòng ban thành công", "Xóa phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_ThongBao_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Delete_ThongBao_Title");
				//MessageBox.Show("Phòng ban này có phòng ban con, hoặc vẫn còn nhân viên trong phòng ban này!", "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Xây dựng cây phòng ban
		/// </summary>
		private void PopulateDepartmentTreeView()
		{
			dsDepartment = departmentDO.GetAllDepartments();
			departmentTreeView.DepartmentDataSet = dsDepartment;
			departmentTreeView.BuildTree1(true);
			departmentTreeView.SelectedNode = departmentTreeView.TopNode;
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
			this.Text = WorkingContext.LangManager.GetString("frmListDepartment_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListDepartment_GroupBox1");
			this.btnAddNew.Text = WorkingContext.LangManager.GetString("frmListDepartment_bntAddNew");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListDepartment_bntClose");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListDepartment_bntDelete");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmListDepartment_bntUpDate");
		}


		#region Windows Form Event Handlers

		private void frmDepartment_Load(object sender, EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			PopulateDepartmentTreeView();
			departmentTreeView.SelectedNode = null;
		}

		private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			departmentTreeView.ExpandNodes(true);
			DepartmentID = (int)departmentTreeView.SelectedNode.Tag;
			
			DataRow[] drs = dsDepartment.Tables[0].Select("DepartmentID=" + DepartmentID);
			DepartmentName = drs[0]["DepartmentName"].ToString();
			Description = drs[0]["Description"].ToString();
			GroupID =Convert.ToInt32(drs[0]["GroupID"].ToString());
		    string thu = drs[0]["SortIndex"].ToString();
            if (drs[0]["SortIndex"].ToString()!="")
                 SortIndex = Convert.ToInt32(drs[0]["SortIndex"].ToString());
			
		}

//
//		private void departmentTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
//		{
//			if (e.Label != null)
//			{
//				if (e.Label.Length > 0)
//				{
//					if (e.Label.IndexOfAny(new char[] {'@', '.', ',', '!'}) == -1)
//					{
//						// Stop editing without canceling the label change.
//						e.Node.EndEdit(false);
//						e.Node.Text = e.Label;
//						//update in DataBase
//						departmentDO.UpdateDepartmentInfo((int) e.Node.Tag, e.Node.Text, txtDescription.Text);
//
//						//display DepartmentName
//						txtDepartmentName.Text = e.Node.Text;
//					}
//					else
//					{
//						/* Cancel the label edit action, inform the user, and 
//						   place the node in edit mode again. */
//						e.CancelEdit = true;
//						MessageBox.Show("Tên Phòng chứa các ký tự đặc biệt.\n" +
//							"Các ký tự không hợp lệ là : '@','.', ',', '!'");
//						e.Node.BeginEdit();
//					}
//				}
//				else
//				{
//					/* Cancel the label edit action, inform the user, and 
//					   place the node in edit mode again. */
//					e.CancelEdit = true;
//					MessageBox.Show("Tên Phòng không hợp lệ - Không được rỗng");
//					e.Node.BeginEdit();
//				}
//				this.departmentTreeView.LabelEdit = false;
//			}
//		}

//		private void departmentTreeView_MouseDown(object sender, MouseEventArgs e)
//		{
//			if ((e.Button == MouseButtons.Left) && (e.Clicks == 2))
//			{
//				frmDepartment frm = new frmDepartment();
//				frm.DepartmentID = (int)departmentTreeView.SelectedNode.Tag;
//				frm.DepartmentName = DepartmentName;
//				frm.Description = Description;
//				frm.ShowDialog(this);
//				PopulateDepartmentTreeView();
//			}
//			departmentTreeView.SelectedNode = null;
//		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			if (departmentTreeView.SelectedNode == null)
			{
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Them_ThongBao_Title");
				//MessageBox.Show("Bạn chưa chọn phòng ban nào", "Thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			frmDepartment frm = new frmDepartment();
			frm.DepartmentID = (int)departmentTreeView.SelectedNode.Tag;
			frm.DepartmentName = "";
			frm.ShowDialog(this);
			PopulateDepartmentTreeView();
			departmentTreeView.SelectedNode = null;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateDepartement();
		}
        /// <summary>
        /// cap nhat thong tin ve phong ban
        /// </summary>
        private void UpdateDepartement()
        {
            if (departmentTreeView.SelectedNode == null)
			{
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_Error_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Sua_ThongBao_Title");
				//MessageBox.Show("Bạn chưa chọn phòng ban nào", "Sửa phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			frmDepartment frm = new frmDepartment();
			frm.DepartmentID = (int)departmentTreeView.SelectedNode.Tag;
			frm.DepartmentName = DepartmentName;
			frm.Description = Description;
			frm.GroupID = GroupID;
            if (SortIndex!= 0)
                frm.SortIndex = SortIndex;
			frm.ShowDialog(this);
			PopulateDepartmentTreeView();
			departmentTreeView.SelectedNode = null;
        }
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (departmentTreeView.SelectedNode == null)
			{
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_Error_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Delete_title");
				//MessageBox.Show("Bạn chưa chọn phòng ban nào để xóa", "Xóa phòng ban", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (departmentTreeView.SelectedNode == departmentTreeView.TopNode)
			{
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_Error_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Delete_title");
				//MessageBox.Show("Đây là phòng ban gốc, bạn không thể xóa phòng ban này", "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else 
			{
				string DepartmentName = departmentTreeView.SelectedNode.Text;
				string str = WorkingContext.LangManager.GetString("frmListDep_Delete_Error_Messa4");
				string str1 = WorkingContext.LangManager.GetString("frmListDep_Delete_title");
				if (MessageBox.Show(str+DepartmentName , str1, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
					== DialogResult.Yes)
				{
					DeleteDepartment();
				}
				PopulateDepartmentTreeView();
			}
			departmentTreeView.SelectedNode = null;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

        private void departmentTreeView_DoubleClick(object sender, EventArgs e)
        {
            UpdateDepartement();
        }
	}
}