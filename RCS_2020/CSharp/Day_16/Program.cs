using System;
using System.Collections.Generic;
using System.IO;

namespace Day_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;

            while (answer != "0")
            {
                Console.WriteLine("--- menu --");
                Console.WriteLine("1 - add student");
                Console.WriteLine("2 - print students");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        FileManager.AppendToFile(AddStudent().StudnetToString());
                        break;
                    case "2":
                        PrintStudents();
                        break;
                    default:
                        Console.WriteLine("Please enter the correct option");
                        break;
                }
            }
        }

        // Is this the correct aproach to use constructor in a method outside the Student.cs file?
        public static Student AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Student student = new Student(name, surname, year);

            return student;
        }

        // where would I add this method to Student or FileManager class?
        public static void PrintStudents()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(FileManager.studentsDB);
                line = sr.ReadLine();

                while (line != null)
                {
                    line = sr.ReadLine();
                    string[] a = line.Split(",");

                    Console.WriteLine($"name: {a[0]}, surname: {a[1]}, year: {a[2]}");
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: File not found! Message: {e.Message}");
            }

        }
    }
}
