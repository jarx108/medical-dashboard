using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace prgPMR
{
    public partial class MainForm : Form
    {
        public enum MedicalControlType
        {
            Default,
            FamilyHistory,
            Medications,
            Immunization,
            DoctorVisits,
            Tests,
            Bloodwork,
            Surgeries,
            Hospitalizations
        }

        private Dictionary<MedicalControlType, ControlManager> ControlManagerDict;

        // Declare user information
        public int intUserID;
        public string strUsername = "";
        public string strPassword = "";
        public string strLastname = "";
        public string strFirstname = "";
        public DateTime dtDOB = DateTime.Today;
        public MedicalControlType ActiveMedicalControl = MedicalControlType.Default;

        public MainForm()
        {
            InitializeComponent();
            //Initialize all the buttons at the bottom at of the form
            Button[] buttons = [button0, button1, button2, button3, button4, button5];
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Tag = i;
                
            }

            // Initialize all the User Control Forms


            ControlManagerDict = new Dictionary<MedicalControlType, ControlManager>
            {
                {MedicalControlType.Default, new ControlManager(MedicalControlType.Default, buttons) },
                {MedicalControlType.FamilyHistory, new ControlManager(MedicalControlType.FamilyHistory, buttons) },
                {MedicalControlType.Medications, new ControlManager(MedicalControlType.Medications, buttons) },
                {MedicalControlType.Immunization, new ControlManager(MedicalControlType.Immunization, buttons) },
                {MedicalControlType.DoctorVisits, new ControlManager(MedicalControlType.DoctorVisits, buttons) },
                {MedicalControlType.Tests, new ControlManager(MedicalControlType.Tests, buttons) },
                {MedicalControlType.Bloodwork, new ControlManager(MedicalControlType.Bloodwork, buttons) },
                {MedicalControlType.Surgeries, new ControlManager(MedicalControlType.Surgeries, buttons) },
                {MedicalControlType.Hospitalizations, new ControlManager(MedicalControlType.Hospitalizations, buttons) },
            };
            // Set the panel to be the Default panel and display it
            Disp_Panel(MedicalControlType.Default);

            

            // Assingn the user values from the database to the labels on the form
            lblLastName.Text = "Jangaon";
            lblFirstName.Text = "Estella";
            lblDOB.Text = "04/09/1963";
            lblUsername.Text = "ejangaon";


            //Go through every item in the dictionary and add the sub panel into the main pane
            foreach ((_, ControlManager value) in ControlManagerDict)
            {
                foreach (MedicalControl c in value.MedicalControls)
                {
                    pnlMain.Controls.Add(c);
                }
            }
        }
        private void MainForm_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEditUser_Click(object sender, EventArgs e)
        {

            // Assign the user data from the database that was  put into 
            // user labels as the defaults for the texboxes 
            txtLastName.Text = lblLastName.Text;
            txtFirstName.Text = lblFirstName.Text;
            txtDOB.Text = lblDOB.Text;
            txtUsername.Text = lblUsername.Text;

            // Turn the display into Edit mode
            Disp_User(1);
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            // Return the display to View mode
            Disp_User(0);
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //Update the fields in the database
            // ****** code goes here *******


            // Copy the edited textbox info to the labels
            lblLastName.Text = txtLastName.Text;
            lblFirstName.Text = txtFirstName.Text;
            lblDOB.Text = txtDOB.Text;
            lblUsername.Text = txtUsername.Text;

            // Return the display to View mode with the new labels
            Disp_User(0);
        }



        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Disp_User(int intChoice)
        {
            // Set the panel to be the default
            Disp_Panel(MedicalControlType.Default);

            if (intChoice == 1)
            {
                // Setup the Userbox for Editing of user information

                // Make the  text boxes visible
                txtLastName.Visible = true;
                txtFirstName.Visible = true;
                txtDOB.Visible = true;
                txtUsername.Visible = true;

                // Hide the user labels
                lblLastName.Visible = false;
                lblFirstName.Visible = false;
                lblDOB.Visible = false;
                lblUsername.Visible = false;

                // Make the Cancel and Save button visible
                btnCancelUser.Visible = true;
                btnSaveUser.Visible = true;

                // Hide the Edit and Delete buttons
                btnEditUser.Visible = false;
                btnDeleteUser.Visible = false;

                // Hide the Change Password button
                bntChangePW.Visible = false;

                // Hide the Menu Panel
                pnlMenu.Visible = false;
            }
            else
            {
                // Setup the Userbox for Display only of user information

                // Hide the text boxes since not editing
                txtLastName.Visible = false;
                txtFirstName.Visible = false;
                txtDOB.Visible = false;
                txtUsername.Visible = false;

                // Make the user labels visible
                lblLastName.Visible = true;
                lblFirstName.Visible = true;
                lblDOB.Visible = true;
                lblUsername.Visible = true;

                // Hide the Cancel and Save button
                btnCancelUser.Visible = false;
                btnSaveUser.Visible = false;

                // Make the Edit and Delete buttons visible
                btnEditUser.Visible = true;
                btnDeleteUser.Visible = true;

                //Make the Change Password button visible
                bntChangePW.Visible = true;

                // Make the Menu Panel visible
                pnlMenu.Visible = true;


            }
        }
       //Method that makes the visible, the panel of the selected medical type
        private void Disp_Panel(MedicalControlType panelChoice)
        {
            //Loop through all the items in the ControManagerDict dictionary
            foreach ((MedicalControlType key, ControlManager value) in ControlManagerDict)
            {
                //If the panelChoice that was passed through the method matches the item in the dictionary
                if (panelChoice == key)
                {
                    //call the method in ControlManger to make the panel visible
                    value.SetVisible(true);
                }
                else
                {
                    //call the method in ControlManger to hide the panel
                    value.SetVisible(false);
                }
            }
        }

        private void btnFamMedHistory_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.FamilyHistory);
            ActiveMedicalControl = MedicalControlType.FamilyHistory;
        }
        private void btnMedications_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Medications);
            ActiveMedicalControl = MedicalControlType.Medications;
        }

        private void btnImmunization_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Immunization);
            ActiveMedicalControl = MedicalControlType.Immunization;
        }
        private void btnDoctorVisits_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.DoctorVisits);
            ActiveMedicalControl = MedicalControlType.DoctorVisits;
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Tests);
            ActiveMedicalControl = MedicalControlType.Tests;
        }

        private void btnBloodwork_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Bloodwork);
            ActiveMedicalControl = MedicalControlType.Bloodwork;
        }

        private void btnSurgeries_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Surgeries);
            ActiveMedicalControl = MedicalControlType.Surgeries;
        }
        private void btnHospital_Click(object sender, EventArgs e)
        {
            Disp_Panel(MedicalControlType.Hospitalizations);
            ActiveMedicalControl = MedicalControlType.Hospitalizations;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ControlManagerDict[ActiveMedicalControl].ClickButton(5);
        }
    }
}
