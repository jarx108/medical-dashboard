using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgPMR
{
    public partial class ImmunizationDetailGridControl : MedicalControl
    {


        public ImmunizationDetailGridControl(ControlManager m) : base(m)
        {
            InitializeComponent();
            InitializeGrid();
            SetButtons(["Next", "Back"], [Next, Back]);
        }
        public void Next()
        {
            Manager.NextControl();
        }
        public void Back()
        {
            Manager.PreviousControl();
        }

        private void dgvVacMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeGrid()
        {

        }

    }
}
