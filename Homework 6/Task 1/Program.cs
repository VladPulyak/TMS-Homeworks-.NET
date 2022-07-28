using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iPhone = new Phone("+375298961247", "IPhone XS Max", 208);
            Phone samsung = new Phone("+375257891235", "Samsung S8", 168);
            Console.WriteLine(samsung.Model);
            Console.WriteLine(iPhone.Number);
            Console.WriteLine(samsung.Weight);
            samsung.Weight = -56;
            Console.WriteLine(samsung.Weight);
            samsung.RecieveCall("Vlad");
            iPhone.RecieveCall("Kolya");

        }
    }
}
