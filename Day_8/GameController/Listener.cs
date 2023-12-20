using System.Numerics;

namespace GameController;

public static class UI
{
    public static void CardUpdated(ICard card, CardStatus status)
    {
        Console.WriteLine($"Card : {card.ID} status changed to {status}");
    }

    public static void PlayerCreated(IPlayer player)
    {
        Console.WriteLine($"Player : {player.Name} ({player.ID}) Created");
    }
}

public static class DataBase
{
    public static void LogToDB(ICard card, CardStatus status)
    {
        Console.WriteLine($"{DateTime.Now} - Card : {card.ID} status changed to {status}");
    }

    public static void LogToDB(IPlayer player)
    {
        Console.WriteLine($"{DateTime.Now} - Player : {player.Name} ({player.ID}) Created");
    }
}
