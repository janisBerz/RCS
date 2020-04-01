using System;

namespace Day3_array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 100, 100, 3, 3, 4, 3, 6, 100 };

            int arraySum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 10)
                {
                    arraySum += a[i];
                }
            }
            Console.WriteLine($"Summa: {arraySum}");
        }
    }
}
