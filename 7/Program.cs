double z1;
double z2;
int a;
Console.Write("Enter a -> ");
a = Convert.ToInt32(Console.ReadLine());
z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
z2 = 2 * Math.Sin(a);
Console.WriteLine($"z1 = {z1} | z2 = {z2}");
Console.ReadKey();
