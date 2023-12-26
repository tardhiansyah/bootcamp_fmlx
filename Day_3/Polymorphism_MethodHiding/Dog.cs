namespace Polymorphism_MethodHiding;

public class Dog : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
