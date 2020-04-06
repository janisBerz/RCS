using System;

namespace MD5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt metodi PrintGreeting, kura console VIENU REIZI izdrukā tekstu “Hello World!”.
            //Izdrukāt šo sveicienu ar metodes palīdzību 3 reizes.
            PrintGreeting();
            PrintGreeting();
            PrintGreeting();
        }

        static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
