namespace Polymorphism_Overriding;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow..");
    }
}
