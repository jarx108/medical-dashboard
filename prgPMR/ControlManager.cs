using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prgPMR.DataObjects;

namespace prgPMR
{
    public class ControlManager
    {
        public Button[] Buttons;
        internal List<MedicalControl> MedicalControls { get; }
        private int activeControl = 0;
        private bool visible = false;

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
                case MainForm.MedicalControlType.Medication:
                    MedicalControls.Add(new MedicationsControl(this));
                    break;
                case MainForm.MedicalControlType.Immunization:
                    MedicalControls.AddRange(new ImmunizationControl(this), new ImmunizationDetailControl(this));
                    break;
                case MainForm.MedicalControlType.DoctorVisit:
                    MedicalControls.Add(new DoctorVisitsControl(this));
                    break;
                case MainForm.MedicalControlType.Test:
                    MedicalControls.Add(new TestsControl(this));
                    break;
                case MainForm.MedicalControlType.Bloodwork:
                    MedicalControls.Add(new BloodworkControl(this));
                    break;
                case MainForm.MedicalControlType.Surgery:
                    MedicalControls.Add(new SurgeriesControl(this));
                    break;
                case MainForm.MedicalControlType.Hospitalization:
                    MedicalControls.Add(new HospitalizationsControl(this));
                    break;
                default:
                    throw new ArgumentException("Invalid Medical Control type");
            }
        }
        public void ButtonClicked(int buttonIndex)
        {
            MedicalControls[activeControl].ButtonActions[buttonIndex]();
        }
        public void RefreshVisibility()
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
                if(isVisible && m == MedicalControls[activeControl])
                {
                    // Set the visibility property of the panel of the ActiveControl/m to true/visible
                    m.Visible = true;

                    //Loop through all the buttons on the panel
                    for (int i = 0; i < Buttons.Length; i++)
                    {
                        // Check if the activeControl is greater than the number of buttons in the list or
                        // the name of the button is null
                        if(i >= m.ButtonsText.Length || m.ButtonsText[i] == null)
                        {
                            //  Hide the button
                            Buttons[i].Visible = false;
                        }
                        else
                        {
                            // Set the text of the button to the text in the control and
                            // make button visible by setting button property to true
                            Buttons[i].Text = m.ButtonsText[i];
                            Buttons[i].Visible = true;
                        }
                    }
                }
                else
                {
                    // Set the visibility property of the panel of the ActiveControl/m to false/invisible
                    m.Visible = false;
                }
            }
        }
        public bool GetVisible()
        {
            return visible;
        }

        // TODO: replace dummy method
        public void NextControl()
        {
            if (activeControl == MedicalControls.Count - 1)
                return;
            activeControl++;
            RefreshVisibility();
        }
        // TODO: replace dummy method
        public void PreviousControl()
        {
            if (activeControl == 0)
                return;
            activeControl--;
            RefreshVisibility();
        }
        public void NextControlWithData(DataInterface data)
        {
            if (activeControl == MedicalControls.Count - 1)
                return;
            activeControl++;
            MedicalControls[activeControl].DataLoad(data);
            RefreshVisibility();

        }
        public void PreviousControlWithData(DataInterface data)
        {
            if (activeControl == 0)
                return;
            activeControl--;
            MedicalControls[activeControl].DataLoad(data);
            RefreshVisibility();
        }
    }
}
