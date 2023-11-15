using System.Reflection.Metadata.Ecma335;

namespace Polymorphism_Overloading;

public class Animal
{
    protected string colour;
    protected int age;

    // Boleh pake virtual atau nggak
    // Istilahnya virtual ini memperbolehkan method diganti oleh child (Overriding)
    // Atau nggak (Method Hiding)
    // 
    public virtual void MakeSound() 
    {
        Console.WriteLine("Animal Make Sound");
    }
}
