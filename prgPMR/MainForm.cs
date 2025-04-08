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
            Hospitalization,
            UpdateUserInfo
        }

        // Declare a dictionary "ControManagerDict" consiting of a "MedicalControlType" and a "ControlManager"
        private readonly Dictionary<MedicalControlType, ControlManager> ControlManagerDict;

        // Declare a dictionary "ControlButtonDict" consisting of a "MedicalControlType" and a single button
        private readonly Dictionary<MedicalControlType, Button> ControlButtonDict;

        // Declare variable "ActiveMedicalControl" of type "MedicalControlType" and assign
        // it to the type of "MedicalControlType.Default"
        public MedicalControlType ActiveMedicalControl = MedicalControlType.Default;

        public MainForm()
        {
            InitializeComponent();

            // Create and initialize "lowerbuttonBar" with the  Winform names for each button
            Button[] lowerbuttonBar = [btnAction0, btnAction1, btnAction2, btnAction3, btnAction4, btnAction5];

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
                {MedicalControlType.UpdateUserInfo, btnUpdateUserInfo }
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

                // DetailAdd to the dictionary "ControManagerDict", a new item with 
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

            // Populate text boxes with User data
            // *** WRITE CODE HERE TO GET USER DATA TO FILL INTO USER INFO
            // *** USING DUMMY DATA UNTIL DB IS IN PLACE
            txtLastName.Text = "Jangaon";
            txtFirstName.Text = "Estella";
            txtDOB.Text = "04/09/1963";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
