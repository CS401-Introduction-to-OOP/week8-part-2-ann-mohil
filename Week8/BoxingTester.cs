namespace Week8;

public class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        object unb = (int)b;
        
        Console.WriteLine($"Value: {a}");
        Console.WriteLine($"Boxed value: {b}");
        Console.WriteLine($"Unboxed value: {unb}");
        
        //line 7: 'a' on the stack
        //line 8: boxing: value -> reference type (copy from stack to heap)
        //line 9: unboxing: reference -> value type (copy from heap to stack)


    }
}