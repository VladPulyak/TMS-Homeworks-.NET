using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Card : IPaymentMethod
    {
        private string _cardNumber;
        public double AmountOfMoney { get; set; }

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public void AddMoney(double countOfMoney)
        {
            AmountOfMoney = AmountOfMoney + countOfMoney;
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
                Console.WriteLine($"Lack {countOfMoney - AmountOfMoney} rubles");
                return;
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
