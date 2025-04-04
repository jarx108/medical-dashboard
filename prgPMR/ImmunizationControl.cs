using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;
using System.Windows.Forms;
using prgPMR.DataObjects;
using static prgPMR.MedicalControl;
using Timer = System.Windows.Forms.Timer;


namespace prgPMR
{

    public partial class ImmunizationControl : MedicalControl
    {

        private Timer clickTimer;
        private bool DoubleClickTriggered=false;  // flag to determine if Click or DoubleClick was triggered

        public Dictionary<lowerbuttonBarPresetGrouping, Action[]> lowerbuttonBarPresetActionDict;

        
        public ImmunizationControl(ControlManager m) : base(m)
        {
            InitializeComponent();

            clickTimer = new Timer();
            clickTimer.Interval = SystemInformation.DoubleClickTime; // Match the system's double-click time
            clickTimer.Tick += ClickTimer_Tick;

            lowerbuttonBarPresetActionDict = new Dictionary<lowerbuttonBarPresetGrouping, Action[]>
            {
                {lowerbuttonBarPresetGrouping.Initial,[Add, null, null, Reset, null, null] },
                {lowerbuttonBarPresetGrouping.Select,[Add, Edit, Delete, Reset, null, null] },
                {lowerbuttonBarPresetGrouping.MultiSelect,[null, null, Delete, Reset, null, null] },
                {lowerbuttonBarPresetGrouping.Add,[null, null, null, Reset, Save, Cancel] },
                {lowerbuttonBarPresetGrouping.Edit,[null, null, Delete, Reset, Save, Cancel] },
            };

            InitializeGrid();

        }

        public void Add()
        {
            Manager.NextControlWithData(new ImmunizationData(true, false));
            MessageBox.Show("Add Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Edit()
        {
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Edit], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Edit]);
            Manager.NextControlWithData(new ImmunizationData(false, true));
            MessageBox.Show("Edit Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete()
        {
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Initial], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Initial]);
            MessageBox.Show("Delete Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Reset() 
        {
            // Reset all the buttons and refresh the data in the grid
            ImmunizationDataGrid.CurrentCell = null;
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Initial], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Initial]);
            MessageBox.Show("Refresh Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Cancel()
        {
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Initial], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Initial]);
            ImmunizationDataGrid.CurrentCell = null;
            MessageBox.Show("Cancel Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Save()
        {
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Initial], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Initial]);
            MessageBox.Show("Save Function Triggered", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeGrid()
        {
            ImmunizationDataGrid.CurrentCell = null;
            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Initial], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Initial]);

            // Define new DataTable called "dt"
            DataTable dt = new();

            // Add 1st four column definitions into the data table
            dt.Columns.Add("Vaccine", typeof(string));
            dt.Columns.Add("VaccineGroup", typeof(string));
            dt.Columns.Add("DateLastDose", typeof(DateOnly));
            dt.Columns.Add("TotalNumDoses", typeof(int));
            dt.Columns.Add("DateDose1", typeof(DateOnly));
            dt.Columns.Add("DateDose2", typeof(DateOnly));
            dt.Columns.Add("DateDose3", typeof(DateOnly));
            dt.Columns.Add("DateDose4", typeof(DateOnly));
            dt.Columns.Add("DateDose5", typeof(DateOnly));

            // fill the data table with dummy data, replace with appropriate code once database is implemented
            dt.Rows.Add("Tetanus, Diptheria, Pertussis", "Tdap", new DateOnly(2005, 11, 22), 1, new DateOnly(2005, 11, 22), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            dt.Rows.Add("Influenza IIV3 PF", "Influenza", new DateOnly(2024, 8, 27), 5, new DateOnly(2010, 10, 30), new DateOnly(2008, 12, 10), new DateOnly(2007, 12, 6), new DateOnly(2005, 11, 22), new DateOnly(2002, 9, 30));
            dt.Rows.Add("Influenza IIV4", "Influenza", new DateOnly(2023, 10, 4), 2, new DateOnly(2016, 8, 18), new DateOnly(2016, 1, 8), DBNull.Value, DBNull.Value, DBNull.Value);
            dt.Rows.Add("Shingles (Zoster)", "RZV", new DateOnly(2022, 10, 14), 2, new DateOnly(2022, 10, 14), new DateOnly(2022, 6, 29), DBNull.Value, DBNull.Value, DBNull.Value);
            dt.Rows.Add("Measles, Mumps, Rubella", "MMR", DBNull.Value, 1, new DateOnly(1999, 11, 9), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            dt.Rows.Add("Meningococcal B, Fully Recomb (Trumenba)", "MenB-FHbp", DBNull.Value, 3, new DateOnly(2016, 12, 21), new DateOnly(2016, 8, 18), new DateOnly(2016, 5, 11), DBNull.Value, DBNull.Value);
            dt.Rows.Add("Oral Polio", "OPV", DBNull.Value, 4, new DateOnly(1999, 11, 9), new DateOnly(1995, 11, 14), new DateOnly(1995, 9, 15), new DateOnly(1995, 7, 20), DBNull.Value);
            dt.Rows.Add("Tetanus, Diptheria, Pertussis", "Tdap", DBNull.Value, 2, new DateOnly(2016, 12, 21), new DateOnly(2006, 11, 7), DBNull.Value, DBNull.Value, DBNull.Value);
            dt.Rows.Add("Varicella", "VAR", DBNull.Value, 1, new DateOnly(2009, 8, 19), DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);

            // Initialize the DataGridView
            ImmunizationDataGrid.DataSource = dt;
        }

        // Timer started once the user initiates the SingleClick on the grid
        // SingleClick action code is NOT executed in this method.  Waiting to see
        // if DoubleClick gets triggered
        private void ImmunizationDataGrid_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 4)
            {
                DoubleClickTriggered = false; // set the flag to the default of false - Single Click
                clickTimer.Start(); // Start timer to wait for possible double-click
            }
        }

        // Time interval for DoubleClick exceeded
        // This method runs once DoubleClick timer interval has exceeded
        // Method utilizes the "DoubleCLickTrigged" boolean to determine if Single or Double click was triggered
        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            clickTimer.Stop(); // Stop timer to prevent execution if double-click occurs

            // Perform actions if DoubleClick was not triggered
            if (!DoubleClickTriggered)
            {  
                DoubleClickTriggered = false; // reset the flag to the default of false - Single Click

                if (ImmunizationDataGrid.SelectedCells.Count > 1)
                {
                    // Multiple cells have been selected, change the buttons in the lower bar to MultiSelect
                    SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.MultiSelect], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.MultiSelect]);
                }
                else
                { 
                    // Single cell has been selected, change the buttons in the lower bar to Select
                    SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Select], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Select]); 
                }
            }
        }

        // DoubleClick triggered
        private void ImmunizationDataGrid_DoubleCellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clickTimer.Stop(); // Stop timer to prevent execution if double-click occurs
            DoubleClickTriggered = true;  //set flag to true becasue DoubleClick was triggered

            SetButtons(lowerbuttonBarPresetTextsDict[lowerbuttonBarPresetGrouping.Edit], lowerbuttonBarPresetActionDict[lowerbuttonBarPresetGrouping.Edit]);


            // Code goes here when a DoubleClick was triggered

        }

    }
}
