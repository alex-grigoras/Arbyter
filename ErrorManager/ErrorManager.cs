using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Arbyter
{
    public partial class ErrorManager
    {
        public static void Appologise(Exception e)
        {

            if (e is System.UnauthorizedAccessException)
            {
                MessageBox.Show(ARBAErrorManager.Resources.UnauthorizedAccesAppology,
                            "Sorry",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }

            if( e is System.IO.IOException)
            {
                MessageBox.Show( ARBAErrorManager.Resources.IOExceptionAppology,
                            "Sorry",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(String.Format(ARBAErrorManager.Resources.GenericAppology_ExceptionMessage, e.ToString()),
                            "Sorry",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

   }
}
