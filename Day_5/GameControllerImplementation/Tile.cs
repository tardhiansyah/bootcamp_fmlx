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
