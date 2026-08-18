using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class ValidateProvider
    {
        public static void ValidateFields(Object sender, CancelEventArgs e, ErrorProvider error, string ErrorMessage)
        {
            Control control = (Control)sender;
            if (string.IsNullOrEmpty(control.Text))
            {
                error.SetError(control, ErrorMessage);
                //preventing focus out the selected control.
                e.Cancel = true;

            }
            else
            {
                error.SetError(control, "");
            }
        }
    }
}
