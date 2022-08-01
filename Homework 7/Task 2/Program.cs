using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numerator and denominator of first fraction");
            Fraction fraction = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter numerator and denominator of second fraction");
            Fraction fraction2 = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Fraction result = new Fraction();
            result = Fraction.Sum(fraction,fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Difference(fraction,fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Multiply(fraction, fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Divide(fraction, fraction2);
            result.Print();
            result.PrintInDecimal();
        }
    }
}
