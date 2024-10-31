namespace prgPMR
{
    partial class VaccinesControl
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
            panel2 = new Panel();
            dgvVacMain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVacMain).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 129);
            panel2.TabIndex = 1;
            // 
            // dgvVacMain
            // 
            dgvVacMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacMain.Location = new Point(3, 200);
            dgvVacMain.Name = "dgvVacMain";
            dgvVacMain.Size = new Size(1197, 299);
            dgvVacMain.TabIndex = 2;
            dgvVacMain.CellContentClick += dgvVacMain_CellContentClick;
            // 
            // VaccineMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVacMain);
            Controls.Add(panel2);
            Name = "VaccineMain";
            Size = new Size(1200, 610);
            ((System.ComponentModel.ISupportInitialize)dgvVacMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvVacMain;
    }
}
