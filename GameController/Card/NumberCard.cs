namespace GameController;

public class NumberCard : Card, INumberCard
{
    public int Number {get; private set;}

    public NumberCard(int id, CardColor color, int number) : base(id, color)
    {
        Number = number;
    }
}