using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes 
{
    public class SweepstakesQueueManager : ISweepManager
    {
        Queue<Sweepstakes> myqueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myqueue.Enqueue(sweepstakes);
        }
       public Sweepstakes GetSweepstakes()
       {
           return myqueue.Dequeue();
       }

       
        
    }
}
