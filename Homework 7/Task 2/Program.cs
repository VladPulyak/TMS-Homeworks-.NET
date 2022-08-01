using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numerator and denominator of first fraction");
            Fraction fraction1 = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            int nod = fraction1.Nod(fraction1);
            if (nod != 0)
            {
                fraction1.Numerator = fraction1.Numerator / nod;
                fraction1.Denominator = fraction1.Denominator / nod;
            }
            fraction1.Print();
            Console.WriteLine("Enter numerator and denominator of second fraction");
            Fraction fraction2 = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            nod = fraction2.Nod(fraction2);
            if (nod != 0)
            {
                fraction2.Numerator = fraction2.Numerator / nod;
                fraction2.Denominator = fraction2.Denominator / nod;
            }
            fraction2.Print();
            Fraction result = new Fraction();
            result = Fraction.Sum(fraction1, fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Difference(fraction1, fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Multiply(fraction1, fraction2);
            result.Print();
            result.PrintInDecimal();
            result = Fraction.Divide(fraction1, fraction2);
            result.Print();
            result.PrintInDecimal();
        }
    }
}
