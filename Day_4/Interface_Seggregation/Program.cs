// Interface Seggregation Principle (ISP)
// Multiple small interfaces instead of one big interface

using Interface_Seggregation;

class Program
{
    static void Main()
    {
        Kosan kosan = new();
        kosan.BukaPintu();
        kosan.Tidur();
        kosan.BukaJendela();
        kosan.AksesLemari();

        KosanMewah kosanMewah = new();
        kosanMewah.HidupkanAC();
        kosanMewah.Tidur();
    }
}