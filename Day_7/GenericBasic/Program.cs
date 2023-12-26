using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        CustomCollection<int> custom = new CustomCollection<int>(20);
        // custom.Add(0, "1");  // Error karena sudah diset int
        custom.Add(0, 5);
        custom.Add(2, 4);

        Console.WriteLine(custom.GetValue(0));
        Console.WriteLine(custom.GetValue(1));  // Return default value 0
    }
}


class CustomCollection <T>
{
    T[] myArray;

    public CustomCollection(int size)
    {
        myArray = new T[size];
    }

    public void Add(int idx, T value)
    {
        myArray[idx] = value;
    }

    public T GetValue(int idx)
    {
        return myArray[idx];
    }
}