
class Program
{
    static void Main()
    {
        foreach(var item in func())
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
    public static IEnumerable<int> func()
    {
        yield return 1;
        yield return 2; 
        yield return 3;
        yield return 4;
        yield return 100;
    }
}