﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16
{
    class Student
    {
        public Student(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            setCourse(course);
        }

        private String name;
        private String surname;
        private int course;

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
            foreach (var student in students)
            {
                Console.WriteLine($"name: {student.name}, surname: {student.surname}, year: {student.course}");
            }
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