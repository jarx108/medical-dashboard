namespace prgPMR
{
    partial class ImmunizationDetailControl
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnPDFFile = new Button();
            btnImageFile = new Button();
            rtxtNotes = new RichTextBox();
            txtDetailedName = new TextBox();
            cboVaccineName = new ComboBox();
            txtRXNum = new TextBox();
            txtNDCNum = new TextBox();
            txtLotNum = new TextBox();
            dtpDoseDate = new DateTimePicker();
            cboManufacturer = new ComboBox();
            label11 = new Label();
            cboFacility = new ComboBox();
            pnlHeading.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 95);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Detailed Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 1;
            label2.Text = "Vaccine Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
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
            pnlHeading.BackColor = Color.Gainsboro;
            pnlHeading.Controls.Add(label3);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1200, 25);
            pnlHeading.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 4;
            label4.Text = "Vaccination Date:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 215);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 6;
            label6.Text = "Manufacturer:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 255);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 7;
            label7.Text = "RX Number:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 295);
            label8.Name = "label8";
            label8.Size = new Size(160, 23);
            label8.TabIndex = 8;
            label8.Text = "NDC Number:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 335);
            label9.Name = "label9";
            label9.Size = new Size(160, 23);
            label9.TabIndex = 9;
            label9.Text = "Lot Number:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(712, 55);
            label10.Name = "label10";
            label10.Size = new Size(54, 21);
            label10.TabIndex = 10;
            label10.Text = "Notes:";
            // 
            // btnPDFFile
            // 
            btnPDFFile.Location = new Point(843, 493);
            btnPDFFile.Name = "btnPDFFile";
            btnPDFFile.Size = new Size(120, 40);
            btnPDFFile.TabIndex = 11;
            btnPDFFile.Text = "Attach PDF File";
            btnPDFFile.UseVisualStyleBackColor = true;
            btnPDFFile.Click += btnPDFFile_Click;
            // 
            // btnImageFile
            // 
            btnImageFile.Location = new Point(969, 493);
            btnImageFile.Name = "btnImageFile";
            btnImageFile.Size = new Size(120, 40);
            btnImageFile.TabIndex = 12;
            btnImageFile.Text = "Attach Image File";
            btnImageFile.UseVisualStyleBackColor = true;
            btnImageFile.Click += btnImageFile_Click;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(712, 88);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(465, 390);
            rtxtNotes.TabIndex = 13;
            rtxtNotes.Text = "";
            // 
            // txtDetailedName
            // 
            txtDetailedName.Location = new Point(169, 95);
            txtDetailedName.Name = "txtDetailedName";
            txtDetailedName.Size = new Size(475, 23);
            txtDetailedName.TabIndex = 14;
            // 
            // cboVaccineName
            // 
            cboVaccineName.FormattingEnabled = true;
            cboVaccineName.Location = new Point(169, 55);
            cboVaccineName.Name = "cboVaccineName";
            cboVaccineName.Size = new Size(475, 23);
            cboVaccineName.TabIndex = 15;
            // 
            // txtRXNum
            // 
            txtRXNum.Location = new Point(169, 255);
            txtRXNum.Name = "txtRXNum";
            txtRXNum.Size = new Size(300, 23);
            txtRXNum.TabIndex = 17;
            // 
            // txtNDCNum
            // 
            txtNDCNum.Location = new Point(169, 295);
            txtNDCNum.Name = "txtNDCNum";
            txtNDCNum.Size = new Size(300, 23);
            txtNDCNum.TabIndex = 18;
            // 
            // txtLotNum
            // 
            txtLotNum.Location = new Point(169, 335);
            txtLotNum.Name = "txtLotNum";
            txtLotNum.Size = new Size(300, 23);
            txtLotNum.TabIndex = 19;
            // 
            // dtpDoseDate
            // 
            dtpDoseDate.Format = DateTimePickerFormat.Short;
            dtpDoseDate.Location = new Point(169, 135);
            dtpDoseDate.Name = "dtpDoseDate";
            dtpDoseDate.Size = new Size(100, 23);
            dtpDoseDate.TabIndex = 21;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Location = new Point(169, 215);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(300, 23);
            cboManufacturer.TabIndex = 23;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 175);
            label11.Name = "label11";
            label11.Size = new Size(160, 23);
            label11.TabIndex = 25;
            label11.Text = "Facility:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboFacility
            // 
            cboFacility.FormattingEnabled = true;
            cboFacility.Location = new Point(169, 175);
            cboFacility.Name = "cboFacility";
            cboFacility.Size = new Size(300, 23);
            cboFacility.TabIndex = 26;
            // 
            // ImmunizationDetailControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboFacility);
            Controls.Add(label11);
            Controls.Add(cboManufacturer);
            Controls.Add(dtpDoseDate);
            Controls.Add(txtLotNum);
            Controls.Add(txtNDCNum);
            Controls.Add(txtRXNum);
            Controls.Add(cboVaccineName);
            Controls.Add(txtDetailedName);
            Controls.Add(rtxtNotes);
            Controls.Add(btnImageFile);
            Controls.Add(btnPDFFile);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pnlHeading);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ImmunizationDetailControl";
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
        private Button btnImageFile;
        private RichTextBox rtxtNotes;
        private TextBox txtDetailedName;
        private ComboBox cboVaccineName;
        private TextBox txtRXNum;
        private TextBox txtNDCNum;
        private TextBox txtLotNum;
        private DateTimePicker dtpDoseDate;
        private ComboBox cboGivenBy;
        private ComboBox cboManufacturer;
        private Label label11;
        private ComboBox cboFacility;
    }
}
