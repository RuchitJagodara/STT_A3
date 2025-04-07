using System;

public class Calculator_new
{
    public double Number1 { get; set; }
    public double Number2 { get; set; }

    public Calculator_new(double num1, double num2)
    {
        Number1 = num1;
        Number2 = num2;
    }

    public double Add() => Number1 + Number2;
    public double Subtract() => Number1 - Number2;
    public double Multiply() => Number1 * Number2;

    public double Divide()
    {
        if (Number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return Number1 / Number2;
    }
}

public class Part5
{
    public static void Main12()
    {
        Console.Write("Enter the first number: ");
        double n1;
        while (!double.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Please enter a valid number.");
            Console.Write("Enter the first number: ");
        }

        Console.Write("Enter the second number: ");
        double n2;
        while (!double.TryParse(Console.ReadLine(), out n2))
        {
            Console.WriteLine("Please enter a valid number.");
            Console.Write("Enter the second number: ");
        }

        Calculator_new calc = new Calculator_new(n1, n2);

        // Perform arithmetic operations
        double sum = calc.Add();
        double difference = calc.Subtract();
        double product = calc.Multiply();

        Console.WriteLine($"Addition: {n1} + {n2} = {sum}");
        Console.WriteLine($"Subtraction: {n1} - {n2} = {difference}");
        Console.WriteLine($"Multiplication: {n1} * {n2} = {product}");

        // Use try-catch around division to handle division-by-zero
        try
        {
            double quotient = calc.Divide();
            Console.WriteLine($"Division: {n1} / {n2} = {quotient}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Division error: {ex.Message}");
        }

        // Check if the sum is even or odd
        // Casting the result to int for the check, as even/odd applies to integers
        if (((int)sum) % 2 == 0)
        {
            Console.WriteLine("The sum is even.");
        }
        else
        {
            Console.WriteLine("The sum is odd.");
        }
    }
}
