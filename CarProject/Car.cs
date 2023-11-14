using CarComponent;

public class Car
{
    public Engine engine;
    public Door door;
    public Tire tire;
    public string name;

    public Car(Engine engine, Door door, Tire tire, string name)
    {
        this.engine = engine;
        this.door = door;
        this.tire = tire;
        this.name = name;
    }

    public Car() {}

    public void Start()
    {
        this.engine.Start();
        this.door.Close();
        this.tire.CheckPressure();
        
        Console.WriteLine($"{this.name} now is ready!");
    }
}
