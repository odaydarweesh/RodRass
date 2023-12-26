using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class UrlValidation : Exception
    {
        public void UrlValidationInput(string input)
        {
            if (Uri.IsWellFormedUriString(input, UriKind.Absolute) == false)
            {
                throw new ValidationException("Please enter a valid URL");
            }
        }
    }
}
