using System;

namespace MD4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt int tipa masīvu, kurā būs 10 elementi.Izveidot for ciklu,
            //kurš aizpildīs šo masīvu ar skaitļiem.Masīvā ir jāieraksta for cikla mainīgā vērtība.

            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
        }
    }
}
