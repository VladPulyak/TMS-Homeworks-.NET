using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    internal class User
    {
        private Dictionary<string, IPaymentMethod> _paymentMethods = new Dictionary<string, IPaymentMethod>();
        public User(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;;
            PaymentMethods.Add("Cash", new Cash());
            PaymentMethods.Add("Points", new Point());
        }
        public Dictionary<string, IPaymentMethod> PaymentMethods
        {
            get
            {
                return _paymentMethods;
            }
            set
            {
                _paymentMethods = value;
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public void TopUpCash(double amountOfMoney)
        {
            PaymentMethods["Cash"].AddMoney(amountOfMoney);
            //PaymentMethods["Points"].AddMoney(amountOfMoney);
            Console.WriteLine("Successful!");
        }
        public void TopUpCard(double amountOfMoney, string cardName)
        {
            bool isContainCard = PaymentMethods.ContainsKey(cardName);
            if (isContainCard)
            {
                PaymentMethods[cardName].AddMoney(amountOfMoney);
                //PaymentMethods["Points"].AddMoney(amountOfMoney);
                Console.WriteLine("Successful!");
            }
            else
            {
                Console.WriteLine("Error, you cannot added card");
            }
        }
        public void AddCard(string cardName, Card card)
        {
            PaymentMethods.Add(cardName, card);
            Console.WriteLine("Successful!");
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var method in PaymentMethods)
            {
                stringBuilder.Append($"{method.Key} --- {method.Value.Print()}\n");
            }
            return stringBuilder.ToString();
        }
    }
}
