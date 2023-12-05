// * CODE REUSE

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(FeetToInches(30));
        Console.WriteLine(FeetToInches(20));
    }

    static int FeetToInches(int feet)
    {
        return feet * 12;
    }
}