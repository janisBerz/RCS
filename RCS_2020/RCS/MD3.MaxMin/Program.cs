using System;

namespace MD3.MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { -10, 11, 234234, 1212, -20 };
            
            int min = intArray[0];
            int max = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                }
            }

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

        }
    }
}
