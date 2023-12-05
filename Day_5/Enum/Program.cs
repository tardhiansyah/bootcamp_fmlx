class Program
{
    static void Main()
    {
        string month = MonthOfYear.March.ToString();
        Console.WriteLine(month);

        MonthOfYear count = MonthOfYear.December;
        Console.WriteLine(count);

        int count2 = (int) MonthOfYear.June;
        Console.WriteLine(count2);

        int x = 9;
        Console.WriteLine((MonthOfYear) x);
    }
}

public enum MonthOfYear
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}