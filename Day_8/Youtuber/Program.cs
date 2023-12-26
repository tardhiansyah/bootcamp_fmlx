// Event Handler Generic

using System.Runtime.Loader;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Youtuber deddy = new("Deddy Corbuzier");
        Subscriber sub = new();
        
        deddy.NewNotif += sub.GetNotif;

        deddy.SendNotif();
    }
}

class Youtuber
{
    public readonly string Name;
    public event EventHandler NewNotif;

    public Youtuber(string name)
    {
        Name = name;
    }

    public void SendNotif()
    {
        NewNotif?.Invoke(this, EventArgs.Empty);
    }
    public override string ToString()
    {
        return Name;
    }
}

class Subscriber
{
    public void GetNotif(object? sender, EventArgs e)
    {
        Console.WriteLine($"Subscriber get notified from: {sender}");
    }
}