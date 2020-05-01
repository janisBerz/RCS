using System;

namespace D3_loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountNumbers();
        }

        //1) Cilvēks ievada 10 skaitļus(integer)
        //2) Izvadīt cik bija pozitīvi skaitļi, cik negatīvi un cik 0

        public static void CountNumbers()
        {
            int positives = 0;
            int negatives = 0;
            int zeros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter {i + 1}. number: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 0)
                {
                    positives++;
                }
                else if (a < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }

            Console.WriteLine($"Positives: {positives}, negatives: {negatives}, zeros: {zeros}");
        }
    }
}
