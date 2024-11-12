namespace prgPMR
{
    partial class TestsControl
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
            lblClass = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 78);
            label1.Name = "label1";
            label1.Size = new Size(479, 86);
            label1.TabIndex = 3;
            label1.Text = "Subform - Tests";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblClass.ForeColor = Color.Red;
            lblClass.Location = new Point(526, 310);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(253, 28);
            lblClass.TabIndex = 4;
            lblClass.Text = "What Button Was Pushed";
            // 
            // TestsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblClass);
            Controls.Add(label1);
            Name = "TestsControl";
            Size = new Size(1200, 610);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblClass;
    }
}
