using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodeCheck
{
    class Pattern
    {
        public static string REGEX_PINCODE = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";//400088
        public bool validatePincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
