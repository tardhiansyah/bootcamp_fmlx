namespace Calculation
{
    class Program
    {
        static void Main()
        {
            NumberCalculation numberCalc = new();

            int a = 10;
            int b = 12;

            Console.WriteLine($"Addition of {a} and {b} is {numberCalc.Add(a, b)}");
			Console.WriteLine($"Subtraction of {a} and {b} is {numberCalc.Subtract(a, b)}");
			Console.WriteLine($"Multiplication of {a} and {b} is {numberCalc.Multiply(a, b)}");
			Console.WriteLine($"Division of {a} and {b} is {numberCalc.Divide(a, b)}");
        }
    }
}