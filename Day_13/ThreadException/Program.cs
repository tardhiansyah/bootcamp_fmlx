class Program
{
    static void Main()
    {
        Thread thread = new Thread( () => {throw new InvalidCastException("Catch me if you can!"); });

        try
        {
            thread.Start();
            thread.Join();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}