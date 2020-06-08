using System;
using System.Collections.Generic;
using System.Text;

namespace Day17
{
    class Student
    {
        // Thsi constructor is not necesarry becasue of auto-property 
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties#auto-implemented-properties
        public Student(String name, String surname, int course)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        private int _course;
        public int Course
        {
            get { return _course; }
            set
            {
                if (value > 3)
                {
                    _course = 3;
                }

                if (value < 1)
                {
                    _course = 1;
                }
            }
        }

        public string StudnetToString()
        {
            return $"{Name},{Surname},{Course}";
        }

        // where would I add this method to Student or FileManager class?
        public static void PrintStudents(List<Student> students)
        {
            int i = 0;
            foreach (var student in students)
            {
                Console.WriteLine($" ID: {i} name: {student.Name}, surname: {student.Surname}, year: {student.Course}");
                i++;
            }
        }

        public static void EditStudent(List<Student> students)
        {
            Console.Write("Entet student ID: ");
            int id = int.Parse(Console.ReadLine());
        }

        public static void RemoveStudent(List<Student> students)
        {
            Console.WriteLine($"Removing student: {students[int.Parse(Console.ReadLine())].Name}...");
            students.RemoveAt(int.Parse(Console.ReadLine()));
        }
    }
}