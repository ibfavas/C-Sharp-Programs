namespace FactorsOfANum{
    class Program{
        static void Main(string [] args){

            Console.WriteLine("Enter a number:");
            int num=int.Parse(Console.ReadLine());

            Console.Write("Factors: ");
            for(int i=1;i<=num;i++){
                if(num % i==0)
                Console.Write(i+" ");
            }
        }
    }
}