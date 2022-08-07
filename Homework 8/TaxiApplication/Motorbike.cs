using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Motorbike : Vehicle, ITaxi
    {
        public Motorbike(string color, string model, string governmentNumber, double fuelConsumption) : base(governmentNumber, fuelConsumption)
        {
            Color = color;
            Model = model;
        }
        public string Color { get; set; }
        public string Model { get; set; }

        public double GetPriceOfRide()
        {
            return 500.00d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.Surname} made a trip on {Color} Motorbike: {Model}");
            user.PaymentMethods["Points"].AddMoney(15);
        }
        public override string ToString()
        {
            string information = $"{Color} motorbike {Model} with government number:{GovernmentNumber} and fuel consuption {FuelComsumption}";
            return information;
        }
    }
}
