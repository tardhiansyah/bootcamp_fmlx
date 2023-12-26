namespace Abstraction;

class Kontrakan : RumahBiasa
{
    // ? Kalau dipanggil base.BukaPintu yg kepanggil kakek atau ayahnya
    public override void BukaPintu()
    {
        // * Yang dipanggil itu yg rumah biasa.
        base.BukaPintu();
    }
}
