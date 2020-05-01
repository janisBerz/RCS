using System;

namespace D3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBiggest();
        }


        //1) Izveidot static void metodi bez parametriem.
        //2) Cilvēks ievada piecus skaitļus.Viens mainīgais priekš ievades.
        //3) No pieciem skaitļiem izvadīt lielāko.

        public static void GetBiggest()
        {
            int result = int.MinValue;
            int a;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Emter a number: ");
                a = int.Parse(Console.ReadLine());

                if (a > result)
                {
                    result = a;
                }

                Console.WriteLine($"Biggest number: {result}");
            }
        }
    }
}
