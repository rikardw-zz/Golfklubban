using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Player
    {
        public int golfId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool sex { get; set; }
        public string address { get; set; }
        public string streetNumber { get; set; }
        public int zipCode { get; set; }
        public string eMail { get; set; }
        public string mobilePhone { get; set; }        
        public int membershipStatus { get; set; }
        public double handicap { get; set; }
        public bool membershipFee { get; set; }
        public int teamId { get; set; }
        public int coupleId {get; set; }

        public override string ToString()
        {
            return firstName + " " + lastName;            
        }
    }   
}
