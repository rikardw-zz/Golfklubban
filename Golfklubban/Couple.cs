﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Couple
    {
        public int Id { get; set; }
        public string name { get; set; }

        public override string toString()
        {
            return name;
        }
    }
}
