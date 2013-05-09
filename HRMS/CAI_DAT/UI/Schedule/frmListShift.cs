using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.UI;
using XPTable.Events;
using XPTable.Models;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.Schedule
{
    /// <summary>
    /// Summary description for frmListShift.
    /// </summary>
    public class frmListShift : Form
    {
        #region các biến tự định nghĩa
        private DataSet dsShift = null;
        private ShiftDO shiftDO = null;
        private DataTable dtShift = null;
        private DataSet dsShiftOver = null;
        private int selectedRow = -1;
        #endregion

        private GroupBox groupBox1;
        private Table lvwShift;
        private ColumnModel columnModel1;
        private TableModel tableModel1;
        private Button btnEditShift;
        private Button btnClose;
        private Button btnAddShift;
        private Button btnDelete;
        private TableModel tableModel2;
        private XPTable.Models.CheckBoxColumn chkBreakShift;
        private ColumnModel columnModel2;
        private TextColumn textColumn1;
        private TextColumn textColumn2;
        private TextColumn textColumn3;
        private TextColumn textColumn4;
        private TextColumn textColumn5;
        private TextColumn cSTT;
        private TextColumn clShiftName;
        private TextColumn clCheckIn1;
        private TextColumn clCheckOut1;
        private TextColumn clDescription;
        private SplitContainer splitContainer1;
        private TextColumn clCheckIn2;
        private TextColumn clCheckOut2;
        private TextColumn clDeltaLateTime;
        private TextColumn clDeltaAllowCheck;


        #region xử lý các sự kiện
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public frmListShift()
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListShift));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwShift = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.cSTT = new XPTable.Models.TextColumn();
            this.clShiftName = new XPTable.Models.TextColumn();
            this.chkBreakShift = new XPTable.Models.CheckBoxColumn();
            this.clDeltaLateTime = new XPTable.Models.TextColumn();
            this.clCheckIn1 = new XPTable.Models.TextColumn();
            this.clCheckOut1 = new XPTable.Models.TextColumn();
            this.clCheckIn2 = new XPTable.Models.TextColumn();
            this.clCheckOut2 = new XPTable.Models.TextColumn();
            this.clDeltaAllowCheck = new XPTable.Models.TextColumn();
            this.clDescription = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnEditShift = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.columnModel2 = new XPTable.Models.ColumnModel();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.textColumn3 = new XPTable.Models.TextColumn();
            this.textColumn4 = new XPTable.Models.TextColumn();
            this.textColumn5 = new XPTable.Models.TextColumn();
            this.tableModel2 = new XPTable.Models.TableModel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwShift)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwShift);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ca";
            // 
            // lvwShift
            // 
            this.lvwShift.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.lvwShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.lvwShift.ColumnModel = this.columnModel1;
            this.lvwShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwShift.EnableToolTips = true;
            this.lvwShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwShift.FullRowSelect = true;
            this.lvwShift.GridColor = System.Drawing.SystemColors.ControlDark;
            this.lvwShift.GridLines = XPTable.Models.GridLines.Both;
            this.lvwShift.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.lvwShift.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lvwShift.Location = new System.Drawing.Point(3, 16);
            this.lvwShift.Name = "lvwShift";
            this.lvwShift.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.lvwShift.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwShift.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.lvwShift.Size = new System.Drawing.Size(778, 478);
            this.lvwShift.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.lvwShift.TabIndex = 0;
            this.lvwShift.TableModel = this.tableModel1;
            this.lvwShift.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.lvwShift.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.lvwShift.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.lvwShift_SelectionChanged);
            this.lvwShift.DoubleClick += new System.EventHandler(this.btnEditShift_Click);
            this.lvwShift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwShift_MouseDown);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.cSTT,
            this.clShiftName,
            this.chkBreakShift,
            this.clDeltaLateTime,
            this.clCheckIn1,
            this.clCheckOut1,
            this.clCheckIn2,
            this.clCheckOut2,
            this.clDeltaAllowCheck,
            this.clDescription});
            // 
            // cSTT
            // 
            this.cSTT.Editable = false;
            this.cSTT.Text = "STT";
            this.cSTT.Width = 40;
            // 
            // clShiftName
            // 
            this.clShiftName.Editable = false;
            this.clShiftName.Text = "Tên ca";
            this.clShiftName.Width = 100;
            // 
            // chkBreakShift
            // 
            this.chkBreakShift.Alignment = XPTable.Models.ColumnAlignment.Center;
            this.chkBreakShift.Editable = false;
            this.chkBreakShift.Text = "Ca gãy";
            this.chkBreakShift.Width = 50;
            // 
            // clDeltaLateTime
            // 
            this.clDeltaLateTime.Editable = false;
            this.clDeltaLateTime.Text = "Đi muộn";
            this.clDeltaLateTime.Width = 70;
            // 
            // clCheckIn1
            // 
            this.clCheckIn1.Editable = false;
            this.clCheckIn1.Text = "Giờ vào 1";
            this.clCheckIn1.Width = 70;
            // 
            // clCheckOut1
            // 
            this.clCheckOut1.Editable = false;
            this.clCheckOut1.Text = "Giờ ra 1";
            this.clCheckOut1.Width = 70;
            // 
            // clCheckIn2
            // 
            this.clCheckIn2.Editable = false;
            this.clCheckIn2.Text = "Giờ vào 2";
            this.clCheckIn2.Width = 70;
            // 
            // clCheckOut2
            // 
            this.clCheckOut2.Editable = false;
            this.clCheckOut2.Text = "Giờ ra 2";
            this.clCheckOut2.Width = 70;
            // 
            // clDeltaAllowCheck
            // 
            this.clDeltaAllowCheck.Editable = false;
            this.clDeltaAllowCheck.Text = "Chấp nhận quẹt thẻ";
            this.clDeltaAllowCheck.Width = 125;
            // 
            // clDescription
            // 
            this.clDescription.Editable = false;
            this.clDescription.Text = "Mô tả";
            this.clDescription.Width = 150;
            // 
            // btnEditShift
            // 
            this.btnEditShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditShift.Location = new System.Drawing.Point(528, 21);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(75, 23);
            this.btnEditShift.TabIndex = 1;
            this.btnEditShift.Text = "&Sửa";
            this.btnEditShift.Click += new System.EventHandler(this.btnEditShift_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(694, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddShift
            // 
            this.btnAddShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddShift.Location = new System.Drawing.Point(445, 21);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(75, 23);
            this.btnAddShift.TabIndex = 0;
            this.btnAddShift.Text = "&Thêm";
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(611, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // columnModel2
            // 
            this.columnModel2.Columns.AddRange(new XPTable.Models.Column[] {
            this.textColumn1,
            this.textColumn2,
            this.textColumn3,
            this.textColumn4,
            this.textColumn5});
            // 
            // textColumn1
            // 
            this.textColumn1.Editable = false;
            this.textColumn1.Text = "STT";
            this.textColumn1.Width = 40;
            // 
            // textColumn2
            // 
            this.textColumn2.Editable = false;
            this.textColumn2.Text = "Tên ca";
            this.textColumn2.Width = 120;
            // 
            // textColumn3
            // 
            this.textColumn3.Editable = false;
            this.textColumn3.Text = "Giờ đầu ca";
            this.textColumn3.Width = 80;
            // 
            // textColumn4
            // 
            this.textColumn4.Editable = false;
            this.textColumn4.Text = "Giờ kết thúc";
            this.textColumn4.Width = 80;
            // 
            // textColumn5
            // 
            this.textColumn5.Editable = false;
            this.textColumn5.Text = "Miêu tả";
            this.textColumn5.Width = 220;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnEditShift);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddShift);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 0;
            // 
            // frmListShift
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách ca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListShift_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwShift)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListShift_Load(object sender, EventArgs e)
        {
            Refresh();
            shiftDO = new ShiftDO();
            PopulateShift();

        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Edit_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Edit_Title");
                //MessageBox.Show("Bạn chưa chọn ca cần sửa!", "Sửa ca", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmShift shift = new frmShift();
                shift.DsOverTime = dsShift;
                shift.CurrentShift = selectedRow;
                shift.ShowDialog();
                PopulateShift();
            }
            selectedRow = -1;
            tableModel1.Selections.Clear();

        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            frmShift frm = new frmShift();
            frm.ShowDialog();
            PopulateShift();
            selectedRow = -1;
            tableModel1.Selections.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Bạn chưa chọn ca cần xóa!", "Xóa ca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //confirm lại có chắc chắn muốn xóa ca làm việc này ko?
                DialogResult dr = MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DeleteShift();
                    PopulateShift();
                }
            }
            selectedRow = -1;
            tableModel1.Selections.Clear();
        }

        private void lvwShift_SelectionChanged(object sender, SelectionEventArgs e)
        {
            if (e.NewSelectedIndicies.Length > 0)
            {
                selectedRow = (int)lvwShift.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
            }
        }

        private void lvwShift_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (lvwShift.SelectedIndicies.Length > 0)
                {
                    frmShift shift = new frmShift();
                    shift.DsOverTime = dsShift;
                    shift.CurrentShift = selectedRow;
                    shift.ShowDialog();
                    PopulateShift();
                }
                selectedRow = -1;
                tableModel1.Selections.Clear();
            }
        }
        #endregion

        #region Các hàm xử lý chính
        /// <summary>
        /// Điền các ca đã định nghĩa vào ListView
        /// </summary>
        private void PopulateShift()
        {
            dsShift = shiftDO.GetShift();

            dtShift = dsShift.Tables[0];

            lvwShift.BeginUpdate();

            lvwShift.TableModel.Rows.Clear();
            int STT = 0;
            foreach (DataRow dr in dtShift.Rows)
            {
                string stt = (STT + 1).ToString();
                string strShiftName = dr["ShiftName"].ToString();
                string strDescription = dr["Description"].ToString();
                bool bBreakShiftPri = Boolean.Parse(dr["BreakShift"].ToString());
                string strDeltaLateTime = dr["DeltaLateTime"].ToString();
                string strCheckIn1 = DateTime.Parse(dr["CheckIn1"].ToString()).ToString("HH:mm");
                string strCheckOut1 = DateTime.Parse(dr["CheckOut1"].ToString()).ToString("HH:mm");
                string strCheckIn2 = "";
                string strCheckOut2 = "";
                string strDeltaAllowCheck = "";
                if (bBreakShiftPri)
                {
                    strCheckIn2 = DateTime.Parse(dr["CheckIn2"].ToString()).ToString("HH:mm");
                    strCheckOut2 = DateTime.Parse(dr["CheckOut2"].ToString()).ToString("HH:mm");
                    strDeltaAllowCheck = dr["DeltaAllowCheck"].ToString();
                }

                Cell[] ShiftList = new Cell[10];
                ShiftList[0] = new Cell(stt);
                ShiftList[1] = new Cell(strShiftName);
                ShiftList[2] = new Cell(bBreakShiftPri);
                ShiftList[2].Checked = bBreakShiftPri;
                ShiftList[3] = new Cell(strDeltaLateTime);
                ShiftList[4] = new Cell(strCheckIn1);
                ShiftList[5] = new Cell(strCheckOut1);
                ShiftList[6] = new Cell(strCheckIn2);
                ShiftList[7] = new Cell(strCheckOut2);
                ShiftList[8] = new Cell(strDeltaAllowCheck);
                ShiftList[9] = new Cell(strDescription);

                Row row = new Row(ShiftList);
                row.Tag = STT;
                lvwShift.TableModel.Rows.Add(row);
                STT++;

            }

            lvwShift.EndUpdate();
        }

        /// <summary>
        /// xóa ca
        /// </summary>
        public void DeleteShift()
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa4");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Bạn chưa chọn ca nào!", "Xóa ca", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ret = 0;
            try
            {
                dtShift.Rows[selectedRow].Delete();
                ret = shiftDO.DeleteShift(dsShift);
            }
            catch
            {
                dtShift.RejectChanges();
            }
            if (ret == 2)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa3");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Ca đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtShift.AcceptChanges();
                //				PopulateEmployeeListView();
            }
            else if (ret == 1)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa4");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Không thể xóa ca khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str + "\n Tồn tại nhân viên đăng ký ca làm việc này !", str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtShift.RejectChanges();
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa4");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Không thể xóa ca khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtShift.RejectChanges();
            }
        }

        /// <summary>
        /// Xóa ca làm thêm
        /// </summary>
        public void DeleteShiftOver()
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa4");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Bạn chưa chọn ca nào!", "Xóa ca", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ret = 0;
            try
            {
                ShiftDO shiftDO = new ShiftDO();
                DataSet dsShiftOver = shiftDO.GetShiftOver();
                DataTable dtShift = dsShiftOver.Tables[0];
                dtShift.Rows[selectedRow].Delete();
                ret = shiftDO.DeleteShiftOver(dsShiftOver);
            }
            catch
            {
                dtShift.RejectChanges();
            }
            if (ret == 2)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa3");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Ca đã được xóa khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtShift.AcceptChanges();
                //				PopulateEmployeeListView();
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa4");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Không thể xóa ca khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtShift.RejectChanges();
            }
        }

        public override void Refresh()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Refresh();
            }

            base.Refresh();
        }
        #endregion

        private void btnAddShiftOver_Click(object sender, EventArgs e)
        {
            frmShift frm = new frmShift(1);
            frm.ShowDialog();
            PopulateShift();
            selectedRow = -1;
            tableModel1.Selections.Clear();
        }

        private void btnEditShiftOver_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Edit_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Edit_Title");
                //MessageBox.Show("Bạn chưa chọn ca cần sửa!", "Sửa ca", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmShift shift = new frmShift();
                shift.DsShiftOverTime = dsShiftOver;
                shift.CurrentShift = selectedRow;
                shift.ShowDialog();
                PopulateShift();
            }
            selectedRow = -1;
            tableModel1.Selections.Clear();

        }

        private void btnDeleteShiftOver_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //MessageBox.Show("Bạn chưa chọn ca cần xóa!", "Xóa ca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string str = WorkingContext.LangManager.GetString("frmListShift_Del_Messa1");
                string str1 = WorkingContext.LangManager.GetString("frmListShift_Del_Title");
                //confirm lại có chắc chắn muốn xóa ca làm việc này ko?
                DialogResult dr = MessageBox.Show(str, str1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DeleteShiftOver();
                    PopulateShift();
                }
            }
            selectedRow = -1;
            tableModel1.Selections.Clear();
        }

        //private void lvwShiftOver_SelectionChanged(object sender, SelectionEventArgs e)
        //{
        //    if (e.NewSelectedIndicies.Length > 0)
        //    {
        //        selectedRow = (int)lvwShiftOver.TableModel.Rows[e.NewSelectedIndicies[0]].Tag;
        //    }
        //}

        //private void lvwShiftOver_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left && e.Clicks == 2)
        //    {
        //        if (lvwShiftOver.SelectedIndicies.Length > 0)
        //        {
        //            frmShift shift = new frmShift();
        //            shift.DsShiftOverTime = dsShiftOver;
        //            shift.CurrentShift = selectedRow;
        //            shift.ShowDialog();
        //            PopulateShift();
        //        }
        //        selectedRow = -1;
        //        tableModel1.Selections.Clear();
        //    }
        //}
    }
}
