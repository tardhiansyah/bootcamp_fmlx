namespace DepedencyInjection;

public class Player: IPlayer
{
    private string _name;
    public Player(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string Name)
    {
        if (Name.Length > 2)
        {
            _name = Name;
        }
           
    }

    public override string ToString()
    {
        return _name;
    }
}
