using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15
{
    class FileManager
    {
        private static string tempFolder
        {
            get { return "C:\\temp\\"; }
        }

        public static string[] GetFolderContent(bool print)
        {
            string[] directoryContent = Directory.GetFiles(tempFolder);

            if (print)
            {
                for (int i = 0; i < directoryContent.Length; i++)
                {
                    Console.WriteLine($"{i} - {directoryContent[i]}");
                }
            }
            return directoryContent;
        }

        public static void NewFile(string fileName)
        {
            string fullPath = tempFolder + fileName + ".txt";

            if (!File.Exists(fullPath))
            {
                StreamWriter streamWriter = new StreamWriter(fullPath);
                streamWriter.Close();
            }
            else if (File.Exists(fullPath))
            {
                Console.WriteLine($"File {fullPath} already exists?");
                Console.WriteLine($"Overwrite (y/n)?");

                switch (Console.ReadLine())
                {
                    case "y":
                        StreamWriter streamWriter = new StreamWriter(fullPath);
                        streamWriter.Close();
                        break;
                    case "n":
                        Console.WriteLine("File not saved");
                        break;
                    default:
                        break;
                }
            }

        }

        public static void NewFile(string fileName, string payload)
        {
            string fullPath = tempFolder + fileName + ".txt";
            if (!File.Exists(fullPath))
            {
                StreamWriter streamWriter = new StreamWriter(fullPath);
                streamWriter.WriteLine(payload);
                streamWriter.Close();
            }
            else if (File.Exists(fullPath))
            {
                Console.WriteLine($"File {fullPath} already exists?");
                Console.WriteLine($"Overwrite (y/n)?");

                switch (Console.ReadLine())
                {
                    case "y":
                        StreamWriter streamWriter = new StreamWriter(fullPath);
                        streamWriter.WriteLine(payload);
                        streamWriter.Close();
                        break;
                    case "n":
                        Console.WriteLine("File not saved");
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AppendToFile(string fullPath)
        {
            //string fullPath = tempFolder + fileName;
            StreamWriter streamWriter = new StreamWriter(fullPath, true);

            Console.Write("Enter text you would like to append to file: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("Save to a new file (y/n)?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                    Console.Write("Enter filename: ");
                    NewFile(Console.ReadLine(), inputText);
                    break;
                case "n":
                    streamWriter.WriteLine(inputText);
                    streamWriter.Close();
                    break;
                default:
                    Console.WriteLine("Please enter y or n!");
                    break;
            }
        }
        public static void ReadFile(string fullPath)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(fullPath);
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Fails netika atrasts");
                throw;
            }
        }

        //public static void WriteToFile()
        //{
        //    try
        //    {
        //        StreamWriter sw = new StreamWriter("C:\\temp\\temp.txt", true);
        //        sw.WriteLine();
        //        sw.Write("sdfsfgsfgs");
        //        sw.Close();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Nevar ierakstit faila!!!");
        //        throw;
        //    }
        //}
    }
}
