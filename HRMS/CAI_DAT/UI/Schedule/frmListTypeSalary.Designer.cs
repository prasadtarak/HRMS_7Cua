namespace EVSoft.HRMS.UI.Schedule
{
    partial class frmListTypeSalarys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblTypeSalary = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.T = new XPTable.Models.TextColumn();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.textColumn3 = new XPTable.Models.TextColumn();
            this.textColumn4 = new XPTable.Models.TextColumn();
            this.SalaryID = new XPTable.Models.TextColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.STT = new XPTable.Models.TextColumn();
            this.Descript = new XPTable.Models.TextColumn();
            this.ContractName = new XPTable.Models.TextColumn();
            this.SalaryBasic = new XPTable.Models.NumberColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypeSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 577);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(626, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(549, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(473, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(396, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblTypeSalary);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kiểu lương";
            // 
            // tblTypeSalary
            // 
            this.tblTypeSalary.AlternatingRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.tblTypeSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tblTypeSalary.ColumnModel = this.columnModel1;
            this.tblTypeSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTypeSalary.EnableToolTips = true;
            this.tblTypeSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.tblTypeSalary.FullRowSelect = true;
            this.tblTypeSalary.GridColor = System.Drawing.SystemColors.ControlDark;
            this.tblTypeSalary.GridLines = XPTable.Models.GridLines.Both;
            this.tblTypeSalary.GridLineStyle = XPTable.Models.GridLineStyle.Dot;
            this.tblTypeSalary.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tblTypeSalary.Location = new System.Drawing.Point(3, 16);
            this.tblTypeSalary.Name = "tblTypeSalary";
            this.tblTypeSalary.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.tblTypeSalary.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.tblTypeSalary.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblTypeSalary.Size = new System.Drawing.Size(695, 558);
            this.tblTypeSalary.SortedColumnBackColor = System.Drawing.Color.Transparent;
            this.tblTypeSalary.TabIndex = 80;
            this.tblTypeSalary.TableModel = this.tableModel1;
            this.tblTypeSalary.UnfocusedSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.tblTypeSalary.UnfocusedSelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(121)))));
            this.tblTypeSalary.DoubleClick += new System.EventHandler(this.tblTypeSalary_DoubleClick);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.T,
            this.textColumn1,
            this.textColumn2,
            this.textColumn3,
            this.textColumn4,
            this.SalaryID});
            // 
            // T
            // 
            this.T.Editable = false;
            this.T.Text = "STT";
            // 
            // textColumn1
            // 
            this.textColumn1.Editable = false;
            this.textColumn1.Text = "Tên kiểu lương";
            this.textColumn1.Width = 100;
            // 
            // textColumn2
            // 
            this.textColumn2.Editable = false;
            this.textColumn2.Text = "Mô tả";
            this.textColumn2.Width = 100;
            // 
            // textColumn3
            // 
            this.textColumn3.Editable = false;
            this.textColumn3.Text = "Hợp đồng";
            this.textColumn3.Width = 100;
            // 
            // textColumn4
            // 
            this.textColumn4.Editable = false;
            this.textColumn4.Text = "Lương cơ bản";
            // 
            // SalaryID
            // 
            this.SalaryID.Visible = false;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // Descript
            // 
            this.Descript.Text = "Mô tả";
            // 
            // ContractName
            // 
            this.ContractName.Text = "Đối tượng";
            // 
            // SalaryBasic
            // 
            this.SalaryBasic.Text = "Lương cơ bản";
            // 
            // frmListTypeSalarys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 577);
            this.Controls.Add(this.panel1);
            this.Name = "frmListTypeSalarys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách kiểu lương cố định";
            this.Load += new System.EventHandler(this.frmListTypeSalarys_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTypeSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private XPTable.Models.TextColumn STT;
        private XPTable.Models.TableModel tableModel1;
        private System.Windows.Forms.Button btnAdd;
          private XPTable.Models.TextColumn Descript;
        private XPTable.Models.TextColumn ContractName;
        private XPTable.Models.NumberColumn SalaryBasic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TextColumn T;
        private XPTable.Models.TextColumn textColumn1;
        private XPTable.Models.TextColumn textColumn2;
        private XPTable.Models.TextColumn textColumn3;
        private System.Windows.Forms.Button button1;
        private XPTable.Models.Table tblTypeSalary;
        private XPTable.Models.TextColumn SalaryID;
        private XPTable.Models.TextColumn textColumn4;
    }
}