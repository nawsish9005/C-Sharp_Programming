using System;
class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}
class Program
{
    static void Main()
    {
        int sum = MathHelper.Add(5, 10);
        int product = MathHelper.Multiply(5, 10);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
