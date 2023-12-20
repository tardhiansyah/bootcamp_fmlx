public class Program
{
    static void Main()
    {
        Console.WriteLine("Starting program.");

        var task = new Thread(DoTask);

        task.Start();   // Running in Foreground
        task.IsBackground = true;    // Make it background. So it will be stopped after Main program exit

        task.Join();       // Wait until DoTask finished

        Console.WriteLine("Program complete.");
    }

    public static void DoTask()
    {
        Console.WriteLine("Starting task.");
        Thread.Sleep(2000);
        Console.WriteLine("Task complete.");
    }
}