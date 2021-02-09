using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepManager
    {
        Stack<Sweepstakes> mystack = new Stack<Sweepstakes>();

        
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

            mystack.Push(sweepstakes);
       

        }
        public Sweepstakes GetSweepstakes()
        {
            return mystack.Pop();
             // need to get a Sweepstakes object from our stack!
        }



    }


}
