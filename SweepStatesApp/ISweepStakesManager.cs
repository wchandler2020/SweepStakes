using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStatesApp
{
   
        interface ISweepStakesManager
        {

        void InsertSweepstakes(SweepStakes sweepStakes);
            SweepStakes GetSweepstakes();
        }
    
}
