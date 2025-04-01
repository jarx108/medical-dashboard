using prgPMR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prgPMR
{
    static class Program
    {
        /// <summary>
        /// Main designer/developer - Nikoli Cartagena
        /// Co desinger/developer - Estella Jangaon (novice/learner)
        /// 
        /// The main entry point for the application.
        /// This application is a Medical Records application, that is for a person to be able to 
        /// have all their medicall information locally versus in the cloud with some 3rd party.
        /// 
        /// In addition, a core focus of this application is to help teach someone new to C# and object
        /// oriented programming.  Thus there will be more comments as help aides throughout
        /// the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}