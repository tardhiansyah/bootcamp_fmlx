namespace Inheritance_B;

public class Animal
{
    public string colour;
    public int age;
    
    public Animal(string colour, int age)
    {
        this.colour = colour;
        this.age = age;
        Console.WriteLine($"Animal Created: {this.colour}, {this.age}");
    }
}
