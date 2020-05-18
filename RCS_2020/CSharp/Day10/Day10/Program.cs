using System;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            //masīvs ar 10 elementiem
            // ģenerēt ar random (0 - 40)
            // sakartot skaitļus augošā secībā izmantojos bubble sort metodi

            var array = NewArray(5);

            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine();

            PrintArray(array);


        }

        public static void QuickSort(int[] array, int low, int high)
        {
            int partitionIndex = PartitionIndex(array, low, high);
            QuickSort(array, low, partitionIndex - 1);
            QuickSort(array, partitionIndex + 1, high);
            
        }

        private static int PartitionIndex(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high -1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int z = array[i];
                    array[i] = array[j];
                    array[j] = z;
                }
            }

            int zz = array[i + 1];
            array[i + 1] = array[high];
            array[high] = zz;

            return (i + 1);
        }

        public static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int z = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = z;
                    }
                }
            }
        }

        public static int[] NewArray(int arraySize)
        {
            int[] a = new int[arraySize];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(40);
            }
            return a;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
