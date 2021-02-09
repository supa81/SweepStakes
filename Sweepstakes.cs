using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
   public  class Sweepstakes
    {
        //MV
        public string name;
        Dictionary<int, Contestant> contestants;


        //ctor 
         Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;       
        }

        //MM
  
        void RegisterContestant(Contestant contestant)
       {
            Random random = new Random();
            random.Next(1, 100);
            contestants.Add(contestant.regerstrationNumber, contestant);
            foreach (int key in contestants.Keys)
            {
                contestant.regerstrationNumber = random.Next(key);
            }
       }
         Contestant PickWinner()
        {

            return null;
        }
        void PrintContestantInfo(Contestant contestant)
       {

            Console.WriteLine($"First Name: {1}, Last Name: {2}, Email: {3}, reg number: {4}," ,contestant.firstName, contestant.lastName, contestant.email,contestant.regerstrationNumber);
            
       }


    }
}
