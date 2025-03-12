using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    public class ControlManager
    {
        public Button[] Buttons;
        internal List<MedicalControl> MedicalControls { get; }
        private MedicalControl ActiveControl;
        private int index;
        private bool visible;

        public ControlManager(MainForm.MedicalControlType type, Button[] b) {
            MedicalControls = [];
            Buttons = b;
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
                    MedicalControls.AddRange(new VaccinesControl(this), new VaccinesDetailGridControl(this), new VaccinesDetailControl(this));
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
                    throw new ArgumentException("Invalid Medical Control type");
            }
            index = 0;
            ActiveControl = MedicalControls[index];
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

        public void Back()
        {
            ActiveControl.Back();
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
                if(isVisible && m == ActiveControl)
                {
                    m.Visible = true;
                    for (int i = 0; i < Buttons.Length; i++)
                    {
                        if(i >= m.ButtonsNames.Length || m.ButtonsNames[i] == null)
                        {
                            Buttons[i].Visible = false;
                        }
                        else
                        {
                            Buttons[i].Text = m.ButtonsNames[i];
                            Buttons[i].Visible = true;
                        }
                    }

                }
                else
                {
                    m.Visible = false;
                }
            }
        }
        public bool GetVisilble()
        {
            return visible;
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
