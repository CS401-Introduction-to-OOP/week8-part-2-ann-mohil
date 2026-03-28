namespace Week8;

class Program
{
    public static void Main()
    {
        Point p1 = new Point{X = 1, Y = 2};
        Point p2 = p1;

        p2.X = 10;
        Console.WriteLine($"p1 ({p1.X}; {p1.Y}), p2 ({p2.X}; {p2.Y})");
        
        Console.WriteLine();

        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;

        r2.X = 10;
        Console.WriteLine($"r1 ({r1.X}; {r1.Y}), r2 ({r2.X}; {r2.Y})");
        
        Console.WriteLine();
        
        BoxingTester.Test();
    }
    
}