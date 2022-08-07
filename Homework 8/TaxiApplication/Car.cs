using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Car : Vehicle, ITaxi
    {
        public Car(string brand, string model, string governmentNumber, double fuelConsumption) : base(governmentNumber, fuelConsumption)
        {
            Brand = brand;
            Model = model;
        }
        public string Brand { get; set; }
        public string Model { get; set; }

        public double GetPriceOfRide()
        {
            return 200.50d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.Surname} made a trip on Car: {Brand} {Model}");
            user.PaymentMethods["Points"].AddMoney(15);
        }
        public override string ToString()
        {
            string information = $"Automobile {Brand} {Model} with government number:{GovernmentNumber} and fuel consuption {FuelComsumption}";
            return information;
        }
    }
}
