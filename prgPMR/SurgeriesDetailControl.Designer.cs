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
            cboSurgeryCenter.Location = new Point(195, 333);
            cboSurgeryCenter.Margin = new Padding(3, 4, 3, 4);
            cboSurgeryCenter.Name = "cboSurgeryCenter";
            cboSurgeryCenter.Size = new Size(342, 28);
            cboSurgeryCenter.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 28);
            label3.TabIndex = 2;
            label3.Text = "Detailed Surgery Information";
            // 
            // cboSurgeon
            // 
            cboSurgeon.FormattingEnabled = true;
            cboSurgeon.Location = new Point(193, 180);
            cboSurgeon.Margin = new Padding(3, 4, 3, 4);
            cboSurgeon.Name = "cboSurgeon";
            cboSurgeon.Size = new Size(342, 28);
            cboSurgeon.TabIndex = 43;
            // 
            // dtpDateSurgery
            // 
            dtpDateSurgery.Format = DateTimePickerFormat.Short;
            dtpDateSurgery.Location = new Point(193, 73);
            dtpDateSurgery.Margin = new Padding(3, 4, 3, 4);
            dtpDateSurgery.Name = "dtpDateSurgery";
            dtpDateSurgery.Size = new Size(114, 27);
            dtpDateSurgery.TabIndex = 42;
            // 
            // cboMedicalCondition
            // 
            cboMedicalCondition.FormattingEnabled = true;
            cboMedicalCondition.Location = new Point(193, 127);
            cboMedicalCondition.Margin = new Padding(3, 4, 3, 4);
            cboMedicalCondition.Name = "cboMedicalCondition";
            cboMedicalCondition.Size = new Size(542, 28);
            cboMedicalCondition.TabIndex = 38;
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(814, 124);
            rtxtNotes.Margin = new Padding(3, 4, 3, 4);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(530, 515);
            rtxtNotes.TabIndex = 36;
            rtxtNotes.Text = "";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(981, 660);
            btnImage.Margin = new Padding(3, 4, 3, 4);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(137, 53);
            btnImage.TabIndex = 35;
            btnImage.Text = "Attach Image File";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnPDFFile
            // 
            btnPDFFile.Location = new Point(814, 660);
            btnPDFFile.Margin = new Padding(3, 4, 3, 4);
            btnPDFFile.Name = "btnPDFFile";
            btnPDFFile.Size = new Size(137, 53);
            btnPDFFile.TabIndex = 34;
            btnPDFFile.Text = "Attach PDF File";
            btnPDFFile.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(814, 92);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 33;
            label10.Text = "Notes:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 329);
            label6.Name = "label6";
            label6.Size = new Size(183, 31);
            label6.TabIndex = 29;
            label6.Text = "Surgery Center:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 215);
            label5.Name = "label5";
            label5.Size = new Size(103, 31);
            label5.TabIndex = 28;
            label5.Text = "Specialty:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(183, 31);
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
            pnlHeading.Margin = new Padding(3, 4, 3, 4);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1371, 33);
            pnlHeading.TabIndex = 26;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 25;
            label2.Text = "Date of Surgery:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 127);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 24;
            label1.Text = "Medical Condition:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSurgeonSpeciality
            // 
            lblSurgeonSpeciality.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSurgeonSpeciality.Location = new Point(293, 215);
            lblSurgeonSpeciality.Name = "lblSurgeonSpeciality";
            lblSurgeonSpeciality.Size = new Size(457, 31);
            lblSurgeonSpeciality.TabIndex = 45;
            lblSurgeonSpeciality.Text = "unknown";
            lblSurgeonSpeciality.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(195, 245);
            label12.Name = "label12";
            label12.Size = new Size(103, 31);
            label12.TabIndex = 46;
            label12.Text = "Location:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(195, 276);
            label13.Name = "label13";
            label13.Size = new Size(103, 31);
            label13.TabIndex = 47;
            label13.Text = "Phone:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSugeonLocation
            // 
            lblSugeonLocation.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeonLocation.Location = new Point(293, 245);
            lblSugeonLocation.Name = "lblSugeonLocation";
            lblSugeonLocation.Size = new Size(457, 31);
            lblSugeonLocation.TabIndex = 48;
            lblSugeonLocation.Text = "unknown";
            lblSugeonLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSugeonPhone
            // 
            lblSugeonPhone.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeonPhone.Location = new Point(293, 276);
            lblSugeonPhone.Name = "lblSugeonPhone";
            lblSugeonPhone.Size = new Size(457, 31);
            lblSugeonPhone.TabIndex = 49;
            lblSugeonPhone.Text = "unknown";
            lblSugeonPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSugeryCenterPhone
            // 
            lblSugeryCenterPhone.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeryCenterPhone.Location = new Point(293, 393);
            lblSugeryCenterPhone.Name = "lblSugeryCenterPhone";
            lblSugeryCenterPhone.Size = new Size(457, 31);
            lblSugeryCenterPhone.TabIndex = 54;
            lblSugeryCenterPhone.Text = "unknown";
            lblSugeryCenterPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(195, 393);
            label16.Name = "label16";
            label16.Size = new Size(103, 31);
            label16.TabIndex = 52;
            label16.Text = "Phone:";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSugeryCenterLocation
            // 
            lblSugeryCenterLocation.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugeryCenterLocation.Location = new Point(293, 363);
            lblSugeryCenterLocation.Name = "lblSugeryCenterLocation";
            lblSugeryCenterLocation.Size = new Size(457, 31);
            lblSugeryCenterLocation.TabIndex = 51;
            lblSugeryCenterLocation.Text = "unknown";
            lblSugeryCenterLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(195, 363);
            label18.Name = "label18";
            label18.Size = new Size(103, 31);
            label18.TabIndex = 50;
            label18.Text = "Location:";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SurgeriesDetailControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SurgeriesDetailControl";
            Size = new Size(1371, 731);
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
