using System.Diagnostics;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Publisher radit = new(name: "Radiya Dika");
        Subscriber randomSubs = new();

        radit.UploadedVideo += randomSubs.GetNotif;
        radit.OnUploadedVideo();
    }
}


class Publisher
{
    public readonly string name;

    public event EventHandler<DataEventArgs>UploadedVideo;

    public Publisher(string name)
    {
        this.name = name;
    }

    public void OnUploadedVideo()
    {
        DataEventArgs dataEventArgs = new() { code = 1, information = "Video Baru", name = "C# Tutorial"};
        UploadedVideo?.Invoke(this, dataEventArgs);
    }

    public override string ToString()
    {
        return name;
    }
}


class Subscriber
{
    public void GetNotif(object? sender, DataEventArgs data)
    {
        Console.WriteLine($"Subscriber Got Notified from {sender}: {data.information} {data.name} {data.code}");
    }
}

class DataEventArgs: EventArgs
{
    public string name;
    public string information;
    public int code;
}