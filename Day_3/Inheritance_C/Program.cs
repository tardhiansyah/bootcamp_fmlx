using Inheritance_C;

class Program
{
    static void Main()
    {
        Bird chirp = new Bird(color: "Bill", age: 4);
        chirp.age = 3;
        chirp.name = "Chirp";
        chirp.colour = "brown";
    }
}