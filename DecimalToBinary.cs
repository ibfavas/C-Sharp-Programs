class D2B{
    static void Main(){
        Console.Write("Enter a decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(decimalNum, 2);
        
        Console.WriteLine($"Binary: {binary}");
    
    }
}