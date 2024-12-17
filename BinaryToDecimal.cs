namespace BinaryToDecimal{
    class B2D{
        static void Main(string[] args){

            Console.WriteLine("Enter a binary number:");
            string binary = Console.ReadLine();

            int decimalnum=Convert.ToInt32(binary,2);
            Console.WriteLine($"Result = {decimalnum}");
        }
    }
}