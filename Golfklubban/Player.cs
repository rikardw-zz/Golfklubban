using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Player
    {
        public int golfId { get; set; }
        public string foreName { get; set; }
        public string lastName { get; set; }
        public bool sex { get; set; }
        public string adress { get; set; }
        public string streetNumber { get; set; }
        public int postalNumber { get; set; }
        public string eMail { get; set; }
        public string mobilePhone { get; set; }        
        public int membershipStatus { get; set; }
        public double handicap { get; set; }
        public bool membershipFee { get; set; }
        
    }
}
