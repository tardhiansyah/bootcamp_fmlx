using System.Reflection.Metadata.Ecma335;

namespace Polymorphism_Overloading;

public class Animal
{
    protected string colour;
    protected int age;

    public void MakeSound()
    {
        Console.WriteLine("Animal Make Sound");
    }
}
