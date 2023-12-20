namespace Class_Base_This;

public class Child : Parent
{
    public new int a;

    public Child(int a, int b) : base(a)
    {
        this.a = a;
        this.a *= b;
    }

    public void GetFromParrent()
    {
        Console.WriteLine(base.a);
    }

    public void GetFromChild()
    {
        Console.WriteLine(a);
    }

}
