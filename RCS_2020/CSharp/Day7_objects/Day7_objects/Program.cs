using System;
using System.Collections.Generic;

namespace Day7_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomIntegers = new List<int>();
            Random random = new Random();
            bool cont = true;

            for (int i = 0; i < 11; i++)
            {
                randomIntegers.Add(random.Next(0, 10));
            }

            while (cont)
            {
                Console.WriteLine("Izvelies darbibu:");
                Console.WriteLine("1 - Izvadit sarakstu.");
                Console.WriteLine("2 - Izdzest elementu pec indeksa.");
                Console.WriteLine("3 - Iziet.");

                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        int i = 0;
                        foreach (var item in randomIntegers)
                        {
                            Console.WriteLine($"{i}: {item}");
                            i++;
                        }
                        break;
                    case 2:
                        //remove using index
                        Console.WriteLine("Kuru ierakstu gribat izdzest?");
                        int inputIndex = int.Parse(Console.ReadLine());
                        try
                        {
                            randomIntegers.RemoveAt(inputIndex);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Izveleta pozicija neeksiste: {e.Message}");
                        }
                        break;
                    case 3:
                        //exit
                        cont = false;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
