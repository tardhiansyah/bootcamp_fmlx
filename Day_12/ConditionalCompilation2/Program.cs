class Program
{
    static void Main()
    {
        #if ANDROID
        Console.WriteLine("Android");
        #elif APPLE
        Console.WriteLine("Apple");
        #endif
    }
}