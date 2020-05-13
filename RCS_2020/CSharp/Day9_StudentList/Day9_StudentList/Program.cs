using System;
using System.Collections.Generic;

namespace Day9_StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentList = new List<Students>();

            string answer = "";
            while (answer != "0")
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - print student list");
                Console.WriteLine("2 - Add new student");
                Console.WriteLine("0 - exit");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        StudentsHelpers.PrintAllStudents(studentList);
                        break;
                    case "2":
                        StudentsHelpers.AddStudnet(studentList);
                        break;
                    default:
                        Console.WriteLine("Wrong menu item selected!");
                        break;
                }
            }
        }
    }
}
