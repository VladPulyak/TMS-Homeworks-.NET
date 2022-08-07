using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Helicopter : Vehicle, ITaxi
    {
        public Helicopter(string model, double speed, string governmentNumber, double fuelConsumption) : base(governmentNumber, fuelConsumption)
        {
            Model = model;
            Speed = speed;
        }
        private double _speed;
        public string Model { get; set; }
        public double Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }

        public double GetPriceOfRide()
        {
            return 1000.65d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.Surname} made a trip on Helocopter: {Model} with speed: {Speed}");
            user.PaymentMethods["Points"].AddMoney(15);
        }
        public override string ToString()
        {
            string information = $"Helicopter {Model} with government number:{GovernmentNumber} and fuel consuption {FuelComsumption}";
            return information;
        }
    }
}
