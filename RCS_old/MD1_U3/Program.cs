using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            aprekinuIzvade();
            Console.Read();
        }

        static void aprekinuIzvade()
        {
            Console.Write("Ievadi skaitli: ");
            float a = float.Parse(Console.ReadLine());

            float d1 = a;
            Console.WriteLine("a = a + 5: " + (d1 + 5));

            float d2 = a;
            Console.WriteLine("a += 5: " + (d2 += 5));

            float d3 = a;
            Console.WriteLine("a -= 3: " + (d3 -= 3));

            float d4 = a;
            Console.WriteLine("a *= 2: " + (d4 *= 2));

            float d5 = a;
            Console.WriteLine("a += 1: " + (d5 = a + 1));

            Console.WriteLine("a++: (before) " + a++);



            //float b = a++;

            //Console.WriteLine("a++: " + b);

            //Console.WriteLine("a++: (before) " + (a++));
            //Console.WriteLine("a++: (after) " + (a));

        }
    }
}
