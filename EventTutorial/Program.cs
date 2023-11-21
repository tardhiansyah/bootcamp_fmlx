using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Video video = new Video();
        video.Title = "Tutorial Event";

        VideoEncoder videoEncoder = new VideoEncoder();     // Publisher
        MailService mailService = new MailService();        // Subscriber
        MessageService messageService = new();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
        videoEncoder.VideoEncoding += mailService.OnVideoEncoding;
        videoEncoder.VideoEncoding += messageService.OnVideoEncoding;
        videoEncoder.Encode(video);
    }
}
