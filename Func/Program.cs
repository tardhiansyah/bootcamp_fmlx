// Func and Lambda Function

class Program
{
    static void Main()
    {
        // Action ini kaya delegate void
        Action<bool> x;
        Action<bool, bool, int, int, bool> y;

        // Function ini delegate yang ada return type nya
        Func<int, int, bool> comparer = Comparison;
        comparer += (int a, int b) => a == b;

        Console.WriteLine(comparer.Invoke(3, 3));
    }

    static bool Comparison(int a, int b)
    {
        return a == b;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}