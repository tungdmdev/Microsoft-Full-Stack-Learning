public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("Operation started...");
        await Task.Delay(3000); // Simulate a delay of 3 seconds
        Console.WriteLine("Operation completed.");
    }
    public static void Main(string[] args)
    {
        // Calling the asynchronous method
        Task.Run(async () => await PerformLongOperationAsync()).Wait();
        Console.WriteLine("Main method completed.");
    }
    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("Operation started..."); // Simulate a breakpoint
        await Task.Delay(3000); // Simulate a delay of 3 seconds
        Console.WriteLine("After await..."); // Simulate a breakpoint
        Console.WriteLine("Operation completed.");
    }
    public static async Task PerformLongOperationAsync()
    {
        try
        {
            Console.WriteLine("Operation started...");
            await Task.Delay(3000); // Simulate a delay
            throw new InvalidOperationException("Simulated long operation error.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}