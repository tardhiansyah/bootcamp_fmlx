namespace Polymorphism_Overloading;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public float Add(float a, float b)
    {
        return a + b;
    }
    private string Add(string a, string b)
    {
        return a + b;
    }

    // public double Add(string a, string b)
    // {
    //     // Will be error because there are same method with same parameter
    // }
}
