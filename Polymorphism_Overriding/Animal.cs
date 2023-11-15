namespace Polymorphism_Overriding;

public class Animal
{
    protected string colour;
    protected int age;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Make Sound");
    }
}
