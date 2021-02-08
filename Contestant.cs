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
        string firstName;
        string lastName;
        string email;
        int regerstrationNumber;
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
