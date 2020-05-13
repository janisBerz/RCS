using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_StudentList
{
    class Students
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }

        public Students(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            Year = year;
        }
    }
}
