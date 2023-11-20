using System.Collections;

class Program
{
    static void Main()
    {
        string[] numbers = {"1", "2" , "3" , "4"};

        Checker check = new();
        check.Checkers(numbers);
    }
}

class Checker
{
    // hanya bisa untuk reference type
    public void Checkers(params object[] obj)
    {
        Console.WriteLine(obj.Length);
    }
}