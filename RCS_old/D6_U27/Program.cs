using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_U27
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitluIevade();
            Console.ReadLine();

        }


        static void skaitluIevade()
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


            //1. varianst
            int a = 0;

            for (int i = 0; i < saraksts.Count; i++)
            {

                if (saraksts[i] == 5)
                {
                    a++;

                }
            }
            Console.WriteLine("Skailis 5 atrasts: {0}", a);


            // 2. variants
            a = saraksts.Count(sk => sk == 5);

            Console.WriteLine("Skailtis 5 atrasts {0} reizes", a);

        }



    }
}
