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

            if (ievaditaisSkaitlis >= -50 && ievaditaisSkaitlis <=50 )
            {
                Console.WriteLine("Skaitlis {0} ir robeza no - 50 lidz 50 ieskaitot.", ievaditaisSkaitlis);
            }
            else
            {
                Console.WriteLine("Skaitlis {0} NAV robeza no - 50 lidz 50 ieskaitot.", ievaditaisSkaitlis);
            }

        }

    }
}
