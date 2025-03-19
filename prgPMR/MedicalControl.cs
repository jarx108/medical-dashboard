using Microsoft.Identity.Client;
using prgPMR.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR
{
    //This line of code is here to overcome the bug in Visual Studio with Form Designer 
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<MedicalControl, UserControl>))]
    public abstract class MedicalControl(ControlManager manager) : UserControl
    {

        private string[] _buttonText = [];
        public string[] ButtonsText { get { return _buttonText; } }

        private Action[] _buttonActions = [];
        public Action[] ButtonActions { get { return _buttonActions; } }
        internal ControlManager Manager { get; } = manager;

        protected void SetButtons(string[] text, Action[] actions)
        {
            _buttonText = text;
            _buttonActions = actions;

            Debug.Assert(_buttonText.Length == _buttonActions.Length);
            for(int i = 0; i < text.Length; i++)
                Debug.Assert((_buttonText[i] == null) == (_buttonActions[i] == null));
        }
    }
}
