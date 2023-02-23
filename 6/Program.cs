namespace зд6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y;
            int x = 1.3;
            y = 2 * Math.Pow(Math.Atan(Math.Sqrt(Math.Exp(x) + 1)), 2) + Math.Abs(x);
            Console.WriteLine($"y = {y}");
            Console.Read();
        }
    }
}
