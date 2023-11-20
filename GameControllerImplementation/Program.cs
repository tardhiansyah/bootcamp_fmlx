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
		GameController game = new GameController(tiles);
        game.CallAction(0);
        game.CallAction(1);
        game.CallAction(2);
    }
}

class GameController
{
    Tile[] tiles;

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

public enum TileType
{
    City,
    Company,
    Jail
}

public interface IProperty
{
    public int GetPrice();
    public void Buy();
}

public abstract class Tile
{
    public readonly TileType type;
    public readonly string description;
    public readonly string name;

    public Tile(TileType type, string description, string name)
    {
        this.type = type;
        this.description = description;
        this.name = name;
    }
    public Tile()
    {

    }
}

class City : Tile, IProperty
{
    private int _price;

    public City(int price, string description, string name) : base(TileType.City, description, name)
    {
        _price = price;
    }

    public void Buy()
    {
        Console.WriteLine("Buy City");
    }

    public int GetPrice()
    {
        return _price;
    }

    public void Build()
    {
        Console.WriteLine("Build city");
    }
}

class Company : Tile, IProperty
{
    private int _price;
    public Company(int price, string description, string name) : base(TileType.Company, description, name)
    {
        _price = price;
    }

    public void Buy()
    {
        Console.WriteLine("Buy Company");
    }

    public int GetPrice()
    {
        return _price;
    }
}

class Jail : Tile
{
    public void Roll()
    {
        // Roll;
    }
}