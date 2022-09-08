namespace FishesWebMVC.Models
{
    public class Fish
    {
        public Fish(string name, int weight, int speed)
        {
            Name = name;
            Weight = weight;
            Speed = speed;
        }
        public string? Name { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
    }
}
