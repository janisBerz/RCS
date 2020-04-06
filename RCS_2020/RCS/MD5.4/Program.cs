using System;

namespace MD5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot metodi PrintArrayValues, kura kā parametru saņem int[] un izdrukā visas tā vērtības.
            //Izmantojot metožu overload funkciju definēt metodi PrintArrayValues, kura kā parametru saņem string[]
            //un var izdrukāt string[] visas vērtības.

            int[] a = { 10, 12, 131234 };
            string[] b = { "medus", "aka", "juris" };

            PrintArrayValues(a);
            PrintArrayValues(b);
        }

        static void PrintArrayValues(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintArrayValues(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
