using System;

namespace MD1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi pirmo skaitli.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli.");
            int y = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= 20 && y >= 30 && y <= 50)
            {
                Console.WriteLine($"Skaitlu summa: {x + y}");
            }
            else
            {
                Console.WriteLine("Kluda! Skaitliem jabut x:\"0-20\", y: \"30-50\"");
            }
        }
    }
}
