int age;
Console.WriteLien("Enter your age: ");
age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLien("Access granted.");
}
else
{
    Console.WriteLine("Access denied.");
}