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
            // Salīdzināt abiem kārtošanas algoritmiem izpildes laiku.

            // create array
            var array = NewArray(100000);

            // run quick sort
            var quickSortWatch = System.Diagnostics.Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            quickSortWatch.Stop();
            var quickSortTime = quickSortWatch.ElapsedMilliseconds;
            Console.WriteLine($"Quicksort time in ms: {quickSortTime}");

            //run bubble sort
            var bubbleSortWatch = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(array);
            bubbleSortWatch.Stop();
            var bubbleSortTime = bubbleSortWatch.ElapsedMilliseconds;
            Console.WriteLine($"Bubblesort time in ms: {bubbleSortTime}");
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = PartitionIndex(array, low, high);
                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }            
        }

        private static int PartitionIndex(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
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
                a[i] = random.Next(10000);
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
