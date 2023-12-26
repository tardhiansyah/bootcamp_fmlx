class Program
{
    static void Main()
    {
        #if DEBUG || DEVELOPMENT
        Console.WriteLine("Development...");
        #elif RELEASE
        Console.WriteLine("Release...");
        #endif
    }
}