namespace ClassCastingImplementation;

public class GameController
{
    public IPlayer player;
    public GameController(IPlayer p)
    {
        player = p;
    }

    public void PlayerChecker()
    {
        if (player.GetPlayerType() == "online")
        {
            OnlinePlayer online = (OnlinePlayer) player;
            online.GetId();
        }
        if (player.GetPlayerType() == "offline")
        {
            OfflinePlayer offline = (OfflinePlayer) player;
            offline.GetId();
        }
    }
}
