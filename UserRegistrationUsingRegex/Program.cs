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
            UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
            Console.WriteLine(userRegistrationRegex.validateFirstName(firstName));
        }
    }
}
