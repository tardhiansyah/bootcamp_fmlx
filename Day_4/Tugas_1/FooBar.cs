/*
  The results displayed will be as requested.
  e.g:
  FooBar.CheckAll(-3, 3)  -->  -3, -2, -1, 0, 1, 2, 3
  FooBar.CheckAll(3, -3)  -->  3, 2, 1, 0, -1, -2, -3
 */

using System.Text;

namespace Tugas_1;

public class FooBar
{
    private static readonly SortedDictionary<uint, string> _conditions = new()
    {
        {3, "Foo"},
        {5, "Bar"}
    };

    public static bool AddCondition(uint value, string text)
    {   
        if (value == 0)
            return false;
        
        if (_conditions.ContainsKey(value))
            _conditions[value] = text;
        else
            _conditions.Add(value, text);

        return true;
    }
    public static bool RemoveCondition(uint value)
    {
        if (value == 3 || value == 5)
            return false;

        return _conditions.Remove(value);
    }
    public static string GetCondition()
    {
        return "{" + string.Join("; ", _conditions.Select(item => $"{item.Key}:\"{item.Value}\"")) + "}";
    }
    public static string? GetCondition(uint key)
    {
        _conditions.TryGetValue(key, out string? value);
        return $"\"{value}\"";
    }

    public static string CheckOnce(int number)
    {
        if (number == 0)
            return number.ToString();
        
        StringBuilder sb = new();
        foreach (var item in _conditions)
        {
            if (number % item.Key == 0)
                sb.Append(item.Value);
        }

        if (sb.Length == 0)
            return number.ToString();

        return sb.ToString();
    }
    public static string Check(int number)
    {
        return Check(0, number);
    }
    public static string Check(int start, int end)
    {
        bool reverse = start > end;
        
        int step = reverse ? -1 : 1;

        StringBuilder sb = new();
        for (int i = start; reverse ? (i >= end) : (i <= end); i += step)
        {
            sb.Append(CheckOnce(i));
            if (reverse ? (i > end) : (i < end))
                sb.Append(", ");
        }
        return sb.ToString();
    }
}
