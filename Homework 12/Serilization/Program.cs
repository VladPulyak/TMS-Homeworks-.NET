using Newtonsoft.Json;
namespace Serilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diet newtonsDiet = new Diet("Newton's Diet", "Newton", "AB123", new List<Ingredient>()
            {
                new Ingredient("Milk", 100.95, 123,"Spain"),
                new Ingredient("Apple", 36.87, 40, "Dagestan"),
                new Ingredient("Watermelon", 180, 132, "Poland")
            });
            string serializeString = JsonConvert.SerializeObject(newtonsDiet,Formatting.Indented);
            Console.WriteLine(serializeString);
            var desirializeDiet = JsonConvert.DeserializeObject<Diet>(serializeString);
        }
    }
}