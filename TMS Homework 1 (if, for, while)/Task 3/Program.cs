using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int result = 0;
            if (count == 1)
            {
                Console.WriteLine(result);
            }
            else
            {
                for (int i = 1; i < count; i++)
                {
                    result += (distanceM) * 100 + widthCm;
                }
                Console.WriteLine(result - widthCm);
            }
        }
    }
}
