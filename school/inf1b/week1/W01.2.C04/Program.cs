public class Program
{
    static void Main(string[] args)
    {
        int pin = 0;
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine("Enter your PIN");
            Console.WriteLine($"{i} attempts left");
            pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 1234)
            {
                Console.WriteLine("Correct!");
                break;
            }
            if (i == 1)
            {
                Console.WriteLine("Your pass is confiscated.");
            }

        }
    }
}