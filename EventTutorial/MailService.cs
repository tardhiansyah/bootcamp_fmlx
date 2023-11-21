public class MailService
{
    public void OnVideoEncoded(object source, string args)
    {
        Console.WriteLine("Sending Email.." + args);
    }
    public void OnVideoEncoding(object source, EventArgs e)
    {
        Console.WriteLine("Wait until encoding done");
    }
}
