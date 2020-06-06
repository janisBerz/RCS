using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Day17
{
    class FileManager
    {
        public static string studentsDB
        {
            get { return "C:\\temp\\studenst.json"; }
        }

        public static void SaveDB(List<Student> students)
        {
            Console.WriteLine("Saving student to DB...");
            StreamWriter streamWriter = new StreamWriter(studentsDB);

            string studentsJson = JsonConvert.SerializeObject(students);
            streamWriter.WriteLine(studentsJson);
            streamWriter.Close();
        }

        public static List<Student> ReadDB()
        {
            Console.WriteLine("Reading student DB...");

            List<Student> students = new List<Student>();
            string stringStudents = "";

            if (!File.Exists(studentsDB))
            {
                Console.WriteLine("Error: Student DB not found. Creating new DB...");
                StreamWriter streamWriter = new StreamWriter(studentsDB);
                streamWriter.Close();
            }

            StreamReader sr = new StreamReader(studentsDB);
            stringStudents = sr.ReadToEnd();
            sr.Close();

            if (stringStudents.Length == 0)
            {
                Console.WriteLine("Error: The Student DB is empty!");
                return students;
            }
            students = JsonConvert.DeserializeObject<List<Student>>(stringStudents);
            return students;
        }
    }
}
