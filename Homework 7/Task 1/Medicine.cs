using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal abstract class Medicine
    {
        public string Name { get; set; }
        private int _price;

        public int Price
        {
            get { return _price; }
            set 
            {
                if(value < 0)
                {
                    _price = 0;
                    return;
                }
                _price = value; 
            }
        }
        public Medicine(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Price:{Price}");
        }

        public abstract void PrintModeOfApplication();
    }
}
