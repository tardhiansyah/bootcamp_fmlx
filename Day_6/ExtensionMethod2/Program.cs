using System.Collections.Immutable;
using System.Reflection.PortableExecutable;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        int x = 3;
        int result = x.Tambah(2);
        result.Cetak();
        x.Cetak();

        string y = "hello";
        // y.Tambah();  // ! ERROR karena method Tambah cuma buat Int
        y.Cetak();
    }
}

public static class IniExtension
{
    // Artinya cuma buat int aja ini extensionnya
    public static int Tambah(this int a, int b)
    {
        return a+b;
    }

    public static void Cetak(this object a)
	{
		Console.WriteLine(a);
	}
}