
class Program
{
    static void Main()
    {
        #region DEVELOPMENT
        #if (DEBUG)
        Console.WriteLine("Debug");
        #elif (PRODUCTION)
        Console.WriteLine("Production");
        #elif (DEVELOPMENT)
        Console.WriteLine("Development");
        #else
        Console.WriteLine("No Define Found");
        #endif
        #endregion

        #region PRINTING
        #warning not finished
        Console.WriteLine("Program Berjalan...");
        Console.ReadKey(false);
        #endregion
    }
}