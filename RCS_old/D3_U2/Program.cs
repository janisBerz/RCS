using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkaitluIzvade();

            Console.Read();
        }

        static void SkaitluIzvade()
        {
            int a = 0;


            for (int i = 1; i <= 10000; i++)
            {

                Console.WriteLine("Skaitlis ir {0}",i);

                a += i;
            }

            Console.Write("Cikla beigas. Skaitļu summa ir {0}", a);

        }
    }
}
