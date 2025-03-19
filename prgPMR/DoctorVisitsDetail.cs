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
    public partial class DoctorVisitsDetail : MedicalControl
    {
        public DoctorVisitsDetail(ControlManager m) : base(m)
        {
            InitializeComponent();
            SetButtons([], []);
        }
    }
}
