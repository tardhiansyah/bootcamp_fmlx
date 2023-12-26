class Program
{
    static void Main()
    {
        int a;
        AddTwo(out a);
        Console.WriteLine(a);   
    }
    
    static void AddTwo(out int y)
    {
        y = 0;
        y += 2;
    }
}