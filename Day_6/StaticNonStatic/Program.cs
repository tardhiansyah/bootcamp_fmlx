class Program
{
    static void Main()
    {
        Car car = new Car("Honda");
        car.EngineRun();
        Car.EngineCheck();

        Car car2 = new Car("Toyota");
        car2.EngineRun();
        Car.EngineCheck();
    }
}

class Car
{
    public static string engineBrand;

    public Car(string brand)
    {
        engineBrand = brand;
    }

    public void EngineRun()
    {
        Console.WriteLine($"Run Engine: {engineBrand}");
    }

    public static void EngineCheck()
    {
        Console.WriteLine($"Check Engine: {engineBrand}");
    }
}