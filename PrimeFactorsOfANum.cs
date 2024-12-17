namespace PrimeFactorsOfANum{
class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime Factors: ");
        for (int i = 2; i <= num; i++) {
            while (num % i == 0) {
                Console.Write(i + " ");
                num /= i;
            }
        }
    }
}

}