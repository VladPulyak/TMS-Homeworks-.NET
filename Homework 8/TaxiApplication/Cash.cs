using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Cash : IPaymentMethod
    {
        public double AmountOfMoney { get; set; }
        public void AddMoney(double countOfMoney)
        {
            AmountOfMoney = countOfMoney;
        }

        public bool IsPaymentPossible(double countOfMoney)
        {
            if (AmountOfMoney < countOfMoney)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakePayment(double countOfMoney)
        {
            if (AmountOfMoney < countOfMoney)
            {
                Console.WriteLine("Error, you not have enough money");
            }
            else
            {
                AmountOfMoney = AmountOfMoney - countOfMoney;
            }
        }
        public double Print()
        {
            return AmountOfMoney;
        }
    }
}
