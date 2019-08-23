using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager:Isweepstakesmanager
    {
        //member var 
        Stack<Sweepstakes> stackmanager = new Stack<Sweepstakes>();

        //ctor
        public SweepstakesStackManager()
        {
                
        }

        public Sweepstakes GetSweepstakes()
        {
            return stackmanager.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stackmanager.Push(sweepstakes);
        }




        // members methods
    }
}
