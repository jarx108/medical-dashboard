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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            ImmunizationDataGrid = new DataGridView();
            Vaccine = new DataGridViewTextBoxColumn();
            VaccineGroup = new DataGridViewTextBoxColumn();
            DateLastDose = new DataGridViewTextBoxColumn();
            TotalNumDoses = new DataGridViewTextBoxColumn();
            DateDose1 = new DataGridViewTextBoxColumn();
            DateDose2 = new DataGridViewTextBoxColumn();
            DateDose3 = new DataGridViewTextBoxColumn();
            DateDose4 = new DataGridViewTextBoxColumn();
            DateDose5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ImmunizationDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ImmunizationDataGrid
            // 
            ImmunizationDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ImmunizationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ImmunizationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ImmunizationDataGrid.Columns.AddRange(new DataGridViewColumn[] { Vaccine, VaccineGroup, DateLastDose, TotalNumDoses, DateDose1, DateDose2, DateDose3, DateDose4, DateDose5 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            ImmunizationDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            ImmunizationDataGrid.Dock = DockStyle.Top;
            ImmunizationDataGrid.Location = new Point(0, 0);
            ImmunizationDataGrid.Name = "ImmunizationDataGrid";
            ImmunizationDataGrid.RowHeadersVisible = false;
            ImmunizationDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ImmunizationDataGrid.Size = new Size(1200, 610);
            ImmunizationDataGrid.TabIndex = 0;
            ImmunizationDataGrid.CellMouseClick += ImmunizationDataGrid_CellClick;
            ImmunizationDataGrid.CellMouseDoubleClick += ImmunizationDataGrid_DoubleCellClick;
            // 
            // Vaccine
            // 
            Vaccine.DataPropertyName = "Vaccine";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Vaccine.DefaultCellStyle = dataGridViewCellStyle2;
            Vaccine.Frozen = true;
            Vaccine.HeaderText = "Vaccine";
            Vaccine.Name = "Vaccine";
            Vaccine.ReadOnly = true;
            Vaccine.Width = 350;
            // 
            // VaccineGroup
            // 
            VaccineGroup.DataPropertyName = "VaccineGroup";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            VaccineGroup.DefaultCellStyle = dataGridViewCellStyle3;
            VaccineGroup.Frozen = true;
            VaccineGroup.HeaderText = "Vaccine Group";
            VaccineGroup.Name = "VaccineGroup";
            VaccineGroup.ReadOnly = true;
            VaccineGroup.Width = 80;
            // 
            // DateLastDose
            // 
            DateLastDose.DataPropertyName = "DateLastDose";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            DateLastDose.DefaultCellStyle = dataGridViewCellStyle4;
            DateLastDose.Frozen = true;
            DateLastDose.HeaderText = "Date of Last Dose";
            DateLastDose.Name = "DateLastDose";
            DateLastDose.ReadOnly = true;
            DateLastDose.Width = 80;
            // 
            // TotalNumDoses
            // 
            TotalNumDoses.DataPropertyName = "TotalNumDoses";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            TotalNumDoses.DefaultCellStyle = dataGridViewCellStyle5;
            TotalNumDoses.Frozen = true;
            TotalNumDoses.HeaderText = "Total Num of Doses";
            TotalNumDoses.Name = "TotalNumDoses";
            TotalNumDoses.ReadOnly = true;
            TotalNumDoses.Width = 75;
            // 
            // DateDose1
            // 
            DateDose1.DataPropertyName = "DateDose1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            DateDose1.DefaultCellStyle = dataGridViewCellStyle6;
            DateDose1.HeaderText = "Date of Dose 1";
            DateDose1.Name = "DateDose1";
            DateDose1.Width = 80;
            // 
            // DateDose2
            // 
            DateDose2.DataPropertyName = "DateDose2";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            DateDose2.DefaultCellStyle = dataGridViewCellStyle7;
            DateDose2.HeaderText = "Date of Dose 2";
            DateDose2.Name = "DateDose2";
            DateDose2.Width = 80;
            // 
            // DateDose3
            // 
            DateDose3.DataPropertyName = "DateDose3";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            DateDose3.DefaultCellStyle = dataGridViewCellStyle8;
            DateDose3.HeaderText = "Date of Dose 3";
            DateDose3.Name = "DateDose3";
            DateDose3.Width = 80;
            // 
            // DateDose4
            // 
            DateDose4.DataPropertyName = "DateDose4";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            DateDose4.DefaultCellStyle = dataGridViewCellStyle9;
            DateDose4.HeaderText = "Date of Dose 4";
            DateDose4.Name = "DateDose4";
            DateDose4.Width = 80;
            // 
            // DateDose5
            // 
            DateDose5.DataPropertyName = "DateDose5";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DateDose5.DefaultCellStyle = dataGridViewCellStyle10;
            DateDose5.HeaderText = "Date of Dose 5";
            DateDose5.Name = "DateDose5";
            DateDose5.Width = 80;
            // 
            // ImmunizationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ImmunizationDataGrid);
            Name = "ImmunizationControl";
            Size = new Size(1200, 610);
            ((System.ComponentModel.ISupportInitialize)ImmunizationDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ImmunizationDataGrid;
        private DataGridViewTextBoxColumn Vaccine;
        private DataGridViewTextBoxColumn VaccineGroup;
        private DataGridViewTextBoxColumn DateLastDose;
        private DataGridViewTextBoxColumn TotalNumDoses;
        private DataGridViewTextBoxColumn DateDose1;
        private DataGridViewTextBoxColumn DateDose2;
        private DataGridViewTextBoxColumn DateDose3;
        private DataGridViewTextBoxColumn DateDose4;
        private DataGridViewTextBoxColumn DateDose5;
    }
}
