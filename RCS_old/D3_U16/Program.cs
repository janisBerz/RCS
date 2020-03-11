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
            DaudzSkaitluIevade();

            Console.Read();
        }

        static void DaudzSkaitluIevade()
        {
            Console.Write("Ievadi skaitu:");

            int skaits = int.Parse(Console.ReadLine());

            int summ = 0;

            //int ievaditaisSkaitliasSumma = 0;

            for (int i = 1; i <= skaits; i++)
            {

                Console.Write("Ievadi {0}. skaitli.", i);
                summ += int.Parse(Console.ReadLine());

            }

            
            Console.WriteLine("Kopējā summa ir {0}", summ);

            Console.WriteLine("Vidējais ir{0}", (summ / skaits));
        }
    }
}
