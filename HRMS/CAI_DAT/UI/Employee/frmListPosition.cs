using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.UI.Employee;
using EVSoft.HRMS.Common;
//using GlacialComponents.Controls;
using XPTable.Models;

namespace EVSoft.HRMS.UI.Employee
{
	/// <summary>
	/// Summary description for frmPosition.
	/// </summary>
	public class frmListPosition : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox grbPositionList;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.TextColumn cSTT;
		private XPTable.Models.TextColumn cPositionName;
		private XPTable.Models.TextColumn cPositionShortName;
		private XPTable.Models.TextColumn cDescription;
		private XPTable.Models.Table lvwPosition;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmListPosition()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPosition));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbPositionList = new System.Windows.Forms.GroupBox();
            this.lvwPosition = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.TextColumn();
            this.cPositionName = new XPTable.Models.TextColumn();
            this.cPositionShortName = new XPTable.Models.TextColumn();
            this.cDescription = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.grbPositionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(280, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(200, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNew.Location = new System.Drawing.Point(120, 230);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(72, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Thêm &mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(358, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbPositionList
            // 
            this.grbPositionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPositionList.Controls.Add(this.lvwPosition);
            this.grbPositionList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbPositionList.Location = new System.Drawing.Point(8, 8);
            this.grbPositionList.Name = "grbPositionList";
            this.grbPositionList.Size = new System.Drawing.Size(424, 216);
            this.grbPositionList.TabIndex = 35;
            this.grbPositionList.TabStop = false;
            this.grbPositionList.Text = "Danh sách chức vụ";
            // 
            // lvwPosition
            // 
            this.lvwPosition.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwPosition.ColumnModel = this.columnModel1;
            this.lvwPosition.EnableToolTips = true;
            this.lvwPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.FullRowSelect = true;
            this.lvwPosition.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwPosition.GridLines = XPTable.Models.GridLines.Both;
            this.lvwPosition.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwPosition.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwPosition.Location = new System.Drawing.Point(8, 16);
            this.lvwPosition.Name = "lvwPosition";
            this.lvwPosition.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwPosition.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwPosition.Size = new System.Drawing.Size(408, 192);
            this.lvwPosition.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwPosition.TabIndex = 13;
            this.lvwPosition.TableModel = this.tableModel1;
            this.lvwPosition.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwPosition.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwPosition.CellDoubleClick += new XPTable.Events.CellMouseEventHandler(this.lvwPosition_CellDoubleClick);
            this.lvwPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwPosition_MouseDown);
            this.lvwPosition.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwPosition_SelectionChanged);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.cPositionName,
            this.cPositionShortName,
            this.cDescription});
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Text = "STT";
            this.cSTT.Width = 50;
            // 
            // cPositionName
            // 
            this.cPositionName.Editable = false;
            this.cPositionName.Text = "Tên chức vụ";
            this.cPositionName.Width = 120;
            // 
            // cPositionShortName
            // 
            this.cPositionShortName.Editable = false;
            this.cPositionShortName.Text = "Tên viết tắt";
            this.cPositionShortName.Width = 80;
            // 
            // cDescription
            // 
            this.cDescription.Editable = false;
            this.cDescription.Text = "Mô tả";
            this.cDescription.Width = 150;
            // 
            // frmListPosition
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(438, 260);
            this.Controls.Add(this.grbPositionList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chức vụ";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.grbPositionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwPosition)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Variables
		/// <summary>
		/// 
		/// </summary>
		private int selectedRowIndex = -1;
		/// <summary>
		/// 
		/// </summary>
		private DepartmentDO departmentDO = null;
		/// <summary>
		/// 
		/// </summary>
		private DataSet dsPosition = null;
		/// <summary>
		/// 
		/// </summary>
		private DataTable dtPosition = null;

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private void PopulatePositionListView()
		{
			dsPosition = departmentDO.GetAllPositions();

			lvwPosition.BeginUpdate();
			lvwPosition.TableModel.Rows.Clear();
			dtPosition = dsPosition.Tables[0];
			if (dtPosition.Rows.Count > 0) 
			{
//				selectedRowIndex = 0;
				int STT = 0;
				foreach (DataRow dr in dtPosition.Rows)
				{
					STT++;
					string PositionName = dr["PositionName"].ToString();
					string PositionShortName = dr["PositionShortName"].ToString();
					string Description = dr["Description"].ToString();

					Row row = new Row(new string[]{STT.ToString(), PositionName , PositionShortName, Description});
					row.Tag = STT - 1;
					lvwPosition.TableModel.Rows.Add(row);
				}
			}
			lvwPosition.EndUpdate();
		}


		private void btnAddNew_Click(object sender, System.EventArgs e)
		{
			frmPosition frm = new frmPosition();
			frm.PositionDataSet = dsPosition;
			frm.ShowDialog(this);
			PopulatePositionListView();
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
		    updatePosition();
		}

        /// <summary>
        /// Cap nhat thong tin chuc vu
        /// </summary>
        private  void updatePosition ()
        {
            if (selectedRowIndex < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmPosition_UpDate_Error_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmPosition_UpDate_Error_Title");
                //MessageBox.Show("Bạn chưa chọn chức vụ nào", "Thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPosition frm = new frmPosition();
                frm.PositionDataSet = dsPosition;
                frm.SelectedPosition = selectedRowIndex;
                frm.ShowDialog(this);
                PopulatePositionListView();
            }
            selectedRowIndex = -1;
            tableModel1.Selections.Clear();
        }
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(selectedRowIndex < 0 )
			{
				string str = WorkingContext.LangManager.GetString("frmListPosition_Delete_Error_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title1");
				//MessageBox.Show("Chưa chọn chức vụ cần xóa","Xóa chức vụ",MessageBoxButtons.OK,MessageBoxIcon.Error);
				MessageBox.Show(str,str1,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				DeletePosition();
			}
			selectedRowIndex = -1;
			tableModel1.Selections.Clear();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmPosition_Load(object sender, System.EventArgs e)
		{
			Refresh();
			departmentDO = new DepartmentDO();
			PopulatePositionListView();
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
			this.Text = WorkingContext.LangManager.GetString("frmListPosition_Text");
			this.grbPositionList.Text = WorkingContext.LangManager.GetString("frmListPosition_grpPosotionList");
			this.cSTT.Text = WorkingContext.LangManager.GetString("frmListPosition_lvwPosition_STT");
			this.cDescription.Text = WorkingContext.LangManager.GetString("frmListPosition_lvwPosition_MoTa");
			this.cPositionName.Text = WorkingContext.LangManager.GetString("frmListPosition_lvwPosition_TenChucVu");
			this.cPositionShortName.Text = WorkingContext.LangManager.GetString("frmListPosition_lvwPosition_TenVietTat");
			this.btnAddNew.Text = WorkingContext.LangManager.GetString("frmListPosition_bntAddNew");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmListPosition_bntClose");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmListPosition_bntUpDate");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmListPosition_bntDelete");
			this.lvwPosition.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
		}

		/// <summary>
		/// Xóa chức vụ
		/// </summary>
		private void DeletePosition()
		{
			string PositionName = dtPosition.Rows[selectedRowIndex]["PositionName"].ToString();
			string str = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Messa1");
			string str2 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
			if (MessageBox.Show(str+"'" + PositionName + "' ?", str2,MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				int result = 0;
				try 
				{
					dtPosition.Rows[selectedRowIndex].Delete();

					result = departmentDO.DeletePosition(dsPosition);
				}
				catch
				{
					
				}
				if (result == 1)
				{
					string str1 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Messa2");
					string str3 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
					//MessageBox.Show("Xóa chức vụ thành công!", "Xóa chức vụ",MessageBoxButtons.OK, MessageBoxIcon.Information);
					MessageBox.Show(str1, str3,MessageBoxButtons.OK, MessageBoxIcon.Information);
					dsPosition.AcceptChanges();
				}
				if (result == -1)
				{
					string str1 = WorkingContext.LangManager.GetString("frmListPosition_Del_ThongBao_Messa3");
					string str3 = WorkingContext.LangManager.GetString("frmListPosition_Delete_ThongBao_Title2");
					//MessageBox.Show("Xóa chức vụ thất bại! Đã có nhân viên được gán chức vụ này!", "Xóa chức vụ",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					MessageBox.Show(str1, str3,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					dsPosition.RejectChanges();					
				}
				PopulatePositionListView();
			}
		}


		private void lvwPosition_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwPosition.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}

		private void lvwPosition_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 2)
			{
				if (lvwPosition.SelectedItems.Length > 0)
				{
					frmPosition frm = new frmPosition();
					frm.PositionDataSet = dsPosition;
					frm.SelectedPosition = selectedRowIndex;
					frm.ShowDialog(this);
					PopulatePositionListView();
				}
				selectedRowIndex = -1;
				tableModel1.Selections.Clear();
			}
		}

        private void lvwPosition_CellDoubleClick(object sender, XPTable.Events.CellMouseEventArgs e)
        {
            updatePosition();
        }

	}
}
