using System;
using System.Collections.Generic;

namespace Day9_StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            string answer = "";
            while (answer != "0")
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - print student list");
                Console.WriteLine("2 - Add new student");
                Console.WriteLine("0 - exit");

                switch (answer)
                {
                    case "1":
                        Student.PrintAllStudents(studentList);
                        break;
                    case "2":
                        Student.AddStudnet();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
