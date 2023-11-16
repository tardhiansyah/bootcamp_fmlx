namespace Abstraction;

class RumahBiasa : Rumah
{
    public override void BukaPintu()
    {
        Console.WriteLine("Buka samping");
    }

    public override void BukaGarasi()
    {
        Console.WriteLine("Buka Pagar");
    }
}
