using Inheritance_B;

class Program
{
    static void Main()
    {
        Bird bird = new Bird("Chirp", "Yellow", 2);
        Console.WriteLine(bird.age);
        Console.WriteLine(bird.colour);
        Console.WriteLine(bird.name);
    }
}