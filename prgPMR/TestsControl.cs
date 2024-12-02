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
    public partial class TestsControl : MedicalControl
    {
        public TestsControl(ControlManager m) : base(m)
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
            lblClass.Text = "Add was Pushed";
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
    }
}
