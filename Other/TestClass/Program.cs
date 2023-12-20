class TestClass
{
    // Args diberikan setelah nama program yang dijalankan
	static void Main(string[] args)
    {
        Console.WriteLine(args.Length);

        if (args.Length == 2 && args[0] == "-n")
        {
            Console.WriteLine(args[1]);
        }
    }
}