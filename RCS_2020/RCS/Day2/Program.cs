using System;

namespace Day2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli");
            string inputA = Console.ReadLine();

            Console.WriteLine("Ievadi skaitli");
            string inputB = Console.ReadLine();

            Console.WriteLine("Ievadi veicamo operaciju");
            string inputOperation = Console.ReadLine();

            int a = int.Parse(inputA);
            int b = int.Parse(inputB);



            switch (inputOperation)
            {
                case "+":
                    Console.WriteLine($"{a}{inputOperation}{b}={(a + b)}");
                    break;
                case "-":
                    Console.WriteLine($"{a}{inputOperation}{b}={(a - b)}");
                    break;
                case "*":
                    Console.WriteLine($"{a}{inputOperation}{b}={(a * b)}");
                    break;
                case "/":
                    Console.WriteLine($"{a}{inputOperation}{b}={(a / b)}");
                    break;
                default:
                    break;
            }



        }
    }
}
