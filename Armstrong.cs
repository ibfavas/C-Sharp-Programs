namespace Armstrong{
    class Problem{
        static void Main(string[] args){

            Console.WriteLine("Enter the number:");
            int num=int.Parse(Console.ReadLine());

            int sum=0, temp=num;

            while(temp>0){
                int digit=temp%10;
                sum += digit*digit*digit;
                temp=temp/10;
            }

            if(sum==num){
                Console.WriteLine($"{num} is an Armstrong Number.");
            }else{
                Console.WriteLine($"{num} is not an Armstrong Number.");
            }

        }
    }
}