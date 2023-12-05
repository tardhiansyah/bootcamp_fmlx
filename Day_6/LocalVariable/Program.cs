// Ini Top Level Statments
// int a = 3;
// Add(a);
// Console.WriteLine(a);

// void Add(int n)
// {
//     a += n;
// }


// Kalau dipecah si top level statment jadi gini
class Program
{
    static void Main()
    {
        int a = 2;
        Add(a);
        Console.WriteLine(a);

        void Add(int n)
        {
            a += n;
        }
    }
}