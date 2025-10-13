// for loops
for (int i = 0; i < 5; i++)
{
    console.WriteLine(i);
}

// array for loops
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

// While loops
int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

// While loops
string input = "";
while (input != "exit")
{
    Console.WriteLine("Enter a command:");
    input = Console.ReadLine();
}

// Do-While loops
int counter = 10;
do
{
    Console.WriteLine(counter);
    counter++;
}
while (counter < 10);

// Combine Loop and If-else
// Number is odd or even
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i] + " is even.");
    }
    else
    {
        Console.WriteLine(numbers[i] + " is odd.");
    }
}
// loop and switch
string[] weatherForecasts = { "sunny and warm", "rainy with thunderstorms", "cloudy and cold" };

for (int i = 0; i < weatherForecasts.Length; i++)
{
    switch (weatherForecasts[i])
    {
        case "sunny and warm":
            Console.WriteLine("Today will be " + weatherForecasts[i] + " so bring your sunglasses.");
            break;
        case "rainy with thunderstorms":
            Console.WriteLine("Today will be " + weatherForecasts[i] + " so bring your umbrella.");
            break;
        case "cloudy and cold":
            Console.WriteLine("Today will be " + weatherForecasts[i] + " so wae warm clothes.");
            break;
    }
}

// Practical loop: GroovEco Update
double[] prices = { 10.00, 15.00, 8.25, 22.00 };
for (int i = 0; i < prices.Length; i++)
{
    prices[i] = prices[i] * 1.05;
    Console.WriteLine("New price for product " + i + ": " + prices[i]);
}

// Validating user input
int input;
do
{
    Console.WriteLine("Enter a number between 1 and 10:");
    input = int.Parse(Console.ReadLine());
    if (input >= 1 && input <= 10)
    {
        Console.WriteLine("Valid input: " + input);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}
while (true);

// Grade pass or fail
int[i] grades = { 85, 92, 78, 64, 89 };
for (int i = 0; i < grades.Length; i++) ;
{
    int grade = grades;
    string result;
    if (grade >= 65)
    {
        result = "Pass";
    }
    else
    {
        result = "Fail";
    }
    Console.WriteLine(result);
}

//Order by status
string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled" };
for (int i = 0; i < orderStatuses.Length; i++)
{
    string status = orderStatuses[i];
    switch (status)
    {
        case "Pending":
            Console.WriteLine("Order is pending.");
            break;
        case "Shipped":
            Console.WriteLine("Order has been shipped.");
            break;
        case "Delivered":
            Console.WriteLine("Order has ben delivered.");
            break;
        case "Cancelled":
            Console.WriteLine("Order has been cancelled.");
            break;
        default:
            Console.WriteLine("Unknown status.");
            break;
    }
}

// Grade evaluation
int[] grades = { 95, 82, 63, 75, 58 };
for (int i = 0; i < grades.Length; i++)
{
    int grade = grades[i];
    switch (grade)
    {
        case int n when (n >= 90):
            Console.WriteLine("Grade A: Excellent!");
            break;
        case int n when (n >= 80):
            Console.WriteLine("Grade B: Good job!");
            break;
        case int n when (n >= 70):
            Console.WriteLine("Grade C: Fair!");
            break;
        case int n when (n >= 60):
            Console.WriteLine("Grade D: Needs improvement!");
            break;
        default:
            Console.WriteLine("Grade F: Fail.");
            break;
    }
}

// Using If-Else to Evaluate Grades
int[] grades = { 85, 92, 78, 64, 89 };

for (int i = 0; i < grades.Length; i++) {
    int grade = grades[i];
    string result;
    if (grade >= 65) {
        result = "Pass";
    } else {
        result = "Fail";
    }
    Console.WriteLine($"Score: {grade} Result: {result}");
}