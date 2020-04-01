using System;

namespace MD3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju, kurā ir definēts string tipa masīvs ar sākotnējām vērtībām "Jānis", "Pēteris", "Andris".
            //Izvadīt uz ekrāna masīva otrā elementa vērtību("Pēteris").
            //Samainīt masīva 3 elementa vērtību no "Andris" uz "Jēkabs".

            string[] a = { "Jānis", "Pēteris", "Andris" };

            Console.WriteLine(a[1]);
            a[3] = "Jēkabs";
        }
    }
}
