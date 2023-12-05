class Program
{
    // Using deleagate
    public delegate void VideoEncodedEventHandler(int val);

    

    static void Main()
    {
        // Simplefied using Action
        Action<int> VideoUploaded = SendNotification2;
        VideoUploaded.Invoke(2);
        VideoEncodedEventHandler VideoEncoded = SendNotification;
        VideoEncoded.Invoke(5);
    }

    static void SendNotification(int number)
    {
        Console.WriteLine($"{number} Video(s) Encoded Successfully");
    }

    static void SendNotification2(int number)
    {
        Console.WriteLine($"{number} Video(s) Uploaded Successfully");
    }
}