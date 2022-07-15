using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
