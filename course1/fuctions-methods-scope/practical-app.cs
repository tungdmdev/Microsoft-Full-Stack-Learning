// Defining and Calling a Simple Method
using System;

public class Program
{
    // Define the method
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Call the method inside Main
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
    }

}

// Creating a Method with Parameters
public class Program
{
    // Define the method with a parameter
    public static void GreetUser(string name)
    {
        Console.WriteLine("Hello " + name + "!");
    }

    // Call the method inside Main
    static void Main(string[] args)
    {
        GreetUser("Alice");
    }
}

// Using Methods with Return Values
public class Program
{
    // Define the method that returns a value
    public static int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Call the method inside Main and store the result
    static void Main(string[] args)
    {
        int sum = CalculateSum(5, 7);
        Console.WriteLine("Sum: " + sum);
    }
}

// Combining Methods and Conditional Logic
public class Program
{
    // Define the method that returns a boolean
    public static bool IsPositive(int num)
    {
        if (num > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Call the method inside Main and use if-else
    static void Main(string[] args)
    {
        int number = 5;
        bool result = IsPositive(number);
        if (result)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }
    }
}

// Practical Application – User Age Validation
public class Program
{
	// Define the method that checks if the user is old enough to drive
	public static bool IsOldEnoughToDrive(int age) {
		if (age >= 18) {
			return true;
		} else {
			return false;
		}
	}

	// Call the method inside Main and check if the user is old enough to drive
	static void Main(string[] args) {
		Console.WriteLine("Enter your age:");
		int age = int.Parse(Console.ReadLine());
		bool canDrive = IsOldEnoughToDrive(age);
		if (canDrive) {
			Console.WriteLine("You are old enough to drive.");
		} else {
			Console.WriteLine("You are not old enough to drive.");
		}
	}
}