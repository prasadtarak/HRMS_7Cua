using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
using XPTable.Models;

namespace EVSoft.HRMS.UI
{
	/// <summary>
	/// Summary description for frmChooseSocialInsurance.
	/// </summary>
	public class frmChooseSocialInsurance : System.Windows.Forms.Form
	{
		private SocialInsuranceDO insuranceDO = null;
		private DataSet dsInsurance = null;

		private int SelectedItem = -1; /// mac dinh ko chon hang nao tren list

		private XPTable.Models.Table lvwListInsurance;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnNewSocialInsurance;
		private XPTable.Models.ColumnModel columnModel1;
		private XPTable.Models.TableModel tableModel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private XPTable.Models.TextColumn cTerm;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private XPTable.Models.TextColumn cFromDate;
		private XPTable.Models.TextColumn cToDate;
		private frmMain frmmain = null;

		public frmChooseSocialInsurance(frmMain frmMain)
		{
			this.frmmain = frmMain;
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
			this.lvwListInsurance = new XPTable.Models.Table();
			this.columnModel1 = new XPTable.Models.ColumnModel();
			this.cTerm = new XPTable.Models.TextColumn();
			this.cFromDate = new XPTable.Models.TextColumn();
			this.cToDate = new XPTable.Models.TextColumn();
			this.tableModel1 = new XPTable.Models.TableModel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNewSocialInsurance = new System.Windows.Forms.Button();
			this.lblYear = new System.Windows.Forms.Label();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.lvwListInsurance)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvwListInsurance
			// 
			this.lvwListInsurance.AlternatingRowColor = System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(237)), ((System.Byte)(245)));
			this.lvwListInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwListInsurance.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(242)), ((System.Byte)(249)));
			this.lvwListInsurance.ColumnModel = this.columnModel1;
			this.lvwListInsurance.EnableToolTips = true;
			this.lvwListInsurance.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListInsurance.FullRowSelect = true;
			this.lvwListInsurance.GridColor = System.Drawing.SystemColors.ControlDark;
			this.lvwListInsurance.GridLines = XPTable.Models.GridLines.Both;
			this.lvwListInsurance.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
			this.lvwListInsurance.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lvwListInsurance.Location = new System.Drawing.Point(8, 16);
			this.lvwListInsurance.Name = "lvwListInsurance";
			this.lvwListInsurance.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
			this.lvwListInsurance.SelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(169)), ((System.Byte)(183)), ((System.Byte)(201)));
			this.lvwListInsurance.SelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListInsurance.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
			this.lvwListInsurance.Size = new System.Drawing.Size(314, 186);
			this.lvwListInsurance.SortedColumnBackColor = System.Drawing.Color.Transparent;
			this.lvwListInsurance.TabIndex = 4;
			this.lvwListInsurance.TableModel = this.tableModel1;
			this.lvwListInsurance.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(210)), ((System.Byte)(221)));
			this.lvwListInsurance.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((System.Byte)(14)), ((System.Byte)(66)), ((System.Byte)(121)));
			this.lvwListInsurance.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwListInsurance_SelectionChanged);
			this.lvwListInsurance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwListInsurance_MouseDown);
			// 
			// columnModel1
			// 
			this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
																			   this.cTerm,
																			   this.cFromDate,
																			   this.cToDate});
			// 
			// cTerm
			// 
			this.cTerm.Alignment = XPTable.Models.ColumnAlignment.Center;
			this.cTerm.Editable = false;
			this.cTerm.Text = "  Đợt";
			this.cTerm.Width = 55;
			// 
			// cFromDate
			// 
			this.cFromDate.Text = "Từ ngày";
			this.cFromDate.Width = 127;
			// 
			// cToDate
			// 
			this.cToDate.Text = "Đến ngày";
			this.cToDate.Width = 127;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvwListInsurance);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(330, 210);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(88, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Đóng";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnNewSocialInsurance
			// 
			this.btnNewSocialInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewSocialInsurance.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNewSocialInsurance.Location = new System.Drawing.Point(8, 16);
			this.btnNewSocialInsurance.Name = "btnNewSocialInsurance";
			this.btnNewSocialInsurance.TabIndex = 7;
			this.btnNewSocialInsurance.Text = "Tạo mới";
			this.btnNewSocialInsurance.Click += new System.EventHandler(this.btnNewSocialInsurance_Click);
			// 
			// lblYear
			// 
			this.lblYear.Location = new System.Drawing.Point(8, 16);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(40, 23);
			this.lblYear.TabIndex = 5;
			this.lblYear.Text = "Năm";
			// 
			// cboYear
			// 
			this.cboYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYear.Items.AddRange(new object[] {
														 "2006",
														 "2007",
														 "2008",
														 "2009",
														 "2010",
														 "2011",
														 "2012",
														 "2013",
														 "2014",
														 "2015",
														 "2016",
														 "2017",
														 "2018",
														 "2019",
														 "2020"});
			this.cboYear.Location = new System.Drawing.Point(64, 16);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(80, 21);
			this.cboYear.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblYear);
			this.groupBox2.Controls.Add(this.cboYear);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 48);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Controls.Add(this.btnNewSocialInsurance);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(162, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(176, 48);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// frmChooseSocialInsurance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(346, 264);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChooseSocialInsurance";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn lần lập danh sách BHYT- BHXH";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwListInsurance_MouseDown);
			this.Load += new System.EventHandler(this.frmChooseSocialInsurance_Load);
			((System.ComponentModel.ISupportInitialize)(this.lvwListInsurance)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnNewSocialInsurance_Click(object sender, System.EventArgs e)
		{
			frmSocialSheet frm = new frmSocialSheet();
//			frm.DsSocialInsurance = dsInsurance;
//			frm.SelectedRowIndex = dsInsurance.Tables[0].Rows.Count-1;
			int lastRowIndex = dsInsurance.Tables[0].Rows.Count-1;
			if(lastRowIndex >= 0)
			{
				DataRow dr = dsInsurance.Tables[0].Rows[lastRowIndex];
				frm.DtpFromDate.Value = DateTime.Parse( dr["EndPointDate"].ToString()).AddDays(1);
				frm.DtpToDate.Value = frm.DtpFromDate.Value.AddMonths(1);
			}
			else
			{
				frm.DtpFromDate.Value = new DateTime(int.Parse(cboYear.Text),1,1);
				frm.DtpToDate.Value = frm.DtpFromDate.Value.AddMonths(1);
			}
			
			this.Close();
			frm.MdiParent = this.frmmain;
			frm.Show();
					
//			frmSocialSheet frm = new frmSocialSheet();
//			this.Close();
//			frm.MdiParent = this.frmmain;
//			frm.Show();
//			this.Close();
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
			this.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_Text");
			this.lblYear.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_lblYear");
			this.btnNewSocialInsurance.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_btnNew");
			this.btnClose.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_btnClose");
			this.cFromDate.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_lvwFrom");
			this.cTerm.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_lvwDot");
			this.cToDate.Text = WorkingContext.LangManager.GetString("frmChoocseSocial_lvwTo");
			this.lvwListInsurance.NoItemsText = WorkingContext.LangManager.GetString("XPtable");
		}
		private void frmChooseSocialInsurance_Load(object sender, System.EventArgs e)
		{
			Refresh();
			cboYear.SelectedIndex = 0;
			insuranceDO = new SocialInsuranceDO();
			PopulateListInsuranInYear();
			this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void lvwListInsurance_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && e.Clicks== 2)
			{
				if(lvwListInsurance.SelectedIndicies.Length > 0)
				{
					frmSocialSheet frm = new frmSocialSheet();
					frm.DsSocialInsurance = dsInsurance;
					frm.SelectedRowIndex = SelectedItem;
					this.Close();
					frm.MdiParent = this.frmmain;
					frm.Show();
					
	
//					PopulateListInsuranInYear();
//					SelectedItem = -1;
//					tableModel1.Selections.Clear();
				}
//				frmSocialSheet frm = new frmSocialSheet();
//				this.Close();
//				frm.MdiParent = this.frmmain;
//				frm.Show();
			}
			
		}
		private void PopulateListInsuranInYear()
		{
			dsInsurance = insuranceDO.GetListInsuranceInYear(int.Parse(cboYear.Text));
			lvwListInsurance.BeginUpdate();
			lvwListInsurance.TableModel.Rows.Clear();
			int STT = 0;
			foreach (DataRow dr in dsInsurance.Tables[0].Rows)
			{
				
				String StartDate = DateTime.Parse(dr["StartPointDate"].ToString()).ToString("dd/MM/yyyy");
				String EndDate = DateTime.Parse(dr["EndPointDate"].ToString()).ToString("dd/MM/yyyy");
				Cell[] listInusurance = new Cell[3];
				listInusurance[0]= new Cell((STT+1).ToString());
				listInusurance[1]= new Cell(StartDate);
				listInusurance[2]= new Cell(EndDate);
				Row row = new Row(listInusurance);
				row.Tag = STT;
				lvwListInsurance.TableModel.Rows.Add(row);
				STT ++;
			}

			lvwListInsurance.EndUpdate();
		}

		private void cboYear_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			PopulateListInsuranInYear();
		}

		private void lvwListInsurance_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
		{
			if (e.NewSelectedIndicies.Length > 0) 
			{
				SelectedItem = (int)lvwListInsurance.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
			}
		}


		
	}
}
