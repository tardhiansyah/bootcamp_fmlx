class Program
{
    static void Main()
    {
        Task<int> task = AddAsync(3,4);
        Console.WriteLine(task.Result);

        // Task<int> task = Task.Run(() => AddAsync(3,4));
        // await task;
        // Console.WriteLine(task);

        // Task<int> task = AddAsync(3,4);
        // Console.WriteLine(await task);

        // int task = await AddAsync(3,4);
        // Console.WriteLine(task);

        // Console.WriteLine(await AddAsync(3,4));
    }

    static async Task<int> AddAsync(int a, int b)
    {
        await Task.Delay(1000);
        return a + b;
    }
}