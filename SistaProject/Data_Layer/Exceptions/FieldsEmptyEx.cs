using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class FieldsEmptyEx : Exception
    {
        public void FieldIsEmptyException(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ValidationException("Enter a value in the combo box");
            }
        }
    }
}
