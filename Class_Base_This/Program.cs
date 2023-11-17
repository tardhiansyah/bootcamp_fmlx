using Class_Base_This;

public class Program
{
    static void Main()
    {
        Child child = new(2,5);
        Console.WriteLine(child.a);
        child.GetFromChild();
        child.GetFromParrent();

        Console.WriteLine();

        Parent parent = new(2);
        parent = child;
        Console.WriteLine(parent.a);
        child.GetFromChild();
        child.GetFromParrent();
    }
}