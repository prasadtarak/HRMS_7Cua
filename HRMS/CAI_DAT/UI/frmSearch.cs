using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
//using GlacialComponents.Controls;
using XPTable.Editors;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Form này dùng cho chức năng tìm kiếm các thông tin về nhân viên
	/// </summary>
	public class frmSearch : Form

	{
		private System.ComponentModel.IContainer components;
		private Button btnExit;
		private XPTable.Models.TextColumn cCardID;
		private XPTable.Models.Table lvwEmployee;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn textColumn1;
		private XPTable.Models.TextColumn textColumn2;
		private XPTable.Models.TextColumn textColumn3;
		private XPTable.Models.TextColumn cEmployeeName;

		public frmSearch()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.btnExit = new System.Windows.Forms.Button();
			this.cCardID = new XPTable.Models.TextColumn();
			this.cEmployeeName = new XPTable.Models.TextColumn();
			this.lvwEmployee = new XPTable.Models.Table();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.textColumn1 = new XPTable.Models.TextColumn();
			this.textColumn2 = new XPTable.Models.TextColumn();
			this.textColumn3 = new XPTable.Models.TextColumn();
			((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExit.Location = new System.Drawing.Point(572, 392);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Đóng";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cCardID
			// 
			this.cCardID.Alignment = XPTable.Models.ColumnAlignment.Center;
			this.cCardID.Editable = false;
			this.cCardID.Text = "Mã thẻ";
			this.cCardID.Width = 80;
			// 
			// cEmployeeName
			// 
			this.cEmployeeName.Alignment = XPTable.Models.ColumnAlignment.Center;
			this.cEmployeeName.Editable = false;
			this.cEmployeeName.Text = "Họ và tên";
			this.cEmployeeName.Width = 150;
			// 
			// lvwEmployee
			// 
			this.lvwEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwEmployee.ColumnModel = this.columnModel1;
			this.lvwEmployee.Location = new System.Drawing.Point(8, 8);
			this.lvwEmployee.Name = "lvwEmployee";
			this.lvwEmployee.Size = new System.Drawing.Size(640, 368);
			this.lvwEmployee.TabIndex = 4;
			this.lvwEmployee.TableModel = this.tableModel1;
			this.lvwEmployee.Text = "table1";
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.textColumn1,
																			   this.textColumn2,
																			   this.textColumn3});
			// 
			// textColumn1
			// 
			this.textColumn1.Editable = false;
			this.textColumn1.Text = "DepartmentName";
			// 
			// textColumn2
			// 
			this.textColumn2.Editable = false;
			this.textColumn2.Text = "CardID";
			// 
			// textColumn3
			// 
			this.textColumn3.Editable = false;
			this.textColumn3.Text = "EmployeeName";
			// 
			// frmSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 422);
			this.Controls.Add(this.lvwEmployee);
			this.Controls.Add(this.btnExit);
			this.Name = "frmSearch";
			this.Text = "Tìm kiếm ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.lvwEmployee)).EndInit();
			this.ResumeLayout(false);

		}
		

		EmployeeDO employeeDO = null;
		DataSet dsEmployee = null;

		/// <summary>
		/// Hiển thị danh sách nhân viên trong công ty/phòng ban
		/// </summary>
		private void PopulateEmployeeListView()
		{
			dsEmployee = employeeDO.GetEmployeeByDepartment(1);
			lvwEmployee.BeginUpdate();

			foreach (DataRow dr in dsEmployee.Tables[0].Rows)
			{
				string CardID = dr["CardID"].ToString();
				string EmployeeName = dr["EmployeeName"].ToString();
				string DepartmentName= dr["DepartmentName"].ToString();
				
				Row xpRow = new Row(new string[] {DepartmentName,CardID, EmployeeName});
				lvwEmployee.TableModel.Rows.Add(xpRow);
			}
			lvwEmployee.EndUpdate();
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
			this.Text = WorkingContext.LangManager.GetString("frmSearch_Text");
			this.btnExit.Text = WorkingContext.LangManager.GetString("frmSearch_btnClose");
		}
		private void frmSearch_Load(object sender, EventArgs e)
		{
			Refresh();
			employeeDO = new EmployeeDO();

			PopulateEmployeeListView();
			ShowCurrentTime();

		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void ShowCurrentTime()
		{
			DateTime now = DateTime.Now;
		}
	}
}