namespace FibonacciSeries{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the number of terms:");
            int n = int.Parse(Console.ReadLine());

            int a=0,b=1;

            Console.Write("Fibonacci Series: ");

            for(int i=0;i<n;i++){
                int temp=a;
                a=b;
                b=temp+b;
                Console.Write(a+" ");
            }
        }
    }
}