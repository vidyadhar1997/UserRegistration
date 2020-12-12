using System;
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
        /// <summary>
        /// validateFirstName methode for pattern matching
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns>true or false when it matched/not matched with patterns</returns>
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN); 
        }
        /// <summary>
        /// validateLastName methode for pattern matching
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns>true or false when it matched/not matched with patterns</returns>
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }
        /// <summary>
        /// validateEmail methode for pattern matching
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true or false when it matched/not matched with patterns</returns>
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }
        /// <summary>
        /// validateMobileFormat methode for pattern matching
        /// </summary>
        /// <param name="mobileFormat"></param>
        /// <returns>true or false when it matched/not matched with patterns</returns>
        public bool validateMobileFormat(string mobileFormat)
        {
            return Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        }
        /// <summary>
        /// validatePreDefinedPassword methode for pattern matching
        /// </summary>
        /// <param name="preDefinedPassword"></param>
        /// <returns>true or false when it matched/not matched with patterns</returns>
        public bool validatePreDefinedPassword(string preDefinedPassword)
        {
            return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        }
        /// <summary>
        /// This is by using lambda expression for validating user first,last name and password,
        /// </summary>
        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidLastName = lastName => Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAILPATTERN);
        public Func<string, bool> isValidMobileNumber = mobileFormat => Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        public Func<string, bool> isValidPassword = preDefinedPassword => Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
    }
}
