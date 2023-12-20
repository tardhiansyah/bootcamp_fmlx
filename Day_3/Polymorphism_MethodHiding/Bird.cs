namespace Polymorphism_MethodHiding;

public class Bird : Animal
{
    public new void MakeSound()
    {
        // base.MakeSound(); // Untuk manggil fungsi parentnya
        Console.WriteLine("Chip..");
    }
}
