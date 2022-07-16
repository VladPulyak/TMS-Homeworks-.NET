using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int numC = int.Parse(Console.ReadLine());
            if (numA > 100 && numB > 100)
            {
                Console.WriteLine("Каждое из чисел А и В больше 100");
            }
            if ((numA % 2 == 0 && numB % 2 != 0) || (numA % 2 != 0 && numB % 2 == 0)) //(numA % 2 == 0 ^ numB % 2 == 0)
            {
                Console.WriteLine("Только одно из чисел А и В четное");
            }
            if (numA > 0 || numB > 0)
            {
                Console.WriteLine("Одно из чисел А и В положительное");
            }
            if (numA % 3 == 0 && numB % 3 == 0 && numC % 3 == 0)
            {
                Console.WriteLine("Каждое из чисел А, В, С кратно трем");
            }
            if ((numA < 50 && numB > 50 && numC > 50) || (numA > 50 && numB < 50 && numC > 50) || (numA > 50 && numB > 50 && numC < 50))
            {
                Console.WriteLine("Только одно из чисел А, В и С меньше 50");
            }
            if (numA < 0 || numB < 0 || numC < 0)
            {
                Console.WriteLine("Одно из чисел А, В, С отрицательное");
            }
        }
    }
}