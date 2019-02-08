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
            GaduIzvade();

            Console.Read();
        }

        

        static void GaduIzvade()
        {

            Console.WriteLine("Ievadi dzimšanas gadu: ");

            int dzimsanasGads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            for (; dzimsanasGads <= robeza; dzimsanasGads++)
            {
                Console.WriteLine(dzimsanasGads);    
            }

            while (dzimsanasGads <= robeza)
            {
                Console.WriteLine(dzimsanasGads);
                dzimsanasGads++;
            }



        }
    }
}
