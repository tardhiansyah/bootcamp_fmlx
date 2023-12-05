namespace Encapsulation;

public class Sedan : Car
{
    private string _name;
    public Sedan(string brand, string colour, int quantity = 4) : base(brand, colour, quantity)
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}
