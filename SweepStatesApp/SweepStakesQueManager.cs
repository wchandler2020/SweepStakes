using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
    class SweepStakesQueueManager : ISweepStakesManager
    {
        Queue<SweepStakes> sweepStakesQueueManager = new Queue<SweepStakes>();

        public SweepStakes GetSweepstakes()
        {
            return sweepStakesQueueManager.Dequeue();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            sweepStakesQueueManager.Enqueue(sweepStakes);
        }
    }
}
