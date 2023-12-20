namespace GameController;

public interface ICard
{
    int ID { get; }
    CardStatus Status { get; set; }
    CardColor Color { get; }
}

public interface INumberCard : ICard
{
    uint Number { get; }
}

public interface IDrawCard : ICard
{
    int DrawNumber { get; }
}