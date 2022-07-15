using System;

namespace TMS_Homework_1__if__for__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Считать число из консоли и вывести на консоль число противоположного знака.
            //Пример до:
            //0: 0
            //1: -1
            //14: -14
            //- 34: 34
            int number = int.Parse(Console.ReadLine());
            int resultNumber = number * (-1);
            Console.WriteLine(resultNumber);
        }
    }
}
