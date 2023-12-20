using System.Xml.XPath;

class Program
{
    static void Main()
    {
        Console.WriteLine("Intialized");

        int result;
        Thread thread = new Thread(() => 
        {
            result = Add(1,3);
        });

        Console.WriteLine(result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}