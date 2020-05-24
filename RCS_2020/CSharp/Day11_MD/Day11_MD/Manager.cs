using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Manager : Employee
    {
        public int YearsOfExperiance { get; set; }

        public Manager(string name, string age, int monthlySalary, int yearsOfExperiance)
        {
            this.Name = name;
            this.Age = age;
            this.MonthlySalary = monthlySalary;
            this.YearsOfExperiance = yearsOfExperiance;
        }

        private List<Manager> _managers = new List<Manager>();

        private static int AddYearsOfExperiance()
        {
            Console.Write("Add years of experaince: ");
            return int.Parse(Console.ReadLine());
        }

        public static void AddManager()
        {
            Console.WriteLine("Add manager details:");
            _managers.Add(new Manager(Employee.AddName(), Employee.AddAge(), Employee.AddMonthlySalary(), AddYearsOfExperiance()));
        }

        public void PrintManagers()
        {
            if (_managers.Count > 0)
            {
                foreach (var item in _managers)
                {
                    Console.WriteLine($"--- Manager info ---");
                    Console.WriteLine($"Name: {Name}, Age: {Age}, Monthly Salary: {MonthlySalary}, Years of experiance: {YearsOfExperiance}");
                }
            }
        }
    }
}
