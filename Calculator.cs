using System;

class AdvancedCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Advanced Calculator");

        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select operation (+, -, *, /, sqrt, square, cube):");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            case "sqrt":
                if (num1 >= 0)
                    result = Math.Sqrt(num1);
                else
                    Console.WriteLine("Error: Cannot calculate square root of a negative number");
                break;
            case "square":
                result = num1 * num1;
                break;
            case "cube":
                result = num1 * num1 * num1;
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        Console.WriteLine($"Result: {result}");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
