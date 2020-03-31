using System;

namespace Day2_enum
{
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        Someday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days day = Days.Monday;

            Console.WriteLine($"Today is {day} and it is day {(int)day}.");

            switch (day)
            {
                case Days.Monday:
                    break;
                case Days.Tuesday:
                    break;
                case Days.Wednesday:
                    break;
                case Days.Thursday:
                    break;
                case Days.Friday:
                    break;
                case Days.Saturday:
                    break;
                case Days.Sunday:
                    break;
                default:
                    break;
            }
        }
    }
}
