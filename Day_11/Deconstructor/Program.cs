class Program
{
    static void Main()
    {
        Test();
        GC.Collect();       // ! Force Garbage Collection (Mark and Sweep)
        GC.WaitForPendingFinalizers();     // ! Execute / Sweep Finalizer List
        Console.ReadKey();
    }

    static void Test()
    {
        DestructorDemo obj1 = new();
    }
}

public class DestructorDemo
{
    public DestructorDemo()
    {
        Console.WriteLine("Create Instances");
    }

    ~DestructorDemo()
    {
        Console.WriteLine("Remove Instances");
    }
}