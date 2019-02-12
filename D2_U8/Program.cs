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
           // menesaDienas();
            Console.Read();
        }

        static void menesaDienas()
        {
            Console.Write("Ievadi menesa nosaukumu: ");
            string men = Console.ReadLine();

            men = men.ToLower();

            if (men == "feb")
            {
                Console.WriteLine("28 dienas");
            }
            else if (men == "apr" || men == "jun" || men == "sep" || men == "nov")
            {
                Console.WriteLine("30 dienas");
            }
            else
            {
                Console.WriteLine("30 dienas");
            }
        }


        static void menesaDienas()
        {
            Console.Write("Ievadi menesa nosaukumu: ");
            string men = Console.ReadLine();

            men = men.ToLower();

            if (men == "feb")
            {
                Console.WriteLine("28 dienas");
            }
            else if (men == "apr" || men == "jun" || men == "sep" || men == "nov")
            {
                Console.WriteLine("30 dienas");
            }
            else
            {
                Console.WriteLine("30 dienas");
            }


            switch (men)
            {
                case "apr":
                case "jun":
                case "sep":
                case "nov":
                    Console.Write("30 dienas");
                    break;
                case "feb":
                    Console.Write("28 dienas");
                    break;
                default:
                    Console.Write("31 diena");
                    break;
            }
        }



    }
}
