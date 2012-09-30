using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Arbyter
{
    static class ARBAGui
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if an exception occurs, appologise for it then stop the application
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            catch (Exception except)
            {
                ErrorManager.Appologise(except);
            }
        }
    }
}
