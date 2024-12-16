using System;

namespace SimpleCalculator
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / (double)num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
