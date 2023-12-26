using Polymorphism_Overloading;

class Program
{
    static void Main()
    {
        Calculator calc = new();

        float result1 = calc.Add(3.5f, 1.0f);
        Console.WriteLine(result1);

        int result2 = calc.Add(1, 2);
        Console.WriteLine(result2);
        
    }
}