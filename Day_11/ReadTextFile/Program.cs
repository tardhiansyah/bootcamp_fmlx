using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        string? line;
        string filePath = "D:\\Hello World.txt";
        using ( StreamReader reader = new StreamReader(filePath) )
        {
            do
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            } 
            while (line != null);
        }
    }
}

