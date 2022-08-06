using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal interface IPaymentMethod
    {
        public bool IsPaymentPossible(double countOfMoney);
        public void MakePayment(double countOfMoney);
        public void AddMoney(double countOfMoney);
        public double Print();
    }
}
