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
        private readonly Timer clickTimer;
        private bool DoubleClickTriggered=false;  // flag to determine if Click or DoubleClick was triggered

        private Dictionary<LowerbuttonBarPresetGrouping, Action[]> lowerbuttonBarPresetActionDict;

        private int CurrentRow=0, CurrentColumn=0;
        
        public ImmunizationControl(ControlManager m) : base(m)
        {
            InitializeComponent();

            clickTimer = new Timer();
            clickTimer.Interval = SystemInformation.DoubleClickTime; // Match the system's double-click time
            clickTimer.Tick += ClickTimer_Tick;

            lowerbuttonBarPresetActionDict = new Dictionary<LowerbuttonBarPresetGrouping, Action[]>
            {
                {LowerbuttonBarPresetGrouping.GridInitial,[Add, null, null, Reset, null, null] },
                {LowerbuttonBarPresetGrouping.GridSelect,[Add, Edit, Delete, Reset, null, null] },
                {LowerbuttonBarPresetGrouping.GridMultiSelect,[null, null, Delete, Reset, null, null] },
            };
            InitializeGrid();
        }

        public override void DataLoad(DataInterface? data)
        {
            if (data == null)
            {
                InitializeGrid();
            }
            else
            {
                throw new ArgumentException("Bad Immunization Data");
            }
        }
        public void Add()
        {
            Manager.NextControl(new ImmunizationAddData("test"));
        }

        public void Edit()
        {
            Manager.NextControl(new ImmunizationEditData());
        }

        public void Delete()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.GridInitial], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.GridInitial]);

            if (result == DialogResult.Yes)
            {
                // Call method that will delete the specific record from the database
                // STILL NEED TO WRITE THIS CODE

                // **** DELETE THIS CODE ONCE TESTED ***
                MessageBox.Show("Delete Function Completed", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Reset();
            }
        }


        public void Reset() 
        {
            // Reset all the buttons and refresh the data in the grid
            ImmunizationDataGrid.CurrentCell = null;
            SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.GridInitial], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.GridInitial]);
        }

        private void InitializeGrid()
        {
            ImmunizationDataGrid.CurrentCell = null;
            SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.GridInitial], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.GridInitial]);

            // Define new DataTable called "dt"
            DataTable dt = new();

            // DetailAdd 1st four column definitions into the data table
            dt.Columns.Add("Vaccine", typeof(string));
            dt.Columns.Add("VaccineGroup", typeof(string));
            dt.Columns.Add("DateLastDose", typeof(DateOnly));
            dt.Columns.Add("TotalNumDoses", typeof(int));
            dt.Columns.Add("DateDose1", typeof(DateOnly));
            dt.Columns.Add("DateDose2", typeof(DateOnly));
            dt.Columns.Add("DateDose3", typeof(DateOnly));
            dt.Columns.Add("DateDose4", typeof(DateOnly));
            dt.Columns.Add("DateDose5", typeof(DateOnly));

            // *** NEED CODE FOR GETTING DATA FROM DATABASE
            // *** USING DUMMY DATA
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
            CurrentColumn = e.ColumnIndex;
            CurrentRow = e.RowIndex;
            if (CurrentRow >= 0 && CurrentColumn >= 4)
            {
                DoubleClickTriggered = false; // set the flag to the default of false - Single Click
                clickTimer.Start(); // Start timer to wait for possible double-click
            }
        }

        // Time interval for DoubleClick exceeded
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
                    // Multiple cells have been selected, change the buttons in the lower bar to GridMultiSelect
                    SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.GridMultiSelect], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.GridMultiSelect]);
                }
                else
                { 
                    // Single cell has been selected, change the buttons in the lower bar to GridSelect
                    SetButtons(lowerbuttonBarPresetTextsDict[LowerbuttonBarPresetGrouping.GridSelect], lowerbuttonBarPresetActionDict[LowerbuttonBarPresetGrouping.GridSelect]); 
                }
            }
        }

        private void ImmunizationDataGrid_DoubleCellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clickTimer.Stop(); // Stop timer to prevent execution if double-click occurs

            if (CurrentRow >= 0 && CurrentColumn >= 4)
            {
                DoubleClickTriggered = true;

                // *** NEED CODE TO PASS CELL DATA TO IMMUNIZATIONDETAILCONTROL
                Manager.NextControl(new ImmunizationEditData());

            }
        }

    }
}
