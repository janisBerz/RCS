using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD2_U5
{
    class Program
    {
        static void Main(string[] args)
        {
            splitSummV2();
            Console.Read();

        }

        //static void splitSumm()
        //{
        //    Console.Write("Ievadi 1. skaitli: ");

        //    string nr1 = Console.ReadLine();
        //    int summa = 0;

        //    string[] nr = nr1.Split();
        //    foreach (string N in nr)
        //    {
        //        summa += int.Parse(N);
        //    }

        //    Console.Write("Atsevsko skaitlu summa ir {0}", summa);
        //}


        static void splitSummV2()
        {
            Console.Write("Ievadi 1. skaitli: ");
            string nr1 = Console.ReadLine();

            for (int i = 0; i < nr1.Length; i++)
            {
                char simbols = nr1[i];

                int numurs += simbols;

                //summa += simbols;
            }

            Console.Write("Atsevsko skaitlu summa ir {0}", numurs);
        }




    }

}
