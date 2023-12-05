namespace Interface_Seggregation_Implementation;

public class Player : IPlayer
{
    private int _id;
    private string _name;

    public int GetID()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }
}

public class MLPlayer : Player
{
    private int _id;
    private string _name;
    private string _userName;
    private int _level;

    public bool isConnected()
    {
        return true;
    }
}

class CODPlayer : IPlayer
{
	private int _id;
	private string _name;
	private string _username;
	private int _level;

	public bool ConnectToServer()
	{
		return true;
	}
	public int GetID()
	{
		return _id;
	}
	public string GetName()
	{
		return _name;
	}
}

class PBPlayer
{
	private int _id;
	private string _name;
	private string _username;
	private int _level;

	public bool ConnectToServer()
	{
		return true;
	}
	public int GetID()
	{
		return _id;
	}
	public string GetName()
	{
		return _name;
	}
}