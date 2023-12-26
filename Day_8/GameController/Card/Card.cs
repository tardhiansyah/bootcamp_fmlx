namespace GameController;

public class Card : ICard
{
    public int ID { get; private set; }

    public CardStatus Status { get; set; }

    public CardColor Color { get; private set; }

    public override int GetHashCode()
    {
        return ID;
    }

    public Card(int id, CardColor color)
    {
        ID = id;
        Color = color;
        Status = CardStatus.OnDeck;
    }
}
