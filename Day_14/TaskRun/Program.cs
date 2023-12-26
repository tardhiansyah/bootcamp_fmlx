class Program
{
    static void Main()
    {
        int a = 2;
        int b = 3;

        Task<int> task1 = Task.Run(() => Add(a,b));
        Task<int> task2 = Task.Run(() => Add(a,b));

        Console.WriteLine(task1.Result);
        Console.WriteLine(task2.Result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}