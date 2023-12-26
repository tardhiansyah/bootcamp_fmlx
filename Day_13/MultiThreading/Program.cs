class Program
{
    static void Main()
    {
        Console.WriteLine("Start");

        Thread threada = new Thread(MethodA);
        Thread threadb = new Thread(MethodB);
        Thread threadc = new Thread(MethodC);

        threada.Start();
        threadb.Start();
        threadc.Start();

        threada.Join();
        threadb.Join();
        threadc.Join();

        Console.WriteLine("Finish");
    }

    static void MethodA()
    {
        Console.WriteLine("Hello A");
    }

    
    static void MethodB()
    {
        Console.WriteLine("Hello B");
    }

    
    static void MethodC()
    {
        Console.WriteLine("Hello C");
    }
}