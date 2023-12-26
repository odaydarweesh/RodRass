using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Layer.Exceptions
{
    public class ErrorHandler
    {
        public static void ManageErrors(Exception ex)
        {
            if (ex.GetType() == typeof(ValidationException))
            {
                MessageBox.Show(ex.Message, "ValidationError", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ex.Message, "Something wrong!", MessageBoxButtons.OK);
            }
        }
    }
}
