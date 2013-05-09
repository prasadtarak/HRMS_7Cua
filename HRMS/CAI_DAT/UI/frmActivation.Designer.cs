namespace EVSoft.HRMS.UI
{
    partial class frmActivation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.serialBox2 = new EVSoft.HRMSLicense.SerialBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialBox1 = new EVSoft.HRMSLicense.SerialBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTrial = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(351, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // serialBox2
            // 
            this.serialBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.serialBox2.Location = new System.Drawing.Point(10, 19);
            this.serialBox2.Name = "serialBox2";
            this.serialBox2.Size = new System.Drawing.Size(399, 24);
            this.serialBox2.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(274, 146);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serialBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registry key";
            // 
            // serialBox1
            // 
            this.serialBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.serialBox1.Location = new System.Drawing.Point(10, 19);
            this.serialBox1.Name = "serialBox1";
            this.serialBox1.ReadOnly = true;
            this.serialBox1.Size = new System.Drawing.Size(399, 24);
            this.serialBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Install key";
            // 
            // btnTrial
            // 
            this.btnTrial.Location = new System.Drawing.Point(12, 146);
            this.btnTrial.Name = "btnTrial";
            this.btnTrial.Size = new System.Drawing.Size(79, 23);
            this.btnTrial.TabIndex = 3;
            this.btnTrial.Text = "Trial Version";
            this.btnTrial.UseVisualStyleBackColor = true;
            this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click);
            // 
            // frmActivation
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 182);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrial);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivation";
            this.ShowIcon = false;
            this.Text = "Activation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private EVSoft.HRMSLicense.SerialBox serialBox2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private EVSoft.HRMSLicense.SerialBox serialBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTrial;
    }
}