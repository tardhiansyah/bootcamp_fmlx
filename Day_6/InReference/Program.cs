using System.Diagnostics;

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota");
        ChangeBrand(in car);
        Console.WriteLine(car.brand);
    }

    static void ChangeBrand(in Car x)
    {
        x.brand = "Honda";  // It's Ok
        // x = new Car("Honda");   // THis ERROR, because Car (the class) passed is readonly
    }
}

class Car
{
    public string brand;
	public readonly int[] myArray = { 1, 2, 3};
	public Car(string b) {
		brand = b;
	}
}