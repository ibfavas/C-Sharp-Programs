namespace HCF{

    //Find HCF or GCD of two numbers
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter first number:");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2=int.Parse(Console.ReadLine());

            int result=FindGCD(num1,num2);
            Console.Write($"HCF of {num1} & {num2} is {result}.");
        }

        static int FindGCD(int x,int y){
            while(y!=0){
                int temp=y;
                y=x%y;
                x=temp;
            }
            return x;
        }
    }
}