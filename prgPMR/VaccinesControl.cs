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
            InitializeGrid();
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
        public override void Back()
        {
            Manager.PreviousControl();
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


            // fill the grid with dummy data
            dt.Rows.Add("COVID", "COVID", new DateOnly(2024, 4,8),2);
            dt.Rows.Add("Influenza", "FLU", new DateOnly(2024, 5, 24), 5);
            dt.Rows.Add("Tetnus", "tdap", new DateOnly(2024, 4, 8), 4);

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


        }


    }
}
