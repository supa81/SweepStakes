using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        //MEMBER VARIABLES 
        
        public string firstName;
        public string lastName;
        public string email;
        public int regerstrationNumber;
        //SPAWN WITH 
        public Contestant(string firstName, string lastName, string email, int regerstrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.regerstrationNumber = regerstrationNumber;
        }
        //MEMBER METHODS 


    }
}
