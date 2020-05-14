using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9_MD
{
    class Operations
    {

        public static void AddCars(List<Car> cars)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please add car to the list...");
            Console.WriteLine();

            string brand = "";
            string colour = "";
            int doors = 0;

            Console.Write("Brand: ");
            brand = Console.ReadLine();
            
            Console.Write("Color: ");
            colour = Console.ReadLine();
            
            Console.Write("Doors: ");
            bool isInt = false;

            while (!isInt)
            {
                Console.WriteLine("Please enter an integer!");
                Console.Write("Doors: ");
                isInt = int.TryParse(Console.ReadLine(), out doors);
            }

            cars.Add(new Car(brand, colour, doors));
        }

        public static void PrintCarList(List<Car> cars)
        {
            Console.WriteLine();
            Console.WriteLine("--- Availiable cars ---");

            if (cars.Count > 0)
            {
                foreach (Car car in cars)
                {
                    Console.WriteLine($"Brand: {car.Brand}; Colour: {car.Colour}; Doors: {car.Doors}");
                }
            }
            else
            {
                Console.WriteLine("Add some cars...");
            }
        }
    }
}
