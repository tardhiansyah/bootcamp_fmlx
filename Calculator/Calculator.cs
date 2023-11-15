namespace Tools;

public class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	
	public int Adds(params int[] numbers)
	{
		int result = 0;
		foreach(int i in numbers)
		{
			result += i;
		}
		return result;
	}
	
	public int Subtract(int a, int b = 0)
	{
		return a - b;
	}
	
	public int Multiply(int a, int b)
	{
		return a * b;
	}
}
