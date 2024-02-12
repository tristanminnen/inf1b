public class Program
{

    public static void Main(string[] args)
    {
        PrintFullName("John", "Doe");
    }

    public static void PrintFullName(string first, string last)
    {
        System.Console.WriteLine($"{first} {last}");
    }
}