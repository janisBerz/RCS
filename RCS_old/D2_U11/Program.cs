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
            operacijaArGradiem();
            Console.Read();
        }

        static void operacijaArGradiem()
        {
            Console.Write("Ievadi gradus: ");
            float gradi = float.Parse(Console.ReadLine());

            Console.Write("Ievadi gradu mervienibu ('F', 'C' vai ‘K’): ");
            string sakumaMerviniba = Console.ReadLine().ToLower();

            Console.Write("Uz kadu mervienibu parverst ('F', 'C' vai ‘K’)? ");
            string beiguMervieniba = Console.ReadLine().ToLower();



            switch (sakumaMerviniba)
            {
                case "c":
                    switch (beiguMervieniba)
                    {
                        case "k":
                            //no c u k
                            break;
                        case "f":
                            //no c uz f
                            break;
                    }
                    break;
                case "k":
                    switch (beiguMervieniba)
                    {
                        case "c":
                            //no k u c
                            break;
                        case "f":
                            //no k uz f
                            break;
                    }
                    break;
                case "f":
                    switch (beiguMervieniba)
                    {
                        case "c":
                            //no f uz c
                            break;
                        case "k":
                            //no f uz k
                            break;
                    }
                    break;
            }


            switch (beiguMervieniba)
            {
                case "f":
                    if (sakumaMerviniba == "c")
                    {
                        Console.Write("Gradi pec Farenheita: " + (gradi * 9 / 5) + 32 );
                    }
                    else {
                        Console.Write("Gradi pec Farenheita: " + (gradi- 32) * 5 / 9 + 273.15);
                    }
                    break;
                case "c":
                    if (sakumaMerviniba == "f")
                    {
                        Console.Write("Gradi pec Celsija: " + (gradi * 9 / 5) + 32);
                    }
                    else
                    {
                        Console.Write("Gradi pec Celsija: " + (gradi + 273.15));
                    }
                    break;
                case "k":
                    if (sakumaMerviniba == "c")
                    {
                        Console.Write("Gradi pec Kelvina: " + (gradi - 273.15));
                    }
                    else
                    {
                        Console.Write("Gradi pec Kelvina: " + (gradi - 32) * 5 / 9 + 273.15 );
                    }
                    break;
                default:
                    Console.Write("Nezinama mervieniba ");
                    break;
            }


        }
    }
}
