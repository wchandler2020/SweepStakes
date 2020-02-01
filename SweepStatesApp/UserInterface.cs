using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
    class UserInterface
    {
        public void Greeting()
        {
            

            Console.WriteLine("Hello, Welcome to PCH, where you Could Win a Life-Changing cash and prizes!");
            Console.WriteLine("What is your first name?");
            string useFIrstName = Console.ReadLine();
            Console.WriteLine("What is your first name?");
            string userLastName = Console.ReadLine();
            Console.WriteLine($"Helo {useFIrstName} {userLastName} please enter an email address?");
            string userEmail = Console.ReadLine();
        }
    }
}
