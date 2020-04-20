using System;
using System.Collections.Generic;

namespace MD8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Izveidot klasi Car ar 5 property(īpašībām) Make, Model, Price un Color, Year,
            ///izvēlieties atbilstošus datutipus izveidotajiem laukiem. Pievienojiet šai klases public metodi,
            ///kura atgriež visu informāciju par mašīnu kā tekstu, kur visas vērtības ir atdalītas ar komatu.
            ///Galvenajā programmā izveidojiet sarakstu ar 5 mašīnām. Atrodiet un izdrukājiet uz ekrāna dārgākās mašīnas informāciju.
            ///Dārgākās mašīnas atrašanai varat izmantot for vai foreach ciklu.
            ///

            int topCarPrice = 0;

            List<Car> cars = new List<Car>();

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Car car4 = new Car();
            Car car5 = new Car();

            car1.Make = "Audi";
            car1.Model = "80";
            car1.Price = 200;
            car1.Color = Color.Red;
            car1.Year = 1990;

            car2.Make = "MBW";
            car2.Model = "301";
            car2.Price = 2000;
            car2.Color = Color.Balack;
            car2.Year = 2000;

            car3.Make = "Opel";
            car3.Model = "Corsa";
            car3.Price = 20;
            car3.Color = Color.Blue;
            car3.Year = 1989;

            car4.Make = "VW";
            car4.Model = "Golf";
            car4.Price = 4500;
            car4.Color = Color.Red;
            car4.Year = 2015;

            car5.Make = "Audi";
            car5.Model = "A3";
            car5.Price = 6000;
            car5.Color = Color.Balack;
            car5.Year = 2016;

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);

            foreach (var car in cars)
            {
                int carPrice = car.Price;
                if (carPrice > topCarPrice)
                {
                    topCarPrice = carPrice;
                }
            }

            foreach (var car in cars)
            {
                if (car.Price == topCarPrice)
                {
                    Console.Write("The most expecnisve car in the car park: ");
                    car.GetCarInfo();
                }
            }
        }
    }
}
