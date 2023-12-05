using System.Diagnostics;

class Program
{
    static void Main()
    {
        object obja = "3";
        object objb = 4;
        object[] objects = {11, 20, "5", true, 25, "false"};  

        Add(obja, objb);

        Check(objects);

        // Unboxing
        // int inta = Convert.ToInt32(obja);        // * Ini OK
        int intb = (int) objb;                      // * Ini OK
        int inta = int.Parse((string) obja);        // * Ini OK
        Console.WriteLine(inta);
        Console.WriteLine(intb);
    }

    static void Check(object[] c)
    {
        foreach (var i in c)
        {
            if (i is int)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Add(object a, object b)
    {
        // Standard
        if (a is int && b is int)
        {
            int resulta = (int) a;
            int resultb = (int) b;
            Console.WriteLine(resulta + resultb);
        }

        // Use pattern matching
        if (a is float floata && b is float floatb)
        {
            Console.WriteLine(floata + floatb);
        }
    }
}