using System;

namespace Microwave_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.WarmUpCompleted += WarmUpCompletedHandler1;
            microwave.WarmUp("Cheese");
            microwave.WarmUpCompleted += WarmUpCompletedHandler2;
            microwave.WarmUp("Pizza");
        }
        private static void WarmUpCompletedHandler1(string foodName)
        {
            Console.WriteLine($"{foodName} is ready!");
        }
        private static void WarmUpCompletedHandler2(string foodName)
        {
            Console.WriteLine($"{foodName} is ready!");
        }
    }
}
