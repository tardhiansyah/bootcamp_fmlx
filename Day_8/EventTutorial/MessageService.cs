public class MessageService
{
    public void OnVideoEncoded(object source, string e)
    {
        Console.WriteLine("Sending Message.." +  e);
    }
    public void OnVideoEncoding(object source, EventArgs e)
    {
        Console.WriteLine("Wait until encoding done");
    }
}