using System;

class Program {
    static void Main() {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = "";

        foreach (char c in input) {
            if (Char.IsUpper(c))
                result += Char.ToLower(c);
            else if (Char.IsLower(c))
                result += Char.ToUpper(c);
            else
                result += c;
        }
        Console.WriteLine($"Toggled string: {result}");
    }
}
