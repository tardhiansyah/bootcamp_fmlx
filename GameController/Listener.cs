using System.Numerics;

namespace GameController;

public class UI
{
    public void CardUpdated(INumberCard card, CardStatus status)
    {
        Console.WriteLine($"Card : {card.ID} status changed to {status}");
    }
}

public class DataBase
{
    public void LogToDB(ICard card, CardStatus status)
    {
        Console.WriteLine($"{DateTime.Now} - Card : {card.ID} status changed to {status}");
    }

    public void LogToDB(IPlayer card, CardStatus status)
    {
        Console.WriteLine($"{DateTime.Now} - Card : {card.ID} status changed to {status}");
    }
}
