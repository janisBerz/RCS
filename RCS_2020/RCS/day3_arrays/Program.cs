using System;

namespace day3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 0, 1, 1, 1, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == 0)
                {
                    break;
                }
            }
        }
    }
}
