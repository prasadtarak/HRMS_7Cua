using System;
using System.Collections;
using System.Data;
using System.Net;
using System.Windows.Forms;
using EVsoft.HRMS.Common;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI
{
    /// <summary>
    /// Summary description for FrmSendMail.
    /// </summary>
    public class FrmSendMail : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TreeView treeViewEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtThongBao;
        private System.Windows.Forms.GroupBox groupBox3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///
        DepartmentDO DepartMent = new DepartmentDO();
        EmployeeDO Employ = new EmployeeDO();
        AdminDO AdDO = new AdminDO();
        private System.Windows.Forms.TreeView treeViewIndex;
        private System.Windows.Forms.Button button1;
        private DateTimePicker dtpSendDate;
        private Label lblFromDate;
        private System.ComponentModel.Container components = null;

        public FrmSendMail()
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeViewIndex = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtThongBao = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.treeViewEmail = new System.Windows.Forms.TreeView();
            this.dtpSendDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.treeViewEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 593);
            this.panel1.TabIndex = 0;
            //
            // groupBox3
            //
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblFromDate);
            this.groupBox3.Controls.Add(this.dtpSendDate);
            this.groupBox3.Controls.Add(this.treeViewIndex);
            this.groupBox3.Location = new System.Drawing.Point(334, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lựa chọn thông tin gửi";
            //
            // treeViewIndex
            //
            this.treeViewIndex.Location = new System.Drawing.Point(176, 19);
            this.treeViewIndex.Name = "treeViewIndex";
            this.treeViewIndex.Size = new System.Drawing.Size(121, 38);
            this.treeViewIndex.TabIndex = 3;
            this.treeViewIndex.Visible = false;
            //
            // groupBox2
            //
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtxtThongBao);
            this.groupBox2.Location = new System.Drawing.Point(331, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 454);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông báo";
            //
            // rtxtThongBao
            //
            this.rtxtThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtThongBao.Location = new System.Drawing.Point(8, 20);
            this.rtxtThongBao.Name = "rtxtThongBao";
            this.rtxtThongBao.Size = new System.Drawing.Size(306, 423);
            this.rtxtThongBao.TabIndex = 0;
            this.rtxtThongBao.Text = "";
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            //
            // button1
            //
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(539, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // btnSend
            //
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(421, 18);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 32);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Gửi Mail";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            //
            // treeViewEmail
            //
            this.treeViewEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewEmail.CheckBoxes = true;
            this.treeViewEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeViewEmail.Location = new System.Drawing.Point(8, 8);
            this.treeViewEmail.Name = "treeViewEmail";
            this.treeViewEmail.Size = new System.Drawing.Size(320, 523);
            this.treeViewEmail.TabIndex = 0;
            this.treeViewEmail.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmail_AfterCheck);
            this.treeViewEmail.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmail_AfterSelect);
            //
            // dtpSendDate
            //
            this.dtpSendDate.CustomFormat = "MM/yyyy";
            this.dtpSendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSendDate.Location = new System.Drawing.Point(81, 26);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.ShowUpDown = true;
            this.dtpSendDate.Size = new System.Drawing.Size(68, 20);
            this.dtpSendDate.TabIndex = 0;
            //
            // lblFromDate
            //
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFromDate.Location = new System.Drawing.Point(6, 26);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(69, 21);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "Chọn tháng :";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FrmSendMail
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(663, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSendMail";
            this.Text = "Gửi Email";
            this.Load += new System.EventHandler(this.FrmSendMail_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion Windows Form Designer generated code

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            int Ksend = 0;
            int Knotsen = 0;
            ArrayList Arr = new ArrayList();
            string From = SystemProcess.Email;
            if (From == "")
            {
                MessageBox.Show("Vui lòng đăng ký Email của bạn", "Thông báo");
                return;
            }
            string listSendError = string.Empty;
            foreach (TreeNode node in treeViewEmail.Nodes)
            {
                int indexDepart = node.Index;

                int DepartMentId = Convert.ToInt16(treeViewIndex.Nodes[indexDepart].Text);
                foreach (TreeNode nodeEmploy in node.Nodes)
                {
                    if (nodeEmploy.Checked)
                    {
                        int Index = nodeEmploy.Index;
                        int EmployID = Convert.ToInt16(treeViewIndex.Nodes[indexDepart].Nodes[Index].Text);

                        int Id = nodeEmploy.Text.IndexOf('(');
                        string To = nodeEmploy.Text.Substring(Id + 1, nodeEmploy.Text.Length - Id - 2);
                        string Name = nodeEmploy.Text.Substring(0, Id);
                        if (To != "Chưa đăng ký email")
                        {
                            Ksend += 1;
                            string body = GetBody(DepartMentId, EmployID, 1);

                            bool result = SendMail(From, To, "Theo dõi nhân viên trong tháng", body);
                            if (!result)
                            {
                                if (listSendError == string.Empty)
                                    listSendError = To;
                                else
                                    listSendError += "\n" + To;
                            }
                            //							check = true;
                        }
                        else
                        {
                            Knotsen += 1;
                            Arr.Add(Name);
                        }
                    }
                }
            }

            if (Arr.Count > 0)
            {
                string msg = "";
                for (int i = 0; i < Arr.Count; i++)
                {
                    msg += Arr[i].ToString() + "\n";
                }
                msg += "Chưa đăng ký email";
                MessageBox.Show(msg, "Thông báo");
            }
            if (Ksend > 0)
            {
                if (listSendError != string.Empty)
                    MessageBox.Show("Gửi email thành công !\nKhông thể gửi mail đến các địa chỉ sau: \n" + listSendError);
                else
                    MessageBox.Show("Gửi email thành công !");
            }
            else
            {
                if (Arr.Count == 0)
                    MessageBox.Show("Bạn chưa chọn người gửi email ", "Thông báo");
            }
        }

        private string GetBody(int DepartId, int EmployId, int Option)
        {
            DateTime currentDate = dtpSendDate.Value;
            //Neu thang duoc chon truoc thang hien tai ==> lay den ngay cuoi cung trong thang do
            if (dtpSendDate.Value.Month != DateTime.Now.Month || dtpSendDate.Value.Year != DateTime.Now.Year)
            {
                //Ngay dau tien cua thang sau thang duoc chon
                currentDate = new DateTime(currentDate.Year, currentDate.Month + 1, 1);
                //Ngay cuoi cung cua thang duoc chon
                currentDate = currentDate.AddDays(-1);
            }
            string Result = "";

            Result = "                                 Bảng chấm công tháng " + currentDate.Month + " năm " + currentDate.Year;
            Result += "\n";
            Result += rtxtThongBao.Text;
            Result += "\n";
            Result += "----------------------------------------------------------------------------------------------------------------\n";
            Result += "| Thoi gian        |   Lam viec       |      Vang mat        | Cong tac         |  Ghi chu                      |\n";
            Result += "----------------------------------------------------------------------------------------------------------------\n";
            Result += "| Ngay  | Thu      | Gio den | Gio ve | Co phep | Khong ly do| Noi den | Noi o  |                               |\n";
            Result += "----------------------------------------------------------------------------------------------------------------- \n";
            //DataSet DsDepartMent = DepartMent.GetAttendRecord(DepartId, currentDate);
            DataSet DsDepartMent = DepartMent.GetAttendRecordByEmployee(EmployId, currentDate);

            if (DsDepartMent != null)
            {
                if (DsDepartMent.Tables.Count > 0)
                {
                    foreach (DataRow r in DsDepartMent.Tables[0].Rows)
                    {
                        if (r["EmployeeID"].ToString() == EmployId.ToString())
                        {
                            string DayofWeek = Convert.ToDateTime(r["DateWorkingDay"]).DayOfWeek.ToString();
                            DayofWeek = DayofWeek.Substring(0, 3);
                            string WorkInFo = r["WorkInfo"].ToString();
                            if (WorkInFo.Length > 30)
                                WorkInFo.Substring(0, 30);
                            int Dateday = Convert.ToInt16(r["DateDay"]);
                            string Rest = "";
                            string absent = "";
                            string LeaveaLocation = "";
                            string mission = "";
                            string timein = "";
                            string timeout = "";
                            string note = "";
                            if (r["Status"] != null)
                            {
                                string Status = r["Status"].ToString();
                                string IsWorkingday = r["IsWorkingDay"].ToString();

                                if (Convert.ToInt16(r["Status"]) == 3)
                                    Rest = "X";
                                if (Convert.ToInt16(r["Status"]) == 4 && Dateday <= DateTime.Now.Day)
                                {
                                    if (IsWorkingday == "")
                                        absent = "";
                                    else
                                    {
                                        if (DayofWeek == "Sun")
                                            absent = "";
                                        else
                                            absent = "X";
                                    }
                                }
                            }
                            if (r["LeaveLocation"] != null)
                                LeaveaLocation = r["LeaveLocation"].ToString();
                            if (LeaveaLocation.Length > 8)
                                LeaveaLocation = LeaveaLocation.Substring(0, 8);
                            if (r["TimeIn"] != null && r["TimeOut"] != null && r["DateDay"] != null && Dateday <= currentDate.Day)
                            {
                                if (r["LateShift"] != DBNull.Value)
                                    if (Convert.ToBoolean(r["LateShift"]))
                                        note = "Đăng ký làm muộn từ: " +
                                           Convert.ToDateTime(r["CheckIn"]).ToShortTimeString();
                                if (r["TimeOut"] is DateTime)
                                    timeout = Convert.ToDateTime(r["TimeOut"]).ToShortTimeString();
                                if (r["TimeIn"] is DateTime)
                                    timein = Convert.ToDateTime(r["TimeIn"]).ToShortTimeString();
                                Result += "\n" + "|" + " " + GetString(r["DateDay"].ToString(), 6 - r["DateDay"].ToString().Length);
                                Result += "| " + GetString(DayofWeek, 9 - DayofWeek.Length);
                                Result += "| " + GetString(timein, 8 - timein.Length);
                                Result += "| " + GetString(timeout, 7 - timeout.Length);
                                Result += "| " + GetString(Rest, 8 - Rest.Length);
                                Result += "| " + GetString(absent, 11 - absent.Length);
                                Result += "| " + GetString(LeaveaLocation, 8 - LeaveaLocation.Length);
                                Result += "| " + GetString(mission, 7 - mission.Length);
                                Result += "| " + GetString(WorkInFo, 30 - WorkInFo.Length);
                                Result += "| " + GetString(note, 50 - note.Length) + "|";
                            }
                        }
                    }
                }
            }
            Result += "\n";
            Result += "\n";
            Result += "\n";
            Result += "Thông tin được gửi bởi " + SystemProcess.UserName + " từ chương trình quản lý nhân sự";
            return Result;
        }

        private string GetString(string InPut, int NumberSpace)
        {
            for (int i = 0; i < NumberSpace; i++)
            {
                InPut += " ";
            }
            return InPut;
        }

        private bool SendMail(string From, string To, string Subject, string body)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(To);
            string SmptServer = AdDO.GetSysVarByNam("MailServer");
            string Pass = AdDO.GetSysVarByNam("PassMail");
            string User = AdDO.GetSysVarByNam("UserMail");
            message.From = new System.Net.Mail.MailAddress(From);
            message.Subject = Subject;
            message.Body = body;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            //message.IsBodyHtml = false;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(SmptServer, 25);

            smtp.Credentials = new NetworkCredential(User, Pass);

            try
            {
                //System.Web.Mail.SmtpMail.SmtpServer = "www.evsoft.com.vn";
                smtp.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void FrmSendMail_Load(object sender, System.EventArgs e)
        {
            dtpSendDate.Value = DateTime.Now;
            Init();
        }

        private void Init()
        {
            DataSet dsDepartMent = DepartMent.GetDepartments();
            if (dsDepartMent.Tables.Count > 0)
            {
                foreach (DataRow r in dsDepartMent.Tables[0].Rows)
                {
                    int ID = Convert.ToInt16(r["DepartmentID"]);
                    TreeNode NodeDepart = treeViewEmail.Nodes.Add(r["Description"].ToString());
                    TreeNode NodeDePartHide = treeViewIndex.Nodes.Add(r["DepartmentID"].ToString());
                    DataSet Emp = Employ.GetEmployeeByDepartment(ID);
                    foreach (DataRow RowEmploy in Emp.Tables[0].Rows)
                    {
                        string temp = "";
                        if (RowEmploy["Email"].ToString() != "")
                            temp = RowEmploy["EmployeeName"].ToString() + "(" + RowEmploy["Email"].ToString() + ")";
                        else
                            temp = RowEmploy["EmployeeName"].ToString() + "(" + "Chưa đăng ký email" + ")";
                        NodeDePartHide.Nodes.Add(RowEmploy["EmployeeID"].ToString());
                        TreeNode NodeEmploy = NodeDepart.Nodes.Add(temp);
                    }
                }
            }
        }

        private void rtxtThongBao_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void treeViewEmail_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
        }

        private void treeViewEmail_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Checked)
                {
                    foreach (TreeNode tr in e.Node.Nodes)
                    {
                        tr.Checked = true;
                    }
                }
                else
                {
                    foreach (TreeNode tr in e.Node.Nodes)
                    {
                        tr.Checked = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}