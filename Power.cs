namespace Power{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter the base:");
            int basenum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponent:");
            int expo = int.Parse(Console.ReadLine());

            int result=1;

            for(int i=0;i<expo;i++){
                result = result*basenum;
            }

            Console.WriteLine($"Result is {result}");

        }
    }
}