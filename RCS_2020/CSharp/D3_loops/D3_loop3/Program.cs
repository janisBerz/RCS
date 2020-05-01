using System;

namespace D3_loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingUp();
            Console.WriteLine();
            DrawingUpAdnDown();
        }

        public static void DrawingUp()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DrawingUpAdnDown()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 4; i > 0; i--)
            {
                for (int j = i-1; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
