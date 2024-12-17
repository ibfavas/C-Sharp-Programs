namespace Permutations{
    class nPr{
        static void Main(){

            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter r:");
            int r = int.Parse(Console.ReadLine());

            int result = Factorial(n) / Factorial (n-r);
            Console.Write($"Permutaion Result = {result}");
        }

        static int Factorial(int num){
            int fact=1;
            for(int i=1;i<=num;i++)
                fact=fact*i;
            return fact;
        }
    }
}