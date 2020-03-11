using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            piemers();
            Console.ReadLine();

        }

        static void piemers()
        {
            int sk1;
            int sk2;


            int[] skaitli = new int[5]; //masivs are 5 elementiem

            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // izmetīs kļūdu - IndexOutOfRange
            //skaitli[5] = 6;

            int skaitlis = skaitli[3]; //4


            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.WriteLine(skaitli[i]);
            }

            foreach (int vertiba in skaitli)
            {
                Console.WriteLine(vertiba);
            }
        }

    }
}
