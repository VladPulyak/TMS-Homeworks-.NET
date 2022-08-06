using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Vehicle
    {
        public Vehicle(string governmentNumber, double fuelConsumption)
        {
            GovernmentNumber = governmentNumber;
            FuelComsumption = fuelConsumption;
        }
        public string GovernmentNumber { get; set; }
        private double _fuelConsumption;

        public double FuelComsumption
        {
            get { return _fuelConsumption; }
            set
            {
                if (value < 0)
                {
                    _fuelConsumption = 0;
                }
                else
                {
                    _fuelConsumption = value;
                }
            }
        }

    }
}
