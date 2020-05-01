using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int average = 0;
            int[] a = { 10, 123, 54, 432, 22, 67, 788, 53, 32 };
            for (int i = 0; i < a.Length; i++)
            {
                average += a[i];
            }

            Console.WriteLine($"Array average: {average / a.Length}");
        }
    }
}
