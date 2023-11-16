namespace Abstraction;

class RumahMewah : Rumah
{
    public override void BukaPintu()
    {
        Console.WriteLine("Buka Keatas");
    }

    public override void BukaGarasi()
    {
        Console.WriteLine("Buka Pintu Garasi");
    }
}