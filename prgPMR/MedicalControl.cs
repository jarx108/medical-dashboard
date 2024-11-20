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
        internal MedicalControl? child;
        internal bool isActive = true;

        
        public void SetVisible(Boolean visible)
        {
            if (!visible)
            {
                this.Visible = false;
                child?.SetVisible(visible);
            } else
            {
                if(isActive)
                {
                    this.Visible = true;
                    child?.SetVisible(false);
                }
                else
                {
                    this.Visible = false;
                    if (child == null)
                    {
                        throw new InvalidOperationException("No control in chain is Active");
                    }
                    child.SetVisible(visible);
                }
            }
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public void AddAllToPanel(Panel pnl) 
        {
            pnl.Controls.Add(this);
            child?.AddAllToPanel(pnl);
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
