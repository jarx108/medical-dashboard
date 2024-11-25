namespace prgPMR
{
    partial class SurgeriesDetailControl
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
            cboSurgeryCenter = new ComboBox();
            label3 = new Label();
            cboSurgeon = new ComboBox();
            dtpDateSurgery = new DateTimePicker();
            cboMedicalCondition = new ComboBox();
            rtxtNotes = new RichTextBox();
            btnImage = new Button();
            btnPDFFile = new Button();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pnlHeading = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblSurgeonSpeciality = new Label();
            label12 = new Label();
            label13 = new Label();
            lblSugeonLocation = new Label();
            lblSugeonPhone = new Label();
            lblSugeryCenterPhone = new Label();
            label16 = new Label();
            lblSugeryCenterLocation = new Label();
            label18 = new Label();
            pnlHeading.SuspendLayout();
            SuspendLayout();
            // 
            // cboSurgeryCenter
            // 
            cboSurgeryCenter.FormattingEnabled = true;
            cboSurgeryCenter.Location = new Point(171, 250);
            cboSurgeryCenter.Name = "cboSurgeryCenter";
            cboSurgeryCenter.Size = new Size(300, 23);
            cboSurgeryCenter.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(235, 21);
            label3.TabIndex = 2;
            label3.Text = "Detailed Surgery Information";
            // 
            // cboSurgeon
            // 
            cboSurgeon.FormattingEnabled = true;
            cboSurgeon.Location = new Point(169, 135);
            cboSurgeon.Name = "cboSurgeon";
            cboSurgeon.Size = new Size(300, 23);
            cboSurgeon.TabIndex = 43;
            // 
            // dtpDateSurgery
            // 
            dtpDateSurgery.Format = DateTimePickerFormat.Short;
            dtpDateSurgery.Location = new Point(169, 55);
            dtpDateSurgery.Name = "dtpDateSurgery";
            dtpDateSurgery.Size = new Size(100, 23);
            dtpDateSurgery.TabIndex = 42;
            // 
            // cboMedicalCondition
            // 
            cboMedicalCondition.FormattingEnabled = true;
            cboMedicalCondition.Location = new Point(169, 95);
            cboMedicalCondition.Name = "cboMedicalCondition";
            cboMedicalCondition.Size = new Size(475, 23);
            cboMedicalCondition.TabIndex = 38;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(712, 93);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(464, 387);
            rtxtNotes.TabIndex = 36;
            rtxtNotes.Text = "";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(858, 495);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(120, 40);
            btnImage.TabIndex = 35;
            btnImage.Text = "Attach Image File";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnPDFFile
            // 
            btnPDFFile.Location = new Point(712, 495);
            btnPDFFile.Name = "btnPDFFile";
            btnPDFFile.Size = new Size(120, 40);
            btnPDFFile.TabIndex = 34;
            btnPDFFile.Text = "Attach PDF File";
            btnPDFFile.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(712, 69);
            label10.Name = "label10";
            label10.Size = new Size(54, 21);
            label10.TabIndex = 33;
            label10.Text = "Notes:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 247);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 29;
            label6.Text = "Surgery Center:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(171, 161);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 28;
            label5.Text = "Specialty:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 27;
            label4.Text = "Surgeon:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.Gainsboro;
            pnlHeading.Controls.Add(label3);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1200, 25);
            pnlHeading.TabIndex = 26;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 25;
            label2.Text = "Date of Surgery:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 95);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 24;
            label1.Text = "Medical Condition:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSurgeonSpeciality
            // 
            lblSurgeonSpeciality.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSurgeonSpeciality.Location = new Point(256, 161);
            lblSurgeonSpeciality.Name = "lblSurgeonSpeciality";
            lblSurgeonSpeciality.Size = new Size(400, 23);
            lblSurgeonSpeciality.TabIndex = 45;
            lblSurgeonSpeciality.Text = "unknown";
            lblSurgeonSpeciality.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(171, 184);
            label12.Name = "label12";
            label12.Size = new Size(90, 23);
            label12.TabIndex = 46;
            label12.Text = "Location:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(171, 207);
            label13.Name = "label13";
            label13.Size = new Size(90, 23);
            label13.TabIndex = 47;
            label13.Text = "Phone:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSugeonLocation
            // 
            lblSugeonLocation.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeonLocation.Location = new Point(256, 184);
            lblSugeonLocation.Name = "lblSugeonLocation";
            lblSugeonLocation.Size = new Size(400, 23);
            lblSugeonLocation.TabIndex = 48;
            lblSugeonLocation.Text = "unknown";
            lblSugeonLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSugeonPhone
            // 
            lblSugeonPhone.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeonPhone.Location = new Point(256, 207);
            lblSugeonPhone.Name = "lblSugeonPhone";
            lblSugeonPhone.Size = new Size(400, 23);
            lblSugeonPhone.TabIndex = 49;
            lblSugeonPhone.Text = "unknown";
            lblSugeonPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSugeryCenterPhone
            // 
            lblSugeryCenterPhone.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeryCenterPhone.Location = new Point(256, 295);
            lblSugeryCenterPhone.Name = "lblSugeryCenterPhone";
            lblSugeryCenterPhone.Size = new Size(400, 23);
            lblSugeryCenterPhone.TabIndex = 54;
            lblSugeryCenterPhone.Text = "unknown";
            lblSugeryCenterPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(171, 295);
            label16.Name = "label16";
            label16.Size = new Size(90, 23);
            label16.TabIndex = 52;
            label16.Text = "Phone:";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSugeryCenterLocation
            // 
            lblSugeryCenterLocation.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeryCenterLocation.Location = new Point(256, 272);
            lblSugeryCenterLocation.Name = "lblSugeryCenterLocation";
            lblSugeryCenterLocation.Size = new Size(400, 23);
            lblSugeryCenterLocation.TabIndex = 51;
            lblSugeryCenterLocation.Text = "unknown";
            lblSugeryCenterLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(171, 272);
            label18.Name = "label18";
            label18.Size = new Size(90, 23);
            label18.TabIndex = 50;
            label18.Text = "Location:";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SurgeriesDetailControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSugeryCenterPhone);
            Controls.Add(label16);
            Controls.Add(lblSugeryCenterLocation);
            Controls.Add(label18);
            Controls.Add(lblSugeonPhone);
            Controls.Add(lblSugeonLocation);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblSurgeonSpeciality);
            Controls.Add(cboSurgeryCenter);
            Controls.Add(cboSurgeon);
            Controls.Add(dtpDateSurgery);
            Controls.Add(cboMedicalCondition);
            Controls.Add(rtxtNotes);
            Controls.Add(btnImage);
            Controls.Add(btnPDFFile);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pnlHeading);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SurgeriesDetailControl";
            Size = new Size(1200, 548);
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSurgeryCenter;
        private Label label3;
        private ComboBox cboSurgeon;
        private DateTimePicker dtpDateSurgery;
        private ComboBox cboMedicalCondition;
        private RichTextBox rtxtNotes;
        private Button btnImage;
        private Button btnPDFFile;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel pnlHeading;
        private Label label2;
        private Label label1;
        private Label lblSurgeonSpeciality;
        private Label label12;
        private Label label13;
        private Label lblSugeonLocation;
        private Label lblSugeonPhone;
        private Label lblSugeryCenterPhone;
        private Label label16;
        private Label lblSugeryCenterLocation;
        private Label label18;
    }
}
