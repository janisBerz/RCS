using System;

namespace MD2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju, kura paprasa lietotājam vai viņš grib pusdienas. 
            //Ja lietotājs ir ievadījis TRUE, tad uz ekrāna izdrukāt "Jūsu pusdienas ir gatavas", 
            //ja lietotājs ir ievadījis FALSE, tad "Jums pusdienas nebūs". 
            //IF ELSE nosacījumā ir jāizmanto bool tipa mainīgais, nevis string tipa mainīgais. 
            //Lai no lietotāja ievadītā teksta iegūtu bool tipa mainīgo ir jāizmanto bool.Parse, līdzīgi kā ar konvertēšanu uz veselu skaitli.

            Console.WriteLine("Esi izsalcis (TRUE/FALSE)?");

            bool hungry = bool.Parse(Console.ReadLine());

            if (hungry)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }

        }
    }
}
