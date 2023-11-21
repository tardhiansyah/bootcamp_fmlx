// Single Delegate
public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        // Create delegate
        MyDelegate mydel = Displayer;

        // Add delegate
        mydel += Farmer;

        // Call delegate
        mydel();
        mydel.Invoke();
    }

    static void Displayer()
    {
        Console.WriteLine("Displayer");
    }

    static void Farmer()
    {
        Console.WriteLine("Farmer");
    }
}