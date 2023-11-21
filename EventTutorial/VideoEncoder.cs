// public class VideoEventArgs : EventArgs
// {
//     public Video Video { get; set; }
// }

public class VideoEncoder
{
    // 1 - Define delegate
    // 2 - Define the event based on the delegate
    // 3 - Raise the event
    // Detailed way
    // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    // public event VideoEncodedEventHandler VideoEncoded;

    // Simplefied way
    public EventHandler<string> VideoEncoded;   // if there are argument needed (VideoEventArgs)
    public EventHandler VideoEncoding;          // No argument needed 

    public void Encode(Video video)
    {
        Console.WriteLine("Video Encoder: Encoding...");
        OnVideoEncoding();

        Thread.Sleep(3000);
        
        OnVideoEncoded(video.Title);
    }

    // Raise the event
    protected virtual void OnVideoEncoded(String title)
    {
        if (VideoEncoded != null)
        {
            VideoEncoded(this, title);
        }
    }

    protected virtual void OnVideoEncoding()
    {
        if (VideoEncoding != null)
        {
            Console.WriteLine("Please Wait");
            VideoEncoding(this, EventArgs.Empty);   // Default nya itu parameter ngikut (object? source, EventArgs e)
        }
    }
}