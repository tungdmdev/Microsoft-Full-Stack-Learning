using System;

public class Program
{
    // Function to calculate the area of a circle
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static void Main()
    {
        // Prompt the user to input the radius
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }
}

// Trapezoid Area Calculation
public class Program
{
    // Function to calculate the area of a trapezoid
    static double CalculateTrapezoidArea(double a, double b, double height)
    {
        return (a + b) / 2 * height;
    }

    public static void Main()
    {
        // Prompt the user to input the length of the first parallel side (a)
        Console.WriteLine("Enter the length of the first parallel side (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the length of the second parallel side (b)
        Console.WriteLine("Enter the length of the second parallel side (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the height of the trapezoid
        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateTrapezoidArea(a, b, height);

        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}