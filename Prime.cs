namespace Prime{
    class Program{
         static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int num=int.Parse(Console.ReadLine());

            bool isPrime = num>1;
            for(int i=2; i*i<=num;i++){
                if(num%i==0){
                    isPrime = false;
                    break;
                }
            }
            if(isPrime){
                Console.WriteLine($"{num} is Prime");
            }else{
                Console.WriteLine($"{num} is not Prime");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
         }
    }
}