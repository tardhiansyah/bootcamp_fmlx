// Is: Type Checking
// As: Explicit cast for reference type
class Program
{
    static void Main()
    {
        object a = "Hello";
        string? resulta = a as string;
        Console.WriteLine(a);


        object b = true;
        var c = b;
        b = false;
        if (c is bool)
        {
            bool resultC = (bool) c;
            bool resiltB = (bool) b;
            Console.WriteLine(resultC);
            Console.WriteLine(b);
        }


        // * Low level
        Type type = b.GetType();
        Type type2 = typeof(Boolean);
        if (type == type2)
        {
            bool resultb = (bool) b;
            Console.WriteLine(resultb);
        }
    }
}