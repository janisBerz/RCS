using System;

namespace RCSCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Palūdzat lietotājam ievadīt savu vārdu un tad ar viņu sasveicinaties:
            //Cilvēks ievada Mārtiņš, izvadat "Sveiki, Mārtiņš"
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}!");


            //-Cilvēks ievada 3 simbolu virknes, tās salikt kopā(sakombinēt) un izvadīt.

            Console.Write("Please enter 1. number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter 2. number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter 3. number: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Combined integers: {a}{b}{c}");

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }


        }
    }
}
