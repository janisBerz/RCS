using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Programmer : Employee
    {
        public string Language { get; set; }

        public Programmer(string name, int age, double monthlySalary, string Language)
        {
            this.Name = name;
            this.Age = age;
            this.MonthlySalary = monthlySalary;
            this.Language = Language;
        }
    }



}
