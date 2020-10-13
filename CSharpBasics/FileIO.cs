using System.IO;
using System;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText("Text.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWriting()
        {
            File.WriteAllText("A.html", "New File is created.");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Directory: {z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.file", "This is my own file.");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"F:\Vedaslab\Badal.Shakya\CSharpBasics";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File count: " + files.Length);
        }
    }
}