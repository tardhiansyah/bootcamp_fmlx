namespace Interface_Seggregation;

public class Kosan : IBasicFurniture, IKosan
{
    public void AksesLemari()
    {
        Console.WriteLine("Buka Lemari");
    }

    public void BukaJendela()
    {
        Console.WriteLine("Buka Jendela");
    }

    public void BukaPintu()
    {
        Console.WriteLine("Buka Pintu");
    }

    public void Tidur()
    {
        Console.WriteLine("Tidur ZZZZ");
    }

}
