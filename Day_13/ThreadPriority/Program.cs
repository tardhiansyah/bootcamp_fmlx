using System.Formats.Tar;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() => 
        {
            Console.WriteLine("Thread 1 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Thread 1 Finished");
        });
        t1.Priority = ThreadPriority.Lowest;

        Thread t2 = new Thread(() => 
        {
            Console.WriteLine("Thread 2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Thread 2 Finished");
        });
        t2.Priority = ThreadPriority.Highest;

        // Start the threads
        t1.Start();
        t2.Start();
        
        // Wait for the threads to finish
        t1.Join();
        t2.Join();
        
        Console.WriteLine("All threads finished");
    }
}