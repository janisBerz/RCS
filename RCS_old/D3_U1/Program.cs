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
            CikluPiemers();

            Console.Read();
        }

        static void CikluPiemers()
        {
            Console.Write("Ievadi skaitli:");

            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i <= 10; i++)
            {
                // pariet pie nākamās iterācijas
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

                // pārtrauc cikla apstrādi
                //if (i == 5)
                //{
                //    break;
                //}
            }

            Console.Write("Cikla beigas");

        }
    }
}
