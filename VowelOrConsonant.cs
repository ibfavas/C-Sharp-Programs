using System;

class Program {
    static void Main() {
        Console.Write("Enter a character: ");
        char ch = Char.ToLower(Console.ReadLine()[0]);
        Console.WriteLine();

        if ("aeiou".Contains(ch)) 
            Console.Write("Vowel");
        else if (Char.IsLetter(ch))
            Console.Write("Consonant");
        else
            Console.Write("Not a letter");
    }
}
