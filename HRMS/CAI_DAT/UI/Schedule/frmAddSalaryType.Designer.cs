namespace EVSoft.HRMS.UI.Schedule
{
    partial class frmAddSalaryType
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboContract = new MTGCComboBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtbasicsalary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboContract);
            this.groupBox1.Controls.Add(this.lblContract);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 47);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 92);
            this.txtDescription.TabIndex = 51;
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Location = new System.Drawing.Point(106, 172);
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(240, 20);
            this.txtbasicsalary.TabIndex = 50;
            this.txtbasicsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbasicsalary_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Lương cơ bản";
            // 
            // cboContract
            // 
            this.cboContract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboContract.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cboContract.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboContract.ColumnNum = 2;
            this.cboContract.ColumnWidth = "0;220";
            this.cboContract.DisplayMember = "Text";
            this.cboContract.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboContract.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cboContract.DropDownForeColor = System.Drawing.Color.Black;
            this.cboContract.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList;
            this.cboContract.DropDownWidth = 120;
            this.cboContract.GridLineColor = System.Drawing.Color.LightGray;
            this.cboContract.GridLineHorizontal = true;
            this.cboContract.GridLineVertical = false;
            this.cboContract.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cboContract.Location = new System.Drawing.Point(107, 145);
            this.cboContract.ManagingFastMouseMoving = true;
            this.cboContract.ManagingFastMouseMovingInterval = 30;
            this.cboContract.Name = "cboContract";
            this.cboContract.Size = new System.Drawing.Size(159, 21);
            this.cboContract.TabIndex = 48;
            // 
            // lblContract
            // 
            this.lblContract.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblContract.Location = new System.Drawing.Point(9, 142);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(86, 24);
            this.lblContract.TabIndex = 47;
            this.lblContract.Text = "Hợp đồng";
            this.lblContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kiểu lương";
            // 
            // frmAddSalaryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 239);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddSalaryType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sửa kiểu lương";
            this.Load += new System.EventHandler(this.frmAddSalaryType_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private MTGCComboBox cboContract;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
    }
}