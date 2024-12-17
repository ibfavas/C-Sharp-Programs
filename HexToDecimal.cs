namespace HexToDeciaml{
    class Program {
    static void Main() {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();
        int decimalNum = Convert.ToInt32(hex, 16);
        Console.WriteLine($"Decimal: {decimalNum}");
    }
}
}