using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD2_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            parbaudiVertibu();
            Console.ReadLine();

        }

        static void parbaudiVertibu()
        {
            Console.Write("Ievadi 1. skaitli: ");

            int nr1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 2. skaitli: ");

            int nr2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 3. skaitli: ");

            int nr3 = int.Parse(Console.ReadLine());


            if (nr1 > nr2 && nr1 > nr3) {

                Console.WriteLine("{0} ir lielakais skaitlis", nr1);
            }

            if (nr2 > nr1 && nr2 > nr3)
            {
                Console.WriteLine("{0} ir lielakais skaitlis", nr2);

            }
            if (nr3 > nr1 && nr1 > nr2)
            {
                Console.WriteLine("{0} ir lielakais skaitlis", nr3);

            }



            if (nr1 < nr2 && nr1 < nr3)
            {
                Console.WriteLine("{0} ir lielakais skaitlis", nr1);

            }
            if (nr2 < nr1 && nr2 < nr3)
            {
                Console.WriteLine("{0} ir lielakais skaitlis", nr2);

            }
            if (nr3 < nr1 && nr1 < nr2)
            {
                Console.WriteLine("{0} ir lielakais skaitlis", nr3);

            }

        }

    }
}
