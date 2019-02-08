using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_U25
{
    class Program
    {
        static void Main(string[] args)
        {
            masivaParbaude();
            Console.ReadLine();
        }

        static void masivaParbaude()
        {
            Console.WriteLine("Ievadi skaitli:");

            int sk = int.Parse(Console.ReadLine());

            int[] skaitluMasivs = { 0, 10, 20, 30, 40, 50 };

            bool irAtrasts = false;
            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] == sk)
                {
                    Console.WriteLine("Skaitlis ir atrasts pozīcijā {0}", i);
                    irAtrasts = true;
                    break;


                }

                //if (irAtrasts == false)
                if(!irAtrasts)
                {
                    Console.WriteLine("Skaitlis nav masīvā!");
                }
            }



        }
    }
}
