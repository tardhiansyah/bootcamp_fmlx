namespace GameController;

public class NumberCard : Card, INumberCard
{
    public uint Number {get; private set;}

    public NumberCard(int id, CardColor color, uint number) : base(id, color)
    {
        Number = number;
    }
}