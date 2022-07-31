using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Salve : Medicine
    {
        public Salve(string color, string name, int price):base(name, price)
        {
            Color = color;
        }
        public string Color { get; set; }
        public override void PrintModeOfApplication()
        {
            Console.WriteLine("People rub it body parts");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color:{Color}");
        }
    }
}
