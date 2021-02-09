using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm : ISweepManager
    {

        //MV
        Stack<Sweepstakes> mystack = new Stack<Sweepstakes>();
        Queue<Sweepstakes> myqueue = new Queue<Sweepstakes>();
        Sweepstakes Sweepstakes;
        //CTOR

        //MM
        public void CreateSweepStakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("name");
        }

        public Sweepstakes GetSweepstakes()
        {
            mystack.Pop();
            return myqueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            mystack.Push(sweepstakes);
            myqueue.Enqueue(sweepstakes);
            

        }
    }
}
