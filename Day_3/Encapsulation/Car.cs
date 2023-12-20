using System.Security.Cryptography;

namespace Encapsulation;

public class Car
{
    protected string brand;
    protected string colour;
    protected readonly int cylinderQuantity;
    
    protected Car(string brand, string colour, int quantity)
    {
        this.brand = brand;
        this.colour = colour;
        cylinderQuantity = quantity;
    }

    public void CarStart()
    {
        for (int i = 0; i < cylinderQuantity; i++)
        {
            Console.WriteLine(EngineCheck(i));
        }
        Console.WriteLine("LETS GOO!!!");
    }
    public string GetBrand()
    {
        return brand;
    }
    public string GetColour()
    {
        return colour;
    }

    private string EngineCheck(int cylinderNumber)
    {
        return $"Engine Number {cylinderNumber}: OK";
    }
}
