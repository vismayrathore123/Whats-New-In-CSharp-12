internal class Program
{
    static void Main(string[] args)
    {
        var buffer = new Buffer(10); // Create a buffer with size 10

        // Populate the buffer
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i;
        }

        // Display the elements of the buffer
        foreach (var i in buffer)
        {
            Console.WriteLine(i);
        }
    }
}
