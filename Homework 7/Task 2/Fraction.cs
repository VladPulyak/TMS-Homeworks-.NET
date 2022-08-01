using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Fraction
    {
        public Fraction()
        {

        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public int Numerator { get; set; }
        private int _denominator;

        public int Denominator
        {
            get { return _denominator; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("You entered signed denominator, try again");
                    value = int.Parse(Console.ReadLine());
                }
                _denominator = value;
            }
        }
        public static Fraction Sum(Fraction firstFraction, Fraction secondFraction)
        {
            Fraction resultFraction = new Fraction();
            if (firstFraction.Denominator == secondFraction.Denominator)
            {
                resultFraction.Numerator = firstFraction.Numerator + secondFraction.Numerator;
                resultFraction.Denominator = firstFraction.Denominator;
            }
            else
            {
                resultFraction.Numerator = firstFraction.Numerator * secondFraction.Denominator + secondFraction.Numerator * firstFraction.Denominator;
                resultFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;
            }
            return resultFraction;
        }
        public static Fraction Difference(Fraction firstFraction, Fraction secondFraction)
        {
            Fraction resultFraction = new Fraction();
            if (firstFraction.Denominator == secondFraction.Denominator)
            {
                resultFraction.Numerator = firstFraction.Numerator - secondFraction.Numerator;
            }
            else
            {
                resultFraction.Numerator = firstFraction.Numerator * secondFraction.Denominator - secondFraction.Numerator * firstFraction.Denominator;
                resultFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;
            }
            return resultFraction;
        }
        public static Fraction Multiply(Fraction firstFraction, Fraction secondFraction)
        {
            Fraction resultFraction = new Fraction();
            resultFraction.Numerator = firstFraction.Numerator * secondFraction.Numerator;
            resultFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;
            return resultFraction;
        }
        public static Fraction Divide(Fraction firstFraction, Fraction secondFraction)
        {
            Fraction resultFraction = new Fraction();
            resultFraction.Numerator = firstFraction.Numerator * secondFraction.Denominator;
            resultFraction.Denominator = firstFraction.Denominator * secondFraction.Numerator;
            return resultFraction;
        }
        public void PrintInDecimal()
        {
            Console.WriteLine($"Fraction in decimal form:{(double)Numerator / Denominator}");
        }
        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
    }
}
