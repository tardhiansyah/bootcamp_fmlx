namespace ClassCastingImplementation;

public class OfflinePlayer : IPlayer
{
    private int _id;
    private string _name;

    public OfflinePlayer(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetPlayerType()
    {
        return "Offline";
    }
}

public class OnlinePlayer : IPlayer
{
    private int _id;
    private string _name;

    public OnlinePlayer(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetPlayerType()
    {
        return "Online";
    }
}
