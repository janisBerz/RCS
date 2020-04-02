using System;

namespace MD3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot string masīvu ar cilvēku vārdiem (Vēlams ne mazāk kā 3).
            //1.Izdrukāt visus vārdus.
            //2.Izdrukāt tikai tos vārdus, kuri sākās ar "J".
            //Izmantojam Substring metodi.

            string[] humanNames = { "Juris", "Kristaps", "Jekabs" };

            for (int i = 0; i < humanNames.Length; i++)
            {
                Console.WriteLine(humanNames[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < humanNames.Length; i++)
            {
                if (humanNames[i].Substring(0,1) == "J")
                {
                    Console.WriteLine(humanNames[i]);
                }
            }
        }
    }
}
