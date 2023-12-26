using System;

static class Program
{
    static void Main()
    {
        int x = 3;
        SomeMethod();
        SomeMethod2();

        void SomeMethod()           // * Local method
        {
            Console.WriteLine(x);
        }
    }

    static void SomeMethod2()
    {
        // Console.WriteLine(x);    // Error
    }
}