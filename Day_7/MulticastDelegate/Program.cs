// Multicast delegate

// Create parameterless delegate function that return nothing
public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        // Create delegate instance
        MyDelegate mydel;

        // Add function you want to delegate
        mydel = Displayer;
        mydel += Yusuf;
        mydel.Invoke();     // Yang pertama dilakukan meng-execute Displayer, baru meng-execute Yusuf.

        // Remove function from delegate
        mydel -= Displayer;
        mydel();


    }

    // If u want to add this code to delegate, it must have same signature
    static void Displayer()
    {
        Console.WriteLine("Display");
    }
    static void Yusuf()
    {
        Console.WriteLine("Yusuf");
    }
}