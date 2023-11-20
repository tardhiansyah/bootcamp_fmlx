/*
  The results displayed will be as requested.
  e.g:
  FooBar.CheckAll(-3, 3)  -->  -3, -2, -1, 0, 1, 2, 3
  FooBar.CheckAll(3, -3)  -->  3, 2, 1, 0, -1, -2, -3
 */

using System.Text;

namespace Tugas_1;

public static class FooBar
{
    private static int _foo = 3;
    private static int _bar = 5;

    // TODO: Handling supaya user tidak bisa set _foo = 0 & _bar = 0 ?
    // public static int Foo
    // {
    //     get { return _foo; }
    //     set { _foo = value; }
    // }
    // public static int Bar
    // {
    //     get { return _bar; }
    //     set { _bar = value; }
    // }


    // * Check only the inputted number
    public static string Check(int number)
    {
        if (number == 0)
        {
            return number.ToString();
        }

        if (number % (_foo * _bar) == 0)
        {
            return "foobar";
        }
        else if (number % _foo == 0)
        {
            return "foo";
        }
        else if (number % _bar == 0)
        {
            return "bar";
        }
        else
        {
            return number.ToString();
        }
    }

    // * Check from 0 to inputted number
    public static string CheckAll(int number)
    {
        return (number < 0) ? CheckAll(number, 0) : CheckAll(0, number);
    }

    // * check the numbers in the range
    public static string CheckAll(int start, int end)
    {
        bool reverse = start > end;

        StringBuilder sb = new();
        for (int i = start; reverse ? (i >= end) : (i <= end); i += reverse ? -1 : 1)
        {
            sb.Append(Check(i));

            if (reverse ? (i > end) : (i < end))
            {
                sb.Append(", ");
            }
        }
        
        return sb.ToString();
    }
}
