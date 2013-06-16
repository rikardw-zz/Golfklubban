using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golfklubban
{
    class Maintenance
    {
        public int maintenanceId { get; set; }
        public DateTime maintenanceDate { get; set; }
        public string maintenanceStart { get; set; }
        public string maintenanceEnd { get; set; }

        public override string ToString()
        {
            return maintenanceDate.ToShortDateString() + " " + maintenanceStart + " - " + maintenanceEnd;
        }
    }
}
