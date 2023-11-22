namespace GameController;

public interface ICard
{
    int ID { get; }
    public CardStatus Status { get; set; }
}

public interface INumberCard : ICard
{
    int Number { get; }
    CardColor Color { get; }
}