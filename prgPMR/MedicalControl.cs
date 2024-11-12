using prgPMR.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<MedicalControl, UserControl>))]
    public abstract class MedicalControl : UserControl
    {
        
        public void SetVisible(Boolean visible)
        {
            this.Visible = visible;
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        
        public abstract void Default();
        // Default is used to display the datagrid or core data
        // The user can then Add, Edit, Delete

        public abstract void Add();

        
        public abstract void Edit();

        
        public abstract void Delete();

        
        public abstract void Cancel();


    }
}
