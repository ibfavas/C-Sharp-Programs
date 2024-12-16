using System;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} is the largest.");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} is the largest.");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"{c} is the largest.");
            }
            else
            {
                Console.WriteLine("There is no single largest number; two or more numbers are equal.");
            }

            Console.ReadKey();
        }
    }
}