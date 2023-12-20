using System;
using System.IO;
namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyTestFile1.txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Create();
            Console.WriteLine("File has been created");
            Console.ReadKey();

            path = @"MyTestFile2.txt";
            fileInfo = new FileInfo(path);
            fileInfo.Delete();
            Console.WriteLine("File has been deleted");
            Console.ReadKey();

            path = @"MyTestFile2.txt";
            fileInfo = new FileInfo(path);
            StreamWriter str = fileInfo.CreateText();
            str.WriteLine("Hello");
            Console.WriteLine("File has been created with text");
            str.Close();
            Console.ReadKey();
        }
    }
}