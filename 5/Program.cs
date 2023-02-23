using System;

namespace C
{
    struct Cylinder
    {
        public double H { get; init; }
        public double R { get; init; }
        public Cylinder(double h, double r)
        {
            H = h;
            R = r;
        }
        public double V() => 2 * Math.PI * R * H;
        public double S() => 2 * Math.PI * R * (R + H);
        public override string ToString() => $"H = {H}; R = {R}; S = {S().ToString("0.###")}; V={V().ToString("0.###")}";
    }
    class LazyStudent
    {
        static void Main(string[] args)
        {
            var c = new Cylinder(5, 6);
            Console.WriteLine(c.ToString());
            c = new Cylinder() { H = 6, R = 5 };
            Console.WriteLine(c.ToString());
        }
    }
}