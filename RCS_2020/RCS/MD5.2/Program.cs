using System;

namespace MD5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt metodi PrintMyName ar diviem string parametriem name un surname.
            //Izsaucot metodi jāizdrukā teksts N. Surname (vārda pirmais burts + uzvārds);
            //Ievades parametrus metode var saņemt no lietotāja vai tie var būt definēti iepriekš izmantojot mainīgos.

            string name = "Juris";
            string surname = "Burka";
            PrintMyName(name, surname);
        }

        private static void PrintMyName(string name, string surname)
        {
            Console.WriteLine($"{name.Substring(0, 1)}. {surname}");
        }
    }
}
