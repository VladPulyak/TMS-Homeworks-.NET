using System;
namespace Task_1
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
            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2) 
            {
                sum += arr[i];
            }
            int temp = 0;
            Console.WriteLine(sum);
            for (int i = 0; i< size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j]) 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Min element: {arr[0]}");
        }
    }
}
