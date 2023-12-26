using System.ComponentModel;

class Program
{
    static async Task Main()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Main");
        CancellationTokenSource source = new();
        CancellationToken token = source.Token;

        // Register action/delegate yg akan dipanggil ketika token cancelled
        //token.Register(OnTested);

        Task task = Task.Run(() => DoLongRunningLoop(token));
        Task task1 = Task.Run(() => DoCheckUserInput(source));
        try
        {
            await task;
        }
        catch (Exception e)
        {

        }

        Console.WriteLine("\nProgram Finished");
    }

    static async Task DoLongRunningLoop(CancellationToken token)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " DoLongRunningLoop");

        for (int i = 0; i <= 100; i++)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }
            Console.WriteLine($"Task {i}%");
            await Task.Delay(10000, token);
        }
        Console.WriteLine($"Task Completed");
    }

    static async Task DoCheckUserInput(CancellationTokenSource source)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " DoCheckUserInput");
        if (Console.ReadKey().KeyChar == ' ')
        {
            source.Cancel();
        }
    }
}