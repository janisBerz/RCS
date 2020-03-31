using System;

namespace Day_1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi atrumu!");

            string inputSpeed = Console.ReadLine();
            int inputToInt = Convert.ToInt32(inputSpeed);

            int speedLimit = 50;
            int actualSpeed = speedLimit + inputToInt;

            if (actualSpeed >= speedLimit + 10 && actualSpeed <= speedLimit + 20)
            {
                Console.WriteLine("Sods 10");
            }
            else if (actualSpeed > speedLimit + 20 && actualSpeed <= speedLimit + 30)
            {
                Console.WriteLine("Sods 30");
            }
            else if (actualSpeed > speedLimit + 20)
            {
                Console.WriteLine("Nost ar tiesibam!");
            }
            else
            {
                Console.WriteLine($"Tavs {actualSpeed}");
            }
        }
    }
}

