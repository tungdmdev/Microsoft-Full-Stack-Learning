// if-else statement
int grade;
Console.WriteLine("Enter the student's grade; ");
grade = int.Parse(Console.ReadLine());
if (grade >= 50)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}

// Switch Statement
int score;
Console.WriteLine("Enter the student's score: ");
score = int.Parse(Console.ReadLine());
switch (score / 10)
{
    case 10:
    case 9:
        Console.WriteLine("A");
        break;
    case 8:
        Console.WriteLine("B");
        break;
    case 7:
        Console.WriteLine("C");
        break;
    case 6:
        Console.WriteLine("D");
        break;
    default:
        Console.WriteLine("F");
        break;
}