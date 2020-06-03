using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_16
{
    class FileManager
    {
        private static string tempFolder
        {
            get { return "C:\\temp\\"; }
        } 
        public static string studentsDB
        {
            get { return "C:\\temp\\studenst.csv"; }
        }

        public static void AppendToFile(string student)
        {
            if (!FindDuplicateStudent(studentsDB, student))
            {
                StreamWriter streamWriter = new StreamWriter(studentsDB, true);
                streamWriter.WriteLine(student);
                streamWriter.Close();
            }
        }
        public static Boolean FindDuplicateStudent(string fullPath, string student)
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
                    line = sr.ReadLine();
                    if (line == student)
                    {
                        sr.Close();
                        return true;
                    }
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: File not found!");
            }
            return false;
        }
    }
}
