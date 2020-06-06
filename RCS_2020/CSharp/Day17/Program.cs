using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load student DB from file
            List<Student> students = FileManager.ReadDB();
            string answer = null;

            //Start the menu
            while (answer != "0")
            {
                Console.WriteLine("--- menu --");
                Console.WriteLine("1 - add student");
                Console.WriteLine("0 - exit");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        AddStudent(students);
                        Student.PrintStudents(students);
                        break;
                    default:
                        Console.WriteLine("Please enter the correct option");
                        break;
                }
            }
        }

        public static void AddStudent(List<Student> students)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Student student = new Student(name, surname, year);

            students.Add(student);

            FileManager.SaveDB(students);
        }
    }
}
