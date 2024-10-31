using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    public abstract class MedicalControl : UserControl
    {
        public void SetVisible(Boolean visible)
        {
            this.Visible = visible;
        }

    }
}
