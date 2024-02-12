using System.Collections.Generic;
public class Program
{
    public static List<String> tasks = new List<string>();
    static void Main(string[] args)
    {
        writeList();
        tasks.Add("Mow lawn");
        tasks.Add("Pay taxes");
        writeList();
        tasks.Remove("Mow lawn");
        tasks.Add("Shopping");
        writeList();

    }
    public static void writeList()
    {
        Console.WriteLine("Amount of tasks: " + tasks.Count);
        foreach (String task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}