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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 127);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 0;
            label1.Text = "Complete Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 1;
            label2.Text = "General Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(348, 28);
            label3.TabIndex = 2;
            label3.Text = "Detailed Immunization Information";
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.Gainsboro;
            pnlHeading.Controls.Add(label3);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Margin = new Padding(3, 4, 3, 4);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1371, 33);
            pnlHeading.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(183, 31);
            label4.TabIndex = 4;
            label4.Text = "Date Given:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 233);
            label5.Name = "label5";
            label5.Size = new Size(183, 31);
            label5.TabIndex = 5;
            label5.Text = "Given By:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 287);
            label6.Name = "label6";
            label6.Size = new Size(183, 31);
            label6.TabIndex = 6;
            label6.Text = "Manufacturer:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 340);
            label7.Name = "label7";
            label7.Size = new Size(183, 31);
            label7.TabIndex = 7;
            label7.Text = "RX Number:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 393);
            label8.Name = "label8";
            label8.Size = new Size(183, 31);
            label8.TabIndex = 8;
            label8.Text = "NDC Number:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 447);
            label9.Name = "label9";
            label9.Size = new Size(183, 31);
            label9.TabIndex = 9;
            label9.Text = "Lot Number:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(814, 73);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 10;
            label10.Text = "Notes:";
            // 
            // btnPDFFile
            // 
            btnPDFFile.Location = new Point(814, 641);
            btnPDFFile.Margin = new Padding(3, 4, 3, 4);
            btnPDFFile.Name = "btnPDFFile";
            btnPDFFile.Size = new Size(137, 53);
            btnPDFFile.TabIndex = 11;
            btnPDFFile.Text = "Attach PDF File";
            btnPDFFile.UseVisualStyleBackColor = true;
            btnPDFFile.Click += btnPDFFile_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(981, 641);
            btnImage.Margin = new Padding(3, 4, 3, 4);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(137, 53);
            btnImage.TabIndex = 12;
            btnImage.Text = "Attach Image File";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(814, 105);
            rtxtNotes.Margin = new Padding(3, 4, 3, 4);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(530, 515);
            rtxtNotes.TabIndex = 13;
            rtxtNotes.Text = "";
            // 
            // txtCompleteName
            // 
            txtCompleteName.Location = new Point(193, 127);
            txtCompleteName.Margin = new Padding(3, 4, 3, 4);
            txtCompleteName.Name = "txtCompleteName";
            txtCompleteName.Size = new Size(542, 27);
            txtCompleteName.TabIndex = 14;
            // 
            // cboGeneralName
            // 
            cboGeneralName.FormattingEnabled = true;
            cboGeneralName.Location = new Point(193, 73);
            cboGeneralName.Margin = new Padding(3, 4, 3, 4);
            cboGeneralName.Name = "cboGeneralName";
            cboGeneralName.Size = new Size(542, 28);
            cboGeneralName.TabIndex = 15;
            cboGeneralName.SelectedIndexChanged += cboGeneralName_SelectedIndexChanged;
            // 
            // txtRXNum
            // 
            txtRXNum.Location = new Point(193, 340);
            txtRXNum.Margin = new Padding(3, 4, 3, 4);
            txtRXNum.Name = "txtRXNum";
            txtRXNum.Size = new Size(342, 27);
            txtRXNum.TabIndex = 17;
            // 
            // txtNDCNum
            // 
            txtNDCNum.Location = new Point(193, 393);
            txtNDCNum.Margin = new Padding(3, 4, 3, 4);
            txtNDCNum.Name = "txtNDCNum";
            txtNDCNum.Size = new Size(342, 27);
            txtNDCNum.TabIndex = 18;
            // 
            // txtLotNum
            // 
            txtLotNum.Location = new Point(193, 447);
            txtLotNum.Margin = new Padding(3, 4, 3, 4);
            txtLotNum.Name = "txtLotNum";
            txtLotNum.Size = new Size(342, 27);
            txtLotNum.TabIndex = 19;
            // 
            // dtpDateGiven
            // 
            dtpDateGiven.Format = DateTimePickerFormat.Short;
            dtpDateGiven.Location = new Point(193, 180);
            dtpDateGiven.Margin = new Padding(3, 4, 3, 4);
            dtpDateGiven.Name = "dtpDateGiven";
            dtpDateGiven.Size = new Size(114, 27);
            dtpDateGiven.TabIndex = 21;
            // 
            // cboGivenBy
            // 
            cboGivenBy.FormattingEnabled = true;
            cboGivenBy.Location = new Point(193, 233);
            cboGivenBy.Margin = new Padding(3, 4, 3, 4);
            cboGivenBy.Name = "cboGivenBy";
            cboGivenBy.Size = new Size(342, 28);
            cboGivenBy.TabIndex = 22;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Location = new Point(193, 287);
            cboManufacturer.Margin = new Padding(3, 4, 3, 4);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(342, 28);
            cboManufacturer.TabIndex = 23;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(1230, 657);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(58, 20);
            lblClass.TabIndex = 24;
            lblClass.Text = "label11";
            // 
            // VaccinesDetailControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "VaccinesDetailControl";
            Size = new Size(1371, 731);
            Load += VaccinesDetailControl_Load;
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
