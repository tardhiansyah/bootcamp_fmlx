using System.Diagnostics;
using System.Text;
using System.Threading.Tasks.Dataflow;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length != 3)
            return;

        if (args[0] != "-n")
            return;

        string FilePath = args[1];
        string message = args[2];

        await WriteToFile(FilePath, message);
        string result = await ReadFile(FilePath);
        
        Console.WriteLine(result);
    }
    

    static async Task WriteToFile(string FilePath, string message)
    {
        using (FileStream fs = new(FilePath, FileMode.OpenOrCreate, FileAccess.Write))
        {
            string base64String = Base64Encode(message);
            byte[] buffer = Encoding.UTF8.GetBytes(base64String);

            await fs.WriteAsync(buffer, 0, buffer.Length);
        }
    }

    static async Task<string> ReadFile(string FilePath)
    {
        string plainText = "";

        using (FileStream fs = new FileStream(FilePath, FileMode.Open))
        {
            byte[] buffer = new byte[fs.Length];
            await fs.ReadAsync(buffer, 0, buffer.Length);

            string contentbase64 = Encoding.UTF8.GetString(buffer);
            plainText = Base64Decode(contentbase64);
        }

        return plainText;
    }
    

    static string Base64Encode(string plainText)
    {
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        return Convert.ToBase64String(plainTextBytes);
    }

    static string Base64Decode(string base64text)
    {
        var stringText = Convert.FromBase64String(base64text);
        return Encoding.UTF8.GetString(stringText);
    }
}