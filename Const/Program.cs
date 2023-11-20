class Program
{
    static void Main()
    {
        MathLib ml = new();
        Console.WriteLine(MathLib.phi);
    }
}

class MathLib
{
    public const int phi = 314; // COnst ini milik class bukan instances
}