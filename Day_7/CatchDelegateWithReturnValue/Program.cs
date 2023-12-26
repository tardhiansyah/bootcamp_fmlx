public delegate int MyDelegate(int a, int b);

class Program
{
    static void Main()
    {
        Calculator calc = new();

        MyDelegate myDelegate = calc.Add;
        myDelegate += calc.Sub;

        Delegate[] delegates = myDelegate.GetInvocationList();
        int[] result = new int[delegates.Length];

        int count = 0;
        foreach (MyDelegate del in delegates)
        {
            result[count] = del.Invoke(6, 5);
            count++;
        }

        foreach(int i in result)
        {
            Console.WriteLine(i);
        }
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