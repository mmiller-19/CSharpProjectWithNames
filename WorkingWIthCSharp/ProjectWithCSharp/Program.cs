using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            space();


            //First Name
            Console.WriteLine("What is your First Name? ");
            Console.WriteLine("Enter to Continue");
            space();

            string firstName = Console.ReadLine();
            Console.WriteLine("Your First name is: " + firstName);
            space();


            //Last Name
            Console.WriteLine("What is your Last Name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your Last name is: " + lastName);
            space();

            //Full Name
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your Full name is: " + fullName);
            space();
            Console.WriteLine("Press Enter to continue to see how many letters are in your names");
            Console.ReadLine();
            space();
            //Taking spacing out of the full name
            string FullNameNoSpace = firstName + lastName;

            //Counts of the Char in each variable
            Console.WriteLine("You have " + firstName.Length + " letters in your first name");
            Console.WriteLine("You have " + lastName.Length + " letters in your last name");
            Console.WriteLine("You have " + FullNameNoSpace.Length + " letters in your full name");

            Console.ReadLine();
        }
        private static void space()
        {
            Console.WriteLine("");
        }

    }
}
