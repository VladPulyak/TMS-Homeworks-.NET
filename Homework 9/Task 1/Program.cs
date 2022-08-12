using System;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        public delegate int GetSalaryMethod(Employee employee);
        public static int GetSalary(Employee employee)
        {
            return (employee.ExperianceInYear + 1) * 1000;
        }
        //1. Создать класс Employee, который должен хранить Имя, Возраст, Опыт(в годах) и Наличие-Отстутствие высшего образования(bool). Этот класс должен содержать статический метод, который принимает List<Employee> и ничего не возвращает. В методе для каждого работника из листа необходимо рассчитать его зарплату по формуле(если у работника есть высшее образование, то зарплата равна (опыт+1) * 1250, иначе зарплата равна(опыт+1) * 1000). И далее выводить на консоль Имя работника и его зарплату.
        //2. В main Создать лист работников.Проверить работу статического метода
        //3. Объявить делегат который принимает Работника и возвращет целое число.
        //4. Создать еще одну версию статического метода которая принимает List<Employee> и объект созданного делегата.В методе для каждого работника из листа необходимо рассчитать его зарплату по формуле(алгоритм расчета зарплаты мы теперь передаем в качестве параметра, нужно просто вызвать метод через делегат). И далее выводить на консоль Имя работника и его зарплату.
        //5. В классе содержащем метод main создать статический метод, который имеет такую же сигнатуру как у созданного делегата.В этом методе должен быть реализован другой алгоритм рассчета заработной платы(например (опыт+1)*1000)
        //6. В самом методе main протестировать новую версию статического метода класса работника, передав в него метод созданный в пункте 5.
        //7. Далее передать в статический метод класса работника передать алгоритм подсчета зарплаты через лямбда-функцию

        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee() { Age = 20, Name = "Ravi", ExperianceInYear = 5, IsHigherEducation = false },
                new Employee() { Age = 55, Name = "John", ExperianceInYear = 8, IsHigherEducation = true },
                new Employee() { Age = 31, Name = "Mery", ExperianceInYear = 1, IsHigherEducation = false },
                new Employee() { Age = 18, Name = "Mike", ExperianceInYear = 6, IsHigherEducation = true }
            };
            Console.WriteLine("Static void method without delegate");
            Employee.PrintSalary(employeeList);
            Console.WriteLine("=================");
            Console.WriteLine("Static int method with delegate");
            GetSalaryMethod delegateSalary = Employee.GetSalary;
            Employee.PrintSalary(employeeList, delegateSalary);
            Console.WriteLine("=================");
            Console.WriteLine("Method without lambda");
            delegateSalary = GetSalary;
            Employee.PrintSalary(employeeList, delegateSalary);
            Console.WriteLine("=================");
            Console.WriteLine("Method with lambda");
            Employee.PrintSalary(employeeList,(employee)=> (employee.ExperianceInYear + 1) * 1000);
        }
    }
}
