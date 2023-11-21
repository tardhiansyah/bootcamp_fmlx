// Multicast delegate from other class

public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate mydel;
        Information info = new();

        mydel = info.Displayer;
        mydel += info.Yusuf;

        mydel.Invoke();
    }
}

class Information
{
    public void Displayer()
    {
        Console.WriteLine("Displayer");
    }

    public void Yusuf()
    {
        Console.WriteLine("Yusuf");
    }
}