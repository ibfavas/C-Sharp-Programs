namespace SumOfNumbersInRange{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the starting number:");
            int start=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending number");
            int end=int.Parse(Console.ReadLine());
            int sum=0;

            for(int i=start;i<=end;i++){
            sum+=i;
            }

            Console.WriteLine($"Sum of numbers fron {start} to {end} is {sum}");
        }
    }
}