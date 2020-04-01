using System;

namespace MD3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uztaisīt console aplikāciju, kura lietotājam paprasa ievadīt veselu skaitli. 
            //Ja nav ievadīts vesels skaitlis, paziņot par kļūdu un likt ievadīt atkārtoti tik ilgi, kamēr ievadīts skaitlis (izmantojam ciklu while). 
            //Kad ievadītā vērtība ir skaitlis, tad izvadīt to uz ekrāna.

            int a;

            do
            {
                Console.WriteLine("Ievadi skaitli");

            } while (!int.TryParse(Console.ReadLine(), out a));

            Console.WriteLine($"Vesels skaitlis: {a}");
        }
    }
}
