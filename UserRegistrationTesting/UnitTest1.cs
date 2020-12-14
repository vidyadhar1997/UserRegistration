using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingRegex;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Case for Givens the first name of the message when happy return entry sucessful for.
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        /// <summary>
        /// Test case for given message when sad then return entry unsuccessfull for first name
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForFirstName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        /// <summary>
        /// Test case for given message when happy entry successfull for last name
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        /// <summary>
        /// Test case for given message when sad then return entry unsuccessfull for last name
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForLastName(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        /// <summary>
        /// Test case for given message when happy then entry successfull for email
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }
        /// <summary>
        /// Test case for given message when sad then return entry unsuccessfull for email
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForEmail(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        /// <summary>
        /// Test case for given message when happy then entry successfull for mobile
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is successful");
        }
        /// <summary>
        /// Test case for given message when sad then return entry unsuccessfull for mobile
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForMobile(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        /// <summary>
        /// Test case for given message when happy then entry successfull for password
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }
        /// <summary>
        /// Test case for given message when sad then return entry unsuccessfull for password
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForPassword(string message)
        {
            UserRegistration userRegistration = new UserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        /// <summary>
        /// Givens the parameterized test when validate multiple entries return entry is sucessful.
        /// </summary>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenParameterizedTest_WhenValidateMultipleEntries_ReturnEntryIsSucessful(string emails)
        {
            UserRegistration userRegistration = new UserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail(emails);
            Assert.AreEqual(result, "Entry is successful");
        }
        /// <summary>
        /// Givens the parameterized test when validate multiple entries return entry is Unsuccessful.
        /// </summary>
        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        public void GivenParameterizedTest_WhenInvalidValidateMultipleEntries_ReturnEntryIsUnSucessful(string emails)
        {
            UserRegistration userRegistration = new UserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail(emails);
            Assert.AreEqual(result, "Entry is not successful");
        }
        /// <summary>
        /// Givens the first name when invalid then should throw invalid first name exception.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        [TestMethod]
        [DataRow("dhiraj")]
        public void GivenFirstName_WhenInvalid_ThenShouldThrowInvalidFirstNameException(string firstName)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkFirstName(firstName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid First Name Format", exception.Message);
            }
        }
        /// <summary>
        /// Givens the last name when invalid then should throw invalid last name exception.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        [TestMethod]
        [DataRow("hudge")]
        public void GivenLastName_WhenInvalid_ThenShouldThrowInvalidLastNameException(string lastName)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkLastName(lastName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Last Name Format", exception.Message);
            }
        }
        /// <summary>
        /// Givens the email when invalid then should throw invalid email exception.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@.com.my")]
        public void GivenEmail_WhenInvalid_ThenShouldThrowInvalidEmailException(string email)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkEmail(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Email Format", exception.Message);
            }
        }
        /// <summary>
        /// Givens the mobile format when invalid then should throw invalid mobile format exception.
        /// </summary>
        /// <param name="mobileFormat">The mobile format.</param>
        [TestMethod]
        [DataRow("911 8149713160")]
        public void GivenMobileFormat_WhenInvalid_ThenShouldThrowInvalidMobileFormatException(string mobileFormat)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkMobile(mobileFormat);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Mobile Number Format", exception.Message);
            }
        }
        /// <summary>
        /// Givens the password format when invalid then should throw invalid password format exception.
        /// </summary>
        /// <param name="preDefinedPassword">The pre defined password.</param>
        [TestMethod]
        [DataRow("dhiraj@123")]
        public void GivenPasswordFormat_WhenInvalid_ThenShouldThrowInvalidPasswordFormatException(string preDefinedPassword)
        {
            try
            {
                UserRegistration userRegistration = new UserRegistration();
                userRegistration.checkPassword(preDefinedPassword);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Password Format", exception.Message);
            }
        }
        /// <summary>
        /// Givens the first name whenvalid then should return true using lambda.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        [TestMethod]
        [DataRow("Dhiraj")]
        public void GivenFirstName_Whenvalid_ThenShouldReturnTrueUsingLambda(string firstName)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateFirstName=userRegistrationRegex.isValidFirstName(firstName);
            Assert.AreEqual(true, validateFirstName);
        }
        /// <summary>
        /// Givens the last name when valid then should return true using lambda.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        [TestMethod]
        [DataRow("Hudge")]
        public void GivenLastName_WhenValid_ThenShouldReturnTrueUsingLambda(string lastName)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateLastName = userRegistrationRegex.isValidLastName(lastName);
            Assert.AreEqual(true, validateLastName);
        }
        /// <summary>
        /// Givens the email when valid then should return true using lambda.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        public void GivenEmail_WhenValid_ThenShouldReturnTrueUsingLambda(string email)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateEmail = userRegistrationRegex.isValidEmail(email);
            Assert.AreEqual(true, validateEmail);
        }
        /// <summary>
        /// Givens the mobile format when valid then should return true using lambda.
        /// </summary>
        /// <param name="mobileFormat">The mobile format.</param>
        [TestMethod]
        [DataRow("91 8149713160")]
        public void GivenMobileFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string mobileFormat)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validateMobileFormat = userRegistrationRegex.isValidMobileNumber(mobileFormat);
            Assert.AreEqual(true, validateMobileFormat);
        }
        /// <summary>
        /// Givens the password format when valid then should return true using lambda.
        /// </summary>
        /// <param name="preDefinedPassword">The pre defined password.</param>
        [TestMethod]
        [DataRow("Dhiraj@123")]
        public void GivenPasswordFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string preDefinedPassword)
        {
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            bool validatePassword = userRegistrationRegex.isValidPassword(preDefinedPassword);
            Assert.AreEqual(true, validatePassword);
        }
    }
}
