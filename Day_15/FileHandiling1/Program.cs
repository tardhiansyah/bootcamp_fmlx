class Program
{
    static void Main()
    {
        string FilePath = @".\My File.txt";

        using (FileStream fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None ))
        {
            Console.WriteLine("File has been opened and the Path is MyFile.txt");
        }
    }
}