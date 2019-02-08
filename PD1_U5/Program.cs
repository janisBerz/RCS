using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1_U5
{
    class Program
    {
        static void Main(string[] args)
        {
            ievietoVardu();

            Console.Read();

        }

        static void ievietoVardu()
        {
            Console.Write("Ievadi 1. skiatli: ");
            double nr1 = double.Parse(Console.ReadLine());

            Console.Write("Ievadi 2. skiatli: ");
            double nr2 = double.Parse(Console.ReadLine());

            double i = nr1;

            if (nr2 < nr1)

            {
                Console.WriteLine("nekorektas vertibas");

            }
            else
            {
                for (; i <= nr2; i++)
                {

                    if (i % 3 != 0 && i % 5 != 0)
                    {
                        Console.Write("{0}, ", i);
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("BUZZFIZZ, ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("BUZZ, ");
                    }
                    else Console.Write("FIZZ, ");


                    // otrs variants

                    if (i % 3 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    else if (i % 3 != 0)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }

        }
    }


}
