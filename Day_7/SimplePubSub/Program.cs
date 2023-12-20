public delegate void MySubscriber(string message);

class Program
{
    static void Main()
    {
        Subscriber sub1 = new();
        Subscriber2 sub2 = new();
		Radio rad = new();


        Youtuber yanto = new();
        yanto.AddSubscriber(sub1.GetNotified);
        yanto.AddSubscriber(sub2.GetNotified2);
        yanto.AddSubscriber(rad.GetInform);
        yanto.RemoveSubscriber(sub1.GetNotified);
        Console.WriteLine(yanto.CheckHistorySubscriber(sub1.GetNotified));

        yanto.UploadVideo();
    }
}

class Youtuber
{
    private MySubscriber _subs;
    private HashSet<MySubscriber> _history = new();

    public void UploadVideo()
    {
        Console.WriteLine("Upload Video..");
        Console.WriteLine("Upload Completed");
        SendNotification("Video Uploaded");
    }
    private void SendNotification(string msg)
    {
        _subs?.Invoke(msg);
    }
    public bool AddSubscriber(MySubscriber subscriber)
    {
        if (_subs == null)
        {
            _history.Add(subscriber);
            _subs += subscriber;
            return true;
        }

        Delegate[] delegates = _subs.GetInvocationList();
        if (delegates.Contains(subscriber))
        {
            return false;
        }

        _history.Add(subscriber);
        _subs += subscriber;
        return true;
    }
    public bool RemoveSubscriber(MySubscriber subscriber)
    {
        _subs -= subscriber;
        return true;
    }
    public bool CheckHistorySubscriber(MySubscriber subscriber)
    {
        if (_history.Contains(subscriber))
        {
            return true;
        }
        return false;
    }
}

class Subscriber
{
	public void GetNotified(string message)
	{
		Console.WriteLine("Subscriber: " + message);
	}
}
class Subscriber2
{
	public void GetNotified2(string message)
	{
		Console.WriteLine("Subscriber 2: " + message);
	}
}
class Radio
{
	public void GetInform(string message)
	{
		Console.WriteLine("Radio: " + message);
	}
}