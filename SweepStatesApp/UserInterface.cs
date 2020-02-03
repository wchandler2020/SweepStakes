using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
   static class UserInterface
    {
        public static int registrationNumber;
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

        public static int SetUserRegisterNum()
        {
            registrationNumber += 1;
            Console.WriteLine($"Your registered number is: {registrationNumber}");
            Console.ReadLine();
            return registrationNumber;
        }

        public static void SetContestant()
        {
            Greeting();
            SetUserFirstName();
            SetUserLastName();
            SetUserEmail();
            SetUserRegisterNum();
        }
    }
}
