using System;
using System.Collections.Generic;

namespace Day_9_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot klasi ar Car
            // krāsa
            // brand
            // durvju skaits

            // saraksts ar 5 objektiem
            // aizpilda cilvēks
            // metode - kas izvada datus par visiem auto
            // metode - pievienot jaunu auto
            // metode - meklē pēc filtriem (durvju skaits, mašīnas krāsa, brand)
            // izvēlas lietotājs

            List<Car> cars = new List<Car>();
            string answer = Console.ReadLine();

            if (cars.Count > 5)
            {
                Console.WriteLine("Add more cars to the list!");
                for (int i = 0; i < 5; i++)
                {
                    Operations.AddCars(cars);
                }

            }

            while (answer != "0")
            {
                Console.WriteLine("----------");
                Console.WriteLine("Mani menu");
                Console.WriteLine("1 - Add car");
                Console.WriteLine("2 - Serch car");
                Console.WriteLine("3 - Print all cars");
                Console.WriteLine("0 - Exit");

                switch (answer)
                {
                    case "1":
                        Operations.AddCars(cars);
                        break;
                    case "2":
                        Operations.SearchCar(cars);
                        break;
                    case "3":
                        Operations.PrintCarList(cars);
                        break;
                    default:
                        Console.WriteLine("Wrong menu item!");
                        break;
                }
            }
        }
    }
}

