using Abstraction;

class Program
{
    static void Main()
    {
        // Rumah r = new();    // ! Error karena gak bisa buat abstract
        RumahMewah rm = new();
        RumahBiasa rb = new();
        RumahSederhana rs = new();

        rm.BukaJendela();
        rm.BukaGarasi();
        rm.BukaPintu();
        Console.WriteLine();

        rb.BukaJendela();
        rb.BukaGarasi();
        rb.BukaPintu();
        Console.WriteLine();

        rs.BukaJendela();
        rs.BukaGarasi();
        rs.BukaPintu();
        Console.WriteLine();

        Kontrakan k = new();
        k.BukaPintu();
    }
}