namespace SumOfnNaturalNumbers{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the value of n:");

            int n=int.Parse(Console.ReadLine());
            int sum= n*(n+1)/2;

            Console.WriteLine($"Sum of {n} numbers is {sum}");
        }
    }
}