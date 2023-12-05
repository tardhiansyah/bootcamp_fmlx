class Program
{
    static void Main()
    {
        Car a = new Car("Honda");
        
        Console.WriteLine(a);   // Ini berarti manggil ToString()
        string result = a.ToString();
        Console.WriteLine(result);
    }
}


class Car
{
    private string brand;
    public Car(string brand)
    {
        this.brand = brand;
    }

    // * It override from class Object
    public override string ToString()
    {
        return brand;
    }
}