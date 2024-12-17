using System;

class Program {
    static void Main() {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        int count = 0;

        foreach (char c in input) {
            if ("aeiou".Contains(c)) count++;
        }
        Console.WriteLine($"Number of vowels: {count}");
    }
}
