using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    public class UserRegistration
    {
        private string message;
        UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
        /// <summary>
        /// Default ConstructorInitializes a new instance of the <see cref="UserRegistration"/> class.
        /// </summary>
        public UserRegistration()
        {
        }
        /// <summary>
        /// Parameterized Constructor Initializes a new instance of the <see cref="UserRegistration"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public UserRegistration(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Checks for first name.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition</returns>
        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks for last name.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition</returns>
        public string checkForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks for email.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition</returns>
        public string checkForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks for mobile.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition</returns>
        public string checkForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks for password.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition </returns>
        public string checkForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks the multiple entries of email.
        /// </summary>
        /// <param name="email1">The email1.</param>
        /// <param name="email2">The email2.</param>
        /// <param name="email3">The email3.</param>
        /// <param name="email4">The email4.</param>
        /// <returns></returns>
        public string checkMultipleEntriesOfEmail(string emails)
        {
            bool emailForEntry1 = userRegistrationRegex.validateEmail(emails);
            if (emailForEntry1 == true)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        /// <summary>
        /// Checks the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <exception cref="UserRegistrationException">Invalid First Name Format</exception>
        public void checkFirstName(string firstName)
        {
            if (userRegistrationRegex.validateFirstName(firstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name Format");
            }
        }
        /// <summary>
        /// Checks the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="UserRegistrationException">Invalid Last Name Format</exception>
        public void checkLastName(string lastName)
        {
            if (userRegistrationRegex.validateLastName(lastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name Format");
            }
        }
        /// <summary>
        /// Checks the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <exception cref="UserRegistrationException">Invalid Email Format</exception>
        public void checkEmail(string email)
        {
            if (userRegistrationRegex.validateEmail(email))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email Format");
            }
        }
        /// <summary>
        /// Checks the mobile.
        /// </summary>
        /// <param name="mobileFormat">The mobile format.</param>
        /// <exception cref="UserRegistrationException">Invalid Mobile Number Format</exception>
        public void checkMobile(string mobileFormat)
        {
            if (userRegistrationRegex.validateMobileFormat(mobileFormat))
            {
                Console.WriteLine("mobile format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number Format");
            }
        }
        /// <summary>
        /// Checks the password.
        /// </summary>
        /// <param name="preDefinedPassword">The pre defined password.</param>
        /// <exception cref="UserRegistrationException">Invalid Password Format</exception>
        public void checkPassword(string preDefinedPassword)
        {
            if (userRegistrationRegex.validatePreDefinedPassword(preDefinedPassword))
            {
                Console.WriteLine("password format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password Format");
            }
        }
    }
}
