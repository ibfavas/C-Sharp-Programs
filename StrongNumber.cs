namespace StrongNumber{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int sum=0,temp=num;

            while(temp>0){
                int digit=temp%10;
                sum+=Factorial(digit);
                temp=temp/10;
            }
            Console.WriteLine(sum==num ? "Strong Number" : "Not a Strong Number");
        }

    static int Factorial(int n){
        int fact=1;
        for(int i=1;i<=n;i++)
        fact=fact*i;
        return fact;
    }
}
}