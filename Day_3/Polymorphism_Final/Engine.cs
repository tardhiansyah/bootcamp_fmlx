namespace Polymorphism_Final;

public class Engine
{
    public virtual void Start()
    {
        Console.WriteLine("Engine Start");
    }

    public virtual void Start(int i)
    {
        Console.WriteLine($"Engine Start {i}");
    }
}
