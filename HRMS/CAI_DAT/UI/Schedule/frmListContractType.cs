//-------------------------------------------------------------------------------
//Purpose: Form định nghĩa kiều hợp đồng
//Auther: tuyetna

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
//using GlacialComponents.Controls
using XPTable.Models;

namespace EVSoft.HRMS.UI.Schedule
{
	/// <summary>
	/// Summary description for frmListContractType.
	/// </summary>
	public class frmListContractType : System.Windows.Forms.Form
	{
		//		private ContractTypeDO ContractType = null;
		private ContractTypeDO ContractType = new ContractTypeDO();
		public CurrencyManager currManager;
		private DataSet dsContractType = new DataSet();
		private DataTable dtContractType = null;
		/// <summary>
		/// 
		/// </summary>
		private int selectedRow = -1;
		private System.Windows.Forms.GroupBox groupBox1;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.Table lvwContractTable;
		private XPTable.Models.TextColumn clContractName;
		private XPTable.Models.TextColumn clNote;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
		private XPTable.Models.TextColumn clSTT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmListContractType()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwContractTable = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.clSTT = new XPTable.Models.TextColumn();
			this.clContractName = new XPTable.Models.TextColumn();
			this.clNote = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwContractTable)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwContractTable);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(592, 416);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách các loại hợp đồng";
			// 
			// lvwContractTable
			// 
            //this.lvwContractTable.AllowDrop = true;
			this.lvwContractTable.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwContractTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwContractTable.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwContractTable.ColumnModel = this.columnModel1;
			this.lvwContractTable.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwContractTable.FullRowSelect = true;
			this.lvwContractTable.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwContractTable.GridLines = XPTable.Models.GridLines.Both;
			this.lvwContractTable.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwContractTable.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvwContractTable.Location = new System.Drawing.Point(8, 16);
			this.lvwContractTable.Name = "lvwContractTable";
			this.lvwContractTable.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwContractTable.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwContractTable.Size = new System.Drawing.Size(574, 390);
			this.lvwContractTable.TabIndex = 0;
			this.lvwContractTable.TableModel = this.tableModel1;
			this.lvwContractTable.Text = "table1";
			this.lvwContractTable.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwContractTable_SelectionChanged);
			this.lvwContractTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwContractTable_MouseDown_1);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.clSTT,
																			   this.clContractName,
																			   this.clNote});
			// 
			// clSTT
			// 
			this.clSTT.Editable = false;
			this.clSTT.Text = "STT";
			this.clSTT.Width = 45;
			// 
			// clContractName
			// 
			this.clContractName.Editable = false;
			this.clContractName.Text = "Tên hợp đồng";
			this.clContractName.Width = 180;
			// 
			// clNote
			// 
			this.clNote.Editable = false;
			this.clNote.Text = "                 Ghi chú";
			this.clNote.Width = 250;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(285, 434);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(365, 434);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(445, 434);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(525, 434);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmListContractType
			// 
		
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(610, 464);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmListContractType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống kê các loại hợp đồng";
			this.Load += new System.EventHandler(this.frmListContractType_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwContractTable)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmContractType frm = new frmContractType();
			frm.DsContractType = dsContractType;
			frm.ShowDialog();
			PopulateContractType();
			selectedRow = -1;// sau khi xóa xong thì đưa vị trí con trỏ về -1
			tableModel1.Selections.Clear();

		}
//		private void frmListContractType_Load(object sender, EventArgs e)
//		{
//			PopulateContractType();
//		}
		/// <summary>
		/// Hiển thị các kiểu hợp đồng được định nghĩa
		/// </summary>
		private void PopulateContractType()
		{
			dsContractType = ContractType.GetContractType();
			dtContractType = dsContractType.Tables[0];
			lvwContractTable.BeginUpdate();
			lvwContractTable.TableModel.Rows.Clear();
			int STT = 0;
			foreach(DataRow dr in dtContractType.Rows)
			{
				STT++;
				//string ContractID = dr["ContractID"].ToString();
				string ContractName = dr["ContractName"].ToString();
				string Note = dr["Note"].ToString();
				Row row = new Row(new string[]{STT.ToString(),ContractName,Note});
				row.Tag = STT-1;
				lvwContractTable.TableModel.Rows.Add(row);
			}
			lvwContractTable.EndUpdate();
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(selectedRow < 0 )
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Xoa_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Xoa_Title");
				//MessageBox.Show("Bạn chưa chọn kiểu hợp đồng nào!", "Xóa kiểu hợp đồng" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1 ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Xoa_Messa2");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Xoa_Title");
				//confirm lại có muốn xóa kiểu hợp đồng ko?
				DialogResult dr = MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					DeleteContractType();
					PopulateContractType();
				}
				else
				{
					dsContractType.RejectChanges();
				}
			}
			selectedRow = -1;// sau khi xóa xong thì đưa con trỏ về vị trí -1
			tableModel1.Selections.Clear();
			
		}
		/// <summary>
		/// Xóa kiểu hợp đồng
		/// </summary>
		private void DeleteContractType()
		{
			int ret = 0;
			try
			{
				dtContractType.Rows[selectedRow].Delete();
				ret = ContractType.DeleteContractTypeDB(dsContractType);
			}
			catch
			{
				dtContractType.RejectChanges();
			}
			if (ret == 1)
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Xoa_Messa3");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Xoa_Title");
				//MessageBox.Show("Kiểu hợp đồng đã được xóa khỏi CSDL", "Xóa kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
				dtContractType.AcceptChanges();
			}
			if (ret == -1)
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Xoa_Messa4");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Xoa_Title");
				//MessageBox.Show("Kiểu hợp đồng này vẫn tồn tại nhân viên đang được ký","Xóa kiểu hợp đồng",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
				dtContractType.RejectChanges();
			}
			if (ret == 0)
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Xoa_Messa5");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Xoa_Title");
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//MessageBox.Show("Không thể xóa kiểu hợp đồng này khỏi CSDL", "Xóa kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtContractType.RejectChanges();
			}
		}

		
		private void lvwContractTable_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if(e.NewSelectedIndicies.Length > 0)
			{
				selectedRow = (int)lvwContractTable.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}
		private void lvwContractTable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if(lvwContractTable.SelectedItems.Length > 0)
				{
					frmContractType frm = new frmContractType();
					frm.DsContractType = dsContractType;
					frm.SelectedRowIndex = selectedRow;
					frm.ShowDialog();
					PopulateContractType();
				}
				selectedRow = -1;
				tableModel1.Selections.Clear();
			}
		}

		private void btnEdit_Click_1(object sender, System.EventArgs e)
		{
			if(selectedRow >= 0)
			{
				frmContractType frm = new frmContractType();
				frm.DsContractType = dsContractType;
				frm.SelectedRowIndex = selectedRow;
				frm.ShowDialog();
				PopulateContractType();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmListContract_Sua_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmListContract_Sua_Title");
				//MessageBox.Show("bạn chưa chọn kiểu hợp đồng cần sửa", "Sửa kiểu hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			selectedRow = -1;// sau khi s?a xong thÌ dua v? trÃ­ con tr? v? -1
			tableModel1.Selections.Clear();
		}

		private void lvwContractTable_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if(lvwContractTable.SelectedItems.Length > 0)
				{
					frmContractType frm = new frmContractType();
					frm.DsContractType = dsContractType;
					frm.SelectedRowIndex = selectedRow;
					frm.ShowDialog();
					PopulateContractType();
				}
				selectedRow = -1;
				tableModel1.Selections.Clear();
			}
		}

		private void frmListContractType_Load(object sender, System.EventArgs e)
		{
			Refresh();
			PopulateContractType();
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
			this.Text = WorkingContext.LangManager.GetString("frmListContract_Text");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmListContract_groupbox1");
			this.clSTT.Text = WorkingContext.LangManager.GetString("frmListContract_lvwContract_STT");
			this.clContractName.Text = WorkingContext.LangManager.GetString("frmListContract_lvwContract_TenHopDong");
			this.clNote.Text = WorkingContext.LangManager.GetString("frmListContract_lvwContract_Note");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmListContract_btnAdd");
			this.btnEdit.Text = WorkingContext.LangManager.GetString("frmListContract_btnUpdate");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListContract_btnDelete");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListContract_btnClose");
			this.lvwContractTable.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
		
			
		}


		

		
		

	}
}
