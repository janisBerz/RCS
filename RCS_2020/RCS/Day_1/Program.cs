using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "vardu";
            Console.WriteLine($"Ievadi {name}!");

            string ievade = Console.ReadLine();

            Console.WriteLine($"Tavs vards ir {ievade}");

            Console.WriteLine("Ievadi savu vecumu!");

            string age = Console.ReadLine();

            int ageInt = int.Parse(age);

            Console.WriteLine($"Tavs vecums ir {ageInt}");

            string intTxt = "65";

            Console.WriteLine(Convert.ToInt32(intTxt));
        }
    }
}
