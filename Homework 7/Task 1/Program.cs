using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pill paracetomol = new Pill("Circle", "Paracetomol", 500);
            paracetomol.Print();
            paracetomol.PrintModeOfApplication();
            Salve dolgit = new Salve("Yellow", "Dolgit", 400);
            dolgit.Print();
            dolgit.PrintModeOfApplication();
            Syrop sinekod = new Syrop("Vanilla", "Sinekod", 600);
            sinekod.Print();
            sinekod.PrintModeOfApplication();
            Console.WriteLine("=====================================");
            Medicine[] medicines = new Medicine[]
            {
                paracetomol,
                dolgit,
                sinekod
            };
            foreach(Medicine medicine in medicines)
            {
                medicine.Print();
                medicine.PrintModeOfApplication();
            }
        }
    }
}
