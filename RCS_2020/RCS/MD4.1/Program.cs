using System;

namespace MD4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju, kurā ir definēts string tipa masīvs ar cilvēku vārdiem. 
            //Izmantojot do while ciklu izdrukāt visus vārdus.

            string[] names = { "Karlis", "Juris", "Burka", "Sintija", "Ilona" };

            int i = 0;
            do
            {
                Console.WriteLine(names[i]);
                i++;
            } while (i<names.Length);
        }
    }
}
