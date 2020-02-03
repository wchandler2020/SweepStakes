using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
   static class UserInterface
    {
        public static void Greeting()
        {
            Console.WriteLine("Hello, Welcome to PCH, where you Could Win a Life-Changing cash and prizes!");
            
        }

        public static string SetUserFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string SetUserLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string SetUserEmail()
        {
            Console.WriteLine("Please provide an email address.");
            return Console.ReadLine();
        }

        public static void SetUserRegisterNum()
        {
            Random random = new Random();
            int userRegistrationNumber = random.Next(999999);
            Console.WriteLine($"Congratulations, your registered number is: {userRegistrationNumber}");
        }
    }
}
