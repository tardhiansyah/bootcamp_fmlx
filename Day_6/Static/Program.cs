//Static
class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(3,4));
    }
}


static class Calculator
{
    // Jika semua method dan field di class static, maka class bisa di declare sebagai static class
	public static int Add(int a, int b) {
		return a + b;
	}
	public static int Div(int a, int b)
	{
		return a / b;
	}
	public static int Mul(int a, int b)
	{
		return a * b;
	}
	public static int Sub(int a, int b)
	{
		return a * b;
	}
}
