using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(Wrapper);
        
        thread.Start();
        thread.Join();

        Console.WriteLine("Finished");
    }

    static void Wrapper()
    {
        try
        {
            Except();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Gotch u: {e.Message}");
        }
    }

    static void Except()
    {
        throw new InvalidCastException("Can you catch me?");
    }
}