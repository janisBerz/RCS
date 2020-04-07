using System;
using System.Collections.Generic;

namespace MD6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt programmas sākumā string[] ar vērtībām {“Jānis”, ””, “Pēteris”, “Antons”, “”, “Andris”}.
            //Izveidot metodi GetNonEmtyArray, kura kā paramatru saņem string[] un lietotājam atgriež string[],
            //kurā vairs nav tukšo vērtību. Lai nodemonstrētu GetNonEmptyArray metodes darbību, izmantojiet metodi PrintArrayValues,
            //kura vispirms izdrukā sākotnējā masīva vērtības, bet vēlāk masīvu, kurā vairs nav tukšās vērtības.

            string[] a = { "Janis", "", "Peteris", "Antons", "", "Andris" };

            string[] cleanArray = GetNonEmtyArray(a);

            PrintArrayValues(a);
            Console.WriteLine("-----");
            PrintArrayValues(cleanArray);

        }

        private static void PrintArrayValues(string[] cleanArray)
        {
            foreach (var item in cleanArray)
            {
                Console.WriteLine(item);
            }
        }

        private static string[] GetNonEmtyArray(string[] a)
        {
            List<string> cleanList = new List<string>();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > 0)
                {
                    cleanList.Add(a[i]);
                }
            }

            string[] cleanArray = new string[cleanList.Count];

            for (int i = 0; i < cleanArray.Length; i++)
            {
                cleanArray[i] = cleanList[i];
            }

            return cleanArray;
        }
    }
}
