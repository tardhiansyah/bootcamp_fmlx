using System.Diagnostics;

class Program
{
    static void Main()
    {
        Thread t0 = new Thread(DoWorkSimple);
        t0.Start();

        Thread t1 = new Thread(new ThreadStart(DoWorkSimple));
        t1.Start();

        Thread t2 = new Thread(new ParameterizedThreadStart(DoWorkWithParameter));
        t2.Start("Hallo");

        Thread t3 = new Thread(
            new ThreadStart(DoWorkSimple),
            maxStackSize: 1024 * 102
        );

        Thread t4 = new Thread(new ThreadStart(DoWorkSimple));
        t4.Name = "Thread Name";
        t4.Start();

        Thread t5 = new Thread( () => DoWorkWithParameter2(2)); // Lambda Expression
        t5.Start();

        Thread t6 = new Thread(DoWorkWithParameter);
        t6.Start("parameter");
        
    }

    static void DoWorkSimple()
    {
        Console.WriteLine("Simple work: Thread ID={0}", Thread.CurrentThread.ManagedThreadId);
    }

    static void DoWorkWithParameter(object? param)
    {
        Console.WriteLine("Parameterized work: Thread ID={0}, Parameter='{1}'", Thread.CurrentThread.ManagedThreadId, param);
    }

    static void DoWorkWithParameter2(int number)
    {
        Console.WriteLine("Parameterized work: Thread ID={0}, Parameter='{1}'", Thread.CurrentThread.ManagedThreadId, number);
    }
}

