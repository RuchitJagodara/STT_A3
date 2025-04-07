using System;

public class Calculator
{
    public double Number1 { get; set; }
    public double Number2 { get; set; }

    public Calculator(double num1, double num2)
    {
        Number1 = num1;
        Number2 = num2;
    }

    public double Add() => Number1 + Number2;
    public double Subtract() => Number1 - Number2;
    public double Multiply() => Number1 * Number2;
    public double Divide() => Number2 != 0 ? Number1 / Number2 : double.NaN;
}

public class Program
{
    public static void Main11()
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

        Calculator calc = new Calculator(n1, n2);

        // Perform arithmetic operations
        double sum = calc.Add();
        double difference = calc.Subtract();
        double product = calc.Multiply();
        double quotient = calc.Divide();

        Console.WriteLine($"Addition: {n1} + {n2} = {sum}");
        Console.WriteLine($"Subtraction: {n1} - {n2} = {difference}");
        Console.WriteLine($"Multiplication: {n1} * {n2} = {product}");
        if (n2 != 0)
        {
            Console.WriteLine($"Division: {n1} / {n2} = {quotient}");
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero.");
        }

        // Check if the sum is even or odd
        // Casting the result to int for the check, as even/odd applies to integers.
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
