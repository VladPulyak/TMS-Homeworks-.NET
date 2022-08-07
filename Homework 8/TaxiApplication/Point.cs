using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class Point : IPaymentMethod
    {
        //public Point()
        //{

        //}
        //public Point(double amountOfMoney)
        //{
        //    AmountOfMoney = amountOfMoney;
        //    AmountOfPoints = 0;
        //}
        public double AmountOfPoints { get; set; }
        public double AmountOfMoney { get; set; }
        public void AddMoney(double countOfMoney)
        {
            AmountOfMoney = AmountOfMoney + countOfMoney;
            AmountOfPoints = AmountOfPoints + countOfMoney / 3;
        }

        public bool IsPaymentPossible(double countOfMoney)
        {
            countOfMoney /= 3;
            if (AmountOfPoints < countOfMoney)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakePayment(double countOfPoints)
        {
            countOfPoints /= 3;
            if (AmountOfPoints < countOfPoints)
            {
                Console.WriteLine($"Lack {countOfPoints - AmountOfPoints} points");
            }
            else
            {
                AmountOfPoints = AmountOfPoints - countOfPoints;
                AmountOfMoney = AmountOfMoney - AmountOfPoints * 3;
            }
        }
        public double Print()
        {
            return AmountOfPoints;
        }
    }
}
