// ! BETTER DON"T USE TUPLE

using System;

class Program
{
    static void Main()
    {
        (bool, int) result = Calculator.Add(3,4);
        bool status = result.Item1;
        int value = result.Item2;
        Console.WriteLine(status);
        Console.WriteLine(value);
    }
}

class Calculator
{
    public static (bool, int) Add(int a, int b)
    {
        if (a+b > 0)
        {
            return (true, a+b);
        }
        return (false, 0);
    }
    public int Add()
    {
        
        (bool, int) result = Add(3,4);
        return 0;
    }
}