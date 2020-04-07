using System;

namespace MD6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izmantojot metožu overload iespējas definēt metodi PrintNameSurname, kura vienā gadījumā strādā ar vienu ieejas parametru name,
            //bet otrajā gadījumā ar diviem parametriem name un surname. Izveidot papildus metodi PrintNameAge (izdruka vārdu un vecumu),
            //tā, lai tai būtu tikai divi parametri un ja lietotājs nav ievadījis vecumu, tad vecuma vietā rakstītos skaitlis 99.

            PrintNameAge("Janis");
        }

        private static void PrintNameAge(string name, int age = 99)
        {
            Console.WriteLine($"{PrintNameSurname(name)} {age}");
        }

        private static string PrintNameSurname(string name)
        {
            return name;
        }
        private static string PrintNameSurname(string name, string surname)
        {
            return $"{name}{surname}";
        }
    }
}
