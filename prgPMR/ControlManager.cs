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

        public ControlManager(MainForm.MedicalControlType type, Button[] b) 
        {
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
        // Method to make the selected panel either visible or hide it
        // and also make visible or hide the appropriate buttons at the bottom of the panel
        public void SetVisible(bool isVisible)
        {
            // Set local variable to the valued passed to the Method for use by other Methods in this class
            visible = isVisible;

            // Loop through all the medical controls
            foreach(MedicalControl m in MedicalControls)
            {
                // Check if the the passed parameter value is set to visible or not visible and
                // if "m" is the the same as the control that is currently active "ActiveControl"
                if(isVisible && m == ActiveControl)
                {
                    // Set the visbility property of the panel of the ActiveControl/m to true/visible
                    m.Visible = true;

                    //Loop through all the buttons on the panel
                    for (int i = 0; i < Buttons.Length; i++)
                    {
                        // Check if the index is greater than the number of buttons in the list or
                        // the name of the button is null
                        if(i >= m.ButtonsNames.Length || m.ButtonsNames[i] == null)
                        {
                            //  Hide the button
                            Buttons[i].Visible = false;
                        }
                        else
                        {
                            // Set the text of the button to the text in the control and
                            // make button visible by setting button property to true
                            Buttons[i].Text = m.ButtonsNames[i];
                            Buttons[i].Visible = true;
                        }
                    }
                }
                else
                {
                    // Set the visbility property of the panel of the ActiveControl/m to false/invisible
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


        // TODO: replace dummy method
        public void NextControl()
        {
            index++;
            ActiveControl = MedicalControls[index];
            RefreshVisible();
        }
        // TODO: replace dummy method
        public void PreviousControl()
        {
            index--;
            ActiveControl = MedicalControls[index];
            RefreshVisible();
        }
    }
}
