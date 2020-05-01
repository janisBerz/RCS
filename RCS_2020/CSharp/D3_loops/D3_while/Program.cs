using System;

namespace D3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxMin();
        }

        //1) Cilvēks ievada skaitļus cik ilgi grib. (nosacījuma, break...)
        //2) Jāizvada lielākais un mazākais skaitlis.

        public static void MaxMin()
        {
            Console.WriteLine("Please enter a number. Non integer to stop the iteration.");
            bool isInteger;
            int min = 0;
            int max = min;
            do
            {
                int a;
                Console.Write("Your number: ");
                isInteger = int.TryParse(Console.ReadLine(), out a);

                if (isInteger)
                {
                    if (a > max)
                    {
                        max = a;
                    }
                    else if (a < min)
                    {
                        min = a;
                    }
                }
            } while (isInteger);

            Console.WriteLine($"min: {min}. max: {max}");
        }
    }
}
