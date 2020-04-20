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
            int first = int.Parse(Console.ReadLine());

            Console.Write("Please enter 2. number: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Please enter 3. number: ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine($"Combined integers: {first}{second}{third}");

            if (first > second && first > third)
            {
                Console.WriteLine(first);
            }
            if (second > first && second > third)
            {
                Console.WriteLine(second);
            }
            if (third > first && third > second)
            {
                Console.WriteLine(third);
            }

            // 4

            int a = 3;
            int b = 9;
            Console.WriteLine($"a: {a}, b: {b}");

            int c = a; //3
            int d = b; //9
            a = d;
            b = c;
            Console.WriteLine($"a: {a}, b: {b}");

        }
    }
}
