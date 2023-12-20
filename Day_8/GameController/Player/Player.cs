namespace GameController;

public class Player : IPlayer
{
    public int ID { get;}
    public string Name { get; }

    public Player(int ID, string name)
    {
        this.ID = ID;
        Name = name;
    }

}
