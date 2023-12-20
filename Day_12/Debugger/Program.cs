using System.ComponentModel;

class Program
{
    static void Main()
    {
        double a = 4.0;
        double b = 2.5;

        Calculator calc = new();
        double result = calc.Add(a, b);
        Console.WriteLine(result);

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                continue;

            result = calc.Add(i, i);    
            Console.WriteLine(result);
        }
    }
}

class Calculator
{
    public double Add(double a, double b)
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
        return a + b;
    }
}