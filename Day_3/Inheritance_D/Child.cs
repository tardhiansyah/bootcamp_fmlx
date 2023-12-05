namespace Inheritance_D;

public class Child : Parent
{
    public int c;
    public int d;

    public Child(int a, int b, int c, int d) : base(a, b)
    {
        this.c = c;
        this.d = d;
    }
}
