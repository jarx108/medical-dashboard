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
    public partial class ImmunizationDetailControl : MedicalControl
    {
        public ImmunizationDetailControl(ControlManager m) : base(m)
        {
            InitializeComponent();
            SetButtons(["Next", "Back", "Delete", "Cancel"], [Next, Back, Delete, Cancel]);
        }
        public void Next()
        {
            Manager.NextControl();
        }

        public void Back()
        {
            Manager.PreviousControl();
        }

        public void Delete()
        {
            lblClass.Text = "Delete was Pushed";
        }

        public void Cancel()
        {
            lblClass.Text = "Cancel was Pushed";
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
