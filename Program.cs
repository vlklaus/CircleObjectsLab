using _051024_Circle_Objects_Lab;

Console.WriteLine("Welcome to the Circle Tester");


Console.Write("Enter radius: ");
double userRadius;
while (double.TryParse(Console.ReadLine(), out userRadius) == false || userRadius < 0.1)
{
    Console.WriteLine("Please enter a valid number.");
}

Circle value = new Circle(userRadius);

Console.WriteLine($"Diameter: {value.CalculateDiameter()}");
Console.WriteLine($"Circumference: {value.CalculateCircumference()}");
Console.WriteLine($"Area: {value.CalculateArea()}");


bool increaseCircle = true;
while (increaseCircle)
{
    Console.WriteLine("Should the circle grow? y/n");
    string growCircle = Console.ReadLine();

    if (growCircle == "y")
    {
        value.Grow();

        Console.WriteLine($"Diameter: {value.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {value.CalculateCircumference()}");
        Console.WriteLine($"Area: {value.CalculateArea()}");
        break;
    } else if (growCircle == "n")
    {
        increaseCircle = false;
        break;
    } else
    {
        Console.WriteLine("Invalid response.");
    }
}

Console.WriteLine($"Goodbye. The circle's final radius is {value.GetRadius()}");
