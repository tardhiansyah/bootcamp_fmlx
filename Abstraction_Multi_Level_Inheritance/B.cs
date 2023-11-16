namespace Abstraction_Multi_Level_Inheritance;

abstract class B : A
{
    public abstract void methodB();
    public override void methodA()
    {
        Console.WriteLine("Class B - A");
    }
    public override void methodA2()
    {
        Console.WriteLine("Class B - A2");
    }
}