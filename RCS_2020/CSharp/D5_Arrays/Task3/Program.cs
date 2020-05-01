using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintElemet();
        }

        public static void PrintElemet()
        {
            Random random = new Random();
            int[] a = new int[10];
            bool arrayContainsInt = false;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0, 10);
            }

            Console.Write("Enter number: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    Console.Write(i + " ");
                    arrayContainsInt = true;
                }
            }

            if (!arrayContainsInt)
            {
                Console.WriteLine("The array did not contain the integer you were searching for :(");
            }
        }
    }
}
