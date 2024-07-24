
using ConsoleApp1;

    internal class Program
{
    static void Main(string[] args)
    {
        //Employee employee = new Employee("Vismay", "Rathore");
        Employee employee = new();
        var result = employee.FullName();
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
    
