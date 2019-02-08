using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1_U5
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitlaOperacijas();
            Console.Read();
        }

        static void skaitlaOperacijas()
        {
            Console.Write("Ievadi skaitli vinu no operacijam (‘+’, ‘-‘, ‘*’, ‘/‘): ");
            string operacija = Console.ReadLine();

            Console.Write("Ievadi skaitli #1: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi skaitli #2: ");
            int nr2 = int.Parse(Console.ReadLine());

            switch (operacija)
            {
                case "+":
                    Console.Write(nr1 + nr2);
                    break;
                case "-":
                    Console.Write(nr1 - nr2);
                    break;
                case "*":
                    Console.Write(nr1 * nr2);
                    break;
                case "/":
                    Console.Write(nr1 / nr2);
                    break;
                default:
                    Console.Write("Operacija nav atlauta");
                    break;
            }


        }
    }
}
