using System;
using System.Collections.Generic;
using System.IO;

namespace Day_16
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
                Console.WriteLine("2 - print students");
                Console.WriteLine("3 - remove students");
                Console.WriteLine("4 - edit student");
                Console.WriteLine("5 - search student");
                Console.WriteLine("7 - add test data");
                Console.WriteLine("8 - drop student DB");
                Console.WriteLine("0 - exit");

                Console.Write("Enter operation: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        AddStudent(students);
                        break;
                    case "2":
                        Student.PrintStudents(students);
                        break;
                    case "3":
                        Student.RemoveStudent(students);
                        break;
                    case "4":
                        Student.EditStudent(students);
                        break;
                    case "5":
                        Student.SerchStudent(students);
                        break;
                    case "7":
                        for (int i = 0; i < 10; i++)
                        {
                            Student student = new Student(name: "Juris" + i, surname: "Burka" + i, course: i);
                            students.Add(student);
                            FileManager.SaveDB(students);
                        }
                        break;
                    case "8":
                        students.Clear();
                        FileManager.SaveDB(students);
                        break;

                    default:
                        Console.WriteLine("Please enter the correct option");
                        break;
                }
            }
        }

        // Is this the correct aproach to use constructor in a method outside the Student.cs file?
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
