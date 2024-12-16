namespace ReverseANumber{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int temp=num;

            int reverse=0;
            while (num>0){
                reverse=reverse*10 + num%10;
                num=num/10;
            }
            Console.WriteLine($"Reverse of {temp} is {reverse}");
        }
    }
}