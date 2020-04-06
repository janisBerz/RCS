using System;

namespace Day4.VardiUnSkaits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju. Nodeklarēt string tipa masīvu ar 6 vārdiem.
            //Programmai ir jāsaskaita, cik vārdi sākas ar katru atrasto pirmo burtu. Izmantojam ciklu for.

            string[] names = { "Juris", "Janis", "Jekabs", "Grieta", "Ansis", "Aivars" };

            string[] charArray = new string[names.Length];


            for (int i = 0; i < names.Length; i++)
            {
                charArray[i] = names[i].Substring(0, 1);
            }

            string b = charArray[0];

            for (int i = 1; i < charArray.Length; i++)
            {
                int a = 0;
                if (b == charArray[i])
                {
                }

                for (int y = 0; y < charArray.Length; y++)
                {
                    if (b == charArray[i])
                    {
                        a++;
                    }
                }
                b = charArray[i];

                Console.WriteLine($"{charArray[i]} - {a}");  
            }




        }
    }
}
