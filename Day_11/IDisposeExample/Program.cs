class Program
{
    static void Main()
    {
        ResourceHandler resourceHandler = new("Test.txt");
        
        resourceHandler.WriteToMemory("Test Write");

        resourceHandler.Dispose();
    }
}
