namespace Polymorphism_MethodHiding;

public class Cat : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Meow..");
    }
}
