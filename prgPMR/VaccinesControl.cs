using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace prgPMR
{
    public partial class VaccinesControl : MedicalControl 
    {


        public VaccinesControl(ControlManager m) : base(m)
        {
            InitializeComponent();
        }


        public override void Default()
        {
            throw new NotImplementedException();
        }

        public override void Add()
        {
            Manager.NextControl();
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        private void dgvVacMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeGrid()
        {
            int startDoses = 4;

            // Define new DataTable called "dt"
            DataTable dt = new DataTable();

            // Add 1st four column definitions
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Abbreviation", typeof(string));
            dt.Columns.Add("LastDose", typeof(DateOnly));
            dt.Columns.Add("NumDoses", typeof(int));

            // Add the columns for the 6 Dose Date fields
            for (int i=1; i <= 6; i++)
            {
                dt.Columns.Add($"DoseDate{i}", typeof(DateOnly));
            }

            // fill the grid with dummy data
            dt.Rows.Add("COVID", "COVID", new DateOnly(2024, 4,8), 3, new DateOnly(2023, 8, 18), new DateOnly(2022, 6, 22), new DateOnly(2022, 6, 22));
            dt.Rows.Add("Influenza", "FLU", new DateOnly(2024, 5, 24), 2, new DateOnly(2022, 8, 18), new DateOnly(2022, 7, 22));
            dt.Rows.Add("Tetnus", "tdap", new DateOnly(2024, 4, 8), 4, new DateOnly(2023, 8, 18), new DateOnly(2022, 4, 12), new DateOnly(2022, 6, 22), new DateOnly(2022, 6, 22));

            // Initialize the DataGridView

            dgvVacMain.DataSource= dt;


            // {
            //    DataSource = dt,
            //    Dock = DockStyle.Fill,
            // };

            // Controls.Add(dgvVacMain);



            // Set the column properties in the DataGridView
            dgvVacMain.Columns["Name"].HeaderText = "Name";
            dgvVacMain.Columns["Name"].Width = 300;
            dgvVacMain.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVacMain.Columns["Abbreviation"].HeaderText = "Abbreviation";
            dgvVacMain.Columns["Abbreviation"].Width = 80;
            dgvVacMain.Columns["LastDose"].HeaderText = "Last Dose";
            dgvVacMain.Columns["LastDose"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVacMain.Columns["LastDose"].Width = 60;
            dgvVacMain.Columns["NumDoses"].HeaderText = "Num of Doses";
            dgvVacMain.Columns["NumDoses"].Width = 40;
            dgvVacMain.Columns["NumDoses"].ReadOnly = true;


            for (int i = 0; i < (dgvVacMain.Columns.Count); i++)
            {
                if (i < startDoses)
                {
                    dgvVacMain.Columns[i].Frozen = true;
                }
               else
               {
                    dgvVacMain.Columns[i].Width = 80;
                    dgvVacMain.Columns[i].HeaderText = "Dose " + i;
                }
            }

        }


    }
}
