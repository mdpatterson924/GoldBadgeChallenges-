using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Challenge
{
   public class Driver
    {
        public string DriverName { get; set; }
        public decimal SpeedViolations { get; set; }
        public decimal SwerveViolations { get; set; }
        public decimal StopViolations { get; set; }
        public decimal ProximityViolations { get; set; }
      
        public Driver(string driverName, decimal speedViolations, decimal swerveViolations, decimal stopViolations, decimal proximityviolations)
        {
            DriverName = driverName;
            SpeedViolations = speedViolations;
            SwerveViolations = swerveViolations;
            StopViolations = stopViolations;
            ProximityViolations = ProximityViolations;
        }
        public Driver()
        {

        }
    }
}
