// Delegate with return number

public delegate int MyDelegate(int a, int b);

class Program
{
    static void Main()
    {
        MyDelegate myDelegate;
        var calc = new Calculator();

        myDelegate = calc.Add;
        myDelegate += calc.Sub;

        int result = myDelegate.Invoke(10, 2);     // Karena calc.Sub diexecute terakhir, maka hasil di result yang muncul adalah yg calc.Sub
        Console.WriteLine(result);
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }
}