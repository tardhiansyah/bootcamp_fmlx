using Inheritances;

class Progran
{
    static void Main()
    {
        Cat kuro = new Cat();
        kuro.Meow();
        kuro.colour = "Black";
        kuro.age = 3;
        
        Dog dog1 = new Dog("Bro");
        dog1.name = "Rocky";

        Console.WriteLine(kuro.colour);
        Console.WriteLine(kuro.age);
        Console.WriteLine(dog1.name);
    }
}