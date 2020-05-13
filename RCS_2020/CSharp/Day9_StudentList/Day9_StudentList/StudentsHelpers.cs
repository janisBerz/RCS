using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_StudentList
{
    class StudentsHelpers
    {
        public static void AddStudnet(List<Students> studentList)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();

            int year = 0;

            try
            {
                Console.Write("Enter year: ");
                year = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }

            studentList.Add(new Students(name, surname, year));
        }

        public static void PrintAllStudents(List<Students> studentList)
        {
            Console.WriteLine("------ All Students ------");
            foreach (Students student in studentList)
            {
                Console.WriteLine($"Name: {student.Name}; Surname: {student.Surname}; Year: {student.Year}");
            }
            Console.WriteLine();
        }
    }
}
