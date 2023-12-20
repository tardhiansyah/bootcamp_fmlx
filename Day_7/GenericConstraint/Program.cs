using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator<int>.Add((int) 2.5f, 3));

        
        Car car = new(10);
        Car car2 = new(50);
        
        // Ini baru bisa diterapin kalau si car udah nerapin IAdditionOperators
        Console.WriteLine(Calculator<Car>.Add(car, car2));
        
    }
}

static class Calculator<T> where T: IAdditionOperators<T, T, T>
{
    public static T Add(T a, T b)
    {
        // a + b baru bisa diterapin kalau sit tipe T nerapin IAdditionOperator
        // kalau gk pake bakal error
        return a + b;
    }
}

class Car: IAdditionOperators<Car, Car, Car>
{
    public int price;
    public Car(int p)
    {
        price = p;
    }
    public static Car operator +(Car left, Car right)
    {
        return new Car(left.price + right.price);
    }
}