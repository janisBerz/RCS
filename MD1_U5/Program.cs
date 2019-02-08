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
            ievadiVecumu();
            Console.Read();
        }

        static void ievadiVecumu()
        {
            Console.Write("Ievadi savu vecumu: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 18)
            {
                Console.WriteLine("Tu esi pilngadigs.");
            }
            else
            {
                Console.WriteLine("Tu neesi pilngadigs");
            }

        }
    }
}
