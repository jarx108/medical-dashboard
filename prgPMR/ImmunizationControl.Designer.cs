namespace prgPMR
{
    partial class ImmunizationControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvVacMain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVacMain).BeginInit();
            SuspendLayout();
            // 
            // dgvVacMain
            // 
            dgvVacMain.AllowUserToAddRows = false;
            dgvVacMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVacMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVacMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVacMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVacMain.EnableHeadersVisualStyles = false;
            dgvVacMain.Location = new Point(23, 21);
            dgvVacMain.MultiSelect = false;
            dgvVacMain.Name = "dgvVacMain";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVacMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVacMain.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVacMain.Size = new Size(1161, 571);
            dgvVacMain.TabIndex = 2;
            dgvVacMain.CellContentClick += VacMainDataGridView_CellContentClick;
            // 
            // VaccinesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVacMain);
            Name = "VaccinesControl";
            Size = new Size(1200, 610);
            ((System.ComponentModel.ISupportInitialize)dgvVacMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvVacMain;
    }
}
