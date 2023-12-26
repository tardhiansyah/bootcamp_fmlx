class Program
{
    static void Main()
    {
        Panda p1 = new Panda("Robert");
        Panda p2 = new Panda("Downey");

        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);

        Console.WriteLine(Panda.population);
        // Console.WriteLine(Panda.name);      // !ERROR
        // Console.WriteLine(p1.population)    // !ERROR

    }
}
