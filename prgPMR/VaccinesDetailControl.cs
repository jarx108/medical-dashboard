using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgPMR
{
    public partial class VaccinesDetailControl : MedicalControl
    {
        public VaccinesDetailControl(ControlManager m) : base(m)
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
            lblClass.Text = "Refresh was Pushed";

        }

        public override void Default()
        {
            lblClass.Text = "Default screen";
        }

        public override void Add()
        {
            Manager.NextControl();
        }

        public override void Edit()
        {
            lblClass.Text = "Edit was Pushed";
        }

        public override void Delete()
        {
            lblClass.Text = "Delete was Pushed";
        }

        public override void Cancel()
        {
            lblClass.Text = "Cancel was Pushed";
        }

        public override void Back()
        {
            Manager.PreviousControl();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboGeneralName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPDFFile_Click(object sender, EventArgs e)
        {

        }

        private void VaccinesDetailControl_Load(object sender, EventArgs e)
        {

        }
    }
}
