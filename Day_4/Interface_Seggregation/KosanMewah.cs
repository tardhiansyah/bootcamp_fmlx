namespace Interface_Seggregation;

public class KosanMewah : Kosan, IKosanMahal
{
    public void HidupkanAC()
    {
        Console.WriteLine("Nyalakan AC");
    }

    public void MatikanAC()
    {
        Console.WriteLine("Matikan AC");
    }
}
