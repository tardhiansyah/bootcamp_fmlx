class Program
{
    static void Main()
    {
        // * Get input Number
        int n = GetUserInputNumber();

        // * Check for negative input
        int negativeSign = (n < 0) ? -1 : 1;
        n *= negativeSign;
        
        for (int i = 0; i <= n; i++)
        {
            // * Check the "FooBar" for every number
            CheckFooBar(i * negativeSign);

            // * Print delimiter to Console
            if (i < n)
            {
                Console.Write(", ");
            }
        }
    }

    static private int GetUserInputNumber()
    {
        while(true)
        {
            // * Read user input
            Console.WriteLine("Masukkan input nilai:");
            string? text = Console.ReadLine();

            // * Parse user input (string) to int n
            int n = 0;
            if (int.TryParse(text, out n))
            {
                return n;
            }
        }
    }

    static private void CheckFooBar(int i)
    {
        // * Print "foo" if number modulo 3 equal 0, and
        // * Print "bar" if number modulo 5 equal 0, otherwise
        // * Print the number

        if ((i % 3 == 0 || i % 5 == 0) && Math.Abs(i) > 0)
        {
            if (i % 3 == 0)
            {
                Console.Write("foo");
            }
            if (i % 5 == 0)
            {
                Console.Write("bar");
            }
        }
        else
        {
            Console.Write(i);
        }
    }
}