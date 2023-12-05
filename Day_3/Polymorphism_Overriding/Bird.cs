namespace Polymorphism_Overriding;

public class Bird : Animal
{
    // This is will not work. The method being override must have same return type.
    // public override int MakeSound()
    // {
    //     Console.WriteLine("Chip..");
    //     return 0;
    // }

    public override void MakeSound()
    {
        // base.MakeSound(); // Untuk manggil fungsi parentnya
        Console.WriteLine("Chip..");
    }
}
