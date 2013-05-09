namespace EVSoft.HRMS.UI.Schedule
{
    partial class frmRestDay
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
            this.tableDayRest = new XPTable.Models.TableModel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DayIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.GroupBox();
            this.checkBoxSunDay = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.CheckBoxMonday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableRestDay = new XPTable.Models.Table();
            this.columnDayRest = new XPTable.Models.ColumnModel();
            this.dateTimeColumn1 = new XPTable.Models.DateTimeColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.DayRest = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.G.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRestDay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.DayIndex);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.G);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(395, 444);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cập Nhật";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Bỏ qua";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(567, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // DayIndex
            // 
            this.DayIndex.Location = new System.Drawing.Point(99, 151);
            this.DayIndex.Name = "DayIndex";
            this.DayIndex.Size = new System.Drawing.Size(200, 20);
            this.DayIndex.TabIndex = 6;
            this.DayIndex.Text = "1";
            this.DayIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hệ số làm thêm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DayRest);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày tháng trong năm";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 49);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(276, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày tháng";
            // 
            // G
            // 
            this.G.Controls.Add(this.checkBoxSunDay);
            this.G.Controls.Add(this.checkBoxThursday);
            this.G.Controls.Add(this.checkBoxFriday);
            this.G.Controls.Add(this.checkBoxSaturday);
            this.G.Controls.Add(this.checkBoxWednesday);
            this.G.Controls.Add(this.checkBoxTuesday);
            this.G.Controls.Add(this.CheckBoxMonday);
            this.G.Location = new System.Drawing.Point(3, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(649, 49);
            this.G.TabIndex = 1;
            this.G.TabStop = false;
            this.G.Text = "Chọn ngày trong tuần";
            // 
            // checkBoxSunDay
            // 
            this.checkBoxSunDay.AutoSize = true;
            this.checkBoxSunDay.Location = new System.Drawing.Point(557, 19);
            this.checkBoxSunDay.Name = "checkBoxSunDay";
            this.checkBoxSunDay.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSunDay.TabIndex = 6;
            this.checkBoxSunDay.Text = "Chủ Nhật";
            this.checkBoxSunDay.UseVisualStyleBackColor = true;
            this.checkBoxSunDay.CheckedChanged += new System.EventHandler(this.checkBoxSunDay_CheckedChanged);
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(287, 19);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxThursday.TabIndex = 5;
            this.checkBoxThursday.Text = "Thứ 5";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.CheckedChanged += new System.EventHandler(this.checkBoxThursday_CheckedChanged);
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(390, 19);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxFriday.TabIndex = 4;
            this.checkBoxFriday.Text = "Thứ 6";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            this.checkBoxFriday.CheckedChanged += new System.EventHandler(this.checkBoxFriday_CheckedChanged);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(477, 19);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxSaturday.TabIndex = 3;
            this.checkBoxSaturday.Text = "Thứ 7";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.CheckedChanged += new System.EventHandler(this.checkBoxSaturday_CheckedChanged);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(191, 19);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxWednesday.TabIndex = 2;
            this.checkBoxWednesday.Text = "Thứ 4";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            this.checkBoxWednesday.CheckedChanged += new System.EventHandler(this.checkBoxWednesday_CheckedChanged);
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(100, 19);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTuesday.TabIndex = 1;
            this.checkBoxTuesday.Text = "Thứ 3";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.CheckedChanged += new System.EventHandler(this.checkBoxTuesday_CheckedChanged);
            // 
            // CheckBoxMonday
            // 
            this.CheckBoxMonday.AutoSize = true;
            this.CheckBoxMonday.Location = new System.Drawing.Point(20, 19);
            this.CheckBoxMonday.Name = "CheckBoxMonday";
            this.CheckBoxMonday.Size = new System.Drawing.Size(54, 17);
            this.CheckBoxMonday.TabIndex = 0;
            this.CheckBoxMonday.Text = "Thứ 2";
            this.CheckBoxMonday.UseVisualStyleBackColor = true;
            this.CheckBoxMonday.CheckedChanged += new System.EventHandler(this.CheckBoxMonday_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableRestDay);
            this.groupBox1.Location = new System.Drawing.Point(3, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableRestDay
            // 
            this.tableRestDay.ColumnModel = this.columnDayRest;
            this.tableRestDay.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableRestDay.Location = new System.Drawing.Point(6, 19);
            this.tableRestDay.Name = "tableRestDay";
            this.tableRestDay.Size = new System.Drawing.Size(637, 238);
            this.tableRestDay.TabIndex = 1;
            this.tableRestDay.TableModel = this.tableDayRest;
            this.tableRestDay.Text = "table1";
            // 
            // columnDayRest
            // 
            this.columnDayRest.Columns.AddRange(new XPTable.Models.Column[] {
            this.dateTimeColumn1,
            this.textColumn2,
            this.textColumn1});
            // 
            // dateTimeColumn1
            // 
            this.dateTimeColumn1.CustomDateTimeFormat = "dd/MM/yyyy ";
            this.dateTimeColumn1.DateTimeFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeColumn1.Text = "Ngày";
            this.dateTimeColumn1.Width = 100;
            // 
            // textColumn2
            // 
            this.textColumn2.Text = "Hệ số làm thêm";
            this.textColumn2.Width = 150;
            // 
            // textColumn1
            // 
            this.textColumn1.Text = "Mô tả";
            this.textColumn1.Width = 200;
            // 
            // DayRest
            // 
            this.DayRest.CustomFormat = "dd/MM/yyyy";
            this.DayRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DayRest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DayRest.Location = new System.Drawing.Point(94, 22);
            this.DayRest.Name = "DayRest";
            this.DayRest.Size = new System.Drawing.Size(120, 20);
            this.DayRest.TabIndex = 15;
            // 
            // frmRestDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 476);
            this.Controls.Add(this.panel1);
            this.Name = "frmRestDay";
            this.Text = "Đăng ký hệ số ngày làm thêm";
            this.Load += new System.EventHandler(this.frmRestDay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.G.ResumeLayout(false);
            this.G.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableRestDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XPTable.Models.TableModel tableDayRest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private XPTable.Models.Table tableRestDay;
        private XPTable.Models.ColumnModel columnDayRest;
        private System.Windows.Forms.GroupBox G;
        private System.Windows.Forms.CheckBox checkBoxSunDay;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox CheckBoxMonday;
        private XPTable.Models.DateTimeColumn dateTimeColumn1;
        private XPTable.Models.TextColumn textColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DayIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private XPTable.Models.TextColumn textColumn2;
        private System.Windows.Forms.DateTimePicker DayRest;
    }
}