using System;

namespace MD1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = "burka";
            string vegetable = "cucamber";
            string spice = "peper";

            Console.WriteLine(item + vegetable + spice);
            Console.WriteLine($"{item}{spice}{vegetable}");
            Console.WriteLine(String.Format("{0}{0}{0}", spice,vegetable,item));



        }
    }
}