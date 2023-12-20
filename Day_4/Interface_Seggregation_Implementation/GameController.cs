namespace Interface_Seggregation_Implementation;

public class GameController
{
    public IPlayer player;
    public GameController(IPlayer iplayer)
    {
        player = iplayer;
    }
}
