using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgPMR
{
    public partial class MainForm : Form
    {
        public enum UserControlType
        {
            Defualt,
            FamilyHistory,
            Medications,
            Vaccines,
            DoctorVisits,
            Tests,
            Bloodwork,
            Surgeries,
            Hospitalizations
        }
        
        public Dictionary<UserControlType, MedicalControl> MedicalControls;

        // Declare user information
        public int intUserID;
        public string strUsername;
        public string strPassword;
        public string strLastname;
        public string strFirstname;
        public DateTime dtDOB;

        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Assingn the user values from the database to the labels on the form
            lblLastName.Text = "Jangaon";
            lblFirstName.Text = "Estella";
            lblDOB.Text = "04/09/1963";
            lblUsername.Text = "ejangaon";

            // Initialize all the User Control Forms
            MedicalControls = new Dictionary<UserControlType, MedicalControl>{
                {UserControlType.Defualt, new DefualtControl() },
                {UserControlType.FamilyHistory, new FamilyHistoryControl() },
                {UserControlType.Medications, new MedicationsControl() },
                {UserControlType.Vaccines, new VaccinesControl() },
                {UserControlType.DoctorVisits, new DoctorVisitsControl() },
                {UserControlType.Tests, new TestsControl() },
                {UserControlType.Bloodwork, new BloodworkControl() },
                {UserControlType.Surgeries, new SurgeriesControl() },
                {UserControlType.Hospitalizations, new HospitalizationsControl() },
            };

            // Add User Control Forms to the Panel
            foreach ((_, MedicalControl value) in MedicalControls)
            {
                pnlMain.Controls.Add(value);
            }

            // Set the display to View mode with the new labels
            Disp_User(0);

            // Set the panel to be the default
            Disp_Panel(UserControlType.Defualt);
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
            Disp_Panel(UserControlType.Defualt);

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
        private void Disp_Panel(UserControlType panelChoice)
        {
            foreach ((UserControlType key, MedicalControl value) in MedicalControls)
            {
                if (key == panelChoice)
                {
                    value.SetVisible(true);
                }
                else
                {
                    value.SetVisible(false);
                }
            }
        }

        private void btnFamMedHistory_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.FamilyHistory);
        }
        private void btnMedications_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Medications);
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Vaccines);
        }
        private void btnDoctorVisits_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.DoctorVisits);
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Tests);
        }

        private void btnBloodwork_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Bloodwork);
        }

        private void btnSurgeries_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Surgeries);
        }
        private void btnHospital_Click(object sender, EventArgs e)
        {
            Disp_Panel(UserControlType.Hospitalizations);
        }

    }
}
