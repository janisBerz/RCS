using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD2_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitlaParbaude();
            Console.ReadLine();

        }

        static void skaitlaParbaude()
        {
            Console.Write("Ievadi skaitli: ");

            int ievaditaisSkaitlis = int.Parse(Console.ReadLine());

            if (ievaditaisSkaitlis % 2 == 0)
            {
                Console.WriteLine("{0} ir para skaitlis", ievaditaisSkaitlis);
            }
            else
            {
                Console.WriteLine("{0} NAV nav para skaitlis", ievaditaisSkaitlis);
            }

        }

    }
}
