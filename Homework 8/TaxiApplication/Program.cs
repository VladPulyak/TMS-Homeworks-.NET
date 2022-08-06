using System;
using System.Collections.Generic;

namespace TaxiApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сделаем реализацию приложения для такси.
            //1 - ая часть(создаём пользователя и способы оплаты)
            //Создать интерфейс IPaymentMethod, в нем создать следующие методы:
            //            -IsPaymentPossible, который принимает double -количество денег необходимое для платежа и возвращает True если платёж возможен и false если денег не хватает. 
            //-MakePayment который принимает double, и отнимает от  денег определённое количество денежных средств(для баллов необходимо будет производить перевод из денег в баллы и отнимать баллы)
            //- AddMoney принимает double и просто пополняет счет(для баллов делать пересчёт).
            //Создать классы Card(банковская карта) , Cash(наличные деньги) , Points(баллы) , которые реализуют IPaymentMethod.
            //Сделать свойства в которых будут храниться деньги, для класса Points сделать свойство в котором будут храниться баллы. 1 балл = 1 / 3 рубля.Снабдить класс Card полем номер карты. 
            //Создать класс User в нем сделать свойства Dictionary<string, IPaymentMethod> paymentMethods(в нем мы будем хранить методы оплаты нашего пользователя) , имя, фамилия, номер телефона. 
            //В конструкторе инциализирлвать свойства, а также добавить создать два метода оплаты Cash(значение денег должно быть получено из конструктора) и Points(изначально должно быть 0 баллов) , эти способы оплаты добавить с ключом "Cash" и "Points" соответственно.
            //Создать методы:
            //TopUpCash, который принимает double и пополняет наличные деньги, 
            //TopUpCard, который принимает string(название карты у пользователя) и количество денег, который пользователь хочет закинуть на карту. 
            //AddCard, который принимает string(название карты с каким она будет храниться у пользователя) и объект Card, который добавляет в словарь карту с ключом.
            //ShowAvailablePaymentMethods()
            //Выводит на консоль информацию о методах оплаты(рекомендую переопредлить to string для это цели).
            //2 - ая часть(создаём таксопарк)
            //1)создать интерфейс ITaxi, который будет содержать следующие методы:
            //            -MakeRide(метод, который принимает объект User, выводит в консоль следующую информацию "<Имя Фамилия пользователя> совершил поездку на <Информация о транспортном средстве, которое совершал поездку>.
            //            - GetPriceOfRide() возвращает тип double стоимость поездке(просто верните какое - нибудь произвольно число).
            //            Создать класс Vehicle, в нем создать свойства потребление топлива и гос номер.
            //            Создать классы Car, Helicopter, Motorbike, которые реализуют интерфейс ITaxi и наследуются от Vehicle.Снабдить классы эти 3 класса дополнительными свойствами по - вашему усмотрению, сделать конструктор, который проводят иниицализацию этих свойств.
            //            Также переопредлить для этих классов метод ToString().
            //            В main создать Лист из объектов ITaxi.Создать и добавить в этот лист объекты Car, Helicopter, Motorbike.
            //            3 - я часть(меню)
            //            В main после добавления в лист объектов необходимо создать объект класса User
            //            Далее необходимо создать меню
            //            Меню содержит следующие пункты:
            //            1)Добавить карту -пользователь вводит имя с каким он хочет хранить карту в словаре, а также данные для создания карты, далее карта добавляется пользователю.
            //2)Пополнить карту(вводит название карты из словаря и количество денег которые он хочет начислять)
            //3)Совершить поездку
            //Выводиться список доступного транспорта, в виде "<индекс в списке> - <транспорт в виде строке(вызывайте to string)" пользователь выбирает транспорт
            //Затем выводятся доступные способы оплаты пользователя, пользователь вводит название способа оплаты
            //Необходимо проверить хватает ли денег для оплаты
            //Для этого используйте GetPriceOfRide и IsPaymentPossible
            //Если оплата возможна тогда тогда снять деньги и с помощью 
            var taxiPark = new List<ITaxi>()
            {
                new Car("Renault","Duster","1231235",6.7),
                new Motorbike("Green", "Harley", "854940", 7.5),
                new Helicopter("Zvezda",140,"23423432",8.9),
            };
            User user = new User("Vlad", "Pulyak", "46546545");
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
                            Console.WriteLine("Enter card name");
                            string cardName = Console.ReadLine();
                            Console.WriteLine("Enter amount of money");
                            double amountOfMoney = double.Parse(Console.ReadLine());
                            user.TopUpCard(amountOfMoney, cardName);
                            break;
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
                               "2.Top up the card" + Environment.NewLine +
                               "3.Make a trip" + Environment.NewLine +
                               "4.Exit program");
        }
    }
}
