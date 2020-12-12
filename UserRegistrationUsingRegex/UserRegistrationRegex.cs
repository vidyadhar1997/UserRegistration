﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAILPATTERN = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
        public static string MOBILEPATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORDRULE = "^(?=.*[A-Z])(?=.*[@#$%&*!_.-=])(?=.*[0-9])[a-zA-Z0-9].{8,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN); 
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }
        public bool validateMobileFormat(string mobileFormat)
        {
            return Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        }
        public bool validatePreDefinedPassword(string preDefinedPassword)
        {
            return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        }
    }
}
