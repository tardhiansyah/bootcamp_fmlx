class Program
{
    static void Main()
    {
        GenericClass<int, int> genericClass = new(100);
        Console.WriteLine(genericClass.GenericMethod(30));

        GenericClass<int, int> genericClass2 = new(20);
        Console.WriteLine(genericClass2.GenericMethod(10));
    }
}
