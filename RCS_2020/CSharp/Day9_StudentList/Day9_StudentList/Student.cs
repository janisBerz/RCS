using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_StudentList
{
    class Student
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Year { get; set; }

        List<Student> studentList = new List<Student>();

        public Student(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            Year = year;
        }

        public static void AddStudnet()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter name: ");
            string surname = Console.ReadLine();

            int year = 0;

            try
            {
                Console.Write("Enter name: ");
                year = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }

            studentList.Add(new Student(name, surname, year));
        }

        public static void PrintAllStudents(List<Student> students)
        {
            Console.WriteLine("------ All Students ------");
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}; Surname: {student.Surname}; Year: {student.Year}");
            }
            Console.WriteLine();
        }






    }
}
