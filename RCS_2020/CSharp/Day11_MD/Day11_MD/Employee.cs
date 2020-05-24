using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Employee
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int MonthlySalary { get; set; }

        public static string AddName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }
        public static string AddAge()
        {
            Console.Write("Age: ");
            return Console.ReadLine();
        }
        public static int AddMonthlySalary()
        {
            Console.Write("MonthlySalary: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
