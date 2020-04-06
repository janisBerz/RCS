using System;

namespace MD5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot divas metodes GetName un PrintName. Metodei GetName ir no lietotāja jāpaprasa vārds.
            //PrintName izdrukās padoto teksta vērtību. Pamatmetodē GetName izsaukums ielasīs vērtību un
            //kā string jāatgriež metodei PrintName, kura šo tekstu izdrukās console.

            PrintName(GetName());
        }

        static string GetName()
        {
            Console.WriteLine("Ievadi vardu:");
            return Console.ReadLine();
        }

        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
