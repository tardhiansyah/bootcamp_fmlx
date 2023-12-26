using System.Diagnostics;
using Tugas_1;

class Program
{    
    static void Main()
    {
        // * Add custom checker condition
        FooBar.AddCondition(6, "Buzz");
        FooBar.AddCondition(2, "Fizz");
        FooBar.AddCondition(9, "Bro");
        FooBar.AddCondition(7, "Sis");
        
        // * Remove custom checker condition
        FooBar.RemoveCondition(0);
        FooBar.RemoveCondition(7);

        // * Get custom checker condition
        Console.WriteLine($"All Checker Conditions  : {FooBar.GetCondition()}");
        Console.WriteLine($"Conditions for number 3 : {FooBar.GetCondition(3)}");


        // * Get input Number
        int userInput = GetUserInputNumber();

        // * Check only the inputted number
        Console.WriteLine(FooBar.CheckOnce(userInput));

        // * Check all number (from 0 to inputted number)
        Console.WriteLine(FooBar.Check(userInput));

        // * Check range of number
        Console.WriteLine($"Case 1: {FooBar.Check(0, 15)}");
        Console.WriteLine($"Case 2: {FooBar.Check(5, 15)}");
        Console.WriteLine($"Case 3: {FooBar.Check(15, 0)}");
        Console.WriteLine($"Case 4: {FooBar.Check(15, 5)}");
        Console.WriteLine($"Case 5: {FooBar.Check(0, -15)}");
        Console.WriteLine($"Case 6: {FooBar.Check(-5, -15)}");
        Console.WriteLine($"Case 7: {FooBar.Check(-15, 0)}");
        Console.WriteLine($"Case 8: {FooBar.Check(-15, -5)}");
        Console.WriteLine($"Case 9: {FooBar.Check(15, -15)}");
        Console.WriteLine($"Case 10: {FooBar.Check(-15, 15)}");
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