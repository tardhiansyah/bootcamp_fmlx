using System.Text;

class Program
{
    static void Main()
    {
        string path = "bootcampfile.txt";

        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);

            string text = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(text);
        }
    }
}