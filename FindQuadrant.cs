namespace FindQuadrant{

class Program {
    static void Main(string[] args) {
        Console.Write("Enter x coordinate: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("First Quadrant");
        else if (x < 0 && y > 0)
            Console.WriteLine("Second Quadrant");
        else if (x < 0 && y < 0)
            Console.WriteLine("Third Quadrant");
        else if (x > 0 && y < 0)
            Console.WriteLine("Fourth Quadrant");
        else
            Console.WriteLine("Origin or Axis");
    }
}

}