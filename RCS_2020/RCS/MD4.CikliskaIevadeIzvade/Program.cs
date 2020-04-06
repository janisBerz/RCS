using System;

namespace MD4.CikliskaIevadeIzvade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pieprasām lietotājam ievadīt skaitli n. Definējam tukšu string masīvu ar izmēru n. 
            //Pēc tam izveidojam ciklu, kurā n reizes lietotājam prasīs ievadīt savu radinieku vārdus, 
            //kurus saglabājam masīvā. Pēc tam JAUNĀ ciklā apskatīt visus masīvā saglabātos vārdus un izvadīt tos vārdus,
            //kuriem teksta garums ir lielāks par 5.

            Console.WriteLine("Ievadi skaitli n");
            int n = int.Parse(Console.ReadLine());
            string[] stringArray = new string[n];

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Ievadi radinieka vardu.");
                stringArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > 5)
                {
                    Console.WriteLine(stringArray[i]);
                }
            }

        }
    }
}
