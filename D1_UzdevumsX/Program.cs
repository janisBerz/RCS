using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_UzdevumsX
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitluVidejais();
            Console.ReadLine();
        }

        static void skaitluVidejais()
        {
            Console.Write("Ievadi #1: ");
            float nr1 = float.Parse(Console.ReadLine());

            Console.Write("Ievadi #2: ");
            float nr2 = float.Parse(Console.ReadLine());

            Console.Write("Ievadi #3: ");
            float nr3 = float.Parse(Console.ReadLine());

            Console.Write("Ievadi #4: ");
            float nr4 = float.Parse(Console.ReadLine());

            float videjais = (nr1 + nr2 + nr3 + nr4) / 4;

            Console.WriteLine("Vidējais skaitlis: " + videjais);

        }
    }
}
