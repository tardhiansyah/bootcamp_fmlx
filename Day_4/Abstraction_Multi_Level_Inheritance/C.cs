namespace Abstraction_Multi_Level_Inheritance;

class C : B
{
    public override void methodA2()
    {
        Console.WriteLine("Class C - A2");
    }
    public override void methodA3()
    {
        Console.WriteLine("Class C - A3");
    }
    public override void methodB()
    {
        Console.WriteLine("Class C - B");
    }
}