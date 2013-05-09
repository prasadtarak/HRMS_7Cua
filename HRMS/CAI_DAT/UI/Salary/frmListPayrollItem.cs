using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI.Salary
{
	/// <summary>
	/// Summary description for frmPayRollItem.
	/// </summary>
	public class frmListPayrollItem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader chPayrollItemID;
		private System.Windows.Forms.ColumnHeader chPayrollItemName;
		private System.Windows.Forms.ColumnHeader chPICategoryID;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListView lvwPayrollItem;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmListPayrollItem()
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
			this.lvwPayrollItem = new System.Windows.Forms.ListView();
			this.chPayrollItemID = new System.Windows.Forms.ColumnHeader();
			this.chPayrollItemName = new System.Windows.Forms.ColumnHeader();
			this.chPICategoryID = new System.Windows.Forms.ColumnHeader();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvwPayrollItem
			// 
			this.lvwPayrollItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwPayrollItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							 this.chPayrollItemID,
																							 this.chPayrollItemName,
																							 this.chPICategoryID});
			this.lvwPayrollItem.FullRowSelect = true;
			this.lvwPayrollItem.GridLines = true;
			this.lvwPayrollItem.Location = new System.Drawing.Point(0, 0);
			this.lvwPayrollItem.Name = "lvwPayrollItem";
			this.lvwPayrollItem.Size = new System.Drawing.Size(424, 240);
			this.lvwPayrollItem.TabIndex = 0;
			this.lvwPayrollItem.View = System.Windows.Forms.View.Details;
			// 
			// chPayrollItemID
			// 
			this.chPayrollItemID.Text = "Mã khoản";
			this.chPayrollItemID.Width = 100;
			// 
			// chPayrollItemName
			// 
			this.chPayrollItemName.Text = "Tên khoản";
			this.chPayrollItemName.Width = 200;
			// 
			// chPICategoryID
			// 
			this.chPICategoryID.Text = "Loại";
			this.chPICategoryID.Width = 120;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(104, 248);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "&Thêm mới";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(184, 248);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 10;
			this.btnEdit.Text = "&Sửa";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(264, 248);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "&Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(344, 248);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "&Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmListPayrollItem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 278);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lvwPayrollItem);
			this.Name = "frmListPayrollItem";
			this.Text = "Các khoản lương";
			this.Load += new System.EventHandler(this.frmListPayrollItem_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private PayrollDO payrollDO = null;
		private DataSet dsPayrollItem = null;

		private void PopulatePayrollItemListView()
		{
			lvwPayrollItem.Items.Clear();
			foreach (DataRow dr in dsPayrollItem.Tables[0].Rows)
			{
				string PayrollItemID = dr["PayrollItemID"].ToString();
				string PIName = dr["PIName"].ToString();
				string PICategoryName = dr["PICategoryName"].ToString();
				
				ListViewItem tmpLVItem = new ListViewItem(PayrollItemID);
				tmpLVItem.SubItems.Add(PIName);
				tmpLVItem.SubItems.Add(PICategoryName);

				lvwPayrollItem.Items.Add(tmpLVItem);
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmListPayrollItem_Load(object sender, System.EventArgs e)
		{
			payrollDO = new PayrollDO();
			dsPayrollItem = payrollDO.GetPayrollItems();

			PopulatePayrollItemListView();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmPayrollItem frm = new frmPayrollItem();
			frm.ShowDialog(this);
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			frmPayrollItem frm = new frmPayrollItem();
			frm.ShowDialog(this);
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
