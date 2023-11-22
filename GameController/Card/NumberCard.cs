namespace GameController;

public class NumberCard : INumberCard
{
    public int ID { get; private set; }
    public int Number  { get; private set; }
    public CardColor Color  { get; private set; }
    public CardStatus Status { get; set; }
    public override int GetHashCode()
    {
        return ID;
    }

    public NumberCard(int id, int number, CardColor color)
    {
        ID = id;
        Number = number;
        Color = color;
        Status = CardStatus.OnDeck;
    }
}

// public class NumberCard : INumberCard
// {
//     public NumberCardStatus Status { get; set; }

//     public int ID { get; private set; }
// }