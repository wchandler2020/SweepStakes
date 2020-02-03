using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
    class SweepStakeStackManager : ISweepStakesManager
    {
        Stack<SweepStakes> sweepStakesStakeManager = new Stack<SweepStakes>();

        public SweepStakes GetSweepstakes()
        {
            return sweepStakesStakeManager.Pop();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            sweepStakesStakeManager.Push(sweepStakes);
        }
    }
}
