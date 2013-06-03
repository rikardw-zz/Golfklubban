using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Competition
    {
        public int competitionId { get; set; }
        public string competitionName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime lastBookingDate { get; set; }
        public DateTime lastUnbookingDate { get; set; }
        public double classA { get; set; }
        public double classB { get; set; }
        public double classC { get; set; }
    }
}
