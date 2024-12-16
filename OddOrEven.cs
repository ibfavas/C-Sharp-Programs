namespace OddOrEven{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter a number:");
            int num;
            num=int.Parse(Console.ReadLine());

            if(num%2==0){
                Console.WriteLine($"{num} is Even");
            }else{
                Console.WriteLine($"{num} is Odd");
            }
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}