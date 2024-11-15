namespace prgPMR
{
    partial class VaccinesDetailControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlHeading = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnPDFFile = new Button();
            btnImage = new Button();
            rtxtNotes = new RichTextBox();
            txtCompleteName = new TextBox();
            cboGeneralName = new ComboBox();
            txtRXNum = new TextBox();
            txtNDCNum = new TextBox();
            txtLotNum = new TextBox();
            dtpDateGiven = new DateTimePicker();
            cboGivenBy = new ComboBox();
            cboManufacturer = new ComboBox();
            lblClass = new Label();
            pnlHeading.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Complete Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 55);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 1;
            label2.Text = "General Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(283, 21);
            label3.TabIndex = 2;
            label3.Text = "Detailed Immunization Information";
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.Silver;
            pnlHeading.Controls.Add(label3);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1200, 25);
            pnlHeading.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 132);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 4;
            label4.Text = "Date Given:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 167);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 5;
            label5.Text = "Given By:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 206);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 6;
            label6.Text = "Manufacturer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 247);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 7;
            label7.Text = "RX Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 287);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 8;
            label8.Text = "NDC Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(64, 330);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 9;
            label9.Text = "Lot Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(712, 53);
            label10.Name = "label10";
            label10.Size = new Size(54, 21);
            label10.TabIndex = 10;
            label10.Text = "Notes:";
            // 
            // btnPDFFile
            // 
            btnPDFFile.Location = new Point(712, 481);
            btnPDFFile.Name = "btnPDFFile";
            btnPDFFile.Size = new Size(120, 39);
            btnPDFFile.TabIndex = 11;
            btnPDFFile.Text = "Attach PDF File";
            btnPDFFile.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(858, 481);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(120, 39);
            btnImage.TabIndex = 12;
            btnImage.Text = "Attach Image File";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(712, 77);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(464, 387);
            rtxtNotes.TabIndex = 13;
            rtxtNotes.Text = "";
            // 
            // txtCompleteName
            // 
            txtCompleteName.Location = new Point(167, 92);
            txtCompleteName.Name = "txtCompleteName";
            txtCompleteName.Size = new Size(475, 23);
            txtCompleteName.TabIndex = 14;
            // 
            // cboGeneralName
            // 
            cboGeneralName.FormattingEnabled = true;
            cboGeneralName.Location = new Point(167, 53);
            cboGeneralName.Name = "cboGeneralName";
            cboGeneralName.Size = new Size(475, 23);
            cboGeneralName.TabIndex = 15;
            // 
            // txtRXNum
            // 
            txtRXNum.Location = new Point(167, 247);
            txtRXNum.Name = "txtRXNum";
            txtRXNum.Size = new Size(300, 23);
            txtRXNum.TabIndex = 17;
            // 
            // txtNDCNum
            // 
            txtNDCNum.Location = new Point(167, 287);
            txtNDCNum.Name = "txtNDCNum";
            txtNDCNum.Size = new Size(300, 23);
            txtNDCNum.TabIndex = 18;
            // 
            // txtLotNum
            // 
            txtLotNum.Location = new Point(167, 330);
            txtLotNum.Name = "txtLotNum";
            txtLotNum.Size = new Size(300, 23);
            txtLotNum.TabIndex = 19;
            // 
            // dtpDateGiven
            // 
            dtpDateGiven.Format = DateTimePickerFormat.Short;
            dtpDateGiven.Location = new Point(167, 132);
            dtpDateGiven.Name = "dtpDateGiven";
            dtpDateGiven.Size = new Size(116, 23);
            dtpDateGiven.TabIndex = 21;
            // 
            // cboGivenBy
            // 
            cboGivenBy.FormattingEnabled = true;
            cboGivenBy.Location = new Point(167, 167);
            cboGivenBy.Name = "cboGivenBy";
            cboGivenBy.Size = new Size(300, 23);
            cboGivenBy.TabIndex = 22;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Location = new Point(167, 208);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(300, 23);
            cboManufacturer.TabIndex = 23;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(322, 394);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(44, 15);
            lblClass.TabIndex = 24;
            lblClass.Text = "label11";
            // 
            // VaccinesDetailControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblClass);
            Controls.Add(cboManufacturer);
            Controls.Add(cboGivenBy);
            Controls.Add(dtpDateGiven);
            Controls.Add(txtLotNum);
            Controls.Add(txtNDCNum);
            Controls.Add(txtRXNum);
            Controls.Add(cboGeneralName);
            Controls.Add(txtCompleteName);
            Controls.Add(rtxtNotes);
            Controls.Add(btnImage);
            Controls.Add(btnPDFFile);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pnlHeading);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VaccinesDetailControl";
            Size = new Size(1200, 548);
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlHeading;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnPDFFile;
        private Button btnImage;
        private RichTextBox rtxtNotes;
        private TextBox txtCompleteName;
        private ComboBox cboGeneralName;
        private TextBox txtRXNum;
        private TextBox txtNDCNum;
        private TextBox txtLotNum;
        private DateTimePicker dtpDateGiven;
        private ComboBox cboGivenBy;
        private ComboBox cboManufacturer;
        private Label lblClass;
    }
}
