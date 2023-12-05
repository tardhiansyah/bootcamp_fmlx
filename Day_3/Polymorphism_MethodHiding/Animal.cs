namespace Polymorphism_MethodHiding;

public class Animal
{
    protected string colour;
    protected int age;

    // Boleh pake virtual atau nggak
    // Istilahnya virtual ini memperbolehkan method diganti oleh child (Overriding)
    // Atau nggak (Method Hiding)
    public void MakeSound() 
    {
        Console.WriteLine("Animal Make Sound");
    }
}
