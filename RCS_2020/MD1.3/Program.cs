using System;

namespace MD1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi vardu!");
            string name = Console.ReadLine();
            Console.WriteLine("Ievadi uzvardu!");
            string surname = Console.ReadLine();

            Console.WriteLine($"{name.Substring(0,1)}. {surname}");
        }
    }
}
