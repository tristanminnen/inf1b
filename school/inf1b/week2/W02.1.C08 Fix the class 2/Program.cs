class PlayingCard
{
    public string Suit;
    public string Rank;

    public PlayingCard(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string Description() => $"The {Rank} of {Suit}";
}

class Program
{
    public static void Main()
    {
        PlayingCard card = new PlayingCard("Spades", "Ace");
        Console.WriteLine(card.Description());
    }
}