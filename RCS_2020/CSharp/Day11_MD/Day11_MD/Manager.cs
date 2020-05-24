using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Manager : Employee
    {
        public int YearsOfExperiance { get; set; }

        public Manager(string name, int age, double monthlySalary, int yearsOfExperiance)
        {
            this.Name = name;
            this.Age = age;
            this.MonthlySalary = monthlySalary;
            this.YearsOfExperiance = yearsOfExperiance;
        }
    }
}
