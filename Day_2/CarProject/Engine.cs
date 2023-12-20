namespace CarComponent;

public class Engine
{
    public int numberOfCylinder;
    public string brand;

    public Engine(int cylinder, string brand)
    {
        this.numberOfCylinder = cylinder;
        this.brand = brand;
    }

    public void Start()
    {
        Console.WriteLine("Starting Engine..");
    }
}
