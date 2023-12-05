class Program
{
    static void Main()
    {
        // Walaupun string termasuk reference type
        // Tapi value nya akan terus berubah. Karena string itu imutable

        string text = "hello";
        Console.WriteLine(text);

        // string* textAddr = &text;
        // IntPtr addr = (IntPtr)textAddr;
        // Console.WriteLine(addr.ToSting("x"));


        string text2 = text;
        Console.WriteLine(text2);


        text2 = "World";
        Console.WriteLine(text2);

    }
}

