namespace prgPMR
{
    partial class UpdateUserInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeading = new Panel();
            label3 = new Label();
            dtpDOB = new DateTimePicker();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            pnlHeading.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.Gainsboro;
            pnlHeading.Controls.Add(label3);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1200, 25);
            pnlHeading.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "User Information";
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(166, 214);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(100, 23);
            dtpDOB.TabIndex = 30;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(166, 174);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(475, 23);
            txtFirstname.TabIndex = 29;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(166, 132);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(475, 23);
            txtLastname.TabIndex = 27;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 171);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 26;
            label7.Text = "First Name:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 214);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 25;
            label4.Text = "Date of Birth:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 88);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 23;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 129);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 22;
            label1.Text = "Last Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(166, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(475, 23);
            txtUsername.TabIndex = 31;
            // 
            // UpdateUserInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtUsername);
            Controls.Add(pnlHeading);
            Controls.Add(dtpDOB);
            Controls.Add(txtFirstname);
            Controls.Add(txtLastname);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateUserInfoControl";
            Size = new Size(1200, 548);
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeading;
        private Label label3;
        private DateTimePicker dtpDoseDate;
        private TextBox txtRXNum;
        private ComboBox cboVaccineName;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private DateTimePicker dtpDOB;
    }
}
