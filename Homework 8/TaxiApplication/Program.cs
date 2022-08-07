using System;
using System.Collections.Generic;

namespace TaxiApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taxiPark = new List<ITaxi>()
            {
                new Car("Renault","Duster","1231235",6.7),
                new Motorbike("Green", "Harley", "854940", 7.5),
                new Helicopter("Zvezda",140,"23423432",8.9),
            };
            User user = new User("Vlad", "Pulyak", "46546545",10000);
            int action = 0;
            while (action != 4)
            {
                Menu();
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter card name");
                            string cardName = Console.ReadLine();
                            Console.WriteLine("Enter amount of money and card number");
                            double amountOfMoney = double.Parse(Console.ReadLine());
                            string cardNumber = Console.ReadLine();
                            user.AddCard(cardName, new Card() { AmountOfMoney = amountOfMoney, CardNumber = cardNumber });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter card name or Cash");
                            string cardNameOrCash = Console.ReadLine();
                            if (cardNameOrCash == "Points")
                            {
                                Console.WriteLine("You cannot top up points");
                                break;
                            }
                            Console.WriteLine("Enter amount of money");
                            double amountOfMoney = double.Parse(Console.ReadLine());
                            if (cardNameOrCash == "Cash")
                            {
                                user.TopUpCash(amountOfMoney);
                                break;
                            }
                            else
                            {
                                user.TopUpCard(amountOfMoney, cardNameOrCash);
                                break;
                            }
                        }
                    case 3:
                        {
                            int counter = 1;
                            foreach (var vehicles in taxiPark)
                            {
                                Console.WriteLine($"{counter}. {vehicles.ToString()}");
                                counter++;
                            }
                            Console.WriteLine("Enter number of preffered vehicle");
                            int numberOfVehicle = int.Parse(Console.ReadLine());
                            double priceOnEnteredVehicle = taxiPark[numberOfVehicle - 1].GetPriceOfRide();
                            Console.WriteLine("Enter name of payement method");
                            Console.WriteLine(user.ToString());
                            string nameOfPaymentMethod = Console.ReadLine();
                            if (user.PaymentMethods[nameOfPaymentMethod].IsPaymentPossible(priceOnEnteredVehicle))
                            {
                                user.PaymentMethods[nameOfPaymentMethod].MakePayment(priceOnEnteredVehicle);
                                taxiPark[numberOfVehicle - 1].MakeRide(user);
                            }
                            else
                            {
                                Console.WriteLine("You have not enough money on this type of vehicle");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You exit program");
                            break;
                        }
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine(@"1.Add new card " + Environment.NewLine +
                               "2.Top up the card or cash" + Environment.NewLine +
                               "3.Make a trip" + Environment.NewLine +
                               "4.Exit program");
        }
    }
}
