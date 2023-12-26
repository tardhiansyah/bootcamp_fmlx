using Inheritance_D;

class Program
{
    static void Main()
    {
        Child child = new Child(1,2,3,4);
        Parent parent = child;
        Console.WriteLine(parent.a);
        Console.WriteLine(parent.b);
        // Console.WriteLine(parent.c);  // Error karena c dan d hanya dimiliki child
        // Console.WriteLine(parent.d);


        Parent parent1 = new Parent(1,2);
        // Child child1 = parent;  // Error tidak bisa parent mengisi child


    }
}