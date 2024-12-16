using System.Globalization;

namespace ArmstrongNumInGivenRange{
    class Program {
    static void Main() {
        Console.Write("Enter the start of range: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of range: ");
        int end = int.Parse(Console.ReadLine());
        for (int i = start; i <= end; i++) {
            int sum = 0, temp = i;
            while (temp > 0) {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            if (sum == i)
                Console.WriteLine(i);
        }
    }
    }
}