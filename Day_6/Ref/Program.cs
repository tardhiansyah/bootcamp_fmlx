// * Sebelum pake ref. si variabel harus di assign dulu
class Program
{
    static void Main()
    {
        int x = 5;
        Add(ref x);
        Console.WriteLine(x);
    }

    static void Add(ref int x)
    {
        x = 2;
    }

}