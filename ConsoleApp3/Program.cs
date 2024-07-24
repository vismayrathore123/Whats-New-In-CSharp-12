

internal class ConsoleApp3
{
    static void Main(string[] args)
    {
        int myNumber = 10;
        DisplayValue(ref myNumber);
        Console.WriteLine(myNumber);
        Console.ReadLine();
    }
    static void DisplayValue(ref int number)
    {
        Console.WriteLine($"Value:{number}");
        number++;
    }
}