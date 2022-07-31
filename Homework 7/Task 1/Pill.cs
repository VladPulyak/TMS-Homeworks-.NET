using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Pill : Medicine
    {
        public Pill(string form, string name, int price) : base(name, price)
        {
            Form = form;
        }
        public string Form { get; set; }
        public override void PrintModeOfApplication()
        {
            Console.WriteLine("People wash down it with water or use it without anything");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Form:{Form}");
        }
    }
}
