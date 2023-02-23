using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Enter the radius (cm): ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        double height = double.Parse(Console.ReadLine());

        double surfaceArea = 2 * Math.PI * radius * (radius + height);

        Console.WriteLine("Surface area of the cylinder: {0:F2} cm^2", surfaceArea);
    }
}
