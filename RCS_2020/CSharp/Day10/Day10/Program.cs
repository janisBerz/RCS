using System;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            //masīvs ar 10 elementiem
            // ģenerēt ar random (0 - 40)
            // sakartot skaitļus augošā secībā izmantojos bubble sort metodi

            int[] a = new int[10];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(40);
            }

            Console.Write("New array: ");

            for (int i = 0; i < a.LongLength; i++)
            {
                Console.Write(a[i] + " ");
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int z = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = z;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Sorted array: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
