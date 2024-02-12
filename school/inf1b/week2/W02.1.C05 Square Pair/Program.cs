class Program
{
    public static void Main()
    {
        Square sq1 = new Square(5);
        Square sq2 = new Square(10);
        System.Console.WriteLine(sq1.Side);
        System.Console.WriteLine(sq1.Area());
        System.Console.WriteLine(sq1.Perimeter());

        System.Console.WriteLine(sq2.Side);
        System.Console.WriteLine(sq2.Area());
        System.Console.WriteLine(sq2.Perimeter());
    }
}

class Square
{
    public int Side;
    public Square(int side)
    {
        this.Side = side;
    }

    public int Area() => this.Side * this.Side;
    public int Perimeter() => 4 * this.Side;
}