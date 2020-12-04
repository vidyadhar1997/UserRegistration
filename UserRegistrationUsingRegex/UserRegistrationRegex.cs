using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
        public bool validatelastName(String firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
    }
}
