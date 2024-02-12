public class Program
{
    static void Main(string[] args)
    {
        Random predictable1 = new Random(1);
        Random predictable2 = new Random(1);
        Random predictable4 = new Random(1);

        int p1n1 = predictable1.Next(10);
        int p1n2 = predictable1.Next(10);

        int p2n1 = predictable2.Next(10);
        int p2n2 = predictable2.Next(10);

        int p3n1 = predictable4.Next(10);
        int p3n2 = predictable4.Next(40);

        Console.WriteLine(p1n1);
        Console.WriteLine(p1n2);
        Console.WriteLine(p2n1);
        Console.WriteLine(p2n2);
        Console.WriteLine(p3n1);
        Console.WriteLine(p3n2);
    }
}