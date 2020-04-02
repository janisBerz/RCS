using System;

namespace MD3.MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { -10, 11, 234234, 1212, 3 };
            
            int min = int.MinValue;
            int max = int.MaxValue;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > min)
                {
                    max = intArray[i];
                }
            }
        }
    }
}
