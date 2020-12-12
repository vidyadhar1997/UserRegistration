using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    public class UserRegistrationException:Exception
    {
        /// <summary>
        /// enum ExceptionType for constants
        /// </summary>
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        /// <summary>
        /// Paramerized Constructor Initializes a new instance of the <see cref="UserRegistrationException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public UserRegistrationException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
