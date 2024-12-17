using System;

class Program {
    static void Main() {
        Console.Write("Enter an integer: ");
        string num = Console.ReadLine();
        string result = num.Replace('0', '1');
        Console.WriteLine($"Result: {result}");
    }
}
