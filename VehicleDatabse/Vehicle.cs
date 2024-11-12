using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDatabse
{
    internal class Vehicle
    {
        public int vehicleNumber;
        public string registration;
        public string wheels;
        public double weight;

        public void VehicleInfo(string registration, string wheels, double weight)
        {
            registration = null;
            wheels = null;
            weight = 0;
        }
    }
}
