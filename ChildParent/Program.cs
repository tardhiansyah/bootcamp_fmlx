using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        Parent p = new();
        Child c = new();


        p.MethodParent();       // OK
        // p.MethodChild();     // ERROR   

        // * Ini OK
        Parent p2 = c;
        Child c2 = (Child) p2;   // Explicitly casting p2 (parent) to child
        c2.MethodParent();      // OK
        c2.MethodChild();       // OK

        // * Ini OK JUGA
        Parent p3 = new Child();    // Di memory dia udah punya DNA si child tapi ke hide
        Child c3 = (Child) p3;      // Istilahnya di balikin lagi fungsi childnya yg ke hide
        c3.MethodChild();


        // * Ini ERROR
        Child c4 = (Child) new Parent();
        c4.MethodParent();      // OK
        c4.MethodChild();       // ERROR

        // ? Implicit casting
        Parent p4 = new Child();
        p4.MethodParent();

    }
}


public class Parent
{
    public void MethodParent()
    {
        Console.WriteLine("Method Parent");
    }
}

public class Child : Parent
{
    public void MethodChild()
    {
        Console.WriteLine("Method Child");
    }
}