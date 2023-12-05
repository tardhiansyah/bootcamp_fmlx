// Multicast delegate for function from class with parameter
public delegate void MyDelegate(string a);

class Program
{
    static void Main()
    {
        MyDelegate mydel;
        Information info = new();

        mydel = info.Displayer;
        mydel += info.Yusuf;

        // Give params in Invoke
        mydel.Invoke("Hello Brow");
    }
}

class Information
{
    public void Displayer(string notif)
    {
        Console.WriteLine($"Displayer: {notif}");
    }

    public void Yusuf(string notif)
    {
        Console.WriteLine($"Yusuf: {notif}");
    }
}