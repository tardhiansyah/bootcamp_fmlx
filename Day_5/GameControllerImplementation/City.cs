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
