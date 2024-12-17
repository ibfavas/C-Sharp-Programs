using System;

//Finding Number of Times a Digit Occurs in an Integer

class Program {
    static void Main() {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the digit to count: ");
        int digit = int.Parse(Console.ReadLine());

        int count = 0;
        while (number > 0) {
            if (number % 10 == digit) count++;
            number /= 10;
        }
        Console.WriteLine($"Digit occurs {count} times.");
    }
}
