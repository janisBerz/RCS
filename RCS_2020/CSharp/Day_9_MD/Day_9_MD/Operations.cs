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
            Console.WriteLine("Please add car to the list.");
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
                isInt = int.TryParse(Console.ReadLine(), out doors);
                if (!isInt)
                {
                    Console.WriteLine("Please enter an integer!");
                    Console.Write("Doors: ");
                }
            }

            cars.Add(new Car(brand.ToUpper().Trim(), colour.ToUpper().Trim(), doors));
        }

        public static void PrintCarList(List<Car> cars)
        {
            Console.WriteLine();
            Console.WriteLine("--- Availiable cars ---");

            if (cars.Count > 0)
            {
                foreach (Car car in cars)
                {
                    Console.WriteLine($"Brand: {car.Brand}; Color: {car.Colour}; Doors: {car.Doors}");
                }
            }
            else
            {
                Console.WriteLine("Add some cars...");
            }
        }

        public static void SearchCar(List<Car> cars)
        {
            Console.WriteLine("----------");
            Console.WriteLine("Search by: ");
            Console.WriteLine("1 - Brand");
            Console.WriteLine("2 - Doors");
            Console.WriteLine("3 - Color");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.Write("Enter brand name: ");
                    string carBrand = Console.ReadLine();
                    foreach (Car car in cars)
                    {
                        if (car.Brand.ToUpper().Trim() == carBrand.ToUpper().Trim())
                        {
                            Console.WriteLine($"Brand: {car.Brand}; Color: {car.Colour}; Doors: {car.Doors}");
                        }
                    }
                    break;
                case "2":
                    Console.Write("Enter door amount: ");
                    int doors = int.Parse(Console.ReadLine());
                    foreach (Car car in cars)
                    {
                        if (car.Doors == doors)
                        {
                            Console.WriteLine($"Brand: {car.Brand}; Color: {car.Colour}; Doors: {car.Doors}");
                        }
                    }
                    break;
                case "3":
                    Console.Write("Enter color: ");
                    string color = Console.ReadLine();
                    foreach (Car car in cars)
                    {
                        if (car.Colour.ToUpper().Trim() == color.ToUpper().Trim())
                        {
                            Console.WriteLine($"Brand: {car.Brand}; Color: {car.Colour}; Doors: {car.Doors}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Wrong menu item!");
                    break;
            }
        }
    }
}
