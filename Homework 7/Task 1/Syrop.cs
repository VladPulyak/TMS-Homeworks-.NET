using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Syrop : Medicine
    {
        public Syrop(string taste, string name, int price) : base(name, price)
        {
            Taste = taste;
        }
        public string Taste { get; set; }
        public override void PrintModeOfApplication()
        {
            Console.WriteLine("People drink it with a lot of kind of drinks");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Taste:{Taste}");
        }
    }
}
