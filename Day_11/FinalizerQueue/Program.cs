class Program
{
    static void Main()
    {
        Test();
        GC.Collect();
        GC.WaitForPendingFinalizers();   
    }

    static void Test()
    {
        Child child = new Child();
    }
}


class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent Created");
    }

    ~Parent()
    {
        Console.WriteLine("Parent Removed");
    }
}

class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child Created");
    }

    ~Child()
    {
        Console.WriteLine("Child Removed");
    }
}