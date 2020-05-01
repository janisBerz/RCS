using System;

namespace D5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            sumArray();
        }
        //1) Uztaisīt masīvu ar 5 (int) vērtībām.
        //Cilvēks ievada visas vērtības konsolē.
        //2) Uztaisīt ciklu, kas sasummē visus masīva elementus


        public static void sumArray()
        {
            int[] a = new int[5];
            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter value for elemet {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }

            Console.WriteLine($"Total: {result}");
            Console
        }

    }
}
