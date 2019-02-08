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
            vecums();
            Console.ReadLine();

        }

        static void vecums() {
            Console.Write("Ievadi Savu vecumu: ");

            int ievaditaisVecums = int.Parse(Console.ReadLine());

            if (ievaditaisVecums <= 50)
            {
                Console.WriteLine("Tu neesi vecaks par 50 gadiem!");
            }
            else {
                Console.WriteLine("Tu esi vecaks par 50 gadiem!");
            }

        }

    }
}
