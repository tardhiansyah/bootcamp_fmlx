class Program
{
    static void Main()
    {
        // Variable must be assigned before passed
        int a = 3;
        AddTwo(in a);
        Console.WriteLine(a);
    }

    static void AddTwo(in int x)
    {
        // x = 2;  // Error, karena in sifatnya ReadOnly
        Console.WriteLine(x);
    }
}