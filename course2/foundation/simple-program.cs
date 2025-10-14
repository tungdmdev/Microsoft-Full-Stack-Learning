// Creating a Simple Calculator
public class Calculator
{
    public static int number1;
    public static int number2;

    public static int Add()
    {
        return number1 + number2;
    }
}

// Executing the Calculator Program
public class Calculator
{
    public static int number1 = 5;
    public static int number2 = 10;

    public static int Add()
    {
        return number1 + number2;
    }

    public static void Main(string[] args)
    {
        int result = Add();
        Console.WriteLine("The sum is: " + result);
    }
}

// Creating a Loop to Display Numbers

public class NumberDisplay
{
    public static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        DisplayNumbers();
    }
}

// Handling User Input
public class UserInput
{
    public static void GreetUser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main(string[] args)
    {
        GreetUser();
    }
}