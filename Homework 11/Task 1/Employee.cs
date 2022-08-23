using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Employee
    {
        private int _age;
        private string _name;
        private double _salary;

        public Employee(int age, string name, double salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 17)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _name = value;
                }
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _salary = value;
                }
            }
        }
    }
}
