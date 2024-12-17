using System;

class Program {
    static void Main() {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        string reversed = Reverse(input);

        if (reversed==input){
            Console.WriteLine("Palindrome");
        }
        else
            Console.WriteLine("Not a palindrome");
    }

    static string Reverse(string str) {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
