using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_U9
{
    class Program
    {
        static void Main(string[] args)
        {
            galvaspilsetas();
            Console.ReadLine();
          
        }

        static void galvaspilsetas()
        {

            Console.Write("Ievadi valsts nosaukumu:");


            string valsts = Console.ReadLine();

            Console.Write("Valsts {0} galvaspilseta ir ", valsts);

            switch (valsts.ToLower())
            {
                case "latvija":
                    Console.Write("Riga");
                    break;
                case "igaunija":
                    Console.Write("Tallina");
                    break;
                case "lietuva":
                    Console.Write("Vilna");
                    break;
                case "krievija":
                    Console.Write("Maskava");
                    break;
                case "somija":
                    Console.Write("Helsinki");
                    break;
                case "zviedrija":
                    Console.Write("Stokholma");
                    break;
                default:
                    Console.Write("Valsts nav atrasta");
                    break;
            }
        }

    }
}
