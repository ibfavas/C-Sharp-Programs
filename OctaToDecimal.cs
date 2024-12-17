namespace OctaToDecimal{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter an octa number:");
            string octal=Console.ReadLine();

            int dec=Convert.ToInt32(octal,8);
            Console.WriteLine($"Result = {dec}");
        }
    }
}