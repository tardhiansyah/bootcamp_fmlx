namespace ClassCastingImplementation;

public abstract class Tile
{
    protected string type;
    protected string name;
    protected string description;

    public abstract string GetTileType();
    public abstract string GetName();
    public string GetDescription()
    {
        return description;
    }
}
