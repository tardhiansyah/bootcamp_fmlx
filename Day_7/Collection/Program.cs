using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Dumper;

class Program
{
    static void Main()
    {
        // Indexable Collections
        List<string> fish = new() {"Hiu", "Pari", "Paus"};

        foreach (var item in fish)
        {
            item.Dump();
        }

        // Remove element from list
        if (fish.Remove("Hiu"))
        {
            Console.WriteLine("hiu dihapus");
        }

        // Add lagi hiu
        fish.Add("Hiu");
        foreach (var item in fish)
        {
            Console.WriteLine(item);
        }

        // Test dumper
        "Hello World".Dump();

        Console.WriteLine();



        // Remove element at specific indexes
        List<int> numbers = new() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        for (var index = numbers.Count - 1; index >= 0; index--)
        {
            if (numbers[index] % 2 == 1)
            {
                numbers.RemoveAt(index);
            }
        }

        // Ini Lambda Function
        numbers.ForEach(numbers => Console.WriteLine(numbers + " ")); 
    }
}

