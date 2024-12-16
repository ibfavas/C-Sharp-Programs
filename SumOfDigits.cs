namespace SumOfDigits{
    // Find the sum of digits in a number

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the number:");
            int num=int.Parse(Console.ReadLine());
            int temp=num;

            int sum=0;

            while(num>0){
                sum+=num%10;
                num/=10;
            }

            Console.Write($"The sum of the digits in {temp} is {sum}");
        }
    }
}