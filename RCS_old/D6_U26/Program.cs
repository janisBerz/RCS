using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_U26
{
    class Program
    {
        static void Main(string[] args)
        {
            masivaParbaude();
            Console.ReadLine();
        }

        static void masivaParbaude()
        {
            int skaits = 10;
            int[] masivs = new int[skaits];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = int.Parse(Console.ReadLine());
            }

            for (int i = masivs.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine("Skaitlis: {0}", masivs[i]);
            }

        }

        static void pretejiSaraksts()
        {
            List<int> saraksts = new List<int>();

            for (int i = 1; i < 5; i++)
            {
                Console.Write("Ievadi skaitli: ");
                saraksts.Add(int.Parse(Console.ReadLine()));
            }

            int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(String.Join(",", saraksts));
        }

        static void pretejiSaraksts2()
        {
            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli: ");
                string vertiba = Console.ReadLine();
                if (string.IsNullOrEmpty(vertiba))
                {
                    break;
                }

                int skaitlis = int.Parse(vertiba);

                if (skaitlis == 0)
                {
                    break;
                }

                saraksts.Add(skaitlis);
            }


            for (int i = 1; i < 5; i++)
            {
                Console.Write("Ievadi skaitli: ");
                saraksts.Add(int.Parse(Console.ReadLine()));
            }

            int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(String.Join(",", saraksts));
        }

    }
    }
