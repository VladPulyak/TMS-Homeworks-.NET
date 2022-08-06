using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal interface ITaxi
    {
        public void MakeRide(User user);
        public double GetPriceOfRide();
    }
}
