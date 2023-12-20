class Program
{
    static void Main()
    {
        string path = @".\bootcamp.txt";

        // Write data
        using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Append)))
        {
            writer.WriteLine("Hello, Streamwriter");
            writer.WriteLine("This is another line of text.");
            writer.WriteLine("YAYAYAYAYA");
            writer.WriteLine("YOYOYOYOYO");
        }

        // Read data
        using (StreamReader reader = new StreamReader(File.Open(path, FileMode.Open)))
        {
            string line1 = reader.ReadLine();
            string line2 = reader.ReadLine();

            // Ini gak ngaruh
            reader.BaseStream.Position = 0;
            
            Console.WriteLine(reader.ReadLine());
            Console.WriteLine(line1);
			Console.WriteLine(line2);
			
        }
    }
}