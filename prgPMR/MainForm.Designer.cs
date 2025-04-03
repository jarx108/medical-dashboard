namespace prgPMR
{
    partial class MainForm
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
            pnlMenu = new Panel();
            btnHospitalization = new Button();
            btnSurgery = new Button();
            btnBloodwork = new Button();
            btnMedicalTest = new Button();
            btnDoctorVisit = new Button();
            btnImmunization = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            btnMedication = new Button();
            panel2 = new Panel();
            btnFamilyHistory = new Button();
            pnlUser = new Panel();
            btnCancelUser = new Button();
            lblUsername = new Label();
            lblDOB = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            btnSaveUser = new Button();
            btnChangePW = new Button();
            btnDeleteUser = new Button();
            txtUsername = new TextBox();
            txtDOB = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditUser = new Button();
            label9 = new Label();
            pnlMain = new Panel();
            pnlMainButtons = new Panel();
            btnAction5 = new Button();
            btnAction4 = new Button();
            btnAction3 = new Button();
            btnAction2 = new Button();
            btnAction1 = new Button();
            btnAction0 = new Button();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUser.SuspendLayout();
            pnlMainButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MidnightBlue;
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(btnHospitalization);
            pnlMenu.Controls.Add(btnSurgery);
            pnlMenu.Controls.Add(btnBloodwork);
            pnlMenu.Controls.Add(btnMedicalTest);
            pnlMenu.Controls.Add(btnDoctorVisit);
            pnlMenu.Controls.Add(btnImmunization);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(btnMedication);
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Controls.Add(btnFamilyHistory);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(150, 729);
            pnlMenu.TabIndex = 1;
            // 
            // btnHospitalization
            // 
            btnHospitalization.BackColor = Color.MidnightBlue;
            btnHospitalization.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnHospitalization.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnHospitalization.FlatStyle = FlatStyle.Flat;
            btnHospitalization.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHospitalization.ForeColor = Color.AliceBlue;
            btnHospitalization.Location = new Point(3, 408);
            btnHospitalization.Name = "btnHospitalization";
            btnHospitalization.Size = new Size(150, 31);
            btnHospitalization.TabIndex = 17;
            btnHospitalization.Text = "Hospitalization";
            btnHospitalization.UseVisualStyleBackColor = false;
            btnHospitalization.Click += DisplayControl_Click;
            // 
            // btnSurgery
            // 
            btnSurgery.BackColor = Color.MidnightBlue;
            btnSurgery.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnSurgery.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnSurgery.FlatStyle = FlatStyle.Flat;
            btnSurgery.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSurgery.ForeColor = Color.AliceBlue;
            btnSurgery.Location = new Point(-2, 381);
            btnSurgery.Name = "btnSurgery";
            btnSurgery.Size = new Size(150, 31);
            btnSurgery.TabIndex = 16;
            btnSurgery.Text = "Surgery";
            btnSurgery.UseVisualStyleBackColor = false;
            btnSurgery.Click += DisplayControl_Click;
            // 
            // btnBloodwork
            // 
            btnBloodwork.BackColor = Color.MidnightBlue;
            btnBloodwork.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnBloodwork.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnBloodwork.FlatStyle = FlatStyle.Flat;
            btnBloodwork.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBloodwork.ForeColor = Color.AliceBlue;
            btnBloodwork.Location = new Point(-2, 353);
            btnBloodwork.Name = "btnBloodwork";
            btnBloodwork.Size = new Size(150, 31);
            btnBloodwork.TabIndex = 15;
            btnBloodwork.Text = "Bloodwork";
            btnBloodwork.UseVisualStyleBackColor = false;
            btnBloodwork.Click += DisplayControl_Click;
            // 
            // btnMedicalTest
            // 
            btnMedicalTest.BackColor = Color.MidnightBlue;
            btnMedicalTest.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnMedicalTest.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnMedicalTest.FlatStyle = FlatStyle.Flat;
            btnMedicalTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedicalTest.ForeColor = Color.AliceBlue;
            btnMedicalTest.Location = new Point(-2, 325);
            btnMedicalTest.Name = "btnMedicalTest";
            btnMedicalTest.Size = new Size(150, 31);
            btnMedicalTest.TabIndex = 14;
            btnMedicalTest.Text = "Medical Test";
            btnMedicalTest.UseVisualStyleBackColor = false;
            btnMedicalTest.Click += DisplayControl_Click;
            // 
            // btnDoctorVisit
            // 
            btnDoctorVisit.BackColor = Color.MidnightBlue;
            btnDoctorVisit.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnDoctorVisit.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnDoctorVisit.FlatStyle = FlatStyle.Flat;
            btnDoctorVisit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctorVisit.ForeColor = Color.AliceBlue;
            btnDoctorVisit.Location = new Point(-2, 297);
            btnDoctorVisit.Name = "btnDoctorVisit";
            btnDoctorVisit.Size = new Size(150, 31);
            btnDoctorVisit.TabIndex = 13;
            btnDoctorVisit.Text = "Doctor Visits";
            btnDoctorVisit.UseVisualStyleBackColor = false;
            btnDoctorVisit.Click += DisplayControl_Click;
            // 
            // btnImmunization
            // 
            btnImmunization.BackColor = Color.MidnightBlue;
            btnImmunization.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnImmunization.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnImmunization.FlatStyle = FlatStyle.Flat;
            btnImmunization.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImmunization.ForeColor = Color.AliceBlue;
            btnImmunization.Location = new Point(-2, 269);
            btnImmunization.Name = "btnImmunization";
            btnImmunization.Size = new Size(150, 31);
            btnImmunization.TabIndex = 12;
            btnImmunization.Text = "Immunizations";
            btnImmunization.UseVisualStyleBackColor = false;
            btnImmunization.Click += DisplayControl_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Navy;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(30, 659);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(73, 30);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += LogoutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PMRImage1;
            pictureBox1.Location = new Point(19, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnMedication
            // 
            btnMedication.BackColor = Color.MidnightBlue;
            btnMedication.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnMedication.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnMedication.FlatStyle = FlatStyle.Flat;
            btnMedication.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedication.ForeColor = Color.AliceBlue;
            btnMedication.Location = new Point(-2, 241);
            btnMedication.Name = "btnMedication";
            btnMedication.Size = new Size(150, 31);
            btnMedication.TabIndex = 4;
            btnMedication.Text = " Medication";
            btnMedication.UseVisualStyleBackColor = false;
            btnMedication.Click += DisplayControl_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(154, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 122);
            panel2.TabIndex = 2;
            // 
            // btnFamilyHistory
            // 
            btnFamilyHistory.BackColor = Color.MidnightBlue;
            btnFamilyHistory.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnFamilyHistory.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnFamilyHistory.FlatStyle = FlatStyle.Flat;
            btnFamilyHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFamilyHistory.ForeColor = Color.AliceBlue;
            btnFamilyHistory.Location = new Point(-2, 213);
            btnFamilyHistory.Name = "btnFamilyHistory";
            btnFamilyHistory.Size = new Size(150, 31);
            btnFamilyHistory.TabIndex = 3;
            btnFamilyHistory.Text = "Family Medical History";
            btnFamilyHistory.UseVisualStyleBackColor = false;
            btnFamilyHistory.Click += DisplayControl_Click;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.RoyalBlue;
            pnlUser.Controls.Add(btnCancelUser);
            pnlUser.Controls.Add(lblUsername);
            pnlUser.Controls.Add(lblDOB);
            pnlUser.Controls.Add(lblFirstName);
            pnlUser.Controls.Add(lblLastName);
            pnlUser.Controls.Add(btnSaveUser);
            pnlUser.Controls.Add(btnChangePW);
            pnlUser.Controls.Add(btnDeleteUser);
            pnlUser.Controls.Add(txtUsername);
            pnlUser.Controls.Add(txtDOB);
            pnlUser.Controls.Add(txtFirstName);
            pnlUser.Controls.Add(txtLastName);
            pnlUser.Controls.Add(label3);
            pnlUser.Controls.Add(label2);
            pnlUser.Controls.Add(label1);
            pnlUser.Controls.Add(btnEditUser);
            pnlUser.Controls.Add(label9);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(150, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(1200, 119);
            pnlUser.TabIndex = 2;
            // 
            // btnCancelUser
            // 
            btnCancelUser.BackColor = Color.Navy;
            btnCancelUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelUser.ForeColor = Color.White;
            btnCancelUser.Location = new Point(535, 76);
            btnCancelUser.Name = "btnCancelUser";
            btnCancelUser.Size = new Size(59, 27);
            btnCancelUser.TabIndex = 16;
            btnCancelUser.Text = "Cancel";
            btnCancelUser.UseVisualStyleBackColor = false;
            btnCancelUser.Click += CancelUserButton_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Yellow;
            lblUsername.Location = new Point(549, 18);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(85, 21);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Username";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = Color.Yellow;
            lblDOB.Location = new Point(130, 77);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(78, 21);
            lblDOB.TabIndex = 14;
            lblDOB.Text = "00/00/00";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.Yellow;
            lblFirstName.Location = new Point(130, 47);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(91, 21);
            lblFirstName.TabIndex = 13;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.RoyalBlue;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.Yellow;
            lblLastName.Location = new Point(130, 18);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(89, 21);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "Last Name";
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.Navy;
            btnSaveUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveUser.ForeColor = Color.White;
            btnSaveUser.Location = new Point(459, 76);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(59, 27);
            btnSaveUser.TabIndex = 11;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += SaveUserButton_Click;
            // 
            // btnChangePW
            // 
            btnChangePW.BackColor = Color.Navy;
            btnChangePW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePW.ForeColor = Color.White;
            btnChangePW.Location = new Point(446, 41);
            btnChangePW.Name = "btnChangePW";
            btnChangePW.Size = new Size(161, 30);
            btnChangePW.TabIndex = 10;
            btnChangePW.Text = "Change Password";
            btnChangePW.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Navy;
            btnDeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(778, 46);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(59, 27);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(549, 18);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 23);
            txtUsername.TabIndex = 8;
            txtUsername.Text = "Username";
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDOB.Location = new Point(130, 77);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(114, 23);
            txtDOB.TabIndex = 7;
            txtDOB.Text = "00/00/00";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(130, 48);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(245, 23);
            txtFirstName.TabIndex = 6;
            txtFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(130, 18);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(245, 23);
            txtLastName.TabIndex = 5;
            txtLastName.Text = "Last Name";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(446, 16);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 3;
            label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Navy;
            btnEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(778, 15);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(59, 27);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += EditUserButton_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.AliceBlue;
            label9.Location = new Point(14, 13);
            label9.Name = "label9";
            label9.Size = new Size(110, 31);
            label9.TabIndex = 0;
            label9.Text = "Last Name:";
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top;
            pnlMain.Location = new Point(150, 119);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1200, 548);
            pnlMain.TabIndex = 3;
            pnlMain.Paint += MainPanel_Paint;
            // 
            // pnlMainButtons
            // 
            pnlMainButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMainButtons.Controls.Add(btnAction5);
            pnlMainButtons.Controls.Add(btnAction4);
            pnlMainButtons.Controls.Add(btnAction3);
            pnlMainButtons.Controls.Add(btnAction2);
            pnlMainButtons.Controls.Add(btnAction1);
            pnlMainButtons.Controls.Add(btnAction0);
            pnlMainButtons.Location = new Point(150, 673);
            pnlMainButtons.Name = "pnlMainButtons";
            pnlMainButtons.Size = new Size(1200, 56);
            pnlMainButtons.TabIndex = 4;
            // 
            // btnAction5
            // 
            btnAction5.BackColor = Color.Navy;
            btnAction5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction5.ForeColor = Color.White;
            btnAction5.Location = new Point(1105, 14);
            btnAction5.Name = "btnAction5";
            btnAction5.Size = new Size(73, 30);
            btnAction5.TabIndex = 18;
            btnAction5.Text = "Cancel";
            btnAction5.UseVisualStyleBackColor = false;
            // 
            // btnAction4
            // 
            btnAction4.BackColor = Color.Navy;
            btnAction4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction4.ForeColor = Color.White;
            btnAction4.Location = new Point(1026, 14);
            btnAction4.Name = "btnAction4";
            btnAction4.Size = new Size(73, 30);
            btnAction4.TabIndex = 16;
            btnAction4.Text = "Save";
            btnAction4.UseVisualStyleBackColor = false;
            btnAction4.Click += ButtonBar_Click;
            // 
            // btnAction3
            // 
            btnAction3.BackColor = Color.Navy;
            btnAction3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction3.ForeColor = Color.White;
            btnAction3.Location = new Point(573, 14);
            btnAction3.Name = "btnAction3";
            btnAction3.Size = new Size(73, 30);
            btnAction3.TabIndex = 15;
            btnAction3.Text = "Reset";
            btnAction3.UseVisualStyleBackColor = false;
            btnAction3.Click += ButtonBar_Click;
            // 
            // btnAction2
            // 
            btnAction2.BackColor = Color.Navy;
            btnAction2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction2.ForeColor = Color.White;
            btnAction2.Location = new Point(218, 14);
            btnAction2.Name = "btnAction2";
            btnAction2.Size = new Size(73, 30);
            btnAction2.TabIndex = 14;
            btnAction2.Text = "Delete";
            btnAction2.UseVisualStyleBackColor = false;
            btnAction2.Click += ButtonBar_Click;
            // 
            // btnAction1
            // 
            btnAction1.BackColor = Color.Navy;
            btnAction1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction1.ForeColor = Color.White;
            btnAction1.Location = new Point(135, 14);
            btnAction1.Name = "btnAction1";
            btnAction1.Size = new Size(73, 30);
            btnAction1.TabIndex = 13;
            btnAction1.Text = "Edit";
            btnAction1.UseVisualStyleBackColor = false;
            btnAction1.Click += ButtonBar_Click;
            // 
            // btnAction0
            // 
            btnAction0.BackColor = Color.Navy;
            btnAction0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction0.ForeColor = Color.White;
            btnAction0.Location = new Point(51, 14);
            btnAction0.Name = "btnAction0";
            btnAction0.Size = new Size(73, 30);
            btnAction0.TabIndex = 12;
            btnAction0.Text = "Add";
            btnAction0.UseVisualStyleBackColor = false;
            btnAction0.Click += ButtonBar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlMainButtons);
            Controls.Add(pnlMain);
            Controls.Add(pnlUser);
            Controls.Add(pnlMenu);
            Name = "MainForm";
            Text = "Personal Medical Records System";
            Load += MainForm_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            pnlMainButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnFamilyHistory;
        private Panel panel2;
        private Panel pnlUser;
        private Panel pnlMain;
        private Label label9;
        private Button btnMedication;
        public Button btnEditUser;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnChangePW;
        public Button btnDeleteUser;
        private TextBox txtUsername;
        private TextBox txtDOB;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        public Button btnSaveUser;
        public Button btnLogout;
        private Button btnDoctorVisit;
        private Button btnImmunization;
        private Button btnHospitalization;
        private Button btnSurgery;
        private Button btnBloodwork;
        private Button btnMedicalTest;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblDOB;
        public Button btnCancelUser;
        private Panel pnlMainButtons;
        public Button btnAction0;
        public Button btnAction3;
        public Button btnAction2;
        public Button btnAction1;
        public Button btnAction4;
        public Button btnAction5;
    }
}