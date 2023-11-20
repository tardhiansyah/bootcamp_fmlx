// ! Jangan pakai DYNAMIC
// ! Mudah error, terus ngabisin resource.

using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        // dynamic will be checked at running time
        // sedangkan var will be checked at compile time
        dynamic a = 3;
        a = "hello";
        a = true;

        a = new Car();
        a.Running();
        a.Run();    // ! Ini pas compile gak akan error
    }
}

class Car
{
    public void Running()
    {
        Console.WriteLine("Running");
    }
}