using System;

namespace UserRegistrationUsingRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the user registration problem");
            Console.WriteLine("Enter the first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the valid email = ");
            string email = Console.ReadLine();

            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            Console.WriteLine(userRegistrationRegex.validateFirstName(firstName));
            Console.WriteLine(userRegistrationRegex.validateLastName(lastName));
            Console.WriteLine(userRegistrationRegex.validatEmail(email));
        }
    }
}
