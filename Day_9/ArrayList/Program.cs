using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList myList = new();
        myList.Add(3);
        myList.Add(4);
        myList.Add("string");
        myList.Add(true);
        myList.Add(new Program());

        int value = (int)myList[0];
        Console.WriteLine(value);
    }
}