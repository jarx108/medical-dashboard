using Microsoft.Identity.Client;
using prgPMR.Abstraction;
using prgPMR.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    //This line of code is here to overcome the bug in Visual Studio with Form Designer 
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<MedicalControl, UserControl>))]

    public abstract class MedicalControl : UserControl
    {
        // Enumerated list for the buttons
        public enum LowerbuttonBarPresetGrouping
        {
            GridInitial,     // Add,               Reset
            GridSelect,      // Add, Edit, Delete, Reset
            GridMultiSelect, //            Delete, Reset
            DetailAdd,       //                    Reset, Save, Cancel
            DetailEdit       //            Delete, Reset, Save, Cancel
        }

        //  Create a private variable "_buttonText" that is an array of strings
        private string[] _buttonText = [];

        public string[] ButtonsText { get { return _buttonText; } }

        // Create a private instance of "_buttonActions" that is an array of Action delegates
        // An Action delegate is a method with no parameters and no return value
        private Action[] _buttonActions = [];

        public Action[] ButtonActions { get { return _buttonActions; } }

        internal ControlManager Manager { get; }

        public Dictionary<LowerbuttonBarPresetGrouping, string[]> lowerbuttonBarPresetTextsDict;

        public MedicalControl(ControlManager manager)
        {
            Manager = manager;

            // Define dictionary
            lowerbuttonBarPresetTextsDict = new Dictionary<LowerbuttonBarPresetGrouping, string[]>
            {
                {LowerbuttonBarPresetGrouping.GridInitial,["Add", null, null, "Reset", null, null] },
                {LowerbuttonBarPresetGrouping.GridSelect,["Add", "Edit", "Delete", "Reset", null, null] },
                {LowerbuttonBarPresetGrouping.GridMultiSelect,[null, null, "Delete", "Reset", null, null] },
                {LowerbuttonBarPresetGrouping.DetailAdd,[null, null, null, "Reset", "Save", "Cancel"] },
                {LowerbuttonBarPresetGrouping.DetailEdit,[null, null, "Delete", "Reset", "Save", "Cancel"] },
            };
        }

        protected void SetButtons(string[] text, Action[] actions)
        {
            _buttonText = text;
            _buttonActions = actions;

            Debug.Assert(_buttonText.Length == _buttonActions.Length);
            for(int i = 0; i < text.Length; i++)
            {
                Debug.Assert((_buttonText[i] == null) == (_buttonActions[i] == null));
            }
            Manager.RefreshVisibility();
        }

        public virtual void DataLoad(DataInterface? data)
        {

        }
    }
}
