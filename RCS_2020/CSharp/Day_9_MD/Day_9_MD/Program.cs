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


            Operations.AddCars(cars);
            Operations.PrintCarList(cars);

              
        }
    }
}
