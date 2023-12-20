using Polymorphism_Overriding;

class Program
{
    static void Main()
    {
        Animal animal = new();
        animal.MakeSound();

        Cat cat = new();
        cat.MakeSound();

        Dog dog = new();
        dog.MakeSound();

        Bird bird = new();
        bird.MakeSound();

        Ant ant = new();
        ant.MakeSound();

        
        // The Parent Method will be replaced by The Child Method
        animal = dog;
        animal.MakeSound();

        Animal animal2 = new Cat();
        animal2.MakeSound();
    }
}