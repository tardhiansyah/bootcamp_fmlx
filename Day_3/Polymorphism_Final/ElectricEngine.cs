namespace Polymorphism_Final;

public class ElectricEngine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Electric Engine Starting");
    }

    // ? Ini gak akan di hide juga walau pake new (dianggap method yang beda)
    // ? Juga bakal error kalo pake override (karena beda sama virtualnya (parameterless))
    // Kalau di parent-nya gak ada method Start(int i). Soalnya si parent gk bisa akses method anak-anaknya
    public new void Start(int i)
    {
        Console.WriteLine("Electric Engine Starting {i}");
    }
}
