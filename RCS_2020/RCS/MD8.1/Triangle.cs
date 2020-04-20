using System;
using System.Collections.Generic;
using System.Text;

namespace MD8._1
{
    class Triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        internal static void GetPerimeter(int a, int b, int c)
        {
            Console.WriteLine("Triangle perimeter: " + (a + b + c));
        }

    }
}
