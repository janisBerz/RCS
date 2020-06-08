using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_16
{
    class FileManager
    {
        public static string studentsDB
        {
            get { return "C:\\temp\\studenst.csv"; }
        }

        public static void SaveDB(List<Student> students)
        {
            Console.WriteLine("Updating students DB...");

            foreach (var student in students)
            {
                if (!FindDuplicateStudent(studentsDB, student))
                {
                    StreamWriter streamWriter = new StreamWriter(studentsDB);
                    streamWriter.WriteLine($"{student.getName()},{student.getSurname()},{student.getCourse()}");
                    streamWriter.Close();
                }
            }
        }

        public static List<Student> ReadDB()
        {
            Console.WriteLine("Reading student DB...");

            List<Student> students = new List<Student>();
            string line = "";
            StreamReader sr = new StreamReader(studentsDB);

            if (!File.Exists(studentsDB))
            {
                Console.WriteLine("Student DB not found. Creating new DB...");
                StreamWriter streamWriter = new StreamWriter(studentsDB);
                streamWriter.Close();
            }

            line = sr.ReadLine();
            while (line != null)
            {

                string[] a = line.Split(',');
                Student student = new Student(a[0], a[1], int.Parse(a[2]));
                students.Add(student);
                line = sr.ReadLine();
            }
            sr.Close();
            return students;
        }

        public static Boolean FindDuplicateStudent(string fullPath, Student student)
        {
            string line;
            try
            {
                if (!File.Exists(fullPath))
                {
                    StreamWriter streamWriter = new StreamWriter(fullPath);
                    streamWriter.Close();
                }

                StreamReader sr = new StreamReader(fullPath);
                line = sr.ReadLine();

                while (line != null)
                {
                    if (line == $"{student.getName()},{student.getSurname()},{student.getCourse()}")
                    {
                        Console.WriteLine($"Found duplicate: {student.StudnetToString()}");
                        sr.Close();
                        return true;
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: File not found! {e.Message}");
            }
            return false;
        }
    }
}
