using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15
{
    class FileManipulation
    {
        public static void ReversFileContent()
        {
            List<string> inputText = new List<string>();
            string line = "";

            StreamReader StreamReader = new StreamReader("c:\\temp\\test.txt");
            StreamWriter StreamWriter = new StreamWriter("c:\\temp\\testNew.txt");
            line = StreamReader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                inputText.Add(line);
                line = StreamReader.ReadLine();
            }
            StreamReader.Close();

            for (int i = 0; i > -inputText.Count; i--)
            {
                StreamWriter.WriteLine(inputText[i + inputText.Count - 1]);
            }
            StreamWriter.Close();
        }
    }
}
