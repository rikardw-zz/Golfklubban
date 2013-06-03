using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Team
    {
        public int teamId { get; set; }
        public string teamName { get; set; }

        public override string ToString()
        {
            return teamName;
        }
    }
}
