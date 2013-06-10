using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Staff
    {
        public int staffId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string civicRegNr { get; set; }
        public string role { get; set; }
        public string mobilePhone { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
         
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
