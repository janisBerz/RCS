﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day17
{
    class Student
    {
        public Student(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            setCourse(course);
        }

        public String name;
        public String surname;
        public int course;

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setCourse(int course)
        {
            if (course > 3)
            {
                course = 3;
            }

            if (course < 1)
            {
                course = 1;
            }

            this.course = course;
        }

        public string StudnetToString()
        {
            return $"{name},{surname},{course}";
        }



        // where would I add this method to Student or FileManager class?
        public static void PrintStudents(List<Student> students)
        {
            int i = 0;
            foreach (var student in students)
            {
                Console.WriteLine($" ID: {i} name: {student.name}, surname: {student.surname}, year: {student.course}");
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
            Console.WriteLine($"Removing student: {students[int.Parse(Console.ReadLine())].getName()}...");
            students.RemoveAt(int.Parse(Console.ReadLine()));
        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public int getCourse()
        {
            return course;
        }

    }
}