using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    public class ControlManager
    {
        internal List<MedicalControl> MedicalControls { get; }
        private MedicalControl ActiveControl;
        private int index;
        private bool visible;

        public ControlManager(MainForm.MedicalControlType type) {
            MedicalControls = [];
            switch (type)
            {
                case MainForm.MedicalControlType.Default:
                    MedicalControls.Add(new DefaultControl(this));
                    break;
                case MainForm.MedicalControlType.FamilyHistory:
                    MedicalControls.Add(new FamilyHistoryControl(this));
                    break;
                case MainForm.MedicalControlType.Medications:
                    MedicalControls.Add(new MedicationsControl(this));
                    break;
                case MainForm.MedicalControlType.Vaccines:
                    MedicalControls.AddRange(new VaccinesControl(this), new VaccinesDetailControl(this));
                    break;
                case MainForm.MedicalControlType.DoctorVisits:
                    MedicalControls.Add(new DoctorVisitsControl(this));
                    break;
                case MainForm.MedicalControlType.Tests:
                    MedicalControls.Add(new TestsControl(this));
                    break;
                case MainForm.MedicalControlType.Bloodwork:
                    MedicalControls.Add(new BloodworkControl(this));
                    break;
                case MainForm.MedicalControlType.Surgeries:
                    MedicalControls.Add(new SurgeriesControl(this));
                    break;
                case MainForm.MedicalControlType.Hospitalizations:
                    MedicalControls.Add(new HospitalizationsControl(this));
                    break;
                default:
                    throw new NotImplementedException();
            }
            ActiveControl = MedicalControls[0];
            index = 0;
        }


        public void Add()
        {
            ActiveControl.Add();
        }
        public void Edit()
        {
            ActiveControl.Edit();
        }
        public void Delete()
        {
            ActiveControl.Delete();
        }
        public void Cancel()
        {
            ActiveControl.Cancel();
        }

        private void RefreshVisible()
        {
            SetVisible(visible);
        }
        public void SetVisible(bool isVisible)
        {
            visible = isVisible;
            foreach(MedicalControl m in MedicalControls)
            {
                if(m == ActiveControl)
                    m.Visible = isVisible;
                else 
                    m.Visible = false;
            }
        }
        public void Default()
        {
            ActiveControl.Default();
        }
        public void Refresh()
        {
            ActiveControl.Refresh();
        }

        public void NextControl()
        {
            index++;
            ActiveControl = MedicalControls[index];
            RefreshVisible();
        }
        public void PreviousControl()
        {
            index--;
            ActiveControl = MedicalControls[index];
            RefreshVisible();
        }
    }
}
