namespace CarComponent;

public class Tire
{
    public int size;
    public string brand;
   
    public Tire(int size, string brand)
    {
        this.size = size;
        this.brand = brand;
    }

    public void CheckPressure()
    {
        Console.WriteLine("Pressure OK");
    }
}
