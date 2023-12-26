class Program
{
    static void Main()
    {
        string filePath = "myfile.txt";

        using (StreamReader reader = new(filePath))
        {
            Console.WriteLine("Content of the file");
            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            string strData = "";
            do
            {
                strData = reader.ReadLine();
                Console.WriteLine(strData);
            } while (strData != null);
        }
    }
}