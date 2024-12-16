namespace PalindromeNum{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the number:");
            int num=int.Parse(Console.ReadLine());

            int temp=num;
            int reverse=0;

            while(num>0){
                reverse=reverse*10 + num%10;
                num=num/10;
            }

            if(temp==reverse){
                Console.WriteLine($"{temp} is a Palindrome Number.");
            }else{
                Console.WriteLine($"{temp} is not a Palindrome Number.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}