using System.Diagnostics;

class Program
{
    static void Main()
    {
        int userID = 123;
        string pass = "password";

        Debug.Indent();
        Debug.WriteLine(userID + "       " + pass, "Notification");
        Debug.WriteLineIf(pass == "password", "Password is too generic", "Warning");
        Debug.Assert(Add(1, 2) == 3, "1 + 2 Seharusnya 3");
        Trace.WriteLine("userID and Password inserted");
    }
    
    /// <summary>
    /// Method untuk penjumlahan
    /// </summary>
    /// <param name="a"> Double pertama </param>
    /// <param name="b"> Double kedua </param>
    /// <returns></returns>
    static int Add(int a, int b)
    {
        return a * b;
    }
}