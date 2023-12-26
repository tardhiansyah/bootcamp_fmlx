using Polymorphism_MethodHiding
;

class Program
{
    static void Main()
    {
        Animal animal = new();
        animal.MakeSound();

        Cat cat = new();
        cat.MakeSound();

        // Jika pada Overriding animal.MakeSound() akan berubah jadi method child-nya
        // Pada MethodHiding tidak akan berubah
        animal = cat;
        animal.MakeSound();

    }
}