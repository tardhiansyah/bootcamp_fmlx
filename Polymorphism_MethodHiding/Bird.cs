namespace Polymorphism_Overloading;

public class Bird : Animal
{
    public new int MakeSound()
    {
        Console.WriteLine("Chip..");
        return 0;
    }
}
