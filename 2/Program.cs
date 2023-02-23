using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Введите четырехзначное число: ");
        int num = int.Parse(Console.ReadLine());

        int d1 = num / 1000;
        int d2 = (num / 100) % 10;
        int d3 = (num / 10) % 10;
        int d4 = num % 10;


        int result = d2 * 1000 + d1 * 100 + d4 * 10 + d3;


        Console.WriteLine("Число, образуемое при перестановке первой и второй, третьей и четвертой цифр {0}", result);
    }
}
