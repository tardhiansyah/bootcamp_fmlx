using System.Diagnostics;
using Tugas_1;

class Program
{    
    static void Main()
    {
        // * Get input Number
        int userInput = GetUserInputNumber();

        // * Check only the inputted number
        Console.WriteLine(FooBar.Check(userInput));

        // * Check all number (from 0 to inputted number)
        Console.WriteLine(FooBar.CheckAll(userInput));

        // * Check range of number
        Console.WriteLine($"Case 1: {FooBar.CheckAll(0, 15)}");
        Console.WriteLine($"Case 2: {FooBar.CheckAll(5, 15)}");
        Console.WriteLine($"Case 3: {FooBar.CheckAll(15, 0)}");
        Console.WriteLine($"Case 4: {FooBar.CheckAll(15, 5)}");
        Console.WriteLine($"Case 5: {FooBar.CheckAll(0, -15)}");
        Console.WriteLine($"Case 6: {FooBar.CheckAll(-5, -15)}");
        Console.WriteLine($"Case 7: {FooBar.CheckAll(-15, 0)}");
        Console.WriteLine($"Case 8: {FooBar.CheckAll(-15, -5)}");
        Console.WriteLine($"Case 9: {FooBar.CheckAll(15, -15)}");
        Console.WriteLine($"Case 10: {FooBar.CheckAll(-15, 15)}");

        // // * Change Foo value
        // FooBar.Foo = 0;
        // // * Change Bar value
        // FooBar.Bar = -7;
        // // * Check range of number with new Foo & Bar value
        // Console.WriteLine($"Case 11: {FooBar.CheckAll(-15, 15)}");
    }   

    static private int GetUserInputNumber()
    {
        while(true)
        {
            // * Read user input
            Console.WriteLine("Masukkan input nilai:");
            string? text = Console.ReadLine();

            // * Parse user input (string) to int n
            if (int.TryParse(text, out int n))
            {
                return n;
            }
        }
    }
}