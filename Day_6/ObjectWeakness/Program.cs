using System.Collections;

class Program
{
    static void Main()
    {
        // * Fixed size
        // ! Not safety
        object[] myArray = {1, "true", true, 5, 3.0f};

        // * Dynamic size
        // ! Not safety too (gak dipakai)
        ArrayList arrlist = new ArrayList();
        arrlist.Add(1);
        arrlist.Add(true);
        arrlist.Add("true");

        foreach (var item in myArray)
        {
            Type type = item.GetType();
            Console.WriteLine(type);
        }

        foreach (var item in arrlist)
        {
            Type type = item.GetType();
            Console.WriteLine(type);
        }
    }
}