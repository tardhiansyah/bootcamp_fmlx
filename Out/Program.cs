using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string number = "30a";
        int.TryParse(number, out int a);
        Console.WriteLine(a);

        int x = 5;
        
    }
    
    static void Add(out int y)
    {
        y = 0;
        
    }
}