// Extension Method. Digunakan untuk menambah method dari suatu class yg sudah ada
// Ini safety ya.. dan direkomendasikan

using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Car car = new();
        car.Cetak("Toyota");
        car.EngineRun();
    }   
}

class Car
{
    public void EngineRun()
    {
        // Console.WriteLine("Engine Running");
    }
}

// Utk extension, class harus static dan public
public static class IniExtension
{
    // this object obj refer to the object / class. in this context refer to car
    // Followed by the parameter. Mirip kaya ngasih argument di console kalo di Python
    public static void Cetak(this object obj, string text)
    {
        Console.WriteLine(text);
    }
}