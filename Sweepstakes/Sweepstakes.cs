using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Sweepstakes
    {
        //member var 
        Sweepstakes sweepstakes = new Sweepstakes();
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();




        //ctor
        public Sweepstakes()
        {
            // example for adding to dictionary
            //Contestant test = new Contestant();
            //contestants.Add(contestants.Count + 1, test);
        }



        // members methods
        private void SweepstakesMethod(string name)
        {

        }
        private void RegisterContestand(Contestant contestant)
        {

        }
        private string PickWinner()
        {
            throw new NotImplementedException();
        }
        private void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
