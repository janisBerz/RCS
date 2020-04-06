using System;

namespace MD4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot divdimensiju masīvu int[5,4] un piešķirt elementiem vērtības. Izdrukāt visu elementu vērtības console.

            int[,] a = new int[5,4];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = 200 + j;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{i},{j}: {a[i,j]}");
                }
            }
        }
    }
}
