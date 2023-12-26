namespace CarComponent;

public class Door
{
    public int quantity;
    public int size;
    public string colour;

    public Door(string colour, int quantity, int size)
    {
        this.quantity = quantity;
        this.size = size;
        this.colour = colour;
    }

    public void Close()
    {
        Console.WriteLine("Closing all doors..");
    }
}
