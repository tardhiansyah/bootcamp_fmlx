namespace Inheritance_B;

public class Bird : Animal
{
    public string name;

    public Bird(string name, string color, int age) : base(color, age)
    {
        this.name = name;
        Console.WriteLine($"Bird with name {this.name} is created");
    }
}
