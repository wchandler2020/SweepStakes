using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
    class SweepStakes
    {
        public string sweepStakesName;
        public int sweepContestantAmount;
        public int winningNum;
        public Dictionary<int, Contestant> SweepStakeName;



        public void CreateContestant(Contestant contestant)
        {
            contestant.firstName = UserInterface.SetUserFirstName();
            contestant.lastName = UserInterface.SetUserLastName();
            contestant.email = UserInterface.SetUserEmail();
            contestant.registrationNumber = UserInterface.SetUserRegisterNum();
        }

        public Contestant PickWinner()
        {
            Contestant defaultContestant = null;
            Random randnumber = new Random();
            winningNum = randnumber.Next(); //????

            foreach (KeyValuePair<int, Contestant> contestant in SweepStakeName)//????
            {
                if (contestant.Key == winningNum)
                {
                    return contestant.Value;
                }
            }
            return defaultContestant;
        }

        public void GetContestantData(Contestant contestant)
            {
                Console.WriteLine($"Contestant's first name: {contestant.firstName} {contestant.lastName}" );
                Console.WriteLine($"Contestant's email address: {contestant.email}");
                Console.WriteLine($"Contestant registration number#: {contestant.registrationNumber}");
            }

        }
}
