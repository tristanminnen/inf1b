    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the person's name?");
            string name = Console.ReadLine();
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Happy birthday to you!");
                if (i == 2)
                {
                    Console.WriteLine($"Happy birthday dear {name}");
                }
            }
        }
    }