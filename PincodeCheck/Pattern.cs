using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodeCheck
{
    class Pattern
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";//400088
        public bool validatePincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
