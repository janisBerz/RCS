using System;

namespace MD3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju, kurā ir definēts int masīvs ar vērtībām 100, 200, 233, 66, 77, 98.
            //Izdrukāt uz ekrāna pirmā un pēdējā elementa vērtības.

            int[] array = { 100, 200, 233, 66, 77, 98 };

            Console.WriteLine(array[0]);
            Console.WriteLine(array[array.Length - 1]);

        }
    }
}
