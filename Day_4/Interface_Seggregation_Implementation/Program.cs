using Interface_Seggregation_Implementation;

class Program
{
    static void Main()
    {
        Player player = new();
        MLPlayer mlplayer = new();
        PBPlayer pbplayer = new();
        CODPlayer codplayer = new();
        GameController gc = new(player);        // Bisa karena sudah kontrak
        GameController gc2 = new(mlplayer);     // Bisa karena sudah kontrak (lewat parentnya si player)
        GameController gc3 = new(codplayer);    // Bisa karena sudah kontrak
        // GameController gc4 = new(pbplayer);      // Error karena beda kontrak (interface)

    }
}