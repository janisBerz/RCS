using System;
using System.IO;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            try
            {
                while (answer != "0")
                {
                    string[] directoryContent = FileManager.GetFolderContent(false);
                    Console.WriteLine();
                    Console.WriteLine("--- main menu ---");
                    Console.WriteLine("1 - Get Folder Content");
                    Console.WriteLine("2 - Create empty file");
                    Console.WriteLine("3 - Append to file");
                    Console.WriteLine("4 - Print file content");
                    Console.WriteLine("0 - Exit");
                    Console.WriteLine("------------------------");

                    Console.WriteLine();
                    Console.Write("Enter option: ");
                    Console.WriteLine();

                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            directoryContent = FileManager.GetFolderContent(true);
                            break;

                        case "2":
                            Console.Write("Please enter file name: ");
                            FileManager.NewFile(Console.ReadLine());
                            break;
                        case "3":
                            Console.WriteLine("Enter the file you would like to edit: ");
                            FileManager.AppendToFile(directoryContent[int.Parse(Console.ReadLine())]);
                            break;
                        case "4":
                            Console.WriteLine("Enter the file you would like to print: ");
                            FileManager.ReadFile(directoryContent[int.Parse(Console.ReadLine())]);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong :(((");
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
