using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager: Isweepstakesmanager
    {
        //member var 
        
        Queue<Sweepstakes> queuemanger = new Queue<Sweepstakes>();

        //ctor
        public SweepstakesQueueManager()
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            return queuemanger.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queuemanger.Enqueue(sweepstakes);
        }



        // members methods

    }
}
