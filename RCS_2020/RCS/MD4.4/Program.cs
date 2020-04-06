using System;

namespace MD4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt int masīvu ar 12 elementiem { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 }. 
            //Izdrukāt skaitļus console logā sadalot tos trijās grupās. Skaitļi robežās no 0-30, 31-60, 61-90.
            //*nav nepieciešams izdomāt kā kārtot, tas būs sarežģīti, izmantojiet papildus ciklus. 
            //Tātad vajag izdrukāt sākumā visus tos ar pirmo robežu, tad tikai ar otro un tad visus skaitļus, kas atbilst trešajai robežai.


            int[] a = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };

            string groupA = "";
            string groupB = "";
            string groupC = "";

            foreach (var item in a)
            {
                if (item >= 0 && item < 31)
                {
                    groupA += " " + item;
                }
                else if (item >= 31 && item < 61)
                {
                    groupB += " " + item;
                }
                else if (item >= 61 && item <= 90)
                {
                    groupC += " " + item;
                }
            }

            Console.WriteLine(groupA);
            Console.WriteLine(groupB);
            Console.WriteLine(groupC);
        }
    }
}
