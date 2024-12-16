namespace PositiveOrNegetiveNum{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter a number:");
            int num=int.Parse(Console.ReadLine());

            if(num>0){
                Console.WriteLine($"{num} is Positive");
            }else if(num==0){
                Console.WriteLine("Zero");
            } 
            else{
                Console.WriteLine($"{num} is Negetive");
            }
        }
    }
}