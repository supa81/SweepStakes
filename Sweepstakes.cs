using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        //MV
      


        //ctor 

        //MM
        Sweepstakes(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes("A Legendary Ninja Item");
        }
        void RegisterContestant(Contestant contestant)
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant newContestant = new Contestant("Naruto","Uzumaki","NarutoUzumaki@LeafVillage.com", 1); 
            sweepstakes.RegisterContestant(newContestant)
            
        }
          Contestant PickWinner()
          {
            Sweepstakes sweepstakes = new Sweepstakes("A Legendary Ninja Item");
            Contestant newContestant = new Contestant("Naruto", "Uzumaki", "NarutoUzumaki@LeafVillage.com", 1);
            Contestant expected = newContestant;
            Contestant actual = Sweepstakes.PickWinner(newContestant)
                

          }
        void PrintContestantInfo(Contestant contestant)
        {
            Sweepstakes sweepstakes;
            sweepstakes.PrintContestantInfo(contestant);
    
        }


    }
}
