using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using XPTable.Models;
using EVSoft.HRMS.DO;
namespace EVSoft.HRMS.UI.Admin
{
	/// <summary>
	/// Summary description for frmSysvar.
	/// </summary>
	public class frmThamsohethong : System.Windows.Forms.Form
	{
		private XPTable.Models.ColumnModel clmSysvar;
		private XPTable.Models.TableModel tblmSysvar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnExit;
		public XPTable.Models.Table tblSysvar;
		private XPTable.Models.TextColumn Descript;
		private XPTable.Models.TextColumn Value;
		private XPTable.Models.TextColumn Sys_name;
		AdminDO DOAdmin = new AdminDO();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
  
		public frmThamsohethong()
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
			this.clmSysvar = new XPTable.Models.ColumnModel();
			this.Sys_name = new XPTable.Models.TextColumn();
			this.Descript = new XPTable.Models.TextColumn();
			this.Value = new XPTable.Models.TextColumn();
			this.tblmSysvar = new XPTable.Models.TableModel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tblSysvar = new XPTable.Models.Table();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblSysvar)).BeginInit();
			this.SuspendLayout();
			// 
			// clmSysvar
			// 
			this.clmSysvar.Columns.AddRange(new XPTable.Models.Column[] {
																			this.Sys_name,
																			this.Descript,
																			this.Value});
			// 
			// Sys_name
			// 
			this.Sys_name.Visible = false;
			this.Sys_name.Width = 16;
			// 
			// Descript
			// 
			this.Descript.Editable = false;
			this.Descript.Text = "Mô tả";
			this.Descript.Width = 500;
			// 
			// Value
			// 
			this.Value.Editable = false;
			this.Value.Text = "Giá trị";
			this.Value.Width = 500;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(824, 614);
			this.panel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 558);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(824, 56);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnExit.Location = new System.Drawing.Point(742, 24);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Thoát";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEdit.Location = new System.Drawing.Point(667, 24);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tblSysvar);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(824, 614);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bảng tham số hệ thống";
			// 
			// tblSysvar
			// 
			this.tblSysvar.ColumnModel = this.clmSysvar;
			this.tblSysvar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblSysvar.FullRowSelect = true;
			this.tblSysvar.GridLines = XPTable.Models.GridLines.Both;
			this.tblSysvar.Location = new System.Drawing.Point(3, 16);
			this.tblSysvar.Name = "tblSysvar";
			this.tblSysvar.NoItemsText = "Không có tham số nào trong hệ thống";
			this.tblSysvar.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tblSysvar.Size = new System.Drawing.Size(818, 595);
			this.tblSysvar.TabIndex = 0;
			this.tblSysvar.TableModel = this.tblmSysvar;
			this.tblSysvar.Text = "table1";
			this.tblSysvar.UnfocusedSelectionForeColor = System.Drawing.SystemColors.Highlight;
			this.tblSysvar.CellDoubleClick += new XPTable.Events.CellMouseEventHandler(this.tblSysvar_CellDoubleClick);
			// 
			// frmThamsohethong
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 614);
			this.Controls.Add(this.panel1);
			this.Name = "frmThamsohethong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đặt tham số hệ thống";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSysvar_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tblSysvar)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void frmSysvar_Load(object sender, System.EventArgs e)
		{
		 
            GetSysVar();
            EVsoft.HRMS.Common.GeneralProcess.StandardFormControl(this);
		}
		public void GetSysVar()
		{
             tblmSysvar.Rows.Clear();
		    DataSet DsSysvar = DOAdmin.GetSysvar();
			foreach(DataRow r in DsSysvar.Tables[0].Rows)
            {
                XPTable.Models.Row Xprow = new Row();
				Xprow.Cells.Add(new Cell(r[0].ToString()));
				Xprow.Cells.Add(new Cell(r[1].ToString()));
				Xprow.Cells.Add(new Cell(r[2].ToString()));
                Xprow.Cells.Add(new Cell(r[3].ToString()));
                //Xprow.Cells.Add(new Cell(r[4].ToString()));
			    tblmSysvar.Rows.Add(Xprow);
            }            
		}
		
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			if(tblSysvar.SelectedItems.Length != 0)
			{
                frmAddSysVar frm = new frmAddSysVar(this, tblSysvar.SelectedItems[0].Cells[0].Text.Trim(), tblSysvar.SelectedItems[0].Cells[1].Text.Trim(), tblSysvar.SelectedItems[0].Cells[2].Text.Trim(), Convert.ToBoolean(tblSysvar.SelectedItems[0].Cells[3].Text.Trim()));
				frm.ShowDialog();
				
			}
			else
				MessageBox.Show("Vui lòng chọn một dòng","Thông báo");
		}

		private void tblSysvar_CellDoubleClick(object sender, XPTable.Events.CellMouseEventArgs e)
		{
			if(tblSysvar.SelectedItems.Length != 0)
			{

                frmAddSysVar frm = new frmAddSysVar(this, tblSysvar.SelectedItems[0].Cells[0].Text.Trim(), tblSysvar.SelectedItems[0].Cells[1].Text.Trim(), tblSysvar.SelectedItems[0].Cells[2].Text.Trim(), Convert.ToBoolean(tblSysvar.SelectedItems[0].Cells[3].Text.Trim()));
					frm.ShowDialog();
				
			}
			else
				MessageBox.Show("Vui lòng chọn một dòng","Thông báo");
		
		}
	}
}
