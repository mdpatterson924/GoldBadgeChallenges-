using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Challenge
{
   public class InsuranceRepository
    {
        List<Driver> _driverList = new List<Driver>();

        public void CreateNewDriver(Driver driver)
        {
            _driverList.Add(driver);
        }
        public List<Driver> GetDriverList()
        {
            return _driverList;
        }
        public void RemoveDriver(Driver driver)
        {
            _driverList.Remove(driver);
        }
    }
}
