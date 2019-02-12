using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas k = new Karatavas();

            k.SaktSpeli();

            while (true) { 
            while (!k.IrAtminets())
            {
                Console.Write("Ievadi burtu: ");

                string burts = Console.ReadLine();

                if (k.Minet(burts))
                {
                    Console.WriteLine(k.Vards());
                }
                else {
                    Console.WriteLine("Burts nav saja varda");
                }

            }

            Console.WriteLine("Vards ir atminets, tu uzvareji!");
            Console.WriteLine("");

            Console.Write("Vai gribi jaunu speli y\n: ");

            string atbilde = Console.ReadLine().ToLower();

           
                if (atbilde == "n"){
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
