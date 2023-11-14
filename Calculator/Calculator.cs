namespace Tools;

public class Calculator
{
	public int add(int a, int b)
	{
		return a + b;
	}
	
	public int adds(params int[] numbers)
	{
		int result = 0;
		foreach(int i in numbers)
		{
			result += i;
		}
		return result;
	}
	
	public int subtract(int a, int b = 0)
	{
		return a - b;
	}
	
	public int multiply(int a, int b)
	{
		return a * b;
	}
}
