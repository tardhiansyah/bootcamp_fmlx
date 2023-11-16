namespace Interface;

public class Orang : Keluarga, IPermintaanOrtu, IPermintaanPribadi
{
    public void Kuliah()
    {
        Console.WriteLine("Kamu Harus Kuliah");
    }

    public void PunyaJetPribadi()
    {
        Console.WriteLine("Kamu Harus Punya Jet Pribadi");
    }
}
