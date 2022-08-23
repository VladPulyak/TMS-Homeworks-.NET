namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1;
            Console.WriteLine("Enter infoemation about employee: Age, Name, Salary");
            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            try
			{
                employee1 = new Employee(age, name, salary);
			}
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine($"Stack Trace:\n {ex.StackTrace}");
            }
            catch (ArgumentException ex)
			{
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine($"Stack Trace:\n {ex.StackTrace}");
			}
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("Press Enter to exit program");
            Console.ReadKey();
        }
    }
}