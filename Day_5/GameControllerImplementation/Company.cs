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
