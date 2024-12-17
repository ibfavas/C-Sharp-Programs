namespace PerfectNumber{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int sum=0;

            for(int i=1;i<num;i++){
                if(num%i==0){
                    sum = sum+i;
                }
            }

            // EX: 6 is divisible by 1,2,3. Sum of 1+2+3=6. So 6 is a perfect number.

            Console.WriteLine(sum == num ? "Perfect Number" : "Not a Perfect Number");
        }
    }
}