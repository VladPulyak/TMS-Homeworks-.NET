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
        public string Name { get; set; }
        public int ExperianceInYear { get; set; }
        public bool IsHigherEducation { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public static int GetSalary(Employee employee)
        {
            if (employee.IsHigherEducation)
            {
                return (employee.ExperianceInYear + 1) * 1250;
            }
            else
            {
                return (employee.ExperianceInYear + 1) * 1000;
            }
        }
        public static void PrintSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee.IsHigherEducation)
                {
                    Console.WriteLine($"Salary:{employee.Name} - { (employee.ExperianceInYear + 1) * 1250}");
                }
                else
                {
                    Console.WriteLine($"Salary:{employee.Name} - { (employee.ExperianceInYear + 1) * 1000}");
                }
            }
        }
        public static void PrintSalary(List<Employee> employees, Program.GetSalaryMethod delegateSalary)
        {
            foreach(var employee in employees)
            {
                int salary = delegateSalary(employee);
                Console.WriteLine($"{employee.Name} - {salary}");
            }
        }
    }
}
