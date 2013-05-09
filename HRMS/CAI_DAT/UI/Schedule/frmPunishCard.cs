using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
//using GlacialComponents.Controls;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmCard.
	/// </summary>
	public class frmPunishCard : System.Windows.Forms.Form
	{
		#region Các biến định nghĩa
		/// <summary>
		/// Biến xác định trạng thái cập nhật hay thêm mới
		/// Mặc định ban đầu là cập nhật
		/// </summary>
		private int EditStatus = 0;
		/// <summary>
		/// Biến xác định vị trí của hàng đang chọn
		/// </summary>
		private int selectedRowIndex = -1;
		private PunishCardDO punishCarDO = null;
		private DataSet dsPunishCard = null;
		private DataTable dtPunishCard = null;
		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnIgnore;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private XPTable.Models.TableModel tableModel1;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TextColumn chCardName;
		private XPTable.Models.TextColumn chPunishFactor;
		private XPTable.Models.TextColumn chNote;
		private XPTable.Models.TextColumn chSTT;
		private AMS.TextBox.NumericTextBox txtPunishFactor;
		private System.Windows.Forms.TextBox txtCardName;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClose;
		private XPTable.Models.Table lvwPunishCard;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPunishCard()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPunishCard));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvwPunishCard = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.chSTT = new XPTable.Models.TextColumn();
			this.chCardName = new XPTable.Models.TextColumn();
			this.chPunishFactor = new XPTable.Models.TextColumn();
			this.chNote = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.btnIgnore = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPunishFactor = new AMS.TextBox.NumericTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCardName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lvwPunishCard)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwPunishCard);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 184);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách thẻ phạt";
			// 
			// lvwPunishCard
			// 
			this.lvwPunishCard.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwPunishCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwPunishCard.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwPunishCard.ColumnModel = this.columnModel1;
			this.lvwPunishCard.EnableToolTips = true;
			this.lvwPunishCard.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwPunishCard.FullRowSelect = true;
			this.lvwPunishCard.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwPunishCard.GridLines = XPTable.Models.GridLines.Both;
			this.lvwPunishCard.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwPunishCard.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwPunishCard.Location = new System.Drawing.Point(8, 16);
			this.lvwPunishCard.Name = "lvwPunishCard";
			this.lvwPunishCard.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwPunishCard.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwPunishCard.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwPunishCard.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwPunishCard.Size = new System.Drawing.Size(464, 160);
			this.lvwPunishCard.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwPunishCard.TabIndex = 19;
			this.lvwPunishCard.TableModel = this.tableModel1;
			this.lvwPunishCard.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwPunishCard.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwPunishCard.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwPunishCard_SelectionChanged);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.chSTT,
																			   this.chCardName,
																			   this.chPunishFactor,
																			   this.chNote});
			// 
			// chSTT
			// 
			this.chSTT.Editable = false;
			this.chSTT.Text = "Số TT";
			this.chSTT.Width = 40;
			// 
			// chCardName
			// 
			this.chCardName.Editable = false;
			this.chCardName.Text = "Tên thẻ";
			this.chCardName.Width = 100;
			// 
			// chPunishFactor
			// 
			this.chPunishFactor.Editable = false;
			this.chPunishFactor.Text = "Hệ số phạt";
			// 
			// chNote
			// 
			this.chNote.Editable = false;
			this.chNote.Text = "Chú thích";
			this.chNote.Width = 240;
			// 
			// btnIgnore
			// 
			this.btnIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIgnore.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnIgnore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnIgnore.Location = new System.Drawing.Point(336, 304);
			this.btnIgnore.Name = "btnIgnore";
			this.btnIgnore.TabIndex = 18;
			this.btnIgnore.Text = "Bỏ qua";
			this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnUpdate.Location = new System.Drawing.Point(256, 304);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnAdd.Location = new System.Drawing.Point(96, 304);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDelete.Location = new System.Drawing.Point(176, 304);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Xóa ";
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnClose.Location = new System.Drawing.Point(416, 304);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.txtNote);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtPunishFactor);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtCardName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 96);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin thẻ phạt";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.Location = new System.Drawing.Point(64, 64);
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(408, 20);
			this.txtNote.TabIndex = 20;
			this.txtNote.Text = "";
			this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.label2.Location = new System.Drawing.Point(152, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "%";
			// 
			// txtPunishFactor
			// 
			this.txtPunishFactor.AllowNegative = true;
			this.txtPunishFactor.DigitsInGroup = 0;
			this.txtPunishFactor.Flags = 0;
			this.txtPunishFactor.Location = new System.Drawing.Point(64, 40);
			this.txtPunishFactor.MaxDecimalPlaces = 4;
			this.txtPunishFactor.MaxWholeDigits = 9;
			this.txtPunishFactor.Name = "txtPunishFactor";
			this.txtPunishFactor.Prefix = "";
			this.txtPunishFactor.RangeMax = 1.7976931348623157E+308;
			this.txtPunishFactor.RangeMin = -1.7976931348623157E+308;
			this.txtPunishFactor.Size = new System.Drawing.Size(88, 20);
			this.txtPunishFactor.TabIndex = 18;
			this.txtPunishFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunishFactor_KeyPress);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Mức phạt";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Chú thích";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCardName
			// 
			this.txtCardName.Location = new System.Drawing.Point(64, 16);
			this.txtCardName.Name = "txtCardName";
			this.txtCardName.ReadOnly = true;
			this.txtCardName.Size = new System.Drawing.Size(136, 20);
			this.txtCardName.TabIndex = 4;
			this.txtCardName.Text = "";
			this.txtCardName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardName_KeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên thẻ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmPunishCard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(498, 336);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnIgnore);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPunishCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Định nghĩa thẻ phạt";
			this.Load += new System.EventHandler(this.frmPunishCard_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lvwPunishCard)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
//			AddPunishCard();
			EditStatus = 1;// chuyển sang chế độ thêm mới
			txtCardName.Text = "";
			txtPunishFactor.Text = "";
			txtNote.Text = "";
			SetEditStatus(true);
		}
		private DataRow SetData(DataRow dr)
		{
			dr.BeginEdit();
			dr["CardName"] = txtCardName.Text.Trim();
			dr["PunishFactor"] = txtPunishFactor.Text.Trim();
			dr["Note"] = txtNote.Text;
			dr.EndEdit();
			return dr;
		}

		private void frmPunishCard_Load(object sender, System.EventArgs e)
		{
			Refresh();
			punishCarDO = new PunishCardDO();
			dsPunishCard = punishCarDO.GetPunishCard();
			PopulatePunishCardView();
			selectedRowIndex = 0;
			LoadPunishCard();
			SetEditStatus(false);
		}

		private void btnIgnore_Click(object sender, System.EventArgs e)
		{
			EditStatus = 0;
			SetEditStatus(false);
			if(selectedRowIndex >= 0)
			{
				LoadPunishCard();
			}
			
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(selectedRowIndex >= 0 )
			{
				DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					DeletePunishCard();
					if(dsPunishCard.Tables[0].Rows.Count > 0)
					{
						selectedRowIndex = 0;
					}
					PopulatePunishCardView();
					// kiểm tra sau khi xóa nếu dataset có dữ liệu thì bind hàng đầu tiên lên các textbox
					if(dsPunishCard.Tables[0].Rows.Count > 0)
					{
						selectedRowIndex = 0;
						LoadPunishCard();

					}
				}
				else
				{
					dsPunishCard.RejectChanges();
				}
				
			}
			else
			{
				MessageBox.Show("Bạn chưa kiểu ngày nào!", "Xóa kiểu ngày", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			SetEditStatus(false);
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			if(CheckPunishFactor())
			{
				if(EditStatus == 0)
				{
					UpdatePunishCard();
				}
				else
				{
					AddPunishCard();				
				}

				SetEditStatus(false);
				PopulatePunishCardView();
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("Message_Punish");
				string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
				//MessageBox.Show("Không thể cập nhật, có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		
		
		/// <summary>
		/// 
		/// </summary>
		private void AddPunishCard()
		{
			dtPunishCard = dsPunishCard.Tables[0];
			DataRow dr = dtPunishCard.NewRow();
			dtPunishCard.Rows.Add(SetData(dr));

			int ret = 0;
			try
			{
				ret = punishCarDO.AddPunishCard(dsPunishCard);
			}
			catch
			{
				
			}
			if(ret != 0)
			{
				MessageBox.Show("Thiết lập thẻ phạt thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				dsPunishCard.AcceptChanges();
			}
			else
			{
				MessageBox.Show("Thiết lập thẻ phạt thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				dsPunishCard.RejectChanges();
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="edit"></param>
		private void SetEditStatus(bool edit)
		{
			btnAdd.Enabled = !edit;
			btnIgnore.Enabled = edit;
			btnUpdate.Enabled = edit;
			btnDelete.Enabled = !edit;
			lvwPunishCard.Enabled = !edit;

		}
		/// <summary>
		/// 
		/// </summary>
		private void PopulatePunishCardView()
		{
			dsPunishCard = punishCarDO.GetPunishCard();

			lvwPunishCard.BeginUpdate();
			lvwPunishCard.TableModel.Rows.Clear();
			dtPunishCard = dsPunishCard.Tables[0];
			int STT = 0;
			foreach (DataRow dr in dtPunishCard.Rows)
			{
				string CardName = dr["CardName"].ToString();
				string PunishFactor = dr["PunishFactor"].ToString()+ " %";
				string Note = dr["Note"].ToString();

				Row row = new Row(new string[]{(STT+1).ToString(),CardName, PunishFactor, Note});
				row.Tag = STT;
				lvwPunishCard.TableModel.Rows.Add(row);

				STT++;
			}
			lvwPunishCard.EndUpdate();
          
		}
		/// <summary>
		/// 
		/// </summary>
		public void UpdatePunishCard()
		{
			dtPunishCard = dsPunishCard.Tables[0];
			DataRow dr = dtPunishCard.Rows[selectedRowIndex];
			dr = SetData(dr);

			int ret = 0;
			try
			{
				ret = punishCarDO.UpdatePunishCard(dsPunishCard);
				dsPunishCard.AcceptChanges();
			}
			catch
			{
			}

			if (ret != 0)
			{
				string str = WorkingContext.LangManager.GetString("frmPunishCard_update_Messa");
				string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
				//MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string str = WorkingContext.LangManager.GetString("frmPunishCard_update_Messa1");
				string str1 = WorkingContext.LangManager.GetString("frmShift_Update_Title1");
				//MessageBox.Show("Không thể cập nhật, có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void lvwPunishCard_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				selectedRowIndex = (int)lvwPunishCard.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
				LoadPunishCard();
			}

		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadPunishCard()
		{
			DataRow dr = dtPunishCard.Rows[selectedRowIndex];
			if (dr != null)
			{
				txtCardName.Text = dr["CardName"].ToString();
				txtNote.Text = dr["Note"].ToString();
				txtPunishFactor.Text = dr["PunishFactor"].ToString();
			}
		}

		private void txtCardName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			SetEditStatus(true);
		}

		private void txtPunishFactor_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			SetEditStatus(true);
		}

		private void txtNote_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			SetEditStatus(true);
		}
		
		/// <summary>
		/// 
		/// </summary>
		private void DeletePunishCard()
		{
			int ret = 0;
			try
			{
				dtPunishCard.Rows[selectedRowIndex].Delete();
				ret = punishCarDO.DeletePunishCard(dsPunishCard);
			}
			catch
			{
				dsPunishCard.RejectChanges();
			}
			if (ret != 0)
			{
				MessageBox.Show("Kiểu thẻ phạt đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				dsPunishCard.AcceptChanges();
				//				PopulateEmployeeListView();
			}
			else
			{
				MessageBox.Show("Không thể xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dsPunishCard.RejectChanges();
			}


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
			this.Text = WorkingContext.LangManager.GetString("frmPunishCard_Text");
			this.groupBox2.Text = WorkingContext.LangManager.GetString("frmPunishCard_GroupBox2");
			this.label1.Text = WorkingContext.LangManager.GetString("frmPunishCard_GroupBox2_lblTenThe");
			this.label4.Text = WorkingContext.LangManager.GetString("frmPunishCard_GroupBox2_lblMucPhat");
			this.label3.Text = WorkingContext.LangManager.GetString("frmPunishCard_GroupBox2_lblChuThich");
			this.groupBox1.Text = WorkingContext.LangManager.GetString("frmPunishCard_GroupBox1");
			this.chSTT.Text = WorkingContext.LangManager.GetString("frmPunishCard_lvwPunishCard_STT");
			this.chCardName.Text = WorkingContext.LangManager.GetString("frmPunishCard_lvwPunishCard_TenThePhat");
			this.chPunishFactor.Text = WorkingContext.LangManager.GetString("frmPunishCard_lvwPunishCard_HeSoPhat");
			this.chNote.Text = WorkingContext.LangManager.GetString("frmPunishCard_lvwPunishCard_ChuThich");
			this.btnAdd.Text = WorkingContext.LangManager.GetString("frmPunishCard_bntAdd");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmPunishCard_bntClose");
			this.btnDelete.Text = WorkingContext.LangManager.GetString("frmPunishCard_bntDelete");
			this.btnIgnore.Text = WorkingContext.LangManager.GetString("frmPunishCard_bntIgron");
			this.btnUpdate.Text = WorkingContext.LangManager.GetString("frmPunishCard_bntUpDate");
			
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool CheckPunishFactor()
		{
			if(txtPunishFactor.Text == "")
				return false;
			else
				return true;
			
		}
	}
}
