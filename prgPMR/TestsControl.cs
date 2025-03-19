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
            SetButtons(
                ["Refresh", "Add", "Edit", "Delete", null, "Cancel"],
                [Refresh, Add, Edit, Delete, null, Cancel]);
        }

        public override void Refresh()
        {
            base.Refresh();
            lblClass.Text = "Refresh was Pushed";

        }
        public void Add()
        {
            lblClass.Text = "Add was Pushed";
        }
        public void Edit()
        {
            lblClass.Text = "Edit was Pushed";
        }

        public void Delete()
        {
            lblClass.Text = "Delete was Pushed";
        }
        public void Cancel()
        {
            lblClass.Text = "Cancel was Pushed";
        }
        public void Back()
        {
            lblClass.Text = "Back was Pushed";
        }
    }
}
