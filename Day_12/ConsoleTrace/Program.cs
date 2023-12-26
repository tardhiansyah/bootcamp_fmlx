using System.Diagnostics;

class Program
{
    static void Main()
    {
        ConsoleTraceListener consoleTraceListener = new();
        Trace.Listeners.Add(consoleTraceListener);

        Trace.WriteLine("Trace listener starting");
        
        int a = 5;
        int b = 7;

        Trace.WriteLine($"a = {a}, b = {b}");

        int sum = a + b;

        Trace.WriteLine($"hasil: {sum}");
        Trace.WriteLine("Program complete");
    }
}