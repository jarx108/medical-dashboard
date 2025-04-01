namespace prgPMR
{
    public partial class MainForm : Form
    {
        // Enumerated list of types of medical controls
        public enum MedicalControlType
        {
            Default,
            FamilyHistory,
            Medication,
            Immunization,
            DoctorVisit,
            Test,
            Bloodwork,
            Surgery,
            Hospitalization
        }

        // Declare a dictionary "ControManagerDict" consiting of a "MedicalControlType" and a "ControlManager"
        private readonly Dictionary<MedicalControlType, ControlManager> ControlManagerDict;

        // Declare a dictionary "ControlButtonDict" consisting of a "MedicalControlType" and a single button
        private readonly Dictionary<MedicalControlType, Button> ControlButtonDict;

        // Declare user information
        public int intUserID;
        public string strUsername = "";
        public string strPassword = "";
        public string strLastname = "";
        public string strFirstname = "";
        public DateTime dtDOB = DateTime.Today;

        // Declare variable "ActiveMedicalControl" of type "MedicalControlType" and assign
        // it to the type of "medicalControlType.Default"
        public MedicalControlType ActiveMedicalControl = MedicalControlType.Default;

        public MainForm()
        {
            InitializeComponent();

            // Create and initialize "lowerbuttonBar" with the  Winform names for each button
            // at the bottom of the form
            Button[] lowerbuttonBar = [btnAction0, btnAction1, btnAction2, btnAction3, btnAction4, btnAction5, btnAction6];






            // Create dictionary "ControlButtonDict" and map MedicalControlType to their corresponding
            // Winform names for each button on the side menu panel
            // Note: There is no line item for default since there is no menu selection for "default"
            //        on the left panel
            ControlButtonDict = new Dictionary<MedicalControlType, Button> 
            {
                {MedicalControlType.FamilyHistory, btnFamilyHistory },
                {MedicalControlType.Medication, btnMedication },
                {MedicalControlType.Immunization, btnImmunization },
                {MedicalControlType.DoctorVisit, btnDoctorVisit },
                {MedicalControlType.Test, btnMedicalTest },
                {MedicalControlType.Bloodwork, btnBloodwork },
                {MedicalControlType.Surgery, btnSurgery },
                {MedicalControlType.Hospitalization, btnHospitalization },
            };
            
            // For all the buttons in the array "lowerbuttonBar", change the tag for that button
            // to be the current index value in the array
            for (int i = 0; i < lowerbuttonBar.Length; i++)
            {
                lowerbuttonBar[i].Tag = i;
            }

            // Go through the entire "ControlButtonDict" dictionary and for each "MedicalControlType"
            // change the tag for that button to the current "MedicalControlType" in the loop
            foreach ((MedicalControlType type, Button b) in ControlButtonDict)
            {
                b.Tag = type;
            }

            // Create a new "ControlManagerDict"
            ControlManagerDict = [];

            // Go through the entire "MedicalControlType" enumeration and for each "MedicalControlType"
            // assign the "MedicalControlType" to "type" and then execute the rest of the loop
            foreach (MedicalControlType type in Enum.GetValues<MedicalControlType>())
            {
                // Create a new "ControlManager" called "m"
                ControlManager m = new(type, lowerbuttonBar);

                // Add to the dictionary "ControManagerDict", a new item with 
                // "MedicalControlType" value of "type" and "ControlManager" instance of "m"
                ControlManagerDict.Add(type, m);

                //Go through every item in the dictionary and add the sub panel into the main pane
                foreach (MedicalControl c in m.MedicalControls)
                {
                    pnlMain.Controls.Add(c);
                }
            }

            // Set the panel to be the Default panel and display it
            DisplayMedicalControl(MedicalControlType.Default);


            // Assign the user values from the database to the labels on the form
            // *** Using dummy values until the database in is place ***
            lblLastName.Text = "Jangaon";
            lblFirstName.Text = "Estella";
            lblDOB.Text = "04/09/1963";
            lblUsername.Text = "ejangaon";
        }

        private void MainForm_Load(object sender, EventArgs e)
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
            txtLastName.Text = "Jangaon";
            txtLastName.ReadOnly = true;
            txtFirstName.Text = "Estella";
            txtFirstName.ReadOnly = true;
            txtDOB.Text = "04/09/1963";
            txtDOB.ReadOnly = true;
            txtUsername.Text = "ejangaon";
            txtUsername.ReadOnly = true;


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
            txtLastName.Text = "Jangaon";
            txtLastName.ReadOnly = false;
            txtFirstName.Text = "Estella";
            txtFirstName.ReadOnly = false;
            txtDOB.Text = "04/09/1963";
            txtDOB.ReadOnly = false;
            txtUsername.Text = "ejangaon";
            txtUsername.ReadOnly = false;

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

                // Hide the Edit and Delete lowerbuttonBar
                btnEditUser.Visible = false;
                btnDeleteUser.Visible = false;

                // Hide the Change Password button
                btnChangePW.Visible = false;

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

                // Make the Edit and Delete lowerbuttonBar visible
                btnEditUser.Visible = true;
                btnDeleteUser.Visible = true;

                //Make the Change Password button visible
                btnChangePW.Visible = true;

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
            ControlManagerDict[ActiveMedicalControl].ButtonClicked((int)b.Tag);
        }
    }
}
