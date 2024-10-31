namespace prgPMR
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnNewUser = new Button();
            btnCancel = new Button();
            label3 = new Label();
            txtbxUsername = new TextBox();
            txtbxPassword = new TextBox();
            btnLogin = new Button();
            lblForgotPW = new Label();
            chkShowPW = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNewUser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 514);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "E:\\Projects\\Medical Records\\PMR\\prgPMR\\images\\PMRImage.jpg";
            pictureBox1.InitialImage = Properties.Resources.PMRImage;
            pictureBox1.Location = new Point(68, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 112);
            label2.Name = "label2";
            label2.Size = new Size(218, 37);
            label2.TabIndex = 2;
            label2.Text = "Records System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 67);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 1;
            label1.Text = "Personal Medical";
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.DarkBlue;
            btnNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(110, 437);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(107, 38);
            btnNewUser.TabIndex = 7;
            btnNewUser.Text = "New User";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkBlue;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(617, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(439, 91);
            label3.Name = "label3";
            label3.Size = new Size(105, 37);
            label3.TabIndex = 3;
            label3.Text = "Sign In";
            label3.Click += label3_Click;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxUsername.Location = new Point(488, 160);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PlaceholderText = "User Name";
            txtbxUsername.Size = new Size(407, 33);
            txtbxUsername.TabIndex = 4;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxPassword.ImeMode = ImeMode.Off;
            txtbxPassword.Location = new Point(488, 223);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PlaceholderText = "Password";
            txtbxPassword.Size = new Size(407, 33);
            txtbxPassword.TabIndex = 5;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(560, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPW
            // 
            lblForgotPW.AutoSize = true;
            lblForgotPW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPW.ForeColor = Color.MidnightBlue;
            lblForgotPW.Location = new Point(782, 262);
            lblForgotPW.Name = "lblForgotPW";
            lblForgotPW.Size = new Size(99, 15);
            lblForgotPW.TabIndex = 8;
            lblForgotPW.Text = "Forgot password";
            // 
            // chkShowPW
            // 
            chkShowPW.AutoSize = true;
            chkShowPW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPW.ForeColor = Color.DarkBlue;
            chkShowPW.Location = new Point(488, 262);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(112, 19);
            chkShowPW.TabIndex = 11;
            chkShowPW.Text = "Show Password";
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1059, 514);
            Controls.Add(btnCancel);
            Controls.Add(chkShowPW);
            Controls.Add(lblForgotPW);
            Controls.Add(btnLogin);
            Controls.Add(txtbxPassword);
            Controls.Add(txtbxUsername);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "none";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel1;
        private Label label3;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Button btnLogin;
        private Button btnNewUser;
        private Label lblForgotPW;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private CheckBox chkShowPW;
        private Label label2;
        private Label label1;
    }
}
