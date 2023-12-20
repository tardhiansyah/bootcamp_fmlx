﻿//Exception Handler
// try - catch
// try = execute
// catch = if try throw exception, will catched by `catch`

class Program
{
    static void Main()
    {
        Console.WriteLine("Program initialized");

        int a = 10;
        int b = 0;

        Console.WriteLine("Program running");

        try
        {
            int result = a/b;
            Console.WriteLine(result);
        }
        // catch(DivideByZeroException e) {
		// 	Console.WriteLine($"{e.Message}");
		// }
		catch(IndexOutOfRangeException e) {
			Console.WriteLine($" index out ");
		}
		catch (Exception e)
		{
			Console.WriteLine($"{e.Message}");
		}
		Console.WriteLine("Program finish");     
    }
}