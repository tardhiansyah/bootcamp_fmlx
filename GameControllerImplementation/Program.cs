using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Tile[] tiles = new Tile[]
        {
			new City(100, "Jakarta", "Kota Jakarta"),
			new City(23, "Semarang", "Kota Jakarta"),
			new Company(1, "PLN", "Listrik Company"),
			new Jail()
		};
		GameController game = new(tiles);
        game.CallAction(0);
        game.CallAction(1);
        game.CallAction(2);
    }
}

class GameController
{
    readonly Tile[] tiles;

    public GameController(Tile[] ts)
    {
        tiles = ts;
    }

    public void CallAction(int index)
    {
        TileType type = tiles[index].type;
        if (type == TileType.City)
        {
            ((City) tiles[index]).Build();
        }
        else if (type == TileType.Company)
        {
            ((Company) tiles[index]).Buy();
        }
        else if (type == TileType.Jail)
        {
            // ((Jail) tiles[index]).Buy();
        }
    }
}