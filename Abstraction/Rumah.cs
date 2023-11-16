namespace Abstraction;

abstract class Rumah
{
    public readonly int i;
    public void BukaJendela()
    {
        Console.WriteLine("Buka Jendela");
    }
    public virtual void BukaGarasi()
    {
        Console.WriteLine("Tidak ada Garasi");
    }
    public abstract void BukaPintu();

    // Abstract harus ada semua di child
    // public abstract void NyalakanKipas();
}
