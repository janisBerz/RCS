using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_myFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloooooo, World");
            // Ggaida uz teksta ievadi

            //tekstaIzvade();
            //tekstaIzvadeArParametru("Teksts no funkcijas ar parametru");
            vecumaIevade();
            //tekstaIevade();
            Console.Read();

        }
        static void tekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadīts teksts");
        }

        static void tekstaIzvadeArParametru(string teksts)
        {
            Console.WriteLine("Izvade: " + teksts);
        }

        static void tekstaIevade()
        {
            // Izvada tekstu
            Console.Write("Ievadi savu vārdu: ");

            // teksta ievadei
            string vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu: ");

            string uzvards = Console.ReadLine();

            // teksta izvade
            Console.Write("Tevi sauc " + vards + " " + uzvards);
        }

        static void vecumaIevade()
        {
            Console.Write("Ievadi savu vecumu: ");
            //string vecums = Console.ReadLine();

            //int skaitlis = Convert.ToInt32(vecums);
            int skaitlis = int.Parse(Console.ReadLine()) + 1;
            //skaitlis = skaitlis + 1;
            //skaitlis += 1;

            Console.WriteLine("Pēc gada tev būs " + skaitlis);
        }


    }
}
