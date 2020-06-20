using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_21_MD
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _course;
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value > 4)
                {
                    _course = 4;
                }
                else if (value < 0)
                {
                    _course = 0;
                }
                else
                {
                    _course = value;
                }
            }
        }

        public Student(string name, string surname, int course)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
        }

        //public static void AddStudent(List<Student> students)
        //{
        //    Console.Write("Name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Surname: ");
        //    string surname = Console.ReadLine();

        //    Console.Write("Year: ");
        //    int year = int.Parse(Console.ReadLine());

        //    Student student = new Student(name, surname, year);

        //    students.Add(student);

        //    FileManager.SaveDB(students);
        //}

        //public static void RemoveStudent(List<Student> students)
        //{
        //    try
        //    {
        //        Console.WriteLine();
        //        Console.Write("Student ID: ");
        //        int _studentID = int.Parse(Console.ReadLine());
        //        Console.WriteLine($"Removing student: {students[(_studentID)].getName()}...");
        //        students.RemoveAt(_studentID);

        //        FileManager.SaveDB(students);
        //        Console.WriteLine();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"ERROR: Unable to remove studnet. Trace: {e.Message}");
        //    }
        //}
    }
}
