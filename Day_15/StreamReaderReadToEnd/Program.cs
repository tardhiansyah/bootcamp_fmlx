using System;
using System.IO;
namespace FileHandlinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "MyFile.txt";

            Console.WriteLine("Content of the File");
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            
            Console.ReadKey();
        }
    }
}