using System;
using System.Collections.Generic;
using System.Text;

namespace MD8._2
{
    class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        List<Student> students = new List<Student>();

        public void AddStudnet(string name, string surename, int age)
        {
            if (age > 7)
            {
                students.Add(new Student()
                {
                    Name = name,
                    Surname = surename,
                    Age = age
                });
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Student is too young! Min age is 7");
                Console.ResetColor();
            }
        }

        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"School name: {Name}, Address: {Address}");
            Console.WriteLine("Student info:");
            Console.ResetColor();

            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
                Console.ResetColor();
            }

        }
    }
}
