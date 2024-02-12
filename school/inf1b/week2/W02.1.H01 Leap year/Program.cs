public class Program
{
    static void Main(string[] args)
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
    }

    public static bool IsDivisibleBy(int num, int devicebleBy) => num % devicebleBy == 0;
    public static bool IsLeapYear(int year) => IsDivisibleBy(year, 4) && IsDivisibleBy(year, 100) == false || IsDivisibleBy(year, 400);
    public static void PrintIsLeapYear(int year)
    {
        bool leapyear = IsLeapYear(year);
        if (leapyear) { System.Console.WriteLine($"{year} is a leap year"); }
        else { System.Console.WriteLine($"{year} is not a leap year"); }
    }
}