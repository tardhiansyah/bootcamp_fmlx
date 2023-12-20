using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new();

        int nWorkerThread;
        int nCompletionPortThread;
        ThreadPool.GetMinThreads(out nWorkerThread, out nCompletionPortThread);
        Console.WriteLine($"{nWorkerThread} {nCompletionPortThread}");

        Console.WriteLine("Execution using Thread");
        stopwatch.Start();
        MethodWithThread();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.ElapsedTicks}");

        stopwatch.Reset();
        Console.WriteLine("Execution using Task");
        stopwatch.Start();
        MethodWithTask();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.ElapsedTicks}");

        stopwatch.Reset();
        Console.WriteLine("Execution using Async Task");
        stopwatch.Start();
        MethodWithAsyncTask();
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.ElapsedTicks}");
    }

    static void MethodWithThread()
    {
        Thread[] myThread = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            myThread[i] = new Thread(Test);
            myThread[i].Start();
        }

        for (int i = 0; i < 10; i++)
        {
            myThread[i].Join();
        } 
    }

    static void MethodWithTask()
    {
        Task[] myTasks = new Task[10];

        for (int i = 0; i < 10; i++)
        {
            myTasks[i] = Task.Run(() => Test());
        }

        Task.WaitAll(myTasks);
    }

    static async void MethodWithAsyncTask()
    {
        Task[] myTasks = new Task[10];

        for (int i = 0; i < 10; i++)
        {
            myTasks[i] = Task.Run(() => Test());
        }

        await Task.WhenAll(myTasks);
    }

    static void Test()
    {

    }
}