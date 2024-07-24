// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        var GetSquare = (int number=10) => number * number;
        Console.WriteLine(GetSquare(5));
        Console.WriteLine(GetSquare());
    }
}
