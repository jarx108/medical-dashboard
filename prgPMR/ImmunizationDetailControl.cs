using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Intrinsics.Arm;

namespace prgPMR
{
    public partial class ImmunizationDetailControl : MedicalControl
    {


        // Flag to show whether Add or Edit button was clicked
        // *** THIS FLAG WILL BE PASSED FROM PREVIOUS DataGrid
        private bool isAddDetailControl=false;
           
        // Flag that gets set if any of the UserDataControls on the form are modified
        private bool isUserDataControlsModified = false;

        public ImmunizationDetailControl(ControlManager m) : base(m)
        {
            InitializeComponent();

            // Call method that attaches event handlers to User Data Controls for when they are modified by user so flag can be set
            AttachEventHandlerstoUserDataControls();
        }

        public override void PanelLoad()
        {
            if (isAddDetailControl)
            {
                // Detailed form was called to "Add" a record/  Set the lowerbuttonBar for "Add"
                SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Add], [null, null, null, Cancel, Save, Refresh, Back]);

                // Call method to clear all TextBoxes, ComboBoxes and RichTextBoxes
                ClearAllUserDataControls();

                // **** DELETE THIS CODE ONCE TESTED ***
                MessageBox.Show("Add Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Detailed form was called to "Edit" a record.  Set the lowerbuttonBar for "Edit"
                SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Edit], [null, null, Delete, Cancel, Save, Refresh, Back]);

                // Call method to gather the data from the database for the specific record selected in previous grid
                // STILL NEED TO WRITE THIS METHOD

                
                // Call method to populate all TextBoxes, ComboBoxes and RichTextBoxes
                FillAllUserControls();

                // **** DELETE THIS CODE ONCE TESTED ***
                MessageBox.Show("Edit Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearAllUserDataControls()
        {
            foreach (var c in this.Controls.OfType<TextBox>())
                c.Clear();

            foreach (var c in this.Controls.OfType<ComboBox>())
            {
                c.SelectedIndex = -1;
                c.Text = string.Empty;
            }
            foreach (var c in this.Controls.OfType<RichTextBox>())
            {
                c.Clear();
            }
        }

        private void FillAllUserControls()
        {
            // Utilizes the data record that was retrieved from the database and fills the User Data Controls on the form
            // NEED TO WRITE THIS CODE

            // Fill User Data Controls with dummy data
            txtDetailedName.Text = "This is the detailed name of a drug";
        }

        private void AttachEventHandlerstoUserDataControls()
        {
            // Attaches event handlers to all the UserDataControls so that if the user modifies any of the controls
            // on the form, the method is called to modify the flag indicating a change occured
            cboVaccineName.SelectedIndexChanged += setUserDataControlsModifiedFlag;
            txtDetailedName.TextChanged += setUserDataControlsModifiedFlag;
            dtpDoseDate.TextChanged += setUserDataControlsModifiedFlag;
            cboFacility.SelectedIndexChanged += setUserDataControlsModifiedFlag;
            cboManufacturer.SelectedIndexChanged += setUserDataControlsModifiedFlag;
            txtRXNum.TextChanged += setUserDataControlsModifiedFlag;
            txtNDCNum.TextChanged += setUserDataControlsModifiedFlag;
            txtLotNum.TextChanged += setUserDataControlsModifiedFlag;
            rtxtNotes.TextChanged += setUserDataControlsModifiedFlag;
        }

        private void setUserDataControlsModifiedFlag(object sender, EventArgs e)
        {
            // Sets the flag to true because the user made a change to one of the UserDataControls
            isUserDataControlsModified=true;
        }


        public void Delete()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call method that will delete the specific record from the database
                // STILL NEED TO WRITE THIS CODE

                // **** DELETE THIS CODE ONCE TESTED ***
                MessageBox.Show("Refresh Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Return to the previous control
                Manager.PreviousControl();

            }
            else
            {
                // **** DELETE THIS ENTIRE ELSE CODE ONCE TESTED.  NOT NEEDED BECAUSE YOU DO NOTHING WHEN SELECTED BY USER ***
                MessageBox.Show("You clicked No!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Cancel()
        {
            Manager.PreviousControl();
        }

        public void Save()
        {
            //Manager.NextControl();
        }
        public void Refresh()
        {
            if (isUserDataControlsModified)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear all the data and start over?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ClearAllUserDataControls();
                    MessageBox.Show("Refresh Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // *** ONCE CODE IS TESTED, THIS "else" CODE CAN BE REMOVED BECAUSE NOT NOTHING DONE IF USE ANSWERS NO
                    MessageBox.Show("You clicked No!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void Back()
        {
            if (isUserDataControlsModified)
            {
                DialogResult result = MessageBox.Show("Data has been modified are you sure you want to lose your changes and return to the previous screen?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Manager.PreviousControl();
                    MessageBox.Show("Refresh Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // *** ONCE CODE IS TESTED,DELETE THE MESSAGEBOX
                    MessageBox.Show("You clicked No!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }


        private void btnPDFFile_Click(object sender, EventArgs e)
        {
            // Method will enable the user to add a PDF file to the record
            // *** NEED TO WRITE THIS CODE
        }

        private void VaccinesDetailControl_Load(object sender, EventArgs e)
        {

        }

        private void btnImageFile_Click(object sender, EventArgs e)
        {
            // Method will enable the user to add an Image file to the record
            // *** NEED TO WRITE THIS CODE
        }
    }
}
