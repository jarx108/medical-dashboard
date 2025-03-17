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
    public partial class VaccinesDetailGridControl : MedicalControl
    {


        public VaccinesDetailGridControl(ControlManager m) : base(m)
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

        public override void Back()
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
