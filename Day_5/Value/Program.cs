// Value
class Program
{
    static void Main()
    {
        int a = 5;
        int b = a;
        b = 3;

        // Value a dan b akan beda karena keduanya beda memori.
        // Keduanya disimpan di stack.
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}