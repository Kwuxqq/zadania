using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());


        double result1 = a + (b + c);
        double result2 = a + c + b;


        Console.WriteLine("(a+(b+c)) = {0:F4}", result1);
        Console.WriteLine("(a+c+b) = {0:F4}", result2);
    }
}
