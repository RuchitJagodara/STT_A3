using System;

public class Part3
{
    public static void Main3()
    {
        // For loop to print numbers from 1 to 10
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // While loop: ask the user for a number to calculate its factorial or "exit" to stop
        Console.WriteLine("Enter a non-negative integer to calculate its factorial or type 'exit' to quit.");
        while (true)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int number) && number >= 0)
            {
                long result = Factorial(number);
                Console.WriteLine($"Factorial of {number} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer or 'exit'.");
            }
        }

        Console.WriteLine("Program terminated.");
    }

    // Function to calculate the factorial of a number
    private static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
