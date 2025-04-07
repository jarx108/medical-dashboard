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
using prgPMR.DataObjects;

namespace prgPMR
{
    public partial class ImmunizationDetailControl : MedicalControl
    {
        private bool isUserDataControlsModified = false;

        private Dictionary<LowerbuttonBarPresetGrouping, Action[]> lowerbuttonBarPresetActionDict;

        public ImmunizationDetailControl(ControlManager m) : base(m)
        {
            InitializeComponent();

            // Call method that attaches event handlers to User Data Controls for when they are modified by user so flag can be set
            AttachEventHandlerstoUserDataControls();

            lowerbuttonBarPresetActionDict = new Dictionary<LowerbuttonBarPresetGrouping, Action[]>
            {
                {LowerbuttonBarPresetGrouping.DetailAdd,[null, null, null, Reset, Save, Cancel] },
                {LowerbuttonBarPresetGrouping.DetailEdit,[null, null, Delete, Reset, Save, Cancel] },
            };
        }

        public override void DataLoad(DataInterface? data)
        {
            isUserDataControlsModified = false;
            if(data is ImmunizationAddData aData)
            {
                // Detailed form was called to "DetailAdd" a record/  Set the lowerbuttonBar for "DetailAdd"
                SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.DetailAdd], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.DetailAdd]);

                // Call method to clear all TextBoxes, ComboBoxes and RichTextBoxes
                ClearAllUserDataControls();
            }
            else if(data is ImmunizationEditData eData)
            {
                // Detailed form was called to "DetailEdit" a record.  Set the lowerbuttonBar for "DetailEdit"
                SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.DetailEdit], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.DetailEdit]);

                // Call method to get data from DB and populate all TextBoxes, ComboBoxes and RichTextBoxes
                FillAllUserControls();

                // **** DELETE THIS CODE ONCE TESTED ***
                MessageBox.Show("DetailEdit Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new ArgumentException("Bad Immunization Data");
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
                MessageBox.Show("DetailedDelete Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Return to the previous control
                // *** Need to change the class being passed
                Manager.PreviousControl();

            }
        }

        public void Cancel()
        {
            if (isUserDataControlsModified)
            {
                DialogResult result = MessageBox.Show("Data has been modified.  Are you sure you want to cancel without saving your data?",
                                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Manager.PreviousControl();
                }
            }
        }

        public void Save()
        {
            // *** WRITE THE CODE TO SAVE THE DATA TO THE DATABASE
            MessageBox.Show("Save Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Reset()
        {
            if (isUserDataControlsModified)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear all the data and start over?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ClearAllUserDataControls();
                    MessageBox.Show("Reset Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPDFFile_Click(object sender, EventArgs e)
        {
            // Method will enable the user to add a PDF file to the record
            // *** NEED TO WRITE THIS CODE
        }

        private void btnImageFile_Click(object sender, EventArgs e)
        {
            // Method will enable the user to add an Image file to the record
            // *** NEED TO WRITE THIS CODE
        }
    }
}
