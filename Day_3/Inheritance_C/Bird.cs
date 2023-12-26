namespace Inheritance_C;

public class Bird : Animal
{
    public string name;

    public Bird(string color, int age, string name = "no_name") : base(color, age)
    {
        this.name = name;
        Console.WriteLine($"Bird with name {this.name} is created");
    }

    public Bird(int age, string color)
    {
        this.age = age;
        this.colour = color;
    }
}
