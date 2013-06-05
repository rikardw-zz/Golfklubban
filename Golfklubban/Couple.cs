using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Couple
    {
        public int coupleId { get; set; }
        public string coupleName { get; set; }

        public override string ToString()
        {
            return coupleName;
        }
    }
}
