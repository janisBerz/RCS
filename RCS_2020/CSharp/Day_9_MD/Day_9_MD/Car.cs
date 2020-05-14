namespace Day_9_MD
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Colour { get; set; }
        public int Doors { get; set; }

        public Car(string brand, string colour, int doors)
        {
            Brand = brand;
            Colour = colour;
            Doors = doors;            
        }
    }
}