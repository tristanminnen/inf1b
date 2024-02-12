public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("give first name");
        string first = Console.ReadLine();
        System.Console.WriteLine("give last name");
        string last = Console.ReadLine();
        DisplayName(first, last);
    }
    public static string Name(string first, string last) => first + " " + last;
    public static void DisplayName(string first, string last) => System.Console.WriteLine(Name(first, last));
}
