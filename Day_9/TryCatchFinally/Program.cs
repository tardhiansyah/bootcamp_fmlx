using System.Runtime.ExceptionServices;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 0;

        try
        {
            int result = a/b;

        }
        catch (FormatException e)
        {
            Console.WriteLine($"{e.Message}");
        }
        finally
        {
            // Ada atau tidak ada exception, tetap tereksekusi
            Console.WriteLine("Finally");
        }

        // Kalau tipe exceptionnya salah, atau bukan super exception. Ini gak akan ke Execute
        Console.WriteLine("Next statment");
    }
}