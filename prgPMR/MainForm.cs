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

        private readonly Dictionary<MedicalControlType, ControlManager> ControlManagerDict;
        private readonly Dictionary<MedicalControlType, Button> ControlButtonDict;

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
            // Initialize all the buttons at the bottom at of the form
            Button[] buttons = [button0, button1, button2, button3, button4, button5];
            // Map MedicalControlType to there corrisponding buttons
            ControlButtonDict = new Dictionary<MedicalControlType, Button> {
                {MedicalControlType.FamilyHistory, familyHistoryButton },
                {MedicalControlType.Medications, medicationButton },
                {MedicalControlType.Immunization, immunizationButton },
                {MedicalControlType.DoctorVisits, doctorVisitsButton },
                {MedicalControlType.Tests, testsButton },
                {MedicalControlType.Bloodwork, bloodworkButton },
                {MedicalControlType.Surgeries, surgeriesButton },
                {MedicalControlType.Hospitalizations, hospitalizationButton },
            };
            // Change the tag for the button bar buttons to match there index
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Tag = i;
            }
            // Change the tag for Control changing buttons to there given MedicalControlType
            foreach ((MedicalControlType type, Button b) in ControlButtonDict)
            {
                b.Tag = type;
            }

            // Initialize all the User Control Forms
            ControlManagerDict = [];

            foreach (MedicalControlType type in Enum.GetValues<MedicalControlType>())
            {
                ControlManager m = new(type, buttons);
                ControlManagerDict.Add(type, m);

                //Go through every item in the dictionary and add the sub panel into the main pane
                foreach (MedicalControl c in m.MedicalControls)
                {
                    pnlMain.Controls.Add(c);
                }
            }

            // Set the panel to be the Default panel and display it
            DisplayMedicalControl(MedicalControlType.Default);

            

            // Assingn the user values from the database to the labels on the form
            lblLastName.Text = "Jangaon";
            lblFirstName.Text = "Estella";
            lblDOB.Text = "04/09/1963";
            lblUsername.Text = "ejangaon";


            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EditUserButton_Click(object sender, EventArgs e)
        {

            // Assign the user data from the database that was  put into 
            // user labels as the defaults for the texboxes 
            txtLastName.Text = lblLastName.Text;
            txtFirstName.Text = lblFirstName.Text;
            txtDOB.Text = lblDOB.Text;
            txtUsername.Text = lblUsername.Text;

            // Turn the display into Edit mode
            DisplayUser(1);
        }

        private void CancelUserButton_Click(object sender, EventArgs e)
        {
            // Return the display to View mode
            DisplayUser(0);
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            //Update the fields in the database
            // ****** code goes here *******


            // Copy the edited textbox info to the labels
            lblLastName.Text = txtLastName.Text;
            lblFirstName.Text = txtFirstName.Text;
            lblDOB.Text = txtDOB.Text;
            lblUsername.Text = txtUsername.Text;

            // Return the display to View mode with the new labels
            DisplayUser(0);
        }



        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayUser(int intChoice)
        {
            // Set the panel to be the default
            DisplayMedicalControl(MedicalControlType.Default);

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
        private void DisplayMedicalControl(MedicalControlType panelChoice)
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
        // Changes current active MedicalControl to the one that matches the Tag of the button that triggered this event
        private void DisplayControl_Click(object sender, EventArgs e)
        {
            if (sender is not Button b || b.Tag is not MedicalControlType m)
            {
                return;
            }
            DisplayMedicalControl(m);
            ActiveMedicalControl = m;
        }
        // Tells currently active control manager that a button has been pressed corrispoding with the tag of button that triggered this event
        private void ButtonBar_Click(object sender, EventArgs e)
        {
            if (sender is not Button b || b.Tag is not int)
            {
                return;
            }
            ControlManagerDict[ActiveMedicalControl].ClickButton((int)b.Tag);
        }
    }
}
