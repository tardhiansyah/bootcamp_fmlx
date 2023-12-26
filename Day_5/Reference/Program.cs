class Program
{
    static void Main()
    {
        Number number = new Number(3);
        Number number2 = number;

        // Keduanya akan sama karena mengacu pada alamat (reference) pada memori yang sama di Heap
        Console.WriteLine(number.a);
        Console.WriteLine(number2.a);

        // Untuk membuat alamat baru di Heap pake keyword new
        Number number3 = new Number(4);

        // Mengganti alamat number3 dengan alamat number
        number3 = number;
        Console.WriteLine(number.a);
        Console.WriteLine(number3.a);

    }
}

class Number
{
    public int a;

    public Number(int a)
    {
        this.a = a;
    }
}