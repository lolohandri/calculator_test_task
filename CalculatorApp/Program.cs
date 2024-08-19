using CalculatorApp;

Calculator calculator = new();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\t\t\t______Welcome to the Strategy Pattern Calculator!_____");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("_____HOW TO USE_____");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Enter two numeric values and select proposed mathematical operator.\nEnter floating-point number with ',' sign.\n");

while (true)
{
    try
    {
        Console.Write("Enter the first number: ");
        var num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        var num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /): ");
        var operation = Console.ReadLine();
        if (operation == null)
        {
            throw new InvalidOperationException("Invalid operation!");
        }
        calculator.SetOperation(operation);

        var result = calculator.Calculate(num1, num2);
        Console.WriteLine($"The result is: {result}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter numeric values.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Do you want to perform another calculation? (no or n to exit): ");
    var continueCalc = Console.ReadLine()?.ToLower() ?? "no";

    if (continueCalc is "no" or "n")
    {
        break;
    }
}

Console.WriteLine("Thank you for using the calculator. Goodbye!");