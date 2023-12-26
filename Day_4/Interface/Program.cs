using Interface;

class Program
{
    static void Main()
    {
        Orang saya = new Orang();
        Console.WriteLine(saya.name);

        saya.Kuliah();
        saya.PunyaJetPribadi();
    }
}