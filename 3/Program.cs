using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = new Random().Next(100, 1000);
        int sum = number.ToString().Select(x => x - '0').
            Cast<int>().Sum();
        int mul = number.ToString().Select(x => x - '0').
            Cast<int>().Aggregate((result, value) => result * value);
        Console.WriteLine("Число: {0}\nСумма: {1}\nПроизведение: {2}",
            number, sum, mul);
        Console.ReadKey(true);
    }
}