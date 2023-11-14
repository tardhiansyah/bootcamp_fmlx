using Tools;

class Program
{
	static void Main()
	{
		Calculator calc = new Calculator();
		
		int result = calc.add(1,2);
		Console.WriteLine(result);
		
		int result2 = calc.adds(1,2,3,4,5,6,7,8);
		Console.WriteLine(result2);
		
		int[] numbers = {3,4,5};
		Console.WriteLine(calc.adds(numbers));
	}
}