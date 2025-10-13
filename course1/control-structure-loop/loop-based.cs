// Using a For Loop to Calculate Total Scores
using System;

public class Program
{
    public static void Main()
    {
        int[] scores = { 85, 90, 78, 92, 88 };
        int total = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            total += scores[i];
        }

        Console.WriteLine("Total score: " + total);

    }
}

// Using a While Loop to Calculate Factorials		
public class Program
{
    public static void Main()
    {
        int number = 5;
        int factorial = 1;

        while (number > 0)
        {
            factorial *= number;
            number--;
        }

        Console.WriteLine("Factorial: " + factorial);
    }
}

// Combining Loops and If-Else to Determine Pass or Fail
public class Program
{
    public static void Main()
    {
        int[] studentScores = { 45, 60, 72, 38, 55 };

        for (int i = 0; i < studentScores.Length; i++)
        {
            if (studentScores[i] >= 50)
            {
                Console.WriteLine(studentScores[i] + " - Pass");
            }
            else
            {
                Console.WriteLine(studentScores[i] + " - Fail");
            }
        }
    }
}

// Combining Loops and Switch Statements for Task Scheduling
public class Program
{
    public static void Main()
    {
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        for (int i = 0; i < weekDays.Length; i++)
        {
            switch (weekDays[i])
            {
                case "Monday":
                    Console.WriteLine("Team Meeting");
                    break;
                case "Tuesday":
                    Console.WriteLine("Code Review");
                    break;
                case "Wednesday":
                    Console.WriteLine("Development");
                    break;
                case "Thursday":
                    Console.WriteLine("Testing");
                    break;
                case "Friday":
                    Console.WriteLine("Deployment");
                    break;
                default:
                    Console.WriteLine("No task assigned.");
                    break;
            }
        }
    }
}

