using System;
using System.Collections.Generic;
using System.Text;

namespace MD8._3
{
    enum Color
    {
       Red,
       Blue,
       Balack
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Color Color { get; set; }
        public int Year { get; set; }

        public void GetCarInfo()
        {
            Console.WriteLine($"{Make}, {Model}, {Price}, {Color}, {Year} ");
        }
    }
}
