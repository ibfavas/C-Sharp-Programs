namespace Fibonacci_nth_Term{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the position of Fibonacci term:");
            int n=int.Parse(Console.ReadLine());

            int a=0,b=1;

            for(int i=2;i<=n;i++){
                int temp = a+b;
                a=b;
                b = temp;
            }
            Console.WriteLine($"The {n}th term is {b}");
        }
    }
}