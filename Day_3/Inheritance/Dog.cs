namespace Inheritances;

public class Dog
{
    public string name;
    public Dog(string name)
    {
        this.name = name;
    }
    public void Bark()
    {
        Console.WriteLine("Woof..");
    }
}
