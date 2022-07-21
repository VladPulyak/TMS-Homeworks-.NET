using System;
using System.Collections.Generic;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine($"Enter {i} element");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Stack<int> stack = new Stack<int>(arr);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
