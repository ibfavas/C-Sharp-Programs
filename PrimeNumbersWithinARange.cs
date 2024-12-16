using System.Runtime.CompilerServices;

namespace PrimeNumbersWithinARange{

    // Print Prime Numbers Within A Range
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the starting number:");
            int start=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending number:");
            int end=int.Parse(Console.ReadLine());

            for(int i=start;i<=end;i++){
                bool isPrime=i>1;
                for(int j=2;j*j<=i;j++){
                    if(i%j==0){
                        isPrime=false;
                        break;
                    }
                }
                if(isPrime){
                    Console.WriteLine(i);
                }
            }
        }
    }
}