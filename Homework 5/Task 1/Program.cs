using System;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            int studentsCounter = 0;
            Console.WriteLine("Enter count of students");
            studentsCounter = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsCounter; i++) 
            {
                Console.WriteLine($"Enter surname and mark {i} student");
                students.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            int operation = 0;
            while (operation != 9)  
            {
                PrintMenu();
                operation = int.Parse(Console.ReadLine());

                switch ((MenuFunctions)operation)
                {
                    case MenuFunctions.AddStudent:
                        {
                            AddStudent(students);
                            break;
                        }
                    case MenuFunctions.ChangeMark:
                        {
                            ChangeMark(students);
                            break;
                        }
                    case MenuFunctions.DeleteMark:
                        {
                            DeleteMark(students);
                            break;
                        }
                    case MenuFunctions.OutpSurnameMark:
                        {
                            OutpSurnameMark(students);
                            break;
                        }
                    case MenuFunctions.OutpAvgMarks:
                        {
                            OutpAvgMarks(students);
                            break;
                        }
                    case MenuFunctions.OutpSurnMaxMark:
                        {
                            OutpSurnMaxMark(students);
                            break;
                        }
                    case MenuFunctions.OutpSurnMore8:
                        {
                            OutpSurnMore8(students);
                            break;
                        }
                    case MenuFunctions.OutpSurnLess4:
                        {
                            OutpSurnLess4(students);
                            break;
                        }
                    case MenuFunctions.Exit:
                        {
                            Console.WriteLine("You exit program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You entered wrong number");
                            break;
                        }
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine(@"Menu:" + Environment.NewLine +  
                               "1.Add new student" + Environment.NewLine + 
                               "2.Change mark of entered student" + Environment.NewLine + 
                               "3.Delete mark of entered student" + Environment.NewLine + 
                               "4.Output students in this format: Surname - Mark" + Environment.NewLine + 
                               "5.Output average of all marks" + Environment.NewLine + 
                               "6.Output surnames, who has max mark among students" + Environment.NewLine + 
                               "7.Enter surnames, who has mark more or equal 8" + Environment.NewLine +
                               "8.Enter surnames, who has mark less or equal 4" + Environment.NewLine + 
                               "9.Exit program");
        }

        static void AddStudent(Dictionary<string, int> students)
        {
            Console.WriteLine("Enter information of new student: surname, mark");
            bool isAdded = students.TryAdd(Console.ReadLine(), int.Parse(Console.ReadLine()));
            if (!isAdded)
            {
                Console.WriteLine("This student has already added");
                return;
            }
            Console.WriteLine("You added student");
        }

        static void ChangeMark(Dictionary<string, int> students)
        {
            Console.WriteLine("Enter surname of changed student: surname");
            string changeSurname = Console.ReadLine();
            Console.WriteLine("Enter new mark");
            int newMark = int.Parse(Console.ReadLine());
            bool isContain = students.ContainsKey(changeSurname);
            if (!isContain)
            {
                Console.WriteLine("This student not found");
                return;
            }
            students[changeSurname] = newMark;
            Console.WriteLine($"You changed information about student {changeSurname}");
        }

        static void DeleteMark(Dictionary<string, int> students)
        {
            Console.WriteLine("Enter surname of student");
            string deleteSurname = Console.ReadLine();
            bool isContain = students.ContainsKey(deleteSurname);
            if (!isContain)
            {
                Console.WriteLine("This student not found");
                return;
            }
            students.Remove(deleteSurname);
            Console.WriteLine($"You deleted student {deleteSurname}");
        }

        static void OutpSurnameMark(Dictionary<string, int> students)
        {
            foreach (KeyValuePair<string, int> pair in students)
            {
                Console.WriteLine($"Surname: {pair.Key}, Mark: {pair.Value}");
            }
        }

        static void OutpAvgMarks(Dictionary<string, int> students)
        {
            double sum = 0;
            foreach (KeyValuePair<string, int> pair in students)
            {
                sum += pair.Value;
            }
            double avg = sum / students.Count;
            Console.WriteLine($"Average ariphmetical of all marks: {avg}");
        }
        
        static void OutpSurnMaxMark(Dictionary<string, int> students)
        {
            int max = 0;
            string maxSurname = string.Empty;
            foreach (KeyValuePair<string, int> pair in students)
            {
                if (pair.Value > max)
                {
                    max = pair.Value;
                }
            }
            Console.WriteLine($"Max mark: {max}");
            foreach (KeyValuePair<string, int> pair in students)
            {
                if (pair.Value == max)
                {
                    Console.WriteLine($"Student with max mark:{pair.Key}");
                }
            }
        }

        static void OutpSurnMore8(Dictionary<string, int> students)
        {
            foreach (KeyValuePair<string, int> pair in students)
            {
                if (pair.Value >= 8)
                {
                    Console.WriteLine($"Student with good mark: {pair.Key}");
                }
            }
        }

        static void OutpSurnLess4(Dictionary<string, int> students)
        {
            foreach (KeyValuePair<string, int> pair in students)
            {
                if (pair.Value <= 4)
                {
                    Console.WriteLine($"Student with bad mark: {pair.Key}");
                }
            }
        }
    }
}
